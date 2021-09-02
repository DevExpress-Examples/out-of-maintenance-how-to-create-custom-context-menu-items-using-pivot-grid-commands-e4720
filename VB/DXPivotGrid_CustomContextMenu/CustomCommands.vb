Imports System.Windows.Input

Namespace CustomContextMenu
	Public Module CustomCommands
'INSTANT VB NOTE: The field copy was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private copy_Conflict As New RoutedUICommand("Copy", "Copy", GetType(CustomCommands))
		Public ReadOnly Property Copy() As RoutedUICommand
			Get
				Return copy_Conflict
			End Get
		End Property
	End Module
End Namespace
