using System;
using DevExpress.Web;

namespace DevExpressWebDemo
{
    

    public partial class GridControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.dxgvGridViewDemo.CommandButtonInitialize += dxgvGridViewDemo_CommandButtonInitialize;
        }

        void dxgvGridViewDemo_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
        {
            if (e.ButtonType != ColumnCommandButtonType.Delete) return;
            e.Visible = e.VisibleIndex % 3 != 1;
            e.Enabled = e.VisibleIndex % 2 != 1;
        }
    }
}