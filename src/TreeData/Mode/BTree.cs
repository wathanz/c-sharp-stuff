namespace TreeData.Mode {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum TraversalMethod {
        Level,
        InOrder,
        PreOrder,
        PoseOrder
    }
    public class BNode {

        public BNode(int data) => this.Data = data;
        public int Data { get; set; }
        public BNode LeftChild { get; set; } = null;
        public BNode RightChild { get; set; } = null;
    }


    /*
     *       1
     *      / \
     *     2   3
     *    / \  
     *   4   5
     *   
     */
    public class BTree {

        public static BTree BuildDefault() {
            var root = new BNode(1) {
                LeftChild = new BNode(2) { LeftChild = new BNode(4), RightChild = new BNode(5) },
                RightChild = new BNode(3) { }
            };
            return new BTree(root);
        }

        public BNode Root { get; } = null;
        public BTree(BNode root) => this.Root = root;


        public void Level(BNode root) {
            if (root == null) {
                return;
            }
            var pointer = root;
            var queue = new Queue<BNode>();
            var hasPointer = pointer != null;
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            sb.Append(pointer.Data + " ");
            queue.Enqueue(pointer);
            while (queue.Count > 0) {
                var n = queue.Dequeue();
                if (n.LeftChild != null) {
                    sb.Append(n.LeftChild.Data + " ");
                    queue.Enqueue(n.LeftChild);
                }
                if (n.RightChild != null) {
                    sb.Append(n.RightChild.Data +" ");
                    queue.Enqueue(n.RightChild);
                }
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        public void Inorder(BNode root) {
            if (root == null) {
                return;
            }
            var pointer = root;
            var stack = new Stack<BNode>();
            var hasPointer = pointer != null;
            var sb = new StringBuilder();
            sb.Append("[ ");
            while (hasPointer || stack.Count > 0) {
                if (hasPointer) {
                    stack.Push(pointer);
                    pointer = pointer.LeftChild;
                }
                else {
                    pointer = stack.Pop();
                    sb.Append($"{pointer.Data} ");
                    pointer = pointer.RightChild;
                }
                hasPointer = pointer != null;
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
        public void Dispaly(TraversalMethod traversal = TraversalMethod.InOrder) {
            Console.WriteLine($"{traversal}");
            switch (traversal) {
                case TraversalMethod.Level:
                    this.Level(this.Root);
                    break;
                case TraversalMethod.InOrder:
                    this.Inorder(this.Root);
                    break;
                case TraversalMethod.PreOrder:
                    break;
                case TraversalMethod.PoseOrder:
                    break;
                default:
                    break;
            }
        }
    }
}
