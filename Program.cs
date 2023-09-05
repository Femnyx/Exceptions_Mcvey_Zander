// See https://aka.ms/new-console-template for more information

//Sets the myFloat's, myOtherFloat's, and result digits.
float myFloat = 65.4f;
float myOtherFloat = 0.0f;
float result = 0f;

//
Random rand = new Random();
int myInt = rand.Next(2, 30);

//Divides the myFloat and myOtherFloat, making it the result. In the catch, it will message the user saying enter a number other than zero.
try
{
    result = Divide(myFloat, myOtherFloat);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Please enter a number other than zero.");
    myOtherFloat = (float) Convert.ToDouble(Console.ReadLine());

    //the 2nd message after the first if you put something invalid will repeat the message and calculate it.
    try
    {
        result = Divide(myFloat, myOtherFloat);
    }
    catch (Exception e2)
    {
        Console.WriteLine(e2.Message);
        
    }
    finally
    {
        Console.WriteLine("Calculations completed with a result of " + result);
    }

    //Checks the age of what result has. it will decide if you are old enough.
    try
    {
        CheckAge(myInt);
    }catch
    {
        Console.WriteLine($"You are {myInt}, YOU ARE NOT OLD ENOUGH! SCRAM!");
    }
}

//Makes the Divide function, allowing us to divide two floats for a result.
static float Divide(float x, float y)
{
    if (y == 0)
    {
        throw new DivideByZeroException();
    }
    else
    {
        return x / y;
    }
}
  //Makes the CheckAge function, looking back on the result to see if the user is old enough.
static void CheckAge(int age)
    {
        if (age >= 17)
        {
            Console.WriteLine($"You are {age}, you can play mature games!");
        }
        else
        {
            throw new ArgumentException();
        }
    }

