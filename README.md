# nour-sistema-pizzaria
Nour - Sistema de Gestão para Pizzarias  Nour é um sistema completo e intuitivo desenvolvido para facilitar a gestão de pequenas e médias pizzarias.

# 🍕 Sistema de Gestão de Pizzaria

Sistema desktop desenvolvido em C# (Windows Forms) com banco de dados SQL Server, voltado para a gestão de uma pizzaria. O sistema permite cadastro de clientes, geração de orçamentos, emissão de pedidos, controle de produtos e geração de relatórios.

---

## 📌 Funcionalidades

- ✅ Cadastro de Clientes
- ✅ Cadastro de Itens (Pizzas, Bebidas e Adicionais)
- ✅ Criação de Orçamentos
- ✅ Conversão de Orçamentos em Pedidos
- ✅ Controle dos Pedidos (Em produção, Finalizado, Cancelado)
- ✅ Relatórios de vendas, pedidos e clientes
- ✅ Controle de estoque (ativos dos itens)

---

## 🧠 Tecnologias Utilizadas

- 💻 **Linguagem:** C# (Windows Forms)
- 🗄️ **Banco de Dados:** SQL Server
- 🔧 **IDE:** Visual Studio
- 📊 **Arquitetura:** Local, com banco de dados SQL Server Express

---

## 🗺️ Estrutura do Banco de Dados

### 🔗 Tabelas

| Tabela             | Descrição                                          |
|--------------------|----------------------------------------------------|
| **Clientes**       | Cadastro de clientes                               |
| **Itens**          | Itens vendidos (Pizzas, Bebidas, Adicionais)       |
| **Orcamentos**     | Orçamentos gerados para os clientes                |
| **Orcamento_Itens**| Itens vinculados a cada orçamento                  |
| **Pedidos**        | Pedidos gerados a partir de orçamentos aprovados   |
| **Pedido_Itens**   | Itens vinculados aos pedidos                       |

### 🔗 Relacionamentos

- Um **Cliente** → possui vários **Orçamentos**.
- Um **Orçamento** → possui vários **Itens**.
- Um **Orçamento aprovado** → gera um **Pedido**.
- Um **Pedido** → possui seus próprios itens vinculados.

---

## 🔥 Fluxo de Funcionamento

1. Cadastrar o cliente (se necessário).
2. Criar um orçamento, escolhendo os itens (Pizzas, Bebidas, Adicionais).
3. O orçamento pode ser:
   - ✅ **Aprovado** → gera um **Pedido**.
   - ❌ **Rejeitado**.
4. O pedido é acompanhado com status:
   - 🏗️ **Em produção**
   - ✅ **Finalizado**
   - ❌ **Cancelado**
5. O sistema permite gerar relatórios e gerenciar clientes e produtos.

---

## 📸 Telas do Sistema

| Tela                            | Descrição                        |
|----------------------------------|-----------------------------------|
| Cadastro de Clientes             | Gerenciar clientes                |
| Cadastro de Itens                | Cadastrar Pizzas, Bebidas, etc.   |
| Tela de Orçamentos               | Gerar orçamentos para clientes    |
| Tela de Pedidos                  | Acompanhar produção dos pedidos   |
| Tela de Relatórios               | Vendas, produtos e clientes       |

---

## 🏁 Como Executar o Projeto


1. Clone este repositório:

    ```bash
    git clone https://github.com/Lucas-Moreschi/nour-sistema-pizzaria.git
    ```

2. Abra a solução no Visual Studio (PrjPizzaria.sln).  
3. Configure a conexão com o banco de dados SQL Server Express ou local.  
4. Execute os scripts do banco (PizzariaDB.sql) para criar as tabelas.  
5. Execute o projeto (F5).   

---

## 🏗️ Melhorias Futuras

- Implementação de Delivery  
- Integração com pagamento online  
- Dashboard com indicadores visuais  
- Controle mais avançado de estoque  

---

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.  

---

## 🧑‍💻 Desenvolvedor

Lucas Moreschi Guerra  
Aluno de Ciência da Computação na Universidade Nove de Julho (UNINOVE)  

---

## 📜 Licença

Este projeto é de uso acadêmico, desenvolvido como trabalho de conclusão de semestre.



