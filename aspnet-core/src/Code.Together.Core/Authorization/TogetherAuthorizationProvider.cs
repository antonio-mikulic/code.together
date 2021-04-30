using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Code.Together.Authorization
{
    public class TogetherAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            var programmingLanguages = context.CreatePermission(PermissionNames.Pages_ProgrammingLanguage, L("ProgrammingLanguage"));
            programmingLanguages.CreateChildPermission(PermissionNames.Pages_ProgrammingLanguage_Create, L("Create"));
            programmingLanguages.CreateChildPermission(PermissionNames.Pages_ProgrammingLanguage_Update, L("Update"));
            programmingLanguages.CreateChildPermission(PermissionNames.Pages_ProgrammingLanguage_Delete, L("Delete"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TogetherConsts.LocalizationSourceName);
        }
    }
}
