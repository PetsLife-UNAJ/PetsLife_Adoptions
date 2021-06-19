﻿using AccessData.Commad.Repository;
using AccessData.Queries.Repository;
using Domain.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ITipoMascotaService
    {
        List<TipoMascotaDTO> GetTipos();

    }
    public class TipoMascotaService : ITipoMascotaService
    {
        private readonly IGenericRepository _repository;
        private readonly ITipoMascotaQuery _query;

        public TipoMascotaService(IGenericRepository repository, ITipoMascotaQuery query)
        {
            this._repository = repository;
            this._query = query;
        }

        public List<TipoMascotaDTO> GetTipos()
        {
            return _query.GetAllTipos();
        }
    }
}