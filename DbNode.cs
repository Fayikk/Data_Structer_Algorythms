using System;

public class DoublyLinkedList<T>
{
    public DoublyLinkedList<T> prev { get; set; }
    public DoublyLinkedList<T> next { get; set; }

    public T Value { get; set; }

    public DoublyLinkedList(T Value)
    {
        Value = Value;
    }
    public override string ToString() => Value.ToString();
}
