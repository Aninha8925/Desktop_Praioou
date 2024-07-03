create database if not exists db_praioou;

use db_praioou;

create table if not exists cliente (
	cd_cliente int AUTO_INCREMENT,
    nm_cliente varchar(45),
    ds_emailC varchar(100),
    nmr_telefoneC varchar(15),
    ds_senhaC varchar(100),
    
    
	constraint pk_cliente
		primary key (cd_cliente)
);





create table if not exists barraqueiro (
	cd_barraqueiro int auto_increment,
    nm_barraqueiro varchar(85),
    ds_emailB varchar(100),
    ds_senhaB varchar (15),
    nmr_telefoneB char(20),
    
    constraint pk_barraqueiro
		primary key (cd_barraqueiro)
);

create table if not exists carrinho (
	cd_carrinho int auto_increment,
    cd_barraqueiro int,
    nm_carrinho varchar(45),
    ds_localizacao text(85),
    qt_pedido int(100),
    
    constraint pk_carrinho
		primary key (cd_carrinho),
        
	constraint fk_barraqueiro_carrinho
		foreign key(cd_barraqueiro)
			references barraqueiro(cd_barraqueiro)
);

create table if not exists reserva (
	cd_reserva int auto_increment,
    cd_carrinho int,
    cd_cliente int,
    dt_reserva date,
    hr_reserva time,
    vl_reserva float,
    
    constraint pk_reserva
		primary key (cd_reserva),
        
	constraint pk_reserva_carrinho
		foreign key (cd_carrinho)
			references carrinho (cd_carrinho),
        
	constraint pk_reserva_cliente
		foreign key (cd_cliente)
			references cliente(cd_cliente)
);

create table if not exists cardapio (
	cd_cardapio int auto_increment,
    cd_carrinho int,

    constraint pk_cardapio
		primary key (cd_cardapio),
        
	constraint fk_cardapio_carrinho
		foreign key (cd_carrinho)
			references carrinho(cd_carrinho)
);

create table produto (
	cd_produto int auto_increment,
    nm_produto varchar(45),
    vl_produto float,
    constraint pk_produto
		primary key (cd_produto)
	
);

create table if not exists pedido (
	cd_pedido int auto_increment,
	cd_carrinho int,
    cd_cliente int,
    vl_total_pedido float,
    ds_guarda_sol char(2),
    
    constraint pk_pedido
		primary key (cd_pedido),
	
    constraint fk_pedido_cliente
		foreign key (cd_cliente)
			references cliente(cd_cliente),
	
    constraint fk_carrinho
		foreign key (cd_carrinho)
			references carrinho(cd_carrinho)
);

create table if not exists sacola (
	cd_pedido int not null,
    cd_produto int not null,
    quantidade int,
    
    constraint pk_sacola
        primary key (cd_pedido, cd_produto),
    
    constraint fk_sacola_pedido
        foreign key (cd_pedido)
            references pedido(cd_pedido),
    
    constraint fk_sacola_produto
        foreign key (cd_produto)
            references produto(cd_produto)
);

create table if not exists clube (
	cd_clube int auto_increment,
	cd_carrinho int,
    nm_clube varchar(100),
    
    constraint pk_clube
		primary key (cd_clube),
        
	constraint fk_clube_carrinho
		foreign key (cd_carrinho)
			references carrinho(cd_carrinho)
);

create table if not exists clube_usuario (
	cd_clube int,
    cd_cliente int,
    qt_pontos decimal(45),
    
    constraint pk_clube_usuario
		primary key (cd_clube, cd_cliente),
        
	constraint fk_clube_usuario_clube
		foreign key (cd_clube)
			references clube (cd_clube),
            
	constraint fk_clube_usuario_cliente
		foreign key (cd_cliente)
			references cliente(cd_cliente)
);

create table if not exists avaliacao (
	cd_avali int auto_increment,
    cd_carrinho int,
    cd_cliente int,
    ds_avaliacao text(500),
    qt_estrelas decimal(5,1),
    
    constraint pk_avaliacao
		primary key (cd_avali),
        
	constraint fk_avaliacao_carrinho
		foreign key (cd_carrinho)
			references carrinho(cd_carrinho),
            
	constraint fk_avaliacao_cliente
		foreign key (cd_cliente)
			references cliente(cd_cliente)
);

