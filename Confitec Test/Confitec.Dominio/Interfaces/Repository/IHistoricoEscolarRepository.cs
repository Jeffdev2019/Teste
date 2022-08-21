﻿using Confitec.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Dominio.Interfaces.Repository
{
    public interface IHistoricoEscolarRepository
    {
        Task<IEnumerable<HistoricoEscolarVO>> FindAll();
        Task<HistoricoEscolarVO> FindById(int id);
        Task<HistoricoEscolarVO> Create(HistoricoEscolarVO vo);
        Task<HistoricoEscolarVO> Update(HistoricoEscolarVO vo);
        Task<bool> Delete(int id);
    }
}