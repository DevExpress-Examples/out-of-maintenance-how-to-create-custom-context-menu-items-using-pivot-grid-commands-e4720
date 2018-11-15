<!-- default file list -->
*Files to look at*:

* [CustomCommands.cs](./CS/DXPivotGrid_CustomContextMenu/CustomCommands.cs) (VB: [CustomCommands.vb](./VB/DXPivotGrid_CustomContextMenu/CustomCommands.vb))
* [MainWindow.xaml](./CS/DXPivotGrid_CustomContextMenu/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_CustomContextMenu/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_CustomContextMenu/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_CustomContextMenu/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create custom context menu items using pivot grid commands


<p>This example shows how to add custom items to the context menu displayed when an end user right-clicks a header area, field value, field header, or pivot grid cell. The following menu items are added:<br />
- 'Reset Prefilter' for the header area context menu;<br />
- 'Expand/Collapse' for the field value context menu;<br />
- 'Change Sort Order' for the field header context menu;<br />
- 'Copy' for the cell context menu.<br />
Properties exposed by the <a href="http://documentation.devexpress.com/#wpf/clsDevExpressXpfPivotGridPivotGridCommandstopic"><u>PivotGridCommands</u></a> object are used to perform the required actions.<br />
The 'Copy' command is created to copy the information obtained using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridCells_GetFocusedCellInfotopic"><u>GetFocusedCellInfo</u></a> method to the Clipboard.</p>

<br/>


