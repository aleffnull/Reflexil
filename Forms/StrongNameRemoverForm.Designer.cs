﻿namespace Reflexil.Forms
{
	partial class StrongNameRemoverForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrongNameRemoverForm));
			this.SNAssemblyLab = new System.Windows.Forms.Label();
			this.SNAssembly = new System.Windows.Forms.TextBox();
			this.SelectSNAssembly = new System.Windows.Forms.Button();
			this.ReferencingBox = new System.Windows.Forms.GroupBox();
			this.ReferencingAssemblies = new System.Windows.Forms.ListBox();
			this.AutoScan = new System.Windows.Forms.Button();
			this.Remove = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.Process = new System.Windows.Forms.Button();
			this.Note = new System.Windows.Forms.Label();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
			this.ReferencingBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// SNAssemblyLab
			// 
			this.SNAssemblyLab.AutoSize = true;
			this.SNAssemblyLab.Location = new System.Drawing.Point(12, 15);
			this.SNAssemblyLab.Name = "SNAssemblyLab";
			this.SNAssemblyLab.Size = new System.Drawing.Size(87, 13);
			this.SNAssemblyLab.TabIndex = 0;
			this.SNAssemblyLab.Text = "Signed assemby:";
			// 
			// SNAssembly
			// 
			this.SNAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SNAssembly.Location = new System.Drawing.Point(105, 12);
			this.SNAssembly.Name = "SNAssembly";
			this.SNAssembly.ReadOnly = true;
			this.SNAssembly.Size = new System.Drawing.Size(440, 20);
			this.SNAssembly.TabIndex = 0;
			// 
			// SelectSNAssembly
			// 
			this.SelectSNAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectSNAssembly.Location = new System.Drawing.Point(551, 10);
			this.SelectSNAssembly.Name = "SelectSNAssembly";
			this.SelectSNAssembly.Size = new System.Drawing.Size(75, 23);
			this.SelectSNAssembly.TabIndex = 1;
			this.SelectSNAssembly.Text = "Select ...";
			this.SelectSNAssembly.UseVisualStyleBackColor = true;
			this.SelectSNAssembly.Click += new System.EventHandler(this.SelectSNAssembly_Click);
			// 
			// ReferencingBox
			// 
			this.ReferencingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ReferencingBox.Controls.Add(this.AutoScan);
			this.ReferencingBox.Controls.Add(this.ReferencingAssemblies);
			this.ReferencingBox.Controls.Add(this.Remove);
			this.ReferencingBox.Controls.Add(this.Add);
			this.ReferencingBox.Location = new System.Drawing.Point(12, 38);
			this.ReferencingBox.Name = "ReferencingBox";
			this.ReferencingBox.Size = new System.Drawing.Size(614, 241);
			this.ReferencingBox.TabIndex = 2;
			this.ReferencingBox.TabStop = false;
			this.ReferencingBox.Text = "Referencing assemblies to update";
			// 
			// ReferencingAssemblies
			// 
			this.ReferencingAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ReferencingAssemblies.FormattingEnabled = true;
			this.ReferencingAssemblies.Location = new System.Drawing.Point(6, 19);
			this.ReferencingAssemblies.Name = "ReferencingAssemblies";
			this.ReferencingAssemblies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.ReferencingAssemblies.Size = new System.Drawing.Size(602, 173);
			this.ReferencingAssemblies.TabIndex = 0;
			this.ReferencingAssemblies.SelectedIndexChanged += new System.EventHandler(this.ReferencingAssemblies_SelectedIndexChanged);
			this.ReferencingAssemblies.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReferencingAssemblies_MouseMove);
			// 
			// AutoScan
			// 
			this.AutoScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AutoScan.Enabled = false;
			this.AutoScan.Location = new System.Drawing.Point(416, 212);
			this.AutoScan.Name = "AutoScan";
			this.AutoScan.Size = new System.Drawing.Size(192, 23);
			this.AutoScan.TabIndex = 2;
			this.AutoScan.Text = "Auto scan assembly directory ...";
			this.AutoScan.UseVisualStyleBackColor = true;
			this.AutoScan.Click += new System.EventHandler(this.AutoScan_Click);
			// 
			// Remove
			// 
			this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Remove.Enabled = false;
			this.Remove.Location = new System.Drawing.Point(346, 212);
			this.Remove.Name = "Remove";
			this.Remove.Size = new System.Drawing.Size(64, 23);
			this.Remove.TabIndex = 1;
			this.Remove.Text = "Remove";
			this.Remove.UseVisualStyleBackColor = true;
			this.Remove.Click += new System.EventHandler(this.Remove_Click);
			// 
			// Add
			// 
			this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Add.Enabled = false;
			this.Add.Location = new System.Drawing.Point(276, 212);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(64, 23);
			this.Add.TabIndex = 0;
			this.Add.Text = "Add ...";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Process
			// 
			this.Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Process.Enabled = false;
			this.Process.Location = new System.Drawing.Point(12, 337);
			this.Process.Name = "Process";
			this.Process.Size = new System.Drawing.Size(614, 23);
			this.Process.TabIndex = 3;
			this.Process.Text = "Remove Strong Name and update referencing assemblies ";
			this.Process.UseVisualStyleBackColor = true;
			this.Process.Click += new System.EventHandler(this.Process_Click);
			// 
			// Note
			// 
			this.Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Note.Location = new System.Drawing.Point(9, 282);
			this.Note.Name = "Note";
			this.Note.Size = new System.Drawing.Size(617, 52);
			this.Note.TabIndex = 5;
			this.Note.Text = resources.GetString("Note.Text");
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.Filter = "Assemblies|*.exe;*.dll|All files|*.*";
			this.OpenFileDialog.Multiselect = true;
			// 
			// StrongNameRemoverForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 372);
			this.Controls.Add(this.Process);
			this.Controls.Add(this.ReferencingBox);
			this.Controls.Add(this.SelectSNAssembly);
			this.Controls.Add(this.SNAssembly);
			this.Controls.Add(this.SNAssemblyLab);
			this.Controls.Add(this.Note);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StrongNameRemoverForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Strong Name Remover";
			this.ReferencingBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label SNAssemblyLab;
        private System.Windows.Forms.TextBox SNAssembly;
        private System.Windows.Forms.Button SelectSNAssembly;
				private System.Windows.Forms.GroupBox ReferencingBox;
        private System.Windows.Forms.Button AutoScan;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox ReferencingAssemblies;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Label Note;
				private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolTip Tooltip;
	}
}