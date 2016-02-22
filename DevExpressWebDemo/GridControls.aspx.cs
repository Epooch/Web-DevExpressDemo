using System;
using DevExpress.Web;

namespace DevExpressWebDemo
{
    using System.Linq;
    using System.Web.UI.WebControls;

    public partial class GridControls : System.Web.UI.Page
    {
        /// <summary>
        /// dxgvGridViewDemo control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected ASPxGridView dxgvGridViewDemo;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.dxgvGridViewDemo.CustomButtonCallback += this.DxgvGridViewDemoCustomButtonCallback;
            this.dxgvGridViewDemo.CustomButtonInitialize += this.DxgvGridViewDemoCustomButtonInitialize;
            this.dxgvGridViewDemo.CommandButtonInitialize += this.DxgvGridViewDemoCommandButtonInitialize;
            this.dxgvGridViewDemo.Load += this.DxgvGridViewDemoLoad;
            
        }

        //Build grid with everything required.
        private void DxgvGridViewDemoLoad(object sender, EventArgs e)
        {
            if (this.dxgvGridViewDemo != null)
            {
                var checkCustomCommandColumn = this.dxgvGridViewDemo.Columns["CustomCommandColumn"]; //Using the Column Caption you can check if a column already exists.
                var checkDefaultCommandColumn = this.dxgvGridViewDemo.Columns["DefaultCommandColumn"];

                //The supposed "linq" way, source: https://www.devexpress.com/Support/Center/Question/Details/T138170
                //var myColumn = dxgvGridViewDemo.Columns.FirstOrDefault((col) => col.GetCaption() == "ID");

                //If this is returned null then the column does not exist.
                if (checkCustomCommandColumn == null)
                {//Make new Custom Command Column
                    // 1. Create a new CommandColumn without any default buttons set.
                        var customCommandColumn = new GridViewCommandColumn { Visible = true, Caption = "CustomCommandColumn", VisibleIndex = 8 };
                    // 2. Create the customButton we want to use
                        var testCustomButton = new GridViewCommandColumnCustomButton() //This button when clicked will change the visibility of the 'DefaultCommandColumn' that I have added.
                        {
                            // a. The ID of the custom Button is used in the CustomButtonCallBack method. 
                            ID = "testCustomCommandButtonID", //this ID == e.ButtonID.
                            Text = "TestCustomCommandButton"
                        };

                    // 3. Assigns the customButton to the column
                        customCommandColumn.CustomButtons.Add(testCustomButton);

                    // 4. Adds the customCommandColumn to the grid, this includes the custom button.
                        this.dxgvGridViewDemo.Columns.Add(customCommandColumn);
                }

                if (checkDefaultCommandColumn == null)
                {//Make new Default Command Column
                    // 1. Creates a default commandColumn and adds it programatically using the default buttons/functionality that already exists
                        var defaultCommandColumn = new GridViewCommandColumn { ShowDeleteButton = true, ShowCancelButton = true, Visible = true, Caption="DefaultCommandColumn" };
                    // 2. Adds the defaultCommandColumn to the grid.
                        this.dxgvGridViewDemo.Columns.Add(defaultCommandColumn);
                }
            }
        }

        /// <summary>
        /// At this point we can apply permissions to specific command buttons when they are initialized.
        /// These DO NOT include the customCommandButtons being initialized they have there own initialize event.
        /// 
        /// At this point can I make a "presenter" call to set permissions on an item?
        /// </summary>
        internal void DxgvGridViewDemoCommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
        {
            #region Disable Command Buttons in GridView
            if (e.ButtonType != ColumnCommandButtonType.Delete) return;
            e.Visible = e.VisibleIndex % 3 != 1;
            e.Enabled = e.VisibleIndex % 2 != 1;
            #endregion
        }

        /// <summary>
        /// At this point we can apply permissions to specific CUSTOM buttons when they are initialized.
        /// These DO NOT include the default CommandButtons being initialized they have there own initialize event.
        /// Source: https://www.devexpress.com/Support/Center/Question/Details/Q438657
        /// At this point can I make a "presenter" call to set permissions on an item?
        /// </summary>
        internal void DxgvGridViewDemoCustomButtonInitialize(object sender, ASPxGridViewCustomButtonEventArgs e)
        {
            if (e.ButtonID == "testCustomCommandButtonID")
            {

            }
        }

        /// <summary>
        /// If we make 100 custom buttons each will have it's own unique ID. The ID will be used to call a presenter method
        /// in this instance, delete, edit, remove, create.
        ///
        /// e.ButtonID controls the specific action to call passed in by the gridView.
        /// </summary>
        internal void DxgvGridViewDemoCustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            if (e.ButtonID == "testCustomCommandButtonID")
            {
                //You cannot change another control during the callback of ASPxGridView
                //Source: https://www.devexpress.com/Support/Center/Question/Details/Q109223
                //this.dxgvGridViewDemo.Visible = false; //This will not work as of DevExpress 15.2.

                //I cannot change or alter the controls but the columns themselves can be manipulated.
                var checkDefaultCommandColumn = this.dxgvGridViewDemo.Columns["DefaultCommandColumn"];

                if (checkDefaultCommandColumn != null)
                {
                    if (checkDefaultCommandColumn.Visible)
                    {
                        checkDefaultCommandColumn.Visible = false;
                    }
                    else
                    {
                        checkDefaultCommandColumn.Visible = true;
                    }
                }
            }
        }
    }
}