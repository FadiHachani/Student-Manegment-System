using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Classe
    {
        private String nomc1;
        ArrayList list;
        public Classe()
        {
            nomc1 = "";
        }
        public Classe(string nom)
        {
            this.nomc1 = nom;
            this.list = new ArrayList();

        }
        public void AjoutE(etudient E)
        {
            this.list.Add(E);
        }
        public void InserE(etudient E, int pos)
        {
            this.list.Insert(pos, E);
        }
        public ArrayList listE()
        {
            return this.list;
        }

        public void remplissage(ListView l, String nom, String moyen)
        {
            ColumnHeader headerNom = new ColumnHeader();
            ColumnHeader headerMoyen = new ColumnHeader();
            headerNom.Text = "Nom etudiant";
            headerNom.Width = 250;
            headerNom.TextAlign = HorizontalAlignment.Center;
            headerMoyen.Text = "Moyen etudiant";
            headerMoyen.Width = 250;
            headerMoyen.TextAlign = HorizontalAlignment.Center;
            l.Columns.Add(headerNom);
            l.Columns.Add(headerMoyen);
            l.View = View.Details;
            string[] row = { nom, moyen };
            var listViewItem = new ListViewItem(row);
            l.Items.Add(listViewItem);
        }

    }
}
