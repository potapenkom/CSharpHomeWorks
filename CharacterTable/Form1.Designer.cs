namespace CharacterTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lasrName = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.forName = new System.Windows.Forms.Label();
            this.forLastName = new System.Windows.Forms.Label();
            this.forGender = new System.Windows.Forms.Label();
            this.forAfe = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(75, 339);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 1;
            // 
            // lasrName
            // 
            this.lasrName.Location = new System.Drawing.Point(291, 339);
            this.lasrName.Name = "lasrName";
            this.lasrName.Size = new System.Drawing.Size(100, 20);
            this.lasrName.TabIndex = 2;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(487, 339);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 3;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(669, 339);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(181, 395);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(118, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add Character";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // forName
            // 
            this.forName.AutoSize = true;
            this.forName.Location = new System.Drawing.Point(12, 346);
            this.forName.Name = "forName";
            this.forName.Size = new System.Drawing.Size(57, 13);
            this.forName.TabIndex = 6;
            this.forName.Text = "First Name";
            // 
            // forLastName
            // 
            this.forLastName.AutoSize = true;
            this.forLastName.Location = new System.Drawing.Point(218, 346);
            this.forLastName.Name = "forLastName";
            this.forLastName.Size = new System.Drawing.Size(58, 13);
            this.forLastName.TabIndex = 7;
            this.forLastName.Text = "Last Name";
            // 
            // forGender
            // 
            this.forGender.AutoSize = true;
            this.forGender.Location = new System.Drawing.Point(439, 346);
            this.forGender.Name = "forGender";
            this.forGender.Size = new System.Drawing.Size(42, 13);
            this.forGender.TabIndex = 8;
            this.forGender.Text = "Gender";
            // 
            // forAfe
            // 
            this.forAfe.AutoSize = true;
            this.forAfe.Location = new System.Drawing.Point(628, 346);
            this.forAfe.Name = "forAfe";
            this.forAfe.Size = new System.Drawing.Size(26, 13);
            this.forAfe.TabIndex = 9;
            this.forAfe.Text = "Age";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(399, 395);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(127, 32);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "RemoveCharasters";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.forAfe);
            this.Controls.Add(this.forGender);
            this.Controls.Add(this.forLastName);
            this.Controls.Add(this.forName);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lasrName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lasrName;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label forName;
        private System.Windows.Forms.Label forLastName;
        private System.Windows.Forms.Label forGender;
        private System.Windows.Forms.Label forAfe;
        private System.Windows.Forms.Button RemoveButton;
    }
}

