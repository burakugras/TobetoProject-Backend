﻿using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IExperienceDal : IRepository<Experience, int>, IAsyncRepository<Experience, int>
{

}
