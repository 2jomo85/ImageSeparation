namespace ImageSeperation
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblInputDir = new MetroFramework.Controls.MetroLabel();
            this.txtInputDirPath = new MetroFramework.Controls.MetroTextBox();
            this.btnOpenInputDir = new MetroFramework.Controls.MetroButton();
            this.btnOpenOutputDir = new MetroFramework.Controls.MetroButton();
            this.txtOutputDirPath = new MetroFramework.Controls.MetroTextBox();
            this.lblOutputDir = new MetroFramework.Controls.MetroLabel();
            this.lblOutputDirRule = new MetroFramework.Controls.MetroLabel();
            this.cbOutputDirRule = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputDir
            // 
            this.lblInputDir.AutoSize = true;
            this.lblInputDir.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblInputDir.Location = new System.Drawing.Point(23, 60);
            this.lblInputDir.Name = "lblInputDir";
            this.lblInputDir.Size = new System.Drawing.Size(259, 19);
            this.lblInputDir.TabIndex = 0;
            this.lblInputDir.Text = "1. 입력 폴더 선택( 하위 폴더 전체 탐색 )";
            // 
            // txtInputDirPath
            // 
            // 
            // 
            // 
            this.txtInputDirPath.CustomButton.Image = null;
            this.txtInputDirPath.CustomButton.Location = new System.Drawing.Point(578, 1);
            this.txtInputDirPath.CustomButton.Name = "";
            this.txtInputDirPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInputDirPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInputDirPath.CustomButton.TabIndex = 1;
            this.txtInputDirPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInputDirPath.CustomButton.UseSelectable = true;
            this.txtInputDirPath.CustomButton.Visible = false;
            this.txtInputDirPath.Lines = new string[0];
            this.txtInputDirPath.Location = new System.Drawing.Point(23, 82);
            this.txtInputDirPath.MaxLength = 32767;
            this.txtInputDirPath.Name = "txtInputDirPath";
            this.txtInputDirPath.PasswordChar = '\0';
            this.txtInputDirPath.ReadOnly = true;
            this.txtInputDirPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInputDirPath.SelectedText = "";
            this.txtInputDirPath.SelectionLength = 0;
            this.txtInputDirPath.SelectionStart = 0;
            this.txtInputDirPath.ShortcutsEnabled = true;
            this.txtInputDirPath.Size = new System.Drawing.Size(600, 23);
            this.txtInputDirPath.TabIndex = 1;
            this.txtInputDirPath.UseSelectable = true;
            this.txtInputDirPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInputDirPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOpenInputDir
            // 
            this.btnOpenInputDir.Location = new System.Drawing.Point(629, 82);
            this.btnOpenInputDir.Name = "btnOpenInputDir";
            this.btnOpenInputDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenInputDir.TabIndex = 2;
            this.btnOpenInputDir.Text = "열기";
            this.btnOpenInputDir.UseSelectable = true;
            // 
            // btnOpenOutputDir
            // 
            this.btnOpenOutputDir.Location = new System.Drawing.Point(629, 130);
            this.btnOpenOutputDir.Name = "btnOpenOutputDir";
            this.btnOpenOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOutputDir.TabIndex = 5;
            this.btnOpenOutputDir.Text = "열기";
            this.btnOpenOutputDir.UseSelectable = true;
            // 
            // txtOutputDirPath
            // 
            // 
            // 
            // 
            this.txtOutputDirPath.CustomButton.Image = null;
            this.txtOutputDirPath.CustomButton.Location = new System.Drawing.Point(578, 1);
            this.txtOutputDirPath.CustomButton.Name = "";
            this.txtOutputDirPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOutputDirPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOutputDirPath.CustomButton.TabIndex = 1;
            this.txtOutputDirPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOutputDirPath.CustomButton.UseSelectable = true;
            this.txtOutputDirPath.CustomButton.Visible = false;
            this.txtOutputDirPath.Lines = new string[0];
            this.txtOutputDirPath.Location = new System.Drawing.Point(23, 130);
            this.txtOutputDirPath.MaxLength = 32767;
            this.txtOutputDirPath.Name = "txtOutputDirPath";
            this.txtOutputDirPath.PasswordChar = '\0';
            this.txtOutputDirPath.ReadOnly = true;
            this.txtOutputDirPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOutputDirPath.SelectedText = "";
            this.txtOutputDirPath.SelectionLength = 0;
            this.txtOutputDirPath.SelectionStart = 0;
            this.txtOutputDirPath.ShortcutsEnabled = true;
            this.txtOutputDirPath.Size = new System.Drawing.Size(600, 23);
            this.txtOutputDirPath.TabIndex = 4;
            this.txtOutputDirPath.UseSelectable = true;
            this.txtOutputDirPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOutputDirPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblOutputDir
            // 
            this.lblOutputDir.AutoSize = true;
            this.lblOutputDir.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOutputDir.Location = new System.Drawing.Point(23, 108);
            this.lblOutputDir.Name = "lblOutputDir";
            this.lblOutputDir.Size = new System.Drawing.Size(117, 19);
            this.lblOutputDir.TabIndex = 3;
            this.lblOutputDir.Text = "2. 출력 폴더 선택";
            // 
            // lblOutputDirRule
            // 
            this.lblOutputDirRule.AutoSize = true;
            this.lblOutputDirRule.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOutputDirRule.Location = new System.Drawing.Point(23, 156);
            this.lblOutputDirRule.Name = "lblOutputDirRule";
            this.lblOutputDirRule.Size = new System.Drawing.Size(505, 19);
            this.lblOutputDirRule.TabIndex = 6;
            this.lblOutputDirRule.Text = "3. 하위 폴더 생성 규칙( 파일의 정보를 기반으로 자동으로 복사/이동 폴더 생성 )";
            // 
            // cbOutputDirRule
            // 
            this.cbOutputDirRule.FormattingEnabled = true;
            this.cbOutputDirRule.ItemHeight = 23;
            this.cbOutputDirRule.Location = new System.Drawing.Point(23, 178);
            this.cbOutputDirRule.Name = "cbOutputDirRule";
            this.cbOutputDirRule.Size = new System.Drawing.Size(681, 29);
            this.cbOutputDirRule.TabIndex = 7;
            this.cbOutputDirRule.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOutputDirRule);
            this.Controls.Add(this.lblOutputDirRule);
            this.Controls.Add(this.btnOpenOutputDir);
            this.Controls.Add(this.txtOutputDirPath);
            this.Controls.Add(this.lblOutputDir);
            this.Controls.Add(this.btnOpenInputDir);
            this.Controls.Add(this.txtInputDirPath);
            this.Controls.Add(this.lblInputDir);
            this.Name = "frmMain";
            this.Text = "사진 분류";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInputDir;
        private MetroFramework.Controls.MetroTextBox txtInputDirPath;
        private MetroFramework.Controls.MetroButton btnOpenInputDir;
        private MetroFramework.Controls.MetroButton btnOpenOutputDir;
        private MetroFramework.Controls.MetroTextBox txtOutputDirPath;
        private MetroFramework.Controls.MetroLabel lblOutputDir;
        private MetroFramework.Controls.MetroLabel lblOutputDirRule;
        private MetroFramework.Controls.MetroComboBox cbOutputDirRule;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

