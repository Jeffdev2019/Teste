﻿using Confitec.WebAPI.Aplication.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.WebAPI.Domain.Interfaces.Repository
{
    public interface IEscolaridadeRepository
    {
        Task<IEnumerable<EscolaridadeVO>> FindAll();
        EscolaridadeVO FindById(int id);
        Task<EscolaridadeVO> Create(EscolaridadeVO vo);
        Task<EscolaridadeVO> Update(EscolaridadeVO vo);
        Task<bool> Delete(int id);
    }
}
