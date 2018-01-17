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
using System.Data;



namespace Cafe_Management_System
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
        string cs = @"Data Source=ASHIK\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True";
        private void login_Click(object sender, RoutedEventArgs e)
        {
            /* string connectionstring = @"Data Source=ASHIK\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True";
             SqlConnection sqlcon = new SqlConnection(connectionstring);
             sqlcon.Open();
             string commandstring = "select * from tb_user";
             SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
             SqlDataReader read = sqlcmd.ExecuteReader();

             string ss = "";

             while (read.Read())
             {

                 if (txt_userid.Text == read[1].ToString() && txt_pass.Password == read[2].ToString()) {
                     MessageBox.Show("Welcome To Cafe Management System");
                     mainInterface mw = new mainInterface();
                     mw.Show();
                     Close();

                 }
                 else
                 {
                     string err = "Wrong User name Or password";
                     MessageBox.Show(err);
                 }
                 ss = ss + read[3].ToString() + " " + read[2].ToString() + " " + read[1].ToString() + "\n";
             }

             sqlcon.Close();
         }*/
            if (txt_userid.Text == "" || txt_pass.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tb_user where userid=@userid and pass=@pass", con);
                cmd.Parameters.AddWithValue("@userid", txt_userid.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Password);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    mainInterface mi = new mainInterface();
                    mi.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Grid_LostFocus(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
