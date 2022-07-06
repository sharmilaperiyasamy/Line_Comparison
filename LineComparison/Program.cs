LineComparison.Line line = new LineComparison.Line();

double l1 = line.finding_length(5, 1, 3, 4);
double l2 = line.finding_length(6, 4, 10, 2);

Console.WriteLine("Length of Line 1 is :" + l1);
Console.WriteLine("Length of Line 2 is :" + l2);

//Console.WriteLine(l1.Equals(l2));
if (l1 > l2)
{
    Console.WriteLine("Line1 is greater than Line2.");
}
else if (l2 > l1)
{
    Console.WriteLine("Line2 is greater than Line1.");
}
else
{
    Console.WriteLine("Both Line1 and line2 are equal");
}