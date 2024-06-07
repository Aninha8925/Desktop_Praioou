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
    cd_cardapio int,
    nm_produto varchar(45),
    ds_produto text(150),
    vl_produto float,
    ds_categoria enum('doce', 'salgado', 'bebida'),
    
    constraint pk_produto
		primary key (cd_produto),
        
	constraint fk_produto_cardapio
		foreign key (cd_cardapio)
			references cardapio(cd_cardapio)
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

insert into produto (cd_produto,cd_cardapio,nm_produto,ds_produto,vl_produto, ds_categoria) values
(100, 81, 'Picolé de Frutas Tropicais', 'Picolé cremoso feito com uma mistura de frutas tropicais, como manga, abacaxi e maracujá. Uma opção refrescante e deliciosa para se refrescar na praia.', 5.50, 'doce'),
(101, 81, 'Espetinho de Queijo Coalho', 'Queijo coalho cortado em cubos e espetado em palitos de bambu, grelhado na churrasqueira até ficar dourado por fora e macio por dentro. Servido com molho de melado ou geleia de pimenta.', 9.90, 'salgado'),
(102, 81, 'Camarão ao Alho e Óleo', 'Camarões frescos refogados no azeite com alho picado e pimenta vermelha, até ficarem macios e dourados. Uma opção simples e saborosa para os amantes de frutos do mar.', 15.75, 'salgado'),
(103, 81, 'Suco de Abacaxi com Hortelã', 'Suco natural de abacaxi batido com folhas frescas de hortelã, servido gelado. Uma bebida refrescante e revigorante, perfeita para se hidratar na praia.', 7.50, 'bebida'),
(104, 81, 'Casquinha de Siri', 'Casquinha de siri recheada com uma mistura de carne de siri desfiada, tomate, cebola, pimentão e temperos, coberta com queijo ralado e gratinada no forno até dourar.', 12.90, 'salgado'),
(105, 81, 'Batata Frita com Cheddar e Bacon', 'Batatas fritas crocantes cobertas com queijo cheddar derretido e pedaços de bacon crocante. Um petisco irresistível para acompanhar uma cerveja gelada.', 14.50, 'salgado'),
(106, 81, 'Coco Gelado', 'Coco verde cortado na hora, servido gelado com canudo para beber a água de coco natural. Uma opção refrescante e saudável para se hidratar na praia.', 6.50, 'doce'),
(107, 81, 'Pastel de Camarão', 'Pastel crocante recheado com uma mistura de camarão refogado com cebola, tomate, pimentão e temperos, envolto por uma massa fina e frita até dourar.', 10.90, 'salgado'),
(108, 81, 'Açaí na Tigela', 'Açaí batido com guaraná e servido em uma tigela, acompanhado de granola, banana, morango e mel. Uma opção energética e nutritiva para um lanche na praia.', 12.75, 'doce'),
(109, 81, 'Mousse de Maracujá', 'Mousse leve e aerado feito com suco de maracujá fresco, leite condensado e creme de leite, servido gelado. Uma sobremesa refrescante e deliciosa.', 8.90, 'doce'),
(110, 81, 'Cerveja Artesanal', 'Cerveja artesanal produzida localmente, com ingredientes selecionados e técnicas tradicionais de fabricação. Uma opção saborosa e exclusiva para os apreciadores de cerveja.', 11.50, 'bebida'),
(111, 82, 'Tapioca de Frango com Catupiry', 'Tapioca recheada com uma mistura de frango desfiado e cremoso catupiry, envolto por uma massa fina de tapioca e aquecido até derreter o queijo.', 9.90, 'salgado'),
(112, 82, 'Ceviche de Peixe Branco', 'Peixe branco fresco cortado em cubos e marinado em suco de limão, cebola roxa, pimenta, coentro e sal, servido com chips de batata-doce crocantes.', 17.90, 'salgado'),
(113, 82, 'Mojito de Maracujá', 'Coquetel refrescante feito com rum, suco de maracujá, folhas de hortelã, limão e água com gás, servido gelado com cubos de gelo. Uma bebida tropical e saborosa.', 14.50, 'bebida'),
(114, 82, 'Churrasco Misto', 'Seleção de carnes grelhadas na churrasqueira, incluindo picanha, linguiça, frango e coração de frango, servidas com farofa, vinagrete e pão de alho.', 35.90, 'salgado'),
(115, 82, 'Caipirinha de Limão', 'Coquetel brasileiro feito com cachaça, limão, açúcar e gelo, macerados e misturados em um copo baixo. Uma bebida clássica e refrescante para acompanhar petiscos.', 12.75, 'bebida'),
(116, 82, 'Queijo Coalho Assado', 'Fatias de queijo coalho grelhadas na churrasqueira até ficarem douradas por fora e macias por dentro, servidas com melado de cana ou geleia de pimenta.', 11.50, 'salgado'),
(117, 82, 'Brigadeiro de Colher', 'Brigadeiro tradicional de chocolate, feito com leite condensado, cacau em pó e manteiga, servido em copinhos individuais para comer de colher. Uma sobremesa clássica e deliciosa.', 6.90, 'doce'),
(118, 82, 'Coxinha de Frango', 'Coxinha de massa fina e crocante, recheada com uma mistura de frango desfiado, catupiry e temperos, modelada em formato de coxa e frita até dourar.', 8.50, 'salgado'),
(119, 82, 'Caipiroska de Morango', 'Coquetel refrescante feito com vodka, morangos frescos, açúcar, limão e gelo, misturados em um copo baixo. Uma opção frutada e saborosa para os amantes de morango.', 13.25, 'bebida'),
(120, 82, 'Pastel de Queijo', 'Pastel crocante recheado com uma mistura de queijos derretidos, envolto por uma massa fina e frita até dourar. Uma opção simples e saborosa para petiscar.', 7.90, 'salgado'),

