// See https://aka.ms/new-console-template for more information
using logical_test;

Console.WriteLine("Logical list:");
Console.WriteLine("1. Palindrome");
Console.WriteLine("2. Counting Triangle Stars");
Console.WriteLine("3. Get triangle (input 3 value)");
Console.WriteLine("");
Console.WriteLine("Please choose:");

GetOption:
string strOption = Console.ReadLine();

if (strOption == "1")
{
    Console.WriteLine("****************** Palindrome test ******************");
    Console.WriteLine("Please enter your word below (type exit for close the program)");

    logicals objLogicals = new logicals();
    string strInput = Console.ReadLine();

retry:
    if (strInput.ToLower() != "exit")
    {
        Console.WriteLine("Word: " + strInput);
        Console.WriteLine("Is palindrome: " + objLogicals.IsPalindrome(strInput.ToLower().Replace(" ", "")));
        Console.WriteLine("");
        Console.WriteLine("type another word");
        strInput = Console.ReadLine();
        goto retry;
    }
}
else if (strOption == "2")
{
    Console.WriteLine("****************** Triangle test ******************");
    Console.WriteLine("Please enter the number of star (type exit for close the program)");

    logicals objLogicals = new logicals();
    string strInput = Console.ReadLine();

retry:
    if (strInput.ToLower() != "exit")
    {
        Console.WriteLine("Star(s): " + strInput);
        objLogicals.Stars(Convert.ToInt32(strInput));
        Console.WriteLine("");
        Console.WriteLine("type another star");
        strInput = Console.ReadLine();
        goto retry;
    }
}
else if (strOption == "3")
{
    Console.WriteLine("****************** Get Triangle ******************");
    Console.WriteLine("Please enter 3 number by typing OK for the first (type exit for close the program)");

    string strInput = Console.ReadLine();
retry:
    if (strInput == "OK")
    {
        logicals objLogicals = new logicals();
        Console.WriteLine("Value a : ");
        string strInput1 = Console.ReadLine();
        Console.WriteLine("Value b : ");
        string strInput2 = Console.ReadLine();
        Console.WriteLine("Value c : ");
        string strInput3 = Console.ReadLine();

        Console.WriteLine("Your input: " + strInput1 + ", " + strInput2 + ", " + strInput3);
        Console.WriteLine(objLogicals.TriangleType(Convert.ToInt32(strInput1), Convert.ToInt32(strInput2), Convert.ToInt32(strInput3)));
        Console.WriteLine("type OK if you wanna repeat or type anything to exit");
        strInput = Console.ReadLine();
        Console.WriteLine("");
        goto retry;
    }
}
else
{
    Console.WriteLine("Please choose the logical test");
    goto GetOption;
}