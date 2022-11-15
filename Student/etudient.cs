using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sahar
{
    public class etudient
    {
        string nom;
        double ex, ds, tp;
        public etudient()
        {
            nom = "";
            ex = 0;
            ds = 0;
            tp = 0;
        }
        public etudient(string nom,double ex,double ds, double np)
        {
            this.nom = nom; 
            this.ex = ex;   
            this.ds = ds;   
            this.tp = np;
              
        }
        public override string ToString()
        {
            return "l'etudient"+ this.nom + moy();
        }
        public string SGnom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Ex
        {
            get { return ex; }
                set { ex = value; }
        }
        public double Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public double Tp
        {
            get { return tp; }
            set { tp = value; }
        }
        public double moy()
        {
            return (ex * 0.5) + (ds * 0.3) + (tp * 0.2);
        }


    }

}
