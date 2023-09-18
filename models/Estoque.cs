using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Estoque
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Nome")]
    public string? Nome { get; set; }
    [BsonElement("Quantidade")]
    public int Quantidade { get; set; }
    [BsonElement("Preço")]
    public double Preco { get; set; }
    [BsonElement("Mês")]
    public string? Mes { get; set; }
    [BsonElement("Ano")]
    public int Ano { get; set; }
}