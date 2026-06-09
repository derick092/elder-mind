# ElderMind

ElderMind is a tool that uses artificial intelligence to review, analyze, and suggest improvements for source code files.

---

## Project Architecture

The project is built on .NET and structured around Clean Architecture, separating responsibilities into the following layers:

* **ElderMind.Domain:** Contains the core entities and business rules.
* **ElderMind.Infrastructure:** Abstracts communication with external services and LLM APIs.
* **ElderMind.Ai:** Orchestrates the analysis workflow and processes responses from the infrastructure layer.
* **ElderMind.ConsoleApp:** Current entry point of the system, responsible for receiving the file and displaying the analysis results.

---

## Technologies and Patterns

* **Environment:** C# / .NET
* **AI Engine:** MAF (Microsoft Agent Framework)
* **Architecture:** Clean Architecture
* **Design Patterns:**
    * **Factory:** Used to instantiate and manage different LLM providers.
    * **Dependency Injection:** Used to ensure low coupling between components.

---

## Roadmap

* **Directory analysis:** Support for processing multiple files from a structured folder, in addition to individual file analysis.
* **Agent enhancement:** Refinement of prompts and contexts for more accurate feedback.
* **Multi-model support:** Native integration with different LLM providers.
* **Graphical interface:** Development of a front-end interface using .NET MAUI to track analyses.
* **Specialized agents:** Dedicated modules for specific development fronts:
    * Deep analysis of ASP.NET projects.
    * Security vulnerability scanning.
    * Unit test generation and validation.
    * Code design pattern and best practices auditing.

---

<details>
  <summary>Clique aqui para ler a versão em Português do Brasil/ Click here for the Brazilian Portuguese version</summary>

  <br />

  # ElderMind (Versão em Português)

  ElderMind é uma ferramenta que utiliza inteligência artificial para revisar, analisar e sugerir melhorias em arquivos de código-fonte.

  ---

  ## Arquitetura do Projeto

  O projeto foi desenvolvido em .NET estruturado em Clean Architecture, dividindo as responsabilidades nas seguintes camadas:

  * **ElderMind.Domain:** Contém as entidades e as regras de negócio centrais.
  * **ElderMind.Infrastructure:** Abstrai a comunicação com serviços externos e APIs de LLM.
  * **ElderMind.Ai:** Orquestra o fluxo de análise e processa os retornos da camada de infraestrutura.
  * **ElderMind.ConsoleApp:** Ponto de entrada atual do sistema, responsável por receber o arquivo e exibir os resultados da análise.

  ---

  ## Tecnologias e Padrões

  * **Ambiente:** C# / .NET
  * **Engine de IA:** MAF (Microsoft Agent Framework)
  * **Arquitetura:** Clean Architecture
  * **Padrões de Projeto:**
      * **Factory:** Utilizado para instanciar e gerenciar os diferentes provedores de LLM.
      * **Injeção de Dependência:** Utilizada para garantir o baixo acoplamento entre os componentes.

  ---

  ## Roadmap

  * **Análise de diretórios:** Suporte para processar múltiplos arquivos de uma pasta estruturada, além da análise individual.
  * **Aprimoramento do agente:** Refinamento de prompts e contextos para feedbacks mais precisos.
  * **Suporte multimodelos:** Integração nativa com diferentes provedores de LLM.
  * **Interface gráfica:** Desenvolvimento de um front-end em .NET MAUI para acompanhamento das análises.
  * **Agentes especializados:** Módulos dedicados para frentes específicas de desenvolvimento:
      * Análise profunda de projetos ASP.NET.
      * Varredura de vulnerabilidades de segurança.
      * Geração e validação de testes unitários.
      * Auditoria de boas práticas e design patterns.

</details>
