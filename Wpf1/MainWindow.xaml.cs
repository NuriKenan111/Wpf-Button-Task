using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpf1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void button_left(object sender, RoutedEventArgs e)
    {
        if (sender is Button but)
        {
            Random random = new Random();
            byte r = (byte)random.Next(0, 256);
            byte g = (byte)random.Next(0, 256);
            byte b = (byte)random.Next(0, 256);
            but.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            MessageBox.Show($"Content: {but.Content.ToString()}\n" +
                            $"Font Size: {but.FontSize}\n" +
                            $"Height: {but.Height}\n" +
                            $"Width: {but.Width}\n" +
                            $"Background Color: R:{r}, G:{g}, B:{b}\n" +
                            $"Margin: {but.Margin.ToString()}");
        }
        else
        {
            MessageBox.Show("Sender is not a Button.");
        }
    }

    private void button_right(object sender, RoutedEventArgs e)
    {
        if (sender is Button b)
        {
            Title = b.Content.ToString();
            
            grid1.Children.Remove(b);
        }
        else
        {
            MessageBox.Show("Sender is not a Button.");
        }
    }
}

