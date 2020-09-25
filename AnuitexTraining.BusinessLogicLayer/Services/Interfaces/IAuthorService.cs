﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AnuitexTraining.BusinessLogicLayer.Models.Authors;

namespace AnuitexTraining.BusinessLogicLayer.Services.Interfaces
{
    public interface IAuthorService
    {
        public Task<AuthorModel> GetAsync(long id);
        public Task<object> GetPageAsync();
        public Task AddAsync(AuthorModel item);
        public Task DeleteAsync(long id);
        public Task UpdateAsync(AuthorModel item);
    }
}