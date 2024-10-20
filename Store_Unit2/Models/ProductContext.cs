using Microsoft.EntityFrameworkCore;

namespace Store_Unit2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "iTable",
                    Description = "Meet the iTable, the most intelligent piece of furniture ever created. " +
                    "It's not just a table, it's a lifestyle upgrade. Equipped with revolutionary" +
                    " \"Surface Stability\" technology, the iTable supports all your belongings without breaking a sweat. " +
                    "With a sleek, minimalist design, it's perfect for working, dining, or just admiring. Need more? It comes with" +
                    " \"Zero Charging Ports\" for the ultimate wireless experience and never requires updates.",
                    Price = 499,
                    ImagePath = "/images/ITable.png"

                }, new Product
                {
                    Id = 2,
                    Name = "Air Pro",
                    Description = "Introducing the revolutionary Air Pro – the world’s most advanced pillow. " +
                    "With cutting-edge \"cloud-like\" technology, this pillow offers the ultimate blend of softness and support," +
                    " making you feel like you're sleeping on air (because you practically are). Engineered with our patented \"Fluff Dynamics,\" the " +
                    "Air Pro adjusts seamlessly to your sleep posture. Plus, it’s so lightweight, you’ll forget it’s even there. Rest easy, dream big," +
                    " and prepare to elevate your naps to a whole new level of comfort.",
                    Price = 19999,
                    ImagePath = "/images/AirPro.png"
                }, new Product
                {
                    Id = 3,
                    Name = "Dice Pro",
                    Description = "The Dice Pro is here to redefine the world of decision-making." +
                    " Say goodbye to the era of uncertainty with this sleek, precision-engineered tool." +
                    " Crafted from premium polycarbonate, the Dice Pro offers a smooth, satisfying roll every time," +
                    " ensuring your fate is left in the hands of the finest randomness known to humankind. Need to choose a restaurant? " +
                    "Figure out who's driving? The Dice Pro has your back, delivering unparalleled performance with every roll.",
                    Price = 399,
                    ImagePath = "/images/DicePro.png"
                }

            );
        }
    }
}