insert into cliente (cd_cliente,nm_cliente,ds_emailC,nmr_telefoneC,ds_senhaC ) 
values 
    (1, 'João Silva', 'joao@example.com', '123456789',  'senha123'),
    (2, 'Maria Santos', 'maria@example.com', '987654321',  'senha456'),
    (3, 'Pedro Oliveira', 'pedro@example.com', '456123789',  'senha789'),
    (4, 'Ana Costa', 'ana@example.com', '789456123', 'senhaabc'),
    (5, 'Carlos Pereira', 'carlos@example.com', '321987654',  'senhadef'),
    (6, 'Luana Oliveira', 'luana@example.com', '654789123','senhaghi'),
    (7, 'Fernando Rodrigues', 'fernando@example.com', '147258369',  'senhajkl'),
    (8, 'Mariana Costa', 'mariana@example.com', '369147258',  'senha1234'),
    (9, 'Rafaela Silva', 'rafaela@example.com', '258369147',  'senha5678'),
    (10, 'Gabriel Santos', 'gabriel@example.com', '741852963',  'senha90ab'),
    (11, 'Larissa Oliveira', 'larissa@example.com', '963852741',  'senhabcde'),
    (12, 'Ricardo Pereira', 'ricardo@example.com', '852963147', 'senhafghi'),
    (13, 'Juliana Silva', 'juliana@example.com', '369852147', 'senhajklm'),
    (14, 'Felipe Costa', 'felipe@example.com', '147963852',  'senhano12'),
    (15, 'Aline Santos', 'aline@example.com', '852147963','senhapqrs'),
    (16, 'Gustavo Oliveira', 'gustavo@example.com', '963147852',  'senh1234t'),
    (17, 'Patricia Silva', 'patricia@example.com', '147852369', 'senha5678u'),
    (18, 'Rodrigo Costa', 'rodrigo@example.com', '852369147', 'senha90vw'),
    (19, 'Camila Santos', 'camila@example.com', '369147852', 'senha1234x'),
    (20, 'Lucas Pereira', 'lucas@example.com', '147852369', 'senha5678y');
    
select * from cliente;

insert into barraqueiro (cd_barraqueiro,nm_barraqueiro,ds_emailB,ds_senhaB,nmr_telefoneB) 
values 
    (21, 'Luciana Ferreira', 'luciana@example.com', 'senha123a', '21198765432'),
    (22, 'Renato Almeida', 'renato@example.com', 'senha456b', '22198765432'),
    (23, 'Paula Carvalho', 'paula@example.com', 'senha789c', '23198765432'),
    (24, 'Roberto Santos', 'roberto@example.com', 'senhaabcd', '24198765432'),
    (25, 'Beatriz Lima', 'beatriz@example.com', 'senhaefgh', '25198765432'),
    (26, 'Guilherme Souza', 'guilherme@example.com', 'senhaijkl', '26198765432'),
    (27, 'Carolina Nunes', 'carolina@example.com',  'senhamnop', '27198765432'),
    (28, 'Fábio Pereira', 'fabio@example.com',  'senhaqrst', '28198765432'),
    (29, 'Vanessa Oliveira', 'vanessa@example.com','senhauvwx', '29198765432'),
    (30, 'Marcos Silva', 'marcos@example.com',  'senhayzab', '30198765432'),
    (31, 'Letícia Rodrigues', 'leticia@example.com', 'senha12cd', '31198765432'),
    (32, 'Ronaldo Pereira', 'ronaldo@example.com', 'senha34ef', '32198765432'),
    (33, 'Tatiane Costa', 'tatiane@example.com',  'senha56gh', '33198765432'),
    (34, 'Vinícius Santos', 'vinicius@example.com',  'senha78ij', '34198765432'),
    (35, 'Fernanda Souza', 'fernanda@example.com', 'senha90kl', '35198765432'),
    (36, 'Felipe Almeida', 'felipea@example.com',  'senha12mn', '36198765432'),
    (37, 'Mariana Pereira', 'marianap@example.com', 'senha34pq', '37198765432'),
    (38, 'Rafael Lima', 'rafaell@example.com', 'senha56rs', '38198765432'),
    (39, 'Amanda Rodrigues', 'amanda@example.com', 'senha78tu', '39198765432'),
    (40, 'Leonardo Costa', 'leonardoc@example.com',  'senha90vw', '40198765432');

