Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.PivotGrid
Imports DXPivotGrid_CustomContextMenu.nwindDataSetTableAdapters

Namespace CustomContextMenu
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim salesPersonDataAdapter As New SalesPersonTableAdapter()
			pivotGridControl1.DataSource = salesPersonDataAdapter.GetData()
		End Sub

		Private Sub CommandBinding_Executed_1(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
			pivotGridControl1 = CType(sender, PivotGridControl)
			Clipboard.SetText(pivotGridControl1.GetFocusedCellInfo().Value.ToString())
		End Sub

		Private Sub CommandBinding_CanExecute_1(ByVal sender As Object, ByVal e As CanExecuteRoutedEventArgs)
			Dim cellInfo As PivotCellBaseEventArgs = pivotGridControl1.GetFocusedCellInfo()
			If cellInfo.Value Is Nothing Then
				e.CanExecute = False
			Else
				e.CanExecute = True
			End If
		End Sub
	End Class
End Namespace
