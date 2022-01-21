using System.Collections;

namespace utility_library
{
    public class PriorityQueue<TElement, TPriority>
    {
        private SortedList sortedList = new SortedList();
        private int indexMin = 0;
        private int indexMax = -1;

        public void Enqueue(TElement element, TPriority priority)
        {
            sortedList.Add(priority, element);
            indexMax++;
        }

        public TElement DequeueMin()
        {
            return (TElement)sortedList.GetByIndex(indexMin++);
        }

        public TElement DequeueMax()
        {
            return (TElement)sortedList.GetByIndex(indexMax--);
        }

        public TElement PeekMin()
        {
            return (TElement)sortedList.GetByIndex(indexMin);
        }

        public TElement PeekMax()
        {
            return (TElement)sortedList.GetByIndex(indexMax);
        }

        public int Count()
        {
            return indexMax - indexMin + 1;
        }
    }
}
