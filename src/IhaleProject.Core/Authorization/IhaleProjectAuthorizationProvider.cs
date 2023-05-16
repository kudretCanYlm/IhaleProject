using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace IhaleProject.Authorization
{
    public class IhaleProjectAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            //
            context.CreatePermission(PermissionNames.Pages_Birim, L("Birim"));
            context.CreatePermission(PermissionNames.Pages_AlimTuru, L("AlimTuru"));
            context.CreatePermission(PermissionNames.Pages_AlimUsulu, L("AlimUsulu"));
            context.CreatePermission(PermissionNames.Pages_Ihale, L("Ihale"));
            context.CreatePermission(PermissionNames.Pages_Arsiv, L("Arsiv"));
            context.CreatePermission(PermissionNames.Pages_TumYayinlar, L("TumYayinlar"));
            context.CreatePermission(PermissionNames.Pages_KaldirilmisYayinlar, L("KaldirilmisYayinlar"));
            context.CreatePermission(PermissionNames.Pages_SuresiBitmisYayinlar, L("SuresiBitmisYayinlar"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, IhaleProjectConsts.LocalizationSourceName);
        }
    }
}
