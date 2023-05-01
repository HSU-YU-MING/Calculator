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
            Add_Number("1"); // 只需要呼叫Add_Number函式，並且設定參數為數字1
            //if (txtNumber.Text == "0")
            //    txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            //txtNumber.Text += "1";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "1";」是一樣的
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("9");
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("0");
        }

        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(0);
            //firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            //txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            //operators = 0; //選擇「加」號
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(1);
            
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(2);
            
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(3);
            
        }

        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator; //選擇「加」號
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            // 確認輸入文字框中完全沒有小數點
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = " ";
        }
 
    }
}
