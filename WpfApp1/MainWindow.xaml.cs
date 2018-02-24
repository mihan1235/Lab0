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
using Test;

namespace WpfApp1
{
    class InputException: Exception
    {

    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestList test_list = new TestList();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            list_date.ItemsSource = test_list.List;
        }

        private void show_number(object sender, SelectionChangedEventArgs e)
        {
            text_output_selected_date.Text = list_date.SelectedIndex.ToString();
        }

        private void button_show_list_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(test_list.ToString(),"All items of List<TestElement>",MessageBoxButton.OK);
        }

       
        private void button_add_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show(textbox_add_date.Text, "new date", MessageBoxButton.OK);
            String input_date = textbox_add_date.Text;
            textbox_add_date.Text = null;
            try
            {
                string[] date_numbers = input_date.Split(new char[1] { ',' });
                if (date_numbers.Length > 3)
                {
                    throw (new InputException());
                }
                int day = int.Parse(date_numbers[0]);
                int month = int.Parse(date_numbers[1]);
                int year = int.Parse(date_numbers[2]);
                
                test_list.List.Add(new TestElement(day, month, year));
                list_date.Items.Refresh();
            }
            catch (Exception a)
            {
                MessageBox.Show("Bad input date!! Example input: [day],[month],[year]", "Error", MessageBoxButton.OK);
            }
            
        }
    }
}
