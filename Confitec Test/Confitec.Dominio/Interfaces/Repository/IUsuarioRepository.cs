﻿using Confitec.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Dominio.Interfaces.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioVO>> FindAll();
        Task<UsuarioVO> FindById(int id);
        Task<UsuarioVO> Create(UsuarioVO vo);
        Task<UsuarioVO> Update(UsuarioVO vo);
        Task<bool> Delete(int id);

    }
}
