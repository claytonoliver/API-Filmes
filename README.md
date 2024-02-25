# API-Filmes

## Descrição do Projeto

Este projeto foi desenvolvido como parte de um projeto Full Stack, onde por meio de outro repositório será realizado a interface e integração com esta API.

## Funcionalidades Principais

- C - Create (Inclusão de filmes no banco de dados)
- R - Read (Leitura dos filmes cadastrados no banco de dados modo geral e por ID)
- U - Update (Atualização de filmes no banco de dados por ID)
- D - Delete (Deletar um filme no banco de dados por um ID)

## Tecnologias Utilizadas

- DTOs (Data Transfer Objects): Estruturas leves utilizadas para transferir dados entre diferentes partes da aplicação, como entre a camada de acesso a dados e a lógica de negócios. Facilitam a eficiente transferência de informações.

- Data Annotations: Atributos aplicados a classes ou membros de classes em .NET, como C#, fornecendo metadados sobre os dados e definindo comportamentos, frequentemente utilizados em conjunto com o Entity Framework.

- Entity Framework: Framework de Mapeamento Objeto-Relacional (ORM) da Microsoft para .NET, simplificando as interações com bancos de dados por meio de operações em objetos, sem a necessidade de escrever SQL diretamente.

## Como Executar o Projeto

1. Clone este repositório: `git clone https://github.com/claytonoliver/API-Filmes`
   
2.  Instale as dependencias:
   - AutoMapper - dotnet add package AutoMapper --version 13.0.1
   - Entity Framework Core - dotnet add package Microsoft.EntityFrameworkCore --version 8.0.2
   - Entity Framework Core Tools - dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.2
   - Pomelo Entity Framework Core - dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0

3. Instale o Mysql workbench
   link para dowload: https://dev.mysql.com/downloads/installer/

   obs: Para uso na API foi utilizado usuário e senha "root"
   
4. Caso tenha utilizado um usuário e senha diferentes não esqueça de alterar no arquivo appsettings.json
   "FilmeConnection": "server=localhost;database=filme;user=root;password=root"

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