(121, 83, 'Sanduíche de Carne de Sol', 'Sanduíche feito com carne de sol desfiada e refogada, servida em pão de forma ou pão francês, acompanhada de queijo coalho grelhado, vinagrete e maionese temperada.', 16.90, 'salgado'),
(122, 83, 'Creme de Açaí', 'Açaí batido com leite condensado e servido em um copo grande, coberto com granola, banana, leite em pó e leite condensado. Uma sobremesa energética e deliciosa.', 14.75, 'doce'),
(123, 83, 'Caipirinha de Maracujá', 'Coquetel refrescante feito com cachaça, suco de maracujá, açúcar e gelo, misturados em um copo baixo. Uma opção tropical e saborosa para relaxar e aproveitar o momento.', 12.50, 'bebida'),
(124, 83, 'Escondidinho de Carne Seca', 'Escondidinho feito com purê de mandioca, carne seca desfiada e refogada, coberto com queijo coalho gratinado. Uma opção reconfortante e saborosa para os amantes da culinária nordestina.', 18.50, 'salgado'),
(125, 83, 'Sorvete de Tapioca', 'Sorvete cremoso de tapioca, feito com leite condensado, creme de leite e tapioca granulada, servido gelado. Uma sobremesa única e irresistível para os apreciadores de tapioca.', 9.90, 'doce'),
(126, 83, 'Água de Coco', 'Água de coco natural servida em um coco verde, com canudo para beber. Uma opção refrescante e saudável para se hidratar durante o dia.', 4.50, 'bebida'),
(127, 83, 'Pastel de Carne', 'Pastel crocante recheado com uma mistura de carne moída refogada com cebola, tomate, pimentão e temperos, envolto por uma massa fina e frita até dourar.', 8.90, 'salgado'),
(128, 83, 'Coxinha de Camarão', 'Coxinha de massa fina e crocante, recheada com uma mistura de camarão refogado, catupiry e temperos, modelada em formato de coxa e frita até dourar.', 11.50, 'salgado'),
(129, 83, 'Café Gelado', 'Café preto forte batido com gelo e leite condensado, servido em copo alto com chantilly por cima. Uma bebida revigorante e doce para os amantes de café.', 8.75, 'bebida'),
(130, 83, 'Pudim de Leite', 'Pudim cremoso de leite condensado, leite integral e ovos, assado em banho-maria até ficar firme e dourado. Uma sobremesa clássica e reconfortante.', 7.50, 'doce'),

(131, 84, 'Sanduíche de Peito de Peru', 'Sanduíche feito com peito de peru fatiado, alface, tomate e maionese, servido em pão integral ou francês. Uma opção leve e saudável para uma refeição rápida.', 11.50, 'salgado'),
(132, 84, 'Salada de Frutas', 'Seleção de frutas frescas da estação cortadas em pedaços, como melancia, abacaxi, morango e manga, servidas em uma tigela e regadas com suco de laranja. Uma opção refrescante e nutritiva.', 9.90, 'doce'),
(133, 84, 'Chá Gelado de Pêssego', 'Chá de pêssego batido com gelo e servido em copo alto com fatias de pêssego e hortelã. Uma bebida refrescante e aromática para os dias quentes.', 6.75, 'bebida'),
(134, 84, 'Wrap de Frango e Vegetais', 'Wrap recheado com tiras de frango grelhado, alface, cenoura ralada, tomate e molho de iogurte, envolto por uma tortilha de trigo. Uma opção leve e saudável para uma refeição equilibrada.', 13.90, 'salgado'),
(135, 84, 'Mousse de Limão', 'Mousse leve e cremoso feito com suco de limão fresco, leite condensado e creme de leite, servido gelado. Uma sobremesa cítrica e refrescante.', 8.50, 'doce'),
(136, 84, 'Suco Detox', 'Suco natural feito com uma combinação de couve, maçã, pepino, gengibre e limão, batidos com água de coco. Uma bebida desintoxicante e revitalizante.', 10.25, 'bebida'),
(137, 84, 'Salada Caesar', 'Salada feita com alface romana, croutons, queijo parmesão ralado e molho Caesar, acompanhada de tiras de frango grelhado. Uma opção leve e saborosa para uma refeição equilibrada.', 14.75, 'salgado'),
(138, 84, 'Smoothie de Morango', 'Smoothie cremoso feito com morangos frescos, banana, iogurte natural e mel, batidos até ficarem homogêneos. Uma opção saudável e energética para um lanche rápido.', 7.90, 'doce'),
(139, 84, 'Iced Latte', 'Café espresso batido com gelo e leite, servido em copo alto com chantilly por cima. Uma bebida refrescante e energética para os amantes de café.', 9.25, 'bebida'),
(140, 84, 'Wrap Vegetariano', 'Wrap recheado com mix de vegetais grelhados, como abobrinha, berinjela, pimentão e cebola, acompanhados de queijo branco e molho pesto, envolto por uma tortilha de trigo. Uma opção leve e saudável para os vegetarianos.', 12.50, 'salgado'),

