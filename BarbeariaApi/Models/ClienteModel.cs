namespace BarbeariaApi.Models;

public class ClienteModel
{
	public required string NomeCompleto { get; set; }
    public required string Telefone { get; set; }
    public required string Endereco { get; set; }
    public byte Ativo { get; set; }
}