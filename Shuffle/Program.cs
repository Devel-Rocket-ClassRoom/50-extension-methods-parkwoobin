using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.


List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> cards = new List<string> { "♠A", "♥K", "♦Q", "♣J" };
List<string> students = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };


Console.WriteLine("=== 컬렉션 셔플 테스트 ===");

Console.WriteLine("\n[숫자 리스트 셔플]");
Console.WriteLine($"원본: {string.Join(", ", numbers)}");
numbers.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", numbers)}");

Console.WriteLine("\n[카드 덱 셔플]");
Console.WriteLine($"원본: {string.Join(", ", cards)}");
cards.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", cards)}");

Console.WriteLine("\n[학생 순서 무작위 배치]");
Console.WriteLine($"원본: {string.Join(", ", students)}");
students.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", students)}");





public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        if (list is null)
        {
            throw new ArgumentNullException(nameof(list));
        }
        Random random = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}