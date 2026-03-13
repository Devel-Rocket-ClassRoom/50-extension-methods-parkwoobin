using System;
using System.Runtime.CompilerServices;

// README.md를 읽고 코드를 작성하세요.

string message = "  Hello World!  ";

string result1 = StringExtensions.Replace(
    StringExtensions.Upper(
        StringExtensions.Trim(message)), ' ', '_');

Console.WriteLine($"결과1: {result1}");

string result2 = StringExtensions
    .Upper(message)
    .Trim()
    .Replace(' ', '_');
Console.WriteLine($"결과2: {result2}");


SecretBoxExtensions.ShowData(new SecretBox());


Greeter g = new Greeter();
g.SayHello();
g.SayGoodbye();

GreeterExtensions.SayHello(g);



public static class StringExtensions
{
    public static string Upper(this string text)
    {
        return text.ToUpper();
    }
    public static string Trim(this string text)
    {
        return text.Trim();
    }
    public static string Replace(this string text, char oldChar, char newChar)
    {
        return text.Replace(oldChar, newChar);
    }
}


public class SecretBox
{
    private string _secret = "비밀";
    public string PublicData = "공개";
}

public static class SecretBoxExtensions
{
    public static void ShowData(this SecretBox box)
    {
        Console.WriteLine($"공개 데이터: {box.PublicData}");
    }
}


public class Greeter
{
    public void SayHello()
    {
        Console.WriteLine($"인스턴스 메서드: 안녕하세요!");
    }
}

public static class GreeterExtensions
{
    public static void SayHello(this Greeter greeter)
    {
        Console.WriteLine($"확장 메서드: 반갑습니다!");
    }
    public static void SayGoodbye(this Greeter greeter)
    {
        Console.WriteLine($"확장 메서드: 안녕히 가세요!");
    }

}