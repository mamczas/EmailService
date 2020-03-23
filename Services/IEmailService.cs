using EmailService.Enums;
using EmailService.Services.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmailService.Services
{
    public interface IEmailService
    {
        Task Create(EmailDto emailDto);
        Task<StatusEnum> GetStatus(int id);
        Task<EmailDtoExtended> GetDetails(int id);
        Task<PageDto<EmailDto>> GetPageAsync(int pageIndex, int itemPerPage);
        Task<List<EmailDto>> GetAllAsync();
        Task Send();
    }
}