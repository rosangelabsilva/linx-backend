public class Item
{
    public Item()
    {
    }

    public Item(long Codigo, string Nome, long Valor)
    {
        this.Codigo = Codigo;
        this.Nome = Nome;
        this.Valor = Valor;
    }

    public long Id { get; set; }
    public long Codigo { get; set; }
    public string Nome { get; set; }
    public long Valor { get; set; }
}