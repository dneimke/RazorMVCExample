using System;

namespace RazorMVC.Data
{
    public class Favourite
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public string UserId { get; set; }
    }
}
