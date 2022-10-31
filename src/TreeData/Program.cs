namespace TreeData {
    using System;
    using TreeData.Mode;

    public class Program {
        protected static void Main() {
            var bTree = BTree.BuildDefault();
            bTree.Dispaly(TraversalMethod.InOrder);
            bTree.Dispaly(TraversalMethod.Level);
            Console.ReadLine();
        }
    }
}
