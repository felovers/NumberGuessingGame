using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NumberGuessingGame
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        int userNumber { get; set; }

        public GameWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);
            userNumber = 1;

            if (userNumber == randomNumber)
            {
                MessageBox.Show($"VOCÊ VENCEU!\r\nO Sistema também escolheu {randomNumber}.");
            }
            else
            {
                MessageBox.Show($"VOCÊ PERDEU!\r\nO Sistema escolheu {randomNumber}.");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);

            userNumber = 2;

            if (userNumber == randomNumber)
            {
                MessageBox.Show($"VOCÊ VENCEU!\r\nO Sistema também escolheu {randomNumber}.");
            }
            else
            {
                MessageBox.Show($"VOCÊ PERDEU!\r\nO Sistema escolheu {randomNumber}.");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);

            userNumber = 3;

            if (userNumber == randomNumber)
            {
                MessageBox.Show($"VOCÊ VENCEU!\r\nO Sistema também escolheu {randomNumber}.");
            }
            else
            {
                MessageBox.Show($"VOCÊ PERDEU!\r\nO Sistema escolheu {randomNumber}.");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);

            userNumber = 4;

            if (userNumber == randomNumber)
            {
                MessageBox.Show($"VOCÊ VENCEU!\r\nO Sistema também escolheu {randomNumber}.");
            }
            else
            {
                MessageBox.Show($"VOCÊ PERDEU!\r\nO Sistema escolheu {randomNumber}.");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);

            userNumber = 5;

            if (userNumber == randomNumber)
            {
                MessageBox.Show($"VOCÊ VENCEU!\r\nO Sistema também escolheu {randomNumber}.");
            }
            else
            {
                MessageBox.Show($"VOCÊ PERDEU!\r\nO Sistema escolheu {randomNumber}.");
            }
        }

        private void Menu_Principal_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Close();
        }
    }
}
