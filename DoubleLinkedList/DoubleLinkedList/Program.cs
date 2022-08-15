// See https://aka.ms/new-console-template for more information
using DoubleLinkedList;

LinkedListOperation x = new LinkedListOperation();
x.InsertAtFirst(2);
x.InsertAtFirst(1);
x.InsertAtLast(3);
x.InsertAtLast(4);
x.InsertAtLast(5);
x.InsertAtLast(6);

x.InsertAfter(6, 200);
x.InsertAfter(200, 86);

x.DeleteFromMiddle(86);

x.Print();


