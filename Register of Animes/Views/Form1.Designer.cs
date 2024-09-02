namespace Register_of_Animes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvData = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEpisode = new TextBox();
            txtGender = new ComboBox();
            lblId = new Label();
            lblName = new Label();
            lblGender = new Label();
            lblEpisode = new Label();
            btnSeach = new Button();
            lblData = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            dgvData.Location = new Point(6, 289);
            dgvData.Name = "dgvData";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(447, 399);
            dgvData.TabIndex = 0;
            dgvData.TabStop = false;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.ImageAlign = ContentAlignment.BottomLeft;
            btnAdd.Location = new Point(6, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 50);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlDarkDark;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEdit.Location = new Point(118, 213);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 50);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.Location = new Point(243, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(43, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 23);
            txtName.TabIndex = 2;
            // 
            // txtEpisode
            // 
            txtEpisode.Location = new Point(286, 152);
            txtEpisode.Name = "txtEpisode";
            txtEpisode.Size = new Size(167, 23);
            txtEpisode.TabIndex = 4;
            // 
            // txtGender
            // 
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Ação", "Aventura", "Comédia", "Drama", "Ecchi", "Esporte", "Fantasia" });
            txtGender.Location = new Point(6, 152);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(156, 23);
            txtGender.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblId.ForeColor = Color.Transparent;
            lblId.Image = Properties.Resources.naruto_and_teammates_fan_art_dbt18qjb7b1cstr1;
            lblId.Location = new Point(6, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 18);
            lblId.TabIndex = 9;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.DimGray;
            lblName.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.ForeColor = Color.Transparent;
            lblName.Image = Properties.Resources.naruto_and_teammates_fan_art_dbt18qjb7b1cstr1;
            lblName.Location = new Point(6, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 17);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGender.ForeColor = Color.Transparent;
            lblGender.Image = Properties.Resources.naruto_and_teammates_fan_art_dbt18qjb7b1cstr1;
            lblGender.Location = new Point(6, 132);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(55, 17);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender";
            // 
            // lblEpisode
            // 
            lblEpisode.AutoSize = true;
            lblEpisode.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEpisode.ForeColor = Color.Transparent;
            lblEpisode.Image = Properties.Resources.naruto_and_teammates_fan_art_dbt18qjb7b1cstr1;
            lblEpisode.Location = new Point(286, 132);
            lblEpisode.Name = "lblEpisode";
            lblEpisode.Size = new Size(60, 17);
            lblEpisode.TabIndex = 12;
            lblEpisode.Text = "Episode";
            // 
            // btnSeach
            // 
            btnSeach.BackColor = Color.SteelBlue;
            btnSeach.FlatStyle = FlatStyle.Popup;
            btnSeach.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSeach.Location = new Point(358, 213);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(90, 50);
            btnSeach.TabIndex = 8;
            btnSeach.Text = "SEACH";
            btnSeach.UseVisualStyleBackColor = false;
            btnSeach.Click += btnSeach_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblData.ForeColor = SystemColors.ActiveCaptionText;
            lblData.Location = new Point(12, 8);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 17);
            lblData.TabIndex = 14;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(420, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 24);
            btnExit.TabIndex = 15;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.naruto_and_teammates_fan_art_dbt18qjb7b1cstr1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 700);
            Controls.Add(btnExit);
            Controls.Add(lblData);
            Controls.Add(btnSeach);
            Controls.Add(lblEpisode);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(txtGender);
            Controls.Add(txtEpisode);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvData);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register of Animes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtEpisode;
        private ComboBox txtGender;
        private Label lblId;
        private Label lblName;
        private Label lblGender;
        private Label lblEpisode;
        private Button btnSeach;
        private Label lblData;
        private Button btnExit;
    }
}