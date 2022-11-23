using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSeperation
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Initialize
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            #region "하위폴더 생성규칙"
            DataTable dtRule = new DataTable();
            dtRule.Columns.Add("RID", typeof(int));
            dtRule.Columns.Add("NAME", typeof(string));            
            dtRule.Rows.Add(1, "YYYY-MM-DD (ex.2022-01-01)");
            //dtRule.Rows.Add(2, "YYYY-MM-DD (ex.2022-01-01)");

            cbOutputDirRule.DataSource = dtRule;
            cbOutputDirRule.DisplayMember = "NAME";
            cbOutputDirRule.ValueMember = "RID";
            #endregion 

            btnOpenInputDir.Click += BtnOpenInputDir_Click;
            btnOpenOutputDir.Click += BtnOpenOutputDir_Click;
        }

        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //}
        #endregion

        #region GetMetaDat
        public static string GetMetaData(string filePath, string directoryName, string tagName)
        {
            IEnumerable<MetadataExtractor.Directory> directories = MetadataExtractor.ImageMetadataReader.ReadMetadata(filePath);
            MetadataExtractor.Directory directory = directories.Where(s => string.Equals(s.Name, directoryName)).FirstOrDefault();

            if (directory == null)
                return string.Empty;

            MetadataExtractor.Tag tag = directory.Tags.Where(s=> string.Equals(s.Name, tagName)).FirstOrDefault();

            return tag.Description;
        }
        #endregion GetMetaData

        #region GetDirectoryPath
        public string GetDirectoryPath(string strDefaultPath)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            if (!string.IsNullOrEmpty(strDefaultPath))
                folderDialog.SelectedPath = strDefaultPath;

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                return folderDialog.SelectedPath;
            }
            else
            {
                return String.Empty;
            }
        }
        #endregion

        #region UI Event
        private void BtnOpenInputDir_Click(object sender, EventArgs e)
        {
            txtInputDirPath.Text = GetDirectoryPath(txtInputDirPath.Text);
        }

        private void BtnOpenOutputDir_Click(object sender, EventArgs e)
        {
            txtOutputDirPath.Text = GetDirectoryPath(txtOutputDirPath.Text);
        }
        #endregion UI Event
    }
}
