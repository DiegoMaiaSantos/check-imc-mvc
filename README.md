# 🩺 CheckImc

Projeto ASP.NET Core MVC com API integrada para cálculo de **IMC (Índice de Massa Corporal)**. O sistema permite que o usuário insira seu peso e altura, visualize o resultado do IMC e sua classificação. O projeto inclui testes automatizados com xUnit e suporte à execução via Docker para facilitar o desenvolvimento e deploy.

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core 8 (MVC + Web API)
- C#
- xUnit (testes)
- Docker
- Bootstrap (interface)
- Visual Studio / VS Code
- .NET CLI

---

## 📁 Estrutura do Projeto

```
Check_IMC/
├── Controllers/
│   └── HomeController.cs
│   └── ImcController.cs
├── Controllers/
│   └── ServiceInjection.cs
├── Interfaces/
│   └── IImcService.cs
├── Models/
│   └── ImcModel.cs
│   └── ErrorViewModel.cs
├── Services/
│   └── ImcService.cs
├── Views/
│   └── Home/
│       └── Index.cshtml
│       └── Privacy.cshtml
│   └── Imc/
│       └── Index.cshtml
│   └── Shared/
├── Check_IMC.Tests/         # Projeto de testes xUnit
│   └── ImcControllerTests.cs
│   └── ImcServiceTests.cs
├── Dockerfile
├── Program.cs
└── README.md
```

---

## 🚀 Como Executar Localmente

### ✅ Executar com .NET CLI

1. Clone o repositório:
   ```bash
   git clone https://github.com/DiegoMaiaSantos/check-imc-mvc.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd Check_IMC
   ```

3. Execute o projeto:
   ```bash
   dotnet run
   ```

4. Acesse no navegador:
   ```
   http://localhost:8080
   ```

---

### 🐳 Executar com Docker

1. Compile a imagem:
   ```bash
   docker build -t checkimc-app .
   ```

2. Execute o container:
   ```bash
   docker run -d -p 8080:80 checkimc-app
   ```

3. Acesse no navegador:
   ```
   http://localhost:8080
   ```

> 💡 Se estiver usando um `docker-compose.yml`, substitua os comandos acima por:
> ```bash
> docker-compose up --build
> ```

---

## 🧪 Executando os Testes

1. Navegue até o projeto de testes:
   ```bash
   cd Check_IMC.Tests
   ```

2. Execute os testes com:
   ```bash
   dotnet test
   ```

---

## 📌 Objetivos do Projeto

- Praticar a estrutura de um projeto MVC com boas práticas.
- Criar uma Web API funcional e simples para cálculo de IMC.
- Implementar testes automatizados com xUnit.
- Executar o projeto em ambiente isolado com Docker.
- Evoluir futuramente com CI/CD e deploy em ambiente de homologação.

---
