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
	public class SocialMediaManager : ISocialMediaService
	{
		ISocialMediaDal _socialMediaDal;

		public SocialMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public SocialMedia GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(SocialMedia t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(SocialMedia t)
		{
			throw new NotImplementedException();
		}

		public List<SocialMedia> TGetList()
		{
			return _socialMediaDal.GetList();
		}

		public void TUpdate(SocialMedia t)
		{
			throw new NotImplementedException();
		}
	}
}
