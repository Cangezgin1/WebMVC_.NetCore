using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager:IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination p)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination p)
        {
            throw new NotImplementedException();
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public List<Destination> TGetList(Destination p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination p)
        {
            throw new NotImplementedException();
        }
    }
}
