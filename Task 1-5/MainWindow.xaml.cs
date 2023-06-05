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

namespace WpfApp1
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLName.Text))
            {
                MessageBox.Show("Вы не заполнили Фамилию.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbFName.Text))
            {
                MessageBox.Show("Вы не заполнили Имя.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Вы не заполнили Телефон.");
                return;
            }
            if (string.IsNullOrWhiteSpace(dpBirthday.Text))
            {
                MessageBox.Show("Вы не указали дату.");
                return;
            }
            for (int i = 0; i < tbPhone.Text.Length; i++)
            {
                if (char.IsLetter(tbPhone.Text[i]))
                {
                    MessageBox.Show("В номере телефона должны быть только цифры.");
                    return;
                }
            }
            if (cmbGender.SelectedItem is null)
            {
                MessageBox.Show("Вы не указали пол.");
                return;
            }
            else
            {
                MessageBox.Show("Сотрудник добавлен.");
            }

        }
    }
}
