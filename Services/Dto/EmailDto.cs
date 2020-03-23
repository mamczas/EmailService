using System.ComponentModel.DataAnnotations;

namespace EmailService.Services.Dto
{
    public class EmailDto
    {
        [Required(ErrorMessage = "Sender is required")]
        public string Sender { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Recipients is required")]
        public string Recipients { get; set; }
        public string Text { get; set; }
        public string HTML { get; set; }
    }
}