# Portfolio.API

Este é o repositório do projeto Portfolio.API, uma API desenvolvida em .NET e C# para salvar os dados de contato do portfólio no Microsoft SQL Server. Esta API fornece endpoints para criar, ler, atualizar e excluir informações de contato.

## Configuração do Ambiente

Antes de começar a utilizar o Portfolio.API, é necessário configurar o ambiente de desenvolvimento. Siga as etapas abaixo para configurar o ambiente:

1. Certifique-se de ter o Visual Studio instalado em sua máquina.
2. Clone este repositório em sua máquina local.
3. Abra o projeto no Visual Studio.
4. Certifique-se de que o SQL Server esteja instalado e configurado em sua máquina.
5. Abra o arquivo `appsettings.json` e configure a string de conexão com o banco de dados, substituindo os campos `<seu-servidor>`, `<seu-usuario>`, `<sua-senha>` e `<seu-banco-de-dados>` pelas informações corretas.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=<seu-servidor>;Database=<seu-banco-de-dados>;User=<seu-usuario>;Password=<sua-senha>;"
}
```

6. Compile o projeto para verificar se não há erros de compilação.

## Migrações do Banco de Dados

O projeto utiliza o Entity Framework Core para interagir com o banco de dados. Para criar a estrutura do banco de dados, é necessário executar as migrações. Siga as etapas abaixo para realizar as migrações:

1. Abra o Console do Gerenciador de Pacotes no Visual Studio. (Menu: Ferramentas -> Gerenciador de Pacotes NuGet -> Console do Gerenciador de Pacotes)
2. No Console do Gerenciador de Pacotes, verifique se o projeto padrão é o "Portfolio.API".
3. Execute o seguinte comando para criar o banco de dados e aplicar as migrações:

```bash
Update-Database
```

Após a execução bem-sucedida do comando acima, a estrutura do banco de dados será criada com as tabelas necessárias para armazenar as informações de contato.

## Utilizando a API

A API do Portfolio.API possui os seguintes endpoints disponíveis:

- **GET /api/contacts**: Retorna todos os contatos cadastrados.
- **GET /api/contacts/{id}**: Retorna um contato específico com base no ID.
- **POST /api/contacts**: Cria um novo contato.
- **PUT /api/contacts/{id}**: Atualiza um contato existente com base no ID.
- **DELETE /api/contacts/{id}**: Exclui um contato específico com base no ID.

Você pode utilizar uma ferramenta como o [Postman](https://www.postman.com/) para testar os endpoints da API.

## Contribuindo

Se você deseja contribuir com o projeto, siga as etapas abaixo:

1. Faça um fork deste repositório.
2. Crie um branch para a sua nova funcionalidade ou correção de bug: `git checkout -b minha-nova-funcionalidade`.
3. Faça as alterações necessárias e adicione os commits: `git commit -m "Adicionando nova funcionalidade"`.
4. Envie as alterações para o seu fork: `git push origin minha-nova-funcionalidade`.
5. Abra um pull request

 neste repositório, explicando as alterações propostas.

## Licença

Este projeto está licenciado sob a [MIT License](https://github.com/rafaelfaust/Portfolio.API/blob/main/LICENSE).

## Contato

Se você tiver alguma dúvida ou sugestão relacionada a este projeto, sinta-se à vontade para entrar em contato comigo através do meu [site](https://www.rafaelfaust.com.br) ou [e-mail](mailto:contato@rafaelfaust.com.br).
