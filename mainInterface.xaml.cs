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
using System.Windows.Shapes;

namespace Cafe_Management_System
{
    /// <summary>
    /// Interaction logic for mainInterface.xaml
    /// </summary>
    public partial class mainInterface : Window
    {
        public mainInterface()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Window_Closed(object sender, EventArgs e){
            Close();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtLattlced.Text = "0";
            txtVale.Text = "0";
            txtCappuccino.Text = "0";
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtIced.Text = "0";
            txtCofeeCake.Text = "0";
            txtRed.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtBoston.Text = "0";
            txtKilburn.Text = "0";
            txtCarlton.Text = "0";
            txtQueen.Text = "0";
            txbCostDrink.Text = String.Format("{0:C}", 0);
            txbCostCake.Text = String.Format("{0:C}", 0);
            txbService.Text = "1.75";
            tpTax.Text = String.Format("{0:C}", 0);
            tpSub.Text = String.Format("{0:C}", 0);
            tpTotal.Text = String.Format("{0:C}", 0);

            chkLatte.IsChecked = false;
            chkEspresso.IsChecked = false;
            chkLattlced.IsChecked = false;
            chkVale.IsChecked = false;
            chkCappuccino.IsChecked = false;
            chkAfrican.IsChecked = false;
            chkAmerican.IsChecked = false;
            chkIced.IsChecked = false;
            chkCofeeCake.IsChecked = false;
            chkRed.IsChecked = false;
            chkBlack.IsChecked = false;
            chkBoston.IsChecked = false;
            chkLagos.IsChecked = false;
            chkKilburn.IsChecked = false;
            chkCarlton.IsChecked = false;
            chkQueen.IsChecked = false;
        }

        private void exit_Loaded(object sender, RoutedEventArgs e)
        {
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtLattlced.Text = "0";
            txtVale.Text = "0";
            txtCappuccino.Text = "0";
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtIced.Text = "0";
            txtCofeeCake.Text = "0";
            txtRed.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtLagos.Text = "0";
            txtKilburn.Text = "0";
            txtCarlton.Text = "0";
            txtQueen.Text = "0";
            txbCostDrink.Text = String.Format("{0:C}", 0);
            txbCostCake.Text = String.Format("{0:C}", 0);
            txbService.Text = "1.75";
            tpTax.Text = String.Format("{0:C}", 0);
            tpSub.Text = String.Format("{0:C}", 0);
            tpTotal.Text =String.Format("{0:C}", 0);

            txtLatte.IsEnabled = false;
            txtEspresso.IsEnabled = false;
            txtLattlced.IsEnabled = false;
            txtVale.IsEnabled = false;
            txtCappuccino.IsEnabled = false;
            txtAfrican.IsEnabled = false;
            txtAmerican.IsEnabled = false;
            txtIced.IsEnabled = false;
            txtCofeeCake.IsEnabled = false;
            txtRed.IsEnabled = false;
            txtBlack.IsEnabled = false;
            txtBoston.IsEnabled = false;
            txtLagos.IsEnabled = false;
            txtKilburn.IsEnabled = false;
            txtCarlton.IsEnabled = false;
            txtQueen.IsEnabled = false;

            chkLatte.IsChecked = false;
            chkEspresso.IsChecked = false;
            chkLattlced.IsChecked = false;
            chkVale.IsChecked = false;
            chkCappuccino.IsChecked = false;
            chkAfrican.IsChecked = false;
            chkAmerican.IsChecked = false;
            chkIced.IsChecked = false;
            chkCofeeCake.IsChecked = false;
            chkRed.IsChecked = false;
            chkBlack.IsChecked = false;
            chkBoston.IsChecked = false;
            chkLagos.IsChecked = false;
            chkKilburn.IsChecked = false;
            chkCarlton.IsChecked = false;
            chkQueen.IsChecked = false;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void chkLatte_Checked(object sender, RoutedEventArgs e)
        {
            if(chkLatte.IsChecked == true)
            {
                txtLatte.IsEnabled = true;
            }
        }
        private void chkLatte_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkLatte.IsChecked == false)
            {
                txtLatte.IsEnabled = false;
                txtLatte.Text = "0";
            }
        }

