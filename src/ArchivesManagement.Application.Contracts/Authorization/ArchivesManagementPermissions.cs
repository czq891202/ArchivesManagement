using Volo.Abp.Reflection;

namespace ArchivesManagement.Authorization
{
    public class ArchivesManagementPermissions
    {
        public const string GroupName = "ArchivesManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ArchivesManagementPermissions));
        }
    }
}