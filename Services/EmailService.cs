using EmailService.Enums;
using EmailService.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmailService.Services
{
    public class EmailService : IEmailService
    {
        public Task Create(EmailDto emailDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<EmailDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<EmailDtoExtended> GetDetails(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PageDto<EmailDto>> GetPageAsync(int pageIndex, int itemPerPage)
        {
            throw new System.NotImplementedException();
        }

        public Task<StatusEnum> GetStatus(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Send()
        {
            throw new System.NotImplementedException();
        }
    }
}
