using SukiUI.Controls;

using Avalonia.Interactivity;
using System;

namespace AvaloniaApplication2.Views;

public partial class MainWindow : SukiWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void ButtonOnClick(object? sender, RoutedEventArgs e)
    {
        // Debug.WriteLine("Hello, Avalonia!");
        if (Double.TryParse(numberA.Text, out double tempA) && Double.TryParse(numberB.Text, out double tempB))
        {
            double result = tempA + tempB;
            resultNumber.Text = result.ToString();
        }
    }
}