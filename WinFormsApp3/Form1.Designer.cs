
namespace WinFormsApp3
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
            components = new System.ComponentModel.Container();
            label2 = new System.Windows.Forms.Label();
            textBoxSumaPopownenych = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            buttonEnd = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            labelTime = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            textBoxNomer = new System.Windows.Forms.TextBox();
            textBoxNomerDowidky = new System.Windows.Forms.TextBox();
            textBoxNomerPunktuObminu = new System.Windows.Forms.TextBox();
            label10Vadacza = new System.Windows.Forms.Label();
            labelPopowneno = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            labelErrMoney = new System.Windows.Forms.Label();
            labelerror = new System.Windows.Forms.Label();
            labelOperatorPopownenych = new System.Windows.Forms.Label();
            label11Vadacza = new System.Windows.Forms.Label();
            labelSumaPopownenych = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label10 = new System.Windows.Forms.Label();
            labelResult = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Довідка №";
            label2.UseWaitCursor = true;
            // 
            // textBoxSumaPopownenych
            // 
            textBoxSumaPopownenych.Location = new System.Drawing.Point(12, 426);
            textBoxSumaPopownenych.Name = "textBoxSumaPopownenych";
            textBoxSumaPopownenych.Size = new System.Drawing.Size(244, 27);
            textBoxSumaPopownenych.TabIndex = 3;
            textBoxSumaPopownenych.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 399);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(215, 20);
            label4.TabIndex = 5;
            label4.Text = "Уведіть суму внесених коштів";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 253);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(154, 20);
            label5.TabIndex = 6;
            label5.Text = "Виберіть оператора ";
            label5.UseWaitCursor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(12, 286);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(244, 104);
            listBox1.TabIndex = 8;
            listBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(148, 483);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(108, 29);
            button1.TabIndex = 10;
            button1.Text = "Поповнити";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // buttonEnd
            // 
            buttonEnd.Location = new System.Drawing.Point(148, 535);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new System.Drawing.Size(108, 29);
            buttonEnd.TabIndex = 12;
            buttonEnd.Text = "Завершити";
            buttonEnd.UseVisualStyleBackColor = true;
            buttonEnd.UseWaitCursor = true;
            buttonEnd.Click += buttonEnd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 107);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 20);
            label3.TabIndex = 13;
            label3.Text = "Термінал №";
            label3.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(17, 180);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(179, 20);
            label7.TabIndex = 14;
            label7.Text = "Уведіть номер телефону";
            label7.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonEnd);
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxSumaPopownenych);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxNomer);
            panel1.Controls.Add(textBoxNomerDowidky);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxNomerPunktuObminu);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(320, 583);
            panel1.TabIndex = 15;
            panel1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 206);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 20);
            label1.TabIndex = 25;
            label1.Text = "+38";
            label1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 483);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(108, 29);
            button2.TabIndex = 24;
            button2.Text = "Друк Чеку";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new System.Drawing.Point(12, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(81, 20);
            labelTime.TabIndex = 18;
            labelTime.Text = "Дата й час";
            labelTime.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel2.Location = new System.Drawing.Point(316, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(250, 564);
            panel2.TabIndex = 16;
            panel2.UseWaitCursor = true;
            // 
            // textBoxNomer
            // 
            textBoxNomer.Location = new System.Drawing.Point(48, 203);
            textBoxNomer.Name = "textBoxNomer";
            textBoxNomer.Size = new System.Drawing.Size(208, 27);
            textBoxNomer.TabIndex = 15;
            textBoxNomer.UseWaitCursor = true;
            // 
            // textBoxNomerDowidky
            // 
            textBoxNomerDowidky.Location = new System.Drawing.Point(12, 66);
            textBoxNomerDowidky.Name = "textBoxNomerDowidky";
            textBoxNomerDowidky.Size = new System.Drawing.Size(244, 27);
            textBoxNomerDowidky.TabIndex = 11;
            textBoxNomerDowidky.UseWaitCursor = true;
            // 
            // textBoxNomerPunktuObminu
            // 
            textBoxNomerPunktuObminu.Location = new System.Drawing.Point(12, 139);
            textBoxNomerPunktuObminu.Name = "textBoxNomerPunktuObminu";
            textBoxNomerPunktuObminu.Size = new System.Drawing.Size(244, 27);
            textBoxNomerPunktuObminu.TabIndex = 14;
            textBoxNomerPunktuObminu.UseWaitCursor = true;
            // 
            // label10Vadacza
            // 
            label10Vadacza.AutoSize = true;
            label10Vadacza.Location = new System.Drawing.Point(79, 20);
            label10Vadacza.Name = "label10Vadacza";
            label10Vadacza.Size = new System.Drawing.Size(152, 20);
            label10Vadacza.TabIndex = 23;
            label10Vadacza.Text = "Інформація для чеку";
            label10Vadacza.UseWaitCursor = true;
            // 
            // labelPopowneno
            // 
            labelPopowneno.AutoSize = true;
            labelPopowneno.Location = new System.Drawing.Point(21, 107);
            labelPopowneno.Name = "labelPopowneno";
            labelPopowneno.Size = new System.Drawing.Size(45, 20);
            labelPopowneno.TabIndex = 22;
            labelPopowneno.Text = "XXXX";
            labelPopowneno.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(21, 69);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(241, 20);
            label9.TabIndex = 21;
            label9.Text = "Номер абонента, що поповнено:";
            label9.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(labelResult);
            panel3.Controls.Add(labelErrMoney);
            panel3.Controls.Add(labelerror);
            panel3.Controls.Add(labelOperatorPopownenych);
            panel3.Controls.Add(label11Vadacza);
            panel3.Controls.Add(labelPopowneno);
            panel3.Controls.Add(label10Vadacza);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(labelSumaPopownenych);
            panel3.Controls.Add(label8);
            panel3.Location = new System.Drawing.Point(319, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(293, 918);
            panel3.TabIndex = 16;
            panel3.UseWaitCursor = true;
            // 
            // labelErrMoney
            // 
            labelErrMoney.AutoSize = true;
            labelErrMoney.Location = new System.Drawing.Point(23, 401);
            labelErrMoney.Name = "labelErrMoney";
            labelErrMoney.Size = new System.Drawing.Size(72, 20);
            labelErrMoney.TabIndex = 27;
            labelErrMoney.Text = "ErrMoney";
            labelErrMoney.UseWaitCursor = true;
            // 
            // labelerror
            // 
            labelerror.AutoSize = true;
            labelerror.Location = new System.Drawing.Point(21, 353);
            labelerror.Name = "labelerror";
            labelerror.Size = new System.Drawing.Size(37, 20);
            labelerror.TabIndex = 26;
            labelerror.Text = "xxxx";
            labelerror.UseWaitCursor = true;
            // 
            // labelOperatorPopownenych
            // 
            labelOperatorPopownenych.AutoSize = true;
            labelOperatorPopownenych.Location = new System.Drawing.Point(21, 286);
            labelOperatorPopownenych.Name = "labelOperatorPopownenych";
            labelOperatorPopownenych.Size = new System.Drawing.Size(45, 20);
            labelOperatorPopownenych.TabIndex = 25;
            labelOperatorPopownenych.Text = "XXXX";
            labelOperatorPopownenych.UseWaitCursor = true;
            // 
            // label11Vadacza
            // 
            label11Vadacza.AutoSize = true;
            label11Vadacza.Location = new System.Drawing.Point(21, 239);
            label11Vadacza.Name = "label11Vadacza";
            label11Vadacza.Size = new System.Drawing.Size(109, 20);
            label11Vadacza.TabIndex = 24;
            label11Vadacza.Text = "Ваш оператор";
            label11Vadacza.UseWaitCursor = true;
            // 
            // labelSumaPopownenych
            // 
            labelSumaPopownenych.AutoSize = true;
            labelSumaPopownenych.Location = new System.Drawing.Point(21, 194);
            labelSumaPopownenych.Name = "labelSumaPopownenych";
            labelSumaPopownenych.Size = new System.Drawing.Size(45, 20);
            labelSumaPopownenych.TabIndex = 18;
            labelSumaPopownenych.Text = "XXXX";
            labelSumaPopownenych.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(21, 146);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(187, 20);
            label8.TabIndex = 17;
            label8.Text = "Сума поповнених коштів:";
            label8.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(635, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(824, 387);
            dataGridView1.TabIndex = 17;
            dataGridView1.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(635, 20);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(564, 20);
            label10.TabIndex = 21;
            label10.Text = "Загальна інформація (з можливістю упорядковування за будь-яким критерієм)";
            label10.UseWaitCursor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new System.Drawing.Point(17, 454);
            labelResult.Name = "labelResult";
            labelResult.Size = new System.Drawing.Size(45, 20);
            labelResult.TabIndex = 28;
            labelResult.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1486, 583);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = " Весельський О. Термінал Платежів";
            UseWaitCursor = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSumaPopownenych;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNomer;
        private System.Windows.Forms.TextBox textBoxNomerPunktuObminu;
        private System.Windows.Forms.TextBox textBoxNomerDowidky;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSumaPopownenych;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelPopowneno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10Vadacza;
        private System.Windows.Forms.Label label11Vadacza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelOperatorPopownenych;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrMoney;
        private System.Windows.Forms.Label labelResult;
    }
}
