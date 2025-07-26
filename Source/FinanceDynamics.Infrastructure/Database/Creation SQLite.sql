-- Tabela de despesas
CREATE TABLE IF NOT EXISTS Expenses (
    Id           INTEGER    PRIMARY KEY AUTOINCREMENT,
    GuidId       TEXT       NOT NULL UNIQUE,
    Value        REAL       NOT NULL,
    Category     TEXT       NOT NULL,
    Subcategory  TEXT,
    Method       TEXT       NOT NULL,
    DateTime     DATETIME   NOT NULL,    -- tipo DATETIME para affinity de data
    Description  TEXT
);

-- Recibos de transação de despesa
CREATE TABLE IF NOT EXISTS ExpenseTransactionReceipts (
    Id       INTEGER    PRIMARY KEY AUTOINCREMENT,
    GuidId   TEXT       NOT NULL,
    Name     TEXT       NOT NULL,
    File     BLOB       NOT NULL,
    FOREIGN KEY (GuidId) REFERENCES Expenses (GuidId) ON DELETE CASCADE
);

-- Tabela de receitas
CREATE TABLE IF NOT EXISTS Incomes (
    Id           INTEGER    PRIMARY KEY AUTOINCREMENT,
    GuidId       TEXT       NOT NULL UNIQUE,
    Value        REAL       NOT NULL,
    Category     TEXT       NOT NULL,
    Subcategory  TEXT,
    Method       TEXT       NOT NULL,
    DateTime     DATETIME   NOT NULL,    -- aqui também
    Description  TEXT
);

-- Recibos de transação de receita
CREATE TABLE IF NOT EXISTS IncomeTransactionReceipts (
    Id       INTEGER    PRIMARY KEY AUTOINCREMENT,
    GuidId   TEXT       NOT NULL,
    Name     TEXT       NOT NULL,
    File     BLOB       NOT NULL,
    FOREIGN KEY (GuidId) REFERENCES Incomes (GuidId) ON DELETE CASCADE
);
