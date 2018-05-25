using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class Heap
    {
        Urun[] siraliUrunler;
        int arrSize;//size for the array container
        int heapSize;//keeps track of the number of elements

        public Heap()
        {
            arrSize = 0;
            heapSize = 0;
            siraliUrunler = new Urun[arrSize];
        }

        public Heap(int size)
        {
            siraliUrunler = new Urun[size];
        }
        public void setHeapSize(int size)
        {
            this.arrSize = size;
            siraliUrunler = new Urun[size];
        }

        public void insert(Urun urunBilgisi)
        {
            if (heapSize == siraliUrunler.Length)
            {
                throw new Exception("Heap is at full capacity!");
            }
            else
            {
                siraliUrunler[heapSize] = urunBilgisi;
                heapSize++;
                siftUp(heapSize - 1);
            }
        }
        public void remove(Urun value)
        {
            for (int i = 0; i < heapSize - 1; i++)
            {
                if (siraliUrunler[i] == value)
                {
                    siraliUrunler[i] = siraliUrunler[heapSize - 1];
                    heapSize--;
                    siftDown(i);
                    break;
                }
            }
        }

        public void removeMin()
        {
            if (heapSize == 0)
            {
                throw new Exception("Heap is empty!");
            }
            else
            {
                siraliUrunler[0] = siraliUrunler[heapSize - 1];
                heapSize--;
                if (heapSize > 0)
                {
                    siftDown(0);
                }
            }
        }
        private void siftUp(int index)
        {
            int parentIndex, temp;
            if (index != 0)
            {
                parentIndex = getParentIndex(index);
                if (siraliUrunler[parentIndex].satisFiyati > siraliUrunler[index].satisFiyati)
                {
                    temp = siraliUrunler[parentIndex].satisFiyati;
                    siraliUrunler[parentIndex] = siraliUrunler[index];
                    siraliUrunler[index].satisFiyati = temp;
                    siftUp(parentIndex);
                }
            }
        }
        private int getParentIndex(int index)
        {
            return (index - 1) / 2;
        }
        private void siftDown(int nodeIndex)
        {
            int leftChildIndex, rightChildIndex, minIndex, tmp;

            leftChildIndex = getLeftChildIndex(nodeIndex);

            rightChildIndex = getRightChildIndex(nodeIndex);

            if (rightChildIndex >= heapSize)
            {
                if (leftChildIndex >= heapSize)
                {
                    return;
                }
                else
                {
                    minIndex = leftChildIndex;
                }
            }
            else
            {
                if (siraliUrunler[leftChildIndex].satisFiyati <= siraliUrunler[rightChildIndex].satisFiyati)
                {
                    minIndex = leftChildIndex;
                }
                else
                {
                    minIndex = rightChildIndex;
                }
            }
            if (siraliUrunler[nodeIndex].satisFiyati > siraliUrunler[minIndex].satisFiyati)
            {
                tmp = siraliUrunler[minIndex].satisFiyati;

                siraliUrunler[minIndex] = siraliUrunler[nodeIndex];

                siraliUrunler[nodeIndex].satisFiyati = tmp;

                siftDown(minIndex);
            }
        }
        private int getRightChildIndex(int nodeIndex)
        {
            return (2 * nodeIndex) + 2;
        }
        private int getLeftChildIndex(int nodeIndex)
        {
            return (2 * nodeIndex) + 1;
        }
        public void displayHeap()
        {
            Console.WriteLine("Elements of the heap:");
            for (int i = 0; i < heapSize; i++)
            {
                Console.Write("{0} ", siraliUrunler[i]);
            }

            Console.WriteLine("\n***********************************");
        }
        public Urun getMin()
        {
            return siraliUrunler[0];
        }
        public void BuildHeap(Urun[] input)
        {
            if (heapSize > 0)
            {
                //clear the current heap
                Array.Resize(ref siraliUrunler, input.Length);
                heapSize = 0;
                for (int i = 0; i < siraliUrunler.Length; i++)
                {
                    siraliUrunler[i] = input[i];
                    heapSize++;
                }
            }
            for (int i = heapSize - 1 / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }
        private void Heapify(int index)
        {
            int left = 2 * index;
            int right = (2 * index) + 1;
            int smallest = index;
            if (left < heapSize && siraliUrunler[left].satisFiyati < siraliUrunler[index].satisFiyati)
            {
                smallest = left;
            }
            else
            {
                smallest = index;
            }
            if (right < heapSize && siraliUrunler[right].satisFiyati < siraliUrunler[smallest].satisFiyati)
            {
                smallest = right;
            }
            if (smallest != index)
            {
                swap(ref siraliUrunler, index, smallest);
                Heapify(smallest);
            }
        }
        private void swap(ref Urun[] input, int a, int b)
        {
            int temp = input[a].satisFiyati;
            input[a] = input[b];
            input[b].satisFiyati = temp;
        }
        public void deleteHeap()
        {
            Array.Resize(ref siraliUrunler, 0);
            heapSize = 0;
        }
    }









    /// <summary>
    /// /////////////////
    /// </summary>

    //private HeapDugumu[] heapArray;
    //private int maxSize;
    //private int currentSize;

    //public Heap(int maxHeapSize)
    //{
    //    maxSize = maxHeapSize;
    //    currentSize = 0;
    //    heapArray = new HeapDugumu[maxSize];
    //}

    //public bool IsEmpty()
    //{
    //    return currentSize == 0;
    //}

    //public bool Insert(Urun yeniUrun)
    //{
    //    if (currentSize == maxSize)
    //        return false;
    //    HeapDugumu newHeapDugumu = new HeapDugumu(yeniUrun);
    //    heapArray[currentSize] = newHeapDugumu;
    //    MoveToUp(currentSize++);
    //    return true;
    //}

    //public void MoveToUp(int index)
    //{
    //    int parent = (index - 1) / 2;
    //    HeapDugumu bottom = heapArray[index];
    //    while (index > 0 && heapArray[parent].Deger.satisFiyati < bottom.Deger.satisFiyati)
    //    {
    //        heapArray[index] = heapArray[parent];
    //        index = parent;
    //        parent = (parent - 1) / 2;
    //    }
    //    heapArray[index] = bottom;
    //}
}
