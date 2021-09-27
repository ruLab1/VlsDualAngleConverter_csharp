namespace psaConverter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numDrill = new System.Windows.Forms.NumericUpDown();
            this.numPintopap = new System.Windows.Forms.NumericUpDown();
            this.numVal = new System.Windows.Forms.NumericUpDown();
            this.numPinbuffer = new System.Windows.Forms.NumericUpDown();
            this.numPsatopap = new System.Windows.Forms.NumericUpDown();
            this.numPintopap2 = new System.Windows.Forms.NumericUpDown();
            this.btn_toPsa = new System.Windows.Forms.Button();
            this.btn_toDual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearDual = new System.Windows.Forms.Button();
            this.btnClearPsa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDrill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPintopap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPinbuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPsatopap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPintopap2)).BeginInit();
            this.SuspendLayout();
            // 
            // numDrill
            // 
            this.numDrill.DecimalPlaces = 3;
            this.numDrill.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numDrill.Location = new System.Drawing.Point(75, 106);
            this.numDrill.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrill.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numDrill.Name = "numDrill";
            this.numDrill.Size = new System.Drawing.Size(120, 25);
            this.numDrill.TabIndex = 0;
            // 
            // numPintopap
            // 
            this.numPintopap.DecimalPlaces = 3;
            this.numPintopap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPintopap.Location = new System.Drawing.Point(75, 171);
            this.numPintopap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPintopap.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numPintopap.Name = "numPintopap";
            this.numPintopap.Size = new System.Drawing.Size(120, 25);
            this.numPintopap.TabIndex = 0;
            // 
            // numVal
            // 
            this.numVal.DecimalPlaces = 3;
            this.numVal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numVal.Location = new System.Drawing.Point(75, 242);
            this.numVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVal.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numVal.Name = "numVal";
            this.numVal.Size = new System.Drawing.Size(120, 25);
            this.numVal.TabIndex = 0;
            // 
            // numPinbuffer
            // 
            this.numPinbuffer.DecimalPlaces = 3;
            this.numPinbuffer.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPinbuffer.Location = new System.Drawing.Point(393, 242);
            this.numPinbuffer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPinbuffer.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numPinbuffer.Name = "numPinbuffer";
            this.numPinbuffer.Size = new System.Drawing.Size(120, 25);
            this.numPinbuffer.TabIndex = 1;
            // 
            // numPsatopap
            // 
            this.numPsatopap.DecimalPlaces = 3;
            this.numPsatopap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPsatopap.Location = new System.Drawing.Point(393, 171);
            this.numPsatopap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPsatopap.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numPsatopap.Name = "numPsatopap";
            this.numPsatopap.Size = new System.Drawing.Size(120, 25);
            this.numPsatopap.TabIndex = 2;
            // 
            // numPintopap2
            // 
            this.numPintopap2.DecimalPlaces = 3;
            this.numPintopap2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPintopap2.Location = new System.Drawing.Point(393, 106);
            this.numPintopap2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPintopap2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numPintopap2.Name = "numPintopap2";
            this.numPintopap2.Size = new System.Drawing.Size(120, 25);
            this.numPintopap2.TabIndex = 3;
            // 
            // btn_toPsa
            // 
            this.btn_toPsa.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_toPsa.Location = new System.Drawing.Point(245, 104);
            this.btn_toPsa.Name = "btn_toPsa";
            this.btn_toPsa.Size = new System.Drawing.Size(104, 74);
            this.btn_toPsa.TabIndex = 4;
            this.btn_toPsa.Text = "→";
            this.btn_toPsa.UseVisualStyleBackColor = true;
            this.btn_toPsa.Click += new System.EventHandler(this.btn_toPsa_Click);
            // 
            // btn_toDual
            // 
            this.btn_toDual.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_toDual.Location = new System.Drawing.Point(245, 211);
            this.btn_toDual.Name = "btn_toDual";
            this.btn_toDual.Size = new System.Drawing.Size(104, 76);
            this.btn_toDual.TabIndex = 4;
            this.btn_toDual.Text = "←";
            this.btn_toDual.UseVisualStyleBackColor = true;
            this.btn_toDual.Click += new System.EventHandler(this.btn_toDual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dual Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(426, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "VLS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drilling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pin to PAP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "VAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pin to PAP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "PSA to PAP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pin Buffer";
            // 
            // btnClearDual
            // 
            this.btnClearDual.Location = new System.Drawing.Point(75, 297);
            this.btnClearDual.Name = "btnClearDual";
            this.btnClearDual.Size = new System.Drawing.Size(120, 32);
            this.btnClearDual.TabIndex = 6;
            this.btnClearDual.Text = "Clear";
            this.btnClearDual.UseVisualStyleBackColor = true;
            this.btnClearDual.Click += new System.EventHandler(this.btnClearDual_Click);
            // 
            // btnClearPsa
            // 
            this.btnClearPsa.Location = new System.Drawing.Point(394, 297);
            this.btnClearPsa.Name = "btnClearPsa";
            this.btnClearPsa.Size = new System.Drawing.Size(119, 32);
            this.btnClearPsa.TabIndex = 6;
            this.btnClearPsa.Text = "Clear";
            this.btnClearPsa.UseVisualStyleBackColor = true;
            this.btnClearPsa.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 373);
            this.Controls.Add(this.btnClearPsa);
            this.Controls.Add(this.btnClearDual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_toDual);
            this.Controls.Add(this.btn_toPsa);
            this.Controls.Add(this.numPinbuffer);
            this.Controls.Add(this.numPsatopap);
            this.Controls.Add(this.numPintopap2);
            this.Controls.Add(this.numVal);
            this.Controls.Add(this.numPintopap);
            this.Controls.Add(this.numDrill);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "VlsDualAngle Conveter";
            ((System.ComponentModel.ISupportInitialize)(this.numDrill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPintopap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPinbuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPsatopap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPintopap2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDrill;
        private System.Windows.Forms.NumericUpDown numPintopap;
        private System.Windows.Forms.NumericUpDown numVal;
        private System.Windows.Forms.NumericUpDown numPinbuffer;
        private System.Windows.Forms.NumericUpDown numPsatopap;
        private System.Windows.Forms.NumericUpDown numPintopap2;
        private System.Windows.Forms.Button btn_toPsa;
        private System.Windows.Forms.Button btn_toDual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearDual;
        private System.Windows.Forms.Button btnClearPsa;
    }
}

