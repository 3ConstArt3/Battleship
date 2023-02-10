namespace Battleship
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.MainKrptPlt = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.MainPnl = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PreparationBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BattleShipIntroLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainPnl)).BeginInit();
            this.MainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainKrptPlt
            // 
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Back.ColorAngle = 24F;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.ColorAngle = 24F;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.Rounding = 27;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Border.Width = 1;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.ColorAngle = 33F;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Back.ColorAngle = 24F;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.ColorAngle = 24F;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.Rounding = 27;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Border.Width = 1;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.ColorAngle = 33F;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StatePressed.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Back.ColorAngle = 24F;
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.ColorAngle = 24F;
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.Rounding = 18;
            this.MainKrptPlt.FormStyles.FormCommon.StateCommon.Border.Width = 1;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Back.ColorAngle = 66F;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.ColorAngle = 24F;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.Rounding = 18;
            this.MainKrptPlt.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAngle = 24F;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAngle = 33F;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 3;
            this.MainKrptPlt.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 1;
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.Padding = new System.Windows.Forms.Padding(24, 36, -1, -1);
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.ColorAngle = 24F;
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.MainKrptPlt.LabelStyles.LabelCommon.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.MainKrptPlt.PanelStyles.PanelCommon.StateCommon.Image = global::Battleship.Properties.Resources.BattleShipIntroIcon;
            this.MainKrptPlt.PanelStyles.PanelCommon.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            // 
            // MainPnl
            // 
            this.MainPnl.Controls.Add(this.PreparationBtn);
            this.MainPnl.Controls.Add(this.BattleShipIntroLbl);
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.Location = new System.Drawing.Point(0, 0);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Palette = this.MainKrptPlt;
            this.MainPnl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.MainPnl.Size = new System.Drawing.Size(823, 523);
            this.MainPnl.TabIndex = 0;
            // 
            // PreparationBtn
            // 
            this.PreparationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PreparationBtn.Location = new System.Drawing.Point(296, 336);
            this.PreparationBtn.Name = "PreparationBtn";
            this.PreparationBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.PreparationBtn.Size = new System.Drawing.Size(244, 84);
            this.PreparationBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.PreparationBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateCommon.Back.ColorAngle = 24F;
            this.PreparationBtn.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounding5;
            this.PreparationBtn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateCommon.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.PreparationBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.PreparationBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateCommon.Border.ColorAngle = 24F;
            this.PreparationBtn.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.PreparationBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PreparationBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateCommon.Border.Rounding = 27;
            this.PreparationBtn.StateCommon.Border.Width = 1;
            this.PreparationBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.PreparationBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PreparationBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PreparationBtn.StateCommon.Content.ShortText.ColorAngle = 24F;
            this.PreparationBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreparationBtn.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.PreparationBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateDisabled.Back.ColorAngle = 24F;
            this.PreparationBtn.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.PreparationBtn.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateDisabled.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.PreparationBtn.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.PreparationBtn.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateDisabled.Border.ColorAngle = 24F;
            this.PreparationBtn.StateDisabled.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.PreparationBtn.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PreparationBtn.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateDisabled.Border.Rounding = 27;
            this.PreparationBtn.StateDisabled.Border.Width = 1;
            this.PreparationBtn.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.PreparationBtn.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PreparationBtn.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PreparationBtn.StateDisabled.Content.ShortText.ColorAngle = 24F;
            this.PreparationBtn.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreparationBtn.StateDisabled.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.PreparationBtn.StateDisabled.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StateDisabled.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.PreparationBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.PreparationBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateNormal.Back.ColorAngle = 24F;
            this.PreparationBtn.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounding5;
            this.PreparationBtn.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateNormal.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.PreparationBtn.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.PreparationBtn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateNormal.Border.ColorAngle = 24F;
            this.PreparationBtn.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.PreparationBtn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PreparationBtn.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateNormal.Border.Image = global::Battleship.Properties.Resources.ReadyForBattleBtn;
            this.PreparationBtn.StateNormal.Border.Rounding = 27;
            this.PreparationBtn.StateNormal.Border.Width = 1;
            this.PreparationBtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.PreparationBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PreparationBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PreparationBtn.StateNormal.Content.ShortText.ColorAngle = 24F;
            this.PreparationBtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreparationBtn.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.PreparationBtn.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.PreparationBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StatePressed.Back.ColorAngle = 24F;
            this.PreparationBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounding5;
            this.PreparationBtn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StatePressed.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.PreparationBtn.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.PreparationBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StatePressed.Border.ColorAngle = 24F;
            this.PreparationBtn.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.PreparationBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PreparationBtn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StatePressed.Border.Rounding = 27;
            this.PreparationBtn.StatePressed.Border.Width = 1;
            this.PreparationBtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.PreparationBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PreparationBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PreparationBtn.StatePressed.Content.ShortText.ColorAngle = 24F;
            this.PreparationBtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreparationBtn.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.PreparationBtn.StatePressed.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.PreparationBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateTracking.Back.ColorAngle = 24F;
            this.PreparationBtn.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounding5;
            this.PreparationBtn.StateTracking.Back.Image = global::Battleship.Properties.Resources.Sailorhat;
            this.PreparationBtn.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.PreparationBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
            this.PreparationBtn.StateTracking.Border.ColorAngle = 24F;
            this.PreparationBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PreparationBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PreparationBtn.StateTracking.Border.Rounding = 27;
            this.PreparationBtn.StateTracking.Border.Width = 1;
            this.PreparationBtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.PreparationBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.PreparationBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PreparationBtn.StateTracking.Content.ShortText.ColorAngle = 24F;
            this.PreparationBtn.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreparationBtn.StateTracking.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.PreparationBtn.StateTracking.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.PreparationBtn.TabIndex = 29;
            this.PreparationBtn.Values.Text = "Let\'s Battle!";
            this.PreparationBtn.Click += new System.EventHandler(this.PreparationBtn_Click);
            // 
            // BattleShipIntroLbl
            // 
            this.BattleShipIntroLbl.AutoSize = false;
            this.BattleShipIntroLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BattleShipIntroLbl.Location = new System.Drawing.Point(0, 0);
            this.BattleShipIntroLbl.Name = "BattleShipIntroLbl";
            this.BattleShipIntroLbl.Palette = this.MainKrptPlt;
            this.BattleShipIntroLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BattleShipIntroLbl.Size = new System.Drawing.Size(823, 229);
            this.BattleShipIntroLbl.TabIndex = 4;
            this.BattleShipIntroLbl.Values.Text = "BattleShip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(823, 523);
            this.Controls.Add(this.MainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Palette = this.MainKrptPlt;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.MainPnl)).EndInit();
            this.MainPnl.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonPalette MainKrptPlt;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel MainPnl;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel BattleShipIntroLbl;
		private ComponentFactory.Krypton.Toolkit.KryptonButton PreparationBtn;
	}
}