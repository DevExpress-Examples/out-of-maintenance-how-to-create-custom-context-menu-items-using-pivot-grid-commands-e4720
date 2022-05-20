Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.PivotGrid
Imports DXPivotGrid_CustomContextMenu.nwindDataSetTableAdapters

Namespace CustomContextMenu

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()
            Me.pivotGridControl1.DataSource = salesPersonDataAdapter.GetData()
        End Sub

        Private Sub CommandBinding_Executed_1(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
            Me.pivotGridControl1 = CType(sender, PivotGridControl)
            Call Clipboard.SetText(Me.pivotGridControl1.GetFocusedCellInfo().Value.ToString())
        End Sub

        Private Sub CommandBinding_CanExecute_1(ByVal sender As Object, ByVal e As CanExecuteRoutedEventArgs)
            Dim cellInfo As PivotCellBaseEventArgs = Me.pivotGridControl1.GetFocusedCellInfo()
            If cellInfo.Value Is Nothing Then
                e.CanExecute = False
            Else
                e.CanExecute = True
            End If
        End Sub
    End Class
End Namespace
