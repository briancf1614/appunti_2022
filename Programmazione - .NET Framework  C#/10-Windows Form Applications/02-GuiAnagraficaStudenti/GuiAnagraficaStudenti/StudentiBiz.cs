using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAnagraficaStudenti
{
    class StudentiBiz
    {
        public List<Studente> Elenco { get; set; }

        private string path = @"C:\Files\Studenti.csv";

        public StudentiBiz()
        {
            Elenco = MyLibrary.LeggiFileStudenti(path);
        }

        public List<Studente> ElencoPerClasse(string classe)
        {
            return Elenco.Where(x => x.Classe == classe).ToList();
        }

        public Studente CercaPerMatricola(int matricola) {
            return Elenco.Where(x => x.Matricola == matricola).FirstOrDefault();
        }

        public void Nuovo(Studente studente) {
            Elenco.Add(studente);            
        }

        public void Modifica(Studente studente)
        {
            int pos = Elenco.FindIndex(x => x.Matricola == studente.Matricola);
            Elenco.RemoveAt(pos);
            Elenco.Insert(pos, studente);
        }

        public bool Elimina(Studente studente)
        {
            return Elenco.Remove(studente);
        }

        public void SalvaTuttoEChiudi()
        {
            MyLibrary.ScriviFileStudenti(path, Elenco);
        }
        

    }
}
