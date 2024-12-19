namespace webProgramlamafinal.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    namespace webProgramlamafinal.Models  // Burada YourProject, projenizin ad�d�r
    {
        public class Recipe
        {
            public int Id { get; set; }  // Tarifin benzersiz ID'si
            public string Name { get; set; }  // Tarifin ad�
            public string Ingredients { get; set; }  // Tarifin malzemeleri
            public string Instructions { get; set; }  // Tarifin yap�l���
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
