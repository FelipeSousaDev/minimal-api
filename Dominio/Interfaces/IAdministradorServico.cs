using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalAPI.Dominio.Entidades;
using MinimalAPI.DTO;

namespace minimal_api.Dominio.Interfaces;

    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador Incluir (Administrador administrador);
        Administrador? BuscaPorId (int id);
        List<Administrador> Todos(int? pagina);

    }
        
 
