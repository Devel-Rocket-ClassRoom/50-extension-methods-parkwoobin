using System;

// README.md를 읽고 코드를 작성하세요.




string message = "안녕하세요";
Console.WriteLine($"{message.First(3)}");


Player player = new Player { Name = "용사", Level = 5, Experience = 150 };
Console.WriteLine(player.GetInfo());
Console.WriteLine($"레벨업 가능? {player.CanLevelUp()}");
player.LevelUp();
Console.WriteLine(player.GetInfo());

public static class StringExtensions
{
    public static string First(this string text, int count)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        if (count >= text.Length)
        {
            return text;
        }
        return text.Substring(0, count);
    }
}

public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
}

public static class PlayerExtensions
{
    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }
    public static bool CanLevelUp(this Player player)
    {
        return player.Experience >= 100;
    }
    public static void LevelUp(this Player player)
    {
        if (player.CanLevelUp())
        {
            player.Level++;
            player.Experience -= 100;
            Console.WriteLine($"{player.Name}이(가) 레벨업! 현재 레벨: {player.Level}");
        }
    }
}