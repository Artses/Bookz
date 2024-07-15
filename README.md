## API Mínima em ASP.NET Core<br>
Este é um projeto de API mínima em ASP.NET Core. Ele fornece operações básicas de CRUD para gerenciar uma entidade simples.

<h4> Funcionalidades: </h4>
Endpoints RESTful<br>
Operações básicas de CRUD<br>
Entity Framework Core para interações com o banco de dados<br>

<h4>Pré-requisitos:</h4>
SDK do .NET 8<br>
Visual Studio 2022 ou Visual Studio Code<br>

## Instalação<br>
Clone o repositório:
```
git clone https://github.com/seuusuario/minimal-aspnet-core-api.git
cd minimal-aspnet-core-api
```
Restaure as dependências:

```
dotnet restore
Atualize o banco de dados (certifique-se de ter um SQL Server local em execução):
```
```
dotnet ef database update
Executando a Aplicação
```
Para executar a aplicação, use o comando:

```
dotnet run
A API estará disponível em https://localhost:5001 ou http://localhost:5000.
```
