namespace cSharpOnScreenVirtualJoystickController
{
    partial class joystick
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
            this.joystickArea = new System.Windows.Forms.Panel();
            this.movingPart = new System.Windows.Forms.PictureBox();
            this.joystickArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingPart)).BeginInit();
            this.SuspendLayout();
            // 
            // joystickArea
            // 
            this.joystickArea.BackgroundImage = global::cSharpOnScreenVirtualJoystickController.Properties.Resources.JoystickOutline_fw;
            this.joystickArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joystickArea.Controls.Add(this.movingPart);
            this.joystickArea.Location = new System.Drawing.Point(0, 0);
            this.joystickArea.Name = "joystickArea";
            this.joystickArea.Size = new System.Drawing.Size(350, 350);
            this.joystickArea.TabIndex = 3;
            this.joystickArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.joystickArea_MouseDown);
            this.joystickArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.joystickArea_MouseMove);
            this.joystickArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.joystickArea_MouseUp);
            // 
            // movingPart
            // 
            this.movingPart.BackColor = System.Drawing.Color.Transparent;
            this.movingPart.BackgroundImage = global::cSharpOnScreenVirtualJoystickController.Properties.Resources.JoystickInner_fw;
            this.movingPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movingPart.Enabled = false;
            this.movingPart.Location = new System.Drawing.Point(150, 150);
            this.movingPart.Name = "movingPart";
            this.movingPart.Size = new System.Drawing.Size(50, 50);
            this.movingPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movingPart.TabIndex = 0;
            this.movingPart.TabStop = false;
            // 
            // joystick
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.joystickArea);
            this.Name = "joystick";
            this.Text = "joystick";
            this.joystickArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movingPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel joystickArea;
        private System.Windows.Forms.PictureBox movingPart;
    }
}

