using ParkMellatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkMellatAPI.Repository.IRepository
{
    public interface IParkMellatRepository
    {
      public  ICollection<ParkMellat> GetAllParkMellat();

     public   ParkMellat GetParkMellatById(int ParkMellatById);
     public   bool ParkMellatExists(string name , string family);
     public   bool ParkMellatExists(int id);
      
     public   bool CreateParkMellat(ParkMellat parkMellat);
      
     public   bool UpdateParkMellat(ParkMellat parkMellat);
      
     public   bool DeleteParkMellat(ParkMellat parkMellat);
        public bool save();
    }
}
