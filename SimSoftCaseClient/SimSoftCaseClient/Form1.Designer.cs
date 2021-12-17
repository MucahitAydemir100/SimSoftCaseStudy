
namespace SimSoftCaseClient
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.ConnectionButton = new System.Windows.Forms.Button();
			this.IpTextField = new System.Windows.Forms.TextBox();
			this.PortTextField = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// ConnectionButton
			// 
			this.ConnectionButton.Location = new System.Drawing.Point(285, 45);
			this.ConnectionButton.Name = "ConnectionButton";
			this.ConnectionButton.Size = new System.Drawing.Size(75, 23);
			this.ConnectionButton.TabIndex = 0;
			this.ConnectionButton.Text = "Connect";
			this.ConnectionButton.UseVisualStyleBackColor = true;
			this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
			// 
			// IpTextField
			// 
			this.IpTextField.Location = new System.Drawing.Point(13, 46);
			this.IpTextField.Name = "IpTextField";
			this.IpTextField.Size = new System.Drawing.Size(121, 20);
			this.IpTextField.TabIndex = 1;
			// 
			// PortTextField
			// 
			this.PortTextField.Location = new System.Drawing.Point(149, 46);
			this.PortTextField.Name = "PortTextField";
			this.PortTextField.Size = new System.Drawing.Size(121, 20);
			this.PortTextField.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(202, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(285, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Disconnect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 131);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PortTextField);
			this.Controls.Add(this.IpTextField);
			this.Controls.Add(this.ConnectionButton);
			this.Name = "Form1";
			this.Text = "Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ConnectionButton;
		private System.Windows.Forms.TextBox IpTextField;
		private System.Windows.Forms.TextBox PortTextField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

