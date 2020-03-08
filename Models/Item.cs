using CsvHelper.Configuration.Attributes;

public class Item
{
   
    [Name("id")]
    public long Id { get; set; }
    [Name("nome")]
    public string Nome { get; set; }
    [Name("valor")]
    public long Valor { get; set; }
}