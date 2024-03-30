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
                    TotalPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    { new Guid("0311a27b-6c6d-4996-a837-c1327b990290"), 3, "Bolso Wilson 65.150005.", 11, "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp", "Bolso Wilson Deportivo Viaje Urbano Bolsillo Gimnasio Cierre Color Verde Liso", 39999m },
                    { new Guid("03a6bdbd-0c21-4ec2-b85c-fcfd68d26d76"), 7, "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", 316, "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp", "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", 17990m },
                    { new Guid("0ff9edc6-cbdc-4655-a415-de24f330ecda"), 5, "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", 0, "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp", "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", 25814m },
                    { new Guid("18b62f20-a0ad-48b2-a606-46298e5f7bc6"), 4, "TENDER DE PIE ACERO CON ALAS.", 15, "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp", "Tendedero Tender Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", 16341.18m },
                    { new Guid("2e8ff07c-6691-42ad-8f35-8d684faa3c9a"), 10, "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", 36, "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp", "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC", 127110m },
                    { new Guid("39c069a3-6541-4e49-bb82-3e27ec2b3f0b"), 3, "PULSERA DE ACERO QUIRURGICO 2 EN 1", 0, "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp", "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", 2547.25m },
                    { new Guid("4837add2-726f-491e-9368-2d9f9d651f37"), 2, "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh", 0, "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp", "Cargador Móvil Gadnic Con Lde Indicador De Batería 25000 Mah Color Negro", 41749m },
                    { new Guid("4917e023-a4af-4f41-8b8e-57286a104e90"), 8, "Pack de 6 latas de 354 mL cada una.", 0, "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp", "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", 4381.82m },
                    { new Guid("4c79e358-41a7-464d-851b-4fa1bec662e3"), 1, "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", 0, "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp", "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", 124999m },
                    { new Guid("5b26bd92-23a1-44e9-830c-80fd44b5bcc8"), 1, "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", 39, "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp", "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", 744292m },
                    { new Guid("5b477a98-b5dd-46da-8988-b264ab4cb074"), 7, "Cocina para nenas nenes chicos infantil madera.", 5, "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp", "Cocinita De Juguete Cocina Madera Infantil Juego Niños Niñas Color Marrón", 34999m },
                    { new Guid("63b93a3c-f0da-49d3-beee-9f803dbc78bd"), 4, "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", 5, "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp", "Cuadro Madera Calado Mdf 5 Hojas Moderno Living Decorativo Color Degrade", 13999m },
                    { new Guid("6be5d86e-dc5a-4691-a4d4-d253982683ef"), 8, "Tableta Milka Chocolate Biscuit 300 gr", 0, "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp", "Tableta Milka Chocolate Biscuit 300 gr", 9999m },
                    { new Guid("74108cef-b016-49b8-be00-09e04e256d34"), 2, "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", 19, "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp", "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", 668249m },
                    { new Guid("74e923ad-2a24-4f60-9935-ef07d5af3919"), 7, "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", 0, "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp", "Super Mario Bros Wonder Nintendo Switch", 82999m },
                    { new Guid("75901e88-e65b-4c53-94c2-f8ac9d177e48"), 8, "Milka Chocolate Oreo Max X 300 Gr.", 0, "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp", "Milka Chocolate Oreo Max X 300 Gr", 9999m },
                    { new Guid("771fd322-6521-4305-8bc3-7298ea6f841f"), 10, "Sustrato Growmix 80Lts Multipro.", 5, "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp", "GrowMix Profesional Multipro 80L", 19860m },
                    { new Guid("7b950abf-e87c-499b-8698-6370a0f3a86e"), 5, "Contenido 7gr", 0, "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp", "Corrector De Ojereas Artez Westerley Distr. Oficial", 7900m },
                    { new Guid("7e65bdc8-ef15-4987-9dd6-2175e118889d"), 5, "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", 0, "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp", "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", 12516m },
                    { new Guid("8288dab4-461d-482e-8e52-9ce5c42d417f"), 10, "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", 0, "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp", "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", 12000m },
                    { new Guid("8b30de4e-e0ce-4ec0-b0d0-fd44442dc230"), 2, "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", 11, "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp", "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", 269999m },
                    { new Guid("8b8efbe3-eded-4b6a-919c-3cb9b0ef5f57"), 6, "GUANTE ATTRAKT SOLID.", 0, "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp", "Guante Arquero Attrakt Solid Reusch Exclusivo", 43230m },
                    { new Guid("8dba51f4-8a34-4598-b3ab-1800a3d350c7"), 5, "KIT DE CUIDADO FACIAL COMPLETO.", 0, "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp", "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo", 22999m },
                    { new Guid("905983ff-cb93-4ee0-a552-df7de6eb074e"), 6, "Edad recomendada: de 8 años a 120 años.", 0, "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp", "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", 20200m },
                    { new Guid("91997a93-77b6-4190-bd9e-5d6cfaf20d2b"), 9, "Expedicion Matematica 6 - Claudia Broitman.", 5, "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp", "Expedicion Matematica 6 - Claudia Broitman", 16700m },
                    { new Guid("988f2315-47f5-43f8-a5e8-274b4ed96604"), 7, "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", 0, "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp", "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch Físico", 79206m },
                    { new Guid("996a4348-fecb-4016-83ed-0693a5e928dc"), 4, "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", 67, "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp", "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", 29000m },
                    { new Guid("afc4add6-7ebd-4978-ada1-dc0f47d9d0c3"), 1, "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", 31, "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp", "Heladera Drean HDR400F11 steel con freezer 396L 220V", 1298199m },
                    { new Guid("aff140d7-b82c-4a19-a8f1-84d334616c68"), 3, "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", 0, "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp", "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", 18400m },
                    { new Guid("b7c9e866-6d50-44b3-becd-a92c80c29a7c"), 6, "Adidas Argentum 19.", 0, "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp", "Pelota adidas Argentum 19 Liga Argentina Balón Oficial", 140000m },
                    { new Guid("c51d791a-09b8-4a7c-a281-957bd99e75be"), 9, "Libro Hábitos Atómicos - James Clear - Booket.", 0, "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp", "Libro Hábitos Atómicos - James Clear - Booket", 14600m },
                    { new Guid("c62820bd-2ee9-4523-8d36-8524d9809fbf"), 6, "Soga de saltar de acero Speed Rope.", 19, "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp", "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", 14998m },
                    { new Guid("cecef362-6f94-44f4-9859-bf5b24cfd955"), 9, "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", 0, "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp", "Libro La Felicidad - Gabriel Rolón - Planeta", 17990m },
                    { new Guid("d39c3999-8b12-49ac-bc5e-a31e8e76462e"), 3, "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", 10, "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp", "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", 21899m },
                    { new Guid("d5bdf157-2117-4ddb-a390-c14611b21a78"), 2, "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", 0, "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp", "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro", 517999m },
                    { new Guid("daf5620a-101c-459d-9838-6b53e02c6fbd"), 9, "EL DUELO (BOLSILLO) - Gabriel Rolón.", 10, "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp", "Libro El duelo - Gabriel Rolón - Booket", 16000m },
                    { new Guid("de85d90f-7a89-434d-80f0-b58e26bec4da"), 8, "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", 5, "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp", "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", 9005.29m },
                    { new Guid("df87f469-975e-4b76-b085-8ac9f2f21d23"), 1, "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", 47, "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp", "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", 1209224m },
                    { new Guid("eb314fa7-8562-46d7-b486-8d3794812853"), 4, "Pileta Encastrable HARDEST Modelo HQ-113XT.", 0, "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp", "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", 102999m },
                    { new Guid("ed5f3485-1767-41d4-9328-8ac015cf9491"), 10, "Potencia: 80 W.", 0, "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp", "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", 9888m }
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
