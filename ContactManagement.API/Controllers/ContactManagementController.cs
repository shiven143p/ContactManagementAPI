using ContactManangement.Entities;
using ContactManangement.Entities.Dto;
using ContactManangement.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactManangement.Controllers
{
    [Route("api/Contact")]
    [ApiController]
    public class ContactManagementController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactManagementController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("GetContacts")]
        public async Task<InternalResponse> Get()
        {
            return await _contactService.GetContactListAsync();            
        }

        [HttpGet]
        [Route("GetContact/{contactId}")]
        public async Task<InternalResponse> Get(string contactId)
        {
            return await _contactService.GetContactByIDAsync(contactId);
        }

        [HttpPost]
        [Route("CreateContact")]
        public async Task<InternalResponse> Post(ContactDto contactDto)
        {
            return await _contactService.AddContactAsync(contactDto);
        }

        [HttpPut]
        [Route("UpdateContact")]
        public async Task<InternalResponse> Put(ContactDto contactDto)
        {
            return await _contactService.UpdateContactAsync(contactDto);
        }

        [HttpDelete]
        [Route("DeleteContact/{contactId}")]
        public async Task<InternalResponse> Delete(string contactId)
        {
            return await _contactService.DeleteContactAsync(contactId);

        }
    }
}
