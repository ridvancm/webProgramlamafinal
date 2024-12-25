namespace webProgramlamafinal.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Recipe
    {
        public int Id { get; set; }  // Tarifin benzersiz ID'si
        public string Name { get; set; }  // Tarifin adýu                                        
        public string Ingredients { get; set; }  // Tarifin malzemeleri
        public string Instructions { get; set; }  // Tarifin yapýlýþý
        public string Category { get; set; } // Yeni eklenen özellik
    }
}
 