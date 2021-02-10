namespace linked_list
{
    public class LinkedList<T>: IList<T>
    {
        private class Node<T>
        {
            public T _value { get; }
            // public Node<T> _prev { set; get; }
            public Node<T> _next { set; get; }

            public Node(T value)
            {
                this._value = value;
            }
        }
        
        private Node<T> _head;
        private Node<T> _tail;

        private int _size = 0;

        public bool Add(T value)
        {
            _size++;
            if (_head == null)
            {
                _head = new Node<T>(value) {_next = null};
                _tail = _head;
                return true;
            }
            var node = new Node<T>(value) {_next = null};
            _tail._next = node;
            _tail = node;
            return true;

        }
    }
}