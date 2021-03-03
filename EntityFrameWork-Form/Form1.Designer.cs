
namespace EntityFrameWork_Form
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStudentList = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtStudentPhoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtLectureName = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextLectureId = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TextCondition = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnLectureList = new System.Windows.Forms.Button();
            this.BtnNoteList = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntities = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnStudentList
            // 
            this.BtnStudentList.Location = new System.Drawing.Point(12, 174);
            this.BtnStudentList.Name = "BtnStudentList";
            this.BtnStudentList.Size = new System.Drawing.Size(135, 31);
            this.BtnStudentList.TabIndex = 1;
            this.BtnStudentList.Text = "Student List";
            this.BtnStudentList.UseVisualStyleBackColor = true;
            this.BtnStudentList.Click += new System.EventHandler(this.BtnStudentList_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(12, 285);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(135, 31);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Update";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(12, 248);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(135, 31);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Delete";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(12, 211);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(135, 31);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Register";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(12, 322);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(135, 31);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Find";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtStudentPhoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtStudentSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtStudentName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtStudentId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(242, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDENT";
            // 
            // TxtStudentPhoto
            // 
            this.TxtStudentPhoto.Location = new System.Drawing.Point(100, 118);
            this.TxtStudentPhoto.Name = "TxtStudentPhoto";
            this.TxtStudentPhoto.Size = new System.Drawing.Size(125, 22);
            this.TxtStudentPhoto.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "PHOTO:";
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.Location = new System.Drawing.Point(100, 90);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(125, 22);
            this.TxtStudentSurname.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "LAST NAME:";
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(100, 62);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(125, 22);
            this.TxtStudentName.TabIndex = 17;
            this.TxtStudentName.TextChanged += new System.EventHandler(this.TxtStudentName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "FIRST NAME:";
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Location = new System.Drawing.Point(100, 34);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(125, 22);
            this.TxtStudentId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtLectureName);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.TextLectureId);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Location = new System.Drawing.Point(242, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 110);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LECTURE";
            // 
            // TxtLectureName
            // 
            this.TxtLectureName.Location = new System.Drawing.Point(119, 60);
            this.TxtLectureName.Name = "TxtLectureName";
            this.TxtLectureName.Size = new System.Drawing.Size(125, 22);
            this.TxtLectureName.TabIndex = 17;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(3, 65);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(119, 17);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "LECTURE NAME:";
            // 
            // TextLectureId
            // 
            this.TextLectureId.Location = new System.Drawing.Point(119, 32);
            this.TextLectureId.Name = "TextLectureId";
            this.TextLectureId.Size = new System.Drawing.Size(125, 22);
            this.TextLectureId.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(28, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 17);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "LECTURE ID:";
            this.Label5.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnJoin);
            this.groupBox3.Controls.Add(this.BtnCalculate);
            this.groupBox3.Controls.Add(this.TextCondition);
            this.groupBox3.Controls.Add(this.Label11);
            this.groupBox3.Controls.Add(this.TxtAverage);
            this.groupBox3.Controls.Add(this.Label10);
            this.groupBox3.Controls.Add(this.TxtExam3);
            this.groupBox3.Controls.Add(this.Label9);
            this.groupBox3.Controls.Add(this.TxtExam2);
            this.groupBox3.Controls.Add(this.Label8);
            this.groupBox3.Controls.Add(this.TxtExam1);
            this.groupBox3.Controls.Add(this.Label7);
            this.groupBox3.Location = new System.Drawing.Point(593, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 290);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NOTES";
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(59, 236);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(182, 36);
            this.BtnJoin.TabIndex = 25;
            this.BtnJoin.Text = "BRING WITH JOIN";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(59, 192);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(182, 31);
            this.BtnCalculate.TabIndex = 24;
            this.BtnCalculate.Text = "CALCULATE";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // TextCondition
            // 
            this.TextCondition.Location = new System.Drawing.Point(106, 149);
            this.TextCondition.Name = "TextCondition";
            this.TextCondition.Size = new System.Drawing.Size(125, 22);
            this.TextCondition.TabIndex = 23;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(15, 152);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(88, 17);
            this.Label11.TabIndex = 22;
            this.Label11.Text = "CONDITION:";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(106, 121);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(125, 22);
            this.TxtAverage.TabIndex = 21;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(25, 124);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(78, 17);
            this.Label10.TabIndex = 20;
            this.Label10.Text = "AVERAGE:";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(106, 93);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(125, 22);
            this.TxtExam3.TabIndex = 19;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(40, 96);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(62, 17);
            this.Label9.TabIndex = 18;
            this.Label9.Text = "EXAM 3:";
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(106, 65);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(125, 22);
            this.TxtExam2.TabIndex = 17;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(41, 70);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 17);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "EXAM 2:";
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(106, 37);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(125, 22);
            this.TxtExam1.TabIndex = 15;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(41, 39);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(62, 17);
            this.Label7.TabIndex = 14;
            this.Label7.Text = "EXAM 1:";
            // 
            // BtnLectureList
            // 
            this.BtnLectureList.Location = new System.Drawing.Point(12, 359);
            this.BtnLectureList.Name = "BtnLectureList";
            this.BtnLectureList.Size = new System.Drawing.Size(135, 31);
            this.BtnLectureList.TabIndex = 9;
            this.BtnLectureList.Text = "Lecture List";
            this.BtnLectureList.UseVisualStyleBackColor = true;
            this.BtnLectureList.Click += new System.EventHandler(this.BtnLectureList_Click);
            // 
            // BtnNoteList
            // 
            this.BtnNoteList.Location = new System.Drawing.Point(12, 396);
            this.BtnNoteList.Name = "BtnNoteList";
            this.BtnNoteList.Size = new System.Drawing.Size(135, 31);
            this.BtnNoteList.TabIndex = 10;
            this.BtnNoteList.Text = "Note List";
            this.BtnNoteList.UseVisualStyleBackColor = true;
            this.BtnNoteList.Click += new System.EventHandler(this.BtnNoteList_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(12, 438);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(135, 31);
            this.btnProcedure.TabIndex = 11;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(862, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 21);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sort By Name(A-Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntities
            // 
            this.BtnLinqEntities.Location = new System.Drawing.Point(862, 424);
            this.BtnLinqEntities.Name = "BtnLinqEntities";
            this.BtnLinqEntities.Size = new System.Drawing.Size(135, 31);
            this.BtnLinqEntities.TabIndex = 13;
            this.BtnLinqEntities.Text = "Linq Entities";
            this.BtnLinqEntities.UseVisualStyleBackColor = true;
            this.BtnLinqEntities.Click += new System.EventHandler(this.BtnLinqEntities_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(862, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sort By Name(Z-A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(862, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 21);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Top 3 Register";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(862, 93);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 21);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Find By Id";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(862, 120);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(119, 21);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Starting with A";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(862, 147);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(102, 21);
            this.radioButton6.TabIndex = 18;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Ends with A";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(862, 174);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(158, 21);
            this.radioButton7.TabIndex = 19;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "The value is in there";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(862, 201);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(121, 21);
            this.radioButton8.TabIndex = 20;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Total Students";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(862, 228);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(123, 21);
            this.radioButton9.TabIndex = 21;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Total of Exam1";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(862, 255);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(162, 21);
            this.radioButton10.TabIndex = 22;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Exam1 Average Note";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(862, 282);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(100, 21);
            this.radioButton11.TabIndex = 23;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Max Exam1";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(862, 309);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(97, 21);
            this.radioButton12.TabIndex = 24;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Min Exam1";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 513);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntities);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.BtnNoteList);
            this.Controls.Add(this.BtnLectureList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnStudentList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStudentList;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtStudentPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtLectureName;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox TextLectureId;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextCondition;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button BtnLectureList;
        private System.Windows.Forms.Button BtnNoteList;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntities;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

