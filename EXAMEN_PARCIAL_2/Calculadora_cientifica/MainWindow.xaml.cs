using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using org.mariuszgromada.math.mxparser;
using System.Reflection;

namespace Calculadora_cientifica
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

        private bool isNewCalculation = true;
        private string errorMessage = "Error: Expresión no válida";
        private List<string> memory = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(Del);
        }

        public void asignarvalor(Button btpresionado)
        {
            string content = btpresionado.Content.ToString();

            if (content == "Del")
            {
                TBpantalla.Text = "";
                isNewCalculation = true;
            }
            else if (content == "=")
            {
                Calculate();
            }
            else if (content == "sin")
            {
                if (isNewCalculation)
                {
                    isNewCalculation = false;
                    TBpantalla.Text = "";
                }
                TBpantalla.Text += "sin(";
            }
            else if (content == "cos")
            {
                if (isNewCalculation)
                {
                    isNewCalculation = false;
                    TBpantalla.Text = "";
                }
                TBpantalla.Text += "cos(";
            }
            else if (content == "tan")
            {
                if (isNewCalculation)
                {
                    isNewCalculation = false;
                    TBpantalla.Text = "";
                }
                TBpantalla.Text += "tan(";
            }
            else if (content == "√")
            {
                if (isNewCalculation)
                {
                    isNewCalculation = false;
                    TBpantalla.Text = "";
                }
                TBpantalla.Text += "sqrt(";
            }
            else if (content == "MC")
            {
                memory.Clear();
            }
            else if (content == "MR")
            {
                TBpantalla.Text += string.Join(Environment.NewLine, memory);
            }
            else if (content == "MS")
            {
                memory.Add(TBpantalla.Text + " = " + EvaluateExpression(TBpantalla.Text));
            }
            else if (content == "M+")
            {
                memory.Add(TBpantalla.Text + " = " + EvaluateExpression(TBpantalla.Text));
            }
            else
            {
                if (isNewCalculation)
                {
                    isNewCalculation = false;
                    TBpantalla.Text = "";
                }
                TBpantalla.Text += content;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn1);
        }

        private void multi_Copiar_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(Sqrt);
        }

        private void multi_Copiar1_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(Elevar);
        }

        private void btn2_Click_1(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn2);
        }

        private void btn3_Click_1(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn3);
        }

        private void btn4_Click_1(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn6);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn9);
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(btn10);
        }

        private void sen_Click_1(object sender, RoutedEventArgs e)
        {
            asignarvalor(sen);
        }

        private void cos_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(cos);
        }

        private void tan_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(tan);
        }

        private void mas_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(mas);
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(div);
        }

        private void menos_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(menos);
        }

        private void parentecis_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(parentecis);
        }

        private void multi_Click_1(object sender, RoutedEventArgs e)
        {
            asignarvalor(multi);
        }

        private void parentecis2_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(parentecis2);
        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }


        private void Calculate()
        {
            try
            {
                string expression = TBpantalla.Text;
                string result = EvaluateExpression(expression);
                TBpantalla.Text = result;
                memory.Add(expression + " = " + result);
                isNewCalculation = true;
            }
            catch (Exception ex)
            {
                TBpantalla.Text = errorMessage;
                isNewCalculation = true;
            }
        }

        private string EvaluateExpression(string expression)
        {
            try
            {
                org.mariuszgromada.math.mxparser.Expression expr = new org.mariuszgromada.math.mxparser.Expression(TBpantalla.Text);
                double result = expr.calculate();
                return result.ToString();
            }
            catch (Exception ex)
            {
                return errorMessage;
            }
        }

        private void M1_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(M1);
        }

        private void m2_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(m2);
        }

        private void MC_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(MC);
        }

        private void MR_Click(object sender, RoutedEventArgs e)
        {
            asignarvalor(MR);
        }
    }
}