namespace Activite8DataSetType
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GrillePersonnes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPassions = new System.Windows.Forms.ListBox();
            this.buttonSupprimerPassion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAjouterPassion = new System.Windows.Forms.Button();
            this.comboBoxPassions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillePersonnes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner un nom pour connaitre ses passions";
            // 
            // GrillePersonnes
            // 
            this.GrillePersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillePersonnes.Location = new System.Drawing.Point(15, 58);
            this.GrillePersonnes.MultiSelect = false;
            this.GrillePersonnes.Name = "GrillePersonnes";
            this.GrillePersonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillePersonnes.Size = new System.Drawing.Size(415, 191);
            this.GrillePersonnes.TabIndex = 1;
            this.GrillePersonnes.SelectionChanged += new System.EventHandler(this.GrillePersonnes_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passions";
            // 
            // listBoxPassions
            // 
            this.listBoxPassions.FormattingEnabled = true;
            this.listBoxPassions.Location = new System.Drawing.Point(456, 61);
            this.listBoxPassions.Name = "listBoxPassions";
            this.listBoxPassions.Size = new System.Drawing.Size(224, 147);
            this.listBoxPassions.TabIndex = 3;
            this.listBoxPassions.SelectedIndexChanged += new System.EventHandler(this.listBoxPassions_SelectedIndexChanged);
            // 
            // buttonSupprimerPassion
            // 
            this.buttonSupprimerPassion.Enabled = false;
            this.buttonSupprimerPassion.Location = new System.Drawing.Point(456, 226);
            this.buttonSupprimerPassion.Name = "buttonSupprimerPassion";
            this.buttonSupprimerPassion.Size = new System.Drawing.Size(224, 23);
            this.buttonSupprimerPassion.TabIndex = 4;
            this.buttonSupprimerPassion.Text = "Supprimer passion";
            this.buttonSupprimerPassion.UseVisualStyleBackColor = true;
            this.buttonSupprimerPassion.Click += new System.EventHandler(this.buttonSupprimerPassion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAjouterPassion);
            this.groupBox1.Controls.Add(this.comboBoxPassions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout d\'une passion pour la personne";
            // 
            // buttonAjouterPassion
            // 
            this.buttonAjouterPassion.Location = new System.Drawing.Point(432, 36);
            this.buttonAjouterPassion.Name = "buttonAjouterPassion";
            this.buttonAjouterPassion.Size = new System.Drawing.Size(214, 23);
            this.buttonAjouterPassion.TabIndex = 5;
            this.buttonAjouterPassion.Text = "Ajouter passion";
            this.buttonAjouterPassion.UseVisualStyleBackColor = true;
            this.buttonAjouterPassion.Click += new System.EventHandler(this.buttonAjouterPassion_Click);
            // 
            // comboBoxPassions
            // 
            this.comboBoxPassions.FormattingEnabled = true;
            this.comboBoxPassions.Location = new System.Drawing.Point(6, 38);
            this.comboBoxPassions.Name = "comboBoxPassions";
            this.comboBoxPassions.Size = new System.Drawing.Size(384, 21);
            this.comboBoxPassions.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSupprimerPassion);
            this.Controls.Add(this.listBoxPassions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrillePersonnes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillePersonnes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillePersonnes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPassions;
        private System.Windows.Forms.Button buttonSupprimerPassion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAjouterPassion;
        private System.Windows.Forms.ComboBox comboBoxPassions;
    }
}