select * from barraqueiro;

insert into carrinho (cd_carrinho,cd_barraqueiro,nm_carrinho,ds_localizacao) 
values 
    (41, 21, 'Sabor na Praia', 'Avenida Beira Mar, próximo ao Quiosque 10'),
    (42, 22, 'Paraíso dos Sabores', 'Praça da Paz, ao lado do parquinho'),
    (43, 23, 'Tropical Gourmet', 'Rua das Palmeiras, em frente à quadra de vôlei de areia'),
    (44, 24, 'Maravilhas do Mar', 'Rua dos Coqueiros, próximo à barraca de coco gelado'),
    (45, 25, 'Sabores da Orla', 'Calçadão da Orla, próximo à ciclovia'),
    (46, 26, 'Delícias da Costa', 'Avenida Atlântica, próximo ao posto de salva-vidas'),
    (47, 27, 'Frescor Tropical', 'Praia Central, próximo ao acesso à praia para cadeirantes'),
    (48, 28, 'Sabor e Prazer', 'Rua das Gaivotas, próximo ao campo de futebol de areia'),
    (49, 29, 'Prazeres da Costa', 'Avenida das Palmeiras, próximo ao calçadão'),
    (50, 30, 'Maravilhas do Verão', 'Praça do Surf, em frente ao ponto de ônibus'),
    (51, 31, 'Sabor & Cia', 'Avenida das Palmeiras, próximo à pista de skate'),
    (52, 32, 'Sabor das Ondas', 'Calçadão da Orla, ao lado do quiosque de informações turísticas'),
    (53, 33, 'Tentação Praiana', 'Rua dos Coqueiros, em frente à escola de surf'),
    (54, 34, 'Prazeres da Estação', 'Avenida Beira Mar, próximo ao ponto de aluguel de bicicletas'),
    (55, 35, 'Sabores do Mar', 'Praça Central, ao lado da fonte luminosa'),
    (56, 36, 'Sabor do Verão', 'Rua das Gaivotas, próximo ao acesso à praia'),
    (57, 37, 'Paraíso Tropical', 'Avenida Atlântica, em frente ao quiosque de informações turísticas'),
    (58, 38, 'Delícias da Orla', 'Calçadão da Orla, próximo ao posto de guarda-vidas'),
    (59, 39, 'Prazeres do Verão', 'Avenida Beira Mar, próximo à pista de caminhada'),
    (60, 40, 'Mar e Sabor', 'Rua das Palmeiras, em frente à academia ao ar livre');

select * from carrinho;

insert into reserva (cd_reserva,cd_carrinho,cd_cliente,dt_reserva,hr_reserva,vl_reserva) values
    (61, 41, 11, '2024-01-10', '09:00', 150),
    (62, 42, 4, '2024-02-21', '10:30', 200),
    (63, 43, 7, '2024-03-21', '12:00', 180),
    (64, 44, 17, '2024-04-16', '14:30', 250),
    (65, 45, 8, '2024-01-18', '16:00', 300),
    (66, 46, 15, '2024-02-20', '17:30', 220),
    (67, 47, 10, '2024-03-22', '09:00', 180),
    (68, 48, 2, '2024-04-24', '10:30', 280),
    (69, 49, 6, '2024-01-26', '12:00', 240),
    (70, 50, 14, '2024-02-28', '14:30', 320),
    (71, 51, 1, '2024-03-14', '16:00', 200),
    (72, 52, 5, '2024-04-01', '17:30', 270),
    (73, 53, 19, '2024-01-03', '09:00', 230),
    (74, 54, 13, '2024-02-05', '10:30', 350),
    (75, 55, 9, '2024-03-07', '12:00', 180),
    (76, 56, 20, '2024-04-09', '14:30', 280),
    (77, 57, 16, '2024-01-11', '16:00', 240),
    (78, 58, 18, '2024-02-13', '17:30', 300),
    (79, 59, 12, '2024-03-15', '09:00', 220),
    (80, 60, 3, '2024-04-17', '10:30', 200),
    (81, 41, 1, '2024-01-10', '09:00', 180),
    (82, 48, 2, '2024-02-15', '10:30', 250),
    (83, 43, 3, '2024-03-12', '12:00', 300),
    (84, 44, 4, '2024-04-25', '14:30', 220),
    (85, 45, 5, '2024-01-27', '16:00', 200),
    (86, 46, 6, '2024-02-29', '17:30', 270),
    (87, 47, 7, '2024-03-01', '09:00', 230),
    (88, 48, 8, '2024-04-03', '10:30', 350),
    (89, 49, 9, '2024-01-05', '12:00', 180),
    (90, 50, 10, '2024-02-07', '14:30', 280),
    (91, 51, 11, '2024-03-09', '16:00', 240),
    (92, 52, 12, '2024-04-11', '17:30', 300),
    (93, 53, 13, '2024-01-13', '09:00', 220),
    (94, 54, 14, '2024-02-15', '10:30', 200),
    (95, 55, 15, '2024-03-17', '12:00', 180),
    (96, 56, 16, '2024-04-19', '14:30', 280),
    (97, 57, 17, '2024-01-21', '16:00', 240),
    (98, 58, 18, '2024-02-23', '17:30', 300),
    (99, 59, 19, '2024-03-25', '09:00', 220),
    (100, 60, 20, '2024-04-27', '10:30', 200),
    (101, 60, 20, '2024-04-25', '10:30', 210);


