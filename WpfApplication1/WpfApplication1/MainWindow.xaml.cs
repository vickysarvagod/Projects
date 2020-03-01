
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = CreateTable(3, 50).DefaultView;
        }

        public DataTable CreateTable(int columns, int rows)
        {
            DataTable d = new DataTable();
            Random r = new Random();

            for (int i = 0; i < columns; i++)
            {
                d.Columns.Add(new DataColumn("Column " + i, typeof(int)));
            }
            for (int i = 0; i < rows; i++)
            {
                DataRow row = d.NewRow();

                for (int j = 0; j < columns; j++)
                {
                    row["Column " + j] = i;
                }

                d.Rows.Add(row);
            }
            return d;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xdg.ActiveRecord = xdg.Records[0];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {           
            if (xdg.ActiveRecord.Index == 0)
            {
                xdg.BringRecordIntoView(xdg.Records[28]);
            }

            if (xdg.ActiveRecord.Index == xdg.Records.Count-1)
            {
                xdg.BringRecordIntoView(xdg.Records[20]);
            }

            xdg.ActiveRecord = xdg.Records[24];
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            xdg.ActiveRecord = xdg.Records[49];
        }
    }
}