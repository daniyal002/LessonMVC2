namespace LessonMVC2.Models
{
    public class Product
    {
        private static int _id { get; set; } = 0;
        private int Id { get; set; }
        private string Name { get; set; }
        private double Cost { get; set; }

        private string Description { get; set; }

        public Product(string name, double cost, string description)
        {
            Id = _id;
            Name = name;
            Cost = cost;
            Description = description;
            _id++;
        }

        public override string ToString() => $"Id{Id} \nName{Name} \nCost{Cost}";
    }
}
