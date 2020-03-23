using EmailService.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmailService.Context.Models
{
    public class EmailModel : IDataEntity
    {
        public int Id { get; set; }
        [EmailAddress]
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Recipients { get; set; }
        public string Message { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime Created { get; set; }
    }
}
