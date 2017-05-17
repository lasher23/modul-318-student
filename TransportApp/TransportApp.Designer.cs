namespace TransportApp
{
    partial class TransportApp
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSearchConnections = new System.Windows.Forms.TabPage();
            this.tabDepartureBoard = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSearchConnections);
            this.tabMain.Controls.Add(this.tabDepartureBoard);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(570, 399);
            this.tabMain.TabIndex = 0;
            // 
            // tabSearchConnections
            // 
            this.tabSearchConnections.Location = new System.Drawing.Point(4, 22);
            this.tabSearchConnections.Name = "tabSearchConnections";
            this.tabSearchConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchConnections.Size = new System.Drawing.Size(562, 373);
            this.tabSearchConnections.TabIndex = 0;
            this.tabSearchConnections.Text = "Verbindung Finden";
            this.tabSearchConnections.UseVisualStyleBackColor = true;
            // 
            // tabDepartureBoard
            // 
            this.tabDepartureBoard.Location = new System.Drawing.Point(4, 22);
            this.tabDepartureBoard.Name = "tabDepartureBoard";
            this.tabDepartureBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartureBoard.Size = new System.Drawing.Size(562, 373);
            this.tabDepartureBoard.TabIndex = 1;
            this.tabDepartureBoard.Text = "Abfahrtstafel";
            this.tabDepartureBoard.UseVisualStyleBackColor = true;
            // 
            // TransportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 423);
            this.Controls.Add(this.tabMain);
            this.Name = "TransportApp";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSearchConnections;
        private System.Windows.Forms.TabPage tabDepartureBoard;
    }
}

