namespace PL.Authorization.Application.Configurations
{
    public static class ClaimConstants
    {
        ///<summary>A claim that specifies the subject of an entity</summary>
        public const string Subject = "sub";

        ///<summary>A claim that specifies the permission of an entity</summary>
        public const string Permission = "permission";
    }

    public static class ScopeConstants
    {
        ///<summary>A scope that specifies the roles of an entity</summary>
        public const string Roles = "roles";
    }

    public static class ModuleConstants
    {
        /// <summary>Entity framework migrations table name</summary>
        public const string EF_MigrationsTable = "EF_Migrations";

        /// <summary>Entity framework migrations table name</summary>
        public const string DefaultSchema = "Authorization";
    }
}
