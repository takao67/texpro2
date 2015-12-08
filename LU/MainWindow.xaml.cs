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
        int x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20;
        

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
            
            
             if (comboBox1.SelectedIndex == 0)
            {
                x4 = 1;
                x8 = 1;
                x12 = 1;
                x13 = 1;
                x14 = 1;
                x15 = 1;
                x16 = 1;
                x20 = 1;
            }
           if(comboBox1.SelectedIndex == 1)
            {
                x4 = Convert.ToInt32(textBox4.Text); 
                x8 = Convert.ToInt32(textBox8.Text);
                x13 = Convert.ToInt32(textBox13.Text);
                x14 = Convert.ToInt32(textBox14.Text);
                x15 = Convert.ToInt32(textBox15.Text);
                x16 = Convert.ToInt32(textBox16.Text);
                x20 = Convert.ToInt32(textBox20.Text);
            }

           //float l11 = x1;
           //float l21 = x2;
           //float l31 = x3;
           //float u12 = x5 / x1;
           //float u13 = x9 / x1;
           //float u14 = x13 / x1;
        

        }

        
        }

        }


    


