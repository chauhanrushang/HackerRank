using System;
using DataStructures.Arrays;
using DataStructures.LinkedLists;
using DataStructures.Queues;
using DataStructures.Stacks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool exit = false;
                Console.WriteLine("Please select a Data Structure for simulation.");
                Console.WriteLine("===================================================");
                Console.WriteLine("0. Exit!");
                Console.WriteLine("1. Arrays");
                Console.WriteLine("2. Linked Lists");
                Console.WriteLine("3. Trees");
                Console.WriteLine("4. Balanced Trees");
                Console.WriteLine("5. Stacks");
                Console.WriteLine("6. Queues");
                Console.WriteLine("7. Heap");
                Console.WriteLine("8. Disjoint Set");
                Console.WriteLine("9. Multiple Choice");
                Console.WriteLine("10. Trie");
                Console.WriteLine("11. Advanced");
                Console.WriteLine("===================================================");
                Console.WriteLine();
                int input = Convert.ToInt32(Console.ReadLine());

                switch ((DataStructureType)input)
                {
                    case DataStructureType.Exit:
                        exit = true;
                        break;
                    case DataStructureType.Arrays:
                        ArraysProgram();
                        break;
                    case DataStructureType.LinkedLists:
                        LinkedListsProgram();
                        break;
                    case DataStructureType.Trees:
                        TreesProgram();
                        break;
                    case DataStructureType.BalancedTrees:
                        BalancedTreesProgram();
                        break;
                    case DataStructureType.Stacks:
                        StacksProgram();
                        break;
                    case DataStructureType.Queues:
                        QueuesProgram();
                        break;
                    case DataStructureType.Heap:
                        HeapProgram();
                        break;
                    case DataStructureType.DisjointSet:
                        DisjointSetProgram();
                        break;
                    case DataStructureType.MultipleChoice:
                        MultipleChoiceProgram();
                        break;
                    case DataStructureType.Trie:
                        TrieProgram();
                        break;
                    case DataStructureType.Advanced:
                        AdvancedProgram();
                        break;
                    default:
                        break;
                }

                if (exit) break;
            }
        }

        private static void AdvancedProgram()
        {
            throw new NotImplementedException();
        }

        private static void TrieProgram()
        {
            throw new NotImplementedException();
        }

        private static void MultipleChoiceProgram()
        {
            throw new NotImplementedException();
        }

        private static void DisjointSetProgram()
        {
            throw new NotImplementedException();
        }

        private static void HeapProgram()
        {
            throw new NotImplementedException();
        }

        private static void QueuesProgram()
        {
            Console.WriteLine("Please select an ArraysProgram for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Queue using Two Stacks");
            Console.WriteLine("2. Castle on the Grid");
            Console.WriteLine("3. Down to Zero II");
            Console.WriteLine("4. Truck Tour");
            Console.WriteLine("5. Queries with Fixed Length");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((QueueProgramTypes)input)
            {
                case QueueProgramTypes.QueueusingTwoStacks:
                    QueueProgramClass.QueueusingTwoStacks();
                    break;
                case QueueProgramTypes.CastleontheGrid:
                    QueueProgramClass.CastleontheGrid();
                    break;
                case QueueProgramTypes.DowntoZeroII:
                    QueueProgramClass.DowntoZeroII();
                    break;
                case QueueProgramTypes.TruckTour:
                    QueueProgramClass.TruckTour();
                    break;
                case QueueProgramTypes.QuerieswithFixedLength:
                    QueueProgramClass.QuerieswithFixedLength();
                    break;
                default:
                    break;
            }
        }

        private static void StacksProgram()
        {
            Console.WriteLine("Please select an ArraysProgram for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Maximum Element");
            Console.WriteLine("2. Balanced Brackets");
            Console.WriteLine("3. Equal Stacks");
            Console.WriteLine("4. Game of Two Stacks");
            Console.WriteLine("5. Largest Rectangle");
            Console.WriteLine("6. Simple Text Editor");
            Console.WriteLine("7. Poisonous Plants");
            Console.WriteLine("8. AND xor OR");
            Console.WriteLine("9. Waiter");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((StacksProgramTypes)input)
            {
                case StacksProgramTypes.Exit:
                    break;
                case StacksProgramTypes.MaximumElement:
                    StacksProgramClass.MaximumElement();
                    break;
                case StacksProgramTypes.BalancedBrackets:
                    StacksProgramClass.BalancedBrackets();
                    break;
                case StacksProgramTypes.EqualStacks:
                    StacksProgramClass.EqualStacks();
                    break;
                case StacksProgramTypes.GameofTwoStacks:
                    StacksProgramClass.GameofTwoStacks();
                    break;
                case StacksProgramTypes.LargestRectangle:
                    StacksProgramClass.LargestRectangle();
                    break;
                case StacksProgramTypes.SimpleTextEditor:
                    StacksProgramClass.SimpleTextEditor();
                    break;
                case StacksProgramTypes.PoisonousPlants:
                    StacksProgramClass.PoisonousPlants();
                    break;
                case StacksProgramTypes.ANDxorOR:
                    StacksProgramClass.ANDxorOR();
                    break;
                case StacksProgramTypes.Waiter:
                    StacksProgramClass.Waiter();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }

        private static void BalancedTreesProgram()
        {
            throw new NotImplementedException();
        }

        private static void TreesProgram()
        {
            throw new NotImplementedException();
        }

        private static void LinkedListsProgram()
        {
            Console.WriteLine("Please select a LinkedListsProgram for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Print the Elements of a Linked List");
            Console.WriteLine("2. Insert a Node at the Tail of a Linked List");
            Console.WriteLine("3. Insert a node at the head of a linked list");
            Console.WriteLine("4. Insert a node at a specific position in a linked list");
            Console.WriteLine("5. Delete a Node");
            Console.WriteLine("6. Print in Reverse");
            Console.WriteLine("7. Reverse a linked list");
            Console.WriteLine("8. Compare two linked lists");
            Console.WriteLine("9. Merge two sorted linked lists");
            Console.WriteLine("10. Get Node Value");
            Console.WriteLine("11. Delete duplicate-value nodes from a sorted linked list");
            Console.WriteLine("12. Cycle Detection");
            Console.WriteLine("13. Find Merge Point of Two Lists");
            Console.WriteLine("14. Inserting a Node Into a Sorted Doubly Linked List");
            Console.WriteLine("15. Reverse a doubly linked list");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((LinkedListsProgramTypes)input)
            {
                case LinkedListsProgramTypes.Exit:
                    break;
                case LinkedListsProgramTypes.PrinttheElementsofaLinkedList:
                    LinkedListsProgramClass.PrinttheElementsofaLinkedList();
                    break;
                case LinkedListsProgramTypes.InsertaNodeattheTailofaLinkedList:
                    LinkedListsProgramClass.InsertaNodeattheTailofaLinkedList();
                    break;
                case LinkedListsProgramTypes.Insertanodeattheheadofalinkedlist:
                    LinkedListsProgramClass.Insertanodeattheheadofalinkedlist();
                    break;
                case LinkedListsProgramTypes.Insertanodeataspecificpositioninalinkedlist:
                    LinkedListsProgramClass.Insertanodeataspecificpositioninalinkedlist();
                    break;
                case LinkedListsProgramTypes.DeleteaNode:
                    LinkedListsProgramClass.DeleteaNode();
                    break;
                case LinkedListsProgramTypes.PrintinReverse:
                    LinkedListsProgramClass.PrintinReverse();
                    break;
                case LinkedListsProgramTypes.Reversealinkedlist:
                    LinkedListsProgramClass.Reversealinkedlist();
                    break;
                case LinkedListsProgramTypes.Comparetwolinkedlists:
                    LinkedListsProgramClass.Comparetwolinkedlists();
                    break;
                case LinkedListsProgramTypes.Mergetwosortedlinkedlists:
                    LinkedListsProgramClass.Mergetwosortedlinkedlists();
                    break;
                case LinkedListsProgramTypes.GetNodeValue:
                    LinkedListsProgramClass.GetNodeValue();
                    break;
                case LinkedListsProgramTypes.Deleteduplicatevaluenodesfromasortedlinkedlist:
                    LinkedListsProgramClass.Deleteduplicatevaluenodesfromasortedlinkedlist();
                    break;
                case LinkedListsProgramTypes.CycleDetection:
                    LinkedListsProgramClass.CycleDetection();
                    break;
                case LinkedListsProgramTypes.FindMergePointofTwoLists:
                    LinkedListsProgramClass.FindMergePointofTwoLists();
                    break;
                case LinkedListsProgramTypes.InsertingaNodeIntoaSortedDoublyLinkedList:
                    LinkedListsProgramClass.InsertingaNodeIntoaSortedDoublyLinkedList();
                    break;
                case LinkedListsProgramTypes.Reverseadoublylinkedlist:
                    LinkedListsProgramClass.Reverseadoublylinkedlist();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }

        private static void ArraysProgram()
        {
            Console.WriteLine("Please select an ArraysProgram for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Arrays - DS");
            Console.WriteLine("2. 2D Array - DS");
            Console.WriteLine("3. Dynamic Array");
            Console.WriteLine("4. Left Rotation");
            Console.WriteLine("5. Sparse Arrays");
            Console.WriteLine("6. Algorithmic Crush");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((ArrayProgramTypes)input)
            {
                case ArrayProgramTypes.Exit:
                    break;
                case ArrayProgramTypes.ArraysDS:
                    ArraysProgramClass.ArrayDS();
                    break;
                case ArrayProgramTypes.TwoDArrayDS:
                    ArraysProgramClass.TwoDArrayDS();
                    break;
                case ArrayProgramTypes.DynamicArray:
                    ArraysProgramClass.DynamicArray();
                    break;
                case ArrayProgramTypes.LeftRotation:
                    ArraysProgramClass.LeftRotation();
                    break;
                case ArrayProgramTypes.SparseArrays:
                    ArraysProgramClass.SparseArrays();
                    break;
                case ArrayProgramTypes.AlgorithmicCrush:
                    ArraysProgramClass.AlgorithmicCrush();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }
    }
}