select * from reserva;

insert into cardapio (cd_cardapio, cd_carrinho) values
    (81, 41),
    (82, 42),
    (83, 43),
    (84, 44),
    (85, 45),
    (86, 46),
    (87, 47),
    (88, 48),
    (89, 49),
    (90, 50),
    (91, 51),
    (92, 52),
    (93, 53),
    (94, 54),
    (95, 55),
    (96, 56),
    (97, 57),
    (98, 58),
    (99, 59),
    (100, 60);

select * from cardapio;

insert into produto (cd_produto,nm_produto,vl_produto) values
(100,  'Picolé de Frutas Tropicais', 5.50),
(101, 'Espetinho de Queijo Coalho', 9.90),
(102,  'Camarão ao Alho e Óleo', 15.75),
(103,  'Suco de Abacaxi com Hortelã', 7.50),
(104,  'Casquinha de Siri', 12.90),
(105,  'Batata Frita com Cheddar e Bacon', 14.50),
(106,  'Coco Gelado',  6.50),
(107,  'Pastel de Camarão', 10.90),
(108,  'Açaí na Tigela',  12.75),
(109,  'Mousse de Maracujá', 8.90),
(110, 'Cerveja Artesanal',  11.50),
(111,  'Tapioca de Frango com Catupiry', 9.90),
(112,  'Ceviche de Peixe Branco',  17.90),
(113, 'Mojito de Maracujá', 14.50),
(114, 'Churrasco Misto', 35.90),
(115,  'Caipirinha de Limão',  12.75),
(116, 'Queijo Coalho Assado', 11.50),
(117, 'Brigadeiro de Colher', 6.90),
(118,  'Coxinha de Frango', 8.50),
(119,  'Caipiroska de Morango',12.85),
(120,  'Pastel de Queijo', 7.90);

select * from produto;

insert into pedido (cd_pedido,cd_carrinho,cd_cliente, vl_total_pedido, ds_guarda_sol) values 
(296, 41, 1, 250.75, 'G1'),
(297, 42, 2, 310.20, 'H2'),
(298, 43, 3, 180.45, 'I3'),
(317, 43, 2, 188.45, 'I8'),
(299, 44, 4, 420.90, 'J4'),
(300, 45, 5, 390.30, 'K5'),
(301, 46, 6, 285.60, 'L6'),
(302, 47, 7, 190.75, 'M7'),
(303, 48, 8, 135.90, 'N8'),
(304, 49, 9, 450.25, 'O9'),
(305, 50, 10, 310.40, 'P1'),
(306, 51, 11, 280.65, 'Q2'),
(307, 52, 12, 395.80, 'R3'),
(308, 53, 13, 210.35, 'S4'),
(309, 54, 14, 180.50, 'T5'),
(310, 55, 15, 485.25, 'U6'),
(311, 56, 16, 327.90, 'V7'),
(312, 57, 17, 402.60, 'W8'),
(313, 58, 18, 175.80, 'X9'),
(314, 59, 19, 278.45, 'Y1'),
(315, 60, 20, 370.70, 'Z2'),
(316, 60, 20, 582.51, 'N8');
    
