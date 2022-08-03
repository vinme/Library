using ExLib.Domain.Interfaces;
using ExLib.Infrastructure.Data.Repositories;
using ExLib.Application.Interfaces;
using ExLib.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ExLib.Application.Mapping;

namespace ExLib.Infrastructure.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            //ExLib.Application
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICheckOutService, CheckOutService>();
            services.AddScoped<IBookTypeService, BookTypeService>();
            services.AddScoped<IBookLocationService, BookLocationService>();
            services.AddScoped<IBookStatusService, BookStatusService>();

            //ExLib.Domain.Interfaces | ExLib.Infra.Data.Repositories
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ICheckOutRepository, CheckOutRepository>();
            services.AddScoped<IBookTypeRepository, BookTypeRepository>();
            services.AddScoped<IBookLocationRepository, BookLocationRepository>();
            services.AddScoped<IBookStatusRepository, BookStatusRepository>();
        }
    }
}
