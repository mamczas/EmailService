using EmailService.Context;
using EmailService.Context.Models;

namespace EmailService.Repositories
{
    public class EmailRepository : BaseRepository<EmailModel, int>, IEmailRepository
    {
        public EmailRepository(EmailServiceDbContext dbContext) : base(dbContext)
        {

        }
    }
}
