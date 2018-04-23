using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.PivotGrid;
using DXPivotGrid_CustomContextMenu.nwindDataSetTableAdapters;

namespace CustomContextMenu {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
            pivotGridControl1.DataSource = salesPersonDataAdapter.GetData();
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e) {
            pivotGridControl1 = (PivotGridControl)sender;
            Clipboard.SetText(pivotGridControl1.GetFocusedCellInfo().Value.ToString());
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e) {
            PivotCellBaseEventArgs cellInfo = pivotGridControl1.GetFocusedCellInfo();
            if (cellInfo.Value == null)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }
    }
}