(141, 85, 'Sanduíche de Rosbife', 'Sanduíche feito com rosbife fatiado, rúcula, tomate e mostarda, servido em pão ciabatta ou baguete. Uma opção saborosa e substancial para uma refeição rápida.', 15.50, 'salgado'),
(142, 85, 'Torta de Maçã', 'Torta assada com uma generosa camada de maçãs fatiadas, canela, açúcar e suco de limão, coberta com massa crocante. Uma sobremesa clássica e reconfortante.', 10.90, 'doce'),
(143, 85, 'Café Espresso', 'Café preto forte feito com uma dose única de café moído finamente, extraído sob pressão. Uma bebida encorpada e aromática para os amantes de café.', 3.75, 'bebida'),
(144, 85, 'Cheesecake de Morango', 'Cheesecake cremoso feito com cream cheese, açúcar, ovos e essência de baunilha, coberto com geleia de morango e decorado com fatias da fruta. Uma sobremesa indulgente e irresistível.', 12.75, 'doce'),
(145, 85, 'Suco de Melancia', 'Suco natural de melancia batido com gelo, servido em copo alto com uma fatia da fruta para decorar. Uma bebida refrescante e hidratante para os dias quentes.', 7.50, 'bebida'),
(146, 85, 'Quiche Lorraine', 'Quiche assada com uma base de massa folhada, recheada com bacon, queijo gruyère, creme de leite, ovos e temperos, gratinada até dourar. Uma opção deliciosa e reconfortante para qualquer ocasião.', 13.90, 'salgado'),
(147, 85, 'Tiramisu', 'Sobremesa italiana feita com camadas de biscoitos embebidos em café e licor, intercaladas com creme de queijo mascarpone e cacau em pó. Uma sobremesa elegante e cheia de sabor.', 11.50, 'doce'),
(148, 85, 'Café com Leite', 'Café preto misturado com leite quente na proporção desejada, servido em uma xícara grande. Uma bebida reconfortante e equilibrada para qualquer momento do dia.', 4.25, 'bebida'),
(149, 85, 'Croissant de Chocolate', 'Croissant folhado recheado com pedaços de chocolate meio amargo, assado até ficar dourado e crocante por fora e macio por dentro. Um petisco indulgente e irresistível.', 9.90, 'doce'),
(150, 85, 'Cappuccino', 'Café espresso misturado com leite vaporizado e uma generosa camada de espuma de leite, polvilhado com cacau em pó ou canela. Uma bebida cremosa e reconfortante para os amantes de café.', 6.75, 'bebida'),

(151, 86, 'Sanduíche de Salame', 'Sanduíche feito com salame fatiado, queijo prato, alface, tomate e maionese, servido em pão de forma ou baguete. Uma opção clássica e saborosa para um lanche rápido.', 10.50, 'salgado'),
(152, 86, 'Pavê de Chocolate', 'Sobremesa montada em camadas alternadas de biscoitos tipo maisena e creme de chocolate, coberta com raspas de chocolate meio amargo. Uma sobremesa indulgente e irresistível para os amantes de chocolate.', 13.90, 'doce'),
(153, 86, 'Chá de Camomila', 'Infusão de flores de camomila em água quente, servida em uma xícara grande. Uma bebida suave e relaxante, ideal para ser apreciada antes de dormir.', 5.25, 'bebida'),
(154, 86, 'Mousse de Maracujá', 'Mousse leve e aerado feito com suco de maracujá fresco, leite condensado e creme de leite, servido gelado. Uma sobremesa refrescante e deliciosa.', 8.90, 'doce'),
(155, 86, 'Suco de Limão', 'Suco natural de limão batido com gelo, servido em copo alto com uma fatia da fruta para decorar. Uma bebida cítrica e refrescante, perfeita para dias quentes.', 6.50, 'bebida'),
(156, 86, 'Empadão de Frango', 'Empadão assado com uma massa crocante, recheado com uma mistura de frango desfiado, ervilhas, milho, cenoura e temperos, coberto com mais massa. Uma opção reconfortante e substancial para uma refeição completa.', 15.75, 'salgado'),
(157, 86, 'Panna Cotta', 'Sobremesa italiana feita com creme de leite, açúcar, gelatina e essência de baunilha, servida gelada com calda de frutas vermelhas. Uma sobremesa elegante e delicada.', 11.50, 'doce'),
(158, 86, 'Chocolate Quente', 'Leite quente misturado com chocolate meio amargo derretido, servido em uma xícara grande com chantilly por cima. Uma bebida cremosa e reconfortante para os dias frios.', 7.25, 'bebida'),
(159, 86, 'Croissant de Queijo', 'Croissant folhado recheado com queijo prato derretido, assado até ficar dourado e crocante por fora e macio por dentro. Um petisco irresistível para os amantes de queijo.', 8.90, 'salgado'),
(160, 86, 'Mocha', 'Café espresso misturado com chocolate em pó e leite vaporizado, servido em uma xícara grande com chantilly por cima. Uma bebida indulgente e energética para os amantes de café.', 8.75, 'bebida'),

