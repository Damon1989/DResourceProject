using Abp.Web.Mvc.Views;

namespace DResourceProject.Web.Views
{
    public abstract class DResourceProjectWebViewPageBase : DResourceProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class DResourceProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DResourceProjectWebViewPageBase()
        {
            LocalizationSourceName = DResourceProjectConsts.LocalizationSourceName;
        }
    }
}