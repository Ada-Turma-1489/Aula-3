using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        // Endpoint - É um ponto de ACESSO/INTERAÇÃO com minha aplicação
        app.MapGet("/score/{cpf:long}", HelloWorld); // Variáveis de Segmento
        app.MapGet("/score/{qualquercoisa:alpha}", MetodoQueRespondeEssaRequest); // Variáveis de Segmento

        app.Run();
    }

    private static async Task MetodoQueRespondeEssaRequest(HttpContext context, string qualquercoisa)
    {
        await context.Response.WriteAsync($"Recebi: {qualquercoisa}");
    }

    private static async Task HelloWorld(HttpContext context, string cpf)
    {
        int score = 0;

        if (cpf == "987654321")
            score = 1000;
        else if (cpf == "123456789")
            score = 200;

        await context.Response.WriteAsync($"O Score do CPF {cpf} é: {score}");
    }
}