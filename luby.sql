--script para criar schema e popular tabelas
CREATE TABLE tabela_pessoa (
    id int IDENTITY (1,1) NOT NULL PRIMARY KEY,
    nome varchar(255),
);
INSERT INTO tabela_pessoa 
VALUES ('John Doe'), ('Jane Doe'), ('Alice Jones'), ('Boby Louis'), ('Lisa Romero');

CREATE TABLE tabela_evento (
    id int IDENTITY (1,1) NOT NULL PRIMARY KEY,
    evento varchar(255),
    pessoa_id int FOREIGN KEY REFERENCES tabela_pessoa(id)
);
INSERT INTO tabela_evento 
VALUES ('Evento A', 2), ('Evento B', 3), ('Evento C', 2), ('Evento D', NULL);


--query 2.1
SELECT p.id, p.nome, e.evento 
FROM tabela_pessoa p left join tabela_evento e on (p.id = e.pessoa_id) 

--query 2.2
SELECT * 
FROM tabela_pessoa
WHERE nome LIKE '%Doe%'

--query 2.3
INSERT INTO tabela_evento
VALUES ('Evento E', 5);

--query 2.4
UPDATE tabela_evento
SET pessoa_id = 1
WHERE evento = 'Evento D';

--query 2.5
DELETE FROM tabela_evento 
WHERE evento = 'Evento B';

--query 2.6 (join)
DELETE FROM tabela_pessoa p left join tabela_evento e on (p.id = e.pessoa_id)
WHERE e.pessoa_id is null
--ou (subquery)
DELETE tabela_pessoa
WHERE id NOT IN (SELECT pessoa_id FROM tabela_evento)

--query 2.7
ALTER TABLE tabela_pessoa 
ADD idade int;

--query 2.8
CREATE TABLE tabela_telefone (
  id int IDENTITY (1,1) NOT NULL PRIMARY KEY,
  telefone varchar(200),
  pessoa_id int FOREIGN KEY REFERENCES tabela_pessoa(id) 
);

--query 2.9
CREATE UNIQUE INDEX indice_tel
ON telefone (tabela_telefone);

--query 2.10
DROP TABLE tabela_telefone;