
using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;

namespace minimal_api.InfraEstrutura.Interfaces
{
    
    public interface IAdministradorServico
    {
       Administrador? Login(LoginDTO loginDTO);
    }
}