using AppLibertadoresHAS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibertadoresHAS.Services.Usuarios
{
    internal class UsuarioService : Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "https://xyz.azurewebsites.net/Usuarios";
        public UsuarioService()
        {
            _request = new Request();
        }
        public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Registrar";
            u.Id = await _request.PostReturnIntAsync(apiUrlBase + urlComplementar, u, string.Empty);
            return u;
        }
        public async Task<Usuario> PostAutententicarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Autenticar";
            u = await _request.PostAsync(apiUrlBase + urlComplementar, u, string.Empty);
            return u;
        }
    }
}
