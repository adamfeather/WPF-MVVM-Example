namespace MVVMExample.Models
{
    public class Cheese
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Sharpness { get; set; }

        
        public override string ToString()
        {
            return $"{Name} (Sharpness: {Sharpness})";
        }
    }
}
