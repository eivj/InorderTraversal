using InorderTraversal;

Tree<int> tree = new Tree<int>();

Random rand = new Random();
for (int i = 0; i < rand.Next(5,20); i++)
{
    tree.Root = tree.AddNode(rand.Next(-1000, 1000), tree.Root);
}

tree.Write(Console.WindowWidth / 2, 0, tree.Root);
Console.SetCursorPosition(0, 20);

Console.WriteLine("Симметричный обход");
foreach (var item in tree)
{
    Console.WriteLine(item);
}
Console.ReadKey();