using MapCreator_Inator.CustomComponents;

namespace MapCreator_Inator
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.maps_tab_menu = new System.Windows.Forms.TabControl();
            this.height_tab = new System.Windows.Forms.TabPage();
            this.brush_panel = new System.Windows.Forms.Panel();
            this.height_brush_hardness_label = new System.Windows.Forms.Label();
            this.height_brush_hardness_numericUD = new System.Windows.Forms.NumericUpDown();
            this.minus_height_brush_width = new System.Windows.Forms.Button();
            this.plus_height_brush_width = new System.Windows.Forms.Button();
            this.height_brush_width_combobox = new System.Windows.Forms.ComboBox();
            this.height_brush_width_label = new System.Windows.Forms.Label();
            this.height_tool_strip = new MapCreator_Inator.CustomComponents.ToolStrip_SingleSelection();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.political_tab = new System.Windows.Forms.TabPage();
            this.info_panel = new System.Windows.Forms.Panel();
            this.hd_checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.map_width_label = new System.Windows.Forms.Label();
            this.octaves_label = new System.Windows.Forms.Label();
            this.octaves_numericUD = new System.Windows.Forms.NumericUpDown();
            this.km_label = new System.Windows.Forms.Label();
            this.show_distance_check_box = new System.Windows.Forms.CheckBox();
            this.distance_numericUD = new System.Windows.Forms.NumericUpDown();
            this.generate_button = new System.Windows.Forms.Button();
            this.nodes_label = new System.Windows.Forms.Label();
            this.nodes_numericUD = new System.Windows.Forms.NumericUpDown();
            this.seed_text_box = new System.Windows.Forms.TextBox();
            this.seed_label = new System.Windows.Forms.Label();
            this.random_seed_check_box = new System.Windows.Forms.CheckBox();
            this.show_nodes_check_box = new System.Windows.Forms.CheckBox();
            this.zoom_label = new System.Windows.Forms.Label();
            this.scale_track_bar = new System.Windows.Forms.TrackBar();
            this.main_menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.map_picture_box = new MapCreator_Inator.PictureBox_NearestNeighbor();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.maps_tab_menu.SuspendLayout();
            this.height_tab.SuspendLayout();
            this.brush_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_brush_hardness_numericUD)).BeginInit();
            this.height_tool_strip.SuspendLayout();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.octaves_numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodes_numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_track_bar)).BeginInit();
            this.main_menu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // maps_tab_menu
            // 
            this.maps_tab_menu.Controls.Add(this.height_tab);
            this.maps_tab_menu.Controls.Add(this.political_tab);
            this.maps_tab_menu.Location = new System.Drawing.Point(717, 33);
            this.maps_tab_menu.Name = "maps_tab_menu";
            this.maps_tab_menu.SelectedIndex = 0;
            this.maps_tab_menu.Size = new System.Drawing.Size(220, 553);
            this.maps_tab_menu.TabIndex = 0;
            this.maps_tab_menu.SelectedIndexChanged += new System.EventHandler(this.maps_tab_menu_SelectedIndexChanged);
            // 
            // height_tab
            // 
            this.height_tab.Controls.Add(this.brush_panel);
            this.height_tab.Controls.Add(this.height_tool_strip);
            this.height_tab.Location = new System.Drawing.Point(4, 22);
            this.height_tab.Name = "height_tab";
            this.height_tab.Padding = new System.Windows.Forms.Padding(3);
            this.height_tab.Size = new System.Drawing.Size(212, 527);
            this.height_tab.TabIndex = 0;
            this.height_tab.Text = "Height Map";
            this.height_tab.UseVisualStyleBackColor = true;
            // 
            // brush_panel
            // 
            this.brush_panel.Controls.Add(this.height_brush_hardness_label);
            this.brush_panel.Controls.Add(this.height_brush_hardness_numericUD);
            this.brush_panel.Controls.Add(this.minus_height_brush_width);
            this.brush_panel.Controls.Add(this.plus_height_brush_width);
            this.brush_panel.Controls.Add(this.height_brush_width_combobox);
            this.brush_panel.Controls.Add(this.height_brush_width_label);
            this.brush_panel.Location = new System.Drawing.Point(7, 39);
            this.brush_panel.Name = "brush_panel";
            this.brush_panel.Size = new System.Drawing.Size(199, 73);
            this.brush_panel.TabIndex = 1;
            // 
            // height_brush_hardness_label
            // 
            this.height_brush_hardness_label.AutoSize = true;
            this.height_brush_hardness_label.Location = new System.Drawing.Point(3, 33);
            this.height_brush_hardness_label.Name = "height_brush_hardness_label";
            this.height_brush_hardness_label.Size = new System.Drawing.Size(55, 13);
            this.height_brush_hardness_label.TabIndex = 5;
            this.height_brush_hardness_label.Text = "Hardness:";
            // 
            // height_brush_hardness_numericUD
            // 
            this.height_brush_hardness_numericUD.Location = new System.Drawing.Point(74, 31);
            this.height_brush_hardness_numericUD.Name = "height_brush_hardness_numericUD";
            this.height_brush_hardness_numericUD.Size = new System.Drawing.Size(122, 20);
            this.height_brush_hardness_numericUD.TabIndex = 4;
            this.height_brush_hardness_numericUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.height_brush_hardness_numericUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // minus_height_brush_width
            // 
            this.minus_height_brush_width.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minus_height_brush_width.BackgroundImage")));
            this.minus_height_brush_width.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minus_height_brush_width.FlatAppearance.BorderSize = 0;
            this.minus_height_brush_width.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus_height_brush_width.Location = new System.Drawing.Point(74, 4);
            this.minus_height_brush_width.Name = "minus_height_brush_width";
            this.minus_height_brush_width.Size = new System.Drawing.Size(21, 21);
            this.minus_height_brush_width.TabIndex = 3;
            this.minus_height_brush_width.UseVisualStyleBackColor = true;
            // 
            // plus_height_brush_width
            // 
            this.plus_height_brush_width.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus_height_brush_width.BackgroundImage")));
            this.plus_height_brush_width.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plus_height_brush_width.FlatAppearance.BorderSize = 0;
            this.plus_height_brush_width.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_height_brush_width.Location = new System.Drawing.Point(175, 4);
            this.plus_height_brush_width.Name = "plus_height_brush_width";
            this.plus_height_brush_width.Size = new System.Drawing.Size(21, 21);
            this.plus_height_brush_width.TabIndex = 2;
            this.plus_height_brush_width.UseVisualStyleBackColor = true;
            // 
            // height_brush_width_combobox
            // 
            this.height_brush_width_combobox.FormattingEnabled = true;
            this.height_brush_width_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "125",
            "150",
            "175",
            "200",
            "225",
            "250",
            "275",
            "300",
            "325",
            "350",
            "375",
            "400",
            "425",
            "450",
            "475",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "900",
            "950",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600",
            "1700",
            "1800",
            "1900",
            "2000"});
            this.height_brush_width_combobox.Location = new System.Drawing.Point(101, 4);
            this.height_brush_width_combobox.Name = "height_brush_width_combobox";
            this.height_brush_width_combobox.Size = new System.Drawing.Size(68, 21);
            this.height_brush_width_combobox.TabIndex = 1;
            // 
            // height_brush_width_label
            // 
            this.height_brush_width_label.AutoSize = true;
            this.height_brush_width_label.Location = new System.Drawing.Point(3, 7);
            this.height_brush_width_label.Name = "height_brush_width_label";
            this.height_brush_width_label.Size = new System.Drawing.Size(65, 13);
            this.height_brush_width_label.TabIndex = 0;
            this.height_brush_width_label.Text = "Brush width:";
            // 
            // height_tool_strip
            // 
            this.height_tool_strip.AutoSize = false;
            this.height_tool_strip.BackColor = System.Drawing.Color.Transparent;
            this.height_tool_strip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.height_tool_strip.Dock = System.Windows.Forms.DockStyle.None;
            this.height_tool_strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.height_tool_strip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.height_tool_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.height_tool_strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.height_tool_strip.Location = new System.Drawing.Point(3, 3);
            this.height_tool_strip.Name = "height_tool_strip";
            this.height_tool_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.height_tool_strip.Size = new System.Drawing.Size(204, 32);
            this.height_tool_strip.TabIndex = 0;
            this.height_tool_strip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.CheckOnClick = true;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.CheckOnClick = true;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.CheckOnClick = true;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // political_tab
            // 
            this.political_tab.Location = new System.Drawing.Point(4, 22);
            this.political_tab.Name = "political_tab";
            this.political_tab.Padding = new System.Windows.Forms.Padding(3);
            this.political_tab.Size = new System.Drawing.Size(212, 527);
            this.political_tab.TabIndex = 1;
            this.political_tab.Text = "Political Map";
            this.political_tab.UseVisualStyleBackColor = true;
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.info_panel.Controls.Add(this.hd_checkbox);
            this.info_panel.Controls.Add(this.label2);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Controls.Add(this.map_width_label);
            this.info_panel.Controls.Add(this.octaves_label);
            this.info_panel.Controls.Add(this.octaves_numericUD);
            this.info_panel.Controls.Add(this.km_label);
            this.info_panel.Controls.Add(this.show_distance_check_box);
            this.info_panel.Controls.Add(this.distance_numericUD);
            this.info_panel.Controls.Add(this.generate_button);
            this.info_panel.Controls.Add(this.nodes_label);
            this.info_panel.Controls.Add(this.nodes_numericUD);
            this.info_panel.Controls.Add(this.seed_text_box);
            this.info_panel.Controls.Add(this.seed_label);
            this.info_panel.Controls.Add(this.random_seed_check_box);
            this.info_panel.Controls.Add(this.show_nodes_check_box);
            this.info_panel.Controls.Add(this.zoom_label);
            this.info_panel.Controls.Add(this.scale_track_bar);
            this.info_panel.Location = new System.Drawing.Point(9, 33);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(200, 553);
            this.info_panel.TabIndex = 1;
            // 
            // hd_checkbox
            // 
            this.hd_checkbox.AutoSize = true;
            this.hd_checkbox.Checked = true;
            this.hd_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hd_checkbox.Location = new System.Drawing.Point(7, 129);
            this.hd_checkbox.Name = "hd_checkbox";
            this.hd_checkbox.Size = new System.Drawing.Size(42, 17);
            this.hd_checkbox.TabIndex = 20;
            this.hd_checkbox.Text = "HD";
            this.hd_checkbox.UseVisualStyleBackColor = true;
            this.hd_checkbox.CheckedChanged += new System.EventHandler(this.hd_checkbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 2);
            this.label2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 2);
            this.label1.TabIndex = 18;
            // 
            // map_width_label
            // 
            this.map_width_label.AutoSize = true;
            this.map_width_label.Location = new System.Drawing.Point(7, 105);
            this.map_width_label.Name = "map_width_label";
            this.map_width_label.Size = new System.Drawing.Size(62, 13);
            this.map_width_label.TabIndex = 17;
            this.map_width_label.Text = "Map Width:";
            // 
            // octaves_label
            // 
            this.octaves_label.AutoSize = true;
            this.octaves_label.Location = new System.Drawing.Point(7, 244);
            this.octaves_label.Name = "octaves_label";
            this.octaves_label.Size = new System.Drawing.Size(100, 13);
            this.octaves_label.TabIndex = 16;
            this.octaves_label.Text = "Number of octaves:";
            // 
            // octaves_numericUD
            // 
            this.octaves_numericUD.Location = new System.Drawing.Point(113, 242);
            this.octaves_numericUD.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.octaves_numericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.octaves_numericUD.Name = "octaves_numericUD";
            this.octaves_numericUD.Size = new System.Drawing.Size(76, 20);
            this.octaves_numericUD.TabIndex = 15;
            this.octaves_numericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.octaves_numericUD.ValueChanged += new System.EventHandler(this.octaves_numericUD_ValueChanged);
            // 
            // km_label
            // 
            this.km_label.AutoSize = true;
            this.km_label.Location = new System.Drawing.Point(168, 105);
            this.km_label.Name = "km_label";
            this.km_label.Size = new System.Drawing.Size(21, 13);
            this.km_label.TabIndex = 14;
            this.km_label.Text = "km";
            // 
            // show_distance_check_box
            // 
            this.show_distance_check_box.AutoSize = true;
            this.show_distance_check_box.Location = new System.Drawing.Point(7, 80);
            this.show_distance_check_box.Name = "show_distance_check_box";
            this.show_distance_check_box.Size = new System.Drawing.Size(83, 17);
            this.show_distance_check_box.TabIndex = 13;
            this.show_distance_check_box.Text = "Show Scale";
            this.show_distance_check_box.UseVisualStyleBackColor = true;
            this.show_distance_check_box.CheckedChanged += new System.EventHandler(this.check_box_CheckedChanged);
            // 
            // distance_numericUD
            // 
            this.distance_numericUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.distance_numericUD.Location = new System.Drawing.Point(74, 103);
            this.distance_numericUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.distance_numericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distance_numericUD.Name = "distance_numericUD";
            this.distance_numericUD.Size = new System.Drawing.Size(88, 20);
            this.distance_numericUD.TabIndex = 12;
            this.distance_numericUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.distance_numericUD.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.distance_numericUD.ValueChanged += new System.EventHandler(this.distance_numericUD_ValueChanged);
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(10, 268);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(180, 23);
            this.generate_button.TabIndex = 10;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // nodes_label
            // 
            this.nodes_label.AutoSize = true;
            this.nodes_label.Location = new System.Drawing.Point(7, 216);
            this.nodes_label.Name = "nodes_label";
            this.nodes_label.Size = new System.Drawing.Size(91, 13);
            this.nodes_label.TabIndex = 9;
            this.nodes_label.Text = "Number of nodes:";
            // 
            // nodes_numericUD
            // 
            this.nodes_numericUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nodes_numericUD.Location = new System.Drawing.Point(113, 216);
            this.nodes_numericUD.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nodes_numericUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nodes_numericUD.Name = "nodes_numericUD";
            this.nodes_numericUD.Size = new System.Drawing.Size(77, 20);
            this.nodes_numericUD.TabIndex = 8;
            this.nodes_numericUD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nodes_numericUD.ValueChanged += new System.EventHandler(this.nodes_numericUD_ValueChanged);
            // 
            // seed_text_box
            // 
            this.seed_text_box.Enabled = false;
            this.seed_text_box.Location = new System.Drawing.Point(48, 188);
            this.seed_text_box.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.seed_text_box.Name = "seed_text_box";
            this.seed_text_box.Size = new System.Drawing.Size(142, 20);
            this.seed_text_box.TabIndex = 7;
            this.seed_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seed_text_box_KeyPress);
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Location = new System.Drawing.Point(7, 191);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(35, 13);
            this.seed_label.TabIndex = 6;
            this.seed_label.Text = "Seed:";
            // 
            // random_seed_check_box
            // 
            this.random_seed_check_box.AutoSize = true;
            this.random_seed_check_box.Checked = true;
            this.random_seed_check_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.random_seed_check_box.Location = new System.Drawing.Point(7, 171);
            this.random_seed_check_box.Name = "random_seed_check_box";
            this.random_seed_check_box.Size = new System.Drawing.Size(116, 17);
            this.random_seed_check_box.TabIndex = 5;
            this.random_seed_check_box.Text = "Use Random Seed";
            this.random_seed_check_box.UseVisualStyleBackColor = true;
            this.random_seed_check_box.CheckedChanged += new System.EventHandler(this.random_seed_check_box_CheckedChanged);
            // 
            // show_nodes_check_box
            // 
            this.show_nodes_check_box.AutoSize = true;
            this.show_nodes_check_box.Location = new System.Drawing.Point(7, 56);
            this.show_nodes_check_box.Name = "show_nodes_check_box";
            this.show_nodes_check_box.Size = new System.Drawing.Size(87, 17);
            this.show_nodes_check_box.TabIndex = 4;
            this.show_nodes_check_box.Text = "Show Nodes";
            this.show_nodes_check_box.UseVisualStyleBackColor = true;
            this.show_nodes_check_box.CheckedChanged += new System.EventHandler(this.check_box_CheckedChanged);
            // 
            // zoom_label
            // 
            this.zoom_label.AutoSize = true;
            this.zoom_label.Location = new System.Drawing.Point(4, 4);
            this.zoom_label.Name = "zoom_label";
            this.zoom_label.Size = new System.Drawing.Size(37, 13);
            this.zoom_label.TabIndex = 3;
            this.zoom_label.Text = "Zoom:";
            // 
            // scale_track_bar
            // 
            this.scale_track_bar.Location = new System.Drawing.Point(3, 20);
            this.scale_track_bar.Maximum = 110;
            this.scale_track_bar.Name = "scale_track_bar";
            this.scale_track_bar.Size = new System.Drawing.Size(193, 45);
            this.scale_track_bar.TabIndex = 2;
            this.scale_track_bar.TickFrequency = 10;
            this.scale_track_bar.ValueChanged += new System.EventHandler(this.scale_track_bar_ValueChanged);
            // 
            // main_menu_strip
            // 
            this.main_menu_strip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.main_menu_strip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.main_menu_strip.Location = new System.Drawing.Point(0, 0);
            this.main_menu_strip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.main_menu_strip.Name = "main_menu_strip";
            this.main_menu_strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_menu_strip.Size = new System.Drawing.Size(949, 24);
            this.main_menu_strip.TabIndex = 2;
            this.main_menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // map_picture_box
            // 
            this.map_picture_box.Cursor = System.Windows.Forms.Cursors.Cross;
            this.map_picture_box.Location = new System.Drawing.Point(215, 33);
            this.map_picture_box.Name = "map_picture_box";
            this.map_picture_box.Size = new System.Drawing.Size(496, 553);
            this.map_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map_picture_box.TabIndex = 0;
            this.map_picture_box.TabStop = false;
            this.map_picture_box.Paint += new System.Windows.Forms.PaintEventHandler(this.map_picture_box_Paint);
            this.map_picture_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_picture_box_MouseMove);
            this.map_picture_box.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.map_picture_box_Wheel);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.CheckOnClick = true;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 598);
            this.Controls.Add(this.map_picture_box);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.maps_tab_menu);
            this.Controls.Add(this.main_menu_strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MapCreator-Inator";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.maps_tab_menu.ResumeLayout(false);
            this.height_tab.ResumeLayout(false);
            this.brush_panel.ResumeLayout(false);
            this.brush_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_brush_hardness_numericUD)).EndInit();
            this.height_tool_strip.ResumeLayout(false);
            this.height_tool_strip.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.octaves_numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodes_numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_track_bar)).EndInit();
            this.main_menu_strip.ResumeLayout(false);
            this.main_menu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl maps_tab_menu;
        private System.Windows.Forms.TabPage height_tab;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.TabPage political_tab;
        private System.Windows.Forms.MenuStrip main_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private PictureBox_NearestNeighbor map_picture_box;
        private System.Windows.Forms.TrackBar scale_track_bar;
        private System.Windows.Forms.Label zoom_label;
        private System.Windows.Forms.CheckBox show_nodes_check_box;
        private System.Windows.Forms.TextBox seed_text_box;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.CheckBox random_seed_check_box;
        private System.Windows.Forms.Label nodes_label;
        private System.Windows.Forms.NumericUpDown nodes_numericUD;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.NumericUpDown distance_numericUD;
        private System.Windows.Forms.CheckBox show_distance_check_box;
        private System.Windows.Forms.Label km_label;
        private System.Windows.Forms.Label octaves_label;
        private System.Windows.Forms.NumericUpDown octaves_numericUD;
        private System.Windows.Forms.Label map_width_label;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox hd_checkbox;
        private ToolStrip_SingleSelection height_tool_strip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Panel brush_panel;
        private System.Windows.Forms.Button plus_height_brush_width;
        private System.Windows.Forms.ComboBox height_brush_width_combobox;
        private System.Windows.Forms.Label height_brush_width_label;
        private System.Windows.Forms.Button minus_height_brush_width;
        private System.Windows.Forms.Label height_brush_hardness_label;
        private System.Windows.Forms.NumericUpDown height_brush_hardness_numericUD;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

