namespace webProgramlamafinal.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    namespace webProgramlamafinal.Models  // Burada YourProject, projenizin adýdýr
    {
        public class Recipe
        {
            public int Id { get; set; }  // Tarifin benzersiz ID'si
            public string Name { get; set; }  // Tarifin adý
            public string Ingredients { get; set; }  // Tarifin malzemeleri
            public string Instructions { get; set; }  // Tarifin yapýlýþý
        }
    }

}



namespace webProgramlamafinal.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
