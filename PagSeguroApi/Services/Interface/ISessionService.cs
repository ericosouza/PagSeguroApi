using PagSeguroApi.Model;
using System.Threading.Tasks;

namespace PagSeguroApi.Services.Interface
{
    interface ISessionService
    {
        Task<SessionResponse> Obter(SessionRequest sessionRequest);
    }
}
