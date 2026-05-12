using Avalonia.Controls;
using Avalonia.Interactivity;
using JobTrack.ViewModels;

namespace JobTrack;

public partial class MainWindow : Window
{
    private MainWindowViewModel ViewModel => (MainWindowViewModel)DataContext!;

    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private void SaveApplication_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel.SaveApplication();
    }
}