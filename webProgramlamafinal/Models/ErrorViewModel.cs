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
        public string Name { get; set; }  // Tarifin ad�u                                        
        public string Ingredients { get; set; }  // Tarifin malzemeleri
        public string Instructions { get; set; }  // Tarifin yap�l���
        public string Category { get; set; } // Yeni eklenen �zellik
    }
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

   
    
        public class UserModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Gender { get; set; }
        }
    

}
