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
    public class ProjectManager : IProjectServices
    {
        IProjectDal _serviceDal;
        public ProjectManager(IProjectDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void TAdd(Project t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _serviceDal.Delete(t);
        }

        public Project TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Project t)
        {
            _serviceDal.Update(t);
        }
    }
}
