using System.Windows;
using MailingLabelApp.Models;

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
            /* create the report object */
            XtraReportLabels rpt = new XtraReportLabels { DataSource = Customer.GetCustomers() };

            /* pass the report object to the print preview */
            DocumentMailingReport.DocumentSource = rpt;
            rpt.CreateDocument(true);
        }
    }
}