        private void txtLatte_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void chkEspresso_Checked(object sender, RoutedEventArgs e)
        {
            if (chkEspresso.IsChecked == true)
            {
                txtEspresso.IsEnabled = true;
            }
        }

        private void chkEspresso_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkEspresso.IsChecked == false)
            {
                txtEspresso.IsEnabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtEspresso_GotFocus(object sender, RoutedEventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void chkLattlced_Checked(object sender, RoutedEventArgs e)
        {
            if (chkLattlced.IsChecked == true)
            {
                txtLattlced.IsEnabled = true;
            }
        }

        private void chkLattlced_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkLattlced.IsChecked == false)
            {
                txtLattlced.IsEnabled = false;
                txtLattlced.Text = "0";
            }
        }

        private void txtLattlced_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLattlced.Text = "";
            txtLattlced.Focus();
        }

        private void chkVale_Checked(object sender, RoutedEventArgs e)
        {
            if (chkVale.IsChecked == true)
            {
                txtVale.IsEnabled = true;
            }

        }

        private void chkVale_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkVale.IsChecked == false)
            {
                txtVale.IsEnabled = false;
                txtVale.Text = "0";
            }
        }

        private void chkCappuccino_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkCappuccino.IsChecked == false)
            {
                txtCappuccino.IsEnabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkCappuccino_Checked(object sender, RoutedEventArgs e)
        {
            if (chkCappuccino.IsChecked == true)
            {
                txtCappuccino.IsEnabled = true;
            }

        }

        private void txtCappuccino_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCappuccino.Text = "";
            txtCappuccino.Focus();
        }

        private void chkAfrican_Checked(object sender, RoutedEventArgs e)
        {
            if (chkAfrican.IsChecked == true)
            {
                txtAfrican.IsEnabled = true;
            }
        }

        private void chkAfrican_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkAfrican.IsChecked == false)
            {
                txtAfrican.IsEnabled = false;
                txtAfrican.Text = "0";
            }

        }

        private void txtAfrican_GotFocus(object sender, RoutedEventArgs e)
        {
            txtAfrican.Text = "";
            txtAfrican.Focus();
        }

        private void chkAmerican_Checked(object sender, RoutedEventArgs e)
        {
            if (chkAmerican.IsChecked == true)
            {
                txtAmerican.IsEnabled = true;
            }
        }

        private void chkAmerican_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkAmerican.IsChecked == false)
            {
                txtAmerican.IsEnabled = false;
                txtAmerican.Text = "0";
            }
        }

        private void txtAmerican_GotFocus(object sender, RoutedEventArgs e)
        {
            txtAmerican.Text = "";
            txtAmerican.Focus();
        }

        private void chkIced_Checked(object sender, RoutedEventArgs e)
        {
            if (chkIced.IsChecked == true)
            {
                txtIced.IsEnabled = true;
            }

        }

        private void chkIced_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkIced.IsChecked == false)
            {
                txtIced.IsEnabled = false;
                txtIced.Text = "0";
            }
        }

        private void txtIced_GotFocus(object sender, RoutedEventArgs e)
        {
            txtIced.Text = "";
            txtIced.Focus();

        }


        private void chkCofeeCake_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkCofeeCake.IsChecked == false)
            {
                txtCofeeCake.IsEnabled = false;
                txtCofeeCake.Text = "0";
            }
        }

        private void chkCofeeCake_Checked(object sender, RoutedEventArgs e)
        {
            if (chkCofeeCake.IsChecked == true)
            {
                txtCofeeCake.IsEnabled = true;
            }
        }

        private void txtCofeeCake_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCofeeCake.Text = "";
            txtCofeeCake.Focus();

        }

        private void chkRed_Checked(object sender, RoutedEventArgs e)
        {
            if (chkRed.IsChecked == true)
            {
                txtRed.IsEnabled = true;
            }

        }

        private void chkRed_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkRed.IsChecked == false)
            {
                txtRed.IsEnabled = false;
                txtRed.Text = "0";
            }

        }

        private void txtRed_GotFocus(object sender, RoutedEventArgs e)
        {
            txtRed.Text = "";
            txtRed.Focus();
        }

        private void chkBlack_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBlack.IsChecked == true)
            {
                txtBlack.IsEnabled = true;
            }

        }

        private void chkBlack_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkBlack.IsChecked == false)
            {
                txtBlack.IsEnabled = false;
                txtBlack.Text = "0";
            }
        }

        private void txtBlack_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBlack.Text = "";
            txtBlack.Focus();

        }

        private void chkBoston_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBoston.IsChecked == true)
            {
                txtBoston.IsEnabled = true;
            }
        }

        private void chkBoston_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkBoston.IsChecked == false)
            {
                txtBoston.IsEnabled = false;
                txtBoston.Text = "0";
            }
        }

        private void txtBoston_GotFocus(object sender, RoutedEventArgs e)
        {

            txtBoston.Text = "";
            txtBoston.Focus();

        }

        private void chkLagos_Checked(object sender, RoutedEventArgs e)
        {
            if (chkLagos.IsChecked == true)
            {
                txtLagos.IsEnabled = true;
            }
        }

        private void chkLagos_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkLagos.IsChecked == false)
            {
                txtLagos.IsEnabled = false;
                txtLagos.Text = "0";
            }
        }

        private void txtLagos_GotFocus(object sender, RoutedEventArgs e)
        {
            txtLagos.Text = "";
            txtLagos.Focus();

        }

        private void chkKilburn_Checked(object sender, RoutedEventArgs e)
        {
            if (chkKilburn.IsChecked == true)
            {
                txtKilburn.IsEnabled = true;
            }
        }

        private void chkKilburn_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkKilburn.IsChecked == false)
            {
                txtKilburn.IsEnabled = false;
                txtKilburn.Text = "0";
            }

        }

        private void txtKilburn_GotFocus(object sender, RoutedEventArgs e)
        {
            txtKilburn.Text = "";
            txtKilburn.Focus();

        }

        private void chkCarlton_Checked(object sender, RoutedEventArgs e)
        {
            if (chkCarlton.IsChecked == true)
            {
                txtCarlton.IsEnabled = true;
            }

        }

        private void chkCarlton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkCarlton.IsChecked == false)
            {
                txtCarlton.IsEnabled = false;
                txtCarlton.Text = "0";
            }
        }

        private void txtCarlton_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCarlton.Text = "";
            txtCarlton.Focus();

        }

        private void chkQueen_Checked(object sender, RoutedEventArgs e)
        {
            if (chkQueen.IsChecked == true)
            {
                txtQueen.IsEnabled = true;
            }

        }

        private void chkQueen_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkQueen.IsChecked == false)
            {
                txtQueen.IsEnabled = false;
                txtQueen.Text = "0";
            }
        }

        private void txtQueen_GotFocus(object sender, RoutedEventArgs e)
        {
            txtQueen.Text = "";
            txtQueen.Focus();

        }

        private void txtVale_GotFocus(object sender, RoutedEventArgs e)
        {
            txtVale.Text = "";
            txtVale.Focus();

        }
        private void btnReceipt_Click(object sender, RoutedEventArgs e)
        {
            rtfreceipt.AppendText(Environment.NewLine);
            rtfreceipt.AppendText("\t\t" + "Just Do Cafe" + Environment.NewLine);
            rtfreceipt.AppendText("\t"+ "___________________________________________________" + Environment.NewLine);                            
            rtfreceipt.AppendText("\t"+  "Latte \t\t\t\t\t" + txtLatte.Text +Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Espresso \t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Lattlced Latte \t\t\t\t" + txtLattlced.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Vale Coffee \t\t\t\t" + txtVale.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Cappuccino \t\t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "African Coffee \t\t\t\t" + txtAfrican.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "American Coffee \t\t\t" + txtAmerican.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Iced-Cappuccino \t\t\t" + txtIced.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Coffee Cake  \t\t\t\t" + txtCofeeCake.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Red Velvet Cake \t\t\t\t" + txtRed.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Black Forest Cake \t\t\t" + txtBlack.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Vale Boston Cream Cake \t\t\t" + txtVale.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Lagos Chocolate Cake \t\t\t" + txtLagos.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Kilburn Chocolate Cake \t\t\t" + txtKilburn.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Carlton Hill Choclate Cake \t\t" + txtCarlton.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Queen Park Chocolate Cake \t\t" + txtQueen.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "___________________________________________________" + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Service Charge \t\t\t" + txbService.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "___________________________________________________" + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Tax \t\t\t\t"+tpTax.Text+Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Sub Total \t\t\t" + tpSub.Text + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "___________________________________________________" + Environment.NewLine);
            rtfreceipt.AppendText("\t" + "Total \t\t\t\t" + tpTotal.Text + Environment.NewLine);
            

        }

        private void btnTotal_Click(object sender, RoutedEventArgs e)
        {
            double tax;
            tax = .45;
            double latte, Espres, iLatte, Vale, aCoff, amCoff, Capp, iCapp;
            double cCake, rVel, bFor, cBos, cLag, cKilb, cCarl, cQueen;
            //Coffee
            latte=1.20; Espres=1.40; iLatte=1.60; Vale=1.8; aCoff=2.00; amCoff=2.20; Capp=2.40; iCapp=2.60;

            double latte_coff = Convert.ToDouble(txtLatte.Text);
            double espresson  = Convert.ToDouble(txtEspresso.Text);
            double IcedLatte  = Convert.ToDouble(txtLattlced.Text);
            double Vale_Coff  = Convert.ToDouble(txtVale.Text);
            double Afri_coff  = Convert.ToDouble(txtAfrican.Text);
            double Amre_coff  = Convert.ToDouble(txtAmerican.Text);
            double Cappe_coff = Convert.ToDouble(txtCappuccino.Text);
            double Icapp_coff = Convert.ToDouble(txtIced.Text);
            //Cake

            cCake=3.00; rVel = 3.20; bFor = 3.40; cBos = 3.60; cLag = 3.80; cKilb = 4.00; cCarl = 4.20; cQueen = 4.40;

            double c_cakes = Convert.ToDouble(txtCofeeCake.Text);
            double vl_cakes = Convert.ToDouble(txtRed.Text);
            double bF_cakes = Convert.ToDouble(txtBlack.Text);
            double cB_cakes = Convert.ToDouble(txtBoston.Text);
            double cL_cakes = Convert.ToDouble(txtLagos.Text);
            double cK_cakes = Convert.ToDouble(txtKilburn.Text);
            double cC_cakes = Convert.ToDouble(txtCarlton.Text);
            double cQ_cakes = Convert.ToDouble(txtQueen.Text);


            Cafe eat_in_cafe = new Cafe(latte_coff, espresson, IcedLatte, Vale_Coff, Afri_coff, Amre_coff, Cappe_coff, Icapp_coff, c_cakes, vl_cakes, bF_cakes, cB_cakes, cL_cakes, cK_cakes, cC_cakes, cQ_cakes);

            double cost_of_drinks = (latte_coff* latte)+ (espresson * Espres) + (IcedLatte * iLatte) + (Vale_Coff * Vale) + (Afri_coff * aCoff) +
                (Amre_coff*amCoff) + (Cappe_coff * Capp) + (Icapp_coff * iCapp) ;
            txbCostDrink.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (c_cakes * cCake) + (vl_cakes * rVel) + (bF_cakes * bFor) + (cB_cakes * cBos) + (cL_cakes * cLag) +
                (cK_cakes * cKilb) + (cC_cakes * cCarl) + (cQ_cakes * cQueen);

            txbCostCake.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(txbService.Text);

            tpSub.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + service_charge);
            tpTax.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + service_charge) * tax) / 100);
            double iTax = Convert.ToDouble(tpTax.Text);
            tpTotal.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + iTax+ service_charge);

            txbCostCake.Text = String.Format("{0:C}", cost_of_cakes);
            txbCostDrink.Text = String.Format("{0:C}  ", cost_of_drinks);
            txbService.Text = String.Format("{0:C}  ", service_charge);
            tpSub.Text = String.Format("{0:C}  ", (cost_of_cakes+ cost_of_drinks+ service_charge));
            tpTax.Text = String.Format("{0:C}  ", iTax);
            tpTotal.Text = String.Format("{0:C}  ", (cost_of_drinks + cost_of_cakes + iTax + service_charge));
        }
    }
}
