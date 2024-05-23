
namespace Modelowanie_Wieloskalowe___aplikacja
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
            this.button_start_stop = new System.Windows.Forms.Button();
            this.textBox_matrix_width = new System.Windows.Forms.TextBox();
            this.textBox_matrix_height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_main_show_matrix = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.textBox_seed_number_1 = new System.Windows.Forms.TextBox();
            this.button_add_seed_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add_seed_2 = new System.Windows.Forms.Button();
            this.textBox_seed_number_2 = new System.Windows.Forms.TextBox();
            this.button_apply_modyfie = new System.Windows.Forms.Button();
            this.button_color_reshuffle = new System.Windows.Forms.Button();
            this.radioButton_periodic = new System.Windows.Forms.RadioButton();
            this.radioButton_hard_stop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_hexa = new System.Windows.Forms.RadioButton();
            this.radioButton_penta = new System.Windows.Forms.RadioButton();
            this.radioButton_von_nueman = new System.Windows.Forms.RadioButton();
            this.radioButton_moore = new System.Windows.Forms.RadioButton();
            this.button_save_image = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_homogeneous_row = new System.Windows.Forms.TextBox();
            this.textBox_homogeneous_col = new System.Windows.Forms.TextBox();
            this.button_homogeneous_apply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_mouse_add = new System.Windows.Forms.CheckBox();
            this.checkBox_mouse_delete = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_scramble = new System.Windows.Forms.Button();
            this.textBox_MC_unique_ids = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_kT_value = new System.Windows.Forms.TextBox();
            this.radioButton_type_of_iter_CA = new System.Windows.Forms.RadioButton();
            this.radioButton_type_of_iter_MC = new System.Windows.Forms.RadioButton();
            this.button_recal_edges = new System.Windows.Forms.Button();
            this.button_edges_on_off = new System.Windows.Forms.Button();
            this.label_stat_coverage = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_whole_energy = new System.Windows.Forms.CheckBox();
            this.checkBox_Coverage_percent = new System.Windows.Forms.CheckBox();
            this.checkBox_how_many_grains = new System.Windows.Forms.CheckBox();
            this.label_number_of_grains = new System.Windows.Forms.Label();
            this.button_background_phase = new System.Windows.Forms.Button();
            this.button_work_dir = new System.Windows.Forms.Button();
            this.button_see_output = new System.Windows.Forms.Button();
            this.button_2_phases = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button_energy_on_off = new System.Windows.Forms.Button();
            this.button_recal_energy = new System.Windows.Forms.Button();
            this.label_energy_of_system = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_auto_energy = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox_auto_edges = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label_iter_and_time_of_simulation = new System.Windows.Forms.Label();
            this.checkBox_3D = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_slice_number = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_matrix_depth = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton_save_to_png = new System.Windows.Forms.RadioButton();
            this.radioButton_save_to_ovito = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_show_matrix)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start_stop
            // 
            this.button_start_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start_stop.Location = new System.Drawing.Point(1045, 703);
            this.button_start_stop.Name = "button_start_stop";
            this.button_start_stop.Size = new System.Drawing.Size(183, 84);
            this.button_start_stop.TabIndex = 0;
            this.button_start_stop.Text = "Start";
            this.button_start_stop.UseVisualStyleBackColor = true;
            this.button_start_stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_matrix_width
            // 
            this.textBox_matrix_width.AllowDrop = true;
            this.textBox_matrix_width.Location = new System.Drawing.Point(1217, 59);
            this.textBox_matrix_width.Name = "textBox_matrix_width";
            this.textBox_matrix_width.Size = new System.Drawing.Size(52, 20);
            this.textBox_matrix_width.TabIndex = 1;
            this.textBox_matrix_width.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox_matrix_width.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // textBox_matrix_height
            // 
            this.textBox_matrix_height.AllowDrop = true;
            this.textBox_matrix_height.Location = new System.Drawing.Point(1217, 85);
            this.textBox_matrix_height.Name = "textBox_matrix_height";
            this.textBox_matrix_height.Size = new System.Drawing.Size(52, 20);
            this.textBox_matrix_height.TabIndex = 2;
            this.textBox_matrix_height.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox2_DragDrop);
            this.textBox_matrix_height.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "                                                 ";
            // 
            // pictureBox_main_show_matrix
            // 
            this.pictureBox_main_show_matrix.Location = new System.Drawing.Point(25, 25);
            this.pictureBox_main_show_matrix.Name = "pictureBox_main_show_matrix";
            this.pictureBox_main_show_matrix.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox_main_show_matrix.TabIndex = 4;
            this.pictureBox_main_show_matrix.TabStop = false;
            this.pictureBox_main_show_matrix.Click += new System.EventHandler(this.pictureBox_main_show_matrix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1157, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matrix dimensions";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(1166, 793);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(62, 32);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_error.Location = new System.Drawing.Point(1303, 81);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(96, 24);
            this.label_error.TabIndex = 7;
            this.label_error.Text = "Input error";
            // 
            // textBox_seed_number_1
            // 
            this.textBox_seed_number_1.AllowDrop = true;
            this.textBox_seed_number_1.Location = new System.Drawing.Point(1155, 220);
            this.textBox_seed_number_1.Name = "textBox_seed_number_1";
            this.textBox_seed_number_1.Size = new System.Drawing.Size(61, 20);
            this.textBox_seed_number_1.TabIndex = 8;
            // 
            // button_add_seed_1
            // 
            this.button_add_seed_1.Location = new System.Drawing.Point(1164, 246);
            this.button_add_seed_1.Name = "button_add_seed_1";
            this.button_add_seed_1.Size = new System.Drawing.Size(44, 20);
            this.button_add_seed_1.TabIndex = 10;
            this.button_add_seed_1.Text = "add";
            this.button_add_seed_1.UseVisualStyleBackColor = true;
            this.button_add_seed_1.Click += new System.EventHandler(this.button_add_seed_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1041, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grain nucleon";
            // 
            // button_add_seed_2
            // 
            this.button_add_seed_2.Location = new System.Drawing.Point(1075, 246);
            this.button_add_seed_2.Name = "button_add_seed_2";
            this.button_add_seed_2.Size = new System.Drawing.Size(44, 20);
            this.button_add_seed_2.TabIndex = 14;
            this.button_add_seed_2.Text = "add";
            this.button_add_seed_2.UseVisualStyleBackColor = true;
            this.button_add_seed_2.Click += new System.EventHandler(this.button_add_seed_2_Click);
            // 
            // textBox_seed_number_2
            // 
            this.textBox_seed_number_2.AllowDrop = true;
            this.textBox_seed_number_2.Location = new System.Drawing.Point(1065, 220);
            this.textBox_seed_number_2.Name = "textBox_seed_number_2";
            this.textBox_seed_number_2.Size = new System.Drawing.Size(61, 20);
            this.textBox_seed_number_2.TabIndex = 13;
            // 
            // button_apply_modyfie
            // 
            this.button_apply_modyfie.Location = new System.Drawing.Point(1190, 138);
            this.button_apply_modyfie.Name = "button_apply_modyfie";
            this.button_apply_modyfie.Size = new System.Drawing.Size(79, 37);
            this.button_apply_modyfie.TabIndex = 15;
            this.button_apply_modyfie.Text = "Apply / Modyfie";
            this.button_apply_modyfie.UseVisualStyleBackColor = true;
            this.button_apply_modyfie.Click += new System.EventHandler(this.button_apply_modyfie_Click);
            // 
            // button_color_reshuffle
            // 
            this.button_color_reshuffle.Location = new System.Drawing.Point(1045, 793);
            this.button_color_reshuffle.Name = "button_color_reshuffle";
            this.button_color_reshuffle.Size = new System.Drawing.Size(107, 32);
            this.button_color_reshuffle.TabIndex = 17;
            this.button_color_reshuffle.Text = "Color reshuffle";
            this.button_color_reshuffle.UseVisualStyleBackColor = true;
            this.button_color_reshuffle.Click += new System.EventHandler(this.button_color_reshuffle_Click);
            // 
            // radioButton_periodic
            // 
            this.radioButton_periodic.AutoSize = true;
            this.radioButton_periodic.Location = new System.Drawing.Point(23, 30);
            this.radioButton_periodic.Name = "radioButton_periodic";
            this.radioButton_periodic.Size = new System.Drawing.Size(63, 17);
            this.radioButton_periodic.TabIndex = 18;
            this.radioButton_periodic.TabStop = true;
            this.radioButton_periodic.Text = "Periodic";
            this.radioButton_periodic.UseVisualStyleBackColor = true;
            // 
            // radioButton_hard_stop
            // 
            this.radioButton_hard_stop.AutoSize = true;
            this.radioButton_hard_stop.Location = new System.Drawing.Point(23, 65);
            this.radioButton_hard_stop.Name = "radioButton_hard_stop";
            this.radioButton_hard_stop.Size = new System.Drawing.Size(77, 17);
            this.radioButton_hard_stop.TabIndex = 19;
            this.radioButton_hard_stop.TabStop = true;
            this.radioButton_hard_stop.Text = "Non active";
            this.radioButton_hard_stop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_periodic);
            this.groupBox1.Controls.Add(this.radioButton_hard_stop);
            this.groupBox1.Location = new System.Drawing.Point(1043, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 101);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boundary conditions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_hexa);
            this.groupBox2.Controls.Add(this.radioButton_penta);
            this.groupBox2.Controls.Add(this.radioButton_von_nueman);
            this.groupBox2.Controls.Add(this.radioButton_moore);
            this.groupBox2.Location = new System.Drawing.Point(1261, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 129);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbourhood";
            // 
            // radioButton_hexa
            // 
            this.radioButton_hexa.AutoSize = true;
            this.radioButton_hexa.Location = new System.Drawing.Point(23, 99);
            this.radioButton_hexa.Name = "radioButton_hexa";
            this.radioButton_hexa.Size = new System.Drawing.Size(126, 17);
            this.radioButton_hexa.TabIndex = 21;
            this.radioButton_hexa.TabStop = true;
            this.radioButton_hexa.Text = "Hexagonal ( random )";
            this.radioButton_hexa.UseVisualStyleBackColor = true;
            // 
            // radioButton_penta
            // 
            this.radioButton_penta.AutoSize = true;
            this.radioButton_penta.Location = new System.Drawing.Point(23, 76);
            this.radioButton_penta.Name = "radioButton_penta";
            this.radioButton_penta.Size = new System.Drawing.Size(129, 17);
            this.radioButton_penta.TabIndex = 20;
            this.radioButton_penta.TabStop = true;
            this.radioButton_penta.Text = "Pentagonal ( random )";
            this.radioButton_penta.UseVisualStyleBackColor = true;
            // 
            // radioButton_von_nueman
            // 
            this.radioButton_von_nueman.AutoSize = true;
            this.radioButton_von_nueman.Location = new System.Drawing.Point(23, 30);
            this.radioButton_von_nueman.Name = "radioButton_von_nueman";
            this.radioButton_von_nueman.Size = new System.Drawing.Size(87, 17);
            this.radioButton_von_nueman.TabIndex = 18;
            this.radioButton_von_nueman.TabStop = true;
            this.radioButton_von_nueman.Text = "Von Nueman";
            this.radioButton_von_nueman.UseVisualStyleBackColor = true;
            // 
            // radioButton_moore
            // 
            this.radioButton_moore.AutoSize = true;
            this.radioButton_moore.Location = new System.Drawing.Point(23, 53);
            this.radioButton_moore.Name = "radioButton_moore";
            this.radioButton_moore.Size = new System.Drawing.Size(55, 17);
            this.radioButton_moore.TabIndex = 19;
            this.radioButton_moore.TabStop = true;
            this.radioButton_moore.Text = "Moore";
            this.radioButton_moore.UseVisualStyleBackColor = true;
            // 
            // button_save_image
            // 
            this.button_save_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.button_save_image.Location = new System.Drawing.Point(1261, 793);
            this.button_save_image.Name = "button_save_image";
            this.button_save_image.Size = new System.Drawing.Size(168, 45);
            this.button_save_image.TabIndex = 22;
            this.button_save_image.Text = "Save to";
            this.button_save_image.UseVisualStyleBackColor = true;
            this.button_save_image.Click += new System.EventHandler(this.button_save_image_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1257, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Homogeneous";
            // 
            // textBox_homogeneous_row
            // 
            this.textBox_homogeneous_row.AllowDrop = true;
            this.textBox_homogeneous_row.Location = new System.Drawing.Point(1299, 338);
            this.textBox_homogeneous_row.Name = "textBox_homogeneous_row";
            this.textBox_homogeneous_row.Size = new System.Drawing.Size(61, 20);
            this.textBox_homogeneous_row.TabIndex = 25;
            // 
            // textBox_homogeneous_col
            // 
            this.textBox_homogeneous_col.AllowDrop = true;
            this.textBox_homogeneous_col.Location = new System.Drawing.Point(1299, 364);
            this.textBox_homogeneous_col.Name = "textBox_homogeneous_col";
            this.textBox_homogeneous_col.Size = new System.Drawing.Size(61, 20);
            this.textBox_homogeneous_col.TabIndex = 24;
            // 
            // button_homogeneous_apply
            // 
            this.button_homogeneous_apply.Location = new System.Drawing.Point(1371, 338);
            this.button_homogeneous_apply.Name = "button_homogeneous_apply";
            this.button_homogeneous_apply.Size = new System.Drawing.Size(58, 46);
            this.button_homogeneous_apply.TabIndex = 26;
            this.button_homogeneous_apply.Text = "Add";
            this.button_homogeneous_apply.UseVisualStyleBackColor = true;
            this.button_homogeneous_apply.Click += new System.EventHandler(this.button_homogeneous_apply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1258, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Row";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1258, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Col";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1041, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mouse";
            // 
            // checkBox_mouse_add
            // 
            this.checkBox_mouse_add.AutoSize = true;
            this.checkBox_mouse_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_mouse_add.Location = new System.Drawing.Point(1083, 345);
            this.checkBox_mouse_add.Name = "checkBox_mouse_add";
            this.checkBox_mouse_add.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mouse_add.TabIndex = 30;
            this.checkBox_mouse_add.UseVisualStyleBackColor = true;
            // 
            // checkBox_mouse_delete
            // 
            this.checkBox_mouse_delete.AutoSize = true;
            this.checkBox_mouse_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_mouse_delete.Location = new System.Drawing.Point(1172, 345);
            this.checkBox_mouse_delete.Name = "checkBox_mouse_delete";
            this.checkBox_mouse_delete.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mouse_delete.TabIndex = 32;
            this.checkBox_mouse_delete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1068, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Adding";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1151, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Deleting";
            // 
            // button_scramble
            // 
            this.button_scramble.Location = new System.Drawing.Point(1307, 246);
            this.button_scramble.Name = "button_scramble";
            this.button_scramble.Size = new System.Drawing.Size(61, 20);
            this.button_scramble.TabIndex = 37;
            this.button_scramble.Text = "Scramble";
            this.button_scramble.UseVisualStyleBackColor = true;
            this.button_scramble.Click += new System.EventHandler(this.button_scramble_Click);
            // 
            // textBox_MC_unique_ids
            // 
            this.textBox_MC_unique_ids.AllowDrop = true;
            this.textBox_MC_unique_ids.Location = new System.Drawing.Point(1307, 220);
            this.textBox_MC_unique_ids.Name = "textBox_MC_unique_ids";
            this.textBox_MC_unique_ids.Size = new System.Drawing.Size(61, 20);
            this.textBox_MC_unique_ids.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_kT_value);
            this.groupBox3.Controls.Add(this.radioButton_type_of_iter_CA);
            this.groupBox3.Controls.Add(this.radioButton_type_of_iter_MC);
            this.groupBox3.Location = new System.Drawing.Point(1261, 686);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 101);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Next iteration generated with";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(104, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "kT";
            // 
            // textBox_kT_value
            // 
            this.textBox_kT_value.AllowDrop = true;
            this.textBox_kT_value.Location = new System.Drawing.Point(128, 65);
            this.textBox_kT_value.Name = "textBox_kT_value";
            this.textBox_kT_value.Size = new System.Drawing.Size(34, 20);
            this.textBox_kT_value.TabIndex = 25;
            // 
            // radioButton_type_of_iter_CA
            // 
            this.radioButton_type_of_iter_CA.AutoSize = true;
            this.radioButton_type_of_iter_CA.Location = new System.Drawing.Point(23, 30);
            this.radioButton_type_of_iter_CA.Name = "radioButton_type_of_iter_CA";
            this.radioButton_type_of_iter_CA.Size = new System.Drawing.Size(107, 17);
            this.radioButton_type_of_iter_CA.TabIndex = 18;
            this.radioButton_type_of_iter_CA.TabStop = true;
            this.radioButton_type_of_iter_CA.Text = "Cellular Automata";
            this.radioButton_type_of_iter_CA.UseVisualStyleBackColor = true;
            this.radioButton_type_of_iter_CA.CheckedChanged += new System.EventHandler(this.radioButton_type_of_iter_CA_CheckedChanged);
            // 
            // radioButton_type_of_iter_MC
            // 
            this.radioButton_type_of_iter_MC.AutoSize = true;
            this.radioButton_type_of_iter_MC.Location = new System.Drawing.Point(23, 65);
            this.radioButton_type_of_iter_MC.Name = "radioButton_type_of_iter_MC";
            this.radioButton_type_of_iter_MC.Size = new System.Drawing.Size(82, 17);
            this.radioButton_type_of_iter_MC.TabIndex = 19;
            this.radioButton_type_of_iter_MC.TabStop = true;
            this.radioButton_type_of_iter_MC.Text = "Monte Carlo";
            this.radioButton_type_of_iter_MC.UseVisualStyleBackColor = true;
            // 
            // button_recal_edges
            // 
            this.button_recal_edges.Location = new System.Drawing.Point(45, 43);
            this.button_recal_edges.Name = "button_recal_edges";
            this.button_recal_edges.Size = new System.Drawing.Size(78, 25);
            this.button_recal_edges.TabIndex = 39;
            this.button_recal_edges.Text = "recal Edges";
            this.button_recal_edges.UseVisualStyleBackColor = true;
            this.button_recal_edges.Click += new System.EventHandler(this.button_high_edges_Click);
            // 
            // button_edges_on_off
            // 
            this.button_edges_on_off.Location = new System.Drawing.Point(133, 43);
            this.button_edges_on_off.Name = "button_edges_on_off";
            this.button_edges_on_off.Size = new System.Drawing.Size(38, 25);
            this.button_edges_on_off.TabIndex = 40;
            this.button_edges_on_off.Text = "Off";
            this.button_edges_on_off.UseVisualStyleBackColor = true;
            this.button_edges_on_off.Click += new System.EventHandler(this.button_edges_on_off_Click);
            // 
            // label_stat_coverage
            // 
            this.label_stat_coverage.AutoSize = true;
            this.label_stat_coverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_stat_coverage.Location = new System.Drawing.Point(1042, 25);
            this.label_stat_coverage.Name = "label_stat_coverage";
            this.label_stat_coverage.Size = new System.Drawing.Size(91, 13);
            this.label_stat_coverage.TabIndex = 41;
            this.label_stat_coverage.Text = "Coverage   100 %";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_whole_energy);
            this.groupBox4.Controls.Add(this.checkBox_Coverage_percent);
            this.groupBox4.Controls.Add(this.checkBox_how_many_grains);
            this.groupBox4.Location = new System.Drawing.Point(1261, 542);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 114);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slice stats";
            // 
            // checkBox_whole_energy
            // 
            this.checkBox_whole_energy.AutoSize = true;
            this.checkBox_whole_energy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox_whole_energy.Location = new System.Drawing.Point(22, 75);
            this.checkBox_whole_energy.Name = "checkBox_whole_energy";
            this.checkBox_whole_energy.Size = new System.Drawing.Size(106, 17);
            this.checkBox_whole_energy.TabIndex = 35;
            this.checkBox_whole_energy.Text = "Energy of system";
            this.checkBox_whole_energy.UseVisualStyleBackColor = true;
            // 
            // checkBox_Coverage_percent
            // 
            this.checkBox_Coverage_percent.AutoSize = true;
            this.checkBox_Coverage_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox_Coverage_percent.Location = new System.Drawing.Point(22, 28);
            this.checkBox_Coverage_percent.Name = "checkBox_Coverage_percent";
            this.checkBox_Coverage_percent.Size = new System.Drawing.Size(111, 17);
            this.checkBox_Coverage_percent.TabIndex = 34;
            this.checkBox_Coverage_percent.Text = "Coverage percent";
            this.checkBox_Coverage_percent.UseVisualStyleBackColor = true;
            // 
            // checkBox_how_many_grains
            // 
            this.checkBox_how_many_grains.AutoSize = true;
            this.checkBox_how_many_grains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox_how_many_grains.Location = new System.Drawing.Point(22, 52);
            this.checkBox_how_many_grains.Name = "checkBox_how_many_grains";
            this.checkBox_how_many_grains.Size = new System.Drawing.Size(106, 17);
            this.checkBox_how_many_grains.TabIndex = 33;
            this.checkBox_how_many_grains.Text = "Number of grains";
            this.checkBox_how_many_grains.UseVisualStyleBackColor = true;
            // 
            // label_number_of_grains
            // 
            this.label_number_of_grains.AutoSize = true;
            this.label_number_of_grains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_number_of_grains.Location = new System.Drawing.Point(1042, 48);
            this.label_number_of_grains.Name = "label_number_of_grains";
            this.label_number_of_grains.Size = new System.Drawing.Size(82, 13);
            this.label_number_of_grains.TabIndex = 43;
            this.label_number_of_grains.Text = "Grains         100";
            // 
            // button_background_phase
            // 
            this.button_background_phase.Location = new System.Drawing.Point(1045, 412);
            this.button_background_phase.Name = "button_background_phase";
            this.button_background_phase.Size = new System.Drawing.Size(91, 30);
            this.button_background_phase.TabIndex = 44;
            this.button_background_phase.Text = "Fill background";
            this.button_background_phase.UseVisualStyleBackColor = true;
            this.button_background_phase.Click += new System.EventHandler(this.button_background_phase_Click);
            // 
            // button_work_dir
            // 
            this.button_work_dir.Location = new System.Drawing.Point(1356, 957);
            this.button_work_dir.Name = "button_work_dir";
            this.button_work_dir.Size = new System.Drawing.Size(73, 42);
            this.button_work_dir.TabIndex = 45;
            this.button_work_dir.Text = "work dir";
            this.button_work_dir.UseVisualStyleBackColor = true;
            this.button_work_dir.Click += new System.EventHandler(this.button_work_dir_Click_1);
            // 
            // button_see_output
            // 
            this.button_see_output.Location = new System.Drawing.Point(1261, 957);
            this.button_see_output.Name = "button_see_output";
            this.button_see_output.Size = new System.Drawing.Size(89, 42);
            this.button_see_output.TabIndex = 46;
            this.button_see_output.Text = "see output";
            this.button_see_output.UseVisualStyleBackColor = true;
            this.button_see_output.Click += new System.EventHandler(this.button_see_output_Click);
            // 
            // button_2_phases
            // 
            this.button_2_phases.Location = new System.Drawing.Point(1142, 412);
            this.button_2_phases.Name = "button_2_phases";
            this.button_2_phases.Size = new System.Drawing.Size(86, 30);
            this.button_2_phases.TabIndex = 47;
            this.button_2_phases.Text = "2 phases";
            this.button_2_phases.UseVisualStyleBackColor = true;
            this.button_2_phases.Click += new System.EventHandler(this.button_2_phases_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(1041, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 24);
            this.label13.TabIndex = 48;
            this.label13.Text = "After deletion";
            // 
            // button_energy_on_off
            // 
            this.button_energy_on_off.Location = new System.Drawing.Point(133, 74);
            this.button_energy_on_off.Name = "button_energy_on_off";
            this.button_energy_on_off.Size = new System.Drawing.Size(38, 25);
            this.button_energy_on_off.TabIndex = 50;
            this.button_energy_on_off.Text = "Off";
            this.button_energy_on_off.UseVisualStyleBackColor = true;
            this.button_energy_on_off.Click += new System.EventHandler(this.button_energy_on_off_Click);
            // 
            // button_recal_energy
            // 
            this.button_recal_energy.Location = new System.Drawing.Point(45, 74);
            this.button_recal_energy.Name = "button_recal_energy";
            this.button_recal_energy.Size = new System.Drawing.Size(78, 25);
            this.button_recal_energy.TabIndex = 49;
            this.button_recal_energy.Text = "recal Energy";
            this.button_recal_energy.UseVisualStyleBackColor = true;
            this.button_recal_energy.Click += new System.EventHandler(this.button_recal_energy_Click);
            // 
            // label_energy_of_system
            // 
            this.label_energy_of_system.AutoSize = true;
            this.label_energy_of_system.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_energy_of_system.Location = new System.Drawing.Point(1042, 68);
            this.label_energy_of_system.Name = "label_energy_of_system";
            this.label_energy_of_system.Size = new System.Drawing.Size(82, 13);
            this.label_energy_of_system.TabIndex = 51;
            this.label_energy_of_system.Text = "Energy      1221";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(10, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Auto";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_auto_energy);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.checkBox_auto_edges);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.button_energy_on_off);
            this.groupBox5.Controls.Add(this.button_recal_edges);
            this.groupBox5.Controls.Add(this.button_recal_energy);
            this.groupBox5.Controls.Add(this.button_edges_on_off);
            this.groupBox5.Location = new System.Drawing.Point(1045, 566);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 108);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filters";
            // 
            // checkBox_auto_energy
            // 
            this.checkBox_auto_energy.AutoSize = true;
            this.checkBox_auto_energy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox_auto_energy.Location = new System.Drawing.Point(18, 80);
            this.checkBox_auto_energy.Name = "checkBox_auto_energy";
            this.checkBox_auto_energy.Size = new System.Drawing.Size(15, 14);
            this.checkBox_auto_energy.TabIndex = 56;
            this.checkBox_auto_energy.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(132, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Switch";
            // 
            // checkBox_auto_edges
            // 
            this.checkBox_auto_edges.AutoSize = true;
            this.checkBox_auto_edges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox_auto_edges.Location = new System.Drawing.Point(18, 49);
            this.checkBox_auto_edges.Name = "checkBox_auto_edges";
            this.checkBox_auto_edges.Size = new System.Drawing.Size(15, 14);
            this.checkBox_auto_edges.TabIndex = 55;
            this.checkBox_auto_edges.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(63, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Manual";
            // 
            // label_iter_and_time_of_simulation
            // 
            this.label_iter_and_time_of_simulation.AutoSize = true;
            this.label_iter_and_time_of_simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_iter_and_time_of_simulation.Location = new System.Drawing.Point(1042, 687);
            this.label_iter_and_time_of_simulation.Name = "label_iter_and_time_of_simulation";
            this.label_iter_and_time_of_simulation.Size = new System.Drawing.Size(118, 13);
            this.label_iter_and_time_of_simulation.TabIndex = 55;
            this.label_iter_and_time_of_simulation.Text = "00 m 50 s   -   iter. 1232";
            // 
            // checkBox_3D
            // 
            this.checkBox_3D.AutoSize = true;
            this.checkBox_3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBox_3D.Location = new System.Drawing.Point(1046, 838);
            this.checkBox_3D.Name = "checkBox_3D";
            this.checkBox_3D.Size = new System.Drawing.Size(40, 17);
            this.checkBox_3D.TabIndex = 56;
            this.checkBox_3D.Text = "3D";
            this.checkBox_3D.UseVisualStyleBackColor = true;
            this.checkBox_3D.CheckedChanged += new System.EventHandler(this.checkBox_3D_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(1257, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 24);
            this.label17.TabIndex = 57;
            this.label17.Text = "MC unique ids";
            // 
            // textBox_slice_number
            // 
            this.textBox_slice_number.AllowDrop = true;
            this.textBox_slice_number.Location = new System.Drawing.Point(1166, 858);
            this.textBox_slice_number.Name = "textBox_slice_number";
            this.textBox_slice_number.Size = new System.Drawing.Size(60, 20);
            this.textBox_slice_number.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(1042, 859);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Slice visualized";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1187, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "x";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(1187, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 16);
            this.label18.TabIndex = 61;
            this.label18.Text = "y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(1187, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 16);
            this.label19.TabIndex = 62;
            this.label19.Text = "z";
            // 
            // textBox_matrix_depth
            // 
            this.textBox_matrix_depth.AllowDrop = true;
            this.textBox_matrix_depth.Location = new System.Drawing.Point(1217, 112);
            this.textBox_matrix_depth.Name = "textBox_matrix_depth";
            this.textBox_matrix_depth.Size = new System.Drawing.Size(52, 20);
            this.textBox_matrix_depth.TabIndex = 63;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton_save_to_png);
            this.groupBox6.Controls.Add(this.radioButton_save_to_ovito);
            this.groupBox6.Location = new System.Drawing.Point(1261, 857);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 82);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File format";
            // 
            // radioButton_save_to_png
            // 
            this.radioButton_save_to_png.AutoSize = true;
            this.radioButton_save_to_png.Location = new System.Drawing.Point(23, 24);
            this.radioButton_save_to_png.Name = "radioButton_save_to_png";
            this.radioButton_save_to_png.Size = new System.Drawing.Size(81, 17);
            this.radioButton_save_to_png.TabIndex = 18;
            this.radioButton_save_to_png.TabStop = true;
            this.radioButton_save_to_png.Text = "png        2D";
            this.radioButton_save_to_png.UseVisualStyleBackColor = true;
            // 
            // radioButton_save_to_ovito
            // 
            this.radioButton_save_to_ovito.AutoSize = true;
            this.radioButton_save_to_ovito.Location = new System.Drawing.Point(23, 51);
            this.radioButton_save_to_ovito.Name = "radioButton_save_to_ovito";
            this.radioButton_save_to_ovito.Size = new System.Drawing.Size(105, 17);
            this.radioButton_save_to_ovito.TabIndex = 19;
            this.radioButton_save_to_ovito.TabStop = true;
            this.radioButton_save_to_ovito.Text = "ovito      2D / 3D";
            this.radioButton_save_to_ovito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 1048);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.textBox_matrix_depth);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_slice_number);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkBox_3D);
            this.Controls.Add(this.label_iter_and_time_of_simulation);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label_energy_of_system);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_2_phases);
            this.Controls.Add(this.button_see_output);
            this.Controls.Add(this.button_work_dir);
            this.Controls.Add(this.button_background_phase);
            this.Controls.Add(this.label_number_of_grains);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label_stat_coverage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_scramble);
            this.Controls.Add(this.textBox_MC_unique_ids);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox_mouse_delete);
            this.Controls.Add(this.checkBox_mouse_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_homogeneous_apply);
            this.Controls.Add(this.textBox_homogeneous_row);
            this.Controls.Add(this.textBox_homogeneous_col);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_save_image);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_color_reshuffle);
            this.Controls.Add(this.button_apply_modyfie);
            this.Controls.Add(this.button_add_seed_2);
            this.Controls.Add(this.textBox_seed_number_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_add_seed_1);
            this.Controls.Add(this.textBox_seed_number_1);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_main_show_matrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_matrix_height);
            this.Controls.Add(this.textBox_matrix_width);
            this.Controls.Add(this.button_start_stop);
            this.Name = "Form1";
            this.Text = "Grainin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.apply_window_position);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_show_matrix)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start_stop;
        private System.Windows.Forms.TextBox textBox_matrix_width;
        private System.Windows.Forms.TextBox textBox_matrix_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_main_show_matrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.TextBox textBox_seed_number_1;
        private System.Windows.Forms.Button button_add_seed_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add_seed_2;
        private System.Windows.Forms.TextBox textBox_seed_number_2;
        private System.Windows.Forms.Button button_apply_modyfie;
        private System.Windows.Forms.Button button_color_reshuffle;
        private System.Windows.Forms.RadioButton radioButton_periodic;
        private System.Windows.Forms.RadioButton radioButton_hard_stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_von_nueman;
        private System.Windows.Forms.RadioButton radioButton_moore;
        private System.Windows.Forms.Button button_save_image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_homogeneous_row;
        private System.Windows.Forms.TextBox textBox_homogeneous_col;
        private System.Windows.Forms.Button button_homogeneous_apply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_mouse_add;
        private System.Windows.Forms.RadioButton radioButton_hexa;
        private System.Windows.Forms.RadioButton radioButton_penta;
        private System.Windows.Forms.CheckBox checkBox_mouse_delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_scramble;
        private System.Windows.Forms.TextBox textBox_MC_unique_ids;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_type_of_iter_CA;
        private System.Windows.Forms.RadioButton radioButton_type_of_iter_MC;
        private System.Windows.Forms.Button button_recal_edges;
        private System.Windows.Forms.Button button_edges_on_off;
        private System.Windows.Forms.Label label_stat_coverage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_how_many_grains;
        private System.Windows.Forms.CheckBox checkBox_Coverage_percent;
        private System.Windows.Forms.Label label_number_of_grains;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_kT_value;
        private System.Windows.Forms.Button button_background_phase;
        private System.Windows.Forms.Button button_work_dir;
        private System.Windows.Forms.Button button_see_output;
        private System.Windows.Forms.Button button_2_phases;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_energy_on_off;
        private System.Windows.Forms.Button button_recal_energy;
        private System.Windows.Forms.CheckBox checkBox_whole_energy;
        private System.Windows.Forms.Label label_energy_of_system;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox_auto_energy;
        private System.Windows.Forms.CheckBox checkBox_auto_edges;
        private System.Windows.Forms.Label label_iter_and_time_of_simulation;
        private System.Windows.Forms.CheckBox checkBox_3D;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_slice_number;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_matrix_depth;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton_save_to_png;
        private System.Windows.Forms.RadioButton radioButton_save_to_ovito;
    }
}

