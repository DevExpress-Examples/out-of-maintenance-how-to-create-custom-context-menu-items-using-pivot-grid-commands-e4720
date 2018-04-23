Imports Microsoft.VisualBasic
Imports System.Windows.Input

Namespace CustomContextMenu
	Public NotInheritable Class CustomCommands
		Private Shared copy_Renamed As New RoutedUICommand("Copy", "Copy", GetType(CustomCommands))
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Copy() As RoutedUICommand
			Get
				Return copy_Renamed
			End Get
		End Property
	End Class
End Namespace
