# ElderMind

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
