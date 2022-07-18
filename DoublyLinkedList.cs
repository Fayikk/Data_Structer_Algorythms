using System;

public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> Head { get; set; }//referans düğüm
    public DoublyLinkedListNode<T> Tail { get; set; }//referans düğüm 

    public void AddFirst(T value)
    {
        var newNode = new DoublyLinkedList<T>(value);
        if(Head != null)
        {
            Head.Prev = newNode;
        }
        newNode.Next = Head;
        newNode.Prev = null;
        Head = newNode;

        if (Tail == null)
        {
            Tail = Head;
        }
       
    }
}
