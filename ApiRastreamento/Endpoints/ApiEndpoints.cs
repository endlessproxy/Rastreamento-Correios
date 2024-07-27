using Microsoft.AspNetCore.Http.HttpResults;

namespace ApiRastreamento.Endpoints;

public class ApiEndpoints
{
    private readonly WebApplication _app;

    public ApiEndpoints(WebApplication app)
    {
        _app = app;
    }

    public void ConfigureEndpoints()
    {
        // Variaveis Importantes
        var rastreamento = new Correios.Pacotes.Services.Rastreador();
        
        
        #region Endpoints

        // Endpoint para padrão:
        _app.MapGet("/", () => { return Results.Ok("Tudo funcionando!"); });
        
        // Endpoint para rastrear a encomenda:
        _app.MapGet($"/Api/Buscar-Encomenda/", (string codigo_rastreamento) =>
        {
            var encomenda = rastreamento.ObterPacote(codigo_rastreamento).Historico;
            var resultado = new
            {
                Status = encomenda.Select(e => new
                {
                    Localização = e.Localizacao,
                    Observação = e.StatusCorreio
                })
            };
            
            return Results.Json(resultado);
        });
        
        // Endpoint para verificar se foi entregue:
        _app.MapGet("/Api/Entregue/", (string codigo_rastreamento) =>
        {
            var encomenda = rastreamento.ObterPacote(codigo_rastreamento).Entregue;
            var resultado = new { Status = "A sua encomenda já foi entregue! :D" };
            
            if (encomenda == false)
            {
                resultado = new { Status = "A sua encomenda ainda não foi entregue! :(" };
            }

            return Results.Json(resultado);
        });

        #endregion
    }
}