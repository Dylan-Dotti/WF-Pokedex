namespace WF_Pokedex
{
    partial class PokedexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchAndSelectionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.nameSelectionBox = new System.Windows.Forms.ListBox();
            this.pokemonInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pokemonInfoRightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.genusLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spriteImageBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.searchAndSelectionPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.pokemonInfoPanel.SuspendLayout();
            this.pokemonInfoRightPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImageBox)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainLayoutPanel.Controls.Add(this.searchAndSelectionPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.pokemonInfoPanel, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(698, 391);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // searchAndSelectionPanel
            // 
            this.searchAndSelectionPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.searchAndSelectionPanel.ColumnCount = 1;
            this.searchAndSelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchAndSelectionPanel.Controls.Add(this.searchPanel, 0, 0);
            this.searchAndSelectionPanel.Controls.Add(this.nameSelectionBox, 0, 1);
            this.searchAndSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAndSelectionPanel.Location = new System.Drawing.Point(2, 2);
            this.searchAndSelectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchAndSelectionPanel.Name = "searchAndSelectionPanel";
            this.searchAndSelectionPanel.RowCount = 2;
            this.searchAndSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchAndSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.searchAndSelectionPanel.Size = new System.Drawing.Size(170, 387);
            this.searchAndSelectionPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.ColumnCount = 1;
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.searchPanel.Controls.Add(this.nameSearchBox, 0, 0);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(5, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RowCount = 1;
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.Size = new System.Drawing.Size(160, 32);
            this.searchPanel.TabIndex = 0;
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchBox.Location = new System.Drawing.Point(3, 3);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.Size = new System.Drawing.Size(154, 30);
            this.nameSearchBox.TabIndex = 0;
            // 
            // nameSelectionBox
            // 
            this.nameSelectionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameSelectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSelectionBox.FormattingEnabled = true;
            this.nameSelectionBox.ItemHeight = 20;
            this.nameSelectionBox.Location = new System.Drawing.Point(5, 45);
            this.nameSelectionBox.Name = "nameSelectionBox";
            this.nameSelectionBox.Size = new System.Drawing.Size(160, 337);
            this.nameSelectionBox.TabIndex = 1;
            // 
            // pokemonInfoPanel
            // 
            this.pokemonInfoPanel.ColumnCount = 2;
            this.pokemonInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pokemonInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pokemonInfoPanel.Controls.Add(this.pokemonInfoRightPanel, 0, 0);
            this.pokemonInfoPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.pokemonInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonInfoPanel.Location = new System.Drawing.Point(177, 3);
            this.pokemonInfoPanel.Name = "pokemonInfoPanel";
            this.pokemonInfoPanel.RowCount = 1;
            this.pokemonInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pokemonInfoPanel.Size = new System.Drawing.Size(518, 385);
            this.pokemonInfoPanel.TabIndex = 1;
            // 
            // pokemonInfoRightPanel
            // 
            this.pokemonInfoRightPanel.AutoSize = true;
            this.pokemonInfoRightPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pokemonInfoRightPanel.ColumnCount = 1;
            this.pokemonInfoRightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pokemonInfoRightPanel.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.pokemonInfoRightPanel.Controls.Add(this.panel1, 0, 1);
            this.pokemonInfoRightPanel.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.pokemonInfoRightPanel.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.pokemonInfoRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonInfoRightPanel.Location = new System.Drawing.Point(3, 3);
            this.pokemonInfoRightPanel.Name = "pokemonInfoRightPanel";
            this.pokemonInfoRightPanel.RowCount = 5;
            this.pokemonInfoRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pokemonInfoRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pokemonInfoRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pokemonInfoRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pokemonInfoRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pokemonInfoRightPanel.Size = new System.Drawing.Size(253, 379);
            this.pokemonInfoRightPanel.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.genusLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.nameLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(253, 63);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // genusLabel
            // 
            this.genusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genusLabel.AutoSize = true;
            this.genusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genusLabel.Location = new System.Drawing.Point(109, 42);
            this.genusLabel.Margin = new System.Windows.Forms.Padding(5);
            this.genusLabel.Name = "genusLabel";
            this.genusLabel.Size = new System.Drawing.Size(96, 15);
            this.genusLabel.TabIndex = 7;
            this.genusLabel.Text = "PokemonGenus";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(85, 6);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 25);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Pokemonname";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(1, 19);
            this.idLabel.Margin = new System.Windows.Forms.Padding(0);
            this.idLabel.Name = "idLabel";
            this.tableLayoutPanel4.SetRowSpan(this.idLabel, 2);
            this.idLabel.Size = new System.Drawing.Size(60, 25);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "#000";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.spriteImageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 199);
            this.panel1.TabIndex = 1;
            // 
            // spriteImageBox
            // 
            this.spriteImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spriteImageBox.Location = new System.Drawing.Point(28, -3);
            this.spriteImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.spriteImageBox.Name = "spriteImageBox";
            this.spriteImageBox.Size = new System.Drawing.Size(200, 200);
            this.spriteImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spriteImageBox.TabIndex = 0;
            this.spriteImageBox.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.typeLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 262);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(253, 57);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.typeLabel, 2);
            this.typeLabel.Location = new System.Drawing.Point(67, 29);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Padding = new System.Windows.Forms.Padding(5);
            this.typeLabel.Size = new System.Drawing.Size(118, 27);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type 1 / Type 2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.heightLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.weightLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 319);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(253, 53);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightLabel.Location = new System.Drawing.Point(4, 27);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(119, 25);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "2.00 kg";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightLabel.Location = new System.Drawing.Point(130, 27);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(119, 25);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "1.04 m";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Height";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Weight";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(262, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 379);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(88, 42);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(77, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "description";
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 391);
            this.Controls.Add(this.mainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PokedexForm";
            this.ShowIcon = false;
            this.Text = "WF Pokedex";
            this.mainLayoutPanel.ResumeLayout(false);
            this.searchAndSelectionPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.pokemonInfoPanel.ResumeLayout(false);
            this.pokemonInfoPanel.PerformLayout();
            this.pokemonInfoRightPanel.ResumeLayout(false);
            this.pokemonInfoRightPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spriteImageBox)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel searchAndSelectionPanel;
        private System.Windows.Forms.TableLayoutPanel searchPanel;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.ListBox nameSelectionBox;
        private System.Windows.Forms.TableLayoutPanel pokemonInfoPanel;
        private System.Windows.Forms.TableLayoutPanel pokemonInfoRightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label genusLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox spriteImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descriptionLabel;
    }
}

