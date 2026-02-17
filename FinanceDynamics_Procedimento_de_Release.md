# FinanceDynamics – Procedimento de Release

## Objetivo

Garantir que novas versões do sistema sejam publicadas corretamente, sem
perder dados e mantendo estabilidade.

------------------------------------------------------------------------

## 1) Parar a Aplicação

Se estiver rodando, executar:

``` bash
stop-app.bat
```

Ou finalizar manualmente o processo.

------------------------------------------------------------------------

## 2) Atualizar o Banco (se houver alterações no modelo)

Se houver mudanças em:

-   Entidades  
-   DbContext  
-   Relacionamentos  
-   Propriedades  
-   Fluent API

Criar migration:

``` bash
dotnet ef migrations add NomeDaMigration --project Source/FinanceDynamics.Infrastructure --startup-project Source/FinanceDynamics.Presentation
```

Aplicar no banco:

``` bash
dotnet ef database update --project Source/FinanceDynamics.Infrastructure --startup-project Source/FinanceDynamics.Presentation
```

------------------------------------------------------------------------

## 3) Gerar Nova Publicação (Release)

Na raiz do projeto executar:

``` bash
dotnet publish Source/FinanceDynamics.Presentation/FinanceDynamics.Presentation.csproj -c Release -o ./publish
```

------------------------------------------------------------------------

## 4) Testar a Nova Versão

Entrar na pasta publish:

``` bash
cd publish
dotnet FinanceDynamics.Presentation.dll --urls=http://localhost:5050
```

Validar:

-   Inicialização do sistema  
-   CRUDs principais  
-   Persistência no banco  
-   Relatórios

------------------------------------------------------------------------

## 5) Substituir Versão Anterior (se necessário)

-   **Não apagar o arquivo:**  
    `publish/Database/FinanceDynamics.db`  
    (caso contenha dados reais)

-   Substituir apenas os binários se for atualização em outra máquina.

------------------------------------------------------------------------

## 6) Iniciar Aplicação

Executar:

``` bash
start-app.bat
```

------------------------------------------------------------------------

## Boas Práticas (Recomendado)

-   Versionar releases (ex: `releases/1.0.0`, `1.1.0`, etc.)  
-   Nunca apagar banco com dados reais  
-   Testar sempre antes de substituir versão ativa  
-   Manter backup periódico do arquivo `.db`

------------------------------------------------------------------------

**Data de criação:** 16 de fevereiro de 2026
