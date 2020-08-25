namespace Ndpprojje
{
    partial class FormHayvanCiftligi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHayvanCiftligi));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUrunDeposu = new System.Windows.Forms.Label();
            this.lblTavYum = new System.Windows.Forms.Label();
            this.lblInekSutu = new System.Windows.Forms.Label();
            this.lblTavYumDegeri = new System.Windows.Forms.Label();
            this.lblInekSutuDegeri = new System.Windows.Forms.Label();
            this.lblOrdYum = new System.Windows.Forms.Label();
            this.lblKeciSutu = new System.Windows.Forms.Label();
            this.lblOrdYumDegeri = new System.Windows.Forms.Label();
            this.lblKeciSutuDegeri = new System.Windows.Forms.Label();
            this.labelSaniye = new System.Windows.Forms.Label();
            this.tableLayoutPanelUstGovde = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKasa = new System.Windows.Forms.Label();
            this.lblTl = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonKeciSutuSat = new System.Windows.Forms.Button();
            this.buttonInekSutuSat = new System.Windows.Forms.Button();
            this.buttonOrdYumSat = new System.Windows.Forms.Button();
            this.labelGidaFabrikasi = new System.Windows.Forms.Label();
            this.buttonTavYumSat = new System.Windows.Forms.Button();
            this.tableLayoutPanelAltGovde = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxKeci = new System.Windows.Forms.PictureBox();
            this.lblKeciLive = new System.Windows.Forms.Label();
            this.buttonYemVerKeci = new System.Windows.Forms.Button();
            this.progressBarKeci = new System.Windows.Forms.ProgressBar();
            this.labelAhir = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxInek = new System.Windows.Forms.PictureBox();
            this.lblInekLive = new System.Windows.Forms.Label();
            this.buttonYemVerInek = new System.Windows.Forms.Button();
            this.progressBarInek = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxOrdek = new System.Windows.Forms.PictureBox();
            this.lblOrdekLive = new System.Windows.Forms.Label();
            this.buttonYemVerOrdek = new System.Windows.Forms.Button();
            this.progressBarOrdek = new System.Windows.Forms.ProgressBar();
            this.labelKumes = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxTavuk = new System.Windows.Forms.PictureBox();
            this.lblTavukLive = new System.Windows.Forms.Label();
            this.buttonYemVerTavuk = new System.Windows.Forms.Button();
            this.progressBarTavuk = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelUstGovde.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanelAltGovde.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeci)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInek)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrdek)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTavuk)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelUrunDeposu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTavYum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInekSutu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTavYumDegeri, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInekSutuDegeri, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOrdYum, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblKeciSutu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblOrdYumDegeri, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblKeciSutuDegeri, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanelUstGovde.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUrunDeposu
            // 
            this.labelUrunDeposu.AutoSize = true;
            this.labelUrunDeposu.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel1.SetColumnSpan(this.labelUrunDeposu, 2);
            this.labelUrunDeposu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUrunDeposu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunDeposu.ForeColor = System.Drawing.Color.White;
            this.labelUrunDeposu.Location = new System.Drawing.Point(6, 6);
            this.labelUrunDeposu.Margin = new System.Windows.Forms.Padding(3);
            this.labelUrunDeposu.Name = "labelUrunDeposu";
            this.labelUrunDeposu.Size = new System.Drawing.Size(299, 24);
            this.labelUrunDeposu.TabIndex = 0;
            this.labelUrunDeposu.Text = "ÜRÜN DEPOSU";
            this.labelUrunDeposu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavYum
            // 
            this.lblTavYum.AutoSize = true;
            this.lblTavYum.BackColor = System.Drawing.Color.Plum;
            this.lblTavYum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTavYum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTavYum.Location = new System.Drawing.Point(6, 36);
            this.lblTavYum.Margin = new System.Windows.Forms.Padding(3);
            this.lblTavYum.Name = "lblTavYum";
            this.lblTavYum.Size = new System.Drawing.Size(146, 24);
            this.lblTavYum.TabIndex = 1;
            this.lblTavYum.Text = "TAVUK YUMURTASI";
            this.lblTavYum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekSutu
            // 
            this.lblInekSutu.AutoSize = true;
            this.lblInekSutu.BackColor = System.Drawing.Color.Plum;
            this.lblInekSutu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInekSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInekSutu.Location = new System.Drawing.Point(158, 36);
            this.lblInekSutu.Margin = new System.Windows.Forms.Padding(3);
            this.lblInekSutu.Name = "lblInekSutu";
            this.lblInekSutu.Size = new System.Drawing.Size(147, 24);
            this.lblInekSutu.TabIndex = 2;
            this.lblInekSutu.Text = "İNEK SÜTÜ";
            this.lblInekSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavYumDegeri
            // 
            this.lblTavYumDegeri.AutoSize = true;
            this.lblTavYumDegeri.BackColor = System.Drawing.Color.Thistle;
            this.lblTavYumDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTavYumDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTavYumDegeri.ForeColor = System.Drawing.Color.Coral;
            this.lblTavYumDegeri.Location = new System.Drawing.Point(6, 66);
            this.lblTavYumDegeri.Margin = new System.Windows.Forms.Padding(3);
            this.lblTavYumDegeri.Name = "lblTavYumDegeri";
            this.lblTavYumDegeri.Size = new System.Drawing.Size(146, 24);
            this.lblTavYumDegeri.TabIndex = 3;
            this.lblTavYumDegeri.Text = "0 ADET";
            this.lblTavYumDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekSutuDegeri
            // 
            this.lblInekSutuDegeri.AutoSize = true;
            this.lblInekSutuDegeri.BackColor = System.Drawing.Color.Thistle;
            this.lblInekSutuDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInekSutuDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekSutuDegeri.ForeColor = System.Drawing.Color.Coral;
            this.lblInekSutuDegeri.Location = new System.Drawing.Point(158, 66);
            this.lblInekSutuDegeri.Margin = new System.Windows.Forms.Padding(3);
            this.lblInekSutuDegeri.Name = "lblInekSutuDegeri";
            this.lblInekSutuDegeri.Size = new System.Drawing.Size(147, 24);
            this.lblInekSutuDegeri.TabIndex = 4;
            this.lblInekSutuDegeri.Text = "0 KG";
            this.lblInekSutuDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdYum
            // 
            this.lblOrdYum.AutoSize = true;
            this.lblOrdYum.BackColor = System.Drawing.Color.Plum;
            this.lblOrdYum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdYum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOrdYum.Location = new System.Drawing.Point(6, 96);
            this.lblOrdYum.Margin = new System.Windows.Forms.Padding(3);
            this.lblOrdYum.Name = "lblOrdYum";
            this.lblOrdYum.Size = new System.Drawing.Size(146, 24);
            this.lblOrdYum.TabIndex = 5;
            this.lblOrdYum.Text = "ÖRDEK YUMURTASI";
            this.lblOrdYum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeciSutu
            // 
            this.lblKeciSutu.AutoSize = true;
            this.lblKeciSutu.BackColor = System.Drawing.Color.Plum;
            this.lblKeciSutu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKeciSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKeciSutu.Location = new System.Drawing.Point(158, 96);
            this.lblKeciSutu.Margin = new System.Windows.Forms.Padding(3);
            this.lblKeciSutu.Name = "lblKeciSutu";
            this.lblKeciSutu.Size = new System.Drawing.Size(147, 24);
            this.lblKeciSutu.TabIndex = 6;
            this.lblKeciSutu.Text = "KEÇİ SÜTÜ";
            this.lblKeciSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdYumDegeri
            // 
            this.lblOrdYumDegeri.AutoSize = true;
            this.lblOrdYumDegeri.BackColor = System.Drawing.Color.Thistle;
            this.lblOrdYumDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdYumDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOrdYumDegeri.ForeColor = System.Drawing.Color.Coral;
            this.lblOrdYumDegeri.Location = new System.Drawing.Point(6, 126);
            this.lblOrdYumDegeri.Margin = new System.Windows.Forms.Padding(3);
            this.lblOrdYumDegeri.Name = "lblOrdYumDegeri";
            this.lblOrdYumDegeri.Size = new System.Drawing.Size(146, 24);
            this.lblOrdYumDegeri.TabIndex = 7;
            this.lblOrdYumDegeri.Text = "0 ADET";
            this.lblOrdYumDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeciSutuDegeri
            // 
            this.lblKeciSutuDegeri.AutoSize = true;
            this.lblKeciSutuDegeri.BackColor = System.Drawing.Color.Thistle;
            this.lblKeciSutuDegeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKeciSutuDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKeciSutuDegeri.ForeColor = System.Drawing.Color.Coral;
            this.lblKeciSutuDegeri.Location = new System.Drawing.Point(158, 126);
            this.lblKeciSutuDegeri.Margin = new System.Windows.Forms.Padding(3);
            this.lblKeciSutuDegeri.Name = "lblKeciSutuDegeri";
            this.lblKeciSutuDegeri.Size = new System.Drawing.Size(147, 24);
            this.lblKeciSutuDegeri.TabIndex = 8;
            this.lblKeciSutuDegeri.Text = "0 KG";
            this.lblKeciSutuDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSaniye
            // 
            this.labelSaniye.AutoSize = true;
            this.labelSaniye.BackColor = System.Drawing.Color.Thistle;
            this.labelSaniye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelSaniye.ForeColor = System.Drawing.Color.Coral;
            this.labelSaniye.Location = new System.Drawing.Point(6, 40);
            this.labelSaniye.Margin = new System.Windows.Forms.Padding(3);
            this.labelSaniye.Name = "labelSaniye";
            this.labelSaniye.Size = new System.Drawing.Size(109, 29);
            this.labelSaniye.TabIndex = 3;
            this.labelSaniye.Text = "0 SN";
            this.labelSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelUstGovde
            // 
            this.tableLayoutPanelUstGovde.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanelUstGovde.ColumnCount = 3;
            this.tableLayoutPanelUstGovde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUstGovde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelUstGovde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUstGovde.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tableLayoutPanelUstGovde.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanelUstGovde.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanelUstGovde.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelUstGovde.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelUstGovde.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUstGovde.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelUstGovde.Name = "tableLayoutPanelUstGovde";
            this.tableLayoutPanelUstGovde.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelUstGovde.RowCount = 2;
            this.tableLayoutPanelUstGovde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUstGovde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUstGovde.Size = new System.Drawing.Size(638, 166);
            this.tableLayoutPanelUstGovde.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblKasa, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTl, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(512, 86);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(121, 75);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.BackColor = System.Drawing.Color.Coral;
            this.lblKasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKasa.ForeColor = System.Drawing.Color.White;
            this.lblKasa.Location = new System.Drawing.Point(6, 6);
            this.lblKasa.Margin = new System.Windows.Forms.Padding(3);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(109, 28);
            this.lblKasa.TabIndex = 4;
            this.lblKasa.Text = "KASA";
            this.lblKasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTl
            // 
            this.lblTl.AutoSize = true;
            this.lblTl.BackColor = System.Drawing.Color.Thistle;
            this.lblTl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTl.ForeColor = System.Drawing.Color.Coral;
            this.lblTl.Location = new System.Drawing.Point(6, 40);
            this.lblTl.Margin = new System.Windows.Forms.Padding(3);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(109, 29);
            this.lblTl.TabIndex = 3;
            this.lblTl.Text = "0 TL";
            this.lblTl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblGecenSure, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelSaniye, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(512, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(121, 75);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.AutoSize = true;
            this.lblGecenSure.BackColor = System.Drawing.Color.Coral;
            this.lblGecenSure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGecenSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGecenSure.ForeColor = System.Drawing.Color.White;
            this.lblGecenSure.Location = new System.Drawing.Point(6, 6);
            this.lblGecenSure.Margin = new System.Windows.Forms.Padding(3);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(109, 28);
            this.lblGecenSure.TabIndex = 4;
            this.lblGecenSure.Text = "GEÇEN SÜRE";
            this.lblGecenSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.buttonKeciSutuSat, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.buttonInekSutuSat, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.buttonOrdYumSat, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelGidaFabrikasi, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonTavYumSat, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.Red;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(322, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanelUstGovde.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(184, 156);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // buttonKeciSutuSat
            // 
            this.buttonKeciSutuSat.BackColor = System.Drawing.Color.Thistle;
            this.buttonKeciSutuSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKeciSutuSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKeciSutuSat.Location = new System.Drawing.Point(6, 126);
            this.buttonKeciSutuSat.Name = "buttonKeciSutuSat";
            this.buttonKeciSutuSat.Size = new System.Drawing.Size(172, 24);
            this.buttonKeciSutuSat.TabIndex = 4;
            this.buttonKeciSutuSat.Text = "KEÇİ SÜTÜ SAT";
            this.buttonKeciSutuSat.UseVisualStyleBackColor = false;
            this.buttonKeciSutuSat.Click += new System.EventHandler(this.buttonKeciSutuSat_Click);
            // 
            // buttonInekSutuSat
            // 
            this.buttonInekSutuSat.BackColor = System.Drawing.Color.Thistle;
            this.buttonInekSutuSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInekSutuSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonInekSutuSat.Location = new System.Drawing.Point(6, 96);
            this.buttonInekSutuSat.Name = "buttonInekSutuSat";
            this.buttonInekSutuSat.Size = new System.Drawing.Size(172, 24);
            this.buttonInekSutuSat.TabIndex = 3;
            this.buttonInekSutuSat.Text = "İNEK SÜTÜ SAT";
            this.buttonInekSutuSat.UseVisualStyleBackColor = false;
            this.buttonInekSutuSat.Click += new System.EventHandler(this.buttonInekSutuSat_Click);
            // 
            // buttonOrdYumSat
            // 
            this.buttonOrdYumSat.BackColor = System.Drawing.Color.Thistle;
            this.buttonOrdYumSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrdYumSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrdYumSat.Location = new System.Drawing.Point(6, 66);
            this.buttonOrdYumSat.Name = "buttonOrdYumSat";
            this.buttonOrdYumSat.Size = new System.Drawing.Size(172, 24);
            this.buttonOrdYumSat.TabIndex = 2;
            this.buttonOrdYumSat.Text = "ÖRDEK YUMURTASI SAT";
            this.buttonOrdYumSat.UseVisualStyleBackColor = false;
            this.buttonOrdYumSat.Click += new System.EventHandler(this.buttonOrdYumSat_Click);
            // 
            // labelGidaFabrikasi
            // 
            this.labelGidaFabrikasi.AutoSize = true;
            this.labelGidaFabrikasi.BackColor = System.Drawing.Color.Coral;
            this.labelGidaFabrikasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGidaFabrikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelGidaFabrikasi.ForeColor = System.Drawing.Color.White;
            this.labelGidaFabrikasi.Location = new System.Drawing.Point(6, 6);
            this.labelGidaFabrikasi.Margin = new System.Windows.Forms.Padding(3);
            this.labelGidaFabrikasi.Name = "labelGidaFabrikasi";
            this.labelGidaFabrikasi.Size = new System.Drawing.Size(172, 24);
            this.labelGidaFabrikasi.TabIndex = 0;
            this.labelGidaFabrikasi.Text = "GIDA FABRİKASI";
            this.labelGidaFabrikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTavYumSat
            // 
            this.buttonTavYumSat.BackColor = System.Drawing.Color.Thistle;
            this.buttonTavYumSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTavYumSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTavYumSat.Location = new System.Drawing.Point(6, 36);
            this.buttonTavYumSat.Name = "buttonTavYumSat";
            this.buttonTavYumSat.Size = new System.Drawing.Size(172, 24);
            this.buttonTavYumSat.TabIndex = 1;
            this.buttonTavYumSat.Text = "TAVUK YUMURTASI SAT";
            this.buttonTavYumSat.UseVisualStyleBackColor = false;
            this.buttonTavYumSat.Click += new System.EventHandler(this.buttonTavYumSat_Click);
            // 
            // tableLayoutPanelAltGovde
            // 
            this.tableLayoutPanelAltGovde.BackColor = System.Drawing.Color.Tan;
            this.tableLayoutPanelAltGovde.ColumnCount = 2;
            this.tableLayoutPanelAltGovde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAltGovde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAltGovde.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanelAltGovde.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanelAltGovde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelAltGovde.Location = new System.Drawing.Point(0, 166);
            this.tableLayoutPanelAltGovde.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelAltGovde.Name = "tableLayoutPanelAltGovde";
            this.tableLayoutPanelAltGovde.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelAltGovde.RowCount = 1;
            this.tableLayoutPanelAltGovde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAltGovde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanelAltGovde.Size = new System.Drawing.Size(638, 245);
            this.tableLayoutPanelAltGovde.TabIndex = 5;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.labelAhir, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(322, 5);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(311, 235);
            this.tableLayoutPanel10.TabIndex = 7;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel11.Controls.Add(this.pictureBoxKeci, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblKeciLive, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.buttonYemVerKeci, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.progressBarKeci, 1, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(6, 131);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(299, 98);
            this.tableLayoutPanel11.TabIndex = 4;
            // 
            // pictureBoxKeci
            // 
            this.pictureBoxKeci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxKeci.Image = global::Ndpprojje.Properties.Resources.keci;
            this.pictureBoxKeci.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxKeci.Name = "pictureBoxKeci";
            this.tableLayoutPanel11.SetRowSpan(this.pictureBoxKeci, 3);
            this.pictureBoxKeci.Size = new System.Drawing.Size(98, 92);
            this.pictureBoxKeci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKeci.TabIndex = 0;
            this.pictureBoxKeci.TabStop = false;
            // 
            // lblKeciLive
            // 
            this.lblKeciLive.AutoSize = true;
            this.lblKeciLive.BackColor = System.Drawing.Color.Plum;
            this.lblKeciLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKeciLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKeciLive.ForeColor = System.Drawing.Color.Brown;
            this.lblKeciLive.Location = new System.Drawing.Point(107, 3);
            this.lblKeciLive.Margin = new System.Windows.Forms.Padding(3);
            this.lblKeciLive.Name = "lblKeciLive";
            this.lblKeciLive.Size = new System.Drawing.Size(189, 26);
            this.lblKeciLive.TabIndex = 1;
            this.lblKeciLive.Text = "CANLI";
            this.lblKeciLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYemVerKeci
            // 
            this.buttonYemVerKeci.BackColor = System.Drawing.Color.Thistle;
            this.buttonYemVerKeci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYemVerKeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYemVerKeci.ForeColor = System.Drawing.Color.Red;
            this.buttonYemVerKeci.Location = new System.Drawing.Point(107, 68);
            this.buttonYemVerKeci.Name = "buttonYemVerKeci";
            this.buttonYemVerKeci.Size = new System.Drawing.Size(189, 27);
            this.buttonYemVerKeci.TabIndex = 2;
            this.buttonYemVerKeci.Text = "YEM VER";
            this.buttonYemVerKeci.UseVisualStyleBackColor = false;
            this.buttonYemVerKeci.Click += new System.EventHandler(this.buttonYemVerKeci_Click);
            // 
            // progressBarKeci
            // 
            this.progressBarKeci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarKeci.ForeColor = System.Drawing.Color.Thistle;
            this.progressBarKeci.Location = new System.Drawing.Point(107, 35);
            this.progressBarKeci.Name = "progressBarKeci";
            this.progressBarKeci.Size = new System.Drawing.Size(189, 27);
            this.progressBarKeci.TabIndex = 3;
            // 
            // labelAhir
            // 
            this.labelAhir.AutoSize = true;
            this.labelAhir.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel10.SetColumnSpan(this.labelAhir, 2);
            this.labelAhir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAhir.ForeColor = System.Drawing.Color.White;
            this.labelAhir.Location = new System.Drawing.Point(6, 6);
            this.labelAhir.Margin = new System.Windows.Forms.Padding(3);
            this.labelAhir.Name = "labelAhir";
            this.labelAhir.Size = new System.Drawing.Size(299, 16);
            this.labelAhir.TabIndex = 1;
            this.labelAhir.Text = "AHIR";
            this.labelAhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel12.Controls.Add(this.pictureBoxInek, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lblInekLive, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.buttonYemVerInek, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.progressBarInek, 1, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(299, 97);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // pictureBoxInek
            // 
            this.pictureBoxInek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInek.Image = global::Ndpprojje.Properties.Resources.inek;
            this.pictureBoxInek.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxInek.Name = "pictureBoxInek";
            this.tableLayoutPanel12.SetRowSpan(this.pictureBoxInek, 3);
            this.pictureBoxInek.Size = new System.Drawing.Size(98, 91);
            this.pictureBoxInek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInek.TabIndex = 0;
            this.pictureBoxInek.TabStop = false;
            // 
            // lblInekLive
            // 
            this.lblInekLive.AutoSize = true;
            this.lblInekLive.BackColor = System.Drawing.Color.Plum;
            this.lblInekLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInekLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInekLive.ForeColor = System.Drawing.Color.Brown;
            this.lblInekLive.Location = new System.Drawing.Point(107, 3);
            this.lblInekLive.Margin = new System.Windows.Forms.Padding(3);
            this.lblInekLive.Name = "lblInekLive";
            this.lblInekLive.Size = new System.Drawing.Size(189, 26);
            this.lblInekLive.TabIndex = 1;
            this.lblInekLive.Text = "CANLI";
            this.lblInekLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYemVerInek
            // 
            this.buttonYemVerInek.BackColor = System.Drawing.Color.Thistle;
            this.buttonYemVerInek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYemVerInek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYemVerInek.ForeColor = System.Drawing.Color.Red;
            this.buttonYemVerInek.Location = new System.Drawing.Point(107, 67);
            this.buttonYemVerInek.Name = "buttonYemVerInek";
            this.buttonYemVerInek.Size = new System.Drawing.Size(189, 27);
            this.buttonYemVerInek.TabIndex = 2;
            this.buttonYemVerInek.Text = "YEM VER";
            this.buttonYemVerInek.UseVisualStyleBackColor = false;
            this.buttonYemVerInek.Click += new System.EventHandler(this.buttonYemVerInek_Click);
            // 
            // progressBarInek
            // 
            this.progressBarInek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarInek.ForeColor = System.Drawing.Color.Thistle;
            this.progressBarInek.Location = new System.Drawing.Point(107, 35);
            this.progressBarInek.Name = "progressBarInek";
            this.progressBarInek.Size = new System.Drawing.Size(189, 26);
            this.progressBarInek.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.labelKumes, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(311, 235);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxOrdek, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOrdekLive, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonYemVerOrdek, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.progressBarOrdek, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 98);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBoxOrdek
            // 
            this.pictureBoxOrdek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOrdek.Image = global::Ndpprojje.Properties.Resources.ordek;
            this.pictureBoxOrdek.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxOrdek.Name = "pictureBoxOrdek";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBoxOrdek, 3);
            this.pictureBoxOrdek.Size = new System.Drawing.Size(98, 92);
            this.pictureBoxOrdek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrdek.TabIndex = 0;
            this.pictureBoxOrdek.TabStop = false;
            // 
            // lblOrdekLive
            // 
            this.lblOrdekLive.AutoSize = true;
            this.lblOrdekLive.BackColor = System.Drawing.Color.Plum;
            this.lblOrdekLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdekLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOrdekLive.ForeColor = System.Drawing.Color.Brown;
            this.lblOrdekLive.Location = new System.Drawing.Point(107, 3);
            this.lblOrdekLive.Margin = new System.Windows.Forms.Padding(3);
            this.lblOrdekLive.Name = "lblOrdekLive";
            this.lblOrdekLive.Size = new System.Drawing.Size(189, 26);
            this.lblOrdekLive.TabIndex = 1;
            this.lblOrdekLive.Text = "CANLI";
            this.lblOrdekLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYemVerOrdek
            // 
            this.buttonYemVerOrdek.BackColor = System.Drawing.Color.Thistle;
            this.buttonYemVerOrdek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYemVerOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYemVerOrdek.ForeColor = System.Drawing.Color.Red;
            this.buttonYemVerOrdek.Location = new System.Drawing.Point(107, 67);
            this.buttonYemVerOrdek.Name = "buttonYemVerOrdek";
            this.buttonYemVerOrdek.Size = new System.Drawing.Size(189, 28);
            this.buttonYemVerOrdek.TabIndex = 2;
            this.buttonYemVerOrdek.Text = "YEM VER";
            this.buttonYemVerOrdek.UseVisualStyleBackColor = false;
            this.buttonYemVerOrdek.Click += new System.EventHandler(this.buttonYemVerOrdek_Click);
            // 
            // progressBarOrdek
            // 
            this.progressBarOrdek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarOrdek.ForeColor = System.Drawing.Color.Thistle;
            this.progressBarOrdek.Location = new System.Drawing.Point(107, 35);
            this.progressBarOrdek.Name = "progressBarOrdek";
            this.progressBarOrdek.Size = new System.Drawing.Size(189, 26);
            this.progressBarOrdek.TabIndex = 3;
            // 
            // labelKumes
            // 
            this.labelKumes.AutoSize = true;
            this.labelKumes.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel8.SetColumnSpan(this.labelKumes, 2);
            this.labelKumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKumes.ForeColor = System.Drawing.Color.White;
            this.labelKumes.Location = new System.Drawing.Point(6, 6);
            this.labelKumes.Margin = new System.Windows.Forms.Padding(3);
            this.labelKumes.Name = "labelKumes";
            this.labelKumes.Size = new System.Drawing.Size(299, 16);
            this.labelKumes.TabIndex = 1;
            this.labelKumes.Text = "KÜMES";
            this.labelKumes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel9.Controls.Add(this.pictureBoxTavuk, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblTavukLive, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.buttonYemVerTavuk, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.progressBarTavuk, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(299, 97);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // pictureBoxTavuk
            // 
            this.pictureBoxTavuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTavuk.Image = global::Ndpprojje.Properties.Resources.tavuk;
            this.pictureBoxTavuk.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTavuk.Name = "pictureBoxTavuk";
            this.tableLayoutPanel9.SetRowSpan(this.pictureBoxTavuk, 3);
            this.pictureBoxTavuk.Size = new System.Drawing.Size(98, 91);
            this.pictureBoxTavuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTavuk.TabIndex = 0;
            this.pictureBoxTavuk.TabStop = false;
            // 
            // lblTavukLive
            // 
            this.lblTavukLive.AutoSize = true;
            this.lblTavukLive.BackColor = System.Drawing.Color.Plum;
            this.lblTavukLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTavukLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTavukLive.ForeColor = System.Drawing.Color.Brown;
            this.lblTavukLive.Location = new System.Drawing.Point(107, 3);
            this.lblTavukLive.Margin = new System.Windows.Forms.Padding(3);
            this.lblTavukLive.Name = "lblTavukLive";
            this.lblTavukLive.Size = new System.Drawing.Size(189, 26);
            this.lblTavukLive.TabIndex = 1;
            this.lblTavukLive.Text = "CANLI";
            this.lblTavukLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYemVerTavuk
            // 
            this.buttonYemVerTavuk.BackColor = System.Drawing.Color.Thistle;
            this.buttonYemVerTavuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonYemVerTavuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYemVerTavuk.ForeColor = System.Drawing.Color.Red;
            this.buttonYemVerTavuk.Location = new System.Drawing.Point(107, 67);
            this.buttonYemVerTavuk.Name = "buttonYemVerTavuk";
            this.buttonYemVerTavuk.Size = new System.Drawing.Size(189, 27);
            this.buttonYemVerTavuk.TabIndex = 2;
            this.buttonYemVerTavuk.Text = "YEM VER";
            this.buttonYemVerTavuk.UseVisualStyleBackColor = false;
            this.buttonYemVerTavuk.Click += new System.EventHandler(this.buttonYemVerTavuk_Click);
            // 
            // progressBarTavuk
            // 
            this.progressBarTavuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarTavuk.ForeColor = System.Drawing.Color.Thistle;
            this.progressBarTavuk.Location = new System.Drawing.Point(107, 35);
            this.progressBarTavuk.Name = "progressBarTavuk";
            this.progressBarTavuk.Size = new System.Drawing.Size(189, 26);
            this.progressBarTavuk.TabIndex = 3;
            // 
            // FormHayvanCiftligi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(638, 411);
            this.Controls.Add(this.tableLayoutPanelAltGovde);
            this.Controls.Add(this.tableLayoutPanelUstGovde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHayvanCiftligi";
            this.Text = "HAYVAN ÇİFTLİĞİ";
            this.Load += new System.EventHandler(this.FormHayvanCiftligi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelUstGovde.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanelAltGovde.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeci)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInek)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrdek)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTavuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUrunDeposu;
        private System.Windows.Forms.Label lblTavYum;
        private System.Windows.Forms.Label lblInekSutu;
        private System.Windows.Forms.Label lblTavYumDegeri;
        private System.Windows.Forms.Label lblInekSutuDegeri;
        private System.Windows.Forms.Label lblOrdYum;
        private System.Windows.Forms.Label lblKeciSutu;
        private System.Windows.Forms.Label lblOrdYumDegeri;
        private System.Windows.Forms.Label lblKeciSutuDegeri;
        private System.Windows.Forms.Label labelSaniye;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUstGovde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label lblTl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonKeciSutuSat;
        private System.Windows.Forms.Button buttonInekSutuSat;
        private System.Windows.Forms.Button buttonOrdYumSat;
        private System.Windows.Forms.Label labelGidaFabrikasi;
        private System.Windows.Forms.Button buttonTavYumSat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAltGovde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.PictureBox pictureBoxKeci;
        private System.Windows.Forms.Label lblKeciLive;
        private System.Windows.Forms.Button buttonYemVerKeci;
        private System.Windows.Forms.ProgressBar progressBarKeci;
        private System.Windows.Forms.Label labelAhir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.PictureBox pictureBoxInek;
        private System.Windows.Forms.Label lblInekLive;
        private System.Windows.Forms.Button buttonYemVerInek;
        private System.Windows.Forms.ProgressBar progressBarInek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxOrdek;
        private System.Windows.Forms.Label lblOrdekLive;
        private System.Windows.Forms.Button buttonYemVerOrdek;
        private System.Windows.Forms.ProgressBar progressBarOrdek;
        private System.Windows.Forms.Label labelKumes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.PictureBox pictureBoxTavuk;
        private System.Windows.Forms.Label lblTavukLive;
        private System.Windows.Forms.Button buttonYemVerTavuk;
        private System.Windows.Forms.ProgressBar progressBarTavuk;
    }
}

