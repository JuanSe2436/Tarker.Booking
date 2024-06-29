using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DataBase.User.Queries.GetUserById
{
    public class GetUserByIdQuery: IGetUserByIdQuery
    //INVOCAR SERVICIO DE BASE DE DATOS
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        //CREACIONO DE METODO PARA OBTENER LOS USUARIOS
        public GetUserByIdQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<GetUserByIdModel> Execute(int userId)
        {
            //CONDICION POR MEDIO DE EXPRESION LAMDA
            var entity = await _dataBaseService.User
                .FirstOrDefaultAsync(x => x.UserId == userId);
            return _mapper.Map<GetUserByIdModel>(entity);
        }
    }
}
