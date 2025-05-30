# Desafio Prático POO

Este projeto foi desenvolvido como parte da disciplina de Programação Orientada a Objetos (POO) e consiste em dois sistemas independentes:

- **Biblioteca:** Gerenciamento de livros utilizando listas.
- **Gerenciamento de Funcionários:** Gerenciamento de funcionários utilizando listas e dicionários.

O objetivo do desafio é aplicar conceitos de POO, bem como o uso de estruturas de dados (listas e dicionários), conforme orientações da professora.

## Sumário

- [Descrição dos Sistemas](#descrição-dos-sistemas)
- [Estruturas de Dados Utilizadas](#estruturas-de-dados-utilizadas)
- [Como Executar](#como-executar)
- [Documentação do Código](#documentação-do-código)
- [Autores](#autores)

---

## Descrição dos Sistemas

### 1. Sistema de Biblioteca

O sistema permite:
- Cadastrar livros (título, autor, ISBN)
- Listar todos os livros cadastrados
- Buscar livros por título ou autor
- Atualizar informações de um livro
- Remover livros

A implementação utiliza uma **lista** para armazenar os livros.

### 2. Sistema de Gerenciamento de Funcionários

O sistema permite:
- Cadastrar funcionários (ID, nome, cargo)
- Listar todos os funcionários cadastrados
- Buscar funcionário por nome ou por ID
- Atualizar dados de um funcionário
- Remover funcionários

A implementação utiliza uma **lista** para armazenar funcionários e um **dicionário** para buscas rápidas por ID.

---

## Estruturas de Dados Utilizadas

- **Listas:**  
  Usadas para armazenar coleções de livros e funcionários de forma sequencial.
- **Dicionários:**  
  Usados no gerenciamento de funcionários para otimizar a busca por ID, garantindo acesso mais eficiente.

---

## Como Executar

1. **Pré-requisitos:**  
   - [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)
   - Editor de código C# (Visual Studio, VS Code ou similar)

2. **Clone o repositório:**
   ```bash
   git clone https://github.com/melo-3/DesafioPraticoPOO.git
   cd DesafioPraticoPOO/DesafioPratico
   ```

3. **Execute o projeto:**
   ```bash
   dotnet run
   ```

4. **Siga o menu no console:**  
   Escolha entre os sistemas de Biblioteca ou Funcionários e utilize as opções disponíveis.

---

## Documentação do Código

O código está organizado da seguinte forma:

- `Biblioteca/`  
  - `ClassBiblioteca.cs`: operações de cadastro, busca, atualização e remoção de livros
  - `Livro.cs`: definição da classe Livro
- `GerenciamentoFuncionarios/`  
  - `GerenciadorFuncionarios.cs`: operações de cadastro, busca, atualização e remoção de funcionários
  - `Funcionario.cs`: definição da classe Funcionario
- `Program.cs`: menu principal e execução dos sistemas

Os métodos de cada classe são comentados para facilitar o entendimento.

---

## Autores

- Equipe: Eduardo Paes, Giovanna de Melo e Mariana Alves
- Projeto acadêmico para a disciplina de Programação Orientada a Objetos – 2025

---
