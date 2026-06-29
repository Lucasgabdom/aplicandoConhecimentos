class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto("notebooks", 20);
        Produto produto2 = new Produto("kit teclado e mouse", 20);

        produto1.ExibirEstoque();
        produto2.ExibirEstoque();

        produto1.RetirarEstoque(10);
        produto2.RetirarEstoque(10);

        produto1.AdicionarEstoque(20);
        produto2.AdicionarEstoque(20);

    }
}