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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    TotalPay = table.Column<double>(type: "float", nullable: false),
                    Subtotal = table.Column<double>(type: "float", nullable: false),
                    TotalDiscount = table.Column<double>(type: "float", nullable: false),
                    Taxes = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleProduct",
                columns: table => new
                {
                    SaleProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SaleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleProduct", x => x.SaleProductId);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_SaleProduct_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "SaleId");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electrodomésticos" },
                    { 2, "Tecnología_y_Electrónica" },
                    { 3, "Moda_y_Accesorios" },
                    { 4, "Hogar_y_Decoración" },
                    { 5, "Salud_y_Belleza" },
                    { 6, "Deportes_y_Ocio" },
                    { 7, "Juguetes_y_Juegos" },
                    { 8, "Alimentos_y_Bebidas" },
                    { 9, "Libros_y_Material_Educativo" },
                    { 10, "Jardinería_y_Bricolaje" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "Discount", "ImageLink", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02ea5f68-7447-4f82-9e95-71c7ff599a79"), 8, "Milka Chocolate Oreo Max X 300 Gr.", 0, "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp", "Milka Chocolate Oreo Max X 300 Gr", 9999.0 },
                    { new Guid("07873ccd-cd9d-44ba-bfd6-e7820f77934b"), 10, "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", 36, "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp", "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC", 127110.0 },
                    { new Guid("15dfe65c-a6d1-45cd-bfad-a0be3bab744d"), 2, "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh", 0, "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp", "Cargador Móvil Gadnic Con Lde Indicador De Batería 25000 Mah Color Negro", 41749.0 },
                    { new Guid("16aea213-3ad5-4492-8fa0-4e35c0412aae"), 2, "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", 19, "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp", "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", 668249.0 },
                    { new Guid("1c495a84-16a1-44c1-900f-577e2d71ec19"), 4, "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", 67, "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp", "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", 29000.0 },
                    { new Guid("1dda1723-9de7-48f6-b23d-838dcfac54b4"), 6, "Soga de saltar de acero Speed Rope.", 19, "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp", "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", 14998.0 },
                    { new Guid("21b26a31-b6ac-496e-8565-55cb0f460ea2"), 3, "PULSERA DE ACERO QUIRURGICO 2 EN 1", 0, "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp", "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", 2547.25 },
                    { new Guid("286fbfd9-7d16-4903-97f7-b73bcd87379e"), 4, "TENDER DE PIE ACERO CON ALAS.", 15, "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp", "Tendedero Tender Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", 16341.18 },
                    { new Guid("2cb8f01c-ba1a-4ac9-b797-c9ae0e14c3c0"), 5, "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", 0, "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp", "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", 12516.0 },
                    { new Guid("352bb741-3ac5-43cb-a4f7-9ed21573cacb"), 8, "Tableta Milka Chocolate Biscuit 300 gr", 0, "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp", "Tableta Milka Chocolate Biscuit 300 gr", 9999.0 },
                    { new Guid("36787699-e2c3-4419-af68-3e894c4bf5fe"), 7, "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", 0, "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp", "Super Mario Bros Wonder Nintendo Switch", 82999.0 },
                    { new Guid("3f807af9-b6ba-4024-b9f3-3784d1774a61"), 6, "GUANTE ATTRAKT SOLID.", 0, "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp", "Guante Arquero Attrakt Solid Reusch Exclusivo", 43230.0 },
                    { new Guid("4b76d73e-f552-4370-abbe-e65611f3e276"), 8, "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", 5, "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp", "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", 9005.2900000000009 },
                    { new Guid("4d1be1eb-217e-446c-b26e-4a4096df4fde"), 3, "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", 0, "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp", "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", 18400.0 },
                    { new Guid("4d364cea-d59c-40c0-91a7-7476079be165"), 1, "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", 0, "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp", "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", 124999.0 },
                    { new Guid("4e900100-5f2d-435b-8ef4-ae0e72b4cf15"), 3, "Bolso Wilson 65.150005.", 11, "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp", "Bolso Wilson Deportivo Viaje Urbano Bolsillo Gimnasio Cierre Color Verde Liso", 39999.0 },
                    { new Guid("5869b8eb-6c53-42a3-a735-66915e7cc38c"), 1, "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", 31, "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp", "Heladera Drean HDR400F11 steel con freezer 396L 220V", 1298199.0 },
                    { new Guid("5a22739e-bc9d-463f-bf04-481be0dd0153"), 6, "Edad recomendada: de 8 años a 120 años.", 0, "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp", "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", 20200.0 },
                    { new Guid("5a3626e0-ce65-4260-9aee-cc6be6348731"), 8, "Pack de 6 latas de 354 mL cada una.", 0, "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp", "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", 4381.8199999999997 },
                    { new Guid("609ed0c8-7991-4fe2-b24a-cfc26365b85a"), 1, "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", 39, "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp", "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", 744292.0 },
                    { new Guid("66ac8bdd-fc2b-4c86-9b7d-bf2f783d5718"), 5, "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", 0, "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp", "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", 25814.0 },
                    { new Guid("6dcc9a4f-d77f-4c96-97da-4f07f5c7b213"), 4, "Pileta Encastrable HARDEST Modelo HQ-113XT.", 0, "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp", "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", 102999.0 },
                    { new Guid("8a4d3fa1-4d94-486c-92f7-84a89ae01828"), 10, "Potencia: 80 W.", 0, "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp", "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", 9888.0 },
                    { new Guid("8a7e845c-abba-46fc-86fd-2154006ce870"), 10, "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", 0, "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp", "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", 12000.0 },
                    { new Guid("8fbe09f3-2a5c-4eb9-9b98-48eb5d2a756a"), 5, "KIT DE CUIDADO FACIAL COMPLETO.", 0, "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp", "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo", 22999.0 },
                    { new Guid("9ab3a578-fd9a-4eb2-91ae-215c0fe40e2a"), 2, "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", 11, "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp", "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", 269999.0 },
                    { new Guid("9bab107b-466a-4b91-aa3b-65e651f146d3"), 9, "Libro Hábitos Atómicos - James Clear - Booket.", 0, "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp", "Libro Hábitos Atómicos - James Clear - Booket", 14600.0 },
                    { new Guid("a45420fe-e730-4719-a9e1-baf99d74c2b7"), 9, "Expedicion Matematica 6 - Claudia Broitman.", 5, "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp", "Expedicion Matematica 6 - Claudia Broitman", 16700.0 },
                    { new Guid("a5634beb-ef9f-41c3-86c0-6afc5e1f6001"), 2, "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", 0, "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp", "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro", 517999.0 },
                    { new Guid("aac4f663-6e35-4f5b-86e0-8fd917bdcb59"), 9, "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", 0, "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp", "Libro La Felicidad - Gabriel Rolón - Planeta", 17990.0 },
                    { new Guid("b380e200-50b6-4c7d-b7fd-7c1e1c90eca8"), 7, "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", 316, "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp", "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", 17990.0 },
                    { new Guid("bbc52e75-abdf-4356-b52c-17ee21eab794"), 1, "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", 47, "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp", "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", 1209224.0 },
                    { new Guid("bedb4273-6e79-415d-b183-265f3d6dc810"), 9, "EL DUELO (BOLSILLO) - Gabriel Rolón.", 10, "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp", "Libro El duelo - Gabriel Rolón - Booket", 16000.0 },
                    { new Guid("c68c8cfc-eabf-435b-9848-5f6754db0a9c"), 4, "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", 5, "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp", "Cuadro Madera Calado Mdf 5 Hojas Moderno Living Decorativo Color Degrade", 13999.0 },
                    { new Guid("e2976a51-0e0b-4aa4-b922-54ed2f82716c"), 3, "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", 10, "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp", "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", 21899.0 },
                    { new Guid("e5ac047a-208c-4583-b7a2-591f6c2f198e"), 5, "Contenido 7gr", 0, "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp", "Corrector De Ojereas Artez Westerley Distr. Oficial", 7900.0 },
                    { new Guid("e983be48-6c19-497a-a57a-a8627eddc453"), 7, "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", 0, "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp", "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch Físico", 79206.0 },
                    { new Guid("eb8fcb1d-4291-4c3f-8570-389a7fa0cda1"), 6, "Adidas Argentum 19.", 0, "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp", "Pelota adidas Argentum 19 Liga Argentina Balón Oficial", 140000.0 },
                    { new Guid("f539aa2f-4070-49b7-967f-561080109616"), 7, "Cocina para nenas nenes chicos infantil madera.", 5, "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp", "Cocinita De Juguete Cocina Madera Infantil Juego Niños Niñas Color Marrón", 34999.0 },
                    { new Guid("fa4fbdf2-94cd-44bc-8b33-3ac21028615f"), 10, "Sustrato Growmix 80Lts Multipro.", 5, "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp", "GrowMix Profesional Multipro 80L", 19860.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_ProductId",
                table: "SaleProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_SaleId",
                table: "SaleProduct",
                column: "SaleId");
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
