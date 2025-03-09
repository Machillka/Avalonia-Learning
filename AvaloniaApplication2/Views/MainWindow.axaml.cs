using Avalonia.Controls;

using Avalonia.Interactivity;
using System.Diagnostics;

namespace AvaloniaApplication2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void ButtonOnClick(object? sender, RoutedEventArgs e)
    {
        Debug.WriteLine("Hello, Avalonia!");
    }
}