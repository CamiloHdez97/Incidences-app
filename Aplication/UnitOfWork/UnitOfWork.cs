using Aplication.Repository;
using Domain.Interfaces;
using Persistence;

namespace Aplication.UnitOfWork{

    public class UnitOfWork : IUnitOfWork, IDisposable{

        private readonly ApiIncidencesContext context;
        private CountryRepository _countries;
        public UnitOfWork(ApiIncidencesContext _context)
        {
            context = _context;
        }

        public ICountryRepository Countries{

            get{
                if (_countries == null){
                    _countries = new CountryRepository(context);
                }return _countries;
            }

        }
        public int Save(){
            return context.SaveChanges();
        }

        public void Dispose(){
            context.Dispose();
        }

    }

}