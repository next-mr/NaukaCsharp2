using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaukaCsharp2
{
    public partial class NaukaC2 : Form
    {
        public NaukaC2()
        {
            InitializeComponent();
        }

        //przesuwanie okna po ekranie bez belki dla okna
        //przesuwanie okna po ekranie bez belki dla okna
        bool dragging = false;
        int xOffset = 0;
        int yOffset = 0;
        private void NaukaC2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            xOffset = Cursor.Position.X - Location.X;
            yOffset = Cursor.Position.Y - Location.Y;
        }
        private void NaukaC2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Location = new Point(Cursor.Position.X - xOffset, Cursor.Position.Y - yOffset);
                Update();
            }
        }
        private void NaukaC2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void NaukaC2_Load(object sender, EventArgs e)
        {
            //załaduj na start

        }

        private void List_Click(object sender, EventArgs e)
        {
            Lista.Clear();
            List<Auto> lista1 = new List<Auto>();
            lista1.Add(new Auto("BMW1", "1500 cm3"));
            lista1.Add(new Auto("BMW2", "2000 cm3"));
            lista1.Add(new Auto("BMW3", "3000 cm3"));
            //metody ... remove, sort, reverse, clear i inne jak najbardziej mozzna stosować

            foreach (var pozycja in lista1)
            {
                Lista.AppendText(pozycja.Nazwa + " ");
                Lista.AppendText(pozycja.Pojemnosc + Environment.NewLine);
            }

            Lista.AppendText("RAZEM : " + lista1.Count.ToString());
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        class Auto
        {
            public string Nazwa { get; set; }
            public string Pojemnosc { get; set; }
            public Auto(string marka, string silnik)
            {
                Nazwa = marka;
                Pojemnosc = silnik;
            }
        }

        private void WczytajDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> slwonik1 = new Dictionary<int, string>();
            slwonik1.Add(1, "Marcin");
            slwonik1.Add(2, "Edek");
            slwonik1.Add(3, "Bożena");
            slwonik1.Add(4, "Maciek");
            //int - jako ID - nie moze sie powtarzać i nie musi być int moze byc string i tak samo nie moze sie powtarzac...
            //metody ... remove, sort, reverse, clear i inne jak najbardziej mozzna stosować
            foreach (var pozycja in slwonik1)
            {
                DictionaryLista.AppendText(pozycja.Key + " ");
                DictionaryLista.AppendText(pozycja.Value + Environment.NewLine);
            }

            DictionaryLista.AppendText("RAZEM : " + slwonik1.Count.ToString());
        }

        private void WczytajQueue_Click(object sender, EventArgs e)
        {
            KolejkaTworzenie();
        }

        private void OdczytajQueue_Click(object sender, EventArgs e)
        {
            //kolejka1.Dequeue();
            //na teraz kasowanie pierwszego elementu jest niewykonalne - brak wiedzy.... :-(
        }

        private void KolejkaTworzenie ()
        {
            Queue<string> kolejka1 = new Queue<string>();
            kolejka1.Enqueue("1");
            kolejka1.Enqueue("2");
            kolejka1.Enqueue("3");
            kolejka1.Enqueue("4");
            kolejka1.Enqueue("Ala ma kota");
            kolejka1.Enqueue("Marcin - koniec kolejnki");
            //typ int, string....
            foreach (var pozycja in kolejka1)
            {
                QueueLista.AppendText(pozycja + ", ");
            }
        }
    }
}
