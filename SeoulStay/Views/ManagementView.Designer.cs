namespace SeoulStay.Views
{
    partial class ManagementView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementView));
            pictureBox1 = new PictureBox();
            controlTab = new TabControl();
            travelerTab = new TabPage();
            ownerTab = new TabPage();
            panel1 = new Panel();
            foundItemsLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            controlTab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // controlTab
            // 
            controlTab.Controls.Add(travelerTab);
            controlTab.Controls.Add(ownerTab);
            controlTab.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlTab.Location = new Point(20, 214);
            controlTab.Name = "controlTab";
            controlTab.SelectedIndex = 0;
            controlTab.Size = new Size(940, 371);
            controlTab.TabIndex = 2;
            controlTab.Selecting += controlTab_Selecting;
            // 
            // travelerTab
            // 
            travelerTab.BorderStyle = BorderStyle.FixedSingle;
            travelerTab.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            travelerTab.Location = new Point(4, 39);
            travelerTab.Name = "travelerTab";
            travelerTab.Size = new Size(932, 328);
            travelerTab.TabIndex = 0;
            travelerTab.Text = "I'm Traveler";
            travelerTab.UseVisualStyleBackColor = true;
            // 
            // ownerTab
            // 
            ownerTab.BorderStyle = BorderStyle.FixedSingle;
            ownerTab.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ownerTab.Location = new Point(4, 39);
            ownerTab.Name = "ownerTab";
            ownerTab.Size = new Size(932, 328);
            ownerTab.TabIndex = 1;
            ownerTab.Text = "I'm Owner / Manager";
            ownerTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(foundItemsLbl);
            panel1.Location = new Point(0, 601);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 29);
            panel1.TabIndex = 3;
            // 
            // foundItemsLbl
            // 
            foundItemsLbl.AutoSize = true;
            foundItemsLbl.Font = new Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foundItemsLbl.Location = new Point(6, 3);
            foundItemsLbl.Name = "foundItemsLbl";
            foundItemsLbl.Size = new Size(73, 23);
            foundItemsLbl.TabIndex = 0;
            foundItemsLbl.Text = "label1";
            // 
            // ManagementView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(controlTab);
            Controls.Add(pictureBox1);
            Name = "ManagementView";
            Size = new Size(980, 630);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            controlTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl controlTab;
        private TabPage travelerTab;
        private TabPage ownerTab;
        private Panel panel1;
        private Label foundItemsLbl;
    }
}