(161, 87, 'Sanduíche de Presunto', 'Sanduíche feito com presunto fatiado, queijo muçarela, alface, tomate e maionese, servido em pão de forma ou baguete. Uma opção clássica e reconfortante para um lanche rápido.', 9.50, 'salgado'),
(162, 87, 'Torta de Limão', 'Torta montada com uma base de massa crocante, recheada com creme de limão feito com leite condensado e suco de limão, coberta com merengue italiano. Uma sobremesa cítrica e delicada.', 12.90, 'doce'),
(163, 87, 'Chá Verde Gelado', 'Chá verde batido com gelo e servido em copo alto com fatias de limão e hortelã. Uma bebida refrescante e revigorante para os apreciadores de chá verde.', 6.75, 'bebida'),
(164, 87, 'Tiramisu', 'Sobremesa italiana feita com camadas de biscoitos embebidos em café e licor, intercaladas com creme de queijo mascarpone e cacau em pó. Uma sobremesa elegante e cheia de sabor.', 11.50, 'doce'),
(165, 87, 'Suco de Laranja', 'Suco natural de laranja batido com gelo, servido em copo alto com uma fatia da fruta para decorar. Uma bebida clássica e refrescante para qualquer ocasião.', 5.50, 'bebida'),
(166, 87, 'Quiche de Alho-Poró', 'Quiche assada com uma base de massa folhada, recheada com alho-poró refogado, queijo gruyère, creme de leite, ovos e temperos, gratinada até dourar. Uma opção saborosa e reconfortante para uma refeição leve.', 14.90, 'salgado'),
(167, 87, 'Cheesecake de Frutas Vermelhas', 'Cheesecake cremoso feito com cream cheese, açúcar, ovos e essência de baunilha, coberto com uma mistura de frutas vermelhas em calda. Uma sobremesa indulgente e refrescante.', 13.75, 'doce'),
(168, 87, 'Café Americano', 'Café preto suave feito com uma dose única de café moído, extraído em água quente. Uma bebida simples e reconfortante para os amantes de café.', 3.50, 'bebida'),
(169, 87, 'Croissant de Amêndoas', 'Croissant folhado recheado com creme de amêndoas, assado até ficar dourado e crocante por fora e macio por dentro, e coberto com amêndoas laminadas. Um petisco elegante e irresistível.', 10.90, 'doce'),
(170, 87, 'Cappuccino', 'Café espresso misturado com leite vaporizado e uma generosa camada de espuma de leite, polvilhado com cacau em pó ou canela. Uma bebida cremosa e reconfortante para os amantes de café.', 6.75, 'bebida'),

(171, 88, 'Sanduíche de Atum', 'Sanduíche feito com atum sólido em conserva, maionese, alface, tomate e cebola, servido em pão de forma integral ou ciabatta. Uma opção leve e saudável para uma refeição rápida.', 9.90, 'salgado'),
(172, 88, 'Torta de Morango', 'Torta montada com uma base de massa crocante, recheada com creme de baunilha e morangos frescos, coberta com geléia de morango. Uma sobremesa clássica e deliciosa.', 12.50, 'doce'),
(173, 88, 'Chá de Frutas Vermelhas', 'Infusão de frutas vermelhas em água quente, servida em uma xícara grande. Uma bebida aromática e refrescante para os apreciadores de frutas vermelhas.', 6.25, 'bebida'),
(174, 88, 'Torta de Chocolate', 'Torta montada com uma base de massa crocante, recheada com creme de chocolate meio amargo, coberta com ganache de chocolate. Uma sobremesa indulgente e irresistível para os amantes de chocolate.', 11.90, 'doce'),
(175, 88, 'Suco de Manga', 'Suco natural de manga batido com gelo, servido em copo alto com uma fatia da fruta para decorar. Uma bebida tropical e refrescante para qualquer ocasião.', 6.75, 'bebida'),
(176, 88, 'Empadão de Camarão', 'Empadão assado com uma massa crocante, recheado com uma mistura de camarão refogado, catupiry, milho, ervilha e temperos, coberto com mais massa. Uma opção reconfortante e substancial para uma refeição completa.', 16.90, 'salgado'),
(177, 88, 'Cheesecake de Chocolate Branco', 'Cheesecake cremoso feito com cream cheese, açúcar, ovos e chocolate branco derretido, coberto com raspas de chocolate branco. Uma sobremesa luxuosa e delicada.', 14.75, 'doce'),
(178, 88, 'Café com Rum', 'Café preto forte misturado com rum, servido em uma xícara grande. Uma bebida quente e reconfortante para os apreciadores de café e rum.', 8.50, 'bebida'),
(179, 88, 'Croissant de Presunto e Queijo', 'Croissant folhado recheado com presunto, queijo prato e uma fina camada de requeijão, assado até ficar dourado e crocante por fora e macio por dentro. Um petisco clássico e delicioso.', 9.50, 'salgado'),
(180, 88, 'Mocaccino', 'Café espresso misturado com chocolate em pó, leite vaporizado e chantilly por cima, polvilhado com cacau em pó. Uma bebida indulgente e aromática para os amantes de café.', 7.25, 'bebida'),

