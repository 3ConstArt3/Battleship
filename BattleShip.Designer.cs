namespace Battleship
{
	partial class BattleShipForm
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
			this.KrptMainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.IntroLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.MainPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.PreparationBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// KrptMainPalette
			// 
			this.KrptMainPalette.ButtonSpecs.FormClose.Image = global::Battleship.Properties.Resources.closeBtn;
			this.KrptMainPalette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Battleship.Properties.Resources.closeBtn;
			this.KrptMainPalette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Battleship.Properties.Resources.closeBtn;
			this.KrptMainPalette.ButtonSpecs.FormMax.Image = global::Battleship.Properties.Resources.maximizeBtn;
			this.KrptMainPalette.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::Battleship.Properties.Resources.maximizeBtn;
			this.KrptMainPalette.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Battleship.Properties.Resources.maximizeBtn;
			this.KrptMainPalette.ButtonSpecs.FormMin.Image = global::Battleship.Properties.Resources.minimize_Btn;
			this.KrptMainPalette.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::Battleship.Properties.Resources.minimize_Btn;
			this.KrptMainPalette.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Battleship.Properties.Resources.minimize_Btn;
			this.KrptMainPalette.ButtonSpecs.FormRestore.Image = global::Battleship.Properties.Resources.maximizeBtn;
			this.KrptMainPalette.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::Battleship.Properties.Resources.maximizeBtn;
			this.KrptMainPalette.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::Battleship.Properties.Resources.maximizeBtn;
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateCommon.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateCommon.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateNormal.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
			this.KrptMainPalette.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.KrptMainPalette.FormStyles.FormCommon.StateActive.Back.ColorAngle = 66F;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Back.ColorAngle = 66F;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.ColorAngle = 0F;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch90;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 21;
			this.KrptMainPalette.FormStyles.FormMain.StateCommon.Border.Width = 0;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAngle = 66F;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAngle = 66F;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 18;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 15;
			this.KrptMainPalette.HeaderStyles.HeaderCommon.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(3);
			// 
			// IntroLbl
			// 
			this.IntroLbl.AutoSize = false;
			this.IntroLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.IntroLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
			this.IntroLbl.Location = new System.Drawing.Point(0, 0);
			this.IntroLbl.Name = "IntroLbl";
			this.IntroLbl.Size = new System.Drawing.Size(856, 225);
			this.IntroLbl.StateCommon.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.IntroLbl.StateCommon.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.IntroLbl.StateCommon.LongText.ColorAngle = 66F;
			this.IntroLbl.StateCommon.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
			this.IntroLbl.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.IntroLbl.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
			this.IntroLbl.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
			this.IntroLbl.StateCommon.ShortText.ColorAngle = 0F;
			this.IntroLbl.StateCommon.ShortText.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.IntroLbl.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.SingleBitPerPixel;
			this.IntroLbl.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.IntroLbl.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.IntroLbl.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Word;
			this.IntroLbl.StateNormal.Padding = new System.Windows.Forms.Padding(48, 24, 15, 15);
			this.IntroLbl.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
			this.IntroLbl.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
			this.IntroLbl.TabIndex = 0;
			this.IntroLbl.Values.Text = "BattleShips";
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add(this.PreparationBtn);
			this.MainPanel.Controls.Add(this.IntroLbl);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.MainPanel.Size = new System.Drawing.Size(856, 554);
			this.MainPanel.StateNormal.Image = global::Battleship.Properties.Resources.BattleShipIntroIcon;
			this.MainPanel.StateNormal.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.MainPanel.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
			this.MainPanel.TabIndex = 1;
			// 
			// PreparationBtn
			// 
			this.PreparationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PreparationBtn.Location = new System.Drawing.Point(334, 315);
			this.PreparationBtn.Name = "PreparationBtn";
			this.PreparationBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.PreparationBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.PreparationBtn.Size = new System.Drawing.Size(218, 78);
			this.PreparationBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateCommon.Back.ColorAngle = 24F;
			this.PreparationBtn.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
			this.PreparationBtn.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StateCommon.Back.Image = global::Battleship.Properties.Resources.ReadyForBattleBtn;
			this.PreparationBtn.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
			this.PreparationBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateCommon.Border.ColorAngle = 45F;
			this.PreparationBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.PreparationBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StateCommon.Border.Rounding = 30;
			this.PreparationBtn.StateCommon.Border.Width = 3;
			this.PreparationBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 33, -1);
			this.PreparationBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.PreparationBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.PreparationBtn.StateCommon.Content.ShortText.ColorAngle = 45F;
			this.PreparationBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreparationBtn.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.PreparationBtn.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.PreparationBtn.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StateDisabled.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateDisabled.Back.ColorAngle = 30F;
			this.PreparationBtn.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
			this.PreparationBtn.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StateDisabled.Back.Image = global::Battleship.Properties.Resources.ReadyForBattleBtn;
			this.PreparationBtn.StateDisabled.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
			this.PreparationBtn.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateDisabled.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateDisabled.Border.ColorAngle = 45F;
			this.PreparationBtn.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.PreparationBtn.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StateDisabled.Border.Rounding = 30;
			this.PreparationBtn.StateDisabled.Border.Width = 3;
			this.PreparationBtn.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 33, -1);
			this.PreparationBtn.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.PreparationBtn.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.PreparationBtn.StateDisabled.Content.ShortText.ColorAngle = 45F;
			this.PreparationBtn.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreparationBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateNormal.Back.ColorAngle = 24F;
			this.PreparationBtn.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
			this.PreparationBtn.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StateNormal.Back.Image = global::Battleship.Properties.Resources.ReadyForBattleBtn;
			this.PreparationBtn.StateNormal.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
			this.PreparationBtn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StateNormal.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StateNormal.Border.ColorAngle = 45F;
			this.PreparationBtn.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
			this.PreparationBtn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.PreparationBtn.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StateNormal.Border.Rounding = 30;
			this.PreparationBtn.StateNormal.Border.Width = 3;
			this.PreparationBtn.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 33, -1);
			this.PreparationBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.PreparationBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.PreparationBtn.StateNormal.Content.ShortText.ColorAngle = 45F;
			this.PreparationBtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreparationBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StatePressed.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StatePressed.Back.ColorAngle = 24F;
			this.PreparationBtn.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassNormalFull;
			this.PreparationBtn.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StatePressed.Back.Image = global::Battleship.Properties.Resources.ReadyForBattleBtn;
			this.PreparationBtn.StatePressed.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
			this.PreparationBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(97)))), ((int)(((byte)(89)))));
			this.PreparationBtn.StatePressed.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.PreparationBtn.StatePressed.Border.ColorAngle = 24F;
			this.PreparationBtn.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
			this.PreparationBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.PreparationBtn.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.PreparationBtn.StatePressed.Border.Image = global::Battleship.Properties.Resources.ReadyForBattleBtn;
			this.PreparationBtn.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopRight;
			this.PreparationBtn.StatePressed.Border.Rounding = 30;
			this.PreparationBtn.StatePressed.Border.Width = 3;
			this.PreparationBtn.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 33, -1);
			this.PreparationBtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.PreparationBtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.PreparationBtn.StatePressed.Content.ShortText.ColorAngle = 30F;
			this.PreparationBtn.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreparationBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.PreparationBtn.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 33, -1);
			this.PreparationBtn.TabIndex = 1;
			this.PreparationBtn.Values.Text = "Let\'s Battle";
			this.PreparationBtn.Click += new System.EventHandler(this.PreparationBtn_Click);
			// 
			// BattleShipForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(196)))), ((int)(((byte)(185)))));
			this.ClientSize = new System.Drawing.Size(856, 554);
			this.Controls.Add(this.MainPanel);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.MinimumSize = new System.Drawing.Size(810, 540);
			this.Name = "BattleShipForm";
			this.Palette = this.KrptMainPalette;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
			this.MainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonPalette KrptMainPalette;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel IntroLbl;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel MainPanel;
		private ComponentFactory.Krypton.Toolkit.KryptonButton PreparationBtn;
	}
}