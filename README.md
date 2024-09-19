
# Blazor Login App

Bem-vindo ao **Blazor Login App**! Este é um projeto de autenticação de usuários desenvolvido em Blazor com .NET 6 e Entity Framework Core para interação com o banco de dados SQL Server. A aplicação permite que usuários façam login com e-mail e senha e, após uma autenticação bem-sucedida, sejam redirecionados para a página inicial.

## 📝 Funcionalidades

- Página de login para usuários inserirem seu e-mail e senha.
- Autenticação de usuários com redirecionamento para uma página inicial após o login.
- Exibição de mensagem de erro para login falho.
- Layout simples e responsivo.
- Utiliza Entity Framework Core para comunicação com o banco de dados SQL Server.
- Script SQL para criar a estrutura do banco de dados incluído na pasta `database`.

## 📂 Estrutura do Projeto

```plaintext
BlazorLoginApp/
├── BlazorLoginApp.Client/       # Projeto Client (Blazor WebAssembly)
├── BlazorLoginApp.Server/       # Projeto Server (ASP.NET Core)
├── BlazorLoginApp.Shared/       # Projeto Compartilhado (Modelos, DTOs)
├── database/                    # Contém o script SQL para criação do banco de dados
│   └── BlazorAppDB.sql
└── README.md                    # Este arquivo
```

## 🚀 Pré-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/) com o .NET 6 SDK instalado.
- [SQL Server](https://www.microsoft.com/pt-br/sql-server) e [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup).
- [Git](https://git-scm.com/) para clonar o repositório.

## 🛠️ Configuração do Banco de Dados

1. Abra o **SQL Server Management Studio (SSMS)**.
2. Conecte-se ao seu servidor SQL.
3. No menu superior, clique em `Nova Consulta`.
4. Abra o arquivo `BlazorAppDB.sql` localizado na pasta `database` do projeto e copie o conteúdo.
5. Cole o conteúdo no editor de consulta do SSMS e execute o script para criar a tabela necessária (`Users`).

## 🎮 Como Executar o Projeto

1. **Clone este repositório**:
   ```bash
   git clone https://github.com/seu-usuario/BlazorLoginApp.git
   ```
2. **Abra o projeto no Visual Studio**:
   - Navegue até o diretório do projeto e abra o arquivo da solução (`.sln`) no Visual Studio.
3. **Configurar a String de Conexão**:
   - No projeto `BlazorLoginApp.Server`, abra o arquivo `appsettings.json` e edite a string de conexão para apontar para o seu servidor SQL:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=BlazorLoginDb;Trusted_Connection=True;"
     }
     ```
4. **Executar a Aplicação**:
   - No Visual Studio, selecione `BlazorLoginApp.Server` como o projeto de inicialização.
   - Pressione `Ctrl + F5` para executar a aplicação.
5. **Acessar a Aplicação**:
   - Abra o navegador e acesse: `https://localhost:5001/login`.

## 🧪 Testando o Login

- Utilize as seguintes credenciais para testar:
  - **Email**: `usuario@example.com`
  - **Senha**: `minhasenha`
- Se o login for bem-sucedido, você será redirecionado para a página inicial.

## 📦 Scripts SQL

Os scripts SQL para criar a estrutura do banco de dados estão incluídos na pasta `database`. Certifique-se de executar esses scripts antes de testar a aplicação.

## 🤝 Contribuição

1. Faça um fork do projeto.
2. Crie uma nova branch:
   ```bash
   git checkout -b feature/nova-feature
   ```
3. Faça suas alterações e confirme:
   ```bash
   git commit -m 'Adicionando nova feature'
   ```
4. Faça o push da branch:
   ```bash
   git push origin feature/nova-feature
   ```
5. Abra um Pull Request.

## 📜 Licença

Este projeto é licenciado sob a [MIT License](LICENSE).

## 📧 Contato

Se tiver dúvidas ou sugestões, entre em contato pelo e-mail: [lucas_alexandre21@outlook.com](mailto:lucas_alexandre21@outlook.com).

---

Feito com 💙 por [Lucas Alexandre].
```
