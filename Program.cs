var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
{
    new Produto("Produto 1", 10, "Descrição do produto 1"),
    new Produto("Produto 2", 20, "Descrição do produto 2"),
    new Produto("Produto 3", 30, "Descrição do produto 3"),
    new Produto("Produto 4", 40, "Descrição do produto 4"),
    new Produto("Produto 5", 50, "Descrição do produto "),
}; 

app.MapGet("/", () => "Tela inicial");
app.MapGet("/api/produto", () => produtos);

app.Run();

public record Produto(string Nome, decimal Preco, string Descricao);