(181, 89, 'Sanduíche de Frango Grelhado', 'Sanduíche feito com filé de frango grelhado, alface, tomate e maionese, servido em pão integral ou ciabatta. Uma opção saudável e deliciosa para uma refeição rápida.', 11.90, 'salgado'),
(182, 89, 'Torta de Limão', 'Torta montada com uma base de massa crocante, recheada com creme de limão feito com leite condensado e suco de limão, coberta com merengue italiano. Uma sobremesa cítrica e delicada.', 12.90, 'doce'),
(183, 89, 'Chá de Hortelã', 'Infusão de folhas de hortelã em água quente, servida em uma xícara grande. Uma bebida refrescante e digestiva, ideal para ser apreciada após as refeições.', 5.75, 'bebida'),
(184, 89, 'Torta de Banana', 'Torta montada com uma base de massa crocante, recheada com bananas fatiadas, açúcar, canela e suco de limão, coberta com uma camada de massa crocante. Uma sobremesa reconfortante e aromática.', 10.50, 'doce'),
(185, 89, 'Suco de Abacaxi', 'Suco natural de abacaxi batido com gelo, servido em copo alto com uma fatia da fruta para decorar. Uma bebida tropical e refrescante para qualquer ocasião.', 6.25, 'bebida'),
(186, 89, 'Empadão de Palmito', 'Empadão assado com uma massa crocante, recheado com uma mistura de palmito refogado, milho, ervilha, cebola, pimentão e temperos, coberto com mais massa. Uma opção vegetariana reconfortante e substancial.', 14.90, 'salgado'),
(187, 89, 'Cheesecake de Morango', 'Cheesecake cremoso feito com cream cheese, açúcar, ovos e essência de baunilha, coberto com uma mistura de frutas vermelhas em calda. Uma sobremesa indulgente e refrescante.', 13.75, 'doce'),
(188, 89, 'Café com Leite', 'Café preto misturado com leite quente na proporção desejada, servido em uma xícara grande. Uma bebida reconfortante e equilibrada para qualquer momento do dia.', 4.25, 'bebida'),
(189, 89, 'Croissant de Queijo', 'Croissant folhado recheado com queijo prato derretido, assado até ficar dourado e crocante por fora e macio por dentro. Um petisco irresistível para os amantes de queijo.', 8.90, 'salgado'),
(190, 89, 'Mocha', 'Café espresso misturado com chocolate em pó e leite vaporizado, servido em uma xícara grande com chantilly por cima. Uma bebida indulgente e energética para os amantes de café.', 8.75, 'bebida'),

(191, 90, 'Sanduíche de Peru e Queijo', 'Sanduíche feito com peito de peru fatiado, queijo prato, alface, tomate e maionese, servido em pão de forma ou baguete. Uma opção clássica e reconfortante para um lanche rápido.', 10.90, 'salgado'),
(192, 90, 'Torta de Morango', 'Torta montada com uma base de massa crocante, recheada com creme de baunilha e morangos frescos, coberta com geléia de morango. Uma sobremesa clássica e deliciosa.', 12.50, 'doce'),
(193, 90, 'Chá de Frutas Vermelhas', 'Infusão de frutas vermelhas em água quente, servida em uma xícara grande. Uma bebida aromática e refrescante para os apreciadores de frutas vermelhas.', 6.25, 'bebida'),
(194, 90, 'Torta de Chocolate', 'Torta montada com uma base de massa crocante, recheada com creme de chocolate meio amargo, coberta com ganache de chocolate. Uma sobremesa indulgente e irresistível para os amantes de chocolate.', 11.90, 'doce'),
(195, 90, 'Suco de Manga', 'Suco natural de manga batido com gelo, servido em copo alto com uma fatia da fruta para decorar. Uma bebida tropical e refrescante para qualquer ocasião.', 6.75, 'bebida'),
(196, 90, 'Empadão de Camarão', 'Empadão assado com uma massa crocante, recheado com uma mistura de camarão refogado, catupiry, milho, ervilha e temperos, coberto com mais massa. Uma opção reconfortante e substancial para uma refeição completa.', 16.90, 'salgado'),
(197, 90, 'Cheesecake de Chocolate Branco', 'Cheesecake cremoso feito com cream cheese, açúcar, ovos e chocolate branco derretido, coberto com raspas de chocolate branco. Uma sobremesa luxuosa e delicada.', 14.75, 'doce'),
(198, 90, 'Café com Rum', 'Café preto forte misturado com rum, servido em uma xícara grande. Uma bebida quente e reconfortante para os apreciadores de café e rum.', 8.50, 'bebida'),
(199, 90, 'Croissant de Presunto e Queijo', 'Croissant folhado recheado com presunto, queijo prato e uma fina camada de requeijão, assado até ficar dourado e crocante por fora e macio por dentro. Um petisco clássico e delicioso.', 9.50, 'salgado'),
(200, 90, 'Mocaccino', 'Café espresso misturado com chocolate em pó, leite vaporizado e chantilly por cima, polvilhado com cacau em pó. Uma bebida indulgente e aromática para os amantes de café.', 7.25, 'bebida'),

