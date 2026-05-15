using Cabelos_do_Taeyong.Context;
using Cabelos_do_Taeyong.Models;

namespace Cabelos_do_Taeyong.Repositories
{
    public class CabelosRepository
    {
        private readonly CabelosContext _context;

        public CabelosRepository(CabelosContext context)
        {
            _context = context;
        }

        public List<Cabelos> ObterCabelos()
        {
            return _context.Cabelos.ToList();
        }

        public void Adicionar (Cabelos t)
        {
            _context.Cabelos.Add(t);
            _context.SaveChanges();
        }
    }
}