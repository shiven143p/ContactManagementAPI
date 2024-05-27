using ContactManangement.Entities;
using ContactManangement.Entities.Dto;

namespace ContactManangement.Services
{
    public interface IContactService
    {
        public Task<InternalResponse> GetContactListAsync();
        public Task<InternalResponse> GetContactByIDAsync(string contactId);
        public Task<InternalResponse> AddContactAsync(ContactDto contactDto);
        public Task<InternalResponse> UpdateContactAsync(ContactDto contactDto);
        public Task<InternalResponse> DeleteContactAsync(string contactId);
    }
}