(201, 91, 'Sanduíche de Peixe', 'Pão fresco recheado com filé de peixe grelhado, alface, tomate e molho especial.', 25.00, 'salgado'),
(202, 91, 'Sorvete de Coco', 'Sorvete cremoso de coco, servido dentro do próprio coco verde.', 12.00, 'doce'),
(203, 91, 'Bolinho de Bacalhau', 'Bolinhos crocantes feitos com bacalhau desfiado, acompanhados de molho de pimenta.', 20.00, 'salgado'),
(204, 91, 'Salada Caesar', 'Salada fresca com alface, croutons, queijo parmesão e molho Caesar.', 18.00, 'salgado'),
(205, 91, 'Mojito', 'Coquetel refrescante de rum, hortelã, limão, açúcar e água com gás.', 22.00, 'bebida'),
(206, 91, 'Camarão à Baiana', 'Camarões salteados em azeite de dendê com leite de coco e pimentões.', 28.00, 'salgado'),
(207, 91, 'Cachorro-Quente Especial', 'Pão macio recheado com salsicha, queijo, milho, ervilha, maionese e ketchup.', 14.00, 'salgado'),
(208, 91, 'Batata Frita com Cheddar e Bacon', 'Batatas fritas crocantes cobertas com queijo cheddar derretido e pedaços de bacon.', 16.00, 'salgado'),
(209, 91, 'Smoothie de Manga', 'Smoothie gelado feito com manga fresca, iogurte natural e mel.', 10.00, 'bebida'),
(210, 91, 'Caipiroska de Kiwi', 'Caipiroska refrescante preparada com kiwi fresco e vodka.', 18.00, 'bebida'),

(211, 92, 'Cerveja Artesanal de Frutas Tropicais', 'Cerveja artesanal com adição de frutas tropicais, refrescante e saborosa.', 15.00, 'bebida'),
(212, 92, 'Tapioca de Frango com Catupiry', 'Tapioca recheada com frango desfiado e catupiry cremoso.', 14.00, 'salgado'),
(213, 92, 'Espetinho Misto', 'Espetinho com cubos de carne, frango, linguiça, pimentão e cebola.', 25.00, 'salgado'),
(214, 92, 'Camarão ao Alho e Óleo', 'Camarões salteados no alho e óleo, servidos com arroz branco e batata frita.', 28.00, 'salgado'),
(215, 92, 'Pastel de Carne', 'Pastel crocante recheado com carne moída temperada.', 12.00, 'salgado'),
(216, 92, 'Salada Caprese', 'Salada fresca com tomate, mussarela de búfala, manjericão e azeite de oliva.', 20.00, 'salgado'),
(217, 92, 'Mousse de Maracujá', 'Sobremesa refrescante feita com suco de maracujá, leite condensado e creme de leite.', 15.00, 'doce'),
(218, 92, 'Batata Rústica', 'Batatas cortadas em formato rústico e assadas com alecrim e alho.', 10.00, 'salgado'),
(219, 92, 'Caipirinha de Tangerina', 'Caipirinha refrescante preparada com tangerina fresca e cachaça.', 18.00, 'bebida'),
(220, 92, 'Pizza de Calabresa', 'Pizza de massa fina coberta com fatias de calabresa, cebola, tomate e queijo.', 30.00, 'salgado'),

(221, 93, 'Pão de Alho', 'Pão francês recheado com pasta de alho e assado na brasa.', 8.00, 'salgado'),
(222, 93, 'Casquinha de Lagosta', 'Casquinha de lagosta gratinada com queijo parmesão e ervas finas.', 40.00, 'salgado'),
(223, 93, 'Ceviche de Camarão', 'Camarões frescos marinados em suco de limão, cebola roxa, pimenta e coentro.', 35.00, 'salgado'),
(224, 93, 'Salada de Frutos do Mar', 'Salada fresca com frutos do mar variados, alface, tomate e molho de limão.', 38.00, 'salgado'),
(225, 93, 'Tapioca de Nutella com Morango', 'Tapioca recheada com Nutella cremosa e morangos frescos.', 14.00, 'doce'),
(226, 93, 'Mousse de Limão', 'Sobremesa cítrica e refrescante, feita com suco de limão e leite condensado.', 18.00, 'doce'),
(227, 93, 'Caipirinha de Maracujá', 'Caipirinha refrescante preparada com maracujá fresco e cachaça.', 18.00, 'bebida'),
(228, 93, 'Água de Coco Gelada', 'Água de coco fresca e gelada, ideal para se hidratar na praia.', 7.00, 'bebida'),
(229, 93, 'Crepe de Queijo e Presunto', 'Crepe quentinho recheado com queijo derretido e presunto.', 12.00, 'salgado'),
(230, 93, 'Tapioca de Chocolate com Banana', 'Tapioca recheada com chocolate derretido e fatias de banana.', 12.00, 'doce'),

