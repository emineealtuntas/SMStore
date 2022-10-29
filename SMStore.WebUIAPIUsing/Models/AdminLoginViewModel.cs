namespace SMStore.WebUIAPIUsing.Models
{
    public class AdminLoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
// class larda data annotation yerine fluent validation ile veri doğrulaması yapabilriz
// Bunun için nuget pm dan fluent validation asp.net core paketini projemize yüklemeliyiz
