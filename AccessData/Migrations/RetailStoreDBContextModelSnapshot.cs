﻿// <auto-generated />
using System;
using AccessData.DataBaseInfraestructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccessData.Migrations
{
    [DbContext(typeof(RetailStoreDBContext))]
    partial class RetailStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Tecnología y Electrónica"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Moda y Accesorios"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Hogar y Decoración"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Salud y Belleza"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Deportes y Ocio"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Juguetes y Juegos"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Alimentos y Bebidas"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Libros y Material Educativo"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Jardinería y Bricolaje"
                        });
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("Category");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("41f6b31a-6722-40d7-889e-b4dd1c743e9c"),
                            Category = 1,
                            Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.",
                            Discount = 31,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp",
                            Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V",
                            Price = 1298199m
                        },
                        new
                        {
                            ProductId = new Guid("1822d79b-623e-49df-a075-5268800f8802"),
                            Category = 1,
                            Description = "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.",
                            Discount = 39,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp",
                            Name = "Lavarropas automatico Drean Next 8.14 P ECO inverter blanco 8kg 220 V",
                            Price = 744292m
                        },
                        new
                        {
                            ProductId = new Guid("4d181baf-8306-4059-9c95-4f9f98928ec0"),
                            Category = 1,
                            Description = "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.",
                            Discount = 47,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp",
                            Name = "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero",
                            Price = 1209224m
                        },
                        new
                        {
                            ProductId = new Guid("d06500be-46ae-40ff-87d8-6b1ff39bb12b"),
                            Category = 1,
                            Description = "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp",
                            Name = "Freidora Electrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro",
                            Price = 124999m
                        },
                        new
                        {
                            ProductId = new Guid("c547282e-8e21-41f7-abc9-51e3d95283c7"),
                            Category = 2,
                            Description = "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.",
                            Discount = 19,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp",
                            Name = "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v",
                            Price = 668249m
                        },
                        new
                        {
                            ProductId = new Guid("b5362955-c42a-4ec3-b2e6-bd3eb684f7ba"),
                            Category = 2,
                            Description = "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp",
                            Name = "Nintendo Switch OLED 64GB Standard color rojo neon, azul neon y negro",
                            Price = 517999m
                        },
                        new
                        {
                            ProductId = new Guid("26f59a09-948e-4f9d-87d3-cbd7273c1d4c"),
                            Category = 2,
                            Description = "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp",
                            Name = "Cargador Movil Gadnic Con Lde Indicador De Batería 25000 Mah Color Negro",
                            Price = 41749m
                        },
                        new
                        {
                            ProductId = new Guid("97d05cb5-25b2-4cf6-9412-2e1df51bf06c"),
                            Category = 2,
                            Description = "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.",
                            Discount = 11,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp",
                            Name = "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv",
                            Price = 269999m
                        },
                        new
                        {
                            ProductId = new Guid("aff8795c-be0d-4dc0-8493-4b9e09807fde"),
                            Category = 3,
                            Description = "PULSERA DE ACERO QUIRURGICO 2 EN 1",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp",
                            Name = "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack",
                            Price = 2547.25m
                        },
                        new
                        {
                            ProductId = new Guid("6932bc98-986a-4254-9ba9-955841fba00e"),
                            Category = 3,
                            Description = "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp",
                            Name = "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)",
                            Price = 18400m
                        },
                        new
                        {
                            ProductId = new Guid("f0fd9a1c-8e98-4c1d-81aa-b37c8778f8cd"),
                            Category = 3,
                            Description = "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.",
                            Discount = 10,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp",
                            Name = "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger",
                            Price = 21899m
                        },
                        new
                        {
                            ProductId = new Guid("fe774203-4177-4b6a-8b42-70ce3962ddc5"),
                            Category = 3,
                            Description = "Bolso Wilson 65.150005.",
                            Discount = 11,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp",
                            Name = "Bolso Wilson Deportivo Viaje Urbano Bolsillo Gimnasio Cierre Color Verde Liso",
                            Price = 39999m
                        },
                        new
                        {
                            ProductId = new Guid("b6853d7c-303d-4851-93f4-e39fd405ae9c"),
                            Category = 4,
                            Description = "Pileta Encastrable HARDEST Modelo HQ-113XT.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp",
                            Name = "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm",
                            Price = 102999m
                        },
                        new
                        {
                            ProductId = new Guid("2fe48b87-bb6d-462f-8ab7-5a23aeb32ef6"),
                            Category = 4,
                            Description = "TENDER DE PIE ACERO CON ALAS.",
                            Discount = 15,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp",
                            Name = "Tendedero Tender Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco",
                            Price = 16341.18m
                        },
                        new
                        {
                            ProductId = new Guid("33f75816-4d97-4b2b-8e00-d2891067be1e"),
                            Category = 4,
                            Description = "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.",
                            Discount = 5,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp",
                            Name = "Cuadro Madera Calado Mdf 5 Hojas Moderno Living Decorativo Color Degrade",
                            Price = 13999m
                        },
                        new
                        {
                            ProductId = new Guid("4488ba96-0b5b-4d8a-a216-0cc40a1f7157"),
                            Category = 4,
                            Description = "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.",
                            Discount = 67,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp",
                            Name = "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos",
                            Price = 29000m
                        },
                        new
                        {
                            ProductId = new Guid("86719fab-ae49-43d5-afba-71ea0f071a7b"),
                            Category = 5,
                            Description = "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp",
                            Name = "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml",
                            Price = 25814m
                        },
                        new
                        {
                            ProductId = new Guid("45bdcaf6-4129-4f98-b997-b6342da33d6c"),
                            Category = 5,
                            Description = "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp",
                            Name = "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente",
                            Price = 12516m
                        },
                        new
                        {
                            ProductId = new Guid("22147730-8261-48c1-95a0-45535d3949cb"),
                            Category = 5,
                            Description = "KIT DE CUIDADO FACIAL COMPLETO.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp",
                            Name = "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo",
                            Price = 22999m
                        },
                        new
                        {
                            ProductId = new Guid("2611fe25-31d0-4a63-b0bf-28b66fe169c2"),
                            Category = 5,
                            Description = "Contenido 7gr",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp",
                            Name = "Corrector De Ojereas Artez Westerley Distr. Oficial",
                            Price = 7900m
                        },
                        new
                        {
                            ProductId = new Guid("a8eb89a3-6ed5-4e8f-b20d-94ca83208702"),
                            Category = 6,
                            Description = "Adidas Argentum 19.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp",
                            Name = "Pelota adidas Argentum 19 Liga Argentina Balon Oficial",
                            Price = 140000m
                        },
                        new
                        {
                            ProductId = new Guid("bd6499a9-e022-4616-9980-7240c6f959ba"),
                            Category = 6,
                            Description = "GUANTE ATTRAKT SOLID.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp",
                            Name = "Guante Arquero Attrakt Solid Reusch Exclusivo",
                            Price = 43230m
                        },
                        new
                        {
                            ProductId = new Guid("745cebaa-bf67-41e8-a89d-08da101c1d1e"),
                            Category = 6,
                            Description = "Edad recomendada: de 8 años a 120 años.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp",
                            Name = "Destroza Este Diario Color - Keri Smith - Libro Del Fondo",
                            Price = 20200m
                        },
                        new
                        {
                            ProductId = new Guid("52eb43ce-8ad7-45f4-b7b8-4e7c3f1fe804"),
                            Category = 6,
                            Description = "Soga de saltar de acero Speed Rope.",
                            Discount = 19,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp",
                            Name = "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit",
                            Price = 14998m
                        },
                        new
                        {
                            ProductId = new Guid("dc026789-b49e-44ac-9e64-e38d932fec39"),
                            Category = 7,
                            Description = "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.",
                            Discount = 31,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp",
                            Name = "Helicoptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro",
                            Price = 17990m
                        },
                        new
                        {
                            ProductId = new Guid("47424c81-7394-42fb-89ba-55b74e2f67e1"),
                            Category = 7,
                            Description = "Cocina para nenas nenes chicos infantil madera.",
                            Discount = 5,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp",
                            Name = "Cocinita De Juguete Cocina Madera Infantil Juego Niños Niñas Color Marron",
                            Price = 34999m
                        },
                        new
                        {
                            ProductId = new Guid("f9f96714-1ef0-4ada-9e81-9765fa51877a"),
                            Category = 7,
                            Description = "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp",
                            Name = "Mario Bros Wonder Nintendo Switch",
                            Price = 82999m
                        },
                        new
                        {
                            ProductId = new Guid("ea01723c-97ff-4504-84c5-8185897c1dcd"),
                            Category = 7,
                            Description = "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp",
                            Name = "Mario Odyssey Standard Edition Nintendo Switch Fisico",
                            Price = 79206m
                        },
                        new
                        {
                            ProductId = new Guid("902c19dc-f776-49df-86db-5c07f1daa587"),
                            Category = 8,
                            Description = "Tableta Milka Chocolate Biscuit 300 gr",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp",
                            Name = "Tableta Milka Chocolate Biscuit 300 gr",
                            Price = 9999m
                        },
                        new
                        {
                            ProductId = new Guid("8312e850-b271-4f85-9a79-312876b3163b"),
                            Category = 8,
                            Description = "Pack de 6 latas de 354 mL cada una.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp",
                            Name = "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und",
                            Price = 4381.82m
                        },
                        new
                        {
                            ProductId = new Guid("c51c2a6a-e7ed-4919-a934-6c40f721f189"),
                            Category = 8,
                            Description = "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.",
                            Discount = 5,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp",
                            Name = "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas",
                            Price = 9005.29m
                        },
                        new
                        {
                            ProductId = new Guid("2783c4dc-d92d-43c4-ae2b-b54542a2627a"),
                            Category = 8,
                            Description = "Milka Chocolate Oreo Max X 300 Gr.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp",
                            Name = "Milka Chocolate Oreo Max X 300 Gr",
                            Price = 9999m
                        },
                        new
                        {
                            ProductId = new Guid("8b489f2b-cb70-4a43-9402-884f2fdf8a34"),
                            Category = 9,
                            Description = "Libro Hábitos Atómicos - James Clear - Booket.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp",
                            Name = "Habitos Atomicos - James Clear - Booket",
                            Price = 14600m
                        },
                        new
                        {
                            ProductId = new Guid("3a9df8f1-bc21-4fe5-b8dc-14a73e6fa98e"),
                            Category = 9,
                            Description = "EL DUELO (BOLSILLO) - Gabriel Rolón.",
                            Discount = 10,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp",
                            Name = "El duelo - Gabriel Rolon - Booket",
                            Price = 16000m
                        },
                        new
                        {
                            ProductId = new Guid("34c89214-3ceb-45d8-a707-1e739f01bd9d"),
                            Category = 9,
                            Description = "Expedicion Matematica 6 - Claudia Broitman.",
                            Discount = 5,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp",
                            Name = "Expedicion Matematica 6 - Claudia Broitman",
                            Price = 16700m
                        },
                        new
                        {
                            ProductId = new Guid("838cd3e4-2464-4ed3-8949-daf18136f53a"),
                            Category = 9,
                            Description = "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp",
                            Name = "La Felicidad - Gabriel Rolon - Planeta",
                            Price = 17990m
                        },
                        new
                        {
                            ProductId = new Guid("1753bd4c-94d8-421d-95a8-ca5b236dea65"),
                            Category = 10,
                            Description = "Sustrato Growmix 80Lts Multipro.",
                            Discount = 5,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp",
                            Name = "GrowMix Profesional Multipro 80L",
                            Price = 19860m
                        },
                        new
                        {
                            ProductId = new Guid("4928a734-cee8-4d05-bc97-ef1bd52a687f"),
                            Category = 10,
                            Description = "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.",
                            Discount = 36,
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp",
                            Name = "Desmalezadora A Explosion 52cc Potencia 1500w 2 Hp DESMA52CC",
                            Price = 127110m
                        },
                        new
                        {
                            ProductId = new Guid("0c498232-2c84-458d-a78c-807c9acc1f28"),
                            Category = 10,
                            Description = "Potencia: 80 W.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp",
                            Name = "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm",
                            Price = 9888m
                        },
                        new
                        {
                            ProductId = new Guid("428e5585-d6fa-4838-8db7-c2aeef9555a5"),
                            Category = 10,
                            Description = "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp",
                            Name = "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape",
                            Price = 12000m
                        });
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPay")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.SaleProduct", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartId"));

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Sale")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("Product");

                    b.HasIndex("Sale");

                    b.ToTable("SaleProduct");
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Product", b =>
                {
                    b.HasOne("AccessData.DataBaseInfraestructure.Entities.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.SaleProduct", b =>
                {
                    b.HasOne("AccessData.DataBaseInfraestructure.Entities.Product", "product")
                        .WithMany("SaleProduct")
                        .HasForeignKey("Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessData.DataBaseInfraestructure.Entities.Sale", "sale")
                        .WithMany("SaleProduct")
                        .HasForeignKey("Sale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("sale");
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Product", b =>
                {
                    b.Navigation("SaleProduct");
                });

            modelBuilder.Entity("AccessData.DataBaseInfraestructure.Entities.Sale", b =>
                {
                    b.Navigation("SaleProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
