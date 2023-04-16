using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace tpmodul9_1302213067.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController: ControllerBase
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Muhammad Zaky Fathurahim","1302213067"),
            new Mahasiswa ("Reza Adhie Dharmawan","1302213016"),
            new Mahasiswa ("Rizki Muhammad Ridwan","1302210097"),
            new Mahasiswa ("Fasya Rayhan Maulana","1302213116" ),
            new Mahasiswa ("Mochaman Rifqi Barlian","1302210125"),
            new Mahasiswa ("Raihan Sulthon Yaafi","1302213074")
        };
   
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= ListMahasiswa.Count)
            {
                NotFound();
            }
            return ListMahasiswa[id];
        }


        [HttpPost]
        public void Post(Mahasiswa dataBaru)
        {
            ListMahasiswa.Add(dataBaru);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= ListMahasiswa.Count)
            {
                NotFound();
            }
            ListMahasiswa.RemoveAt(id);
        }

   
    }
}
