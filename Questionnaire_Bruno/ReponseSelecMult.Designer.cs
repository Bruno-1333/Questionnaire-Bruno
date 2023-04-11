namespace Questionnaire_Bruno
{
    partial class ReponseSelecMult
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReponseSelecMult));
            txtQuestion4 = new TextBox();
            txtQuestion3 = new TextBox();
            txtQuestion2 = new TextBox();
            txtQuestion1 = new TextBox();
            check4Question = new CheckBox();
            check3Question = new CheckBox();
            check2Question = new CheckBox();
            check1Question = new CheckBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // txtQuestion4
            // 
            txtQuestion4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion4.Location = new Point(346, 336);
            txtQuestion4.Name = "txtQuestion4";
            txtQuestion4.ReadOnly = true;
            txtQuestion4.Size = new Size(154, 26);
            txtQuestion4.TabIndex = 15;
            // 
            // txtQuestion3
            // 
            txtQuestion3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion3.Location = new Point(346, 304);
            txtQuestion3.Name = "txtQuestion3";
            txtQuestion3.ReadOnly = true;
            txtQuestion3.Size = new Size(154, 26);
            txtQuestion3.TabIndex = 14;
            // 
            // txtQuestion2
            // 
            txtQuestion2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion2.Location = new Point(151, 336);
            txtQuestion2.Name = "txtQuestion2";
            txtQuestion2.ReadOnly = true;
            txtQuestion2.Size = new Size(149, 26);
            txtQuestion2.TabIndex = 13;
            // 
            // txtQuestion1
            // 
            txtQuestion1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion1.Location = new Point(151, 298);
            txtQuestion1.Name = "txtQuestion1";
            txtQuestion1.ReadOnly = true;
            txtQuestion1.Size = new Size(149, 26);
            txtQuestion1.TabIndex = 12;
            // 
            // check4Question
            // 
            check4Question.AutoSize = true;
            check4Question.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            check4Question.Location = new Point(325, 342);
            check4Question.Name = "check4Question";
            check4Question.Size = new Size(15, 14);
            check4Question.TabIndex = 11;
            check4Question.UseVisualStyleBackColor = true;
            // 
            // check3Question
            // 
            check3Question.AutoSize = true;
            check3Question.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            check3Question.Location = new Point(325, 310);
            check3Question.Name = "check3Question";
            check3Question.Size = new Size(15, 14);
            check3Question.TabIndex = 10;
            check3Question.UseVisualStyleBackColor = true;
            // 
            // check2Question
            // 
            check2Question.AutoSize = true;
            check2Question.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            check2Question.Location = new Point(130, 342);
            check2Question.Name = "check2Question";
            check2Question.Size = new Size(15, 14);
            check2Question.TabIndex = 9;
            check2Question.UseVisualStyleBackColor = true;
            // 
            // check1Question
            // 
            check1Question.AutoSize = true;
            check1Question.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            check1Question.Location = new Point(130, 310);
            check1Question.Name = "check1Question";
            check1Question.Size = new Size(15, 14);
            check1Question.TabIndex = 8;
            check1Question.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 112);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // ReponseSelecMult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(check1Question);
            Controls.Add(txtQuestion1);
            Controls.Add(groupBox1);
            Controls.Add(txtQuestion4);
            Controls.Add(check2Question);
            Controls.Add(txtQuestion2);
            Controls.Add(txtQuestion3);
            Controls.Add(check4Question);
            Controls.Add(check3Question);
            DoubleBuffered = true;
            Name = "ReponseSelecMult";
            Size = new Size(577, 377);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion4;
        private TextBox txtQuestion3;
        private TextBox txtQuestion2;
        private TextBox txtQuestion1;
        private CheckBox check4Question;
        private CheckBox check3Question;
        private CheckBox check2Question;
        private CheckBox check1Question;
        private GroupBox groupBox1;
    }
}
