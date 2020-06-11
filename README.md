# SimplePerformanceChecker
A Simple Performance Check!

<br>

## Environment
- Visual Studio 2019
- .NET Core 3.1

<br>

## Usage
using `SimplePerformanceChecker`.
```csharp
using SimplePerformanceChecker;
```

<br>

Compare performance of `Method1` and `Method2`.  
**Methods must not be have input and output argument.**
```csharp
PerformanceChecker checker = new PerformanceChecker(Method1, Method2);
```
or
```csharp
PerformanceChecker checker = new PerformanceChecker(Method1, Method2, 1_000_000);
```
The 3rd argument is `CountOfPerform` that has a default value of 1 and may or may not be included.  
<br>
<br>
`CountOfPerform` is number of times to perform each method.
```csharp
checker.CountOfPerform = 1_000_000;
```

<br>

`Perform()` returns a list that elapsed time in each method in seconds.
```csharp
var elapsedTimes = checker.Perform();
foreach (double elapsedTime in elapsedTimes)
{
    Console.WriteLine(elapsedTime);
}
// 1.160833
// 1.874759
```

<br>

`PerformResult()` returns the string that result of performance. 
```csharp
Console.WriteLine(checker.PerformResult());
// ================================
// Method1 : 1.160833sec
// Method2 : 1.874759sec
// ================================
```
