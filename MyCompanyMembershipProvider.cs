using System;
using System.Web.Security;

namespace MyCompany.Security
{
    public class MyCompanyMembershipProvider : MembershipProvider
    {
        public override string ApplicationName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new System.NotImplementedException();
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new System.NotImplementedException();
        }

        public override bool EnablePasswordReset
        {
            get { throw new System.NotImplementedException(); }
        }

        public override bool EnablePasswordRetrieval
        {
            get { throw new System.NotImplementedException(); }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            var users = GetMyCompanyUsers();
            totalRecords = users.Count;
            return users;
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new System.NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            return GetMyCompanyUser(username);
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new System.NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new System.NotImplementedException(); }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new System.NotImplementedException(); }
        }

        public override int MinRequiredPasswordLength
        {
            get { throw new System.NotImplementedException(); }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new System.NotImplementedException(); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new System.NotImplementedException(); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new System.NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { throw new System.NotImplementedException(); }
        }

        public override bool RequiresUniqueEmail
        {
            get { throw new System.NotImplementedException(); }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new System.NotImplementedException();
        }

        public override bool UnlockUser(string userName)
        {
            throw new System.NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new System.NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            return true;
        }

        private MembershipUserCollection GetMyCompanyUsers()
        {
            var anonymous = new MembershipUser(
                            "MyCompanyProvider"
                            , @"mycompany\anonymous"
                            , "MyCompany1234"
                            , "anonymous@mycompany.com"
                            , "password"
                            , "This anonymous from MyCompany"
                            , true
                            , false
                            , DateTime.Today
                            , DateTime.Now
                            , DateTime.Now
                            , DateTime.MinValue
                            , DateTime.MinValue
                        );
            var user1 = new MembershipUser(
                            "MyCompanyProvider"
                            , @"mycompany\user1"
                            , "MyCompany1234"
                            , "user1@mycompany.com"
                            , "password"
                            , "This user1 from MyCompany"
                            , true
                            , false
                            , DateTime.Today
                            , DateTime.Now
                            , DateTime.Now
                            , DateTime.MinValue
                            , DateTime.MinValue
                        );
            var user2 = new MembershipUser(
                            "MyCompanyProvider"
                            , @"mycompany\user2"
                            , "MyCompany1234"
                            , "user2@mycompany.com"
                            , "password"
                            , "This user2 from MyCompany"
                            , true
                            , false
                            , DateTime.Today
                            , DateTime.Now
                            , DateTime.Now
                            , DateTime.MinValue
                            , DateTime.MinValue
                        );
            var users = new MembershipUserCollection() { anonymous, user1, user2 };
            return users;
        }

        private MembershipUser GetMyCompanyUser(string username)
        {
            return GetMyCompanyUsers()[username.ToLower()];
        }
    }
}
