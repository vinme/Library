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
    public class BookLocationService : IBookLocationService
    {
        public IBookLocationRepository _bookLocationRepository;
        private readonly IMapper _mapper;
        public BookLocationService(IBookLocationRepository bookLocationRepository, IMapper mapper)
        {
            _bookLocationRepository = bookLocationRepository;
            _mapper = mapper;
        }
        public LocationsResourceModel GetLocationList()
        {
            var list = _bookLocationRepository.GetBookLocationList();

            return new LocationsResourceModel()
            {
                BookLocations = _mapper.Map<IEnumerable<BookLocation>, IEnumerable<LocationResourceModel>>(list)
            };
        }
    }
}
