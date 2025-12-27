# ProductApi

API REST simples em .NET para gerenciamento de produtos com Swagger habilitado.

## Estrutura do Projeto
ProductApi/
├── ProductApi.sln
├── .github/workflows/
│   ├── ci-dotnet.yml
│   └── docker-publish.yml
├── src/ProductApi/
├── tests/ProductApi.Tests/

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
