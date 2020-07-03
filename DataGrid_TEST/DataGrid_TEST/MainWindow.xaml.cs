using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace DataGrid_TEST
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Wypelnij_danymi();
        }
        private void Wypelnij_danymi()
        {
            string ConString = @"Data Source=DESKTOP-MA3N1EE\SQLEXPRESS;Initial Catalog=FoodDiary;Integrated Security=True;
                         Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                         MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(ConString))
            {

                string CmdString = "SELECT ProductName,Protein,Carbohydrates,Fat,Kcal,Weight FROM Products";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Products");

                sda.Fill(dt);
                DataG.ItemsSource = dt.DefaultView;
            }
        }

        private void DataG_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            List<DataGridCellInfo> cell_infos = new List<DataGridCellInfo>();
            for (int i = 0; i < DataG.SelectedCells.Count; i++)
            {
                cell_infos.Add(DataG.SelectedCells[i]);
            }
            txt_a.Text = (cell_infos[0].Column.GetCellContent(cell_infos[0].Item) as TextBlock).Text;
            txt_b.Text = (cell_infos[1].Column.GetCellContent(cell_infos[2].Item) as TextBlock).Text;
        }
    }
}
