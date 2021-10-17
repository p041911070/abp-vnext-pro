using CompanyName.ProjectName.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CompanyName.ProjectName.Blazor
{
    public abstract class ProjectNameComponentBase : AbpComponentBase
    {
        protected ProjectNameComponentBase()
        {
            LocalizationResource = typeof(ProjectNameResource);
        }
    }
}
