using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class AddressRepository : GenericRepository<Address>, IAddressRepository{
    public AddressRepository(ApiIncidencesContext contex) : base(contex){}
}