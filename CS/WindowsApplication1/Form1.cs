using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.XtraGrid.Views.Base;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        public void InitData() {
            for (int i = 0; i <= 10; i++) {
                dataSet11.DataTable1.Rows.Add(new object[] {  0, i,DateTime.Today, i });
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
          }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
            GridControl gridControl = (sender as GridControlNavigator).NavigatableControl as GridControl;
            ColumnView view = gridControl.FocusedView as ColumnView;
            if (e.Button.ButtonType == NavigatorButtonType.Custom && view!=null) {
                view.DeleteSelectedRows();
            }
        }


    }
}
