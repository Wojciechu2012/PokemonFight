namespace PokemonFight
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MyPokemonLabel = new System.Windows.Forms.Label();
            this.EnemyPokemonLabel = new System.Windows.Forms.Label();
            this.MyAttackNormalButton = new System.Windows.Forms.Button();
            this.MyAttackSpecialButton = new System.Windows.Forms.Button();
            this.Pokemon1 = new System.Windows.Forms.Button();
            this.Pokemon2 = new System.Windows.Forms.Button();
            this.Pokemon3 = new System.Windows.Forms.Button();
            this.poketypelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 232);
            this.textBox1.TabIndex = 0;
            // 
            // MyPokemonLabel
            // 
            this.MyPokemonLabel.AutoSize = true;
            this.MyPokemonLabel.Location = new System.Drawing.Point(32, 94);
            this.MyPokemonLabel.Name = "MyPokemonLabel";
            this.MyPokemonLabel.Size = new System.Drawing.Size(0, 13);
            this.MyPokemonLabel.TabIndex = 1;
            // 
            // EnemyPokemonLabel
            // 
            this.EnemyPokemonLabel.AutoSize = true;
            this.EnemyPokemonLabel.Location = new System.Drawing.Point(454, 94);
            this.EnemyPokemonLabel.Name = "EnemyPokemonLabel";
            this.EnemyPokemonLabel.Size = new System.Drawing.Size(0, 13);
            this.EnemyPokemonLabel.TabIndex = 2;
            // 
            // MyAttackNormalButton
            // 
            this.MyAttackNormalButton.Location = new System.Drawing.Point(12, 151);
            this.MyAttackNormalButton.Name = "MyAttackNormalButton";
            this.MyAttackNormalButton.Size = new System.Drawing.Size(75, 23);
            this.MyAttackNormalButton.TabIndex = 3;
            this.MyAttackNormalButton.Text = "button1";
            this.MyAttackNormalButton.UseVisualStyleBackColor = true;
            this.MyAttackNormalButton.Visible = false;
            this.MyAttackNormalButton.Click += new System.EventHandler(this.MyAttackNormalButton_Click);
            // 
            // MyAttackSpecialButton
            // 
            this.MyAttackSpecialButton.Location = new System.Drawing.Point(13, 206);
            this.MyAttackSpecialButton.Name = "MyAttackSpecialButton";
            this.MyAttackSpecialButton.Size = new System.Drawing.Size(75, 23);
            this.MyAttackSpecialButton.TabIndex = 4;
            this.MyAttackSpecialButton.Text = "button1";
            this.MyAttackSpecialButton.UseVisualStyleBackColor = true;
            this.MyAttackSpecialButton.Visible = false;
            this.MyAttackSpecialButton.Click += new System.EventHandler(this.MyAttackSpecialButton_Click);
            // 
            // Pokemon1
            // 
            this.Pokemon1.Location = new System.Drawing.Point(138, 363);
            this.Pokemon1.Name = "Pokemon1";
            this.Pokemon1.Size = new System.Drawing.Size(75, 23);
            this.Pokemon1.TabIndex = 7;
            this.Pokemon1.Text = "Fire";
            this.Pokemon1.UseVisualStyleBackColor = true;
            this.Pokemon1.Click += new System.EventHandler(this.Pokemon1_Click);
            // 
            // Pokemon2
            // 
            this.Pokemon2.Location = new System.Drawing.Point(219, 363);
            this.Pokemon2.Name = "Pokemon2";
            this.Pokemon2.Size = new System.Drawing.Size(75, 23);
            this.Pokemon2.TabIndex = 8;
            this.Pokemon2.Text = "Water";
            this.Pokemon2.UseVisualStyleBackColor = true;
            this.Pokemon2.Click += new System.EventHandler(this.Pokemon2_Click);
            // 
            // Pokemon3
            // 
            this.Pokemon3.Location = new System.Drawing.Point(308, 363);
            this.Pokemon3.Name = "Pokemon3";
            this.Pokemon3.Size = new System.Drawing.Size(75, 23);
            this.Pokemon3.TabIndex = 9;
            this.Pokemon3.Text = "Grass";
            this.Pokemon3.UseVisualStyleBackColor = true;
            this.Pokemon3.Click += new System.EventHandler(this.Pokemon3_Click);
            // 
            // poketypelabel
            // 
            this.poketypelabel.AutoSize = true;
            this.poketypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poketypelabel.Location = new System.Drawing.Point(180, 322);
            this.poketypelabel.Name = "poketypelabel";
            this.poketypelabel.Size = new System.Drawing.Size(168, 20);
            this.poketypelabel.TabIndex = 10;
            this.poketypelabel.Text = "Choose pokemon type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 413);
            this.Controls.Add(this.poketypelabel);
            this.Controls.Add(this.Pokemon3);
            this.Controls.Add(this.Pokemon2);
            this.Controls.Add(this.Pokemon1);
            this.Controls.Add(this.MyAttackSpecialButton);
            this.Controls.Add(this.MyAttackNormalButton);
            this.Controls.Add(this.EnemyPokemonLabel);
            this.Controls.Add(this.MyPokemonLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MyPokemonLabel;
        private System.Windows.Forms.Label EnemyPokemonLabel;
        private System.Windows.Forms.Button MyAttackNormalButton;
        private System.Windows.Forms.Button MyAttackSpecialButton;
        private System.Windows.Forms.Button Pokemon1;
        private System.Windows.Forms.Button Pokemon2;
        private System.Windows.Forms.Button Pokemon3;
        private System.Windows.Forms.Label poketypelabel;
    }
}