(231, 94, 'Sanduíche de Peixe Frito', 'Pão fresco recheado com filé de peixe frito crocante, alface, tomate e maionese.', 22.00, 'salgado'),
(232, 94, 'Sorvete de Frutas Vermelhas', 'Sorvete cremoso com uma variedade de frutas vermelhas frescas.', 10.00, 'doce'),
(233, 94, 'Camarão Empanado', 'Camarões grandes empanados e fritos, acompanhados de molho tártaro.', 28.00, 'salgado'),
(234, 94, 'Salada de Rúcula com Tomate Seco', 'Salada fresca com rúcula, tomate seco, queijo parmesão e molho balsâmico.', 16.00, 'salgado'),
(235, 94, 'Milkshake de Morango', 'Milkshake cremoso feito com sorvete de morango e leite.', 12.00, 'doce'),
(236, 94, 'Espetinho de Carne', 'Espetinho de carne bovina grelhada com cebola e pimentão.', 20.00, 'salgado'),
(237, 94, 'Água de Coco Natural', 'Água de coco fresca e natural, diretamente do coco verde.', 8.00, 'bebida'),
(238, 94, 'Crepe de Nutella com Banana', 'Crepe quentinho recheado com Nutella e fatias de banana.', 14.00, 'doce'),
(239, 94, 'Mousse de Maracujá com Chocolate', 'Sobremesa deliciosa feita com camadas de mousse de maracujá e chocolate.', 18.00, 'doce'),
(240, 94, 'Caipirinha de Limão', 'Caipirinha clássica preparada com limão fresco e cachaça.', 16.00, 'bebida'),

(241, 95, 'Pastel de Queijo e Presunto', 'Pastel crocante recheado com queijo derretido e presunto.', 12.00, 'salgado'),
(242, 95, 'Cerveja Gelada', 'Cerveja gelada para refrescar e acompanhar o clima de praia.', 10.00, 'bebida'),
(243, 95, 'Escondidinho de Carne Seca', 'Escondidinho cremoso feito com purê de mandioca e carne seca desfiada.', 30.00, 'salgado'),
(244, 95, 'Coxinha de Frango', 'Coxinhas crocantes recheadas com frango desfiado e temperado.', 14.00, 'salgado'),
(245, 95, 'Salada de Camarão', 'Salada fresca com camarões cozidos, alface, tomate e molho de limão.', 30.00, 'salgado'),
(246, 95, 'Crepe de Queijo e Presunto', 'Crepe quentinho recheado com queijo derretido e presunto.', 12.00, 'salgado'),
(247, 95, 'Açaí na Tigela', 'Açaí cremoso servido com granola, banana e mel. Energia pura para o seu dia.', 20.00, 'doce'),
(248, 95, 'Caipirinha de Maracujá', 'Caipirinha refrescante preparada com maracujá fresco e cachaça.', 18.00, 'bebida'),
(249, 95, 'Batata Frita com Cheddar e Bacon', 'Batatas fritas crocantes cobertas com queijo cheddar derretido e pedaços de bacon.', 16.00, 'salgado'),
(250, 95, 'Smoothie de Abacaxi com Hortelã', 'Smoothie gelado feito com abacaxi fresco, hortelã e iogurte natural.', 14.00, 'bebida'),

(251, 96, 'Barraca de Açaí', 'Açaí cremoso servido na tigela com granola, banana, leite condensado e mel.', 20.00, 'doce'),
(252, 96, 'Petisco de Polvo', 'Fatias de polvo grelhado com azeite, alho e pimenta, acompanhadas de pão.', 25.00, 'salgado'),
(253, 96, 'Cerveja Gelada', 'Cerveja gelada para refrescar e acompanhar o clima de praia.', 10.00, 'bebida'),
(254, 96, 'Pão de Queijo Recheado', 'Pão de queijo recheado com queijo mussarela derretido.', 8.00, 'salgado'),
(255, 96, 'Salada de Kani', 'Salada refrescante com kani-kama, pepino, manga, alface e molho de gengibre.', 18.00, 'salgado'),
(256, 96, 'Pastel de Queijo', 'Pastel crocante recheado com queijo derretido e temperado.', 12.00, 'salgado'),
(257, 96, 'Tábua de Frios', 'Seleção de queijos e frios servidos com torradas e geleia de pimenta.', 35.00, 'salgado'),
(258, 96, 'Coco Gelado com Rum', 'Coco gelado servido com uma dose de rum, para um toque tropical.', 15.00, 'bebida'),
(259, 96, 'Churrasco de Peixe', 'Espetinhos de peixe grelhado com legumes, servidos com molho de pimenta.', 32.00, 'salgado'),
(260, 96, 'Batida de Maracujá', 'Bebida cremosa preparada com suco de maracujá, leite condensado e cachaça.', 18.00, 'bebida'),

