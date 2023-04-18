using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210028.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mh = new List<Mahasiswa>
        {
            new Mahasiswa("Rihan Hidayat", "1302210028", 
                new List<string>{"KPL", "BasDat", "PBO"}, 2021),
            new Mahasiswa("Jaatsiyah Maulidina Astrianto", "1302213043",
                new List<string>{"KPL", "BasDat", "PBO"}, 2021),
            new Mahasiswa("Hilman Fariz Hirzi", "1302213092",
                new List<string>{"KPL", "BasDat", "PBO"}, 2021),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mh;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mh.Add(newMahasiswa);
        }

        [HttpGet("{idx}")]
        public Mahasiswa Get(int idx)
        {
            return mh[idx];
        }

        [HttpDelete("{idx}")]
        public void Delete(int idx)
        {
            mh.RemoveAt(idx);
        }
    }
}
