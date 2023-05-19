using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelvvizsgaFeladat
{
    internal class Vizsgak
    {
        string nyelv;
        int elsoEv;
        int masodikEv;
        int harmadikEv;
        int negyedikEv;
        int otodikEv;
        int hatodikEv;
        int hetedikEv;
        int nyolcadikEv;
        int kilencedikEv;
        int tizedikEv;
        char sikeresVagyNem;

        public Vizsgak(string sor, bool sikeres)
        {
            var mezok = sor.Split(";");
            this.nyelv = mezok[0];
            this.elsoEv = int.Parse(mezok[1]);
            this.masodikEv = int.Parse(mezok[2]);
            this.harmadikEv = int.Parse(mezok[3]);
            this.negyedikEv = int.Parse(mezok[4]);
            this.otodikEv = int.Parse(mezok[5]);
            this.hatodikEv = int.Parse(mezok[6]);
            this.hetedikEv = int.Parse(mezok[7]);
            this.nyolcadikEv = int.Parse(mezok[8]);
            this.kilencedikEv = int.Parse(mezok[9]);
            this.tizedikEv = int.Parse(mezok[10]);
            this.sikeresVagyNem = 'i';
        }
        public Vizsgak(string sor)
        {
            var mezok = sor.Split(";");
            this.nyelv = mezok[0];
            this.elsoEv = int.Parse(mezok[1]);
            this.masodikEv = int.Parse(mezok[2]);
            this.harmadikEv = int.Parse(mezok[3]);
            this.negyedikEv = int.Parse(mezok[4]);
            this.otodikEv = int.Parse(mezok[5]);
            this.hatodikEv = int.Parse(mezok[6]);
            this.hetedikEv = int.Parse(mezok[7]);
            this.nyolcadikEv = int.Parse(mezok[8]);
            this.kilencedikEv = int.Parse(mezok[9]);
            this.tizedikEv = int.Parse(mezok[10]);
            this.sikeresVagyNem = 'n';
        }


        public string Nyelv { get => nyelv;}
        public int ElsoEv { get => elsoEv;}
        public int MasodikEv { get => masodikEv;}
        public int HarmadikEv { get => harmadikEv;}
        public int NegyedikEv { get => negyedikEv;}
        public int OtodikEv { get => otodikEv;}
        public int HatodikEv { get => hatodikEv;}
        public int HetedikEv { get => hetedikEv;}
        public int NyolcadikEv { get => nyolcadikEv;}
        public int KilencedikEv { get => kilencedikEv;}
        public int TizedikEv { get => tizedikEv; }
        public long Osszes { get => elsoEv + masodikEv + harmadikEv + negyedikEv + otodikEv + hatodikEv + hetedikEv + nyolcadikEv + kilencedikEv + TizedikEv; }
        public char SikeresVagyNem { get => sikeresVagyNem;}
        
    }
}
