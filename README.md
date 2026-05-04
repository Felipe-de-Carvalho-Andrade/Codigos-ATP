# 🚀 Codigos-ATP

### Algoritmos e Técnicas de Programação — Sistemas de Informação | PUC Minas

[![.NET](https://img.shields.io/badge/.NET-Console-blueviolet)]()
[![C#](https://img.shields.io/badge/C%23-Language-239120)]()
[![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)]()
[![License](https://img.shields.io/badge/license-Acad%C3%AAmico-lightgrey)]()

---

## 📖 Sobre o Projeto

Este repositório reúne exercícios desenvolvidos ao longo da disciplina de **Algoritmos e Técnicas de Programação (ATP)**, no curso de **Sistemas de Informação da PUC Minas**.

O projeto foi estruturado como uma aplicação de console em **C# (.NET)**, com o objetivo de consolidar fundamentos essenciais de programação, incluindo lógica, organização de código e boas práticas iniciais.

A aplicação fornece um menu interativo que permite acessar diferentes categorias de exercícios de forma modular e organizada.

---

## 🧱 Arquitetura e Organização

A estrutura do projeto foi pensada para separar responsabilidades e facilitar a navegação entre os conteúdos:

```id="8k2p0z"
📁 Codigos-ATP
├── 📁 Categorias/        # Implementação dos exercícios por tema
│   ├── Condicionais.cs
│   ├── Iniciais.cs
│   ├── Repeticao.cs
│   ├── Vetores.cs
│   └── Laboratorio.cs
│
├── 📁 Core/              # Núcleo da aplicação (controle de fluxo)
│   ├── MenuCategoria.cs
│   └── MenuPrincipal.cs
│
├── Codigos-ATP.csproj    # Configuração do projeto .NET
├── Codigos-ATP.sln       # Solução do Visual Studio
├── Program.cs            # Ponto de entrada da aplicação
└── README.md             # (Este arquivo)
```

> ⚠️ As pastas `bin/` e `obj/` são geradas automaticamente pelo .NET e estão devidamente ignoradas no versionamento.

---

## ⚙️ Funcionalidades

* 📌 Menu interativo via console
* 🧭 Navegação por categorias de exercícios
* 🧩 Organização modular por tema
* 🔄 Execução contínua até escolha de saída

### Exemplo de Fluxo

A aplicação inicia exibindo um menu principal:

```id="s4v6f8"
===== SISTEMA DE EXERCÍCIOS =====
1 - Exercícios Iniciais
2 - Exercícios Condicionais
3 - Exercícios de Repetição
4 - Exercícios de Vetores e Matrizes
5 - Exercícios do Laboratório
0 - Sair
```

A navegação é gerenciada pela classe `MenuPrincipal`, que delega a execução para `MenuCategoria`.

---

## 🧠 Conteúdos Abordados

O projeto cobre os principais fundamentos iniciais da programação:

* **Lógica de Programação**
* **Estruturas Condicionais** (`if`, `else`, `switch`)
* **Estruturas de Repetição** (`for`, `while`, `do-while`)
* **Vetores e Matrizes**
* **Práticas Orientadas de Laboratório**

---

## 🚀 Como Executar

### Pré-requisitos

* [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/codigos-atp.git

# Acessar o diretório
cd codigos-atp

# Executar o projeto
dotnet run
```

---

## 🎯 Objetivo Acadêmico

Este projeto tem como finalidade:

* Consolidar fundamentos de programação e da linguagem C#
* Exercitar resolução de problemas

---

## 👨‍💻 Autor

Desenvolvido por Felipe de Carvalho Andrade, estudante de **Sistemas de Informação — PUC Minas**
Disciplina: **Algoritmos e Técnicas de Programação**

---

## 📄 Licença

Este projeto é destinado exclusivamente para fins **acadêmicos e educacionais**.