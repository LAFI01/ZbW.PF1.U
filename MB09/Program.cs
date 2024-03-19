
using MB09.SinglyLinkedListExample;
//using MB09.Loesung.SinglyLinkedListExample;


var singlyLinkedList = new SinglyLinkedList();

//Aufgabe 1
singlyLinkedList.Add(1);
singlyLinkedList.Add(2);
singlyLinkedList.Add(3);
singlyLinkedList.Add(4);
singlyLinkedList.Add(5);
var cnt = singlyLinkedList.Count;

//Aufgabe 2
var c = singlyLinkedList.Contains(6);
Console.WriteLine($"does list contain string? {c}");

//Aufgabe 3
var remove = 1;
singlyLinkedList.Remove(remove);
Console.WriteLine($"object with data {remove} was removed");

//Aufgabe 4
//var o = singlyLinkedList.FindByIndex(1);

//Aufgabe 5
//var x = singlyLinkedList[1];
//singlyLinkedList[1] = "xyz";


