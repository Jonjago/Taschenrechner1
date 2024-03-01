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
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
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

        Number number = new Number();
        Operator op = new Operator();

        // Result
        private void bt_result_Click(object sender, RoutedEventArgs e)
        {
            

            

            Output.Text = op.Rechnung(number.Zahl1, number.Zahl2);


        }


        // Number Buttons
        private void bt_7_Click(object sender, RoutedEventArgs e)
        {
            if(op.Operatoren == string.Empty)
            {
               number.Zahl1 += 7;
            }
            else
            {

                number.Zahl2 += 7;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;


        }

        private void bt_8_Click(object sender, RoutedEventArgs e)
        {

            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 8;
            }
            else
            {

                number.Zahl2 += 8;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_9_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 9;
            }
            else
            {

                number.Zahl2 += 9;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_4_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 4;
            }
            else
            {

                number.Zahl2 += 4;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_5_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 5;
            }
            else
            {

                number.Zahl2 += 5;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_6_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 6;
            }
            else
            {

                number.Zahl2 += 6;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 1;
            }
            else
            {

                number.Zahl2 += 1;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 2;
            }
            else
            {

                number.Zahl2 += 2;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 3;
            }
            else
            {

                number.Zahl2 += 3;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        private void bt_0_Click(object sender, RoutedEventArgs e)
        {
            if (op.Operatoren == string.Empty)
            {
                number.Zahl1 += 0;
            }
            else
            {

                number.Zahl2 += 0;

            }

            Output.Text = number.Zahl1 + op.Operatoren + number.Zahl2;
        }

        // Delete 
        private void bt_del_Click(object sender, RoutedEventArgs e)
        {
            op.Ergebnis = string.Empty;
            number.Zahl1 = string.Empty;
            number.Zahl2 = string.Empty;
            op.Operatoren = string.Empty;
            
        }



        // Operatoren

        private void bt_sub_Click(object sender, RoutedEventArgs e)
        {
            op.Operatoren = "-";
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            op.Operatoren = "+";
        }

        private void bt_multi_Click(object sender, RoutedEventArgs e)
        {
            op.Operatoren = "*";
        }

        private void bt_modulo_Click(object sender, RoutedEventArgs e)
        {
            op.Operatoren = "%";
        }

        private void bt_div_Click(object sender, RoutedEventArgs e)
        {
            op.Operatoren = "/";
        }


    }


    public class Number
    {

        private string zahl1 = string.Empty;
        private string zahl2 = string.Empty;

        public string Zahl1
        {
            get { return zahl1; }
            set { zahl1 = value; }
        }

        public string Zahl2
        {
            get { return zahl2;}
            set { zahl2 = value; } 
        }

    }


    public class Operator
    {
        private string operatoren = string.Empty;
        private string ergebnis;


        public string Operatoren
        {

            get { return operatoren; }
            set { operatoren = value; }

        }

        public string Ergebnis
        {

            get { return ergebnis; }
            set { ergebnis = value; }

        }


        public string Rechnung(string za1, string za2)
        {
            double z1 = Convert.ToDouble(za1);
            double z2 = Convert.ToDouble(za2);

            switch (Operatoren)
            {
                case "+":
                    Ergebnis = Convert.ToString(z1 + z2);
                break;

                case "-":
                    Ergebnis = Convert.ToString(z1 - z2);
                break;

                case "*":
                    Ergebnis = Convert.ToString(z1 * z2);
                break;

                case "/":
                    Ergebnis = Convert.ToString(z1 / z2);
                break;

                case "%":
                    Ergebnis = Convert.ToString(z1 % z2);
                break;
            }


            z1 = 0;
            z2 = 0;

            return Ergebnis;

            

        }


    }



}
