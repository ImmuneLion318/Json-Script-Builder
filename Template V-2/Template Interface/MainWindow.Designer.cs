namespace Interface
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.TabController = new MaterialSkin.Controls.MaterialTabControl();
            this.BuilderPage = new System.Windows.Forms.TabPage();
            this.ItemList = new MaterialSkin.Controls.MaterialListBox();
            this.CreateBtn = new MaterialSkin.Controls.MaterialButton();
            this.ScriptBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.DescriptionDivider = new MaterialSkin.Controls.MaterialDivider();
            this.DescriptionBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.TitleDivider = new MaterialSkin.Controls.MaterialDivider();
            this.TitleBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.AddBtn = new MaterialSkin.Controls.MaterialButton();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.EncodeBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.TabController.SuspendLayout();
            this.BuilderPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Home Logo.png");
            this.ImageList.Images.SetKeyName(1, "Settings Logo.png");
            this.ImageList.Images.SetKeyName(2, "Question Logo.png");
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.BuilderPage);
            this.TabController.Controls.Add(this.SettingsPage);
            this.TabController.Depth = 0;
            this.TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabController.ImageList = this.ImageList;
            this.TabController.Location = new System.Drawing.Point(3, 64);
            this.TabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabController.Multiline = true;
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(594, 283);
            this.TabController.TabIndex = 0;
            // 
            // BuilderPage
            // 
            this.BuilderPage.BackColor = System.Drawing.Color.White;
            this.BuilderPage.Controls.Add(this.ItemList);
            this.BuilderPage.Controls.Add(this.CreateBtn);
            this.BuilderPage.Controls.Add(this.ScriptBox);
            this.BuilderPage.Controls.Add(this.DescriptionDivider);
            this.BuilderPage.Controls.Add(this.DescriptionBox);
            this.BuilderPage.Controls.Add(this.TitleDivider);
            this.BuilderPage.Controls.Add(this.TitleBox);
            this.BuilderPage.Controls.Add(this.AddBtn);
            this.BuilderPage.ImageKey = "Home Logo.png";
            this.BuilderPage.Location = new System.Drawing.Point(4, 39);
            this.BuilderPage.Name = "BuilderPage";
            this.BuilderPage.Padding = new System.Windows.Forms.Padding(3);
            this.BuilderPage.Size = new System.Drawing.Size(586, 240);
            this.BuilderPage.TabIndex = 0;
            this.BuilderPage.Text = "Builder";
            // 
            // ItemList
            // 
            this.ItemList.BackColor = System.Drawing.Color.Transparent;
            this.ItemList.BorderColor = System.Drawing.Color.Transparent;
            this.ItemList.Depth = 0;
            this.ItemList.Dock = System.Windows.Forms.DockStyle.Right;
            this.ItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemList.Location = new System.Drawing.Point(371, 3);
            this.ItemList.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemList.Name = "ItemList";
            this.ItemList.SelectedIndex = -1;
            this.ItemList.SelectedItem = null;
            this.ItemList.ShowBorder = false;
            this.ItemList.Size = new System.Drawing.Size(212, 234);
            this.ItemList.TabIndex = 18;
            this.ItemList.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.CreateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateBtn.Depth = 0;
            this.CreateBtn.HighEmphasis = true;
            this.CreateBtn.Icon = null;
            this.CreateBtn.Location = new System.Drawing.Point(115, 198);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateBtn.Size = new System.Drawing.Size(103, 36);
            this.CreateBtn.TabIndex = 17;
            this.CreateBtn.Text = "Build Json";
            this.CreateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateBtn.UseAccentColor = false;
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ScriptBox
            // 
            this.ScriptBox.AnimateReadOnly = false;
            this.ScriptBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScriptBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ScriptBox.Depth = 0;
            this.ScriptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ScriptBox.HideSelection = true;
            this.ScriptBox.LeadingIcon = null;
            this.ScriptBox.Location = new System.Drawing.Point(6, 143);
            this.ScriptBox.MaxLength = 32767;
            this.ScriptBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.PasswordChar = '\0';
            this.ScriptBox.PrefixSuffixText = null;
            this.ScriptBox.ReadOnly = false;
            this.ScriptBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScriptBox.SelectedText = "";
            this.ScriptBox.SelectionLength = 0;
            this.ScriptBox.SelectionStart = 0;
            this.ScriptBox.ShortcutsEnabled = true;
            this.ScriptBox.Size = new System.Drawing.Size(362, 48);
            this.ScriptBox.TabIndex = 16;
            this.ScriptBox.TabStop = false;
            this.ScriptBox.Text = "Script";
            this.ScriptBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ScriptBox.TrailingIcon = null;
            this.ScriptBox.UseSystemPasswordChar = false;
            this.ScriptBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScriptBox_MouseDown);
            // 
            // DescriptionDivider
            // 
            this.DescriptionDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescriptionDivider.Depth = 0;
            this.DescriptionDivider.Location = new System.Drawing.Point(6, 127);
            this.DescriptionDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionDivider.Name = "DescriptionDivider";
            this.DescriptionDivider.Size = new System.Drawing.Size(362, 5);
            this.DescriptionDivider.TabIndex = 15;
            this.DescriptionDivider.Text = "Divider";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AnimateReadOnly = false;
            this.DescriptionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DescriptionBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DescriptionBox.Depth = 0;
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionBox.HideSelection = true;
            this.DescriptionBox.LeadingIcon = null;
            this.DescriptionBox.Location = new System.Drawing.Point(6, 73);
            this.DescriptionBox.MaxLength = 32767;
            this.DescriptionBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.PasswordChar = '\0';
            this.DescriptionBox.PrefixSuffixText = null;
            this.DescriptionBox.ReadOnly = false;
            this.DescriptionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionBox.SelectedText = "";
            this.DescriptionBox.SelectionLength = 0;
            this.DescriptionBox.SelectionStart = 0;
            this.DescriptionBox.ShortcutsEnabled = true;
            this.DescriptionBox.Size = new System.Drawing.Size(362, 48);
            this.DescriptionBox.TabIndex = 14;
            this.DescriptionBox.TabStop = false;
            this.DescriptionBox.Text = "Description";
            this.DescriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionBox.TrailingIcon = null;
            this.DescriptionBox.UseSystemPasswordChar = false;
            this.DescriptionBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DescriptionBox_MouseDown);
            // 
            // TitleDivider
            // 
            this.TitleDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleDivider.Depth = 0;
            this.TitleDivider.Location = new System.Drawing.Point(6, 57);
            this.TitleDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.TitleDivider.Name = "TitleDivider";
            this.TitleDivider.Size = new System.Drawing.Size(362, 5);
            this.TitleDivider.TabIndex = 13;
            this.TitleDivider.Text = "Divider";
            // 
            // TitleBox
            // 
            this.TitleBox.AnimateReadOnly = false;
            this.TitleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TitleBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TitleBox.Depth = 0;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TitleBox.HideSelection = true;
            this.TitleBox.LeadingIcon = null;
            this.TitleBox.Location = new System.Drawing.Point(6, 6);
            this.TitleBox.MaxLength = 32767;
            this.TitleBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.PasswordChar = '\0';
            this.TitleBox.PrefixSuffixText = null;
            this.TitleBox.ReadOnly = false;
            this.TitleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleBox.SelectedText = "";
            this.TitleBox.SelectionLength = 0;
            this.TitleBox.SelectionStart = 0;
            this.TitleBox.ShortcutsEnabled = true;
            this.TitleBox.Size = new System.Drawing.Size(362, 48);
            this.TitleBox.TabIndex = 12;
            this.TitleBox.TabStop = false;
            this.TitleBox.Text = "Title";
            this.TitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TitleBox.TrailingIcon = null;
            this.TitleBox.UseSystemPasswordChar = false;
            this.TitleBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBox_MouseDown);
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.AddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddBtn.Depth = 0;
            this.AddBtn.HighEmphasis = true;
            this.AddBtn.Icon = null;
            this.AddBtn.Location = new System.Drawing.Point(7, 198);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddBtn.Size = new System.Drawing.Size(103, 36);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add To Set";
            this.AddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddBtn.UseAccentColor = false;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.White;
            this.SettingsPage.Controls.Add(this.EncodeBox);
            this.SettingsPage.ImageKey = "Settings Logo.png";
            this.SettingsPage.Location = new System.Drawing.Point(4, 39);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(586, 240);
            this.SettingsPage.TabIndex = 1;
            this.SettingsPage.Text = "Settings";
            // 
            // EncodeBox
            // 
            this.EncodeBox.AutoSize = true;
            this.EncodeBox.Depth = 0;
            this.EncodeBox.Location = new System.Drawing.Point(3, 3);
            this.EncodeBox.Margin = new System.Windows.Forms.Padding(0);
            this.EncodeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EncodeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EncodeBox.Name = "EncodeBox";
            this.EncodeBox.ReadOnly = false;
            this.EncodeBox.Ripple = true;
            this.EncodeBox.Size = new System.Drawing.Size(87, 37);
            this.EncodeBox.TabIndex = 0;
            this.EncodeBox.Text = "Encode";
            this.EncodeBox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.TabController);
            this.DrawerTabControl = this.TabController;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json Script Builder";
            this.Load += new System.EventHandler(this.OnLoad);
            this.TabController.ResumeLayout(false);
            this.BuilderPage.ResumeLayout(false);
            this.BuilderPage.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImageList;
        private MaterialSkin.Controls.MaterialTabControl TabController;
        private System.Windows.Forms.TabPage BuilderPage;
        private MaterialSkin.Controls.MaterialListBox ItemList;
        private MaterialSkin.Controls.MaterialButton CreateBtn;
        private MaterialSkin.Controls.MaterialTextBox2 ScriptBox;
        private MaterialSkin.Controls.MaterialDivider DescriptionDivider;
        private MaterialSkin.Controls.MaterialTextBox2 DescriptionBox;
        private MaterialSkin.Controls.MaterialDivider TitleDivider;
        private MaterialSkin.Controls.MaterialTextBox2 TitleBox;
        private MaterialSkin.Controls.MaterialButton AddBtn;
        private System.Windows.Forms.TabPage SettingsPage;
        private MaterialSkin.Controls.MaterialCheckbox EncodeBox;
    }
}

