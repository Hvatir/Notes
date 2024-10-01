namespace Notes
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MainPanel = new Panel();
            NoteInput = new TextBox();
            TopPanel = new Panel();
            TitleLabel = new Label();
            NoteTitleInput = new TextBox();
            BottomPanel = new Panel();
            NewBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            panel2 = new Panel();
            NotesDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            noteBindingSource = new BindingSource(components);
            TopBar = new Panel();
            ExitBtn = new Button();
            MainPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).BeginInit();
            TopBar.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(29, 29, 29);
            MainPanel.Controls.Add(NoteInput);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Controls.Add(BottomPanel);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(TopBar);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 567);
            MainPanel.TabIndex = 0;
            // 
            // NoteInput
            // 
            NoteInput.BackColor = Color.FromArgb(31, 31, 31);
            NoteInput.BorderStyle = BorderStyle.FixedSingle;
            NoteInput.Dock = DockStyle.Fill;
            NoteInput.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteInput.ForeColor = Color.White;
            NoteInput.Location = new Point(197, 73);
            NoteInput.Multiline = true;
            NoteInput.Name = "NoteInput";
            NoteInput.Size = new Size(603, 436);
            NoteInput.TabIndex = 2;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(41, 41, 41);
            TopPanel.Controls.Add(TitleLabel);
            TopPanel.Controls.Add(NoteTitleInput);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(197, 33);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(603, 40);
            TopPanel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(6, 10);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(50, 20);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Titulo:";
            // 
            // NoteTitleInput
            // 
            NoteTitleInput.BackColor = Color.FromArgb(31, 31, 31);
            NoteTitleInput.BorderStyle = BorderStyle.FixedSingle;
            NoteTitleInput.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteTitleInput.ForeColor = Color.White;
            NoteTitleInput.Location = new Point(62, 7);
            NoteTitleInput.Name = "NoteTitleInput";
            NoteTitleInput.Size = new Size(341, 26);
            NoteTitleInput.TabIndex = 0;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.FromArgb(41, 41, 41);
            BottomPanel.Controls.Add(NewBtn);
            BottomPanel.Controls.Add(EditBtn);
            BottomPanel.Controls.Add(DeleteBtn);
            BottomPanel.Controls.Add(SaveBtn);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(197, 509);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(603, 58);
            BottomPanel.TabIndex = 0;
            // 
            // NewBtn
            // 
            NewBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NewBtn.BackColor = Color.FromArgb(17, 94, 163);
            NewBtn.FlatAppearance.BorderSize = 0;
            NewBtn.FlatStyle = FlatStyle.Flat;
            NewBtn.ForeColor = Color.White;
            NewBtn.Location = new Point(215, 6);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(98, 42);
            NewBtn.TabIndex = 3;
            NewBtn.Text = "Nuevo";
            NewBtn.UseVisualStyleBackColor = false;
            NewBtn.Click += NewBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditBtn.BackColor = Color.FromArgb(17, 94, 163);
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(6, 6);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(98, 42);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Visible = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteBtn.BackColor = Color.FromArgb(17, 94, 163);
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(111, 6);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(98, 42);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveBtn.BackColor = Color.FromArgb(17, 94, 163);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(6, 6);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(98, 42);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Guardar";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(NotesDataGridView);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 534);
            panel2.TabIndex = 0;
            // 
            // NotesDataGridView
            // 
            NotesDataGridView.AllowUserToAddRows = false;
            NotesDataGridView.AllowUserToDeleteRows = false;
            NotesDataGridView.AutoGenerateColumns = false;
            NotesDataGridView.BackgroundColor = Color.FromArgb(29, 29, 29);
            NotesDataGridView.BorderStyle = BorderStyle.None;
            NotesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesDataGridView.ColumnHeadersVisible = false;
            NotesDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, titleDataGridViewTextBoxColumn, Description });
            NotesDataGridView.DataSource = noteBindingSource;
            NotesDataGridView.Dock = DockStyle.Fill;
            NotesDataGridView.Location = new Point(0, 0);
            NotesDataGridView.Name = "NotesDataGridView";
            NotesDataGridView.ReadOnly = true;
            NotesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(17, 94, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 84, 140);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            NotesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            NotesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NotesDataGridView.Size = new Size(197, 534);
            NotesDataGridView.TabIndex = 0;
            NotesDataGridView.CellClick += NotesDataGridView_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Visible = false;
            Description.Width = 125;
            // 
            // noteBindingSource
            // 
            noteBindingSource.DataSource = typeof(Data.Note);
            // 
            // TopBar
            // 
            TopBar.Controls.Add(ExitBtn);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(800, 33);
            TopBar.TabIndex = 2;
            TopBar.MouseMove += TopBar_MouseMove;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(209, 52, 56);
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Location = new Point(756, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(41, 29);
            ExitBtn.TabIndex = 0;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Notes";
            Load += MainForm_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NotesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)noteBindingSource).EndInit();
            TopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel panel2;
        private Panel TopPanel;
        private Panel BottomPanel;
        private Button SaveBtn;
        private TextBox NoteTitleInput;
        private Label TitleLabel;
        private TextBox NoteInput;
        private DataGridView NotesDataGridView;
        private BindingSource noteBindingSource;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button NewBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Description;
        private Panel TopBar;
        private Button ExitBtn;
    }
}
