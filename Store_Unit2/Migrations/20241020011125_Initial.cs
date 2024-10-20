using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store_Unit2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 1, "Meet the iTable, the most intelligent piece of furniture ever created. It's not just a table, it's a lifestyle upgrade. Equipped with revolutionary \"Surface Stability\" technology, the iTable supports all your belongings without breaking a sweat. With a sleek, minimalist design, it's perfect for working, dining, or just admiring. Need more? It comes with \"Zero Charging Ports\" for the ultimate wireless experience and never requires updates.", "/images/ITable.png", "iTable", 499.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 2, "Introducing the revolutionary Air Pro – the world’s most advanced pillow. With cutting-edge \"cloud-like\" technology, this pillow offers the ultimate blend of softness and support, making you feel like you're sleeping on air (because you practically are). Engineered with our patented \"Fluff Dynamics,\" the Air Pro adjusts seamlessly to your sleep posture. Plus, it’s so lightweight, you’ll forget it’s even there. Rest easy, dream big, and prepare to elevate your naps to a whole new level of comfort.", "/images/AirPro.png", "Air Pro", 19999.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 3, "The Dice Pro is here to redefine the world of decision-making. Say goodbye to the era of uncertainty with this sleek, precision-engineered tool. Crafted from premium polycarbonate, the Dice Pro offers a smooth, satisfying roll every time, ensuring your fate is left in the hands of the finest randomness known to humankind. Need to choose a restaurant? Figure out who's driving? The Dice Pro has your back, delivering unparalleled performance with every roll.", "/images/DicePro.png", "Dice Pro", 399.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
