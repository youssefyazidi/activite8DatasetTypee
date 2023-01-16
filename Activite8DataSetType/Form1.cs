
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Activite8DataSetType.dsPassionsTableAdapters;
using static Activite8DataSetType.dsPassions;

namespace Activite8DataSetType
{
    public partial class Form1 : Form
    {

        private dsPassions dsp;
        PersonnesTableAdapter personnesAdapter;
        PassionsTableAdapter passionAdapter;
        PersPassTableAdapter persPassAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void initialisePersonnes()
        {
            personnesAdapter = new PersonnesTableAdapter();
            personnesAdapter.Fill(dsp.Personnes);
            GrillePersonnes.DataSource = dsp.Personnes;
        }

        private void initialisePassions()
        {
            passionAdapter = new PassionsTableAdapter();
            passionAdapter.Fill(dsp.Passions);
            comboBoxPassions.DataSource = dsp.Passions;
            comboBoxPassions.DisplayMember = "Passion";
        }

        private void initialisePersPass()
        {
            persPassAdapter = new PersPassTableAdapter();
            persPassAdapter.Fill(dsp.PersPass);
            afficherPassion(0);
        }

        private void afficherPassion(int indexNom)
        {
            listBoxPassions.Items.Clear();
            //Les DataRelations

            DataRelation RPersonnePersPAss = 
                dsp.Relations["FK__PersPass__IndexN__3B75D760"];
            DataRelation RPassionPersPAss =
               dsp.Relations["FK__PersPass__IndexP__3C69FB99"];
            //Les DataRow personnalisées
            PersonnesRow row =(PersonnesRow)dsp.Personnes.Rows[indexNom];

            PersPassRow[] enfants= (PersPassRow[])row.GetChildRows(RPersonnePersPAss);

            foreach (PersPassRow item in enfants)
            {
                PassionsRow rowparent=(PassionsRow)item.GetParentRow(RPassionPersPAss);
                listBoxPassions.Items.Add(rowparent.Passion);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creation DataSet
            dsp = new dsPassions();
            initialisePersonnes();
            initialisePassions();
            initialisePersPass();
        }

        private void GrillePersonnes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void GrillePersonnes_CurrentCellChanged(object sender, EventArgs e)
        {
          

        }

        private void GrillePersonnes_SelectionChanged(object sender, EventArgs e)
        {
            if (GrillePersonnes.SelectedRows.Count > 0)
            {
                int indice = GrillePersonnes.SelectedRows[0].Index;
                afficherPassion(indice);
            }
        }
    }
}
