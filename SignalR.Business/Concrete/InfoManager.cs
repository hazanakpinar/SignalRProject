using SignalR.Business.Abstract;
using SignalR.DataAccess.Abstract;
using SignalR.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Business.Concrete
{
    public class InfoManager : IInfoService
    {
        private readonly IInfoDal _infoDal;
        public void TAdd(Info entity)
        {
            _infoDal.Add(entity);
        }

        public void TDelete(Info entity)
        {
            _infoDal.Delete(entity);
        }

        public List<Info> TGetListAll()
        {
            return _infoDal.GetAll();
        }

        public Info TGetByID(int id)
        {
            return _infoDal.GetByID(id);
        }

        public void TUpdate(Info entity)
        {
            _infoDal.Update(entity);
        }
    }
}
