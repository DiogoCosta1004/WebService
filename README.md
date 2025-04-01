# WebService

Este repositório contém uma aplicação WebService desenvolvida para fins de estudo e prática. O projeto está estruturado para fornecer serviços via API, permitindo integrações com outras aplicações.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET
- **Banco de Dados**: (Especificar se houver)
- **Protocolos**: RESTful API

## Como Configurar e Executar

1. Clone o repositório:
   ```sh
   git clone https://github.com/DiogoCosta1004/WebService.git
   ```
2. Acesse o diretório do projeto:
   ```sh
   cd WebService
   ```
3. Restaure as dependências:
   ```sh
   dotnet restore
   ```
4. Compile o projeto:
   ```sh
   dotnet build
   ```
5. Execute a aplicação:
   ```sh
   dotnet run
   ```
6. A API estará disponível em `http://localhost:5000` ou conforme configuração.

## Endpoints

| Método | Rota          | Descrição |
|---------|--------------|-------------|
| GET     | `/api/Worker...`   | Responsável por buscar todos os dados dos trabalhadores no banco no banco |
| POST    | `/api/Worker...`   | Fazer a inserção de um novo trabalhador |
| PUT     | `/api/Worker...`   | Fazer alteração nos dados dos trabalhadores |
| DELETE  | `/api/Worker...`   | Faz a remoção do trabalhador no banco |
| Get("{id}")  | `/api/Worker...`   | Faz a busca de um trabalhador por um id específico |
| PUT     | `/api/Worker...`   | Fazer alteração nos dados dos trabalhadores para inativo |

## Contribuição

Sinta-se à vontade para contribuir com melhorias! Para isso:
1. Faça um fork do repositório.
2. Crie um branch com sua funcionalidade:
   ```sh
   git checkout -b minha-funcionalidade
   ```
3. Faça commit das mudanças:
   ```sh
   git commit -m "Adicionando nova funcionalidade"
   ```
4. Envie para o repositório remoto:
   ```sh
   git push origin minha-funcionalidade
   ```
5. Abra um Pull Request.

## Licença

Este projeto está sob a licença MIT. Para mais detalhes, consulte o arquivo `LICENSE`.

---
Criado por [Diogo Costa](https://github.com/DiogoCosta1004).

