using Syncfusion.DataSource.Extensions;
using Syncfusion.GridCommon.ScrollAxis;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields
        SfListView ListView;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            ListView.Loaded += ListView_Loaded;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            ListView.Loaded -= ListView_Loaded;
            ListView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Events
        private void ListView_Loaded(object sender, ListViewLoadedEventArgs e)
        {
            DependencyService.Get<IDependencyServiceListView>().DisableScrolling(ListView);
        }
        #endregion
    }
}