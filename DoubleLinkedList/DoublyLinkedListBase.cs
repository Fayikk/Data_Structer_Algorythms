namespace DoubleLinkedList
{
    public class DoublyLinkedListBase
    {

        public DoublyLinkedListNode<T> Head { get; set; }//referans düğüm
        public DoublyLinkedListNode<T> Tail { get; set; }//referans düğüm 
        public DoublyLinkedList<T> prev { get; set; }
        public DoublyLinkedList<T> next { get; set; }

        public T Value { get; set; }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedList<T>(value);
            if (Head != null)
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
        public override string ToString() => Value.ToString();
    }
}