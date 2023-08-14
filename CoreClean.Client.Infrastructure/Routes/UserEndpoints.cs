namespace CoreClean.Client.Infrastructure.Routes
{
    public static class UserEndpoints
    {
        public static string GetAll = "api/identity/user";
        public static string GetAllDemandes = "api/identity/user/getalldemandes";

        public static string GetAllFromNif(string Nif) => $"api/identity/user/fromNif/{Nif}";
        public static string Get(string userId)
        {
            return $"api/identity/user/{userId}";
        }

        public static string GetUserRoles(string userId)
        {
            return $"api/identity/user/roles/{userId}";
        }
        internal static string ConfirmEmail(string userId, string code)
        {
            return $"api/identity/user/confirm-email/?userId={userId}&code={code}";
        }
        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        //public static string notification(string email)
        //{
        //    return $"api/identity/user/notification/?email={email}";
        //}
        public const string RegisterIntervisaProvider = "api/identity/user/RegisterInternalVisaProvider";
        public const string ActivateInternalVisaProvider = "api/identity/user/ActivateInternalVisaProvider";
        internal static string DeleteUser(string userId)
        {
            return $"api/identity/user/delete/{userId}";
        }
        internal static string checkIfNifHasActiveUser(string nif) => $"api/identity/user/checknifusers/{nif}";



        public static string Export = "api/identity/user/export";
        public static string Register = "api/identity/user";
         public const string notification = "api/identity/user/notification";
        public static string ToggleUserStatus = "api/identity/user/toggle-status";
        public static string ForgotPassword = "api/identity/user/forgot-password";
        public static string ResetPassword = "api/identity/user/reset-password";
    }
}