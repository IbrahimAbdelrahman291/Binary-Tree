using Tree;

internal class Program
{
    private static void Main(string[] args)
    {
        Btree tree = new Btree();
        tree.add(8);
        tree.add(3);
        tree.add(2);
        tree.add(6);
        tree.add(10);
        tree.add(11);
        tree.add(9);
        tree.add(9);
        tree.search(3);
        tree.preOrder();
        tree.postOrder();
        tree.InOrder();
    }
}