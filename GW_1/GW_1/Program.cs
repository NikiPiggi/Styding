using GW_1;

Dec d = new Dec(new int[] {1,2,3,4,5});

Console.WriteLine(d.toString());
Console.WriteLine(d.Head);
Console.WriteLine(d.Tail);
Console.WriteLine();

d.AddLeft(0);
Console.WriteLine(d.toString());
Console.WriteLine(d.Head);
Console.WriteLine(d.Tail);
Console.WriteLine();

d.AddRight(6);
Console.WriteLine(d.toString());
Console.WriteLine(d.Head);
Console.WriteLine(d.Tail);
Console.WriteLine();

d.DeletLeft();
Console.WriteLine(d.toString());
Console.WriteLine(d.Head);
Console.WriteLine(d.Tail);
Console.WriteLine();

d.DeletRight();
Console.WriteLine(d.toString());
Console.WriteLine(d.Head);
Console.WriteLine(d.Tail);
Console.WriteLine();