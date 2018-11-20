namespace DoublyLinkedListImplementation.DoublyLinkedListNode
{
    //Node class for linked list to hold the next, previous pointers and value
    public sealed class DoublyLinkedListNode<T>
    {
        //Properties
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }

        public T Value { get; set; }

        //Constructor
        public DoublyLinkedListNode(T value, DoublyLinkedListNode<T> next, DoublyLinkedListNode<T> prev) {
            Value = value;
            Next = next;
            Previous = prev;
        }
    }
}
