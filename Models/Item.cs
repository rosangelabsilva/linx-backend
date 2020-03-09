using CsvHelper.Configuration.Attributes;

public class Item
{
   
    [Name("Codigo")]
    public long Id { get; set; }
    [Name("Nome")]
    public string Nome { get; set; }
    [Name("Valor")]
    public long Valor { get; set; }
}