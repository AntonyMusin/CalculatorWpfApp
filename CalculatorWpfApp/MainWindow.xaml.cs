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

namespace CalculatorWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output = "";//Задаем необходимые переменные, которые будут содержать данные для "логики" калькулятора
        string operaton = "";
        double temp = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;//Получаем "Имя" кнопки и в зависимости от полученного имени
                                                //вносим в TextBlock те или иные цифры + ","

            switch (name)
            {
                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;

                case "OneBtn":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;

                case "TwoBtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;

                case "ThreeBtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "FourBtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "FiveBtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "SixBtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "DecimalBtn":
                    if (output.Contains(","))
                    {
                        break;
                    }
                    output += ",";
                    OutputTextBlock.Text = output;
                    break;
            }
        }
        //Обрабатываем события нажатия на кнопки арифметических действий
        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = Convert.ToDouble(output);
            output = "";
            operaton = "Minus";
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = Convert.ToDouble(output);
            output = "";
            operaton = "Plus";
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = Convert.ToDouble(output);
            output = "";
            operaton = "Divide";
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = Convert.ToDouble(output);
            output = "";
            operaton = "Multiplay";
        }

        //Обрабатываем событие нажатия на "=" в зависимости от ранее нажатого арифметического оператора
        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;
            switch(operaton)
            {
                case "Minus":
                    outputTemp = temp - Convert.ToDouble(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Plus":
                    outputTemp = temp + Convert.ToDouble(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Multiplay":
                    outputTemp = temp * Convert.ToDouble(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Divide":
                    if (Convert.ToDouble(output)!=0)
                    {
                        outputTemp = temp / Convert.ToDouble(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                    }
                    break;
            }
        }


        //Очистка дисплея
        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
        }
        //Реализация дополнительных алгебраических функций
        private void SquareBtn_Click(object sender, RoutedEventArgs e)
        {
            double squareOutput = Convert.ToDouble(output);
            OutputTextBlock.Text = Convert.ToString(squareOutput * squareOutput);
        }

        private void SquareRootBtn_Click(object sender, RoutedEventArgs e)
        {
            double squareRootOutput = Convert.ToDouble(output);
            OutputTextBlock.Text = Convert.ToString(Math.Sqrt(squareRootOutput));
        }

    }
}
