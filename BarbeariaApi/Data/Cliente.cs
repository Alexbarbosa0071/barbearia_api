namespace BarbeariaApi.Data;

public record Cliente(
    int ID,
    string NomeCompleto,
    string Telefone,
    string Endereco,
    Boolean Ativo
);