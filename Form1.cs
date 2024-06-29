using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EAC2_Exercici3
{
    public partial class Form1 : Form
    {
        private readonly string fitxerRutes = "Rutes.txt";
        private readonly GestorRuta gestorRuta;
        private double vot = 0;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            gestorRuta = new GestorRuta(fitxerRutes);
            listViewRutes.View = View.Details;
            listViewRutes.Columns.Add("Seleccioneu una ruta", 300);
            MostrarRutes();
        }
        public void MostrarRutes()
        {
            List<Ruta> rutes = gestorRuta.LlegirRutes();
            foreach (var ruta in rutes)
            {
                listViewRutes.Items.Add(ruta.Nom);
            }
        }
        public void MostrarDetallsRuta(int index)
        {
            List<Ruta> rutes = gestorRuta.LlegirRutes();
            var ruta = rutes[index];
            labelNomRuta.Text = ruta.Nom;
            labelTipus.Text = "Tipus: " + ruta.Tipus;
            labelDistancia.Text = "Distància: " + ruta.Distancia + " km";
            labelDificultat.Text = "Dificultat: " + ruta.Dificultat;
            labelDuracio.Text = "Duració: " + ruta.Duracio;
            textBoxDescripcio.Text = ruta.Descripcio;
            pictureBoxRuta.Image = Image.FromFile(Path.Combine(Application.StartupPath, ruta.RutaImatge));
            MostrarTotalPuntuacio(index);
        }
        private void MostrarTotalPuntuacio(int Index)
        {
            List<Ruta> rutes = gestorRuta.LlegirRutes();
            Ruta ruta = rutes[Index];
            double mitjanaPunts = 0;
            mitjanaPunts = ruta.NumVotacions > 0 ? ruta.Puntuacio / ruta.NumVotacions : 0;
            labelTotalPuntuacio.Text = "Total de Puntuació: " + mitjanaPunts.ToString("0.00");
        }
        private void buttonVota_Click(object sender, EventArgs e)
        {
            if (vot != 0)
            {
                int Index = listViewRutes.SelectedIndices[0];
                gestorRuta.ActualitzarVotacions(Index, vot);
                MostrarTotalPuntuacio(Index);
                vot = 0;
                comboBoxPuntuacio.Text = "0";
            }
            else
            {
                MessageBox.Show("Si us plau, seleccioneu una puntuació", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxPuntuacio_SelectedIndexChanged(object sender, EventArgs e)
        {
            vot = double.Parse(comboBoxPuntuacio.Text);
        }

        private void listViewRutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRutes.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewRutes.SelectedIndices[0];
                MostrarDetallsRuta(selectedIndex);
            }
        }
    }

    public class GestorRuta
    {
        private readonly string fitxerRutes;

        public GestorRuta(string fitxerRutes)
        {
            this.fitxerRutes = fitxerRutes;
        }

        public List<Ruta> LlegirRutes()
        {
            List<Ruta> rutes = new List<Ruta>();

            using (StreamReader sr = new StreamReader(fitxerRutes))
            {
                string linia;
                while ((linia = sr.ReadLine()) != null)
                {
                    string[] camps = linia.Split(';');
                    Ruta ruta = new Ruta
                    {
                        Nom = camps[0],
                        Tipus = camps[1],
                        Distancia = Convert.ToDouble(camps[2]),
                        Dificultat = camps[3],
                        Descripcio = camps[4],
                        Puntuacio = Convert.ToDouble(camps[5]),
                        RutaImatge = camps[6],
                        Duracio = camps[7],
                        NumVotacions = Convert.ToDouble(camps[8])
                    };
                    rutes.Add(ruta);
                }
            }
            return rutes;
        }
        public void DesarRutes(List<Ruta> rutes)
        {
            using (StreamWriter sw = new StreamWriter(fitxerRutes))
            {
                foreach (var ruta in rutes)
                {
                    sw.WriteLine($"{ruta.Nom};{ruta.Tipus};{ruta.Distancia};{ruta.Dificultat};{ruta.Descripcio};{ruta.Puntuacio};{ruta.RutaImatge};{ruta.Duracio};{ruta.NumVotacions}");
                }
            }
        }
        public void ActualitzarVotacions(int index, double novaPuntuacio)
        {
            List<Ruta> rutes = LlegirRutes();
            Ruta ruta = rutes[index];
            ruta.NumVotacions++;
            ruta.Puntuacio += novaPuntuacio;
            DesarRutes(rutes);
        }
    }

    public class Ruta
    {
        public string Nom { get; set; }
        public string Tipus { get; set; }
        public double Distancia { get; set; }
        public string Dificultat { get; set; }
        public string Descripcio { get; set; }
        public double Puntuacio { get; set; }
        public string RutaImatge { get; set; }
        public string Duracio { get; set; }
        public double NumVotacions { get; set; }
    }
}