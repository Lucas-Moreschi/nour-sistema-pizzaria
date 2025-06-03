CREATE DATABASE PizzariaDB;
GO
USE PizzariaDB;
GO

-- Tabela de Cadastro de Clientes
CREATE TABLE Clientes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nome NVARCHAR(255) NOT NULL,
    telefone NVARCHAR(20) NOT NULL Unique,
    email NVARCHAR(100),
    endereco NVARCHAR(255),
	ativo BIT DEFAULT 1
);

GO

-- Tabela de Itens
CREATE TABLE Itens (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nome NVARCHAR(255) NOT NULL unique,
    descricao NVARCHAR(MAX),
    preco DECIMAL(10,2) NOT NULL,
    categoria NVARCHAR(50) NOT NULL CHECK (categoria IN ('Pizza', 'Bebida', 'Adicional')),
	ativo BIT DEFAULT 1
);

GO

-- Tabela de Orçamentos
CREATE TABLE Orcamentos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT,
    data_criacao DATETIME DEFAULT GETDATE(),
    valor_total DECIMAL(10,2),
    status NVARCHAR(50) DEFAULT 'Pendente' CHECK (status IN ('Pendente', 'Aprovado', 'Rejeitado')),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id)
);

GO

-- Tabela de Itens de Orçamento
CREATE TABLE Orcamento_Itens (
    id INT IDENTITY(1,1) PRIMARY KEY,
    orcamento_id INT,
    item_id INT,
    quantidade INT NOT NULL,
    preco_unitario DECIMAL(10,2) NOT NULL,
    observacao NVARCHAR(MAX),
    FOREIGN KEY (orcamento_id) REFERENCES Orcamentos(id) ON DELETE CASCADE,
    FOREIGN KEY (item_id) REFERENCES Itens(id) ON DELETE CASCADE
);

GO

-- Tabela de Pedidos
CREATE TABLE Pedidos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT,
    data_pedido DATETIME DEFAULT GETDATE(),
    valor_total DECIMAL(10,2),
    status NVARCHAR(50) DEFAULT 'Em preparo' CHECK (status IN ('Em preparo', 'Pronto', 'Entregue', 'Cancelado')),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id)
);

GO

-- Tabela de Itens de Pedido
CREATE TABLE Pedido_Itens (
    id INT IDENTITY(1,1) PRIMARY KEY,
    pedido_id INT,
    item_id INT,
    quantidade INT NOT NULL,
    preco_unitario DECIMAL(10,2) NOT NULL,
	observacao NVARCHAR(MAX),
    FOREIGN KEY (pedido_id) REFERENCES Pedidos(id) ON DELETE CASCADE,
    FOREIGN KEY (item_id) REFERENCES Itens(id) ON DELETE CASCADE
);