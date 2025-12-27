# ProductApi

API REST simples em .NET para gerenciamento de produtos com Swagger habilitado.

## Estrutura do Projeto
ProductApi/
├── .github/
│&nbsp;&nbsp; └── workflows/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── ci-dotnet.yml&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; # build e testes .NET
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; └── docker-publish.yml&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; # build e publish da imagem (GHCR)
├── .editorconfig
├── .gitattributes
├── .gitignore
├── LICENSE
├── README.md
├── Dockerfile
├── global.json&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; # (opcional) fixa SDK do .NET
├── src/
│&nbsp;&nbsp; └── ProductApi/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── ProductApi.csproj&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; # VS project (ícone do Visual Studio)
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── Domain/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp; └── Product.cs
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── Application/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp; ├── DTOs/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp; │&nbsp;&nbsp; └── ProductDto.cs
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp; └── Mappers/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; └── ProductMapper.cs
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── WebApi/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp; └── Controllers/
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; │&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; └── ProductController.cs
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── Program.cs
│&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; └── appsettings.json
└── tests/
&nbsp;&nbsp;&nbsp; └── ProductApi.Tests/
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ├── ProductApi.Tests.csproj
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; └── ProductMapperTests.cs

## Pré-requisitos
- .NET 10 SDK
- Docker
- GitHub CLI (opcional)

## Como executar localmente
```bash
dotnet restore
dotnet build
dotnet run --project src/ProductApi/ProductApi.csproj
```
Acesse Swagger em: http://localhost:5000/swagger

## Executar testes
```bash
dotnet test
```

## Executar com Docker
```bash
docker build -t productapi:latest .
docker run -d -p 5000:80 productapi:latest
```

## Publicar imagem no GHCR
```bash
docker login ghcr.io -u <SEU_USUARIO> --password <TOKEN>
docker build -t ghcr.io/<SEU_USUARIO>/<NOME_REPO>/productapi:latest .
docker push ghcr.io/<SEU_USUARIO>/<NOME_REPO>/productapi:latest
```

## Configuração de Secrets no GitHub Actions
- GHCR_TOKEN: Token pessoal do GitHub
- GHCR_USERNAME: Seu nome de usuário
