﻿namespace hellenicair2
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.Label flightIDLabel;
            System.Windows.Forms.Label departureLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label departureDateTimeLabel;
            System.Windows.Forms.Label arrivalDateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flightsDataSet = new hellenicair2.flightsDataSet();
            this.flights3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flights3TableAdapter = new hellenicair2.flightsDataSetTableAdapters.flights3TableAdapter();
            this.tableAdapterManager = new hellenicair2.flightsDataSetTableAdapters.TableAdapterManager();
            this.flights3DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightIDTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.departureDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flight116ToolStrip = new System.Windows.Forms.ToolStrip();
            this.flightIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.flightIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.flight116ToolStripButton = new System.Windows.Forms.ToolStripButton();
            flightIDLabel = new System.Windows.Forms.Label();
            departureLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            departureDateTimeLabel = new System.Windows.Forms.Label();
            arrivalDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flights3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flights3DataGridView)).BeginInit();
            this.flight116ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightIDLabel
            // 
            flightIDLabel.AutoSize = true;
            flightIDLabel.Location = new System.Drawing.Point(24, 229);
            flightIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            flightIDLabel.Name = "flightIDLabel";
            flightIDLabel.Size = new System.Drawing.Size(49, 13);
            flightIDLabel.TabIndex = 22;
            flightIDLabel.Text = "Flight ID:";
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.Location = new System.Drawing.Point(24, 252);
            departureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new System.Drawing.Size(57, 13);
            departureLabel.TabIndex = 24;
            departureLabel.Text = "Departure:";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(24, 275);
            destinationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(63, 13);
            destinationLabel.TabIndex = 26;
            destinationLabel.Text = "Destination:";
            // 
            // departureDateTimeLabel
            // 
            departureDateTimeLabel.AutoSize = true;
            departureDateTimeLabel.Location = new System.Drawing.Point(24, 297);
            departureDateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departureDateTimeLabel.Name = "departureDateTimeLabel";
            departureDateTimeLabel.Size = new System.Drawing.Size(111, 13);
            departureDateTimeLabel.TabIndex = 28;
            departureDateTimeLabel.Text = "Departure Date/Time:";
            // 
            // arrivalDateTimeLabel
            // 
            arrivalDateTimeLabel.AutoSize = true;
            arrivalDateTimeLabel.Location = new System.Drawing.Point(24, 320);
            arrivalDateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            arrivalDateTimeLabel.Name = "arrivalDateTimeLabel";
            arrivalDateTimeLabel.Size = new System.Drawing.Size(93, 13);
            arrivalDateTimeLabel.TabIndex = 30;
            arrivalDateTimeLabel.Text = "Arrival Date/Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(202, 106);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(363, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "List of Available Flights";
            // 
            // flightsDataSet
            // 
            this.flightsDataSet.DataSetName = "flightsDataSet";
            this.flightsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flights3BindingSource
            // 
            this.flights3BindingSource.DataMember = "flights3";
            this.flights3BindingSource.DataSource = this.flightsDataSet;
            // 
            // flights3TableAdapter
            // 
            this.flights3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.flights3TableAdapter = this.flights3TableAdapter;
            this.tableAdapterManager.UpdateOrder = hellenicair2.flightsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flights3DataGridView
            // 
            this.flights3DataGridView.AutoGenerateColumns = false;
            this.flights3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flights3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.flights3DataGridView.DataSource = this.flights3BindingSource;
            this.flights3DataGridView.Location = new System.Drawing.Point(226, 229);
            this.flights3DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flights3DataGridView.Name = "flights3DataGridView";
            this.flights3DataGridView.RowTemplate.Height = 24;
            this.flights3DataGridView.Size = new System.Drawing.Size(473, 155);
            this.flights3DataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departure";
            this.dataGridViewTextBoxColumn2.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn3.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartureDateTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartureDateTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ArrivalDateTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "ArrivalDateTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // flightIDTextBox
            // 
            this.flightIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "FlightID", true));
            this.flightIDTextBox.Location = new System.Drawing.Point(137, 227);
            this.flightIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightIDTextBox.Name = "flightIDTextBox";
            this.flightIDTextBox.Size = new System.Drawing.Size(76, 20);
            this.flightIDTextBox.TabIndex = 23;
            // 
            // departureTextBox
            // 
            this.departureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "Departure", true));
            this.departureTextBox.Location = new System.Drawing.Point(137, 249);
            this.departureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(76, 20);
            this.departureTextBox.TabIndex = 25;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(137, 272);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(76, 20);
            this.destinationTextBox.TabIndex = 27;
            // 
            // departureDateTimeTextBox
            // 
            this.departureDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "DepartureDateTime", true));
            this.departureDateTimeTextBox.Location = new System.Drawing.Point(137, 295);
            this.departureDateTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureDateTimeTextBox.Name = "departureDateTimeTextBox";
            this.departureDateTimeTextBox.Size = new System.Drawing.Size(76, 20);
            this.departureDateTimeTextBox.TabIndex = 29;
            // 
            // arrivalDateTimeTextBox
            // 
            this.arrivalDateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flights3BindingSource, "ArrivalDateTime", true));
            this.arrivalDateTimeTextBox.Location = new System.Drawing.Point(137, 318);
            this.arrivalDateTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrivalDateTimeTextBox.Name = "arrivalDateTimeTextBox";
            this.arrivalDateTimeTextBox.Size = new System.Drawing.Size(76, 20);
            this.arrivalDateTimeTextBox.TabIndex = 31;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(24, 397);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 14);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Administrator Login";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 39;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 24);
            this.button2.TabIndex = 40;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 393);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 24);
            this.button4.TabIndex = 41;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 24);
            this.button3.TabIndex = 42;
            this.button3.Text = "Continue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flight116ToolStrip
            // 
            this.flight116ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.flight116ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightIDToolStripLabel,
            this.flightIDToolStripTextBox,
            this.flight116ToolStripButton});
            this.flight116ToolStrip.Location = new System.Drawing.Point(26, 175);
            this.flight116ToolStrip.Name = "flight116ToolStrip";
            this.flight116ToolStrip.Size = new System.Drawing.Size(316, 25);
            this.flight116ToolStrip.TabIndex = 43;
            this.flight116ToolStrip.Text = "flight116ToolStrip";
            // 
            // flightIDToolStripLabel
            // 
            this.flightIDToolStripLabel.Name = "flightIDToolStripLabel";
            this.flightIDToolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // flightIDToolStripTextBox
            // 
            this.flightIDToolStripTextBox.Name = "flightIDToolStripTextBox";
            this.flightIDToolStripTextBox.Size = new System.Drawing.Size(226, 25);
            // 
            // flight116ToolStripButton
            // 
            this.flight116ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.flight116ToolStripButton.Name = "flight116ToolStripButton";
            this.flight116ToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.flight116ToolStripButton.Text = "Search Flights";
            this.flight116ToolStripButton.Click += new System.EventHandler(this.flight116ToolStripButton_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 488);
            this.Controls.Add(this.flight116ToolStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(flightIDLabel);
            this.Controls.Add(this.flightIDTextBox);
            this.Controls.Add(departureLabel);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(departureDateTimeLabel);
            this.Controls.Add(this.departureDateTimeTextBox);
            this.Controls.Add(arrivalDateTimeLabel);
            this.Controls.Add(this.arrivalDateTimeTextBox);
            this.Controls.Add(this.flights3DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form11";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AERObook";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flights3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flights3DataGridView)).EndInit();
            this.flight116ToolStrip.ResumeLayout(false);
            this.flight116ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private flightsDataSet flightsDataSet;
        private System.Windows.Forms.BindingSource flights3BindingSource;
        private flightsDataSetTableAdapters.flights3TableAdapter flights3TableAdapter;
        private flightsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView flights3DataGridView;
        private System.Windows.Forms.TextBox flightIDTextBox;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox departureDateTimeTextBox;
        private System.Windows.Forms.TextBox arrivalDateTimeTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip flight116ToolStrip;
        private System.Windows.Forms.ToolStripLabel flightIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox flightIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton flight116ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

    }
}
