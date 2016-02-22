using System;
using DevExpress.Web;

namespace DevExpressWebDemo
{
    

    public partial class GridControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.dxgvGridViewDemo.CommandButtonInitialize += dxgvGridViewDemo_CommandButtonInitialize;
            this.dxgvGridViewDemo.Load += dxgvGridViewDemo_Load;
        }


        //Build grid with everything required.
        void dxgvGridViewDemo_Load(object sender, EventArgs e)
        {
            //the difference is DataColumns come from "DataSources"?
            foreach (GridViewDataColumn gridViewColumn in this.dxgvGridViewDemo.DataColumns)
            {
                foreach (GridViewColumn columns in gridViewColumn.Grid.Columns)
                {
                    foreach (var charColumnHeader in columns.Caption)
                    {
                        //testing
                    }
                }
            }
            if (this.dxgvGridViewDemo != null)
            {
                var testColumn = new GridViewCommandColumn { ShowDeleteButton = true, ShowCancelButton = true, Visible = true, Caption="Remove" };
                //create new column.
                this.dxgvGridViewDemo.Columns.Add(testColumn);
            }
        }

        //Apply Permissions.
        void dxgvGridViewDemo_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
        {
            #region Disable Command Buttons in GridView
            if (e.ButtonType != ColumnCommandButtonType.Delete) return;
            e.Visible = e.VisibleIndex % 3 != 1;
            e.Enabled = e.VisibleIndex % 2 != 1;
            #endregion
        }
    }
}