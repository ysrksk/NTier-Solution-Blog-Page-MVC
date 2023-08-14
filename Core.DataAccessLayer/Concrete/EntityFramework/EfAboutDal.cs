﻿using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfAboutDal : EfEntityRepositoryBase<About, BlogContext>, IAboutDal
{
}
