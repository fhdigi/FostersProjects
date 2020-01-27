using System.Windows;
using MailingLabelApp.ViewModels;

namespace MailingLabelApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowViewModel vm)
            {
                /* refresh the listing */
                vm.RefreshListing();

                /* create the report object */
                XtraReportLabels rpt = new XtraReportLabels { DataSource = vm.CustomerListing };

                /* pass the report object to the print preview */
                DocumentMailingReport.DocumentSource = rpt;
                rpt.CreateDocument(true);
            }
        }

        private void ButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            DocumentMailingReport.Print();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
