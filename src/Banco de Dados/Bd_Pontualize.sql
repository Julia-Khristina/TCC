-- drop database Db_Pontualize;
CREATE DATABASE IF NOT EXISTS Db_Pontualize;
USE Db_Pontualize;

SET GLOBAL max_allowed_packet = 67108864;

CREATE TABLE Serie (
    cd_Serie INT AUTO_INCREMENT PRIMARY KEY,
    nm_Serie VARCHAR(100) NOT NULL
);

CREATE TABLE Curso (
    cd_Curso INT AUTO_INCREMENT PRIMARY KEY,
    nm_Curso VARCHAR(100) NOT NULL
);

CREATE TABLE Biometria (
    cd_Biometria INT AUTO_INCREMENT PRIMARY KEY,
    dados_Biometria BLOB NOT NULL
);

CREATE TABLE Aluno (
    cd_Aluno INT PRIMARY KEY,
    nm_Aluno VARCHAR(100) NOT NULL,
    gmail_aluno VARCHAR(100) UNIQUE NOT NULL,
    telefone_aluno VARCHAR(20) NOT NULL,
    Serie_Aluno INT NOT NULL,
    Curso_Aluno INT NOT NULL,
    cd_Biometria INT NOT NULL,
    atrasos Int NOT NULL DEFAULT 0,
    foto_aluno LONGBLOB NOT NULL,
    status ENUM('AGUARDANDO_DIGITAL', 'REGISTRANDO_AGORA', 'COMPLETO') NOT NULL,
    FOREIGN KEY (Serie_Aluno) REFERENCES Serie(cd_Serie),
    FOREIGN KEY (Curso_Aluno) REFERENCES Curso(cd_Curso),
    FOREIGN KEY (cd_Biometria) REFERENCES Biometria(cd_Biometria)
);

CREATE TABLE Administrador (
    cd_Administrador INT AUTO_INCREMENT PRIMARY KEY,
    nm_Administrador VARCHAR(100) NOT NULL,
    telefone_Administrador VARCHAR(20) NOT NULL,
    email_Administrador VARCHAR(100) UNIQUE NOT NULL,
    senha_Administrador VARCHAR(255) NOT NULL
);

CREATE TABLE Notificacao (
    cd_Notificacao INT AUTO_INCREMENT PRIMARY KEY,
    cd_Aluno INT,
    mensagem TEXT NOT NULL,
    data_envio DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (cd_Aluno) REFERENCES Aluno(cd_Aluno)
);

-- TABELA DE REGISTRO DE ATRASOS
CREATE TABLE RegistroAtraso (
    cd_Registro INT AUTO_INCREMENT PRIMARY KEY,
    cd_Aluno INT,
    nm_Aluno VARCHAR(100),
    nm_Serie VARCHAR(100),
    nm_Curso VARCHAR(100),
    horario_entrada TIME,
    data_registro DATE,
    FOREIGN KEY (cd_Aluno) REFERENCES Aluno(cd_Aluno)
);

-- VIEW DE ENTRADAS
CREATE VIEW Entradas AS
SELECT 
    A.cd_Aluno AS rm_Aluno,
    A.nm_Aluno,
    S.nm_Serie,
    C.nm_Curso,
    CURRENT_TIME() AS Horario_Entrada,
    CURRENT_DATE() AS Data
FROM Aluno A
JOIN Serie S ON A.Serie_Aluno = S.cd_Serie
JOIN Curso C ON A.Curso_Aluno = C.cd_Curso
WHERE (
    (CURRENT_TIME() < '15:30:00' AND CURRENT_TIME() <= '07:45:59') OR
    (CURRENT_TIME() >= '15:30:00' AND CURRENT_TIME() <= '18:15:59')
);

-- TRIGGER DE AVISO DE 3 ATRASOS
DELIMITER //
CREATE TRIGGER trig_AVISO_3_atrasos
AFTER INSERT ON RegistroAtraso
FOR EACH ROW
BEGIN
    DECLARE qtd_atrasos INT;
    DECLARE detalhes_atrasos TEXT;

    SELECT COUNT(*) INTO qtd_atrasos
    FROM RegistroAtraso
    WHERE cd_Aluno = NEW.cd_Aluno;

    IF qtd_atrasos = 3 THEN
        SELECT GROUP_CONCAT(
            DATE_FORMAT(data_registro, '%d/%m/%Y') SEPARATOR ', '
        ) INTO detalhes_atrasos
        FROM (
            SELECT data_registro
            FROM RegistroAtraso
            WHERE cd_Aluno = NEW.cd_Aluno
            ORDER BY data_registro
            LIMIT 3
        ) AS UltimosAtrasos;

        INSERT INTO Notificacao (cd_Aluno, mensagem)
        VALUES (
            NEW.cd_Aluno,
            CONCAT(
                'Você acumulou 3 atrasos. Isso é um aviso: o próximo atraso resultará em advertência. ',
                'Os dias dos atrasos foram: ', detalhes_atrasos, '.'
            )
        );
    END IF;
END;
//
DELIMITER ;

