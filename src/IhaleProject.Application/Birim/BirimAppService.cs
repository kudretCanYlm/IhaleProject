using AutoMapper;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Domain.Birim;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Birim
{
    public class BirimAppService : IhaleProjectAppServiceBase, IBirimAppService
    {
        private readonly IBirimRepository birimRepository;
        //private readonly BirimManager birimManager;

        public BirimAppService(IBirimRepository birimRepository)
        {
            this.birimRepository = birimRepository;
            
        }

        // [Authorize()]
        public async Task<BirimDto> CreateAsync(CreateBirimDto input)
        {
            input.BirimAdi = input.BirimAdi.ToLower();
            var birim = ObjectMapper.Map<BirimEntity>(input);
            var birimDto = await birimRepository.InsertAsync(birim);

            return ObjectMapper.Map<BirimDto>(birimDto);
        }

        // [Authorize()]
        public async Task DeleteAsync(Guid id)
        {
            await birimRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<BirimDto>> GetAllAsync()
        {
            var birimler =await birimRepository.GetAllListAsync();
            var birimlerDto= ObjectMapper.Map<IEnumerable<BirimDto>>(birimler);
            return birimlerDto;
        }

        //public async Task<IEnumerable<BirimDto>> GetByFilter(Expression<Func<BirimEntity,bool>> filter)
        //{
        //    var birimler = await birimRepository.GetAllListAsync(filter);
        //    var birimlerDto = ObjectMapper.Map<IEnumerable<BirimDto>>(birimler);
        //    return birimlerDto;
        //}

        public async Task<BirimDto> GetAsync(Guid id)
        {
            var birim= await birimRepository.GetAsync(id);

            return ObjectMapper.Map<BirimDto>(birim);
        }

		public async Task<BirimEntity> GetEntityAsync(Guid id)
		{
            var birim = await birimRepository.GetAsync(id);
            return birim;
		}

		// [Authorize()]
		public async Task UpdateAsync(Guid id, UpdateBirimDto input)
        {
            var birim = await birimRepository.GetAsync(id);
            birim.BirimAdi = input.BirimAdi.ToLower();
            await birimRepository.UpdateAsync(birim);
        }
    }
}
