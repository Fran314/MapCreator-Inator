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
            this.political_tab = new System.Windows.Forms.TabPage();
            this.map_picture_box = new System.Windows.Forms.PictureBox();
            this.info_panel = new System.Windows.Forms.Panel();
            this.octaves_label = new System.Windows.Forms.Label();
            this.octaves_numericUD = new System.Windows.Forms.NumericUpDown();
            this.km_label = new System.Windows.Forms.Label();
            this.show_distance_check_box = new System.Windows.Forms.CheckBox();
            this.distance_numericUD = new System.Windows.Forms.NumericUpDown();
            this.randomize_button = new System.Windows.Forms.Button();
            this.nodes_label = new System.Windows.Forms.Label();
            this.nodes_numericUD = new System.Windows.Forms.NumericUpDown();
            this.seed_text_box = new System.Windows.Forms.TextBox();
            this.seed_label = new System.Windows.Forms.Label();
            this.random_seed_check_box = new System.Windows.Forms.CheckBox();
            this.show_nodes_check_box = new System.Windows.Forms.CheckBox();
            this.zoom_label = new System.Windows.Forms.Label();
            this.scale_track_bar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.map_width_label = new System.Windows.Forms.Label();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maps_tab_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_picture_box)).BeginInit();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.octaves_numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodes_numericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_track_bar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maps_tab_menu
            // 
            this.maps_tab_menu.Controls.Add(this.height_tab);
            this.maps_tab_menu.Controls.Add(this.political_tab);
            this.maps_tab_menu.Location = new System.Drawing.Point(214, 482);
            this.maps_tab_menu.Name = "maps_tab_menu";
            this.maps_tab_menu.SelectedIndex = 0;
            this.maps_tab_menu.Size = new System.Drawing.Size(723, 104);
            this.maps_tab_menu.TabIndex = 0;
            this.maps_tab_menu.SelectedIndexChanged += new System.EventHandler(this.maps_tab_menu_SelectedIndexChanged);
            // 
            // height_tab
            // 
            this.height_tab.Location = new System.Drawing.Point(4, 22);
            this.height_tab.Name = "height_tab";
            this.height_tab.Padding = new System.Windows.Forms.Padding(3);
            this.height_tab.Size = new System.Drawing.Size(715, 78);
            this.height_tab.TabIndex = 0;
            this.height_tab.Text = "Height Map";
            this.height_tab.UseVisualStyleBackColor = true;
            // 
            // political_tab
            // 
            this.political_tab.Location = new System.Drawing.Point(4, 22);
            this.political_tab.Name = "political_tab";
            this.political_tab.Padding = new System.Windows.Forms.Padding(3);
            this.political_tab.Size = new System.Drawing.Size(715, 78);
            this.political_tab.TabIndex = 1;
            this.political_tab.Text = "Political Map";
            this.political_tab.UseVisualStyleBackColor = true;
            // 
            // map_picture_box
            // 
            this.map_picture_box.Cursor = System.Windows.Forms.Cursors.Cross;
            this.map_picture_box.Location = new System.Drawing.Point(212, 33);
            this.map_picture_box.Name = "map_picture_box";
            this.map_picture_box.Size = new System.Drawing.Size(725, 443);
            this.map_picture_box.TabIndex = 0;
            this.map_picture_box.TabStop = false;
            this.map_picture_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.height_picture_box_MouseMove);
            this.map_picture_box.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.height_map_panel_Wheel);
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.info_panel.Controls.Add(this.map_width_label);
            this.info_panel.Controls.Add(this.octaves_label);
            this.info_panel.Controls.Add(this.octaves_numericUD);
            this.info_panel.Controls.Add(this.km_label);
            this.info_panel.Controls.Add(this.show_distance_check_box);
            this.info_panel.Controls.Add(this.distance_numericUD);
            this.info_panel.Controls.Add(this.randomize_button);
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
            this.info_panel.Size = new System.Drawing.Size(199, 553);
            this.info_panel.TabIndex = 1;
            // 
            // octaves_label
            // 
            this.octaves_label.AutoSize = true;
            this.octaves_label.Location = new System.Drawing.Point(7, 179);
            this.octaves_label.Name = "octaves_label";
            this.octaves_label.Size = new System.Drawing.Size(100, 13);
            this.octaves_label.TabIndex = 16;
            this.octaves_label.Text = "Number of octaves:";
            // 
            // octaves_numericUD
            // 
            this.octaves_numericUD.Location = new System.Drawing.Point(113, 177);
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
            this.km_label.Location = new System.Drawing.Point(168, 234);
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
            this.distance_numericUD.Location = new System.Drawing.Point(74, 232);
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
            1,
            0,
            0,
            0});
            this.distance_numericUD.ValueChanged += new System.EventHandler(this.distance_numericUD_ValueChanged);
            // 
            // randomize_button
            // 
            this.randomize_button.Location = new System.Drawing.Point(10, 203);
            this.randomize_button.Name = "randomize_button";
            this.randomize_button.Size = new System.Drawing.Size(180, 23);
            this.randomize_button.TabIndex = 10;
            this.randomize_button.Text = "Randomize";
            this.randomize_button.UseVisualStyleBackColor = true;
            this.randomize_button.Click += new System.EventHandler(this.randomize_button_Click);
            // 
            // nodes_label
            // 
            this.nodes_label.AutoSize = true;
            this.nodes_label.Location = new System.Drawing.Point(7, 152);
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
            this.nodes_numericUD.Location = new System.Drawing.Point(113, 150);
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
            this.seed_text_box.Location = new System.Drawing.Point(48, 124);
            this.seed_text_box.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.seed_text_box.Name = "seed_text_box";
            this.seed_text_box.Size = new System.Drawing.Size(142, 20);
            this.seed_text_box.TabIndex = 7;
            this.seed_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seed_text_box_KeyPress);
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Location = new System.Drawing.Point(7, 127);
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
            this.random_seed_check_box.Location = new System.Drawing.Point(7, 103);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // map_width_label
            // 
            this.map_width_label.AutoSize = true;
            this.map_width_label.Location = new System.Drawing.Point(6, 234);
            this.map_width_label.Name = "map_width_label";
            this.map_width_label.Size = new System.Drawing.Size(62, 13);
            this.map_width_label.TabIndex = 17;
            this.map_width_label.Text = "Map Width:";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 598);
            this.Controls.Add(this.map_picture_box);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.maps_tab_menu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MapCreator-Inator";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.maps_tab_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map_picture_box)).EndInit();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.octaves_numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodes_numericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_track_bar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl maps_tab_menu;
        private System.Windows.Forms.TabPage height_tab;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.TabPage political_tab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.PictureBox map_picture_box;
        private System.Windows.Forms.TrackBar scale_track_bar;
        private System.Windows.Forms.Label zoom_label;
        private System.Windows.Forms.CheckBox show_nodes_check_box;
        private System.Windows.Forms.TextBox seed_text_box;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.CheckBox random_seed_check_box;
        private System.Windows.Forms.Label nodes_label;
        private System.Windows.Forms.NumericUpDown nodes_numericUD;
        private System.Windows.Forms.Button randomize_button;
        private System.Windows.Forms.NumericUpDown distance_numericUD;
        private System.Windows.Forms.CheckBox show_distance_check_box;
        private System.Windows.Forms.Label km_label;
        private System.Windows.Forms.Label octaves_label;
        private System.Windows.Forms.NumericUpDown octaves_numericUD;
        private System.Windows.Forms.Label map_width_label;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

