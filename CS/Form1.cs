using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;

namespace Q143749 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void controlNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
            ControlNavigator navigator = (ControlNavigator)sender;
            if (e.Button == navigator.Buttons.CustomButtons[0]) {
                FieldInfo fi = typeof(NavigatorButtonsBase).GetField("viewInfo", BindingFlags.Instance | BindingFlags.NonPublic);
                NavigatorButtonsViewInfo buttonsViewInfo = (NavigatorButtonsViewInfo)fi.GetValue(navigator.ViewInfo.Buttons);
                Point mousePosition = navigator.PointToClient(Control.MousePosition);
                NavigatorButtonViewInfo buttonViewInfo = buttonsViewInfo.ButtonViewInfoAt(mousePosition);
                Point menuPosition = new Point(buttonViewInfo.Bounds.Left, buttonViewInfo.Bounds.Bottom);
                menuPosition = navigator.PointToScreen(menuPosition);
                popupMenu1.ShowPopup(menuPosition);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }
    }
}