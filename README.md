# FinanceDynamics 🚀

**Controle financeiro pessoal** — aplicação-laboratório desenvolvida em **C# (.NET 8)** com foco em boas práticas de engenharia de software e experimentação técnica.

---

## O que é
FinanceDynamics é uma app para gerenciar finanças pessoais. Foi criada como um **laboratório** para experimentar arquitetura limpa, DDD, padrões de projeto e um front-end moderno e responsivo.

## Principais conceitos aplicados
- Orientação a objetos (POO)  
- Arquitetura limpa — camadas: Domain, Application, Infrastructure, Presentation  
- DDD (entidades, value objects imutáveis, validações de domínio)  
- SOLID, Clean Code (small functions, nomes significativos)  
- Injeção de dependência, Factory Method, Guard Clauses  
- Uso de DTOs para fronteiras de aplicação  
- Código em inglês para maior compartilhamento internacional

## 🚀 Tecnologias

- **C#** / **.NET 8**
- **Visual Studio Insiders** (IDE de desenvolvimento)
- **Blazor Server**
- **MudBlazor** — UI moderna, componentizada e responsiva
- **SQLite** — banco de dados local (arquivo `.db`)
- **Entity Framework Core** — ORM
- **GitHub Desktop** — versionamento

### 🔧 Ferramentas úteis

- https://sqliteviewer.app/  
- https://markdownlivepreview.com/

---

## Quickstart — rodando a versão empacotada (.zip)
1. Baixe e extraia o arquivo `FinanceDynamics v1.0.zip` (contendo a pasta `publish/` do release).  
2. Instale o **ASP.NET Core Runtime / .NET 8** na máquina.  
3. Abra a pasta `publish/` e use os scripts:  
   - `start-app.bat` — inicia a aplicação (abre o navegador em `http://localhost:5050`) 🚀  
   - `stop-app.bat` — finaliza a instância que está escutando na porta 5050 🛑  
4. Mantenha o arquivo `publish/Database/FinanceDynamics.db` se quiser preservar dados entre releases.

---

## Desenvolvimento (resumo)
```bash
# restaurar e compilar
dotnet restore
dotnet build -c Release

# executar em dev
cd Source/FinanceDynamics.Presentation
dotnet run
```

### Publicar (gerar zip de release)
```bash
dotnet publish Source/FinanceDynamics.Presentation/FinanceDynamics.Presentation.csproj -c Release -o ./publish
# compactar a pasta publish em publish.zip e distribuir
```

---

## Propósito
Projeto educacional/experimental — objetivo principal: aplicar e validar técnicas de engenharia de software em um cenário prático (local-first), usando uma UI moderna e um banco leve que permite execução offline.

---

## 👥 Equipe do Projeto

- 📋 Levantamento de Requisitos — Nicolas Fischer  
- 🧠 Arquitetura & Back-End — Nicolas Fischer  
- 🎨 Front-End & UI — Nicolas Fischer  
- 🗄 Estruturação do Banco de Dados — Nicolas Fischer  
- 🔄 Versionamento — Nicolas Fischer  
- 🚀 Publicação — Nicolas Fischer  

> Projeto solo, mas com múltiplos papéis 😉

---