(261, 97, 'Pizza de Calabresa', 'Pizza de massa fina coberta com fatias de calabresa, cebola, tomate e queijo.', 30.00, 'salgado'),
(262, 97, 'Pão de Alho', 'Pão francês recheado com pasta de alho e assado na brasa.', 8.00, 'salgado'),
(263, 97, 'Casquinha de Lagosta', 'Casquinha de lagosta gratinada com queijo parmesão e ervas finas.', 40.00, 'salgado'),
(264, 97, 'Ceviche de Camarão', 'Camarões frescos marinados em suco de limão, cebola roxa, pimenta e coentro.', 35.00, 'salgado'),
(265, 97, 'Salada de Frutos do Mar', 'Salada fresca com frutos do mar variados, alface, tomate e molho de limão.', 38.00, 'salgado'),
(266, 97, 'Tapioca de Nutella com Morango', 'Tapioca recheada com Nutella cremosa e morangos frescos.', 14.00, 'doce'),
(267, 97, 'Mousse de Limão', 'Sobremesa cítrica e refrescante, feita com suco de limão e leite condensado.', 18.00, 'doce'),
(268, 97, 'Caipirinha de Maracujá', 'Caipirinha refrescante preparada com maracujá fresco e cachaça.', 18.00, 'bebida'),
(269, 97, 'Água de Coco Gelada', 'Água de coco fresca e gelada, ideal para se hidratar na praia.', 7.00, 'bebida'),
(270, 97, 'Crepe de Queijo e Presunto', 'Crepe quentinho recheado com queijo derretido e presunto.', 12.00, 'salgado'),

(271, 98, 'Tapioca de Frango com Catupiry', 'Tapioca recheada com frango desfiado e catupiry cremoso.', 14.00, 'salgado'),
(272, 98, 'Espetinho Misto', 'Espetinho com cubos de carne, frango, linguiça, pimentão e cebola.', 25.00, 'salgado'),
(273, 98, 'Camarão ao Alho e Óleo', 'Camarões salteados no alho e óleo, servidos com arroz branco e batata frita.', 28.00, 'salgado'),
(274, 98, 'Pastel de Carne', 'Pastel crocante recheado com carne moída temperada.', 12.00, 'salgado'),
(275, 98, 'Salada Caprese', 'Salada fresca com tomate, mussarela de búfala, manjericão e azeite de oliva.', 20.00, 'salgado'),
(276, 98, 'Mousse de Maracujá', 'Sobremesa refrescante feita com suco de maracujá, leite condensado e creme de leite.', 15.00, 'doce'),
(277, 98, 'Batata Rústica', 'Batatas cortadas em formato rústico e assadas com alecrim e alho.', 10.00, 'salgado'),
(278, 98, 'Caipirinha de Tangerina', 'Caipirinha refrescante preparada com tangerina fresca e cachaça.', 18.00, 'bebida'),
(279, 98, 'Cerveja Artesanal de Frutas', 'Cerveja artesanal com adição de frutas tropicais, leve e refrescante.', 12.00, 'bebida'),
(280, 98, 'Tapioca de Chocolate com Banana', 'Tapioca recheada com chocolate derretido e fatias de banana.', 12.00, 'doce'),

(281, 99, 'Sanduíche de Peixe', 'Pão fresco recheado com filé de peixe grelhado, alface, tomate e molho especial.', 25.00, 'salgado'),
(282, 99, 'Sorvete de Coco', 'Sorvete cremoso de coco, servido dentro do próprio coco verde.', 12.00, 'doce'),
(283, 99, 'Bolinho de Bacalhau', 'Bolinhos crocantes feitos com bacalhau desfiado, acompanhados de molho de pimenta.', 20.00, 'salgado'),
(284, 99, 'Salada Caesar', 'Salada fresca com alface, croutons, queijo parmesão e molho Caesar.', 18.00, 'salgado'),
(285, 99, 'Mojito', 'Coquetel refrescante de rum, hortelã, limão, açúcar e água com gás.', 22.00, 'bebida'),
(286, 99, 'Camarão à Baiana', 'Camarões salteados em azeite de dendê com leite de coco e pimentões.', 28.00, 'salgado'),
(287, 99, 'Cachorro-Quente Especial', 'Pão macio recheado com salsicha, queijo, milho, ervilha, maionese e ketchup.', 14.00, 'salgado'),
(288, 99, 'Batata Frita com Cheddar e Bacon', 'Batatas fritas crocantes cobertas com queijo cheddar derretido e pedaços de bacon.', 16.00, 'salgado'),
(289, 99, 'Smoothie de Manga', 'Smoothie gelado feito com manga fresca, iogurte natural e mel.', 10.00, 'doce'),
(290, 99, 'Caipiroska de Kiwi', 'Caipiroska refrescante preparada com kiwi fresco e vodka.', 18.00, 'bebida'),

(291, 100, 'Cerveja Artesanal de Frutas Tropicais', 'Cerveja artesanal com adição de frutas tropicais, refrescante e saborosa.', 15.00, 'bebida'),
(292, 100, 'Tapioca de Frango com Catupiry', 'Tapioca recheada com frango desfiado e catupiry cremoso.', 14.00, 'salgado'),
(293, 100, 'Espetinho Misto', 'Espetinho com cubos de carne, frango, linguiça, pimentão e cebola.', 25.00, 'salgado'),
(294, 100, 'Camarão ao Alho e Óleo', 'Camarões salteados no alho e óleo, servidos com arroz branco e batata frita.', 28.00, 'salgado'),
(295, 100, 'Pastel de Carne', 'Pastel crocante recheado com carne moída temperada.', 12.00, 'salgado'),
(296, 100, 'Salada Caprese', 'Salada fresca com tomate, mussarela de búfala, manjericão e azeite de oliva.', 20.00, 'salgado');


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

