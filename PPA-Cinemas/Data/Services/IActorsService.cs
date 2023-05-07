using PPA_Cinemas.Models;

namespace PPA_Cinemas.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIDAsync(int actorId);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int actorId, Actor newActor);
        Task  DeleteAsync(int actorId);
    }
}
