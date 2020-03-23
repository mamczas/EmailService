using System.Collections.Generic;
using System.Threading.Tasks;
using EmailService.Services;
using EmailService.Services.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EmailService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;

        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpGet]
        [Route("GetDetails")]
        public async Task<IActionResult> GetDetailsAsync(int id)
        {
            EmailDtoExtended details = await emailService.GetDetails(id);
            return Ok(details);
        }

        [HttpGet]
        [Route("Page")]
        public async Task<IActionResult> Page(int pageIndex, int itemPerPage)
        {
            PageDto<EmailDto> result = await emailService.GetPageAsync(pageIndex, itemPerPage);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            List<EmailDto> result = await emailService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("SendPending")]
        public async Task<IActionResult> SendPending()
        {
            await emailService.Send();
            return Ok();
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateAsync(EmailDto emailDto)
        {
            await emailService.Create(emailDto);
            return StatusCode(201);
        }
    }
}
