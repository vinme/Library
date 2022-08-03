using ExLib.Domain.Interfaces;
using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;
using ExLib.Application.ResourceModels.Common;
using AutoMapper;
using ExLib.Domain.Entities;

namespace ExLib.Application.Services
{
    public class BookTypeService : IBookTypeService
    {
        public IBookTypeRepository _bookTypeRepository;
        private readonly IMapper _mapper;
        public BookTypeService(IBookTypeRepository bookTypeRepository, IMapper mapper)
        {
            _bookTypeRepository = bookTypeRepository;
            _mapper = mapper;
        }
        public TypesResourceModel GetTypeList()
        {
            var list = _bookTypeRepository.GetBookTypeList();
            
            return new TypesResourceModel()
            {
                BookTypes = _mapper.Map<IEnumerable<BookType>, IEnumerable<TypeResourceModel>>(list)
            };
        }
    }
}