select * from pedido;

insert into sacola (cd_pedido,cd_produto,quantidade) values
(296, 100, 10),
(297, 101, 15),
(298, 102, 8),
(299, 103, 20),
(300, 104, 12),
(301, 105, 18),
(302, 106, 25),
(303, 107, 30),
(304, 108, 5),
(305, 109, 22),
(306, 110, 17),
(307, 111, 11),
(308, 112, 14),
(309, 113, 9),
(310, 114, 16),
(311, 115, 21),
(312, 116, 7),
(313, 117, 19),
(314, 118, 26),
(315, 119, 13);

insert into clube (cd_clube,cd_carrinho,nm_clube) values 
(1, 41, 'Clube da Praia'),
(2, 42, 'Clube dos Sabores'),
(3, 43, 'Clube Tropical'),
(4, 44, 'Clube Maravilhoso'),
(5, 45, 'Clube da Orla'),
(6, 46, 'Clube do Verão'),
(7, 47, 'Clube do Frescor'),
(8, 48, 'Clube do Sabor'),
(9, 45, 'Clube dos Prazeres'),
(10, 50, 'Clube Veranil'),
(11, 51, 'Clube da Aventura'),
(12, 52, 'Clube das Ondas'),
(13, 53, 'Clube Praiano'),
(14, 54, 'Clube do Prazer'),
(15, 45, 'Clube Marítimo'),
(16, 56, 'Clube Refrescante'),
(17, 57, 'Clube da Beira Mar'),
(18, 58, 'Clube da Orla Tropical'),
(19, 59, 'Clube da Brisa'),
(20, 60, 'Clube do Mar');

insert into clube_usuario(cd_clube,cd_cliente,qt_pontos) values 
(1, 1, 100),
(2, 2, 150),
(3, 3, 80),
(3, 4, 200),
(5, 5, 120),
(3, 6, 90),
(3, 7, 180),
(3, 8, 220),
(9, 9, 70),
(10, 10, 160),
(11, 11, 110),
(3, 12, 240),
(13, 13, 130),
(14, 12, 85),
(15, 12, 190),
(16, 16, 60),
(17, 17, 170),
(18, 12, 105),
(19, 12, 210),
(20, 20, 140);

insert into avaliacao (cd_avali,cd_carrinho,cd_cliente,ds_avaliacao,qt_estrelas) values 
(1,41, 1, 'Ótima comida e ambiente maravilhoso!', 5.0),
(2,42, 2, 'Serviço rápido e comida deliciosa.', 4.5),
(3,43, 3, 'Localização perfeita e atendimento excelente.', 4.8),
(4,44, 4, 'Comida saborosa, mas o ambiente poderia ser mais limpo.', 4.0),
(5,42, 5, 'Adorei o ambiente e a vista!', 4.7),
(6,42, 6, 'Preço justo e porções generosas.', 4.3),
(7,47, 7, 'Comida fresca e atendimento cordial.', 4.9),
(8,48, 8, 'Ótimo lugar para relaxar e aproveitar a comida.', 4.6),
(9,42, 9, 'Ambiente agradável, mas a comida poderia ser mais variada.', 3.8),
(10,42, 10, 'Excelente experiência, voltarei com certeza!', 5.0),
(11,51, 11, 'Comida saborosa e atendimento atencioso.', 4.7),
(12,52, 12, 'Ambiente agradável e comida de qualidade.', 4.8),
(13,53, 13, 'Serviço impecável e pratos bem apresentados.', 4.9),
(14,54, 14, 'Preço justo e porções generosas.', 4.5),
(15,55, 15, 'Comida deliciosa e vista incrível.', 5.0),
(16,56, 16, 'Ótimo lugar para reunir amigos e familiares.', 4.3),
(17,57, 17, 'Atendimento rápido e eficiente.', 4.6),
(18,58, 18, 'Ambiente descontraído e comida fresca.', 4.4),
(19,59, 19, 'Cardápio variado e ambiente acolhedor.', 4.8),
(20,60, 20, 'Excelente experiência gastronômica.', 5.0);

