using System.Windows;
using Jamie.ViewModel;
using System;
using System.Windows.Documents;
using System.Diagnostics;

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

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Hyperlink hl = (Hyperlink)sender;

            string navigateUri = hl.NavigateUri.ToString();

            Process.Start(new ProcessStartInfo(navigateUri));

            e.Handled = true;

        }


    }
}