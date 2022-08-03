using ExLib.Domain.Interfaces;
using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Books;
using System;
using System.Collections.Generic;
using System.Text;
using ExLib.Application.ResourceModels.Common;
using ExLib.Domain.Entities;
using AutoMapper;

namespace ExLib.Application.Services
{
    public class BookStatusService : IBookStatusService
    {
        public IBookStatusRepository _bookStatusRepository;
        private readonly IMapper _mapper;
        public BookStatusService(IBookStatusRepository bookStatusRepository, IMapper mapper)
        {
            _bookStatusRepository = bookStatusRepository;
            _mapper = mapper;
        }
        public StatusesResourceModel GetStatusList()
        {
            var list = _bookStatusRepository.GetBookStatusList();

            return new StatusesResourceModel()
            {
                BookStatuses = _mapper.Map<IEnumerable<BookStatus>, IEnumerable<StatusResourceModel>>(list)
            };
        }
    }
}
