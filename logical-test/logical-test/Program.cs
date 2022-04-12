// See https://aka.ms/new-console-template for more information
using logical_test;

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