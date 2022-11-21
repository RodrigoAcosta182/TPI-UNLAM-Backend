using Grandin.Web.EF;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Hubs
{
    public class MessageHub : Hub
    {
        
        //private IAppSharedFunction _appSharedFunction;
        //private IUsuarioRepositorio _userRepo;
        //private string _emailTemp;
        //public MessageHub( IAppSharedFunction appSharedFunction, IUsuarioRepositorio userRepom, string email )
        //{
           
        //    _appSharedFunction = appSharedFunction;
        //    _userRepo = userRepom;
        //    _emailTemp = email;
        //}
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public  override Task OnDisconnectedAsync(Exception exception)
        {
            //QuitarDeGrupo(_emailTemp);
            return base.OnDisconnectedAsync(exception);
        }
        public async Task AgregarAGrupo(string email)
        {

            //_emailTemp = email;
            //Usuario usuario = _userRepo.getUsuarioByEmail(email);
            await Groups.AddToGroupAsync(GetConnectionId(), email);
        } 
        
        public void QuitarDeGrupo(string email)
        {
            //Usuario usuario = _userRepo.getUsuarioByEmail(email);
            Groups.RemoveFromGroupAsync(GetConnectionId(), email);
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}
