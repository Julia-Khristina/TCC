CREATE DATABASE Db_Pontualize;
USE Db_Pontualize;

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
    cd_Aluno INT AUTO_INCREMENT PRIMARY KEY,
    nm_Aluno VARCHAR(100) NOT NULL,
    gmail_aluno VARCHAR(100) NOT NULL,
    telefone_aluno VARCHAR(11) NOT NULL,
    Serie_Aluno INT,
    Curso_Aluno INT,
    cd_Biometria INT NOT NULL,
    FOREIGN KEY (Serie_Aluno) REFERENCES Serie(cd_Serie),
    FOREIGN KEY (Curso_Aluno) REFERENCES Curso(cd_Curso)
);

CREATE TABLE Administrador (
    cd_Administrador INT AUTO_INCREMENT PRIMARY KEY,
    nm_Administrador VARCHAR(100) NOT NULL,
    telefone_Administrador VARCHAR(20) NOT NULL,
    email_Administrador VARCHAR(100) UNIQUE NOT NULL,
    senha_Administrador VARCHAR(255) NOT NULL
);

-- VIEW DE ENTRADAS COMUNS
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

-- TABELA ATRASOS
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

-- AVISO DE 3 ATRASOS
DELIMITER //
CREATE TRIGGER trig_AVISO_3_atrasos
AFTER INSERT ON RegistroAtraso
FOR EACH ROW
BEGIN
    DECLARE qtd_atrasos INT;
    DECLARE detalhes_atrasos TEXT;

    -- Conta a quantidade de atrasos do aluno
    SELECT COUNT(*) INTO qtd_atrasos
    FROM RegistroAtraso
    WHERE cd_Aluno = NEW.cd_Aluno;

    IF qtd_atrasos = 3 THEN
        -- Monta a lista de datas e horários dos 3 atrasos
        SELECT GROUP_CONCAT(
            DATE_FORMAT(data_registro, '%d/%m/%Y') 
            SEPARATOR ', '
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

-- Inserções Básicas
INSERT INTO Serie (nm_Serie) VALUES
('Primeiro ano'),
('Segundo ano'),
('Terceiro ano');

INSERT INTO Curso (nm_Curso) VALUES
('Automação Industrial'),
('Administração'),
('Desenvolvimento de Sistemas');

INSERT INTO Administrador (nm_Administrador, telefone_Administrador, email_Administrador, senha_Administrador)
VALUES
('Regiane Moraes Silva', '12 999999999', 'etec@gmail.com', '1234#');

-- Select
SELECT * FROM Administrador;
