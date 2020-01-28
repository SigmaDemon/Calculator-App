using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // These variables are used to store and process the user's input, building the calculation process
        string input = string.Empty; // this string stores the user's input
        string operand1 = string.Empty; // this string stores the first operand
        string operand2 = string.Empty; // this string stores the second operand
        char operation; // char makes the operation between numbers using characters like +,-,* or /
        double result = 0.0; // this double stores the results for the calculations 

        public MainPage()
        {
            this.InitializeComponent();
        }
        
        // The methods bellow are used to store the data that the user will enter when pressing on the calculator's buttons
        
        // This method will implement the input for the button 1 
        // Each time the user clicks on the numbered buttons, a string-based number will be added to the screen
        private void Button1(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = ""; // this statement and the third one allow the user to see what they are inputing in the calculator
            input += "1"; // this statement adds the input for each button
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 2
        private void Button2(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "2";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 3
        private void Button3(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "3";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 4
        private void Button4(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "4";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 5
        private void Button5(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "5";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 6
        private void Button6(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "6";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 7
        private void Button7(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "7";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 8
        private void Button8(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "8";
            this.Calculations_Box.Text += input; 
        }

        // This method will implement the input for the button 9
        private void Button9(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "9";
            this.Calculations_Box.Text += input;
        }

        // This method will implement the input for the button 0
        private void Button0(object sender, RoutedEventArgs e)
        {
            this.Calculations_Box.Text = "";
            input += "0";
            this.Calculations_Box.Text += input;
        }

        // For the operands, the code provided below will store the contents of the input string into the operand1 string
        // This method will implement the input for the button .
        private void Button_Dot(object sender, RoutedEventArgs e)
        {
            input += ".";
        }

        
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            input += "C";
            this.Calculations_Box.Text = ""; // This first line clears the text box
            this.input = string.Empty; // the last three lines empty the input, operand1 and operand2 strings and effectively clear everything
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        // This method will implement the input for the button /
        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        // This method will implement the input for the button *
        private void Button_Multiply(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }

        // This method will implement the input for the button +
        private void Button_Plus(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        // This method will implement the input for the button -
        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        // This final method will perform all the capabilities of the equal button and provide result inputs for all calculator scenarios
        private void Button_Equals(object sender, RoutedEventArgs e)
        {
            operand2 = input; // the input string is set equal to operand2, assuming that the user clicked on the = button
            double num1, num2; // these double variables will store the numerical values within operand1 and operand2
            double.TryParse(operand1, out num1); // the two TryParse lines convert the operand1 and operand2 strings into double types, placing them in num1 and num2
            double.TryParse(operand2, out num2);

            this.Calculations_Box.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            /* The if and else statements below are used for data comparisons 
             * The solution provides multiple conditions to form the calculation process for each calculator scenario
             * For example, if the condition for + is true then the condition is executed, if another option is selected such as a - then the else statement is executed
             */
            if (operation == '+')
            {
                result = num1 + num2; // the code will add the variables num1 and num2 together, storing the result in the result variable
                Calculations_Box.Text = result.ToString(); // this line converts the result variable to a string type and displays the output in the text box
            }
            else if (operation == '-')
            {
                result = num1 - num2; // this code will subtract num1 and num2
                Calculations_Box.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2; // this code will multiply num1 and num2
                Calculations_Box.Text = result.ToString();
            }
            else if (operation == '/') // this condition has an additional functionality
            {
                if (num2 != 0)
                {
                    result = num1 / num2; // this code will divide num1 and num2
                    Calculations_Box.Text = result.ToString();
                }
                else
                {
                    Calculations_Box.Text = "DIV/Zero!"; // this line will be displayed if any number is divided by 0
                }
            }
        }
    }
}
