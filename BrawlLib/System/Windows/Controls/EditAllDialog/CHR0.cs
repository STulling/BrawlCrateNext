﻿using BrawlLib.SSBB.ResourceNodes;
using BrawlLib.Wii.Animations;
using System.Collections.Generic;

namespace System.Windows.Forms
{
    public class EditAllCHR0Editor : UserControl
    {
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox ScaleZ;
        private TextBox ScaleY;
        private TextBox ScaleX;
        private Label label1;
        private TextBox keyframeCopy;
        private TextBox name;
        private CheckBox copyKeyframes;
        private GroupBox groupBox1;
        private CheckBox NameContains;
        private TextBox targetName;
        private CheckBox Rename;
        private TextBox newName;
        private CheckBox editLoop;
        private CheckBox enableLoop;
        private CheckBox Port;
        private ComboBox Version;
        private RadioButton ScaleDivide;
        private RadioButton ScaleMultiply;
        private RadioButton ScaleSubtract;
        private RadioButton ScaleAdd;
        private RadioButton ScaleClear;
        private RadioButton ScaleReplace;
        private RadioButton TranslateDivide;
        private RadioButton TranslateMultiply;
        private RadioButton TranslateSubtract;
        private RadioButton TranslateAdd;
        private RadioButton TranslateClear;
        private RadioButton TranslateReplace;
        private Label label5;
        private Label label9;
        private Label label10;
        private TextBox TranslateZ;
        private TextBox TranslateY;
        private TextBox TranslateX;
        private RadioButton RotateDivide;
        private RadioButton RotateMultiply;
        private RadioButton RotateSubtract;
        private RadioButton RotateAdd;
        private RadioButton RotateClear;
        private RadioButton RotateReplace;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox RotateZ;
        private TextBox RotateY;
        private TextBox RotateX;
        private RadioButton TranslateDoNotChange;
        private RadioButton RotateDoNotChange;
        private RadioButton ScaleDoNotChange;
        private CheckBox ChangeVersion;