-- INSERÇÕES BÁSICAS
INSERT INTO Serie (nm_Serie) VALUES
('Primeiro ano'),
('Segundo ano'),
('Terceiro ano');

INSERT INTO Curso (nm_Curso) VALUES
('Automação Industrial'),
('Administração'),
('Desenvolvimento de Sistemas');

INSERT INTO Biometria (dados_Biometria) VALUES
('A1B2C3D4'), ('B1C2D3E4'), ('C1D2E3F4'),
('D1E2F3A4'), ('E1F2A3B4'), ('F1A2B3C4'),
('A2B3C4D5'), ('B2C3D4E5'), ('C2D3E4F5'),
('D2E3F4A5'), ('E2F3A4B5'), ('F2A3B4C5'),
('A3B4C5D6'), ('B3C4D5E6'), ('C3D4E5F6'),
('D3E4F5A6'), ('E3F4A5B6'), ('F3A4B5C6');

INSERT INTO Aluno (cd_aluno, nm_Aluno, gmail_aluno, telefone_aluno, Serie_Aluno, Curso_Aluno, cd_Biometria, atrasos, foto_aluno) VALUES
-- Curso 1: Automação Industrial
('230060','Ana Silva', 'aluno1@gmail.com', '11999990001', 1, 1, 1, 0, 'FFD8FFE0'),
('230061', 'Bruno Costa', 'aluno2@gmail.com', '11999990002', 1, 1, 2, 1, 'FFD8FFE0'),

('240030', 'Carla Souza', 'aluno3@gmail.com', '11999990003', 2, 1, 3, 0, 'FFD8FFE0'),
('240031', 'Diego Lima', 'aluno4@gmail.com', '11999990004', 2, 1, 4, 2, 'FFD8FFE0'),

('250024', 'Eduarda Alves', 'aluno5@gmail.com', '11999990005', 3, 1, 5, 0, 'FFD8FFE0'),
('250025', 'Felipe Torres', 'aluno6@gmail.com', '11999990006', 3, 1, 6, 1, 'FFD8FFE0'),

-- Curso 2: Administração
('230070', 'Gabriela Rocha', 'aluno7@gmail.com', '11999990007', 1, 2, 7, 0, 'FFD8FFE0'),
('230071', 'Henrique Melo', 'aluno8@gmail.com', '11999990008', 1, 2, 8, 3, 'FFD8FFE0'), 

('240067', 'Isabela Martins', 'aluno9@gmail.com', '11999990009', 2, 2, 9, 0, 'FFD8FFE0'),
('240068', 'João Pedro', 'aluno10@gmail.com', '11999990010', 2, 2, 10, 0, 'FFD8FFE0'),

('250067', 'Karen Oliveira', 'aluno11@gmail.com', '11999990011', 3, 2, 11, 0, 'FFD8FFE0'),
('250069', 'Lucas Ribeiro', 'aluno12@gmail.com', '11999990012', 3, 2, 12, 2, 'FFD8FFE0'),

-- Curso 3: Desenvolvimento de Sistemas
('230093', 'Mariana Fernandes', 'aluno13@gmail.com', '11999990013', 1, 3, 13, 0, 'FFD8FFE0'),
('230094', 'Nicolas Barros', 'aluno14@gmail.com', '11999990014', 1, 3, 14, 1, 'FFD8FFE0'),

('240009', 'Olivia Prado', 'aluno15@gmail.com', '11999990015', 2, 3, 15, 0, 'FFD8FFE0'),
('240010', 'Paulo Henrique', 'aluno16@gmail.com', '11999990016', 2, 3, 16, 0, 'FFD8FFE0'),

('250048', 'Renata Cardoso', 'aluno17@gmail.com', '11999990017', 3, 3, 17, 0, 'FFD8FFE0'),
('250049', 'Thiago Moreira', 'aluno18@gmail.com', '11999990018', 3, 3, 18, 1, 'FFD8FFE0');



INSERT INTO Administrador (nm_Administrador, telefone_Administrador, email_Administrador, senha_Administrador)
VALUES
('Mestre dos Magos', '12999999999', 'etec@gmail.com', '$2a$12$TaL734zFwCyAQUhNwnCucOESnPOKLTOIerLbW31Rhx8iXDQpZQjIW');

select * from Administrador;

-- EXEMPLO DE INSERÇÃO DE ATRASO
/*
INSERT INTO RegistroAtraso (cd_Aluno, nm_Aluno, nm_Serie, nm_Curso, horario_entrada, data_registro)
SELECT 
    A.cd_Aluno,
    A.nm_Aluno,
    S.nm_Serie,
    C.nm_Curso,
    CURRENT_TIME(),
    CURRENT_DATE()
FROM Aluno A
JOIN Serie S ON A.Serie_Aluno = S.cd_Serie
JOIN Curso C ON A.Curso_Aluno = C.cd_Curso
WHERE (
    (CURRENT_TIME() < '15:30:00' AND CURRENT_TIME() > '07:45:59') OR
    (CURRENT_TIME() >= '15:30:00' AND CURRENT_TIME() > '18:15:59')
);
*/
