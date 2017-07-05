using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;


namespace WPF_ReceiptDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    /// 



    public partial class MainWindow : Window
    {


        //1st Listbox
        WPFListBoxModel Companies = new WPFListBoxModel();
        //2nd listbox
      //  WPFListBoxModel GroceryInv = new WPFListBoxModel();


        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
            

        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            //This intializes all the data
            GetData();
           this.DataContext = Companies;
   
        }

        /* 
         * Populate combo box from Grocery Level Invetory
          * Parameters for event controlled actions using MARS-  multiple SqlDataReader
          * 
         * */
        public void GetData()
        {
            //want to reuse connection
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-QUAEPTE;Initial Catalog=Receipts_DB;Integrated Security=True;");

            SqlConnectionStringBuilder str = new SqlConnectionStringBuilder();

            SqlConnection myConnection1 = new SqlConnection("Data Source=DESKTOP-QUAEPTE;Initial Catalog=Receipts_DB;Integrated Security=True;");

            SqlConnectionStringBuilder str1 = new SqlConnectionStringBuilder();



            //  SqlConnection myConnection = new SqlConnection(str.ConnectionString);

            //   SqlDataReader myReader = null;

            myConnection.Open();
            SqlDataReader dr = new SqlCommand("SELECT GroceryCompany_ID, Company_Name FROM COMPANIES ORDER BY Company_Name DESC", myConnection).ExecuteReader();
            while (dr.Read())
            {
                Companies.Categories.Add(new Category { Id = dr.GetInt32(0), CategoryName = dr.GetString(1) });
            }
            myConnection.Close();


           
            myConnection.Open();
            SqlDataReader br = new SqlCommand("SELECT Store_ID, StreetAddress FROM Stores ORDER BY StreetAddress DESC", myConnection).ExecuteReader();
            while (br.Read())
            {
                Companies.Categories1.Add(new Category { Id = br.GetInt32(0), CategoryName = br.GetString(1) });
            }
            myConnection.Close();



           myConnection.Open();
            SqlDataReader cr = new SqlCommand("SELECT Item_ID, ItemName FROM Grocery_Inventory ORDER BY ItemName DESC", myConnection).ExecuteReader();
            while (cr.Read())
            {
                Companies.Categories2.Add(new Category { Id = cr.GetInt32(0), CategoryName = cr.GetString(1) });
            }
            myConnection.Close();
            


            myConnection.Open();
            //SqlDataReader gr = new SqlCommand("SELECT GroceryCompany_ID, Company_Name FROM COMPANIES ORDER BY Company_Name DESC", myConnection1).ExecuteReader();

            SqlDataReader gr = new SqlCommand("SELECT Store_ID, Category FROM Grocery_Inventory ORDER BY Category DESC", myConnection).ExecuteReader();
            while (gr.Read())
            {
                Companies.ComboxBox1.Add(new Category { Id = gr.GetInt32(0), CategoryName = gr.GetString(1) });
            }
            myConnection.Close();



        }




    }
}




