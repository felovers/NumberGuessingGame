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
using System.Windows.Shapes;

namespace NumberGuessingGame
{
    /// <summary>
    /// Interaction logic for InstructionsWindow.xaml
    /// </summary>
    public partial class InstructionsWindow : Window
    {
        public InstructionsWindow()
        {
            InitializeComponent();
        }

        private void Continuar_Button_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();

            Close();
        }

        private void Voltar_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Close();
        }
    }
}
