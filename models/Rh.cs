using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Rh
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Nome")]
    public string? Nome { get; set; }
    [BsonElement("Cargo")]
    public string? Cargo { get; set; }
    [BsonElement("Setor")]
    public string? Setor { get; set; }
    [BsonElement("Salário")]
    public double Salario { get; set; }
    [BsonElement("MesLancamento")]
    public string? MesLancamento { get; set; }
    [BsonElement("AnoLancamento")]
    public int AnoLancamento { get; set; }
}