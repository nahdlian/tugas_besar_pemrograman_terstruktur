using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_besar
{
    class Mahasiswa
    {
        private string nim, nama, prodi, smstr, tahun;

        public string Nim {
            get { return nim; }
            set { nim = value; }
        }

        public string Nama{
            get { return nama; }
            set { nama = value; }
        }

        public string Prodi{
            get { return prodi; }
            set { prodi = value; }
        }

        public string Semester
        {
            get { return smstr; }
            set { smstr = value; }
        }

        public string Tahun{
            get { return tahun; }
            set { tahun = value; }
        }
    }
}
