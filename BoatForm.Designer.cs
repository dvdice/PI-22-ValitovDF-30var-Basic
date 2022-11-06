
namespace Boats
{
    partial class BoatForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel_speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel_weight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel_color = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_speed,
            this.toolStripLabel_weight,
            this.toolStripLabel_color});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabel_speed
            // 
            this.toolStripLabel_speed.Name = "toolStripLabel_speed";
            this.toolStripLabel_speed.Size = new System.Drawing.Size(76, 20);
            this.toolStripLabel_speed.Text = "Скорость:";
            // 
            // toolStripLabel_weight
            // 
            this.toolStripLabel_weight.Name = "toolStripLabel_weight";
            this.toolStripLabel_weight.Size = new System.Drawing.Size(36, 20);
            this.toolStripLabel_weight.Text = "Вес:";
            // 
            // toolStripLabel_color
            // 
            this.toolStripLabel_color.Name = "toolStripLabel_color";
            this.toolStripLabel_color.Size = new System.Drawing.Size(45, 20);
            this.toolStripLabel_color.Text = "Цвет:";
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBoat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(800, 424);
            this.pictureBoxBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBoat.TabIndex = 1;
            this.pictureBoxBoat.TabStop = false;
            this.pictureBoxBoat.Resize += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.Location = new System.Drawing.Point(13, 13);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(94, 29);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Создать";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_right
            // 
            this.btn_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_right.BackgroundImage = global::SailboatRPP.Properties.Resources.Вправо;
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_right.Location = new System.Drawing.Point(694, 392);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(94, 29);
            this.btn_right.TabIndex = 4;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_down
            // 
            this.btn_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_down.BackgroundImage = global::SailboatRPP.Properties.Resources.down;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(594, 392);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(94, 29);
            this.btn_down.TabIndex = 5;
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_up
            // 
            this.btn_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_up.BackgroundImage = global::SailboatRPP.Properties.Resources.up;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(594, 357);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(94, 29);
            this.btn_up.TabIndex = 6;
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_left
            // 
            this.btn_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_left.BackgroundImage = global::SailboatRPP.Properties.Resources.left;
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_left.Location = new System.Drawing.Point(494, 391);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(94, 29);
            this.btn_left.TabIndex = 7;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // BoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.pictureBoxBoat);
            this.Controls.Add(this.statusStrip1);
            this.Name = "BoatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatForm";
            this.Click += new System.EventHandler(this.btn_move_Click);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_speed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_weight;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_color;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_left;
    }
}

