using ParkMellatAPI.Data;
using ParkMellatAPI.Models;
using ParkMellatAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkMellatAPI.Repository
{
    public class ParkMellatRepository : IParkMellatRepository
    {
        private readonly ApplicationDbContext _db;

        public ParkMellatRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateParkMellat(ParkMellat parkMellat)
        {
            _db.ParkMellats.Add(parkMellat);
            return save();
        }

        public bool DeleteParkMellat(ParkMellat parkMellat)
        {
            _db.ParkMellats.Remove(parkMellat);
            return save();
        }

        public ICollection<ParkMellat> GetAllParkMellat()
        {
            return _db.ParkMellats.OrderBy(name => name.Name).ToList();
        }

        public ParkMellat GetParkMellatById(int ParkMellatById)
        {
            return _db.ParkMellats.FirstOrDefault(id => id.Id == ParkMellatById);
        }

        public bool ParkMellatExists(string name, string family)
        {
            bool nValue = _db.ParkMellats.Any(n => n.Name.ToLower().Trim() == name.ToLower().Trim());
            bool fValue = _db.ParkMellats.Any(f => f.Family.ToLower().Trim() == family.ToLower().Trim());
            if (nValue==true && fValue==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ParkMellatExists(int id)
        {
           return _db.ParkMellats.Any(a => a.Id == id);
        }

        public bool save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateParkMellat(ParkMellat parkMellat)
        {
            _db.ParkMellats.Update(parkMellat);
            return save();
        }
    }
}
