using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyToVK
{
	public partial class STVK_MainForm : Form
	{
		private Button Login_Button;
		private Label LoginStatus_Label;
		private TableLayoutPanel Spotify_tableLayoutPanel;
		private Label SpotifyToken_Label;
		private Label ClientID_Label;
		private Label SecretID_Label;
		private TextBox SecretID_textBox;
		private TextBox SpotifyToken_textBox;
		private TextBox ClientID_textBox;
		private GroupBox Control_groupBox;
		private GroupBox Login_groupBox;
		private FlowLayoutPanel Login_flowLayoutPanel;
		private Button LoginSave_Button;
		private TableLayoutPanel VK_tableLayoutPanel;
		private Label VKToken_Label;
		private Label UserID_Label;
		private TextBox UserID_textBox;
		private TextBox VKToken_textBox;
		private PictureBox AlbumLogo_pictureBox;
		private TableLayoutPanel tableLayoutPanel1;
		private Label Title_Label;
		private Label Artist_Label;
		private Button CheckLogin_Button;
		private ProgressBar progressBar1;
		private CheckBox LoginStatus_checkBox;
        private GroupBox Settings_groupBox;
        private CheckBox LoadSettings_checkBox;
        private Button Start_Button;

        // private IContainer components;
        private GroupBox SongInfo_groupBox;

		public STVK_MainForm()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
            this.Login_Button = new System.Windows.Forms.Button();
            this.LoginStatus_Label = new System.Windows.Forms.Label();
            this.Spotify_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SpotifyToken_Label = new System.Windows.Forms.Label();
            this.ClientID_Label = new System.Windows.Forms.Label();
            this.SecretID_Label = new System.Windows.Forms.Label();
            this.SecretID_textBox = new System.Windows.Forms.TextBox();
            this.SpotifyToken_textBox = new System.Windows.Forms.TextBox();
            this.ClientID_textBox = new System.Windows.Forms.TextBox();
            this.Control_groupBox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Login_groupBox = new System.Windows.Forms.GroupBox();
            this.Login_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LoginSave_Button = new System.Windows.Forms.Button();
            this.CheckLogin_Button = new System.Windows.Forms.Button();
            this.LoginStatus_checkBox = new System.Windows.Forms.CheckBox();
            this.VK_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.VKToken_Label = new System.Windows.Forms.Label();
            this.UserID_Label = new System.Windows.Forms.Label();
            this.UserID_textBox = new System.Windows.Forms.TextBox();
            this.VKToken_textBox = new System.Windows.Forms.TextBox();
            this.SongInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Artist_Label = new System.Windows.Forms.Label();
            this.AlbumLogo_pictureBox = new System.Windows.Forms.PictureBox();
            this.Settings_groupBox = new System.Windows.Forms.GroupBox();
            this.LoadSettings_checkBox = new System.Windows.Forms.CheckBox();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Spotify_tableLayoutPanel.SuspendLayout();
            this.Control_groupBox.SuspendLayout();
            this.Login_groupBox.SuspendLayout();
            this.Login_flowLayoutPanel.SuspendLayout();
            this.VK_tableLayoutPanel.SuspendLayout();
            this.SongInfo_groupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumLogo_pictureBox)).BeginInit();
            this.Settings_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Login_Button.Location = new System.Drawing.Point(3, 3);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(52, 23);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Логин";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // LoginStatus_Label
            // 
            this.LoginStatus_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginStatus_Label.AutoSize = true;
            this.LoginStatus_Label.Location = new System.Drawing.Point(223, 8);
            this.LoginStatus_Label.Name = "LoginStatus_Label";
            this.LoginStatus_Label.Size = new System.Drawing.Size(107, 13);
            this.LoginStatus_Label.TabIndex = 1;
            this.LoginStatus_Label.Text = "Не авторизировано";
            this.LoginStatus_Label.Click += new System.EventHandler(this.LoginStatus_Label_Click);
            // 
            // Spotify_tableLayoutPanel
            // 
            this.Spotify_tableLayoutPanel.ColumnCount = 2;
            this.Spotify_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Spotify_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.Spotify_tableLayoutPanel.Controls.Add(this.SpotifyToken_Label, 0, 2);
            this.Spotify_tableLayoutPanel.Controls.Add(this.ClientID_Label, 0, 0);
            this.Spotify_tableLayoutPanel.Controls.Add(this.SecretID_Label, 0, 1);
            this.Spotify_tableLayoutPanel.Controls.Add(this.SecretID_textBox, 1, 1);
            this.Spotify_tableLayoutPanel.Controls.Add(this.SpotifyToken_textBox, 1, 2);
            this.Spotify_tableLayoutPanel.Controls.Add(this.ClientID_textBox, 1, 0);
            this.Spotify_tableLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.Spotify_tableLayoutPanel.Name = "Spotify_tableLayoutPanel";
            this.Spotify_tableLayoutPanel.RowCount = 3;
            this.Spotify_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Spotify_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Spotify_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Spotify_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Spotify_tableLayoutPanel.Size = new System.Drawing.Size(364, 81);
            this.Spotify_tableLayoutPanel.TabIndex = 3;
            // 
            // SpotifyToken_Label
            // 
            this.SpotifyToken_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpotifyToken_Label.AutoSize = true;
            this.SpotifyToken_Label.Location = new System.Drawing.Point(3, 61);
            this.SpotifyToken_Label.Name = "SpotifyToken_Label";
            this.SpotifyToken_Label.Size = new System.Drawing.Size(73, 13);
            this.SpotifyToken_Label.TabIndex = 4;
            this.SpotifyToken_Label.Text = "Spotify Token";
            // 
            // ClientID_Label
            // 
            this.ClientID_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClientID_Label.AutoSize = true;
            this.ClientID_Label.Location = new System.Drawing.Point(3, 7);
            this.ClientID_Label.Name = "ClientID_Label";
            this.ClientID_Label.Size = new System.Drawing.Size(47, 13);
            this.ClientID_Label.TabIndex = 2;
            this.ClientID_Label.Text = "Client ID";
            // 
            // SecretID_Label
            // 
            this.SecretID_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecretID_Label.AutoSize = true;
            this.SecretID_Label.Location = new System.Drawing.Point(3, 34);
            this.SecretID_Label.Name = "SecretID_Label";
            this.SecretID_Label.Size = new System.Drawing.Size(52, 13);
            this.SecretID_Label.TabIndex = 3;
            this.SecretID_Label.Text = "Secret ID";
            // 
            // SecretID_textBox
            // 
            this.SecretID_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecretID_textBox.Location = new System.Drawing.Point(94, 30);
            this.SecretID_textBox.Name = "SecretID_textBox";
            this.SecretID_textBox.Size = new System.Drawing.Size(267, 20);
            this.SecretID_textBox.TabIndex = 6;
            this.SecretID_textBox.TextChanged += new System.EventHandler(this.SecretID_textBox_TextChanged);
            // 
            // SpotifyToken_textBox
            // 
            this.SpotifyToken_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpotifyToken_textBox.Location = new System.Drawing.Point(94, 57);
            this.SpotifyToken_textBox.Name = "SpotifyToken_textBox";
            this.SpotifyToken_textBox.Size = new System.Drawing.Size(267, 20);
            this.SpotifyToken_textBox.TabIndex = 7;
            this.SpotifyToken_textBox.TextChanged += new System.EventHandler(this.SpotifyToken_textBox_TextChanged);
            // 
            // ClientID_textBox
            // 
            this.ClientID_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClientID_textBox.Location = new System.Drawing.Point(94, 3);
            this.ClientID_textBox.Name = "ClientID_textBox";
            this.ClientID_textBox.Size = new System.Drawing.Size(267, 20);
            this.ClientID_textBox.TabIndex = 5;
            this.ClientID_textBox.TextChanged += new System.EventHandler(this.ClientID_textBox_TextChanged);
            // 
            // Control_groupBox
            // 
            this.Control_groupBox.Controls.Add(this.progressBar1);
            this.Control_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Control_groupBox.Name = "Control_groupBox";
            this.Control_groupBox.Size = new System.Drawing.Size(276, 100);
            this.Control_groupBox.TabIndex = 4;
            this.Control_groupBox.TabStop = false;
            this.Control_groupBox.Text = "Управление";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Login_groupBox
            // 
            this.Login_groupBox.Controls.Add(this.Login_flowLayoutPanel);
            this.Login_groupBox.Controls.Add(this.VK_tableLayoutPanel);
            this.Login_groupBox.Controls.Add(this.Spotify_tableLayoutPanel);
            this.Login_groupBox.Location = new System.Drawing.Point(294, 12);
            this.Login_groupBox.Name = "Login_groupBox";
            this.Login_groupBox.Size = new System.Drawing.Size(376, 202);
            this.Login_groupBox.TabIndex = 5;
            this.Login_groupBox.TabStop = false;
            this.Login_groupBox.Text = "Авторизация";
            // 
            // Login_flowLayoutPanel
            // 
            this.Login_flowLayoutPanel.Controls.Add(this.Login_Button);
            this.Login_flowLayoutPanel.Controls.Add(this.LoginSave_Button);
            this.Login_flowLayoutPanel.Controls.Add(this.CheckLogin_Button);
            this.Login_flowLayoutPanel.Controls.Add(this.LoginStatus_Label);
            this.Login_flowLayoutPanel.Controls.Add(this.LoginStatus_checkBox);
            this.Login_flowLayoutPanel.Location = new System.Drawing.Point(9, 166);
            this.Login_flowLayoutPanel.Name = "Login_flowLayoutPanel";
            this.Login_flowLayoutPanel.Size = new System.Drawing.Size(361, 30);
            this.Login_flowLayoutPanel.TabIndex = 6;
            // 
            // LoginSave_Button
            // 
            this.LoginSave_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginSave_Button.Location = new System.Drawing.Point(61, 3);
            this.LoginSave_Button.Name = "LoginSave_Button";
            this.LoginSave_Button.Size = new System.Drawing.Size(75, 23);
            this.LoginSave_Button.TabIndex = 1;
            this.LoginSave_Button.Text = "Сохранить";
            this.LoginSave_Button.UseVisualStyleBackColor = true;
            this.LoginSave_Button.Click += new System.EventHandler(this.LoginSave_Button_Click);
            // 
            // CheckLogin_Button
            // 
            this.CheckLogin_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckLogin_Button.Location = new System.Drawing.Point(142, 3);
            this.CheckLogin_Button.Name = "CheckLogin_Button";
            this.CheckLogin_Button.Size = new System.Drawing.Size(75, 23);
            this.CheckLogin_Button.TabIndex = 2;
            this.CheckLogin_Button.Text = "Проверка";
            this.CheckLogin_Button.UseVisualStyleBackColor = true;
            this.CheckLogin_Button.Click += new System.EventHandler(this.CheckLogin_Button_Click);
            // 
            // LoginStatus_checkBox
            // 
            this.LoginStatus_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginStatus_checkBox.AutoSize = true;
            this.LoginStatus_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginStatus_checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginStatus_checkBox.Location = new System.Drawing.Point(336, 9);
            this.LoginStatus_checkBox.Name = "LoginStatus_checkBox";
            this.LoginStatus_checkBox.Size = new System.Drawing.Size(12, 11);
            this.LoginStatus_checkBox.TabIndex = 3;
            this.LoginStatus_checkBox.UseVisualStyleBackColor = true;
            // 
            // VK_tableLayoutPanel
            // 
            this.VK_tableLayoutPanel.ColumnCount = 2;
            this.VK_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.VK_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.VK_tableLayoutPanel.Controls.Add(this.VKToken_Label, 0, 0);
            this.VK_tableLayoutPanel.Controls.Add(this.UserID_Label, 0, 1);
            this.VK_tableLayoutPanel.Controls.Add(this.UserID_textBox, 1, 1);
            this.VK_tableLayoutPanel.Controls.Add(this.VKToken_textBox, 1, 0);
            this.VK_tableLayoutPanel.Location = new System.Drawing.Point(6, 106);
            this.VK_tableLayoutPanel.Name = "VK_tableLayoutPanel";
            this.VK_tableLayoutPanel.RowCount = 2;
            this.VK_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.VK_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.VK_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VK_tableLayoutPanel.Size = new System.Drawing.Size(364, 54);
            this.VK_tableLayoutPanel.TabIndex = 6;
            // 
            // VKToken_Label
            // 
            this.VKToken_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VKToken_Label.AutoSize = true;
            this.VKToken_Label.Location = new System.Drawing.Point(3, 7);
            this.VKToken_Label.Name = "VKToken_Label";
            this.VKToken_Label.Size = new System.Drawing.Size(55, 13);
            this.VKToken_Label.TabIndex = 2;
            this.VKToken_Label.Text = "VK Token";
            // 
            // UserID_Label
            // 
            this.UserID_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserID_Label.AutoSize = true;
            this.UserID_Label.Location = new System.Drawing.Point(3, 34);
            this.UserID_Label.Name = "UserID_Label";
            this.UserID_Label.Size = new System.Drawing.Size(43, 13);
            this.UserID_Label.TabIndex = 3;
            this.UserID_Label.Text = "User ID";
            // 
            // UserID_textBox
            // 
            this.UserID_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserID_textBox.Location = new System.Drawing.Point(94, 30);
            this.UserID_textBox.Name = "UserID_textBox";
            this.UserID_textBox.Size = new System.Drawing.Size(267, 20);
            this.UserID_textBox.TabIndex = 6;
            this.UserID_textBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // VKToken_textBox
            // 
            this.VKToken_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VKToken_textBox.Location = new System.Drawing.Point(94, 3);
            this.VKToken_textBox.Name = "VKToken_textBox";
            this.VKToken_textBox.Size = new System.Drawing.Size(267, 20);
            this.VKToken_textBox.TabIndex = 5;
            this.VKToken_textBox.TextChanged += new System.EventHandler(this.VKToken_textBox_TextChanged);
            // 
            // SongInfo_groupBox
            // 
            this.SongInfo_groupBox.Controls.Add(this.tableLayoutPanel1);
            this.SongInfo_groupBox.Controls.Add(this.AlbumLogo_pictureBox);
            this.SongInfo_groupBox.Location = new System.Drawing.Point(12, 118);
            this.SongInfo_groupBox.Name = "SongInfo_groupBox";
            this.SongInfo_groupBox.Size = new System.Drawing.Size(276, 248);
            this.SongInfo_groupBox.TabIndex = 5;
            this.SongInfo_groupBox.TabStop = false;
            this.SongInfo_groupBox.Text = "Информация о треке";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Title_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Artist_Label, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Title_Label
            // 
            this.Title_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.Title_Label.Location = new System.Drawing.Point(44, 3);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(77, 19);
            this.Title_Label.TabIndex = 3;
            this.Title_Label.Text = "Название";
            // 
            // Artist_Label
            // 
            this.Artist_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Artist_Label.AutoSize = true;
            this.Artist_Label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Artist_Label.Location = new System.Drawing.Point(44, 32);
            this.Artist_Label.Name = "Artist_Label";
            this.Artist_Label.Size = new System.Drawing.Size(77, 13);
            this.Artist_Label.TabIndex = 4;
            this.Artist_Label.Text = "Исполнитель";
            // 
            // AlbumLogo_pictureBox
            // 
            this.AlbumLogo_pictureBox.Location = new System.Drawing.Point(56, 19);
            this.AlbumLogo_pictureBox.Name = "AlbumLogo_pictureBox";
            this.AlbumLogo_pictureBox.Size = new System.Drawing.Size(165, 165);
            this.AlbumLogo_pictureBox.TabIndex = 0;
            this.AlbumLogo_pictureBox.TabStop = false;
            this.AlbumLogo_pictureBox.Click += new System.EventHandler(this.AlbumLogo_pictureBox_Click);
            // 
            // Settings_groupBox
            // 
            this.Settings_groupBox.Controls.Add(this.LoadSettings_checkBox);
            this.Settings_groupBox.Location = new System.Drawing.Point(294, 220);
            this.Settings_groupBox.Name = "Settings_groupBox";
            this.Settings_groupBox.Size = new System.Drawing.Size(376, 67);
            this.Settings_groupBox.TabIndex = 7;
            this.Settings_groupBox.TabStop = false;
            this.Settings_groupBox.Text = "Настройки";
            // 
            // LoadSettings_checkBox
            // 
            this.LoadSettings_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadSettings_checkBox.AutoSize = true;
            this.LoadSettings_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSettings_checkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadSettings_checkBox.Location = new System.Drawing.Point(9, 19);
            this.LoadSettings_checkBox.Name = "LoadSettings_checkBox";
            this.LoadSettings_checkBox.Size = new System.Drawing.Size(242, 17);
            this.LoadSettings_checkBox.TabIndex = 4;
            this.LoadSettings_checkBox.Text = "Загружать данные в TextBoxы при запуске";
            this.LoadSettings_checkBox.UseVisualStyleBackColor = true;
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(294, 343);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 8;
            this.Start_Button.Text = "button1";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // STVK_MainForm
            // 
            this.ClientSize = new System.Drawing.Size(682, 378);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Settings_groupBox);
            this.Controls.Add(this.SongInfo_groupBox);
            this.Controls.Add(this.Login_groupBox);
            this.Controls.Add(this.Control_groupBox);
            this.Name = "STVK_MainForm";
            this.Load += new System.EventHandler(this.STVK_MainForm_Load);
            this.Spotify_tableLayoutPanel.ResumeLayout(false);
            this.Spotify_tableLayoutPanel.PerformLayout();
            this.Control_groupBox.ResumeLayout(false);
            this.Login_groupBox.ResumeLayout(false);
            this.Login_flowLayoutPanel.ResumeLayout(false);
            this.Login_flowLayoutPanel.PerformLayout();
            this.VK_tableLayoutPanel.ResumeLayout(false);
            this.VK_tableLayoutPanel.PerformLayout();
            this.SongInfo_groupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumLogo_pictureBox)).EndInit();
            this.Settings_groupBox.ResumeLayout(false);
            this.Settings_groupBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#region var

		public string _Title;
		public string _Artist;
		public string CheckTitle;

		public string ClientID;
		public string SecretID;
		public string UserID;
		public string VKToken;
		public string SpotifyToken;

		public Bitmap _AlbumCover;

        #endregion

        private void LoginSave_Button_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
		}

		private void ClientID_textBox_TextChanged(object sender, EventArgs e)
		{
            Properties.Settings.Default.ClientID_data = ClientID_textBox.Text;
        }

		private void SecretID_textBox_TextChanged(object sender, EventArgs e)
		{
            Properties.Settings.Default.SecretID_data = SecretID_textBox.Text;
        }

		private void SpotifyToken_textBox_TextChanged(object sender, EventArgs e)
		{
            Properties.Settings.Default.SpotifyToken_data = SpotifyToken_textBox.Text;
        }

		private void VKToken_textBox_TextChanged(object sender, EventArgs e)
		{
            Properties.Settings.Default.VKToken_data = VKToken_textBox.Text;
        }

		private void UserID_textBox_TextChanged(object sender, EventArgs e)
		{
            Properties.Settings.Default.UserID_data = UserID_textBox.Text;
		}

		private void AlbumLogo_pictureBox_Click(object sender, EventArgs e)
		{

		}

		private void Login_Button_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(ClientID_textBox.Text) & String.IsNullOrEmpty(SecretID_textBox.Text) & String.IsNullOrEmpty(VKToken_textBox.Text))
			{
				MessageBox.Show("Есть незаполненные поля!");
			}
			else
			{
				SpotifyRequest.LoginSpotify();
				VKRequest.LoginVK();
				LoginStatus_Label.Text = "Вроде успешно!";
			}
		}

		private void LoginStatus_Label_Click(object sender, EventArgs e)
		{

		}

		private void CheckLogin_Button_Click(object sender, EventArgs e)
		{
            ClientID_textBox.Text = Properties.Settings.Default.ClientID_data;
            SecretID_textBox.Text = Properties.Settings.Default.SecretID_data;
            UserID_textBox.Text = Properties.Settings.Default.UserID_data;
            VKToken_textBox.Text = Properties.Settings.Default.VKToken_data;
            SpotifyToken_textBox.Text = Properties.Settings.Default.SpotifyToken_data;
		}

		private void STVK_MainForm_Load(object sender, EventArgs e)
		{

            #region tooltip

            ToolTip CheckButton_Tooltip = new ToolTip();

            CheckButton_Tooltip.AutoPopDelay = 5000;
            CheckButton_Tooltip.InitialDelay = 1000;
            CheckButton_Tooltip.ReshowDelay = 500;
            CheckButton_Tooltip.ShowAlways = true;
            CheckButton_Tooltip.SetToolTip(CheckLogin_Button, "Проверка введенных данных. Нажмите, чтобы увидеть текущие данные.");

            #endregion

            LoginStatus_checkBox.AutoCheck = false;
			LoginStatus_checkBox.ForeColor = Color.Gray;
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
