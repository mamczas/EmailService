using EmailService.Enums;
using System;

namespace EmailService.Services.Dto
{
    public class EmailDtoExtended
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Recipients { get; set; }
        public string Message { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime Created { get; set; }
    }
}
