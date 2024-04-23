<h1 align="center">
  Brasil Api
</h1>

<p align="center">
 <a href="https://www.linkedin.com/in/rodrigofelixf/" target="_blank">
    <img src="https://img.shields.io/static/v1?label=Linkedin&message=@rodrigofelixf&color=8257E5&labelColor=000000" alt="@rodrigofelixf" />
</a>
 <img src="https://img.shields.io/static/v1?label=Tipo&message=Estudos&color=8257E5&labelColor=000000" alt="Estudos" />
</p>

API que consome uma API externa da [Brasil API](https://brasilapi.com.br/docs) Consumindo a API de buscar cep e bancos.

Referência do projeto [Artigo Tech](https://www.youtube.com/@ArtigoTech).

## Tecnologias
 
- [ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core)
- [AutoMapper](https://automapper.org/)
- [System Net HTTP](https://learn.microsoft.com/pt-br/dotnet/api/system.net.http?view=net-8.0)
- [Swagger](https://swagger.io/docs/)


## Práticas adotadas

- API REST
- Consumo de api externa
- Responses
- Auto Mapper
- Geração automática do Swagger

## Como Executar

- Clonar repositório git
- Navegar ate o projeto:
```bash
$ cd IntegraBrasilApi
```
- Executar a aplicação:
```bash
$ dotnet build
$ dotnet run
```

A API poderá ser acessada em [localhost:porta].
O Swagger poderá ser visualizado em [localhost:porta/swagger-ui.html](http://localhost:porta/swagger-ui.html)

## API Endpoints

Para fazer as requisições HTTP abaixo, foi utilizada a ferramenta [httpie](https://httpie.io):
(Você pode usar outros como: Insomnia, postman, etc.)

- Buscar Endereço Pelo CEP 
```
$ http GET :<Porta>/api/v1/Endereco/buscar/<CEP>

{
  "statusCode": 200,
  "returnData": {
    "cep": "88888888",
    "state": "AA",
    "city": "Cidade 1",
    "neighborhood": "Bairro 1",
    "street": "Rua 1"
  },
  "returnError": {}
}
```

- Buscar Banco Pelo Codigo
```
$ http GET :8080/api/v1/Banco/busca/104

{
  "ispb": "00360305",
  "shortName": "CAIXA ECONOMICA FEDERAL",
  "bankCode": 104,
  "fullName": "CAIXA ECONOMICA FEDERAL"
}
```

- Buscar Todos os Bancos (obs: Sem paginacao)
```
$ http PUT :8080/api/v1/Banco/busca/todos

[
  {
    "ispb": "00000000",
    "shortName": "BCO DO BRASIL S.A.",
    "bankCode": 1,
    "fullName": "Banco do Brasil S.A."
  },
  {
    "ispb": "00000208",
    "shortName": "BRB - BCO DE BRASILIA S.A.",
    "bankCode": 70,
    "fullName": "BRB - BANCO DE BRASILIA S.A."
  },
  {
    "ispb": "00038121",
    "shortName": "Selic",
    "bankCode": 0,
    "fullName": "Banco Central do Brasil - Selic"
  },
  {
    "ispb": "00038166",
    "shortName": "Bacen",
    "bankCode": 0,
    "fullName": "Banco Central do Brasil"
  }
]
```
