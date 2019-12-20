# CSharp-BasicConverter-BasicCalculator-
A basic converter and a basic calculator using C#

				
Unless otherwise stated, all your programs should be created as Visual Studio C# windows form applications. You must add C# winforms desktop development to the latest visual studio if not already installed.
1. Write a C# application that creates a multi conversion tool. The program must allow the user to choose the type of conversion that they require, perform the conversion and output the result of the conversion.  The user should then be able to perform another conversion.  The multi conversion tool will allow the user to convert from inches to feet (12 inches equals 1 foot), from pounds to Euro (1 Euro equals 0.79 pounds), or from Celsius to Fahrenheit (celsius = 5/9 (fahr – 32) or fahr = (celsius * 9/5) + 32)).

2.Write a C# application that implements a partially functional calculator (see Windows calculator for functionality).  The program must allow the user to enter numbers and perform, addition, subtraction, multiplication and division. The user may enter two operands and perform a calculation, then using the result of this calculation the user can perform further calculations.  The program must implement the numeric keypad using buttons on the form. 
 
Some Sample Code
Converting between a number and a string and visa versa


txtNumber and txtResult are textboxes

Double num = Convert.ToDouble( txtNumber.Text);
    	num = num * 1.3;
     txtResult.Text = Convert.ToString(num);
