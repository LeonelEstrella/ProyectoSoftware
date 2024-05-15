using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccessData.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category",
                        column: x => x.Category,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleProduct",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleProduct", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Product_Product",
                        column: x => x.Product,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Sale_Sale",
                        column: x => x.Sale,
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electrodomésticos" },
                    { 2, "Tecnología y Electrónica" },
                    { 3, "Moda y Accesorios" },
                    { 4, "Hogar y Decoración" },
                    { 5, "Salud y Belleza" },
                    { 6, "Deportes y Ocio" },
                    { 7, "Juguetes y Juegos" },
                    { 8, "Alimentos y Bebidas" },
                    { 9, "Libros y Material Educativo" },
                    { 10, "Jardinería y Bricolaje" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0c498232-2c84-458d-a78c-807c9acc1f28"), 10, "Potencia: 80 W.", null, "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp", "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", 9888m },
                    { new Guid("1753bd4c-94d8-421d-95a8-ca5b236dea65"), 10, "Sustrato Growmix 80Lts Multipro.", 5, "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp", "GrowMix Profesional Multipro 80L", 19860m },
                    { new Guid("1822d79b-623e-49df-a075-5268800f8802"), 1, "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", 39, "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp", "Lavarropas automatico Drean Next 8.14 P ECO inverter blanco 8kg 220 V", 744292m },
                    { new Guid("22147730-8261-48c1-95a0-45535d3949cb"), 5, "KIT DE CUIDADO FACIAL COMPLETO.", null, "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp", "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo", 22999m },
                    { new Guid("2611fe25-31d0-4a63-b0bf-28b66fe169c2"), 5, "Contenido 7gr", null, "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp", "Corrector De Ojereas Artez Westerley Distr. Oficial", 7900m },
                    { new Guid("26f59a09-948e-4f9d-87d3-cbd7273c1d4c"), 2, "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh", null, "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp", "Cargador Movil Gadnic Con Lde Indicador De Batería 25000 Mah Color Negro", 41749m },
                    { new Guid("2783c4dc-d92d-43c4-ae2b-b54542a2627a"), 8, "Milka Chocolate Oreo Max X 300 Gr.", null, "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp", "Milka Chocolate Oreo Max X 300 Gr", 9999m },
                    { new Guid("2fe48b87-bb6d-462f-8ab7-5a23aeb32ef6"), 4, "TENDER DE PIE ACERO CON ALAS.", 15, "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp", "Tendedero Tender Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", 16341.18m },
                    { new Guid("33f75816-4d97-4b2b-8e00-d2891067be1e"), 4, "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", 5, "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp", "Cuadro Madera Calado Mdf 5 Hojas Moderno Living Decorativo Color Degrade", 13999m },
                    { new Guid("34c89214-3ceb-45d8-a707-1e739f01bd9d"), 9, "Expedicion Matematica 6 - Claudia Broitman.", 5, "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp", "Expedicion Matematica 6 - Claudia Broitman", 16700m },
                    { new Guid("3a9df8f1-bc21-4fe5-b8dc-14a73e6fa98e"), 9, "EL DUELO (BOLSILLO) - Gabriel Rolón.", 10, "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp", "El duelo - Gabriel Rolon - Booket", 16000m },
                    { new Guid("41f6b31a-6722-40d7-889e-b4dd1c743e9c"), 1, "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", 31, "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp", "Heladera Drean HDR400F11 steel con freezer 396L 220V", 1298199m },
                    { new Guid("428e5585-d6fa-4838-8db7-c2aeef9555a5"), 10, "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", null, "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp", "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", 12000m },
                    { new Guid("4488ba96-0b5b-4d8a-a216-0cc40a1f7157"), 4, "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", 67, "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp", "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", 29000m },
                    { new Guid("45bdcaf6-4129-4f98-b997-b6342da33d6c"), 5, "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", null, "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp", "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", 12516m },
                    { new Guid("47424c81-7394-42fb-89ba-55b74e2f67e1"), 7, "Cocina para nenas nenes chicos infantil madera.", 5, "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp", "Cocinita De Juguete Cocina Madera Infantil Juego Niños Niñas Color Marron", 34999m },
                    { new Guid("4928a734-cee8-4d05-bc97-ef1bd52a687f"), 10, "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", 36, "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp", "Desmalezadora A Explosion 52cc Potencia 1500w 2 Hp DESMA52CC", 127110m },
                    { new Guid("4d181baf-8306-4059-9c95-4f9f98928ec0"), 1, "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", 47, "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp", "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", 1209224m },
                    { new Guid("52eb43ce-8ad7-45f4-b7b8-4e7c3f1fe804"), 6, "Soga de saltar de acero Speed Rope.", 19, "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp", "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", 14998m },
                    { new Guid("6932bc98-986a-4254-9ba9-955841fba00e"), 3, "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", null, "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp", "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", 18400m },
                    { new Guid("745cebaa-bf67-41e8-a89d-08da101c1d1e"), 6, "Edad recomendada: de 8 años a 120 años.", null, "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp", "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", 20200m },
                    { new Guid("8312e850-b271-4f85-9a79-312876b3163b"), 8, "Pack de 6 latas de 354 mL cada una.", null, "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp", "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", 4381.82m },
                    { new Guid("838cd3e4-2464-4ed3-8949-daf18136f53a"), 9, "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", null, "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp", "La Felicidad - Gabriel Rolon - Planeta", 17990m },
                    { new Guid("86719fab-ae49-43d5-afba-71ea0f071a7b"), 5, "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", null, "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp", "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", 25814m },
                    { new Guid("8b489f2b-cb70-4a43-9402-884f2fdf8a34"), 9, "Libro Hábitos Atómicos - James Clear - Booket.", null, "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp", "Habitos Atomicos - James Clear - Booket", 14600m },
                    { new Guid("902c19dc-f776-49df-86db-5c07f1daa587"), 8, "Tableta Milka Chocolate Biscuit 300 gr", null, "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp", "Tableta Milka Chocolate Biscuit 300 gr", 9999m },
                    { new Guid("97d05cb5-25b2-4cf6-9412-2e1df51bf06c"), 2, "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", 11, "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp", "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", 269999m },
                    { new Guid("a8eb89a3-6ed5-4e8f-b20d-94ca83208702"), 6, "Adidas Argentum 19.", null, "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp", "Pelota adidas Argentum 19 Liga Argentina Balon Oficial", 140000m },
                    { new Guid("aff8795c-be0d-4dc0-8493-4b9e09807fde"), 3, "PULSERA DE ACERO QUIRURGICO 2 EN 1", null, "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp", "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", 2547.25m },
                    { new Guid("b5362955-c42a-4ec3-b2e6-bd3eb684f7ba"), 2, "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", null, "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp", "Nintendo Switch OLED 64GB Standard color rojo neon, azul neon y negro", 517999m },
                    { new Guid("b6853d7c-303d-4851-93f4-e39fd405ae9c"), 4, "Pileta Encastrable HARDEST Modelo HQ-113XT.", null, "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp", "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", 102999m },
                    { new Guid("bd6499a9-e022-4616-9980-7240c6f959ba"), 6, "GUANTE ATTRAKT SOLID.", null, "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp", "Guante Arquero Attrakt Solid Reusch Exclusivo", 43230m },
                    { new Guid("c51c2a6a-e7ed-4919-a934-6c40f721f189"), 8, "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", 5, "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp", "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", 9005.29m },
                    { new Guid("c547282e-8e21-41f7-abc9-51e3d95283c7"), 2, "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", 19, "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp", "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", 668249m },
                    { new Guid("d06500be-46ae-40ff-87d8-6b1ff39bb12b"), 1, "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", null, "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp", "Freidora Electrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", 124999m },
                    { new Guid("dc026789-b49e-44ac-9e64-e38d932fec39"), 7, "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", 31, "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp", "Helicoptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", 17990m },
                    { new Guid("ea01723c-97ff-4504-84c5-8185897c1dcd"), 7, "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", null, "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp", "Mario Odyssey Standard Edition Nintendo Switch Fisico", 79206m },
                    { new Guid("f0fd9a1c-8e98-4c1d-81aa-b37c8778f8cd"), 3, "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", 10, "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp", "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", 21899m },
                    { new Guid("f9f96714-1ef0-4ada-9e81-9765fa51877a"), 7, "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", null, "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp", "Mario Bros Wonder Nintendo Switch", 82999m },
                    { new Guid("fe774203-4177-4b6a-8b42-70ce3962ddc5"), 3, "Bolso Wilson 65.150005.", 11, "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp", "Bolso Wilson Deportivo Viaje Urbano Bolsillo Gimnasio Cierre Color Verde Liso", 39999m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category",
                table: "Product",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Product",
                table: "SaleProduct",
                column: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Sale",
                table: "SaleProduct",
                column: "Sale");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleProduct");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
