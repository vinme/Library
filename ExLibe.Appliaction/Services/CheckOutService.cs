using ExLib.Domain.Interfaces;
using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ExLib.Domain.Entities;
using ExLib.Application.ResourceModels.Comments;
using ExLib.Application.ResourceModels.CheckOuts;

namespace ExLib.Application.Services
{
    public class CheckOutService : ICheckOutService
    {
        public ICheckOutRepository _checkOutRepository;
        private readonly IMapper _mapper;
        public CheckOutService(ICheckOutRepository checkOutRepository, IMapper mapper)
        {
            _checkOutRepository = checkOutRepository;
            _mapper = mapper;
        }


        public CheckOutsResourceModel GetCheckOuts()
        {
            return new CheckOutsResourceModel()
            {
                CheckOuts = _checkOutRepository.GetCheckOuts()
            };
        }

        public async Task<CheckOutResponse> AddCheckOut(CheckOutRequest checkOut)
        {
            var checkOutAdd = _mapper.Map<CheckOutRequest, CheckOut>(checkOut);
            var result = await _checkOutRepository.AddcheckOut(checkOutAdd);
            return _mapper.Map<CheckOut, CheckOutResponse>(result);
        }
    }
}
