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
    public class About2Manager : IAbout2Service
    {
        IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void TAdd(About2 p)
        {
            _about2Dal.Insert(p);
        }

        public void TDelete(About2 p)
        {
            _about2Dal.Delete(p);
        }

        public About2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About2> TGetList(About2 p)
        {
            return _about2Dal.GetList();
        }

        public void TUpdate(About2 p)
        {
            _about2Dal.Update(p);
        }
    }
}
