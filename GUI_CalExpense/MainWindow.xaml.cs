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

namespace GUI_CalExpense
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

        private void getResult()
        {
            double vTotal = double.Parse(txtWishList.Text) / (double.Parse(txtIncome.Text) - double.Parse(txtExpense.Text) ) ;
            txtTotal.Text = vTotal.ToString();
        }

        private bool chkValue()
        {
            int chkTxtIncome = txtIncome.Text.Length, chkTxtExpense = txtExpense.Text.Length, chkTxtWishlist = txtWishList.Text.Length;
            if (chkTxtIncome == 0) 
            {
                txtIncome.Focus();
                MessageBox.Show("Please input valuse");
                return false;
            }
            if (chkTxtExpense == 0)
            {
                txtExpense.Focus();
                MessageBox.Show("Please input valuse");
                return false;
            }
            if (chkTxtWishlist == 0)
            {
                txtWishList.Focus();
                MessageBox.Show("Please input valuse");
                return false;
            }
            return true;
        }
        
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (chkValue() == true)
            {
                getResult();
            }
        }

        private void txtIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIncome.Text, "[.][^0-9]")) 
            {
                MessageBox.Show("Please input only number");
                txtIncome.Focus();
                txtIncome.Clear();
            }
        }

        private void txtExpense_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtExpense.Text, "[.][^0-9]"))
            {
                MessageBox.Show("Please input only number");
                txtExpense.Focus();
                txtExpense.Clear();
            }
        }

        private void txtWishList_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtWishList.Text, "[.][^0-9]"))
            {
                MessageBox.Show("Please input only number");
                txtWishList.Focus();
                txtWishList.Clear();
            }

        }
    }
}
