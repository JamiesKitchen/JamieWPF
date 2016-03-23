using System.Windows;
using Jamie.ViewModel;
using System;

namespace Jamie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.frame1.Navigate(new Uri("/PageManageShoppingList.xaml", UriKind.Relative));
        }

        private void dgTest_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}