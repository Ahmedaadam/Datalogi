// See https://aka.ms/new-console-template for more information

using Datalogi_02;

Console.WriteLine("Hello, World!");

MyLinkedList<int> minLista = new MyLinkedList<int>();
minLista.Push(1);
minLista.Push(2);
minLista.Push(3);
minLista.Push(4);
minLista.Reset();
minLista.RemoveAt(0);
Console.WriteLine(minLista.Current.Data);
minLista.Next();
Console.WriteLine(minLista.Current.Data);
minLista.Next();
Console.WriteLine(minLista.Current.Data);
minLista.Next();



