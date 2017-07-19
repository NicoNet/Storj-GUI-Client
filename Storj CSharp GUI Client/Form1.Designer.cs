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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCreateUser = new System.Windows.Forms.Button();
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
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(71, 182);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(133, 20);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(71, 217);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(133, 20);
			this.txtPassword.TabIndex = 4;
			// 
			// btnCreateUser
			// 
			this.btnCreateUser.Location = new System.Drawing.Point(123, 244);
			this.btnCreateUser.Name = "btnCreateUser";
			this.btnCreateUser.Size = new System.Drawing.Size(139, 52);
			this.btnCreateUser.TabIndex = 6;
			this.btnCreateUser.Text = "Create User";
			this.btnCreateUser.UseVisualStyleBackColor = true;
			this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 314);
			this.Controls.Add(this.btnCreateUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEmail);
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
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnCreateUser;
	}
}

