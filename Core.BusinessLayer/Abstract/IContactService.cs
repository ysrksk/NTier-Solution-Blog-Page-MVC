using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract;

public interface IContactService
{
    void AddContact(Contact contact);
    void UpdateContact(Contact contact);
    void DeleteContact(Contact contact);
    Contact GetContactById(int id);
    List<Contact> GetAllContact();
}