        #region Designer

        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            TranslateDoNotChange = new RadioButton();
            TranslateDivide = new RadioButton();
            TranslateMultiply = new RadioButton();
            TranslateSubtract = new RadioButton();
            TranslateAdd = new RadioButton();
            TranslateClear = new RadioButton();
            TranslateReplace = new RadioButton();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            TranslateZ = new TextBox();
            TranslateY = new TextBox();
            TranslateX = new TextBox();
            groupBox3 = new GroupBox();
            RotateDoNotChange = new RadioButton();
            RotateDivide = new RadioButton();
            RotateMultiply = new RadioButton();
            RotateSubtract = new RadioButton();
            RotateAdd = new RadioButton();
            RotateClear = new RadioButton();
            RotateReplace = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RotateZ = new TextBox();
            RotateY = new TextBox();
            RotateX = new TextBox();
            groupBox5 = new GroupBox();
            ScaleDoNotChange = new RadioButton();
            ScaleDivide = new RadioButton();
            ScaleMultiply = new RadioButton();
            ScaleSubtract = new RadioButton();
            ScaleAdd = new RadioButton();
            ScaleClear = new RadioButton();
            ScaleReplace = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            ScaleZ = new TextBox();
            ScaleY = new TextBox();
            ScaleX = new TextBox();
            keyframeCopy = new TextBox();
            copyKeyframes = new CheckBox();
            label1 = new Label();
            name = new TextBox();
            groupBox1 = new GroupBox();
            targetName = new TextBox();
            NameContains = new CheckBox();
            newName = new TextBox();
            Rename = new CheckBox();
            enableLoop = new CheckBox();
            editLoop = new CheckBox();
            Port = new CheckBox();
            Version = new ComboBox();
            ChangeVersion = new CheckBox();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(keyframeCopy);
            groupBox2.Controls.Add(copyKeyframes);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(name);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Drawing.Point(0, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Drawing.Size(405, 250);
            groupBox2.TabIndex = 87;
            groupBox2.TabStop = false;
            groupBox2.Text = "CHR0 Bone Entries";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                                | AnchorStyles.Left;
            groupBox4.Controls.Add(TranslateDoNotChange);
            groupBox4.Controls.Add(TranslateDivide);
            groupBox4.Controls.Add(TranslateMultiply);
            groupBox4.Controls.Add(TranslateSubtract);
            groupBox4.Controls.Add(TranslateAdd);
            groupBox4.Controls.Add(TranslateClear);
            groupBox4.Controls.Add(TranslateReplace);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(TranslateZ);
            groupBox4.Controls.Add(TranslateY);
            groupBox4.Controls.Add(TranslateX);
            groupBox4.Location = new Drawing.Point(272, 68);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Drawing.Size(126, 176);
            groupBox4.TabIndex = 39;
            groupBox4.TabStop = false;
            groupBox4.Text = "Translate";
            // 
            // TranslateDoNotChange
            // 
            TranslateDoNotChange.AutoSize = true;
            TranslateDoNotChange.Checked = true;
            TranslateDoNotChange.Location = new Drawing.Point(5, 152);
            TranslateDoNotChange.Name = "TranslateDoNotChange";
            TranslateDoNotChange.Size = new Drawing.Size(96, 17);
            TranslateDoNotChange.TabIndex = 48;
            TranslateDoNotChange.TabStop = true;
            TranslateDoNotChange.Text = "Do not change";
            TranslateDoNotChange.UseVisualStyleBackColor = true;
            TranslateDoNotChange.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // TranslateDivide
            // 
            TranslateDivide.AutoSize = true;
            TranslateDivide.Location = new Drawing.Point(66, 129);
            TranslateDivide.Name = "TranslateDivide";
            TranslateDivide.Size = new Drawing.Size(55, 17);
            TranslateDivide.TabIndex = 47;
            TranslateDivide.Text = "Divide";
            TranslateDivide.UseVisualStyleBackColor = true;
            TranslateDivide.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // TranslateMultiply
            // 
            TranslateMultiply.AutoSize = true;
            TranslateMultiply.Location = new Drawing.Point(5, 129);
            TranslateMultiply.Name = "TranslateMultiply";
            TranslateMultiply.Size = new Drawing.Size(60, 17);
            TranslateMultiply.TabIndex = 46;
            TranslateMultiply.Text = "Multiply";
            TranslateMultiply.UseVisualStyleBackColor = true;
            TranslateMultiply.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // TranslateSubtract
            // 
            TranslateSubtract.AutoSize = true;
            TranslateSubtract.Location = new Drawing.Point(55, 106);
            TranslateSubtract.Name = "TranslateSubtract";
            TranslateSubtract.Size = new Drawing.Size(65, 17);
            TranslateSubtract.TabIndex = 45;
            TranslateSubtract.Text = "Subtract";
            TranslateSubtract.UseVisualStyleBackColor = true;
            TranslateSubtract.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // TranslateAdd
            // 
            TranslateAdd.AutoSize = true;
            TranslateAdd.Location = new Drawing.Point(5, 106);
            TranslateAdd.Name = "TranslateAdd";
            TranslateAdd.Size = new Drawing.Size(44, 17);
            TranslateAdd.TabIndex = 44;
            TranslateAdd.Text = "Add";
            TranslateAdd.UseVisualStyleBackColor = true;
            TranslateAdd.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // TranslateClear
            // 
            TranslateClear.AutoSize = true;
            TranslateClear.Location = new Drawing.Point(72, 83);
            TranslateClear.Name = "TranslateClear";
            TranslateClear.Size = new Drawing.Size(49, 17);
            TranslateClear.TabIndex = 43;
            TranslateClear.Text = "Clear";
            TranslateClear.UseVisualStyleBackColor = true;
            TranslateClear.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // TranslateReplace
            // 
            TranslateReplace.AutoSize = true;
            TranslateReplace.Location = new Drawing.Point(5, 83);
            TranslateReplace.Name = "TranslateReplace";
            TranslateReplace.Size = new Drawing.Size(65, 17);
            TranslateReplace.TabIndex = 42;
            TranslateReplace.Text = "Replace";
            TranslateReplace.UseVisualStyleBackColor = true;
            TranslateReplace.CheckedChanged += TranslateClear_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Drawing.Point(6, 39);
            label5.Name = "label5";
            label5.Size = new Drawing.Size(17, 13);
            label5.TabIndex = 40;
            label5.Text = "Y:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Drawing.Point(6, 18);
            label9.Name = "label9";
            label9.Size = new Drawing.Size(17, 13);
            label9.TabIndex = 39;
            label9.Text = "X:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Drawing.Point(6, 60);
            label10.Name = "label10";
            label10.Size = new Drawing.Size(17, 13);
            label10.TabIndex = 41;
            label10.Text = "Z:";
            // 
            // TranslateZ
            // 
            TranslateZ.Enabled = false;
            TranslateZ.Location = new Drawing.Point(24, 57);
            TranslateZ.Name = "TranslateZ";
            TranslateZ.Size = new Drawing.Size(96, 20);
            TranslateZ.TabIndex = 38;
            // 
            // TranslateY
            // 
            TranslateY.Enabled = false;
            TranslateY.Location = new Drawing.Point(24, 36);
            TranslateY.Name = "TranslateY";
            TranslateY.Size = new Drawing.Size(96, 20);
            TranslateY.TabIndex = 37;
            // 
            // TranslateX
            // 
            TranslateX.Enabled = false;
            TranslateX.Location = new Drawing.Point(24, 15);
            TranslateX.Name = "TranslateX";
            TranslateX.Size = new Drawing.Size(96, 20);
            TranslateX.TabIndex = 36;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                                | AnchorStyles.Left;
            groupBox3.Controls.Add(RotateDoNotChange);
            groupBox3.Controls.Add(RotateDivide);
            groupBox3.Controls.Add(RotateMultiply);
            groupBox3.Controls.Add(RotateSubtract);
            groupBox3.Controls.Add(RotateAdd);
            groupBox3.Controls.Add(RotateClear);
            groupBox3.Controls.Add(RotateReplace);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(RotateZ);
            groupBox3.Controls.Add(RotateY);
            groupBox3.Controls.Add(RotateX);
            groupBox3.Location = new Drawing.Point(140, 68);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Drawing.Size(126, 176);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rotate";
            // 
            // RotateDoNotChange
            // 
            RotateDoNotChange.AutoSize = true;
            RotateDoNotChange.Checked = true;
            RotateDoNotChange.Location = new Drawing.Point(5, 152);
            RotateDoNotChange.Name = "RotateDoNotChange";
            RotateDoNotChange.Size = new Drawing.Size(96, 17);
            RotateDoNotChange.TabIndex = 37;
            RotateDoNotChange.TabStop = true;
            RotateDoNotChange.Text = "Do not change";
            RotateDoNotChange.UseVisualStyleBackColor = true;
            RotateDoNotChange.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // RotateDivide
            // 
            RotateDivide.AutoSize = true;
            RotateDivide.Location = new Drawing.Point(66, 129);
            RotateDivide.Name = "RotateDivide";
            RotateDivide.Size = new Drawing.Size(55, 17);
            RotateDivide.TabIndex = 47;
            RotateDivide.Text = "Divide";
            RotateDivide.UseVisualStyleBackColor = true;
            RotateDivide.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // RotateMultiply
            // 
            RotateMultiply.AutoSize = true;
            RotateMultiply.Location = new Drawing.Point(5, 129);
            RotateMultiply.Name = "RotateMultiply";
            RotateMultiply.Size = new Drawing.Size(60, 17);
            RotateMultiply.TabIndex = 46;
            RotateMultiply.Text = "Multiply";
            RotateMultiply.UseVisualStyleBackColor = true;
            RotateMultiply.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // RotateSubtract
            // 
            RotateSubtract.AutoSize = true;
            RotateSubtract.Location = new Drawing.Point(55, 106);
            RotateSubtract.Name = "RotateSubtract";
            RotateSubtract.Size = new Drawing.Size(65, 17);
            RotateSubtract.TabIndex = 45;
            RotateSubtract.Text = "Subtract";
            RotateSubtract.UseVisualStyleBackColor = true;
            RotateSubtract.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // RotateAdd
            // 
            RotateAdd.AutoSize = true;
            RotateAdd.Location = new Drawing.Point(5, 106);
            RotateAdd.Name = "RotateAdd";
            RotateAdd.Size = new Drawing.Size(44, 17);
            RotateAdd.TabIndex = 44;
            RotateAdd.Text = "Add";
            RotateAdd.UseVisualStyleBackColor = true;
            RotateAdd.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // RotateClear
            // 
            RotateClear.AutoSize = true;
            RotateClear.Location = new Drawing.Point(72, 83);
            RotateClear.Name = "RotateClear";
            RotateClear.Size = new Drawing.Size(49, 17);
            RotateClear.TabIndex = 43;
            RotateClear.Text = "Clear";
            RotateClear.UseVisualStyleBackColor = true;
            RotateClear.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // RotateReplace
            // 
            RotateReplace.AutoSize = true;
            RotateReplace.Location = new Drawing.Point(5, 83);
            RotateReplace.Name = "RotateReplace";
            RotateReplace.Size = new Drawing.Size(65, 17);
            RotateReplace.TabIndex = 42;
            RotateReplace.Text = "Replace";
            RotateReplace.UseVisualStyleBackColor = true;
            RotateReplace.CheckedChanged += RotateClear_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Drawing.Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Drawing.Size(17, 13);
            label2.TabIndex = 40;
            label2.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Drawing.Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Drawing.Size(17, 13);
            label3.TabIndex = 39;
            label3.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Drawing.Point(6, 60);
            label4.Name = "label4";
            label4.Size = new Drawing.Size(17, 13);
            label4.TabIndex = 41;
            label4.Text = "Z:";
            // 
            // RotateZ
            // 
            RotateZ.Enabled = false;
            RotateZ.Location = new Drawing.Point(24, 57);
            RotateZ.Name = "RotateZ";
            RotateZ.Size = new Drawing.Size(96, 20);
            RotateZ.TabIndex = 38;
            // 
            // RotateY
            // 
            RotateY.Enabled = false;
            RotateY.Location = new Drawing.Point(24, 36);
            RotateY.Name = "RotateY";
            RotateY.Size = new Drawing.Size(96, 20);
            RotateY.TabIndex = 37;
            // 
            // RotateX
            // 
            RotateX.Enabled = false;
            RotateX.Location = new Drawing.Point(24, 15);
            RotateX.Name = "RotateX";
            RotateX.Size = new Drawing.Size(96, 20);
            RotateX.TabIndex = 36;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                                | AnchorStyles.Left;
            groupBox5.Controls.Add(ScaleDoNotChange);
            groupBox5.Controls.Add(ScaleDivide);
            groupBox5.Controls.Add(ScaleMultiply);
            groupBox5.Controls.Add(ScaleSubtract);
            groupBox5.Controls.Add(ScaleAdd);
            groupBox5.Controls.Add(ScaleClear);
            groupBox5.Controls.Add(ScaleReplace);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(ScaleZ);
            groupBox5.Controls.Add(ScaleY);
            groupBox5.Controls.Add(ScaleX);
            groupBox5.Location = new Drawing.Point(8, 68);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Drawing.Size(126, 176);
            groupBox5.TabIndex = 37;
            groupBox5.TabStop = false;
            groupBox5.Text = "Scale";
            // 
            // ScaleDoNotChange
            // 
            ScaleDoNotChange.AutoSize = true;
            ScaleDoNotChange.Checked = true;
            ScaleDoNotChange.Location = new Drawing.Point(5, 152);
            ScaleDoNotChange.Name = "ScaleDoNotChange";
            ScaleDoNotChange.Size = new Drawing.Size(96, 17);
            ScaleDoNotChange.TabIndex = 36;
            ScaleDoNotChange.TabStop = true;
            ScaleDoNotChange.Text = "Do not change";
            ScaleDoNotChange.UseVisualStyleBackColor = true;
            ScaleDoNotChange.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // ScaleDivide
            // 
            ScaleDivide.AutoSize = true;
            ScaleDivide.Location = new Drawing.Point(66, 129);
            ScaleDivide.Name = "ScaleDivide";
            ScaleDivide.Size = new Drawing.Size(55, 17);
            ScaleDivide.TabIndex = 35;
            ScaleDivide.Text = "Divide";
            ScaleDivide.UseVisualStyleBackColor = true;
            ScaleDivide.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // ScaleMultiply
            // 
            ScaleMultiply.AutoSize = true;
            ScaleMultiply.Location = new Drawing.Point(5, 129);
            ScaleMultiply.Name = "ScaleMultiply";
            ScaleMultiply.Size = new Drawing.Size(60, 17);
            ScaleMultiply.TabIndex = 34;
            ScaleMultiply.Text = "Multiply";
            ScaleMultiply.UseVisualStyleBackColor = true;
            ScaleMultiply.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // ScaleSubtract
            // 
            ScaleSubtract.AutoSize = true;
            ScaleSubtract.Location = new Drawing.Point(55, 106);
            ScaleSubtract.Name = "ScaleSubtract";
            ScaleSubtract.Size = new Drawing.Size(65, 17);
            ScaleSubtract.TabIndex = 33;
            ScaleSubtract.Text = "Subtract";
            ScaleSubtract.UseVisualStyleBackColor = true;
            ScaleSubtract.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // ScaleAdd
            // 
            ScaleAdd.AutoSize = true;
            ScaleAdd.Location = new Drawing.Point(5, 106);
            ScaleAdd.Name = "ScaleAdd";
            ScaleAdd.Size = new Drawing.Size(44, 17);
            ScaleAdd.TabIndex = 32;
            ScaleAdd.Text = "Add";
            ScaleAdd.UseVisualStyleBackColor = true;
            ScaleAdd.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // ScaleClear
            // 
            ScaleClear.AutoSize = true;
            ScaleClear.Location = new Drawing.Point(72, 83);
            ScaleClear.Name = "ScaleClear";
            ScaleClear.Size = new Drawing.Size(49, 17);
            ScaleClear.TabIndex = 31;
            ScaleClear.Text = "Clear";
            ScaleClear.UseVisualStyleBackColor = true;
            ScaleClear.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // ScaleReplace
            // 
            ScaleReplace.AutoSize = true;
            ScaleReplace.Location = new Drawing.Point(5, 83);
            ScaleReplace.Name = "ScaleReplace";
            ScaleReplace.Size = new Drawing.Size(65, 17);
            ScaleReplace.TabIndex = 30;
            ScaleReplace.Text = "Replace";
            ScaleReplace.UseVisualStyleBackColor = true;
            ScaleReplace.CheckedChanged += ScaleClear_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Drawing.Point(6, 39);
            label7.Name = "label7";
            label7.Size = new Drawing.Size(17, 13);
            label7.TabIndex = 19;
            label7.Text = "Y:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Drawing.Point(6, 18);
            label6.Name = "label6";
            label6.Size = new Drawing.Size(17, 13);
            label6.TabIndex = 18;
            label6.Text = "X:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Drawing.Point(6, 60);
            label8.Name = "label8";
            label8.Size = new Drawing.Size(17, 13);
            label8.TabIndex = 20;
            label8.Text = "Z:";
            // 
            // ScaleZ
            // 
            ScaleZ.Enabled = false;
            ScaleZ.Location = new Drawing.Point(24, 57);
            ScaleZ.Name = "ScaleZ";
            ScaleZ.Size = new Drawing.Size(96, 20);
            ScaleZ.TabIndex = 14;
            // 
            // ScaleY
            // 
            ScaleY.Enabled = false;
            ScaleY.Location = new Drawing.Point(24, 36);
            ScaleY.Name = "ScaleY";
            ScaleY.Size = new Drawing.Size(96, 20);
            ScaleY.TabIndex = 13;
            // 
            // ScaleX
            // 
            ScaleX.Enabled = false;
            ScaleX.Location = new Drawing.Point(24, 15);
            ScaleX.Name = "ScaleX";
            ScaleX.Size = new Drawing.Size(96, 20);
            ScaleX.TabIndex = 12;
            // 
            // keyframeCopy
            // 
            keyframeCopy.Enabled = false;
            keyframeCopy.Location = new Drawing.Point(208, 43);
            keyframeCopy.Name = "keyframeCopy";
            keyframeCopy.Size = new Drawing.Size(189, 20);
            keyframeCopy.TabIndex = 34;
            // 
            // copyKeyframes
            // 
            copyKeyframes.AutoSize = true;
            copyKeyframes.Location = new Drawing.Point(208, 26);
            copyKeyframes.Name = "copyKeyframes";
            copyKeyframes.Size = new Drawing.Size(127, 17);
            copyKeyframes.TabIndex = 33;
            copyKeyframes.Text = "Copy keyframes from:";
            copyKeyframes.UseVisualStyleBackColor = true;
            copyKeyframes.CheckedChanged += copyKeyframes_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Drawing.Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Drawing.Size(200, 13);
            label1.TabIndex = 4;
            label1.Text = "Change all bone entries with the name:";
            // 
            // name
            // 
            name.HideSelection = false;
            name.Location = new Drawing.Point(11, 42);
            name.Name = "name";
            name.Size = new Drawing.Size(187, 20);
            name.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(targetName);
            groupBox1.Controls.Add(NameContains);
            groupBox1.Controls.Add(newName);
            groupBox1.Controls.Add(Rename);
            groupBox1.Controls.Add(enableLoop);
            groupBox1.Controls.Add(editLoop);
            groupBox1.Controls.Add(Port);
            groupBox1.Controls.Add(Version);
            groupBox1.Controls.Add(ChangeVersion);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Drawing.Size(405, 89);
            groupBox1.TabIndex = 86;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHR0";
            // 
            // targetName
            // 
            targetName.Enabled = false;
            targetName.HideSelection = false;
            targetName.Location = new Drawing.Point(171, 16);
            targetName.Name = "targetName";
            targetName.Size = new Drawing.Size(151, 20);
            targetName.TabIndex = 84;
            // 
            // NameContains
            // 
            NameContains.Location = new Drawing.Point(8, 18);
            NameContains.Name = "NameContains";
            NameContains.Size = new Drawing.Size(163, 17);
            NameContains.TabIndex = 85;
            NameContains.Text = "Modify only if name contains: ";
            NameContains.UseVisualStyleBackColor = true;
            NameContains.CheckedChanged += NameContains_CheckedChanged;
            // 
            // newName
            // 
            newName.Enabled = false;
            newName.HideSelection = false;
            newName.Location = new Drawing.Point(203, 39);
            newName.Name = "newName";
            newName.Size = new Drawing.Size(119, 20);
            newName.TabIndex = 82;
            // 
            // Rename
            // 
            Rename.Location = new Drawing.Point(136, 41);
            Rename.Name = "Rename";
            Rename.Size = new Drawing.Size(69, 17);
            Rename.TabIndex = 83;
            Rename.Text = "Rename:";
            Rename.UseVisualStyleBackColor = true;
            Rename.CheckedChanged += Rename_CheckedChanged;
            // 
            // enableLoop
            // 
            enableLoop.AutoSize = true;
            enableLoop.Enabled = false;
            enableLoop.Location = new Drawing.Point(76, 41);
            enableLoop.Name = "enableLoop";
            enableLoop.Size = new Drawing.Size(59, 17);
            enableLoop.TabIndex = 39;
            enableLoop.Text = "Enable";
            enableLoop.UseVisualStyleBackColor = true;
            // 
            // editLoop
            // 
            editLoop.AutoSize = true;
            editLoop.Location = new Drawing.Point(8, 41);
            editLoop.Name = "editLoop";
            editLoop.Size = new Drawing.Size(70, 17);
            editLoop.TabIndex = 38;
            editLoop.Text = "Edit loop:";
            editLoop.UseVisualStyleBackColor = true;
            editLoop.CheckedChanged += editLoop_CheckedChanged;
            // 
            // Port
            // 
            Port.AutoSize = true;
            Port.Location = new Drawing.Point(202, 63);
            Port.Name = "Port";
            Port.Size = new Drawing.Size(59, 17);
            Port.TabIndex = 37;
            Port.Text = "Port All";
            Port.UseVisualStyleBackColor = true;
            // 
            // Version
            // 
            Version.DropDownStyle = ComboBoxStyle.DropDownList;
            Version.Enabled = false;
            Version.FormattingEnabled = true;
            Version.Items.AddRange(new object[]
            {
                "4",
                "5"
            });
            Version.Location = new Drawing.Point(114, 61);
            Version.Name = "Version";
            Version.Size = new Drawing.Size(80, 21);
            Version.TabIndex = 36;
            // 
            // ChangeVersion
            // 
            ChangeVersion.AutoSize = true;
            ChangeVersion.Location = new Drawing.Point(8, 64);
            ChangeVersion.Name = "ChangeVersion";
            ChangeVersion.Size = new Drawing.Size(103, 17);
            ChangeVersion.TabIndex = 35;
            ChangeVersion.Text = "Change version:";
            ChangeVersion.UseVisualStyleBackColor = true;
            ChangeVersion.CheckedChanged += ChangeVersion_CheckedChanged;
            // 
            // EditAllCHR0Editor
            // 
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EditAllCHR0Editor";
            Size = new Drawing.Size(405, 339);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public EditAllCHR0Editor()
        {
            InitializeComponent();
        }

        private void editLoop_CheckedChanged(object sender, EventArgs e)
        {
            enableLoop.Enabled = editLoop.Checked;
        }

        public void OnlyEntryNodesSelected()
        {
            groupBox1.Enabled =
                name.Enabled =
                    keyframeCopy.Enabled =
                        copyKeyframes.Enabled =
                            false;
        }

        public static PartialVector3 Vec3From(TextBox x, TextBox y, TextBox z)
        {
            return Vec3From(x.Text, y.Text, z.Text);
        }

        public static PartialVector3 Vec3From(string x, string y, string z)
        {
            return new PartialVector3(
                string.IsNullOrEmpty(x) ? (float?) null : float.Parse(x),
                string.IsNullOrEmpty(y) ? (float?) null : float.Parse(y),
                string.IsNullOrEmpty(z) ? (float?) null : float.Parse(z));
        }

        public void Apply(IEnumerable<CHR0Node> CHR0)
        {
            string _name = name.Text;
            MDL0Node model = null;
            MDL0Node _targetModel = null;
            if (Port.Checked)
            {
                MessageBox.Show(
                    "Please open the model you want to port the animations to.\nThen open the model the animations work normally for.");
                OpenFileDialog dlgOpen = new OpenFileDialog();
                OpenFileDialog dlgOpen2 = new OpenFileDialog();
                dlgOpen.Filter = dlgOpen2.Filter = "MDL0 Model (*.mdl0)|*.mdl0";
                dlgOpen.Title = "Select the model to port the animations to...";
                dlgOpen2.Title = "Select the model the animations are for...";
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    _targetModel = (MDL0Node) NodeFactory.FromFile(null, dlgOpen.FileName);
                    if (dlgOpen2.ShowDialog() == DialogResult.OK)
                    {
                        model = (MDL0Node) NodeFactory.FromFile(null, dlgOpen2.FileName);
                    }
                }
            }

            PartialVector3 scale = Vec3From(ScaleX, ScaleY, ScaleZ);
            PartialVector3 rot = Vec3From(RotateX, RotateY, RotateZ);
            PartialVector3 trans = Vec3From(TranslateX, TranslateY, TranslateZ);

            foreach (CHR0Node n in CHR0)
            {
                if (NameContains.Checked && !n.Name.Contains(targetName.Text))
                {
                    continue;
                }

                if (editLoop.Checked)
                {
                    n.SignalPropertyChange();
                    n.Loop = enableLoop.Checked;
                }

                if (Rename.Checked)
                {
                    n.SignalPropertyChange();
                    n.Name = n.Parent.FindName(newName.Text);
                }

                if (ChangeVersion.Checked)
                {
                    n.SignalPropertyChange();
                    n.Version = Version.SelectedIndex + 4;
                }

                if (Port.Checked && _targetModel != null && model != null)
                {
                    n.SignalPropertyChange();
                    n.Port(_targetModel, model);
                }

                if (copyKeyframes.Checked)
                {
                    CHR0EntryNode _copyNode = n.FindChild(keyframeCopy.Text, false) as CHR0EntryNode;

                    if (n.FindChild(_name, false) == null)
                    {
                        if (!string.IsNullOrEmpty(_name))
                        {
                            KeyframeEntry kfe = null;
                            CHR0EntryNode c = new CHR0EntryNode();
                            c.SetSize(n.FrameCount, n.Loop);
                            c.Name = _name;

                            if (_copyNode != null)
                            {
                                for (int x = 0; x < _copyNode.FrameCount; x++)
                                {
                                    for (int i = 0; i < 9; i++)
                                    {
                                        if ((kfe = _copyNode.GetKeyframe(i, x)) != null)
                                        {
                                            c.SetKeyframe(i, x, kfe._value);
                                        }
                                    }
                                }
                            }

                            n.AddChild(c);
                        }
                    }
                }

                CHR0EntryNode entry = n.FindChild(_name, false) as CHR0EntryNode;
                if (entry == null)
                {
                    entry = new CHR0EntryNode() {_name = _name};
                    n.AddChild(entry);
                }

                Apply(entry, scale, rot, trans);
            }
        }

