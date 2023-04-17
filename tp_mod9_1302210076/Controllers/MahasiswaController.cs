using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tp_mod9_1302210076.Controllers
{
    public class MahasiswaController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class mahasiswaController : ControllerBase
        {
            private static List<mahasiswa> data = new List<mahasiswa>
        {
            new mahasiswa("Ridwa Nur Rahman","1302210076"),
            new mahasiswa("Hilmi Fauziyyah Supriatna ","1302210081"),
            new mahasiswa("Ibrahim Mulyo Tsabit","1302210022"),
            new mahasiswa("Arya Frandika Daulay","1302213069"),
            new mahasiswa("Marsya Rayani Humaira","1302213003")
        };

            [HttpGet]
            public IEnumerable<mahasiswa> Get()
            {
                return data;
            }

            [HttpGet("{id}")]
            public mahasiswa Get(int id)
            {
                return data[id];
            }
            [HttpPost]
            public void Post(mahasiswa value)
            {
                data.Add(value);
            }

            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                data.RemoveAt(id);
            }
        }
    }
}
