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