        public void Apply(IEnumerable<CHR0EntryNode> CHR0)
        {
            PartialVector3 scale = Vec3From(ScaleX, ScaleY, ScaleZ);
            PartialVector3 rot = Vec3From(RotateX, RotateY, RotateZ);
            PartialVector3 trans = Vec3From(TranslateX, TranslateY, TranslateZ);

            foreach (CHR0EntryNode entry in CHR0)
            {
                Apply(entry, scale, rot, trans);
            }
        }

        private void Apply(CHR0EntryNode entry, PartialVector3 scaleVec, PartialVector3 rotVec, PartialVector3 transVec)
        {
            KeyframeEntry kfe = null;
            CHRAnimationFrame anim;
            bool hasKeyframe = false;
            int numFrames = entry.FrameCount;
            int low = 0, high = 3;
            if (ScaleReplace.Checked)
            {
                Vector3 scale = (Vector3) scaleVec;
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if (entry.GetKeyframe(i, x) != null)
                        {
                            entry.RemoveKeyframe(i, x);
                        }
                    }
                }

                entry.SetKeyframeOnlyScale(0, scale);
            }
            else if (ScaleClear.Checked)
            {
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if (entry.GetKeyframe(i, x) != null)
                        {
                            entry.RemoveKeyframe(i, x);
                        }
                    }
                }
            }
            else if (ScaleAdd.Checked)
            {
                Vector3 scale = new Vector3(
                    scaleVec._x ?? 0,
                    scaleVec._y ?? 0,
                    scaleVec._z ?? 0);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value += scale._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value += scale._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value += scale._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newScale = anim.Scale;
                    scale._x += newScale._x;
                    scale._y += newScale._y;
                    scale._z += newScale._z;
                    entry.SetKeyframeOnlyScale(0, scale);
                }
            }
            else if (ScaleSubtract.Checked)
            {
                Vector3 scale = new Vector3(
                    scaleVec._x ?? 0,
                    scaleVec._y ?? 0,
                    scaleVec._z ?? 0);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value -= scale._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value -= scale._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value -= scale._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newScale = anim.Scale;
                    scale._x = newScale._x - scale._x;
                    scale._y = newScale._y - scale._y;
                    scale._z = newScale._z - scale._z;
                    entry.SetKeyframeOnlyScale(0, scale);
                }
            }
            else if (ScaleMultiply.Checked)
            {
                Vector3 scale = new Vector3(
                    scaleVec._x ?? 1,
                    scaleVec._y ?? 1,
                    scaleVec._z ?? 1);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value *= scale._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value *= scale._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value *= scale._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newScale = anim.Scale;
                    scale._x *= newScale._x;
                    scale._y *= newScale._y;
                    scale._z *= newScale._z;
                    entry.SetKeyframeOnlyScale(0, scale);
                }
            }
            else if (ScaleDivide.Checked)
            {
                Vector3 scale = new Vector3(
                    scaleVec._x ?? 1,
                    scaleVec._y ?? 1,
                    scaleVec._z ?? 1);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low && scale._x != 0)
                            {
                                kfe._value /= scale._x;
                            }
                            else if (i == low + 1 && scale._y != 0)
                            {
                                kfe._value /= scale._y;
                            }
                            else if (i == high - 1 && scale._z != 0)
                            {
                                kfe._value /= scale._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newScale = anim.Scale;
                    if (scale._x != 0)
                    {
                        scale._x = newScale._x / scale._x;
                    }

                    if (scale._y != 0)
                    {
                        scale._y = newScale._y / scale._y;
                    }

                    if (scale._z != 0)
                    {
                        scale._z = newScale._z / scale._z;
                    }

                    entry.SetKeyframeOnlyScale(0, scale);
                }
            }

            low = 3;
            high = 6;
            if (RotateReplace.Checked)
            {
                Vector3 rot = (Vector3) rotVec;
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if (entry.GetKeyframe(i, x) != null)
                        {
                            entry.RemoveKeyframe(i, x);
                        }
                    }
                }

                entry.SetKeyframeOnlyRot(0, rot);
            }
            else if (RotateClear.Checked)
            {
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if (entry.GetKeyframe(i, x) != null)
                        {
                            entry.RemoveKeyframe(i, x);
                        }
                    }
                }
            }
            else if (RotateAdd.Checked)
            {
                Vector3 rot = new Vector3(
                    rotVec._x ?? 0,
                    rotVec._y ?? 0,
                    rotVec._z ?? 0);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value += rot._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value += rot._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value += rot._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newRotate = anim.Rotation;
                    rot._x += newRotate._x;
                    rot._y += newRotate._y;
                    rot._z += newRotate._z;
                    entry.SetKeyframeOnlyRot(0, rot);
                }
            }
            else if (RotateSubtract.Checked)
            {
                Vector3 rot = new Vector3(
                    rotVec._x ?? 0,
                    rotVec._y ?? 0,
                    rotVec._z ?? 0);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value -= rot._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value -= rot._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value -= rot._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newRotate = anim.Rotation;
                    rot._x = newRotate._x - rot._x;
                    rot._y = newRotate._y - rot._y;
                    rot._z = newRotate._z - rot._z;
                    entry.SetKeyframeOnlyRot(0, rot);
                }
            }
            else if (RotateMultiply.Checked)
            {
                Vector3 rot = new Vector3(
                    rotVec._x ?? 1,
                    rotVec._y ?? 1,
                    rotVec._z ?? 1);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value *= rot._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value *= rot._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value *= rot._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newRotate = anim.Rotation;
                    rot._x *= newRotate._x;
                    rot._y *= newRotate._y;
                    rot._z *= newRotate._z;
                    entry.SetKeyframeOnlyRot(0, rot);
                }
            }
            else if (RotateDivide.Checked)
            {
                Vector3 rot = new Vector3(
                    rotVec._x ?? 1,
                    rotVec._y ?? 1,
                    rotVec._z ?? 1);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low && rot._x != 0)
                            {
                                kfe._value /= rot._x;
                            }
                            else if (i == low + 1 && rot._y != 0)
                            {
                                kfe._value /= rot._y;
                            }
                            else if (i == high - 1 && rot._z != 0)
                            {
                                kfe._value /= rot._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newRotate = anim.Rotation;
                    if (rot._x != 0)
                    {
                        rot._x = newRotate._x / rot._x;
                    }

                    if (rot._y != 0)
                    {
                        rot._y = newRotate._y / rot._y;
                    }

                    if (rot._z != 0)
                    {
                        rot._z = newRotate._z / rot._z;
                    }

                    entry.SetKeyframeOnlyRot(0, rot);
                }
            }

            low = 6;
            high = 9;
            if (TranslateReplace.Checked)
            {
                Vector3 trans = (Vector3) transVec;
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = 0x10; i < high; i++)
                    {
                        if (entry.GetKeyframe(i, x) != null)
                        {
                            entry.RemoveKeyframe(i, x);
                        }
                    }
                }

                entry.SetKeyframeOnlyTrans(0, trans);
            }
            else if (TranslateClear.Checked)
            {
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if (entry.GetKeyframe(i, x) != null)
                        {
                            entry.RemoveKeyframe(i, x);
                        }
                    }
                }
            }
            else if (TranslateAdd.Checked)
            {
                Vector3 trans = new Vector3(
                    transVec._x ?? 0,
                    transVec._y ?? 0,
                    transVec._z ?? 0);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value += trans._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value += trans._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value += trans._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newTranslate = anim.Translation;
                    trans._x += newTranslate._x;
                    trans._y += newTranslate._y;
                    trans._z += newTranslate._z;
                    entry.SetKeyframeOnlyTrans(0, trans);
                }
            }
            else if (TranslateSubtract.Checked)
            {
                Vector3 trans = new Vector3(
                    transVec._x ?? 0,
                    transVec._y ?? 0,
                    transVec._z ?? 0);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value -= trans._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value -= trans._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value -= trans._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newTranslate = anim.Translation;
                    trans._x = newTranslate._x - trans._x;
                    trans._y = newTranslate._y - trans._y;
                    trans._z = newTranslate._z - trans._z;
                    entry.SetKeyframeOnlyTrans(0, trans);
                }
            }
            else if (TranslateMultiply.Checked)
            {
                Vector3 trans = new Vector3(
                    transVec._x ?? 1,
                    transVec._y ?? 1,
                    transVec._z ?? 1);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low)
                            {
                                kfe._value *= trans._x;
                            }
                            else if (i == low + 1)
                            {
                                kfe._value *= trans._y;
                            }
                            else if (i == high - 1)
                            {
                                kfe._value *= trans._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newTranslate = anim.Translation;
                    trans._x *= newTranslate._x;
                    trans._y *= newTranslate._y;
                    trans._z *= newTranslate._z;
                    entry.SetKeyframeOnlyTrans(0, trans);
                }
            }
            else if (TranslateDivide.Checked)
            {
                Vector3 trans = new Vector3(
                    transVec._x ?? 1,
                    transVec._y ?? 1,
                    transVec._z ?? 1);
                entry.SignalPropertyChange();
                for (int x = 0; x < numFrames; x++)
                {
                    for (int i = low; i < high; i++)
                    {
                        if ((kfe = entry.GetKeyframe(i, x)) != null)
                        {
                            if (i == low && trans._x != 0)
                            {
                                kfe._value /= trans._x;
                            }
                            else if (i == low + 1 && trans._y != 0)
                            {
                                kfe._value /= trans._y;
                            }
                            else if (i == high - 1 && trans._z != 0)
                            {
                                kfe._value /= trans._z;
                            }

                            hasKeyframe = true;
                        }
                    }
                }

                if (!hasKeyframe)
                {
                    anim = entry.GetAnimFrame(0);
                    Vector3 newTranslate = anim.Translation;
                    if (trans._x != 0)
                    {
                        trans._x = newTranslate._x / trans._x;
                    }

                    if (trans._y != 0)
                    {
                        trans._y = newTranslate._y / trans._y;
                    }

                    if (trans._z != 0)
                    {
                        trans._z = newTranslate._z / trans._z;
                    }

                    entry.SetKeyframeOnlyTrans(0, trans);
                }
            }
        }

        private void copyKeyframes_CheckedChanged(object sender, EventArgs e)
        {
            keyframeCopy.Enabled = copyKeyframes.Checked;
        }

        private void NameContains_CheckedChanged(object sender, EventArgs e)
        {
            targetName.Enabled = NameContains.Checked;
        }

        private void Rename_CheckedChanged(object sender, EventArgs e)
        {
            newName.Enabled = Rename.Checked;
        }

        private void ChangeVersion_CheckedChanged(object sender, EventArgs e)
        {
            Version.Enabled = ChangeVersion.Checked;
        }

        private void ScaleClear_CheckedChanged(object sender, EventArgs e)
        {
            ScaleX.Enabled = ScaleY.Enabled = ScaleZ.Enabled = !ScaleClear.Checked && !ScaleDoNotChange.Checked;
        }

        private void RotateClear_CheckedChanged(object sender, EventArgs e)
        {
            RotateX.Enabled = RotateY.Enabled = RotateZ.Enabled = !RotateClear.Checked && !RotateDoNotChange.Checked;
        }

        private void TranslateClear_CheckedChanged(object sender, EventArgs e)
        {
            TranslateX.Enabled = TranslateY.Enabled =
                TranslateZ.Enabled = !TranslateClear.Checked && !TranslateDoNotChange.Checked;
        }
    }
}