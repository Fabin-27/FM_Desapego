namespace FM_Desapega
{
    partial class Form2
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
            btnSucesso = new Button();
            SuspendLayout();
            // 
            // btnSucesso
            // 
            btnSucesso.Location = new Point(317, 138);
            btnSucesso.Name = "btnSucesso";
            btnSucesso.Size = new Size(75, 23);
            btnSucesso.TabIndex = 0;
            btnSucesso.Text = "Sucesso";
            btnSucesso.UseVisualStyleBackColor = true;
            btnSucesso.Click += btnSucesso_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSucesso);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSucesso;
    }
}