namespace WorldOfFilesEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WorldCreatorTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoadWorldButton = new System.Windows.Forms.Button();
            this.SaveWorldButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.DesciptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPlaceButton = new System.Windows.Forms.Button();
            this.PlacesList = new System.Windows.Forms.ListBox();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.TranslatorTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LoadLangaugeButton = new System.Windows.Forms.Button();
            this.SaveLanguageButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.KeyListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TranslatedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.idLabelLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.WorldCreatorTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TranslatorTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WorldCreatorTab);
            this.tabControl1.Controls.Add(this.TranslatorTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 537);
            this.tabControl1.TabIndex = 1;
            // 
            // WorldCreatorTab
            // 
            this.WorldCreatorTab.Controls.Add(this.panel3);
            this.WorldCreatorTab.Controls.Add(this.panel2);
            this.WorldCreatorTab.Controls.Add(this.panel1);
            this.WorldCreatorTab.Location = new System.Drawing.Point(4, 22);
            this.WorldCreatorTab.Name = "WorldCreatorTab";
            this.WorldCreatorTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorldCreatorTab.Size = new System.Drawing.Size(752, 511);
            this.WorldCreatorTab.TabIndex = 0;
            this.WorldCreatorTab.Text = "World Creator";
            this.WorldCreatorTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LoadWorldButton);
            this.panel3.Controls.Add(this.SaveWorldButton);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 62);
            this.panel3.TabIndex = 3;
            // 
            // LoadWorldButton
            // 
            this.LoadWorldButton.Location = new System.Drawing.Point(128, 3);
            this.LoadWorldButton.Name = "LoadWorldButton";
            this.LoadWorldButton.Size = new System.Drawing.Size(136, 52);
            this.LoadWorldButton.TabIndex = 1;
            this.LoadWorldButton.Text = "Load World";
            this.LoadWorldButton.UseVisualStyleBackColor = true;
            this.LoadWorldButton.Click += new System.EventHandler(this.LoadWorldButton_Click);
            // 
            // SaveWorldButton
            // 
            this.SaveWorldButton.Location = new System.Drawing.Point(0, 3);
            this.SaveWorldButton.Name = "SaveWorldButton";
            this.SaveWorldButton.Size = new System.Drawing.Size(122, 52);
            this.SaveWorldButton.TabIndex = 0;
            this.SaveWorldButton.Text = "Save World";
            this.SaveWorldButton.UseVisualStyleBackColor = true;
            this.SaveWorldButton.Click += new System.EventHandler(this.SaveWorldButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.idLabelLabel);
            this.panel2.Controls.Add(this.numericUpDown5);
            this.panel2.Controls.Add(this.numericUpDown4);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.placeNameTextBox);
            this.panel2.Controls.Add(this.DesciptionRichTextBox);
            this.panel2.Location = new System.Drawing.Point(273, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 505);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Connections";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.Location = new System.Drawing.Point(0, 20);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(470, 20);
            this.placeNameTextBox.TabIndex = 5;
            this.placeNameTextBox.TextChanged += new System.EventHandler(this.placeNameTextBox_TextChanged);
            // 
            // DesciptionRichTextBox
            // 
            this.DesciptionRichTextBox.Location = new System.Drawing.Point(3, 128);
            this.DesciptionRichTextBox.Name = "DesciptionRichTextBox";
            this.DesciptionRichTextBox.Size = new System.Drawing.Size(470, 374);
            this.DesciptionRichTextBox.TabIndex = 0;
            this.DesciptionRichTextBox.Text = "";
            this.DesciptionRichTextBox.TextChanged += new System.EventHandler(this.DesciptionRichTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPlaceButton);
            this.panel1.Controls.Add(this.PlacesList);
            this.panel1.Controls.Add(this.RemoveSelectedButton);
            this.panel1.Location = new System.Drawing.Point(3, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 437);
            this.panel1.TabIndex = 1;
            // 
            // AddPlaceButton
            // 
            this.AddPlaceButton.Location = new System.Drawing.Point(0, 4);
            this.AddPlaceButton.Name = "AddPlaceButton";
            this.AddPlaceButton.Size = new System.Drawing.Size(122, 23);
            this.AddPlaceButton.TabIndex = 1;
            this.AddPlaceButton.Text = "Create new Place";
            this.AddPlaceButton.UseVisualStyleBackColor = true;
            this.AddPlaceButton.Click += new System.EventHandler(this.AddPlaceButton_Click);
            // 
            // PlacesList
            // 
            this.PlacesList.FormattingEnabled = true;
            this.PlacesList.Location = new System.Drawing.Point(0, 29);
            this.PlacesList.Name = "PlacesList";
            this.PlacesList.Size = new System.Drawing.Size(264, 407);
            this.PlacesList.TabIndex = 0;
            this.PlacesList.SelectedIndexChanged += new System.EventHandler(this.PlacesList_SelectedIndexChanged);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(128, 4);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(136, 23);
            this.RemoveSelectedButton.TabIndex = 2;
            this.RemoveSelectedButton.Text = "Remove";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // TranslatorTab
            // 
            this.TranslatorTab.Controls.Add(this.panel4);
            this.TranslatorTab.Controls.Add(this.panel6);
            this.TranslatorTab.Controls.Add(this.panel5);
            this.TranslatorTab.Location = new System.Drawing.Point(4, 22);
            this.TranslatorTab.Name = "TranslatorTab";
            this.TranslatorTab.Padding = new System.Windows.Forms.Padding(3);
            this.TranslatorTab.Size = new System.Drawing.Size(752, 511);
            this.TranslatorTab.TabIndex = 1;
            this.TranslatorTab.Text = "Translator";
            this.TranslatorTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LoadLangaugeButton);
            this.panel4.Controls.Add(this.SaveLanguageButton);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 50);
            this.panel4.TabIndex = 4;
            // 
            // LoadLangaugeButton
            // 
            this.LoadLangaugeButton.Location = new System.Drawing.Point(120, 3);
            this.LoadLangaugeButton.Name = "LoadLangaugeButton";
            this.LoadLangaugeButton.Size = new System.Drawing.Size(117, 44);
            this.LoadLangaugeButton.TabIndex = 1;
            this.LoadLangaugeButton.Text = "Load Language";
            this.LoadLangaugeButton.UseVisualStyleBackColor = true;
            this.LoadLangaugeButton.Click += new System.EventHandler(this.LoadLangaugeButton_Click);
            // 
            // SaveLanguageButton
            // 
            this.SaveLanguageButton.Location = new System.Drawing.Point(0, 3);
            this.SaveLanguageButton.Name = "SaveLanguageButton";
            this.SaveLanguageButton.Size = new System.Drawing.Size(114, 44);
            this.SaveLanguageButton.TabIndex = 0;
            this.SaveLanguageButton.Text = "Save Language";
            this.SaveLanguageButton.UseVisualStyleBackColor = true;
            this.SaveLanguageButton.Click += new System.EventHandler(this.SaveLanguageButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.KeyListBox);
            this.panel6.Location = new System.Drawing.Point(3, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 452);
            this.panel6.TabIndex = 2;
            // 
            // KeyListBox
            // 
            this.KeyListBox.FormattingEnabled = true;
            this.KeyListBox.Items.AddRange(new object[] {
            "NEW_BUTTON",
            "LOAD_BUTTON",
            "LANGUAGE_BUTTON",
            "EXIT_BUTTON",
            "MENU_BUTTON",
            "ARRIVED_TEXT",
            "WHERETO_TEXT"});
            this.KeyListBox.Location = new System.Drawing.Point(3, 29);
            this.KeyListBox.Name = "KeyListBox";
            this.KeyListBox.Size = new System.Drawing.Size(234, 420);
            this.KeyListBox.TabIndex = 0;
            this.KeyListBox.SelectedIndexChanged += new System.EventHandler(this.KeyListBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.TranslatedRichTextBox);
            this.panel5.Location = new System.Drawing.Point(242, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(507, 505);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Translated Values";
            // 
            // TranslatedRichTextBox
            // 
            this.TranslatedRichTextBox.Location = new System.Drawing.Point(7, 82);
            this.TranslatedRichTextBox.Name = "TranslatedRichTextBox";
            this.TranslatedRichTextBox.Size = new System.Drawing.Size(497, 420);
            this.TranslatedRichTextBox.TabIndex = 0;
            this.TranslatedRichTextBox.Text = "";
            this.TranslatedRichTextBox.TextChanged += new System.EventHandler(this.TranslatedRichTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Key List";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(4, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(72, 72);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(140, 72);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(208, 72);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown4.TabIndex = 13;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(276, 72);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown5.TabIndex = 14;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // idLabelLabel
            // 
            this.idLabelLabel.AutoSize = true;
            this.idLabelLabel.Location = new System.Drawing.Point(411, 52);
            this.idLabelLabel.Name = "idLabelLabel";
            this.idLabelLabel.Size = new System.Drawing.Size(48, 13);
            this.idLabelLabel.TabIndex = 15;
            this.idLabelLabel.Text = "Place ID";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(425, 74);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.WorldCreatorTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TranslatorTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WorldCreatorTab;
        private System.Windows.Forms.TabPage TranslatorTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LoadWorldButton;
        private System.Windows.Forms.Button SaveWorldButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.RichTextBox DesciptionRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddPlaceButton;
        private System.Windows.Forms.ListBox PlacesList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button LoadLangaugeButton;
        private System.Windows.Forms.Button SaveLanguageButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox KeyListBox;
        private System.Windows.Forms.RichTextBox TranslatedRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idLabelLabel;
    }
}

