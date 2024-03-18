using Application.Features.Brands.Constants;
using Application.Service.Repositories;
using Core.Applicantion.Rules;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Rules
{
    public class BrandBusinessRules : BaseBusinessRules
    {
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public void BrandIdShouldExistWhenSelected(Brand? brand)
        {
            if (brand is null)
                throw new Exception(BrandRulesMessages.BrandIsNotExists);
        }

        public async Task BrandNameCanNotBeDuplicatedWhenUpdated(Brand brand)
        {
            Brand? result = await _brandRepository.GetAsync(x => x.Id != brand.Id && x.Name.ToLower() == brand.Name.ToLower());
            if (result is not null)
                throw new Exception(BrandRulesMessages.BrandNameAlreadyExists);
        }
    }
}
