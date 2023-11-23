namespace Code;
class Variables
{
    public void Main()
    {
        //                                             ========== Our first example from the PowerPoint, exlaining how to declare variables. ==========

        //Defining our initial variables using the type keywords.
        int mealsToday = 4; //Integers are whole numbers, and can be negative or zero.
        float price = 29.99f; //the 'f' behind the number is important, as the compiler will otherwise not recognize the number as a float, resulting in an error.
        bool isHavingFun = false; //Booleans can only be true or false

        string exampleString = "This is just an example, and is not used for anything... At all. What a sad purpose for a string :("; //Strings are text, numbers, special characters and everything else in ASCII enclosed in double-quotes.
        char exampleCharacter = 'h'; //A string is a single character, number, special character or anything else included in ASCII enclosed in single-quotes.

        //Below are some examples on formatting of strings.
        string formattingAString1 = "You cannot make double-quotes inside the double-quotes defining a string, but you can use: \", which formats as just a double-quote";
        string formattingAString2 = "You can also use: \n to get a new line";
        string formattingAString3 = "As the backslash indicates you making some kind of exception, for a backslash you do: \\";
        string formattingAString4 = "Use: \t to make a tab in a string";

        //It is seldom of any use, but you can also format chars:
        char formattingWithAChar = '\n'; //Even though this is 2 characters, '\' and 'n', it is recognized as one character because it is technically defining a single character, this one for example, is called the "Newline Character".

        string fix = exampleString + exampleCharacter + formattingAString1 + formattingAString2 + formattingAString3 + formattingAString4 + formattingWithAChar; //IGNORE THIS

        Console.WriteLine($"Meals today: {mealsToday}|Price: {price}|Is having fun: {isHavingFun}"); //This prints all the data to the console before editing the variables.

        //Accesing and changing our variables.
        //int mealsToday = 5; //Gives error: A local variable or function named 'mealsToday' is already defined in this scope, meaning that the scope aldready has a variable named 'mealsToday' declared. Uncomment to see error.
        mealsToday = 5;
        price = 37.49f;
        isHavingFun = true;

        Console.WriteLine($"Meals today: {mealsToday}|Price: {price}|Is having fun: {isHavingFun}"); //This prints all the data to the console after editing the variables.

        //                                             ========== Our second example from the PowerPoint, showing a variable at work. ==========

        float originalPrice = 59.95f; //Picking some price.
        float discount = 0.3f; //A discount for the price.
        float discountedPrice; //Defining the variable for the price after applying discount. This one is currently not assigned a value, but as long as we do that before using it, we won't run into an error.

        discountedPrice = originalPrice * (1 - discount); //Here we are making a new variable, and using it to store the price after having the discount subtracted.
        Console.WriteLine($"Price after discount: {discountedPrice}");  //Prints = 41.965

        discount = 0.5f; //Changing our discount variable.
        discountedPrice = originalPrice * (1 - discount); //Calculating new discounted price after updating the discount.
        Console.WriteLine($"Price after discount: {discountedPrice}");  //Prints = 29.975

        //                                             ========== The third example from the PowerPoint, showcasing different common cases used for programming. ==========

        int yearsOld = 21; //The most used. In C#, it is used for variables, in many other languages, it is used for functions/methods as well.
        int YearsOld = 21; //Used in C# for functions and classes.
        int years_old = 21; //Rarely seen. Used for example in Python and Ruby for naming functions/methods.
        //int years-old = 21; //This one is called kebab-case, or hyphen-case. It is most commonly found in HTML and CSS for naming classes, IDs and attributes. It is commented out here, because you cannot do kebab-case in C#, feel free to uncomment to see the error.

        Console.WriteLine((yearsOld + YearsOld + years_old) / 3);
    }
}
