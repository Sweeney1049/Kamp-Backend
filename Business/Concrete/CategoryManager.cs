﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //business codes
            return new SuccessDataResult<List<Category>> (_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            //Select * from Categories where CategoryId=3 

            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
