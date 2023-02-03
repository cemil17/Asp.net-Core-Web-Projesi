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
	public class DefaultFieldManager : IDefaultFieldService
	{
		IDefaultFieldDal _defaulFieldDal;

		public DefaultFieldManager(IDefaultFieldDal defaulFieldDal)
		{
			_defaulFieldDal = defaulFieldDal;
		}

		public DefaultField GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(DefaultField t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(DefaultField t)
		{
			throw new NotImplementedException();
		}

		public List<DefaultField> TGetList()
		{
			return _defaulFieldDal.GetList();
		}

		public void TUpdate(DefaultField t)
		{
			throw new NotImplementedException();
		}
	}
}
