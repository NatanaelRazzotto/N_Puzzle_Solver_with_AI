using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class BinaryHeapMin //Necessitou-se criar uma outra arvore binaria para a lista de precedencia
    {
        public Node[] heapArray { get; set; }//int
        public int capacity { get; set; }
        public int elements_in_heap { get; set; }
        public BinaryHeapMin(int i) {
            capacity = i;
            heapArray = new Node[capacity];
            elements_in_heap = 0;
        }
        public bool insert(Node node)//insertKey
        {
            if (elements_in_heap == capacity) return false;
            int i = elements_in_heap;
            heapArray[i] = node;
            elements_in_heap++;

            while (i != 0 && heapArray[i].F_cost < heapArray[Parent(i)].F_cost)
            {
                Trocar(ref heapArray[i],ref heapArray[Parent(i)]);
                i = Parent(i);
            }
            return true;
        }
        public Node getMinRoot() {
            Node root = heapArray[0];
            deleteNode(0);
            return root;
        }
        public void deleteNode(int key)
        {
            decreaseKey(key);//int.MinValue
            extractMin();

        }
        public int extractMin()
        {
            if (elements_in_heap <= 0)
            {
                return int.MaxValue;
            }

            if (elements_in_heap == 1)
            {
                elements_in_heap--;
                return heapArray[0].F_cost;
            }

            // Store the minimum value, 
            // and remove it from heap 
            int root = heapArray[0].F_cost;

            heapArray[0] = heapArray[elements_in_heap - 1];
            elements_in_heap--;
            //MinHeapify(0);

            return root;
        }
        public void decreaseKey(int key)//
        {
            Node new_val = new Node();
            new_val.F_cost = int.MinValue;
            heapArray[key] = new_val;

            while (key != 0 && heapArray[key].F_cost <
                               heapArray[Parent(key)].F_cost)
            {
                Trocar(ref heapArray[key],
                     ref heapArray[Parent(key)]);
                key = Parent(key);
            }
        }
        public static void Trocar<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public int Parent(int key)
        {
            return (key - 1) / 2;
        }


    }
}
