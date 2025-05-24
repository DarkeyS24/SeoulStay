using System.Windows.Forms.PropertyGridInternal;

namespace SeoulStay.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pswdCb = new CheckBox();
            keepCb = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pswdTxt = new TextBox();
            userTxt = new TextBox();
            empTxt = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            managementView1 = new ManagementView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pswdCb);
            panel1.Controls.Add(keepCb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pswdTxt);
            panel1.Controls.Add(userTxt);
            panel1.Controls.Add(empTxt);
            panel1.Location = new Point(53, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 285);
            panel1.TabIndex = 1;
            // 
            // pswdCb
            // 
            pswdCb.AutoSize = true;
            pswdCb.Font = new Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pswdCb.Location = new Point(593, 168);
            pswdCb.Name = "pswdCb";
            pswdCb.Size = new Size(202, 27);
            pswdCb.TabIndex = 7;
            pswdCb.Text = "Show Password";
            pswdCb.UseVisualStyleBackColor = true;
            pswdCb.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // keepCb
            // 
            keepCb.AutoSize = true;
            keepCb.Font = new Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            keepCb.Location = new Point(593, 100);
            keepCb.Name = "keepCb";
            keepCb.Size = new Size(234, 27);
            keepCb.TabIndex = 6;
            keepCb.Text = "Keep me signed in";
            keepCb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 200);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 131);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 4;
            label3.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 63);
            label2.Name = "label2";
            label2.Size = new Size(173, 31);
            label2.TabIndex = 3;
            label2.Text = "Employee:";
            // 
            // pswdTxt
            // 
            pswdTxt.BorderStyle = BorderStyle.FixedSingle;
            pswdTxt.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pswdTxt.Location = new Point(237, 198);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.PasswordChar = '●';
            pswdTxt.Size = new Size(301, 37);
            pswdTxt.TabIndex = 2;
            // 
            // userTxt
            // 
            userTxt.BorderStyle = BorderStyle.FixedSingle;
            userTxt.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(237, 131);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(301, 37);
            userTxt.TabIndex = 1;
            // 
            // empTxt
            // 
            empTxt.BorderStyle = BorderStyle.FixedSingle;
            empTxt.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empTxt.Location = new Point(237, 61);
            empTxt.Name = "empTxt";
            empTxt.Size = new Size(301, 37);
            empTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 196);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(291, 516);
            button1.Name = "button1";
            button1.Size = new Size(149, 46);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnClickToLogin;
            // 
            // button2
            // 
            button2.Font = new Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(513, 516);
            button2.Name = "button2";
            button2.Size = new Size(149, 46);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 574);
            label5.Name = "label5";
            label5.Size = new Size(254, 23);
            label5.TabIndex = 5;
            label5.Text = "Don't have an account";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(551, 574);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create one";
            // 
            // managementView1
            // 
            managementView1.BackColor = Color.White;
            managementView1.Location = new Point(2, -7);
            managementView1.Name = "managementView1";
            managementView1.Size = new Size(980, 637);
            managementView1.TabIndex = 7;
            managementView1.Load += LoadManagementView;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 623);
            Controls.Add(managementView1);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginView";
            Text = "Seoul Stay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox empTxt;
        private TextBox pswdTxt;
        private TextBox userTxt;
        private CheckBox pswdCb;
        private CheckBox keepCb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label5;
        private LinkLabel linkLabel1;
        private ManagementView managementView1;
    }
}