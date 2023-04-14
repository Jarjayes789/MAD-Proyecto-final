namespace MAD___PF_Hotel
{
    partial class OperatorForm
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlOperatorSystemChild = new System.Windows.Forms.Panel();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.AutoScroll = true;
            this.pnlMainMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlMainMenu.Controls.Add(this.btnAddReservation);
            this.pnlMainMenu.Controls.Add(this.btnAddClient);
            this.pnlMainMenu.Controls.Add(this.pnlLogo);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 653);
            this.pnlMainMenu.TabIndex = 1;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddReservation.FlatAppearance.BorderSize = 0;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnAddReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddReservation.Location = new System.Drawing.Point(0, 181);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddReservation.Size = new System.Drawing.Size(200, 50);
            this.btnAddReservation.TabIndex = 2;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnAddClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClient.Location = new System.Drawing.Point(0, 131);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddClient.Size = new System.Drawing.Size(200, 50);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 131);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlOperatorSystemChild
            // 
            this.pnlOperatorSystemChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnlOperatorSystemChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperatorSystemChild.Location = new System.Drawing.Point(200, 0);
            this.pnlOperatorSystemChild.Name = "pnlOperatorSystemChild";
            this.pnlOperatorSystemChild.Size = new System.Drawing.Size(982, 653);
            this.pnlOperatorSystemChild.TabIndex = 2;
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlOperatorSystemChild);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "OperatorForm";
            this.Text = "Quetzal Travels - Operator Menu";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlOperatorSystemChild;
    }
}