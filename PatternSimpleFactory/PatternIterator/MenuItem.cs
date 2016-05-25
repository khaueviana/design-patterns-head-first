namespace PatternIteratorComposite
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegetarian { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }
    }
}