using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dealer d;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            d = new Dealer();
            d.Generate();
            d.Randomize();
            txtResult.Text = "";

            foreach(Card c in d.Deck)
            {
                txtResult.Text += c.Symbol + c.Suit + "\n";
            }

            

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Card card = d.Deal();
            MessageBox.Show(c.Suit + c.Symbol);

            txtResult.Text = "";

            foreach (Card c in d.Deck)
            {
                txtResult.Text += c.Symbol + c.Suit + "\n";
            }

            MessageBox.Show(card.Suit + card.Symbol);

           

        }
    }
}
