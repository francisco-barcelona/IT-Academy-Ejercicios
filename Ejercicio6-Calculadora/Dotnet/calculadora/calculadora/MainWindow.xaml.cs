using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using System.Xml.Schema;

namespace calculadora
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

        private decimal numero1 = 0;
        private decimal numero2 = 0;
        private int operacion = 0;

        public void numero1Set(decimal num)
        {
                numero1 = num;            
        }

        public decimal numero1Get()
        {
            return numero1;
        }

        public void numero2Set(decimal num)
        {
            numero2 = num;
        }

        public decimal numero2Get()
        {
            return numero2;
        }

        public void operacionSet(int num)
        {
            operacion = num;
        }

        public int operacionGet()
        {
            return operacion;
        }

        public void Clear()
        {
            Num1.Clear();
        }

        public void Escribir(string num)
        {
            Num1.Text = Num1.Text + num;
        }      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Escribir("1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Escribir("2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Escribir("3");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Escribir("4");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Escribir("5");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Escribir("6");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Escribir("7");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Escribir("8");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Escribir("9");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Escribir("0");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Escribir(".");
        }

        // botón suma
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = decimal.Parse(Num1.Text);
                operacionSet(1);
                numero1Set(num);
                Clear();
            }
            catch (System.FormatException)
            {
                Num1.Text = "Escribe un número correcto";
            }           
        }

        // botón resta
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = decimal.Parse(Num1.Text);
                operacionSet(2);
                numero1Set(num);
                Clear();
            }
            catch (System.FormatException)
            {
                Num1.Text = "Escribe un número correcto";
            }
        }

        // botón multiplicación
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = decimal.Parse(Num1.Text);
                operacionSet(3);
                numero1Set(num);
                Clear();
            }
            catch (System.FormatException)
            {
                Num1.Text = "Escribe un número correcto";
            }
        }

        // botón division
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = decimal.Parse(Num1.Text);
                operacionSet(4);
                numero1Set(num);
                Clear();
            }
            catch (System.FormatException)
            {
                Num1.Text = "Escribe un número correcto";
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = decimal.Parse(Num1.Text);
                numero2Set(num);
                Clear();

                if (operacionGet() == 1)
                {
                    Suma(numero1Get(), numero2Get());
                }
                else if (operacionGet() == 2)
                {
                    Resta(numero1Get(), numero2Get());
                }
                else if (operacionGet() == 3)
                {
                    Multiplicacion(numero1Get(), numero2Get());
                }
                else
                {
                    Division(numero1Get(), numero2Get());
                }
                Restaurar();
            }
            catch (System.FormatException)
            {
                Num1.Text = "Escribe un número correcto";
            }   
        }

        public void Suma(decimal num1, decimal num2)
        {
            var suma = num1 + num2;
            Num1.Text = suma.ToString();
        }

        public void Resta(decimal num1, decimal num2)
        {
            var resta = num1 - num2;
            Num1.Text = resta.ToString();
        }

        public void Multiplicacion(decimal num1, decimal num2)
        {
            var multiplicacion = num1 * num2;
            Num1.Text = multiplicacion.ToString();
        }

        public void Division(decimal num1, decimal num2)
        {
            var division = num1 / num2;
            Num1.Text = division.ToString();
        }
        
        public void Restaurar()
        {
            numero1Set(0);
            numero2Set(0);
            operacionSet(0);
        }
    }
}
