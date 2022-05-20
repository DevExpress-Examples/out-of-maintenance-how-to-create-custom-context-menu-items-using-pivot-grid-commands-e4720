Imports System.Windows.Input

Namespace CustomContextMenu

    Public Module CustomCommands

        Private copyField As RoutedUICommand = New RoutedUICommand("Copy", "Copy", GetType(CustomCommands))

        Public ReadOnly Property Copy As RoutedUICommand
            Get
                Return copyField
            End Get
        End Property
    End Module
End Namespace
