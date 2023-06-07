namespace Enigma_1_0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.message_txtbox = new System.Windows.Forms.TextBox();
            this.key2_txtbox = new System.Windows.Forms.TextBox();
            this.key1_txtbox = new System.Windows.Forms.TextBox();
            this.key0_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Szyfr_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.get_from_file_btn = new System.Windows.Forms.Button();
            this.key9_txtbox = new System.Windows.Forms.TextBox();
            this.key8_txtbox = new System.Windows.Forms.TextBox();
            this.key7_txtbox = new System.Windows.Forms.TextBox();
            this.key6_txtbox = new System.Windows.Forms.TextBox();
            this.key5_txtbox = new System.Windows.Forms.TextBox();
            this.key4_txtbox = new System.Windows.Forms.TextBox();
            this.key3_txtbox = new System.Windows.Forms.TextBox();
            this.key2_K_txtbox = new System.Windows.Forms.TextBox();
            this.key1_K_txtbox = new System.Windows.Forms.TextBox();
            this.key0_K_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.message_ok_label = new System.Windows.Forms.Label();
            this.delete_attachment_btn = new System.Windows.Forms.Button();
            this.filename_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.attachment_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.login_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailboxes_cb = new System.Windows.Forms.ComboBox();
            this.receiver_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sender_txtbox = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // message_txtbox
            // 
            this.message_txtbox.BackColor = System.Drawing.Color.Black;
            this.message_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.message_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.message_txtbox.Location = new System.Drawing.Point(12, 50);
            this.message_txtbox.Multiline = true;
            this.message_txtbox.Name = "message_txtbox";
            this.message_txtbox.Size = new System.Drawing.Size(495, 338);
            this.message_txtbox.TabIndex = 0;
            this.message_txtbox.TextChanged += new System.EventHandler(this.message_txtbox_TextChanged);
            this.message_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.message_txtbox_KeyPress);
            // 
            // key2_txtbox
            // 
            this.key2_txtbox.BackColor = System.Drawing.Color.Black;
            this.key2_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key2_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key2_txtbox.Location = new System.Drawing.Point(99, 52);
            this.key2_txtbox.MaxLength = 1;
            this.key2_txtbox.Name = "key2_txtbox";
            this.key2_txtbox.PasswordChar = '*';
            this.key2_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key2_txtbox.TabIndex = 3;
            this.key2_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key2_txtbox.TextChanged += new System.EventHandler(this.key2_txtbox_TextChanged);
            // 
            // key1_txtbox
            // 
            this.key1_txtbox.BackColor = System.Drawing.Color.Black;
            this.key1_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key1_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key1_txtbox.Location = new System.Drawing.Point(55, 52);
            this.key1_txtbox.MaxLength = 1;
            this.key1_txtbox.Name = "key1_txtbox";
            this.key1_txtbox.PasswordChar = '*';
            this.key1_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key1_txtbox.TabIndex = 2;
            this.key1_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key1_txtbox.TextChanged += new System.EventHandler(this.key1_txtbox_TextChanged);
            // 
            // key0_txtbox
            // 
            this.key0_txtbox.BackColor = System.Drawing.Color.Black;
            this.key0_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key0_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key0_txtbox.Location = new System.Drawing.Point(11, 52);
            this.key0_txtbox.MaxLength = 1;
            this.key0_txtbox.Name = "key0_txtbox";
            this.key0_txtbox.PasswordChar = '*';
            this.key0_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key0_txtbox.TabIndex = 1;
            this.key0_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key0_txtbox.TextChanged += new System.EventHandler(this.key0_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "WIADOMOSC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "KLUCZ:";
            // 
            // Szyfr_btn
            // 
            this.Szyfr_btn.BackColor = System.Drawing.Color.Black;
            this.Szyfr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Szyfr_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.Szyfr_btn.FlatAppearance.BorderSize = 3;
            this.Szyfr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Szyfr_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szyfr_btn.ForeColor = System.Drawing.Color.Gold;
            this.Szyfr_btn.Location = new System.Drawing.Point(11, 21);
            this.Szyfr_btn.Name = "Szyfr_btn";
            this.Szyfr_btn.Size = new System.Drawing.Size(146, 54);
            this.Szyfr_btn.TabIndex = 6;
            this.Szyfr_btn.Text = "SZYFRUJ";
            this.Szyfr_btn.UseVisualStyleBackColor = false;
            this.Szyfr_btn.Click += new System.EventHandler(this.Szyfr_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(11, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "DESZYFRUJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Black;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.exit_btn.FlatAppearance.BorderSize = 3;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Gold;
            this.exit_btn.Location = new System.Drawing.Point(299, 90);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(146, 54);
            this.exit_btn.TabIndex = 8;
            this.exit_btn.Text = "WYJSCIE";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Black;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.clear_btn.FlatAppearance.BorderSize = 3;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.Gold;
            this.clear_btn.Location = new System.Drawing.Point(299, 110);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(146, 54);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "WYCZYSC";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // get_from_file_btn
            // 
            this.get_from_file_btn.BackColor = System.Drawing.Color.Black;
            this.get_from_file_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get_from_file_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.get_from_file_btn.FlatAppearance.BorderSize = 3;
            this.get_from_file_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_from_file_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_from_file_btn.ForeColor = System.Drawing.Color.Gold;
            this.get_from_file_btn.Location = new System.Drawing.Point(231, 21);
            this.get_from_file_btn.Name = "get_from_file_btn";
            this.get_from_file_btn.Size = new System.Drawing.Size(214, 54);
            this.get_from_file_btn.TabIndex = 10;
            this.get_from_file_btn.Text = "WCZYTAJ Z PLIKU";
            this.get_from_file_btn.UseVisualStyleBackColor = false;
            this.get_from_file_btn.Click += new System.EventHandler(this.get_from_file_btn_Click);
            // 
            // key9_txtbox
            // 
            this.key9_txtbox.BackColor = System.Drawing.Color.Black;
            this.key9_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key9_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key9_txtbox.Location = new System.Drawing.Point(407, 52);
            this.key9_txtbox.MaxLength = 1;
            this.key9_txtbox.Name = "key9_txtbox";
            this.key9_txtbox.PasswordChar = '*';
            this.key9_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key9_txtbox.TabIndex = 12;
            this.key9_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key9_txtbox.TextChanged += new System.EventHandler(this.key9_txtbox_TextChanged);
            // 
            // key8_txtbox
            // 
            this.key8_txtbox.BackColor = System.Drawing.Color.Black;
            this.key8_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key8_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key8_txtbox.Location = new System.Drawing.Point(363, 52);
            this.key8_txtbox.MaxLength = 1;
            this.key8_txtbox.Name = "key8_txtbox";
            this.key8_txtbox.PasswordChar = '*';
            this.key8_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key8_txtbox.TabIndex = 13;
            this.key8_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key8_txtbox.TextChanged += new System.EventHandler(this.key8_txtbox_TextChanged);
            // 
            // key7_txtbox
            // 
            this.key7_txtbox.BackColor = System.Drawing.Color.Black;
            this.key7_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key7_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key7_txtbox.Location = new System.Drawing.Point(319, 52);
            this.key7_txtbox.MaxLength = 1;
            this.key7_txtbox.Name = "key7_txtbox";
            this.key7_txtbox.PasswordChar = '*';
            this.key7_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key7_txtbox.TabIndex = 14;
            this.key7_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key7_txtbox.TextChanged += new System.EventHandler(this.key7_txtbox_TextChanged);
            // 
            // key6_txtbox
            // 
            this.key6_txtbox.BackColor = System.Drawing.Color.Black;
            this.key6_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key6_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key6_txtbox.Location = new System.Drawing.Point(275, 52);
            this.key6_txtbox.MaxLength = 1;
            this.key6_txtbox.Name = "key6_txtbox";
            this.key6_txtbox.PasswordChar = '*';
            this.key6_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key6_txtbox.TabIndex = 15;
            this.key6_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key6_txtbox.TextChanged += new System.EventHandler(this.key6_txtbox_TextChanged);
            // 
            // key5_txtbox
            // 
            this.key5_txtbox.BackColor = System.Drawing.Color.Black;
            this.key5_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key5_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key5_txtbox.Location = new System.Drawing.Point(231, 52);
            this.key5_txtbox.MaxLength = 1;
            this.key5_txtbox.Name = "key5_txtbox";
            this.key5_txtbox.PasswordChar = '*';
            this.key5_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key5_txtbox.TabIndex = 16;
            this.key5_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key5_txtbox.TextChanged += new System.EventHandler(this.key5_txtbox_TextChanged);
            // 
            // key4_txtbox
            // 
            this.key4_txtbox.BackColor = System.Drawing.Color.Black;
            this.key4_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key4_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key4_txtbox.Location = new System.Drawing.Point(187, 52);
            this.key4_txtbox.MaxLength = 1;
            this.key4_txtbox.Name = "key4_txtbox";
            this.key4_txtbox.PasswordChar = '*';
            this.key4_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key4_txtbox.TabIndex = 17;
            this.key4_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key4_txtbox.TextChanged += new System.EventHandler(this.key4_txtbox_TextChanged);
            // 
            // key3_txtbox
            // 
            this.key3_txtbox.BackColor = System.Drawing.Color.Black;
            this.key3_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key3_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key3_txtbox.Location = new System.Drawing.Point(143, 52);
            this.key3_txtbox.MaxLength = 1;
            this.key3_txtbox.Name = "key3_txtbox";
            this.key3_txtbox.PasswordChar = '*';
            this.key3_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key3_txtbox.TabIndex = 18;
            this.key3_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key3_txtbox.TextChanged += new System.EventHandler(this.key3_txtbox_TextChanged);
            // 
            // key2_K_txtbox
            // 
            this.key2_K_txtbox.BackColor = System.Drawing.Color.Black;
            this.key2_K_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key2_K_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key2_K_txtbox.Location = new System.Drawing.Point(99, 130);
            this.key2_K_txtbox.MaxLength = 1;
            this.key2_K_txtbox.Name = "key2_K_txtbox";
            this.key2_K_txtbox.PasswordChar = '*';
            this.key2_K_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key2_K_txtbox.TabIndex = 19;
            this.key2_K_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key2_K_txtbox.TextChanged += new System.EventHandler(this.key2_K_txtbox_TextChanged);
            // 
            // key1_K_txtbox
            // 
            this.key1_K_txtbox.BackColor = System.Drawing.Color.Black;
            this.key1_K_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key1_K_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key1_K_txtbox.Location = new System.Drawing.Point(55, 130);
            this.key1_K_txtbox.MaxLength = 1;
            this.key1_K_txtbox.Name = "key1_K_txtbox";
            this.key1_K_txtbox.PasswordChar = '*';
            this.key1_K_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key1_K_txtbox.TabIndex = 20;
            this.key1_K_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key1_K_txtbox.TextChanged += new System.EventHandler(this.key1_K_txtbox_TextChanged);
            // 
            // key0_K_txtbox
            // 
            this.key0_K_txtbox.BackColor = System.Drawing.Color.Black;
            this.key0_K_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.key0_K_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.key0_K_txtbox.Location = new System.Drawing.Point(11, 130);
            this.key0_K_txtbox.MaxLength = 1;
            this.key0_K_txtbox.Name = "key0_K_txtbox";
            this.key0_K_txtbox.PasswordChar = '*';
            this.key0_K_txtbox.Size = new System.Drawing.Size(38, 38);
            this.key0_K_txtbox.TabIndex = 21;
            this.key0_K_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key0_K_txtbox.TextChanged += new System.EventHandler(this.key0_K_txtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "KLUCZ KLUCZA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.key2_txtbox);
            this.groupBox1.Controls.Add(this.key0_K_txtbox);
            this.groupBox1.Controls.Add(this.key1_txtbox);
            this.groupBox1.Controls.Add(this.key1_K_txtbox);
            this.groupBox1.Controls.Add(this.key0_txtbox);
            this.groupBox1.Controls.Add(this.key2_K_txtbox);
            this.groupBox1.Controls.Add(this.key9_txtbox);
            this.groupBox1.Controls.Add(this.key3_txtbox);
            this.groupBox1.Controls.Add(this.key8_txtbox);
            this.groupBox1.Controls.Add(this.key4_txtbox);
            this.groupBox1.Controls.Add(this.key7_txtbox);
            this.groupBox1.Controls.Add(this.key5_txtbox);
            this.groupBox1.Controls.Add(this.key6_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(513, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 184);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Szyfr_btn);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.exit_btn);
            this.groupBox2.Controls.Add(this.get_from_file_btn);
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(513, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 160);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.message_ok_label);
            this.groupBox3.Controls.Add(this.delete_attachment_btn);
            this.groupBox3.Controls.Add(this.filename_label);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.attachment_btn);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.login_txtbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.password_txtbox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mailboxes_cb);
            this.groupBox3.Controls.Add(this.receiver_txtbox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.sender_txtbox);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(12, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(961, 263);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wysyłanie depeszy";
            // 
            // message_ok_label
            // 
            this.message_ok_label.AutoSize = true;
            this.message_ok_label.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_ok_label.ForeColor = System.Drawing.Color.Lime;
            this.message_ok_label.Location = new System.Drawing.Point(248, 219);
            this.message_ok_label.Name = "message_ok_label";
            this.message_ok_label.Size = new System.Drawing.Size(311, 23);
            this.message_ok_label.TabIndex = 22;
            this.message_ok_label.Text = "Wiadomosc wyslana poprawnie";
            this.message_ok_label.Visible = false;
            // 
            // delete_attachment_btn
            // 
            this.delete_attachment_btn.BackColor = System.Drawing.Color.Black;
            this.delete_attachment_btn.BackgroundImage = global::Enigma_1_0.Properties.Resources._759389;
            this.delete_attachment_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_attachment_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_attachment_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.delete_attachment_btn.FlatAppearance.BorderSize = 3;
            this.delete_attachment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_attachment_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_attachment_btn.ForeColor = System.Drawing.Color.Gold;
            this.delete_attachment_btn.Location = new System.Drawing.Point(887, 121);
            this.delete_attachment_btn.Name = "delete_attachment_btn";
            this.delete_attachment_btn.Size = new System.Drawing.Size(59, 54);
            this.delete_attachment_btn.TabIndex = 21;
            this.delete_attachment_btn.UseVisualStyleBackColor = false;
            this.delete_attachment_btn.Click += new System.EventHandler(this.delete_attachment_btn_Click);
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_label.Location = new System.Drawing.Point(202, 172);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(96, 23);
            this.filename_label.TabIndex = 20;
            this.filename_label.Text = "filename";
            this.filename_label.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Dodany zalacznik:";
            // 
            // attachment_btn
            // 
            this.attachment_btn.BackColor = System.Drawing.Color.Black;
            this.attachment_btn.BackgroundImage = global::Enigma_1_0.Properties.Resources.png_clipart_paper_clip_computer_icons_email_attachment_blue_paper_clip_icon_miscellaneous_text;
            this.attachment_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.attachment_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attachment_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.attachment_btn.FlatAppearance.BorderSize = 3;
            this.attachment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachment_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachment_btn.ForeColor = System.Drawing.Color.Gold;
            this.attachment_btn.Location = new System.Drawing.Point(800, 121);
            this.attachment_btn.Name = "attachment_btn";
            this.attachment_btn.Size = new System.Drawing.Size(59, 54);
            this.attachment_btn.TabIndex = 18;
            this.attachment_btn.UseVisualStyleBackColor = false;
            this.attachment_btn.Click += new System.EventHandler(this.attachment_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Login do poczty:";
            // 
            // login_txtbox
            // 
            this.login_txtbox.BackColor = System.Drawing.Color.Black;
            this.login_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.login_txtbox.Location = new System.Drawing.Point(722, 35);
            this.login_txtbox.Name = "login_txtbox";
            this.login_txtbox.Size = new System.Drawing.Size(224, 34);
            this.login_txtbox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hasło do poczty:";
            // 
            // password_txtbox
            // 
            this.password_txtbox.BackColor = System.Drawing.Color.Black;
            this.password_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.password_txtbox.Location = new System.Drawing.Point(722, 81);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(224, 34);
            this.password_txtbox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Poczta nadawcy:";
            // 
            // mailboxes_cb
            // 
            this.mailboxes_cb.BackColor = System.Drawing.Color.Black;
            this.mailboxes_cb.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailboxes_cb.ForeColor = System.Drawing.Color.Gold;
            this.mailboxes_cb.FormattingEnabled = true;
            this.mailboxes_cb.Items.AddRange(new object[] {
            "Gmail",
            "Interia",
            "Onet",
            "WP"});
            this.mailboxes_cb.Location = new System.Drawing.Point(191, 130);
            this.mailboxes_cb.Name = "mailboxes_cb";
            this.mailboxes_cb.Size = new System.Drawing.Size(249, 31);
            this.mailboxes_cb.TabIndex = 12;
            // 
            // receiver_txtbox
            // 
            this.receiver_txtbox.BackColor = System.Drawing.Color.Black;
            this.receiver_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.receiver_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.receiver_txtbox.Location = new System.Drawing.Point(191, 81);
            this.receiver_txtbox.Name = "receiver_txtbox";
            this.receiver_txtbox.Size = new System.Drawing.Size(304, 34);
            this.receiver_txtbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email odbiorcy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email nadawcy:";
            // 
            // sender_txtbox
            // 
            this.sender_txtbox.BackColor = System.Drawing.Color.Black;
            this.sender_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sender_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.sender_txtbox.Location = new System.Drawing.Point(191, 35);
            this.sender_txtbox.Name = "sender_txtbox";
            this.sender_txtbox.Size = new System.Drawing.Size(304, 34);
            this.sender_txtbox.TabIndex = 8;
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.Black;
            this.send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.send_btn.FlatAppearance.BorderSize = 3;
            this.send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_btn.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.ForeColor = System.Drawing.Color.Gold;
            this.send_btn.Location = new System.Drawing.Point(800, 188);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(146, 54);
            this.send_btn.TabIndex = 7;
            this.send_btn.Text = "WYSLIJ";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 23);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(992, 669);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message_txtbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_txtbox;
        private System.Windows.Forms.TextBox key2_txtbox;
        private System.Windows.Forms.TextBox key1_txtbox;
        private System.Windows.Forms.TextBox key0_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Szyfr_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button get_from_file_btn;
        private System.Windows.Forms.TextBox key9_txtbox;
        private System.Windows.Forms.TextBox key8_txtbox;
        private System.Windows.Forms.TextBox key7_txtbox;
        private System.Windows.Forms.TextBox key6_txtbox;
        private System.Windows.Forms.TextBox key5_txtbox;
        private System.Windows.Forms.TextBox key4_txtbox;
        private System.Windows.Forms.TextBox key3_txtbox;
        private System.Windows.Forms.TextBox key2_K_txtbox;
        private System.Windows.Forms.TextBox key1_K_txtbox;
        private System.Windows.Forms.TextBox key0_K_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox receiver_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sender_txtbox;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mailboxes_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox login_txtbox;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button attachment_btn;
        private System.Windows.Forms.Button delete_attachment_btn;
        private System.Windows.Forms.Label message_ok_label;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

