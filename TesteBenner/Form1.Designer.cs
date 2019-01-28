namespace TesteBenner
{
	partial class Form1
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.quickStart = new System.Windows.Forms.Button();
			this.informacoes = new System.Windows.Forms.TextBox();
			this.newPower = new System.Windows.Forms.TextBox();
			this.adicionar = new System.Windows.Forms.Button();
			this.newInfo = new System.Windows.Forms.TextBox();
			this.newTime = new System.Windows.Forms.TextBox();
			this.newChar = new System.Windows.Forms.TextBox();
			this.Potência = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.newName = new System.Windows.Forms.TextBox();
			this.nome = new System.Windows.Forms.Label();
			this.preDefinido = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(73, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Aquecer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// quickStart
			// 
			this.quickStart.Location = new System.Drawing.Point(249, 62);
			this.quickStart.Name = "quickStart";
			this.quickStart.Size = new System.Drawing.Size(75, 23);
			this.quickStart.TabIndex = 6;
			this.quickStart.Text = "inicio rápido";
			this.quickStart.UseVisualStyleBackColor = true;
			this.quickStart.Click += new System.EventHandler(this.quickStart_Click);
			// 
			// informacoes
			// 
			this.informacoes.Location = new System.Drawing.Point(39, 36);
			this.informacoes.Name = "informacoes";
			this.informacoes.Size = new System.Drawing.Size(375, 20);
			this.informacoes.TabIndex = 7;
			this.informacoes.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// newPower
			// 
			this.newPower.Location = new System.Drawing.Point(24, 140);
			this.newPower.Name = "newPower";
			this.newPower.ShortcutsEnabled = false;
			this.newPower.Size = new System.Drawing.Size(100, 20);
			this.newPower.TabIndex = 8;
			this.newPower.TextChanged += new System.EventHandler(this.test_TextChanged);
			// 
			// adicionar
			// 
			this.adicionar.Location = new System.Drawing.Point(355, 183);
			this.adicionar.Name = "adicionar";
			this.adicionar.Size = new System.Drawing.Size(75, 23);
			this.adicionar.TabIndex = 9;
			this.adicionar.Text = "adicionar";
			this.adicionar.UseVisualStyleBackColor = true;
			this.adicionar.Click += new System.EventHandler(this.button2_Click);
			// 
			// newInfo
			// 
			this.newInfo.Location = new System.Drawing.Point(166, 185);
			this.newInfo.Name = "newInfo";
			this.newInfo.Size = new System.Drawing.Size(158, 20);
			this.newInfo.TabIndex = 10;
			this.newInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// newTime
			// 
			this.newTime.Location = new System.Drawing.Point(183, 140);
			this.newTime.Name = "newTime";
			this.newTime.Size = new System.Drawing.Size(100, 20);
			this.newTime.TabIndex = 11;
			// 
			// newChar
			// 
			this.newChar.Location = new System.Drawing.Point(330, 140);
			this.newChar.Name = "newChar";
			this.newChar.Size = new System.Drawing.Size(100, 20);
			this.newChar.TabIndex = 12;
			this.newChar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// Potência
			// 
			this.Potência.AutoSize = true;
			this.Potência.Location = new System.Drawing.Point(49, 124);
			this.Potência.Name = "Potência";
			this.Potência.Size = new System.Drawing.Size(49, 13);
			this.Potência.TabIndex = 13;
			this.Potência.Text = "Potência";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Tempo (em min, ex: 1.5)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(309, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "caractere para identificação";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(208, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "descrição";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(409, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Programar(formato: potencia, tempo (1 min e 30 = 1.5),  função pré-definida(opcio" +
    "nal))";
			// 
			// newName
			// 
			this.newName.Location = new System.Drawing.Point(24, 185);
			this.newName.Name = "newName";
			this.newName.Size = new System.Drawing.Size(100, 20);
			this.newName.TabIndex = 18;
			// 
			// nome
			// 
			this.nome.AutoSize = true;
			this.nome.Location = new System.Drawing.Point(52, 167);
			this.nome.Name = "nome";
			this.nome.Size = new System.Drawing.Size(33, 13);
			this.nome.TabIndex = 19;
			this.nome.Text = "nome";
			// 
			// preDefinido
			// 
			this.preDefinido.FormattingEnabled = true;
			this.preDefinido.Location = new System.Drawing.Point(24, 259);
			this.preDefinido.Name = "preDefinido";
			this.preDefinido.Size = new System.Drawing.Size(424, 82);
			this.preDefinido.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 243);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Funções pré-definidas";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 373);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.preDefinido);
			this.Controls.Add(this.nome);
			this.Controls.Add(this.newName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Potência);
			this.Controls.Add(this.newChar);
			this.Controls.Add(this.newTime);
			this.Controls.Add(this.newInfo);
			this.Controls.Add(this.adicionar);
			this.Controls.Add(this.newPower);
			this.Controls.Add(this.informacoes);
			this.Controls.Add(this.quickStart);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button quickStart;
		private System.Windows.Forms.TextBox informacoes;
		private System.Windows.Forms.TextBox newPower;
		private System.Windows.Forms.Button adicionar;
		private System.Windows.Forms.TextBox newInfo;
		private System.Windows.Forms.TextBox newTime;
		private System.Windows.Forms.TextBox newChar;
		private System.Windows.Forms.Label Potência;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox newName;
		private System.Windows.Forms.Label nome;
		private System.Windows.Forms.ListBox preDefinido;
		private System.Windows.Forms.Label label5;
	}
}

