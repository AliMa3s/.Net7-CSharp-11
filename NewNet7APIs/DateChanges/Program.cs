using System.Diagnostics;

Console.WriteLine("Hit a key to start!");
Console.ReadLine();
var stopWatch = Stopwatch.StartNew();

Console.WriteLine("Hit a key to stop!");
Console.ReadLine();

stopWatch.Stop();

Console.WriteLine($"{stopWatch.Elapsed.TotalMilliseconds} ms");
Console.WriteLine($"{stopWatch.Elapsed.TotalMicroseconds} µs");
Console.WriteLine($"{stopWatch.Elapsed.TotalNanoseconds} ns");

var verySoon = DateTime.Now.AddMicroseconds(100);

Console.WriteLine(verySoon.ToLongTimeString());

Console.ReadLine() ;

