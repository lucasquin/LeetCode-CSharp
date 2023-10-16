using LeetCode;
using System.Diagnostics;

Solution solution = new();
Stopwatch stopwatch = new();

stopwatch.Start();
long startMemory = Process.GetCurrentProcess().WorkingSet64;

// Start

int[] x = { 2, 5, 5, 11 };
solution.IsPalindrome(121);

// End

long endMemory = Process.GetCurrentProcess().WorkingSet64;
stopwatch.Stop();
long memoryUsed = startMemory - endMemory;
Console.WriteLine("Result: ");
Console.WriteLine($"Memory used: {memoryUsed / (1024.0 * 1024.0)} MB");
Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
