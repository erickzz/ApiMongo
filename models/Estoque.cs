using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Estoque
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Name")]
    public string? Nome { get; set; }
    [BsonElement("Quantidade")]
    public int Quantidade { get; set; }
    [BsonElement("Preço")]
    public double Preco { get; set; }
}