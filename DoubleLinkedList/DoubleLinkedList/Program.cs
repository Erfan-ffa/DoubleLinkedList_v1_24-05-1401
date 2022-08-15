// See https://aka.ms/new-console-template for more information
using DoubleLinkedList;

Operation x = new Operation();
x.InsertAtFirst(2);
x.InsertAtFirst(1);
x.DeleteFromFirst();
x.InsertAtLast(3);
x.InsertAtLast(4);
x.InsertAtLast(5);
x.InsertAtLast(6);
x.InsertAtFirst(0);
x.DeleteFromFirst();

    
x.Print();

