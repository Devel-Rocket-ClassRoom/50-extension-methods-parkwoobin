using System;
using System.Collections.Generic;
using System.Linq;




Console.WriteLine("=== 컬렉션 청킹 테스트 ===");
Console.WriteLine("\n[숫자를 3개씩 그룹화]");

IEnumerable<int> numbers = Enumerable.Range(1, 10);
foreach (IEnumerable<int> chunk in numbers.Chunk(3))
{
    Console.WriteLine($"[{string.Join(", ", chunk)}]");
}

Console.WriteLine("\n[학생들을 2명씩 팀 구성]");
string[] students = { "김철수", "이영희", "박민수", "최지연", "정우진" };
int teamNumber = 1;

foreach (IEnumerable<string> team in students.Chunk(2))
{
    Console.WriteLine($"팀 {teamNumber}: {string.Join(", ", team)}");
    teamNumber++;
}

Console.WriteLine("\n[페이지별로 5개씩 나누기]");
IEnumerable<int> pages = Enumerable.Range(1, 25);
int pageNumber = 1;

foreach (IEnumerable<int> page in pages.Chunk(5))
{
    Console.WriteLine($"페이지 {pageNumber}: {string.Join(", ", page)}");
    pageNumber++;
}



public static class EnumerableExtensions
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (size < 1)
        {
            throw new ArgumentException("청크 크기는 1 이상이어야 합니다.", nameof(size));
        }

        return ChunkIterator(source, size);
    }

    private static IEnumerable<IEnumerable<T>> ChunkIterator<T>(IEnumerable<T> source, int size)
    {
        List<T> current = new(size);

        foreach (T item in source)
        {
            current.Add(item);

            if (current.Count == size)
            {
                yield return current;
                current = new List<T>(size);
            }
        }

        if (current.Count > 0)
        {
            yield return current;
        }
    }
}




