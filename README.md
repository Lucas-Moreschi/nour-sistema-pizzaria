# nour-sistema-pizzaria
Nour - Sistema de Gestão para Pizzarias  
Nour é um sistema completo e intuitivo, desenvolvido para facilitar a gestão de pequenas e médias pizzarias com praticidade.

# 🍕 Sistema de Gestão de Pizzaria

Este é um sistema desktop feito em C# (Windows Forms) com banco de dados SQL Server, focado em otimizar a gestão da sua pizzaria. Com ele, você pode cadastrar clientes, criar orçamentos, emitir pedidos, controlar produtos e gerar relatórios detalhados.

---

## 📌 Funcionalidades

- ✅ Cadastro rápido e fácil de Clientes  
- ✅ Cadastro completo de Itens (Pizzas, Bebidas e Adicionais)  
- ✅ Criação e edição de Orçamentos personalizados  
- ✅ Conversão automática de Orçamentos aprovados em Pedidos  
- ✅ Gestão dos Pedidos com status claros (Em produção, Finalizado, Cancelado)  
- ✅ Relatórios para analisar vendas, pedidos e clientes  
- ✅ Controle básico de estoque para acompanhar ativos dos itens

---

## 🧠 Tecnologias Utilizadas

- 💻 **Linguagem:** C# com Windows Forms  
- 🗄️ **Banco de Dados:** SQL Server (Express/local)  
- 🔧 **IDE:** Visual Studio  
- 📊 **Arquitetura:** Aplicação local com banco SQL Server Express

---

## 🗺️ Estrutura do Banco de Dados

### 🔗 Tabelas

| Tabela              | Descrição                                       |
|---------------------|------------------------------------------------|
| **Clientes**        | Cadastro dos clientes                           |
| **Itens**           | Cardápio: Pizzas, Bebidas e Adicionais         |
| **Orcamentos**      | Orçamentos criados para clientes                |
| **Orcamento_Itens** | Itens vinculados a cada orçamento               |
| **Pedidos**         | Pedidos gerados a partir de orçamentos aprovados|
| **Pedido_Itens**    | Itens vinculados aos pedidos                     |

### 🔗 Relacionamentos

- Um **Cliente** pode ter vários **Orçamentos**.  
- Cada **Orçamento** inclui diversos **Itens**.  
- Um orçamento aprovado gera automaticamente um **Pedido**.  
- Cada **Pedido** contém seus próprios itens vinculados.

---

## 🔥 Fluxo de Funcionamento

1. Cadastre os clientes quando necessário.  
2. Monte um orçamento escolhendo os itens desejados (pizzas, bebidas, adicionais).  
3. O orçamento pode ser:  
   - ✅ **Aprovado** e automaticamente transformado em pedido.  
   - ❌ **Rejeitado** ou alterado conforme necessidade.  
4. Acompanhe o pedido com status:  
   - 🏗️ **Em produção**  
   - ✅ **Finalizado**  
   - ❌ **Cancelado**  
5. Utilize os relatórios para acompanhar vendas, clientes e estoque.

---

## 📸 Telas do Sistema


| Tela                   | Descrição                         |
|------------------------|----------------------------------|
| Cadastro de Clientes    | Gerencie os dados dos clientes    |
| Cadastro de Itens       | Cadastre pizzas, bebidas e extras |
| Tela de Orçamentos     | Crie e controle orçamentos        |
| Tela de Pedidos        | Acompanhe os pedidos em andamento |
| Tela de Relatórios     | Visualize vendas, estoque e clientes |

---

### 📸 Telas do Sistema

#### Cadastro de Clientes  
![Cadastro de Clientes](screenshots/cadastroClientes.png)

#### Cadastro de Itens  
![Cadastro de Itens](screenshots/cadastroItens.png)

#### Consulta de Orçamento  
![Consulta de Orçamento](screenshots/consultaOrcamento.png)

#### Novo Orçamento  
![Novo Orçamento](screenshots/novoOrcamento.png)

#### Tela de Pedidos  
![Tela de Pedidos](screenshots/pedidos.png)

#### Tela de Relatórios  
![Tela de Relatórios](screenshots/relatorios.png)

---

## 🏁 Como Executar o Projeto

1. Clone este repositório:

    ```bash
    git clone https://github.com/Lucas-Moreschi/nour-sistema-pizzaria.git
    ```

2. Abra a solução no Visual Studio (PrjPizzaria.sln).  
3. Configure a conexão com seu banco SQL Server Express ou local.  
4. Execute o script `PizzariaDB.sql` para criar as tabelas no banco.  
5. Inicie o projeto (F5) e comece a usar.

---

## 🏗️ Melhorias Futuras

- Implantar sistema de delivery  
- Integrar pagamento online  
- Criar dashboards com indicadores visuais  
- Avançar no controle de estoque

---

## 🤝 Contribuição

Sua contribuição é muito bem-vinda! Fique à vontade para abrir issues e enviar pull requests.

---

## 🧑‍💻 Desenvolvedor

Lucas Moreschi Guerra  
Aluno de Ciência da Computação na Universidade Nove de Julho (UNINOVE)

---

## 📜 Licença

Projeto acadêmico desenvolvido como trabalho de conclusão de semestre.
