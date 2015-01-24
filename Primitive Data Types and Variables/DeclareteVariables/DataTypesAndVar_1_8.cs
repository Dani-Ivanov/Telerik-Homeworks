using System;

class DeclareteVariables
{
    static void Main()
    {
        //Problem 1. Declare Variables
        //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
        //Submit the source code of your Visual Studio project as part of your homework submission.
        separateProblems("Problem 1. Declare Variables");

        ushort n1 = 52130;
        sbyte n2 = -115;
        uint n3 = 4825932;
        byte n4 = 97;
        short n5 = -10000;

        Console.WriteLine("n1 = {0} ushort, n2 = {1} sbyte, n3 = {2} uint, n4 = {3} byte, n5 = {4} short", n1, n2, n3, n4, n5);

        //Problem 2. Float or Double?
        //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        //Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        separateProblems("Problem 2. Float or Double?");

        double isDouble = 34.567839023;
        float isFloat1 = 12.345f;
        double isDouble2 = 8923.1234857;
        float isFloat2 = 3456.091f;

        Console.WriteLine("n1 = {0} double, n2 = {1} float, n3 = {2} double, n4 = {3} float", isDouble, isFloat1, isDouble2, isFloat2);

        //Problem 3. Variable in Hexadecimal Format
        //Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
        //Use Windows Calculator to find its hexadecimal representation.
        //Print the variable and ensure that the result is 254.
        separateProblems("Problem 3. Variable in Hexadecimal Format");

        string hexValue = "0xFE";
        int decValue = Convert.ToInt32(hexValue, 16);

        Console.WriteLine("Hexdecimal number {0} to decimal is {1}",hexValue,decValue);

        //Problem 4. Unicode Character
        //Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        //Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
        separateProblems("Problem 4. Unicode Character");

        char mySymbol = '\u002A';

        Console.WriteLine("u002A to char = {0}", mySymbol);
        //Problem 5. Boolean Variable
        //Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
        //Print it on the console.
        separateProblems("Problem 5. Boolean Variable");

        bool isFemale = false;

        Console.WriteLine("Is Dani Ivanov female: {0}", isFemale);

        //Problem 6. Strings and Objects
        //Declare two string variables and assign them with Hello and World.
        //Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
        //Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
        separateProblems("Problem 6. Strings and Objects");
        

        string hello = "Hello ";
        string world = "World";
        object HelloWorld = hello + world;
        string blyat = HelloWorld.ToString();

        Console.WriteLine(blyat);

        //Problem 7. Quotes in Strings
        //Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
        //Do the above in two different ways - with and without using quoted strings.
        //Print the variables to ensure that their value was correctly defined
        
        separateProblems("Problem 7. Quotes in Strings");

        string string1= "The \"use\" of quotations causes difficulties.";
        string string2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(string1);
        Console.WriteLine(string2);
        Console.WriteLine();

        //Problem 8. Isosceles Triangle
        separateProblems("Problem 8. Isosceles Triangle");

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine(@" 
   ©
  © ©
 ©   ©
© © © ©
                            ");
    }
    static void separateProblems(string s)
    {
        string separator = new String('-', 80);
        Console.WriteLine(separator);
        Console.WriteLine(s);
        Console.WriteLine();
    }
}