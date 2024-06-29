using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DataBase.Customer.Commands.DeleteCustomer
{
    public class DeleteCustomeCommand: IDeleteCustomeCommand
    {
        private readonly IDataBaseService _dataBaseService;
        public DeleteCustomeCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService; 
        }
        public async Task<bool> Execute(int customerId)
        {
            var entity = await _dataBaseService.Customer
                .FirstOrDefaultAsync(x => x.CustomerId == customerId);
            if (entity == null)
                return false;
            
            _dataBaseService.Customer.Remove(entity);
            return await _dataBaseService.SaveAsync();
        }
    }
}
