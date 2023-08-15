using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class ContactManager : IContactService
{

    IContactDal _contactDal;
    public ContactManager(IContactDal ContactDal)
    {
        _contactDal = ContactDal;
    }

    public void AddContact(Contact contact)
    {
        _contactDal.Add(contact);
    }

    public void DeleteContact(Contact contact)
    {
        _contactDal.Delete(contact);
    }

    public Contact GetContactById(int id)
    {
        var contact = _contactDal.Get(x => x.ContacttId == id);
        return contact;
    }

    public List<Contact> GetAllContact()
    {
        return _contactDal.GetAll();
    }

    public void UpdateContact(Contact contact)
    {
        _contactDal.Update(contact);
    }
}
