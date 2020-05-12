using ArchivesManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ArchivesManagement.Authorization
{
    public class ArchivesManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(ArchivesManagementPermissions.GroupName, L("Permission:ArchivesManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ArchivesManagementResource>(name);
        }
    }
}