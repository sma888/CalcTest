using System;
using System.Windows;
using System.Windows.Media.Animation;
using static System.Math;

namespace CalcApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        float a = 0, b = 0;
        int count = 0, kol = 0;
        bool znak = true;
        double exp = 2.71828; double MS = 0;
       

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 3;
        }

        private void Nol_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.IndexOf("0") == 0 && textBox.Text.IndexOf(",") != 1) { }
            else
                textBox.Text = textBox.Text + 0;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 4;
        }

        private void Zap_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.IndexOf(",") >= 1) { }
            else if (textBox.Text != "")
                textBox.Text = textBox.Text + ",";
            else MessageBox.Show("Заполните поле!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 6;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 9;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
                MessageBox.Show("Заполните поле!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                a = float.Parse(textBox.Text);
                textBox.Clear();
                count = 1;
                label1.Text = a.ToString() + "+";
                znak = true;
            }
        }

       

        private void Znam_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox.Text);
            b = 1 / a;
            textBox.Text = b.ToString();
        }

        private void Proc_Click(object sender, RoutedEventArgs e)
        {
            
                a = float.Parse(textBox.Text);
                textBox.Clear();
                count = 9;
                label1.Text = a.ToString() + "% * ";
                znak = true;
            
        }

        private void C_Button(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            label1.Text = "";
        }

        private void Ravn_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                switch (count)
                {
                    case 1:
                        b = a + float.Parse(textBox.Text);
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 2:
                        b = a - float.Parse(textBox.Text);
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 3:
                        b = a * float.Parse(textBox.Text);
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 4:
                        b = a / float.Parse(textBox.Text);
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 5:
                        b = (float)Cos(float.Parse(textBox.Text));
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 6:
                        b = (float)Sin(float.Parse(textBox.Text));
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 7:
                        b = (float)Tan(float.Parse(textBox.Text));
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 8:
                        b = (float)Pow(a, float.Parse(textBox.Text));
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 9:
                        b = (float)(a / 100 * float.Parse(textBox.Text));
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;
                    case 10:
                        b = (float)Pow(a, 1 / float.Parse(textBox.Text));
                        textBox.Text = b.ToString();
                        label1.Text = "";
                        break;

                    default:
                        break;
                }
            }
            else MessageBox.Show("Введите число", "Предупреждение");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
                MessageBox.Show("Заполните поле!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                a = float.Parse(textBox.Text);
                textBox.Clear();
                count = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
                kol++;
            }
        }

        private void Umn_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
                MessageBox.Show("Заполните поле!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                a = float.Parse(textBox.Text);
                textBox.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
            }
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {
            int lenght = textBox.Text.Length - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox.Text = textBox.Text + text[i];
            }
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = Sqrt(Convert.ToDouble(textBox.Text)).ToString();
        }

        private void delen_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
                MessageBox.Show("Заполните поле!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                a = float.Parse(textBox.Text);
                textBox.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
            }
        }

        private void PlMin_Click(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                textBox.Text = "-" + textBox.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox.Text = textBox.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Kvad_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = (Math.Pow(Convert.ToDouble(textBox.Text),2)).ToString();
        }
    }
}
