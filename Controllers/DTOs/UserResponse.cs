namespace MiPrimerAPI.Controllers.DTOs
{
    public class UserResponse
    {
        public int Page { get; set; }
        public int Per_Page { get; set; }
        public List<User> Data { get; set; }
    }
}
