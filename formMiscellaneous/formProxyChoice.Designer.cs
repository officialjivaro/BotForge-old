namespace Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous
{
    partial class formProxyChoice
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProxyChoice));
            buttonProxyChoice_IPRoyal = new Button();
            buttonProxyChoice_SeeFullList = new Button();
            buttonProxyChoice_ProxyCheap = new Button();
            buttonProxyChoice_ProxySeller = new Button();
            SuspendLayout();
            // 
            // buttonProxyChoice_IPRoyal
            // 
            buttonProxyChoice_IPRoyal.FlatAppearance.BorderColor = Color.Coral;
            buttonProxyChoice_IPRoyal.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonProxyChoice_IPRoyal.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonProxyChoice_IPRoyal.FlatStyle = FlatStyle.Flat;
            buttonProxyChoice_IPRoyal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProxyChoice_IPRoyal.Location = new Point(25, 25);
            buttonProxyChoice_IPRoyal.Margin = new Padding(0);
            buttonProxyChoice_IPRoyal.Name = "buttonProxyChoice_IPRoyal";
            buttonProxyChoice_IPRoyal.Size = new Size(100, 65);
            buttonProxyChoice_IPRoyal.TabIndex = 0;
            buttonProxyChoice_IPRoyal.Text = "IPRoyal";
            buttonProxyChoice_IPRoyal.UseVisualStyleBackColor = true;
            buttonProxyChoice_IPRoyal.Click += btnProxyChoice_IPRoyal_Click;
            // 
            // buttonProxyChoice_SeeFullList
            // 
            buttonProxyChoice_SeeFullList.FlatAppearance.BorderColor = Color.Coral;
            buttonProxyChoice_SeeFullList.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonProxyChoice_SeeFullList.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonProxyChoice_SeeFullList.FlatStyle = FlatStyle.Flat;
            buttonProxyChoice_SeeFullList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProxyChoice_SeeFullList.Location = new Point(200, 125);
            buttonProxyChoice_SeeFullList.Margin = new Padding(0);
            buttonProxyChoice_SeeFullList.Name = "buttonProxyChoice_SeeFullList";
            buttonProxyChoice_SeeFullList.Size = new Size(100, 65);
            buttonProxyChoice_SeeFullList.TabIndex = 1;
            buttonProxyChoice_SeeFullList.Text = "See Full List";
            buttonProxyChoice_SeeFullList.UseVisualStyleBackColor = true;
            buttonProxyChoice_SeeFullList.Click += btnProxyChoice_SeeFullList_Click;
            // 
            // buttonProxyChoice_ProxyCheap
            // 
            buttonProxyChoice_ProxyCheap.FlatAppearance.BorderColor = Color.Coral;
            buttonProxyChoice_ProxyCheap.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonProxyChoice_ProxyCheap.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonProxyChoice_ProxyCheap.FlatStyle = FlatStyle.Flat;
            buttonProxyChoice_ProxyCheap.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProxyChoice_ProxyCheap.Location = new Point(200, 25);
            buttonProxyChoice_ProxyCheap.Margin = new Padding(0);
            buttonProxyChoice_ProxyCheap.Name = "buttonProxyChoice_ProxyCheap";
            buttonProxyChoice_ProxyCheap.Size = new Size(100, 65);
            buttonProxyChoice_ProxyCheap.TabIndex = 2;
            buttonProxyChoice_ProxyCheap.Text = "Proxy-Cheap";
            buttonProxyChoice_ProxyCheap.UseVisualStyleBackColor = true;
            buttonProxyChoice_ProxyCheap.Click += btnProxyChoice_ProxyCheap_Click;
            // 
            // buttonProxyChoice_ProxySeller
            // 
            buttonProxyChoice_ProxySeller.FlatAppearance.BorderColor = Color.Coral;
            buttonProxyChoice_ProxySeller.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonProxyChoice_ProxySeller.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonProxyChoice_ProxySeller.FlatStyle = FlatStyle.Flat;
            buttonProxyChoice_ProxySeller.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProxyChoice_ProxySeller.Location = new Point(25, 125);
            buttonProxyChoice_ProxySeller.Margin = new Padding(0);
            buttonProxyChoice_ProxySeller.Name = "buttonProxyChoice_ProxySeller";
            buttonProxyChoice_ProxySeller.Size = new Size(100, 65);
            buttonProxyChoice_ProxySeller.TabIndex = 3;
            buttonProxyChoice_ProxySeller.Text = "Proxy-Seller";
            buttonProxyChoice_ProxySeller.UseVisualStyleBackColor = true;
            buttonProxyChoice_ProxySeller.Click += btnProxyChoice_ProxySeller_Click;
            // 
            // formProxyChoice
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(334, 211);
            Controls.Add(buttonProxyChoice_ProxySeller);
            Controls.Add(buttonProxyChoice_ProxyCheap);
            Controls.Add(buttonProxyChoice_SeeFullList);
            Controls.Add(buttonProxyChoice_IPRoyal);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formProxyChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose a Proxy Provider";
            ResumeLayout(false);
        }

        #endregion

        public Button buttonProxyChoice_IPRoyal;
        public Button buttonProxyChoice_SeeFullList;
        public Button buttonProxyChoice_ProxyCheap;
        public Button buttonProxyChoice_ProxySeller;
    }
}