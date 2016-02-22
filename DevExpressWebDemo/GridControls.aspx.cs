using System;
using DevExpress.Web;

namespace DevExpressWebDemo
{
    using System.Web.UI.WebControls;

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
                //Creates a default commandColumn and adds it programatically using the default buttons/functionality that already exists
                var defaultCommandColumn = new GridViewCommandColumn { ShowDeleteButton = true, ShowCancelButton = true, Visible = true, Caption="DefaultCommandColumn" };
                this.dxgvGridViewDemo.Columns.Add(defaultCommandColumn);

                //Creates a new CommandColumn without any default buttons set.
                var customCommandColumn = new GridViewCommandColumn { Visible = true, Caption = "CustomCommandColumn" };
                //Creates the customButton we want to use
                var testCustomButton = new GridViewCommandColumnCustomButton()
                                           {
                                               ID = "testCustomCommandButtonID",
                                               Text = "TestCustomCommandButton"
                                           };

                //Assigns the customButton to the column
                customCommandColumn.CustomButtons.Add(testCustomButton);

                //Adds the customCommandColumn to the grid, this includes the custom button.
                this.dxgvGridViewDemo.Columns.Add(customCommandColumn);
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