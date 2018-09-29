namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butSubstraccion = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.ButMultiplicacion = new System.Windows.Forms.Button();
            this.butPunto = new System.Windows.Forms.Button();
            this.butDivison = new System.Windows.Forms.Button();
            this.butPotenciacion = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.butAdicion = new System.Windows.Forms.Button();
            this.butIgual = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtOperacion, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 26);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // txtOperacion
            // 
            this.txtOperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOperacion.Location = new System.Drawing.Point(3, 3);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.ReadOnly = true;
            this.txtOperacion.Size = new System.Drawing.Size(318, 20);
            this.txtOperacion.TabIndex = 50;
            this.txtOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperacion_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.butSubstraccion, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.but0, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ButMultiplicacion, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.butPunto, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.butDivison, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butPotenciacion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.but1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.but9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.but2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.but8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.but3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.but7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.but4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.but5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.but6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.butAdicion, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.butIgual, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.butReset, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 145);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // butSubstraccion
            // 
            this.butSubstraccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSubstraccion.Location = new System.Drawing.Point(246, 3);
            this.butSubstraccion.Name = "butSubstraccion";
            this.butSubstraccion.Size = new System.Drawing.Size(75, 23);
            this.butSubstraccion.TabIndex = 17;
            this.butSubstraccion.Text = "-";
            this.butSubstraccion.UseVisualStyleBackColor = true;
            this.butSubstraccion.Click += new System.EventHandler(this.butSubstraccion_Click);
            // 
            // but0
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.but0, 2);
            this.but0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but0.Location = new System.Drawing.Point(3, 119);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(156, 23);
            this.but0.TabIndex = 1;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // ButMultiplicacion
            // 
            this.ButMultiplicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButMultiplicacion.Location = new System.Drawing.Point(165, 3);
            this.ButMultiplicacion.Name = "ButMultiplicacion";
            this.ButMultiplicacion.Size = new System.Drawing.Size(75, 23);
            this.ButMultiplicacion.TabIndex = 16;
            this.ButMultiplicacion.Text = "*";
            this.ButMultiplicacion.UseVisualStyleBackColor = true;
            this.ButMultiplicacion.Click += new System.EventHandler(this.ButMultiplicacion_Click);
            // 
            // butPunto
            // 
            this.butPunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butPunto.Location = new System.Drawing.Point(165, 119);
            this.butPunto.Name = "butPunto";
            this.butPunto.Size = new System.Drawing.Size(75, 23);
            this.butPunto.TabIndex = 2;
            this.butPunto.Text = "Decimal";
            this.butPunto.UseVisualStyleBackColor = true;
            this.butPunto.Click += new System.EventHandler(this.butPunto_Click);
            // 
            // butDivison
            // 
            this.butDivison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butDivison.Location = new System.Drawing.Point(84, 3);
            this.butDivison.Name = "butDivison";
            this.butDivison.Size = new System.Drawing.Size(75, 23);
            this.butDivison.TabIndex = 15;
            this.butDivison.Text = "/";
            this.butDivison.UseVisualStyleBackColor = true;
            this.butDivison.Click += new System.EventHandler(this.butDivison_Click);
            // 
            // butPotenciacion
            // 
            this.butPotenciacion.AutoSize = true;
            this.butPotenciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butPotenciacion.Location = new System.Drawing.Point(3, 3);
            this.butPotenciacion.Name = "butPotenciacion";
            this.butPotenciacion.Size = new System.Drawing.Size(75, 23);
            this.butPotenciacion.TabIndex = 14;
            this.butPotenciacion.Text = "^";
            this.butPotenciacion.UseVisualStyleBackColor = true;
            this.butPotenciacion.Click += new System.EventHandler(this.butPotenciacion_Click);
            // 
            // but1
            // 
            this.but1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but1.Location = new System.Drawing.Point(3, 90);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 4;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but9
            // 
            this.but9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but9.Location = new System.Drawing.Point(165, 32);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(75, 23);
            this.but9.TabIndex = 13;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but2
            // 
            this.but2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but2.Location = new System.Drawing.Point(84, 90);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 5;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but8
            // 
            this.but8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but8.Location = new System.Drawing.Point(84, 32);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(75, 23);
            this.but8.TabIndex = 12;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but3
            // 
            this.but3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but3.Location = new System.Drawing.Point(165, 90);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 23);
            this.but3.TabIndex = 6;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but7
            // 
            this.but7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but7.Location = new System.Drawing.Point(3, 32);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(75, 23);
            this.but7.TabIndex = 11;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // but4
            // 
            this.but4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but4.Location = new System.Drawing.Point(3, 61);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(75, 23);
            this.but4.TabIndex = 7;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but5
            // 
            this.but5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but5.Location = new System.Drawing.Point(84, 61);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(75, 23);
            this.but5.TabIndex = 8;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but6
            // 
            this.but6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but6.Location = new System.Drawing.Point(165, 61);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(75, 23);
            this.but6.TabIndex = 9;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // butAdicion
            // 
            this.butAdicion.AutoSize = true;
            this.butAdicion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAdicion.Location = new System.Drawing.Point(246, 32);
            this.butAdicion.Name = "butAdicion";
            this.butAdicion.Size = new System.Drawing.Size(75, 23);
            this.butAdicion.TabIndex = 10;
            this.butAdicion.Text = "+";
            this.butAdicion.UseVisualStyleBackColor = true;
            this.butAdicion.Click += new System.EventHandler(this.butAdicion_Click);
            // 
            // butIgual
            // 
            this.butIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butIgual.Location = new System.Drawing.Point(246, 90);
            this.butIgual.Name = "butIgual";
            this.tableLayoutPanel2.SetRowSpan(this.butIgual, 2);
            this.butIgual.Size = new System.Drawing.Size(75, 52);
            this.butIgual.TabIndex = 3;
            this.butIgual.Text = "=";
            this.butIgual.UseVisualStyleBackColor = true;
            this.butIgual.Click += new System.EventHandler(this.butIgual_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(246, 61);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(75, 23);
            this.butReset.TabIndex = 18;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculadora";
            this.Text = "Hyper Calc v1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butSubstraccion;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button ButMultiplicacion;
        private System.Windows.Forms.Button butPunto;
        private System.Windows.Forms.Button butDivison;
        private System.Windows.Forms.Button butPotenciacion;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button butAdicion;
        private System.Windows.Forms.Button butIgual;
        private System.Windows.Forms.Button butReset;
    }
}

