﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DataBase.Customer.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery: IGetAllCustomerQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public GetAllCustomerQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            //INYECCION DE DEPENDENCIAS
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllCustomerModel>> Execute()
        {
            var listEntities = await _dataBaseService.Customer.ToListAsync();
            return _mapper.Map<List<GetAllCustomerModel>>(listEntities);
        }
    }
}
