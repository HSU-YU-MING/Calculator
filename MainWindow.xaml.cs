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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "1";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "1";」是一樣的
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; 
            txtNumber.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "9";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = txtNumber.Text + "0";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = 0; //選擇「加」號
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1; //選擇「減」號
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2; //選擇「乘」號
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3; //選擇「除」號
        }
        
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            float ans = 0;
            secondNumber = Convert.ToSingle(txtNumber.Text);

            if(operators == 0)
            {
                ans = firstNumber + secondNumber;
            }
            else if (operators == 1)
            {
                ans = firstNumber - secondNumber;
            }
            else if (operators == 2)
            {
                ans = firstNumber * secondNumber;
            }
            else if (operators == 3)
            {
                ans = firstNumber / secondNumber;
            }
            txtNumber.Text = ans.ToString();
        }

    }
}
