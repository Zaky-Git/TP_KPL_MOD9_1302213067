﻿namespace tpmodul9_1302213067
{
    public class Mahasiswa
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public Mahasiswa(string Nama, string Nim) { 
            this.Nama = Nama; 
            this.Nim = Nim; 
        }
    }
}
