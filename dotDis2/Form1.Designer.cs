namespace dotDis2
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
            displistbox = new ListBox();
            addbtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            idlab = new Label();
            namelab = new Label();
            Changebtn = new Button();
            delbtn = new Button();
            conbtn = new Button();
            disconbtn = new Button();
            delbtn2 = new Button();
            SuspendLayout();
            // 
            // displistbox
            // 
            displistbox.FormattingEnabled = true;
            displistbox.Location = new Point(583, 39);
            displistbox.Name = "displistbox";
            displistbox.Size = new Size(159, 304);
            displistbox.TabIndex = 1;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(437, 82);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(115, 29);
            addbtn.TabIndex = 2;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 27);
            textBox2.TabIndex = 4;
            // 
            // idlab
            // 
            idlab.AutoSize = true;
            idlab.Location = new Point(70, 89);
            idlab.Name = "idlab";
            idlab.Size = new Size(24, 20);
            idlab.TabIndex = 5;
            idlab.Text = "ID";
            // 
            // namelab
            // 
            namelab.AutoSize = true;
            namelab.Location = new Point(70, 136);
            namelab.Name = "namelab";
            namelab.Size = new Size(51, 20);
            namelab.TabIndex = 6;
            namelab.Text = "NAME";
            // 
            // Changebtn
            // 
            Changebtn.Location = new Point(437, 136);
            Changebtn.Name = "Changebtn";
            Changebtn.Size = new Size(115, 29);
            Changebtn.TabIndex = 7;
            Changebtn.Text = "Change";
            Changebtn.UseVisualStyleBackColor = true;
            Changebtn.Click += Changebtn_Click;
            // 
            // delbtn
            // 
            delbtn.Location = new Point(437, 185);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(115, 29);
            delbtn.TabIndex = 8;
            delbtn.Text = "Delete by ID";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // conbtn
            // 
            conbtn.Location = new Point(70, 392);
            conbtn.Name = "conbtn";
            conbtn.Size = new Size(94, 29);
            conbtn.TabIndex = 9;
            conbtn.Text = "Connect";
            conbtn.UseVisualStyleBackColor = true;
            conbtn.Click += conbtn_Click;
            // 
            // disconbtn
            // 
            disconbtn.Location = new Point(207, 392);
            disconbtn.Name = "disconbtn";
            disconbtn.Size = new Size(94, 29);
            disconbtn.TabIndex = 10;
            disconbtn.Text = "Disconnect";
            disconbtn.UseVisualStyleBackColor = true;
            disconbtn.Click += disconbtn_Click;
            // 
            // delbtn2
            // 
            delbtn2.Location = new Point(437, 234);
            delbtn2.Name = "delbtn2";
            delbtn2.Size = new Size(115, 49);
            delbtn2.TabIndex = 11;
            delbtn2.Text = "Delete by Name";
            delbtn2.UseVisualStyleBackColor = true;
            delbtn2.Click += delbtn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delbtn2);
            Controls.Add(disconbtn);
            Controls.Add(conbtn);
            Controls.Add(delbtn);
            Controls.Add(Changebtn);
            Controls.Add(namelab);
            Controls.Add(idlab);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(addbtn);
            Controls.Add(displistbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox displistbox;
        private Button addbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label idlab;
        private Label namelab;
        private Button Changebtn;
        private Button delbtn;
        private Button conbtn;
        private Button disconbtn;
        private Button delbtn2;
    }
}
