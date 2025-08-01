# 🏢 Sistema de Cadastro e Consulta de Empresas via CNPJ

Este projeto consiste em uma aplicação fullstack com backend em .NET e frontend em Next.js, que permite o cadastro e listagem de empresas por meio da consulta automática dos dados via API pública da ReceitaWS.

---

## **📁 Estrutura do Projeto**

### Backend (.NET)

O backend foi desenvolvido em ASP.NET Core, com autenticação baseada em JWT, armazenamento seguro de senhas com hash e conexão com banco de dados relacional.

### Frontend (Next.js)

O frontend foi desenvolvido com Next.js, oferecendo uma interface moderna e responsiva, com autenticação integrada e consumo das APIs para cadastro e listagem de empresas.

---

# **🔹 Passo a Passo para Rodar o Projeto**

## **1️⃣ Pré-requisitos**

Antes de começar, é necessário ter instalado:

✅ [.NET SDK](https://dotnet.microsoft.com/download)
✅ [Node.js + npm](https://nodejs.org/)
✅ Banco de dados relacional **PostgreSQL**
✅ [Git](https://git-scm.com/downloads)

---

## **2️⃣ Clonar o Repositório**

No terminal, execute:

```bash
git clone https://github.com/TH3USS/cnpj-register.git
```

---

## **3️⃣ Configurar Banco de Dados**

* Crie o banco de dados no seu ambiente (PostgreSQL ou SQL Server).
* Atualize a string de conexão no `appsettings.json` do backend com o nome do servidor, banco e credenciais.
* Rode as migrações ou scripts necessários para estruturar o banco.

---

## **4️⃣ Rodar o Backend (.NET)**

Dentro da pasta do backend, execute:

```bash
dotnet restore
dotnet build
dotnet run
```

---

## **5️⃣ Rodar o Frontend (Next.js)**

Dentro da pasta do frontend, execute:

```bash
npm install
npm run dev
```

---

Ao acessar o frontend no navegador, você poderá realizar login, cadastrar uma empresa via CNPJ e visualizar a listagem das empresas associadas ao seu usuário.
Exemplo:

```bash
http://localhost:3000
```

---

# **🔥 Resumo dos Comandos**

```bash
# Clonar o projeto
git clone https://github.com/TH3USS/cnpj-register.git

# Backend
cd backend
dotnet restore
dotnet build
dotnet run

# Frontend
cd frontend
npm install
npm run dev
```

---

# **📌 Tecnologias e Ferramentas Utilizadas**

## **1️⃣ Frontend - Next.js**

Frontend moderno, rápido e server-side renderizado com Next.js.

### 🔹 Tecnologias principais

✅ **Next.js** → Framework React para SSR
✅ **React.js** → Biblioteca para UI interativa
✅ **Axios** → Consumo de APIs
✅ **JWT (via cookies)** → Autenticação do usuário
✅ **Tailwind CSS** → Estilização da aplicação

---

## **2️⃣ Backend - ASP.NET Core**

API REST segura desenvolvida com ASP.NET Core e autenticação JWT.

### 🔹 Tecnologias principais

✅ **ASP.NET Core** → Backend moderno em .NET
✅ **Entity Framework Core** → ORM para acesso a dados
✅ **JWT** → Autenticação baseada em token
✅ **BCrypt** → Hash seguro de senhas
✅ **HttpClient** → Requisições à API da ReceitaWS
✅ **AutoMapper** → Conversão entre DTOs e entidades

---

## **3️⃣ API Pública Utilizada**

✅ **ReceitaWS API**
→ [https://www.receitaws.com.br/v1/cnpj/{cnpj}](https://www.receitaws.com.br/v1/cnpj/{cnpj})
Consulta automática dos dados da empresa com base no CNPJ.

Campos extraídos:

* Nome empresarial
* Nome fantasia
* CNPJ
* Situação
* Abertura
* Tipo
* Natureza jurídica
* Atividade principal
* Endereço (logradouro, número, complemento, bairro, município, UF, CEP)

---

## **4️⃣ Banco de Dados Relacional**

✅ **PostgreSQL**
→ Armazena usuários autenticados e empresas cadastradas por CNPJ

---

## **5️⃣ Ferramentas Auxiliares**

✅ **Git & GitHub** → Controle de versão
✅ **Visual Studio / VS Code** → Desenvolvimento
✅ **Insomnia / Postman** → Testes de API

---

# **🚀 Conclusão**

Este projeto integra autenticação segura, API pública e interface moderna para permitir que usuários cadastrem empresas por meio do CNPJ.
Com backend robusto em .NET e frontend otimizado em Next.js, a aplicação oferece praticidade, segurança e escalabilidade.
