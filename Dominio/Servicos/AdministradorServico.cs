using System;
using System.Data.Common;
using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;
using minimal_api.InfraEstrutura.DB;
using minimal_api.InfraEstrutura.Interfaces;


namespace minimal_api.Dominio.Servicos
{

    public class AdministradorServico : IAdministradorServico
    {
        private readonly AppDbContext _context;
        public AdministradorServico(AppDbContext context)
        {
            _context = context;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
        }

    }
}

