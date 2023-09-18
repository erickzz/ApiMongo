using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Rh
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Name")]
    public string? Nome { get; set; }
    [BsonElement("Cargo")]
    public string? Cargo { get; set; }
    [BsonElement("Setor")]
    public string? Setor { get; set; }
    [BsonElement("Salário")]
    public double Salario { get; set; }
    public string? Mes { get; set; }
    [BsonElement("Ano")]
    public int Ano { get; set; }
}