using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class Heap
    {
        private HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;


        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugumu[maxSize];
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public bool Insert(Urun yeniUrun)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(yeniUrun);
            heapArray[currentSize] = newHeapDugumu;
            currentSize++;
            siftUp(currentSize-1);

            return true;
        }

        public HeapDugumu RemoveMin()
        {
            HeapDugumu yeniHP = new HeapDugumu();
            if (currentSize == 0)
            {
                return null;
                throw new Exception("Heap boş!");
                
            }
            else
            {
                
                yeniHP = heapArray[0];
                heapArray[0] = heapArray[currentSize - 1];
                currentSize--;
                if (currentSize > 0)
                {
                    siftDown(0);
                }
            }

            return yeniHP;
        }

        private void siftDown(int nodeIndex)
        {
            int leftChildIndex, rightChildIndex, minIndex;
            HeapDugumu tmp;

            leftChildIndex = getLeftChildIndex(nodeIndex);

            rightChildIndex = getRightChildIndex(nodeIndex);

            if (rightChildIndex >= currentSize)
            {
                if (leftChildIndex >= currentSize)
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
                if (heapArray[leftChildIndex].Deger.satisFiyati <= heapArray[rightChildIndex].Deger.satisFiyati)
                {
                    minIndex = leftChildIndex;
                }
                else
                {
                    minIndex = rightChildIndex;
                }
            }
            if (heapArray[nodeIndex].Deger.satisFiyati > heapArray[minIndex].Deger.satisFiyati)
            {
                tmp = heapArray[minIndex];

                heapArray[minIndex] = heapArray[nodeIndex];

                heapArray[nodeIndex] = tmp;

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

        private void siftUp(int index)
        {
            int parentIndex;
            HeapDugumu temp;
            if (index != 0)
            {
                parentIndex = getParentIndex(index);
                if (heapArray[parentIndex].Deger.satisFiyati > heapArray[index].Deger.satisFiyati)
                {
                    temp = heapArray[parentIndex];
                    heapArray[parentIndex] = heapArray[index];
                    heapArray[index] = temp;
                    siftUp(parentIndex);
                }
            }
        }
        private int getParentIndex(int index)
        {
            return (index - 1) / 2;
        }
    }
}
