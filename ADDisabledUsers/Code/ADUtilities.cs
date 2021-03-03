using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace ADDisabledUsers.Code
{
    class ADUtilities
    {
        /// <summary>
        /// Initialize retrieving of AD users.
        /// </summary>
        /// <param name="domainController">Name of domain</param>
        /// <param name="paths">Array of paths</param>
        /// <param name="username">Username to access AD</param>
        /// <param name="password">Password for accessing AD</param>
        /// <param name="bgWorker">Background worker to be used for progress reporting</param>
        /// <param name="totalUsers">Total number of users imported.</param>
        public static List<ADUser> InitiateRetrievingADUsers(string domainController, string[] paths, string username, string password, BackgroundWorker bgWorker, ref int totalUsers)
        {
            PrincipalContext principalContext;

            var adUsers = new List<ADUser>();

            if (paths != null)
            {
                foreach (var path in paths)
                {
                    principalContext = new PrincipalContext(ContextType.Domain, domainController, path, username, password);
                    var users = GetAllADUsers(principalContext, bgWorker, ref totalUsers);
                    adUsers.AddRange(users);
                }
            }
            else
            {
                principalContext = new PrincipalContext(ContextType.Domain, domainController, username, password);
                var users = GetAllADUsers(principalContext, bgWorker, ref totalUsers);
                adUsers.AddRange(users);
            }

            return adUsers;
        }

        /// <summary>
        /// Get all AD users for specified domain and OU path.
        /// </summary>
        /// <param name="principalContext">Principal Context object</param>
        /// <param name="bgWorker">Background worker to be used for progress reporting</param>
        /// <param name="totalUsers">Total number of users imported</param>
        public static List<ADUser> GetAllADUsers(PrincipalContext principalContext, BackgroundWorker bgWorker, ref int totalUsers)
        {
            var users = new List<ADUser>();

            using (principalContext)
            {
                bgWorker.ReportProgress(0, "Looking for domain users...");

                var userPrincipal = new UserPrincipal(principalContext);
                var principalSearcher = new PrincipalSearcher(userPrincipal);
                var principals = principalSearcher.FindAll();

                foreach (var principal in principals)
                {
                    totalUsers++;
                    bgWorker.ReportProgress(0, string.Format("Retrieving user '{0}' details (Total retrieved: {1})", principal.DisplayName, totalUsers));

                    using (var deUser = principal.GetUnderlyingObject() as DirectoryEntry)
                    {
                        if (deUser != null)
                        {
                            var status = IsAccountDisabled(deUser);
                            
                            if(status)
                                users.Add(new ADUser { UserName = principal.SamAccountName, FullName = principal.DisplayName, Disabled= true});
                        }
                    }
                }

                return users;
            }
        }

        /// <summary>
        /// Get whether account is enabled or disabled.
        /// </summary>
        /// <param name="user">The directory entry user.</param>
        /// <returns>Return true if account is disabled else false.</returns>
        public static bool IsAccountDisabled(DirectoryEntry user)
        {
            const string uac = "userAccountControl";
            if (user.NativeGuid == null) return false;

            if (user.Properties[uac] != null && user.Properties[uac].Value != null)
            {
                var userFlags = (UserFlags)user.Properties[uac].Value;
                return userFlags.Contains(UserFlags.AccountDisabled);
            }

            return false;
        }
    }

    #region Helper Classes & Enum

    [Flags]
    public enum UserFlags
    {
        // Reference - Chapter 10 (from The .NET Developer's Guide to Directory Services Programming)

        Script = 1, // 0x1
        AccountDisabled = 2, // 0x2
        HomeDirectoryRequired = 8, // 0x8
        AccountLockedOut = 16, // 0x10
        PasswordNotRequired = 32, // 0x20
        PasswordCannotChange = 64, // 0x40
        EncryptedTextPasswordAllowed = 128, // 0x80
        TempDuplicateAccount = 256, // 0x100
        NormalAccount = 512, // 0x200
        InterDomainTrustAccount = 2048, // 0x800
        WorkstationTrustAccount = 4096, // 0x1000
        ServerTrustAccount = 8192, // 0x2000
        PasswordDoesNotExpire = 65536, // 0x10000 (Also 66048 )
        MnsLogonAccount = 131072, // 0x20000
        SmartCardRequired = 262144, // 0x40000
        TrustedForDelegation = 524288, // 0x80000
        AccountNotDelegated = 1048576, // 0x100000
        UseDesKeyOnly = 2097152, // 0x200000
        DontRequirePreauth = 4194304, // 0x400000
        PasswordExpired = 8388608, // 0x800000 (Applicable only in Window 2000 and Window Server 2003)
        TrustedToAuthenticateForDelegation = 16777216, // 0x1000000
        NoAuthDataRequired = 33554432 // 0x2000000
    }

    public class ADUser
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public bool Disabled { get; set; }
    }

    public static class UserFlagExtensions
    {
        /// <summary>
        /// Check if flags contains the specific user flag. This method is more efficient compared to 'HasFlag()'.
        /// </summary>
        /// <param name="haystack">The bunch of flags</param>
        /// <param name="needle">The flag to look for.</param>
        /// <returns>Return true if flag found in flags.</returns>
        public static bool Contains(this UserFlags haystack, UserFlags needle)
        {
            return (haystack & needle) == needle;
        }
    }

    #endregion

}
