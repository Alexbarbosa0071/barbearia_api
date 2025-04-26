namespace BarbeariaApi.Models;

public class AtualizarClienteModel
{
    public int Id { get; set; }
    public required string NomeCompleto { get; set; }
    public required string Telefone { get; set; }
    public required string Endereco { get; set; }
}
