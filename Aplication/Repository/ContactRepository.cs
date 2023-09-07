using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class ContactRepository : GenericRepository<Contact>, IContactRepository{
    public ContactRepository(ApiIncidencesContext contex) : base(contex){}
}