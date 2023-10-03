using Microsoft.EntityFrameworkCore;
using JeanLuis_AP1_P1.DAL;
using JeanLuis_AP1_P1.Models;
using System.Linq.Expressions;

namespace JeanLuis_AP1_P1.BLL
{
    public class AportesBLL
    {
        private readonly Context _context;

        public AportesBLL(Context context)
        {
            _context = context;
        }

        public bool Existe(int AporteId)
        {
            return _context.Aportes.Any(op => op.AporteId == AporteId);
        }

        public bool Insertar(Aportes aportes)
        {
            _context.Aportes.Add(aportes);
            return _context.SaveChanges() > 0;
        }

        public bool Modificar(Aportes aportes)
        {
            var encontrado = _context.Aportes.Find(aportes.AporteId);

            if(encontrado != null)
            {
                _context.Entry(encontrado).CurrentValues.SetValues(aportes);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Guardar(Aportes aportes)
        {
            if(!Existe(aportes.AporteId))
                return Insertar(aportes);
            else
                return Modificar(aportes);
        }

        public bool Eliminar(int AporteId)
        {
            var eliminado = _context.Aportes.Where(o => o.AporteId == AporteId).SingleOrDefault();

            if (eliminado != null)
            {
                _context.Entry(eliminado).State = EntityState.Deleted;
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public Aportes? Buscar (int AporteId)
        {
            return _context.Aportes.Where(op => op.AporteId == AporteId).AsNoTracking().SingleOrDefault();
        }

        public List<Aportes> GetList (Expression<Func<Aportes, bool>> Criterio)
        {
            return _context.Aportes.Where(Criterio).AsNoTracking().ToList();
        }

        public bool verificar(Aportes aportes)
        {
            var igual = _context.Aportes.Any(op => op.Persona == aportes.Persona || op.AporteId == aportes.AporteId);
            if (igual)
                return true;

            return false;
        }
    }
}
