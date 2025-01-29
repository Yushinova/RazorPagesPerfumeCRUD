namespace RazorPagesPerfumeCRUD.Model
{
    public class Perfume
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Gender {  get; set; }
        public string Notes {  get; set; }
        public int Volume { get; set; }
        public decimal Price {  get; set; }
        public bool isSale { get; set; }

    }
}
