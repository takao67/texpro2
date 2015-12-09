using System;
using System.Collections.Generic;
using System.Linq;
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

namespace LU
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
        int a11, a12, a13, a14, a21, a22, a23, a24, a31, a32, a33, a34, a41, a42, a43, a44, a17, a18, a19, a20;
        int u11, u12, u13, u14, u22, u23, u24, u33, u34, u44;
        int l21, l31, l41, l32, l42, l43;

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox4.Visibility = Visibility.Hidden;
                textBox8.Visibility = Visibility.Hidden;
                textBox12.Visibility = Visibility.Hidden;
                textBox13.Visibility = Visibility.Hidden;
                textBox14.Visibility = Visibility.Hidden;
                textBox15.Visibility = Visibility.Hidden;
                textBox16.Visibility = Visibility.Hidden;
                textBox20.Visibility = Visibility.Hidden;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox4.Visibility = Visibility;
                textBox8.Visibility = Visibility;
                textBox12.Visibility = Visibility;
                textBox13.Visibility = Visibility;
                textBox14.Visibility = Visibility;
                textBox15.Visibility = Visibility;
                textBox16.Visibility = Visibility;
                textBox20.Visibility = Visibility;
            }
        }
        

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {


            a11 = Convert.ToInt32(textBox1.Text);
            a21 = Convert.ToInt32(textBox2.Text);
            a31 = Convert.ToInt32(textBox3.Text);
            a41 = Convert.ToInt32(textBox4.Text);

            a12 = Convert.ToInt32(textBox5.Text);
            a22 = Convert.ToInt32(textBox6.Text);
            a32 = Convert.ToInt32(textBox7.Text);
            a42 = Convert.ToInt32(textBox8.Text);

            a13 = Convert.ToInt32(textBox9.Text);
            a23 = Convert.ToInt32(textBox10.Text);
            a33 = Convert.ToInt32(textBox11.Text);
            a43 = Convert.ToInt32(textBox12.Text);

            a14 = Convert.ToInt32(textBox13.Text);
            a24 = Convert.ToInt32(textBox14.Text);
            a34 = Convert.ToInt32(textBox15.Text);
            a44 = Convert.ToInt32(textBox16.Text);

            int vek1 = Convert.ToInt32(textBox17.Text);
            int vek2 = Convert.ToInt32(textBox18.Text);
            int vek3 = Convert.ToInt32(textBox19.Text);
            int vek4 = Convert.ToInt32(textBox20.Text);

            u11 = a11;
            u12 = a12;
            u13 = a13;
            u14 = a14;

            l21 = a21 / u11;
            l31 = a31 / u11;
            l41 = a41 / u11;

            u22 = a22 - (l21 * u12);
            u23 = a23 - (l21 * u13);
            u24 = a24 - (l21 * u14);

            l32 = (1 / u22) * (a32 - (l31 * u12));
            l42 = (1 / u22) * (a42 - (l41 * u12));

            u33 = a33 - ((l31 * u13) + (l32 * u23));
            u34 = a34 - ((l31 * u14) + (l32 * u24));

            l43 = (1 / u33) * (a43 - (l41 * u13) + (l42 * u23));

            u44 = a44 - ((l41 * u14) + (l42 * u24) + (l43 * u34));


            float b11, b21, b31, b41;
            b11 = vek1;
            b21 = vek2 - (a21 * vek1);
            b31 = vek3 - (a31 * vek1);
            b41 = vek4 - (a41 * vek1);

            float b32, b42;
            b32 = b31 - a32 * b21;
            b42 = b41 - a42 * b21;

            float b43;
            b43 = b42 - a43 * b32;

            float x1, x2, x3, x4;
            x4 = b43 / u44;
            x3 = (b32 - u34 * x4) / -b32;
            x2 = (b21 - u23 * x3 - u24 * x4) / u22;
            x1 = (b11 - u12 * x2 - u13 * x3) / u11;


            label1.Content = x1;
            label2.Content = x2;
            label3.Content = x3;
            label4.Content = x4;
        }

        
        }

        }


    


