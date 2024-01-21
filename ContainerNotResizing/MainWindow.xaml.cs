using System;
using System.Windows;

namespace ContainerNotResizing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel vm = new();
            DataContext = vm;
        }

        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Random rnd = new();
            MainViewModel mainViewModel = new(rnd.Next(1000));
            DataContext = mainViewModel;
        }
    }
}
