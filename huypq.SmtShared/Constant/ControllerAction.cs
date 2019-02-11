namespace huypq.SmtShared.Constant
{
    public class ControllerAction
    {
        public class Smt
        {
            public const string ControllerName = "smt";
            public const string Register = "register";
            public const string TenantLogin = "tenantlogin";
            public const string TenantLoginWithIdToken = "tenantloginwithidtoken";
            public const string UserLogin = "userlogin";
            public const string TenantRequestToken = "tenantrequesttoken";
            public const string UserRequestToken = "userrequesttoken";
            public const string LockUser = "lockuser";
            public const string ChangePassword = "changepassword";
            public const string ResetPassword = "resetpassword";
            public const string Logout = "logout";
            public const string IP = "ip";
            public const string Ping = "ping";
            public const string TenantLogout = "tenantlogout";
            public const string UserLogout = "userlogout";
        }

        public class SmtEntityBase
        {
            public const string Get = "get";
            public const string GetAll = "getall";
            public const string GetUpdate = "getupdate";
            public const string GetByID = "getbyid";
            public const string Save = "save";
            public const string Add = "add";
            public const string Update = "update";
            public const string Delete = "delete";
        }

        public class SmtFileBase
        {
            public const string GetByID = "getbyid";
            public const string Add = "add";
            public const string Update = "update";
            public const string Download = "download";
            public const string Delete = "delete";
        }

        public class SmtImageFileBase : SmtFileBase
        {
            public const string GetThumbnailByID = "getthumbnailbyid";
        }
    }
}
