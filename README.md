# SolucaoEmpresa

Projeto criado na materia de nanodegree da faculdade, mostrando o uso do C# .NET em todas as camadas de um projeto. Desenvolvendo um aplicativo para cadastro, edição e remoção de clientes, em um banco de dados SQL Server

## Detalhes

O projeto consiste em uma biblioteca de classes para armazenamento dos dados de acesso ao banco (Empresa.Db), uma biblioteca de  classes para armazenar os modelos (Empresa.Models), um projeto WindowsForms (Empresa.UI.Windows) e um projeto web ASP.NET.CORE (Empresa.UI.Web).

## Windows Forms

### Tela inicial com a lista de cliente cadastrados
![image](https://user-images.githubusercontent.com/89602176/193591119-489cabbf-9a79-4030-96b2-91ac1fca7377.png)

### Tela de inserção de clientes
![image](https://user-images.githubusercontent.com/89602176/193591253-dd09c6f7-a99f-4619-825c-d1d50f5e1dc7.png)

### Tela com formulário preenchido
![image](https://user-images.githubusercontent.com/89602176/193591576-30380341-f2b0-496a-a91b-fc8c6681457d.png)

## Web

### Tela inicial (Home)
![image](https://user-images.githubusercontent.com/89602176/193592160-065981b3-9dc6-40e4-b09e-50c0272e7fc2.png)

### Tela da lista de clientes
![image](https://user-images.githubusercontent.com/89602176/193592340-e0305d95-a243-41fd-96db-4096034901dc.png)

### Formulário para inserção de clientes
![image](https://user-images.githubusercontent.com/89602176/193592636-5328532f-6c15-4065-a553-13451270c0bc.png)

## Execução
Para execução desse projeto é necessário e criação de uma banco de dados SQL Server, e a inserção de uma tabela com o nome Clientes, com os valores (Id, Nome, Email, Telefone)

comando sql:
```
  CREATE TABLE [dbo].[Cliente] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (255) NULL,
    [Email]    VARCHAR (255) NULL,
    [Telefone] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
