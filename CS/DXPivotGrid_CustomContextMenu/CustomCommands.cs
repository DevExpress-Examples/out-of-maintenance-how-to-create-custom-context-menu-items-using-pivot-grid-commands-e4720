using System.Windows.Input;

namespace CustomContextMenu {
    public static class CustomCommands {
        static RoutedUICommand copy = new RoutedUICommand("Copy", "Copy", typeof(CustomCommands));
        public static RoutedUICommand Copy { get { return copy; } }
    }
}
