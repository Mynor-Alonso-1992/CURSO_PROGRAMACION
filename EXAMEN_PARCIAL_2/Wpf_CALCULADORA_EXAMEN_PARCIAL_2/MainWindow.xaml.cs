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

namespace ScientificCalculatorWPF
{
    public partial class MainWindow : Window
    {
        private double memoryValue;
        private string history;

        public MainWindow()
        {
            InitializeComponent();
            history = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Content.ToString();

            switch (buttonText)
            {
                case "+":
                    // Implementar suma
                    break;
                case "-":
                    // Implementar resta
                    break;
                case "*":
                    // Implementar multiplicación
                    break;
                case "/":
                    // Implementar división
                    break;
                case "=":
                    // Mostrar resultado
                    break;
                case "M":
                    // Almacenar en memoria
                    break;
                case "MR":
                    // Recuperar de memoria
                    break;
                case "H":
                    // Mostrar historial
                    break;
                default:
                    // Procesar números y otros caracteres
                    break;
            }
        }
    }
}
