namespace Sockets.client
{
    partial class Client
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
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEnviarMsg = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtFormServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 182);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(460, 54);
            this.txtMsg.TabIndex = 0;
            // 
            // btnEnviarMsg
            // 
            this.btnEnviarMsg.Location = new System.Drawing.Point(243, 242);
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.Size = new System.Drawing.Size(229, 23);
            this.btnEnviarMsg.TabIndex = 1;
            this.btnEnviarMsg.Text = "Enviar mensagem para o servidor";
            this.btnEnviarMsg.UseVisualStyleBackColor = true;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 2;
            // 
            // txtFormServer
            // 
            this.txtFormServer.Location = new System.Drawing.Point(10, 65);
            this.txtFormServer.Multiline = true;
            this.txtFormServer.Name = "txtFormServer";
            this.txtFormServer.Size = new System.Drawing.Size(460, 54);
            this.txtFormServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informações do server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite uma mensagem para enviar ao servidor";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormServer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEnviarMsg);
            this.Controls.Add(this.txtMsg);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnEnviarMsg;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtFormServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

