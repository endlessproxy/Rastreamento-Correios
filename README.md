# Backend: **API REST** de Rastreamento dos Correios com modelo C# Web API

## Introdução
Este projeto é uma API REST desenvolvida com .NET 8 que permite rastrear pacotes utilizando o serviço dos Correios. A API fornece endpoints para buscar o status da encomenda e verificar se ela já foi entregue.

## Funcionalidades:
- **Busca de Encomenda:** Permite buscar o histórico de rastreamento de um pacote através do código de rastreamento.
- **Verificação de Entrega:** Verifica se a encomenda já foi entregue.

## Pré-requisitos
- .NET 8 SDK instalado no seu sistema.

```sh
## Instalação
1. Clone o repositório:
   git clone https://github.com/seu_usuario/api-rastreamento-correios.git
   cd api-rastreamento-correios

## Instale as dependencias (Se necessário)
2. Dependencias:
   dotnet restore

## Execute o programa no Terminal
3. Executar:
   cd ApiRastreamento > dotnet run
