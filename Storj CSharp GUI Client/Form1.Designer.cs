namespace Storj_CSharp_GUI_Client
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this.txtNodeID = new System.Windows.Forms.TextBox();
			this.btnNodeInfo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNodeID
			// 
			this.txtNodeID.Location = new System.Drawing.Point(71, 66);
			this.txtNodeID.Name = "txtNodeID";
			this.txtNodeID.Size = new System.Drawing.Size(170, 20);
			this.txtNodeID.TabIndex = 0;
			this.txtNodeID.Text = "8bcd2636cc4c3799ba4e2e86f45e89bc7ffe05ca";
			// 
			// btnNodeInfo
			// 
			this.btnNodeInfo.Location = new System.Drawing.Point(122, 117);
			this.btnNodeInfo.Name = "btnNodeInfo";
			this.btnNodeInfo.Size = new System.Drawing.Size(127, 28);
			this.btnNodeInfo.TabIndex = 1;
			this.btnNodeInfo.Text = "Get Node Info";
			this.btnNodeInfo.UseVisualStyleBackColor = true;
			this.btnNodeInfo.Click += new System.EventHandler(this.btnNodeInfo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnNodeInfo);
			this.Controls.Add(this.txtNodeID);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNodeID;
		private System.Windows.Forms.Button btnNodeInfo;
	}
}

