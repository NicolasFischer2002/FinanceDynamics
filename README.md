# Finance Dynamics - MVP Minimum Viable Product

## Objetivo do Sistema (Resumo)
- Permitir que o usuário doméstico gerencie suas receitas, despesas e investimentos de forma simples e prática.

## (Principais) Funcionalidades do Sistema - Requisitos

### Conta do Usuário
- Login.
- Suporte a multiusuário por meio de login (não simultâneo).
- Recuperação de conta.

### Gerenciamento de Transações - Receitas (Ganhos), Despesas e Investimentos

#### Receitas e Despesas
- Registro de diferentes fontes de receita e despesa.
- Adição de novas formas de receitas e despesas (categorias) de forma personalizada.
- Adição de transações parceladas, como compras ou recebimentos em várias parcelas.
- Adição de transações contínuas, que aparecerão mensalmente por tempo indeterminado nos relatórios (ex.: salário e contas fixas).

#### Investimentos
- Gerenciamento de forma simples de investimentos de renda fixa e de renda variável (ações).

### Armazenamento de Comprovantes
- Armazenamento de arquivos, como comprovantes de pagamento, nos formatos de imagem e PDF.

### Avisos e Alarmes
- Alertas sobre quais despesas estão prestes a vencer ou estão em atraso.

### Relatórios

#### Receitas e Despesas
- Todas as transações cadastradas no sistema.
- Filtrar os dados para separar as transações por tipo, datas e categoria, dentre outras formas.
- Filtrar transações por mês para permitir controle de gastos e ganhos mensais, prevendo também compras parceladas.
- Em resumo, deve gerar relatórios suficientes para o gerenciamento mensal e anual.

#### Investimentos
- Projeções dos investimentos cadastrados, como rendimentos mensais necessários para atingir o valor desejado (renda fixa).
- Calcular ganhos ou perdas baseado no valor cadastrado e no valor atual do ativo (ação).

#### Exportação
- Todos os relatórios devem poder ser exportados para Excel com a extensão `.xlsx`.

### Segurança e Backups
- Dados sensíveis devem ser armazenados criptografados.
- Exportar backups do banco de dados.

## Paradigmas de Programação
- Orientação à Objetos (OOP)

## Padrões e Princípios de Projeto
- Arquitetura Limpa (Clean Architecture)
- SOLID
- Código Limpo (Clean Code)
- Injeção de Dependência (DI)
- Testes Automatizados
- Factory Pattern
- Guard Clauses

## Diagrama de classes
- UML

## Estrutura e Organização do Projeto
- **Domain**: Dados e regras cruciais para o negócio.
- **Application**: Coordena a lógica de aplicação e os casos de uso do sistema.
- **Infrastructure**: Implementa detalhes técnicos, como persistência de dados, acesso a APIs externas e outros serviços auxiliares.
- **Presentation**: GUI - Interface Gráfica do Usuário.

## Tecnologias Utilizadas
- **Visual Studio 2022 Community**
- **Plataforma**: .NET 8.0
- **Linguagem de Programação**: C#
- **Framework ORM**: Entity Framework Core
- **Testes Automatizados**: MSTest
- **Aplicativo**: Console App
- **Banco de Dados**: SQLite
- **Controle de Versão**: GitHub Desktop
- **Diagrama de classes**: Draw.io, disponível em `https://www.drawio.com/`

## Controle de Versão
- Utilização do GitHub Desktop para versionamento do código.

## Requisitos Não Funcionais

- **Facilidade de Manutenção**:
  - Arquitetura limpa aliada a boas práticas de design para garantir que o código seja legível e fácil de evoluir.

- **Facilidade de Uso**:
  - Uso de SQLite e Console App para facilitar o uso local em computadores, após versionar/baixar o projeto.

- **Evolução**:
  - A adoção da Arquitetura Limpa permite que módulos do sistema sejam substituídos ou estendidos de forma independente, sem causar interferências nas demais partes do sistema.
  - Será possível futuramente trocar o aplicativo de console por uma interface em Blazor ou Desktop, ou substituir o SQLite por outro banco de dados, como SQL Server ou MongoDB, sem impactar as regras de negócio ou a lógica central da aplicação. Essa flexibilidade é garantida pela separação clara entre as camadas e pela independência do domínio em relação às tecnologias externas.

## Intenções

Este projeto é **open source** e foi criado com o propósito de servir como uma ferramenta de **desenvolvimento pessoal** e para **fins didáticos**. Seu objetivo é explorar e aplicar conceitos avançados de desenvolvimento e arquitetura de software, proporcionando uma experiência prática e desafiadora para quem está envolvido em sua construção.

A abordagem adotada neste projeto inclui o uso de princípios e padrões amplamente reconhecidos, como **Clean Architecture**, **SOLID**, **Factory Method**, **Clean Code**, **Guard Clauses** e **Testes Automatizados**. Embora isso possa parecer **overengineering** em um sistema relativamente simples, essa complexidade é **intencional** e cuidadosamente planejada. 

O objetivo não é apenas desenvolver um sistema funcional, mas criar uma **demonstração de boas práticas** e um **projeto modelo** que destaque o domínio técnico do autor em projetos de software bem estruturados. Essa escolha reflete o propósito principal do projeto: ser uma vitrine de habilidades, servindo tanto para aprendizado quanto para exibição de competências em desenvolvimento de software.

## Licença e Termos de Uso

Este projeto é **100% open source**, mas com restrições quanto ao uso comercial.

Você pode:
- Usar o sistema livremente para fins pessoais, acadêmicos ou não comerciais.
- Modificar o código e criar versões customizadas.
- Compartilhar ou redistribuir o código-fonte, desde que inclua este aviso de licença e os termos de uso.

**Restrições:**
- Não é permitido comercializar o sistema ou suas versões derivadas.
- Alterações feitas no código devem ser disponibilizadas sob os mesmos termos desta licença.

**Termos de Responsabilidade:**
- Este software é fornecido "como está", sem garantias de qualquer tipo, expressas ou implícitas, incluindo, mas não se limitando, a garantias de comercialização, adequação a uma finalidade específica e não infração. 
- O uso do software é de total responsabilidade do usuário. O autor não será responsável por quaisquer danos ou prejuízos diretos ou indiretos resultantes do uso do sistema.
