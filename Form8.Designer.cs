using System.Drawing;
using System.Windows.Forms;

namespace WashMe2
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.labelLogo = new Label();
            this.labelBeranda = new Label();
            this.labelPesanLaundry = new Label();
            this.labelLacakCucian = new Label();
            this.labelPelanggan = new Label();
            this.linkLabelKeluar = new LinkLabel();
            this.labelLangkah = new Label();
            this.labelJudul = new Label();
            this.labelSubjudul = new Label();
            this.panelCuciKiloan = new Panel();
            this.radioButtonCuciKiloan = new RadioButton();
            this.labelNamaCuciKiloan = new Label();
            this.labelDeskripsiCuciKiloan = new Label();
            this.labelEstimasiCuciKiloan = new Label();
            this.labelHargaCuciKiloan = new Label();
            this.panelCuciSetrika = new Panel();
            this.radioButtonCuciSetrika = new RadioButton();
            this.labelNamaCuciSetrika = new Label();
            this.labelPalingPopuler = new Label();
            this.labelDeskripsiCuciSetrika = new Label();
            this.labelEstimasiCuciSetrika = new Label();
            this.labelHargaCuciSetrika = new Label();
            this.panelExpress24Jam = new Panel();
            this.radioButtonExpress24Jam = new RadioButton();
            this.labelNamaExpress24Jam = new Label();
            this.labelDeskripsiExpress24Jam = new Label();
            this.labelEstimasiExpress24Jam = new Label();
            this.labelHargaExpress24Jam = new Label();
            this.panelSatuan = new Panel();
            this.radioButtonSatuan = new RadioButton();
            this.labelNamaSatuan = new Label();
            this.labelDeskripsiSatuan = new Label();
            this.labelEstimasiSatuan = new Label();
            this.labelHargaSatuan = new Label();
            this.labelJudulJumlahCucian = new Label();
            this.panelJumlahCucian = new Panel();
            this.labelPerkiraanBerat = new Label();
            this.labelKeteranganBerat = new Label();
            this.buttonKurang = new Button();
            this.labelBeratKilogram = new Label();
            this.buttonTambah = new Button();
            this.labelJudulLayananTambahan = new Label();
            this.panelJemputAntar = new Panel();
            this.checkBoxJemputAntar = new CheckBox();
            this.labelKeteranganJemputAntar = new Label();
            this.labelHargaJemputAntar = new Label();
            this.panelPewangiPremium = new Panel();
            this.checkBoxPewangiPremium = new CheckBox();
            this.labelKeteranganPewangiPremium = new Label();
            this.labelHargaPewangiPremium = new Label();
            this.panelPisahkanPakaianPutih = new Panel();
            this.checkBoxPisahkanPakaianPutih = new CheckBox();
            this.labelKeteranganPisahkanPakaianPutih = new Label();
            this.labelHargaPisahkanPakaianPutih = new Label();
            this.panelRingkasanPesanan = new Panel();
            this.labelJudulRingkasan = new Label();
            this.labelRingkasanNamaPaket = new Label();
            this.labelRingkasanRincianPaket = new Label();
            this.labelRingkasanHargaPaket = new Label();
            this.labelRingkasanJemputAntar = new Label();
            this.labelRingkasanHargaJemputAntar = new Label();
            this.panelGarisPemisah = new Panel();
            this.labelKeteranganTotal = new Label();
            this.labelTotalHarga = new Label();
            this.labelCatatanHarga = new Label();
            this.buttonLanjutKePenjemputan = new Button();
            this.panelHeader.SuspendLayout();
            this.panelCuciKiloan.SuspendLayout();
            this.panelCuciSetrika.SuspendLayout();
            this.panelExpress24Jam.SuspendLayout();
            this.panelSatuan.SuspendLayout();
            this.panelJumlahCucian.SuspendLayout();
            this.panelJemputAntar.SuspendLayout();
            this.panelPewangiPremium.SuspendLayout();
            this.panelPisahkanPakaianPutih.SuspendLayout();
            this.panelRingkasanPesanan.SuspendLayout();
            this.SuspendLayout();

            this.panelHeader.BackColor = Color.FromArgb(47, 115, 102);
            this.panelHeader.Controls.Add(this.labelLogo);
            this.panelHeader.Controls.Add(this.labelBeranda);
            this.panelHeader.Controls.Add(this.labelPesanLaundry);
            this.panelHeader.Controls.Add(this.labelLacakCucian);
            this.panelHeader.Controls.Add(this.labelPelanggan);
            this.panelHeader.Controls.Add(this.linkLabelKeluar);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(1120, 53);
            this.panelHeader.TabIndex = 14;

            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new Font("Cambria", 12F, FontStyle.Bold);
            this.labelLogo.ForeColor = Color.White;
            this.labelLogo.Location = new Point(27, 15);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new Size(88, 23);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "WashMe";

            this.labelBeranda.AutoSize = true;
            this.labelBeranda.Font = new Font("Segoe UI", 9F);
            this.labelBeranda.ForeColor = Color.FromArgb(220, 235, 230);
            this.labelBeranda.Location = new Point(377, 18);
            this.labelBeranda.Name = "labelBeranda";
            this.labelBeranda.Size = new Size(64, 20);
            this.labelBeranda.TabIndex = 1;
            this.labelBeranda.Text = "Beranda";

            this.labelPesanLaundry.BackColor = Color.FromArgb(225, 239, 235);
            this.labelPesanLaundry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelPesanLaundry.ForeColor = Color.FromArgb(47, 115, 102);
            this.labelPesanLaundry.Location = new Point(457, 13);
            this.labelPesanLaundry.Name = "labelPesanLaundry";
            this.labelPesanLaundry.Size = new Size(114, 28);
            this.labelPesanLaundry.TabIndex = 2;
            this.labelPesanLaundry.Text = "Pesan Laundry";
            this.labelPesanLaundry.TextAlign = ContentAlignment.MiddleCenter;

            this.labelLacakCucian.AutoSize = true;
            this.labelLacakCucian.Font = new Font("Segoe UI", 9F);
            this.labelLacakCucian.ForeColor = Color.FromArgb(220, 235, 230);
            this.labelLacakCucian.Location = new Point(594, 18);
            this.labelLacakCucian.Name = "labelLacakCucian";
            this.labelLacakCucian.Size = new Size(94, 20);
            this.labelLacakCucian.TabIndex = 3;
            this.labelLacakCucian.Text = "Lacak Cucian";

            this.labelPelanggan.AutoSize = true;
            this.labelPelanggan.Font = new Font("Segoe UI", 9F);
            this.labelPelanggan.ForeColor = Color.White;
            this.labelPelanggan.Location = new Point(949, 18);
            this.labelPelanggan.Name = "labelPelanggan";
            this.labelPelanggan.Size = new Size(78, 20);
            this.labelPelanggan.TabIndex = 4;
            this.labelPelanggan.Text = "Pelanggan";

            this.linkLabelKeluar.AutoSize = true;
            this.linkLabelKeluar.Font = new Font("Segoe UI", 9F);
            this.linkLabelKeluar.LinkColor = Color.White;
            this.linkLabelKeluar.Location = new Point(1040, 18);
            this.linkLabelKeluar.Name = "linkLabelKeluar";
            this.linkLabelKeluar.Size = new Size(51, 20);
            this.linkLabelKeluar.TabIndex = 5;
            this.linkLabelKeluar.TabStop = true;
            this.linkLabelKeluar.Text = "Keluar";

            this.labelLangkah.AutoSize = true;
            this.labelLangkah.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.labelLangkah.ForeColor = Color.FromArgb(47, 115, 102);
            this.labelLangkah.Location = new Point(34, 70);
            this.labelLangkah.Name = "labelLangkah";
            this.labelLangkah.Size = new Size(192, 19);
            this.labelLangkah.TabIndex = 13;
            this.labelLangkah.Text = "LANGKAH 1 DARI 3 · PAKET";

            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new Font("Rockwell", 22.2F, FontStyle.Bold);
            this.labelJudul.ForeColor = Color.Black;
            this.labelJudul.Location = new Point(30, 87);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new Size(371, 46);
            this.labelJudul.TabIndex = 12;
            this.labelJudul.Text = "Pilih paket laundry";

            this.labelSubjudul.AutoSize = true;
            this.labelSubjudul.Font = new Font("Segoe UI", 9F);
            this.labelSubjudul.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelSubjudul.Location = new Point(34, 137);
            this.labelSubjudul.Name = "labelSubjudul";
            this.labelSubjudul.Size = new Size(478, 20);
            this.labelSubjudul.TabIndex = 11;
            this.labelSubjudul.Text = "Pilih satu paket sesuai jenis cucian dan kecepatan yang kamu butuhkan.";

            this.panelCuciKiloan.BackColor = Color.White;
            this.panelCuciKiloan.BorderStyle = BorderStyle.FixedSingle;
            this.panelCuciKiloan.Controls.Add(this.radioButtonCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelNamaCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelDeskripsiCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelEstimasiCuciKiloan);
            this.panelCuciKiloan.Controls.Add(this.labelHargaCuciKiloan);
            this.panelCuciKiloan.Location = new Point(34, 171);
            this.panelCuciKiloan.Name = "panelCuciKiloan";
            this.panelCuciKiloan.Size = new Size(347, 124);
            this.panelCuciKiloan.TabIndex = 10;

            this.radioButtonCuciKiloan.BackColor = Color.Transparent;
            this.radioButtonCuciKiloan.Location = new Point(313, 9);
            this.radioButtonCuciKiloan.Name = "radioButtonCuciKiloan";
            this.radioButtonCuciKiloan.Size = new Size(23, 21);
            this.radioButtonCuciKiloan.TabIndex = 0;
            this.radioButtonCuciKiloan.UseVisualStyleBackColor = false;

            this.labelNamaCuciKiloan.AutoSize = true;
            this.labelNamaCuciKiloan.BackColor = Color.Transparent;
            this.labelNamaCuciKiloan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelNamaCuciKiloan.Location = new Point(14, 9);
            this.labelNamaCuciKiloan.Name = "labelNamaCuciKiloan";
            this.labelNamaCuciKiloan.Size = new Size(99, 23);
            this.labelNamaCuciKiloan.TabIndex = 1;
            this.labelNamaCuciKiloan.Text = "Cuci Kiloan";

            this.labelDeskripsiCuciKiloan.BackColor = Color.Transparent;
            this.labelDeskripsiCuciKiloan.Font = new Font("Segoe UI", 8F);
            this.labelDeskripsiCuciKiloan.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelDeskripsiCuciKiloan.Location = new Point(14, 34);
            this.labelDeskripsiCuciKiloan.Name = "labelDeskripsiCuciKiloan";
            this.labelDeskripsiCuciKiloan.Size = new Size(309, 30);
            this.labelDeskripsiCuciKiloan.TabIndex = 2;
            this.labelDeskripsiCuciKiloan.Text = "Cuci, kering, dan lipat rapi.";

            this.labelEstimasiCuciKiloan.AutoSize = true;
            this.labelEstimasiCuciKiloan.BackColor = Color.Transparent;
            this.labelEstimasiCuciKiloan.Font = new Font("Segoe UI", 8F);
            this.labelEstimasiCuciKiloan.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelEstimasiCuciKiloan.Location = new Point(14, 68);
            this.labelEstimasiCuciKiloan.Name = "labelEstimasiCuciKiloan";
            this.labelEstimasiCuciKiloan.Size = new Size(112, 19);
            this.labelEstimasiCuciKiloan.TabIndex = 3;
            this.labelEstimasiCuciKiloan.Text = "Estimasi 2–3 hari";

            this.labelHargaCuciKiloan.AutoSize = true;
            this.labelHargaCuciKiloan.BackColor = Color.Transparent;
            this.labelHargaCuciKiloan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelHargaCuciKiloan.Location = new Point(14, 92);
            this.labelHargaCuciKiloan.Name = "labelHargaCuciKiloan";
            this.labelHargaCuciKiloan.Size = new Size(131, 25);
            this.labelHargaCuciKiloan.TabIndex = 4;
            this.labelHargaCuciKiloan.Text = "Rp 7.000 / kg";

            this.panelCuciSetrika.BackColor = Color.FromArgb(225, 239, 235);
            this.panelCuciSetrika.BorderStyle = BorderStyle.FixedSingle;
            this.panelCuciSetrika.Controls.Add(this.radioButtonCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelNamaCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelPalingPopuler);
            this.panelCuciSetrika.Controls.Add(this.labelDeskripsiCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelEstimasiCuciSetrika);
            this.panelCuciSetrika.Controls.Add(this.labelHargaCuciSetrika);
            this.panelCuciSetrika.Location = new Point(395, 171);
            this.panelCuciSetrika.Name = "panelCuciSetrika";
            this.panelCuciSetrika.Size = new Size(347, 124);
            this.panelCuciSetrika.TabIndex = 9;

            this.radioButtonCuciSetrika.BackColor = Color.Transparent;
            this.radioButtonCuciSetrika.Checked = true;
            this.radioButtonCuciSetrika.Location = new Point(313, 9);
            this.radioButtonCuciSetrika.Name = "radioButtonCuciSetrika";
            this.radioButtonCuciSetrika.Size = new Size(23, 21);
            this.radioButtonCuciSetrika.TabIndex = 0;
            this.radioButtonCuciSetrika.TabStop = true;
            this.radioButtonCuciSetrika.UseVisualStyleBackColor = false;

            this.labelNamaCuciSetrika.AutoSize = true;
            this.labelNamaCuciSetrika.BackColor = Color.Transparent;
            this.labelNamaCuciSetrika.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelNamaCuciSetrika.Location = new Point(14, 9);
            this.labelNamaCuciSetrika.Name = "labelNamaCuciSetrika";
            this.labelNamaCuciSetrika.Size = new Size(123, 23);
            this.labelNamaCuciSetrika.TabIndex = 1;
            this.labelNamaCuciSetrika.Text = "Cuci + Setrika";

            this.labelPalingPopuler.BackColor = Color.FromArgb(47, 115, 102);
            this.labelPalingPopuler.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelPalingPopuler.ForeColor = Color.White;
            this.labelPalingPopuler.Location = new Point(14, 32);
            this.labelPalingPopuler.Name = "labelPalingPopuler";
            this.labelPalingPopuler.Size = new Size(101, 18);
            this.labelPalingPopuler.TabIndex = 2;
            this.labelPalingPopuler.Text = "Paling populer";
            this.labelPalingPopuler.TextAlign = ContentAlignment.MiddleCenter;

            this.labelDeskripsiCuciSetrika.BackColor = Color.Transparent;
            this.labelDeskripsiCuciSetrika.Font = new Font("Segoe UI", 8F);
            this.labelDeskripsiCuciSetrika.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelDeskripsiCuciSetrika.Location = new Point(14, 53);
            this.labelDeskripsiCuciSetrika.Name = "labelDeskripsiCuciSetrika";
            this.labelDeskripsiCuciSetrika.Size = new Size(309, 30);
            this.labelDeskripsiCuciSetrika.TabIndex = 3;
            this.labelDeskripsiCuciSetrika.Text = "Cuci, kering, lalu dilipat atau digantung.";

            this.labelEstimasiCuciSetrika.AutoSize = true;
            this.labelEstimasiCuciSetrika.BackColor = Color.Transparent;
            this.labelEstimasiCuciSetrika.Font = new Font("Segoe UI", 8F);
            this.labelEstimasiCuciSetrika.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelEstimasiCuciSetrika.Location = new Point(14, 77);
            this.labelEstimasiCuciSetrika.Name = "labelEstimasiCuciSetrika";
            this.labelEstimasiCuciSetrika.Size = new Size(112, 19);
            this.labelEstimasiCuciSetrika.TabIndex = 4;
            this.labelEstimasiCuciSetrika.Text = "Estimasi 2–3 hari";

            this.labelHargaCuciSetrika.AutoSize = true;
            this.labelHargaCuciSetrika.BackColor = Color.Transparent;
            this.labelHargaCuciSetrika.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelHargaCuciSetrika.Location = new Point(14, 96);
            this.labelHargaCuciSetrika.Name = "labelHargaCuciSetrika";
            this.labelHargaCuciSetrika.Size = new Size(131, 25);
            this.labelHargaCuciSetrika.TabIndex = 5;
            this.labelHargaCuciSetrika.Text = "Rp 9.000 / kg";

            this.panelExpress24Jam.BackColor = Color.White;
            this.panelExpress24Jam.BorderStyle = BorderStyle.FixedSingle;
            this.panelExpress24Jam.Controls.Add(this.radioButtonExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelNamaExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelDeskripsiExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelEstimasiExpress24Jam);
            this.panelExpress24Jam.Controls.Add(this.labelHargaExpress24Jam);
            this.panelExpress24Jam.Location = new Point(34, 309);
            this.panelExpress24Jam.Name = "panelExpress24Jam";
            this.panelExpress24Jam.Size = new Size(347, 124);
            this.panelExpress24Jam.TabIndex = 8;

            this.radioButtonExpress24Jam.BackColor = Color.Transparent;
            this.radioButtonExpress24Jam.Location = new Point(313, 9);
            this.radioButtonExpress24Jam.Name = "radioButtonExpress24Jam";
            this.radioButtonExpress24Jam.Size = new Size(23, 21);
            this.radioButtonExpress24Jam.TabIndex = 0;
            this.radioButtonExpress24Jam.UseVisualStyleBackColor = false;

            this.labelNamaExpress24Jam.AutoSize = true;
            this.labelNamaExpress24Jam.BackColor = Color.Transparent;
            this.labelNamaExpress24Jam.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelNamaExpress24Jam.Location = new Point(14, 9);
            this.labelNamaExpress24Jam.Name = "labelNamaExpress24Jam";
            this.labelNamaExpress24Jam.Size = new Size(132, 23);
            this.labelNamaExpress24Jam.TabIndex = 1;
            this.labelNamaExpress24Jam.Text = "Express 24 Jam";

            this.labelDeskripsiExpress24Jam.BackColor = Color.Transparent;
            this.labelDeskripsiExpress24Jam.Font = new Font("Segoe UI", 8F);
            this.labelDeskripsiExpress24Jam.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelDeskripsiExpress24Jam.Location = new Point(14, 34);
            this.labelDeskripsiExpress24Jam.Name = "labelDeskripsiExpress24Jam";
            this.labelDeskripsiExpress24Jam.Size = new Size(309, 30);
            this.labelDeskripsiExpress24Jam.TabIndex = 2;
            this.labelDeskripsiExpress24Jam.Text = "Cuci kering prioritas, selesai dalam satu hari.";

            this.labelEstimasiExpress24Jam.AutoSize = true;
            this.labelEstimasiExpress24Jam.BackColor = Color.Transparent;
            this.labelEstimasiExpress24Jam.Font = new Font("Segoe UI", 8F);
            this.labelEstimasiExpress24Jam.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelEstimasiExpress24Jam.Location = new Point(14, 68);
            this.labelEstimasiExpress24Jam.Name = "labelEstimasiExpress24Jam";
            this.labelEstimasiExpress24Jam.Size = new Size(97, 19);
            this.labelEstimasiExpress24Jam.TabIndex = 3;
            this.labelEstimasiExpress24Jam.Text = "Estimasi 1 hari";

            this.labelHargaExpress24Jam.AutoSize = true;
            this.labelHargaExpress24Jam.BackColor = Color.Transparent;
            this.labelHargaExpress24Jam.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelHargaExpress24Jam.Location = new Point(14, 92);
            this.labelHargaExpress24Jam.Name = "labelHargaExpress24Jam";
            this.labelHargaExpress24Jam.Size = new Size(142, 25);
            this.labelHargaExpress24Jam.TabIndex = 4;
            this.labelHargaExpress24Jam.Text = "Rp 14.000 / kg";

            this.panelSatuan.BackColor = Color.White;
            this.panelSatuan.BorderStyle = BorderStyle.FixedSingle;
            this.panelSatuan.Controls.Add(this.radioButtonSatuan);
            this.panelSatuan.Controls.Add(this.labelNamaSatuan);
            this.panelSatuan.Controls.Add(this.labelDeskripsiSatuan);
            this.panelSatuan.Controls.Add(this.labelEstimasiSatuan);
            this.panelSatuan.Controls.Add(this.labelHargaSatuan);
            this.panelSatuan.Location = new Point(395, 309);
            this.panelSatuan.Name = "panelSatuan";
            this.panelSatuan.Size = new Size(347, 124);
            this.panelSatuan.TabIndex = 7;

            this.radioButtonSatuan.BackColor = Color.Transparent;
            this.radioButtonSatuan.Location = new Point(313, 9);
            this.radioButtonSatuan.Name = "radioButtonSatuan";
            this.radioButtonSatuan.Size = new Size(23, 21);
            this.radioButtonSatuan.TabIndex = 0;
            this.radioButtonSatuan.UseVisualStyleBackColor = false;

            this.labelNamaSatuan.AutoSize = true;
            this.labelNamaSatuan.BackColor = Color.Transparent;
            this.labelNamaSatuan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelNamaSatuan.Location = new Point(14, 9);
            this.labelNamaSatuan.Name = "labelNamaSatuan";
            this.labelNamaSatuan.Size = new Size(65, 23);
            this.labelNamaSatuan.TabIndex = 1;
            this.labelNamaSatuan.Text = "Satuan";

            this.labelDeskripsiSatuan.BackColor = Color.Transparent;
            this.labelDeskripsiSatuan.Font = new Font("Segoe UI", 8F);
            this.labelDeskripsiSatuan.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelDeskripsiSatuan.Location = new Point(14, 34);
            this.labelDeskripsiSatuan.Name = "labelDeskripsiSatuan";
            this.labelDeskripsiSatuan.Size = new Size(309, 30);
            this.labelDeskripsiSatuan.TabIndex = 2;
            this.labelDeskripsiSatuan.Text = "Bedcover, selimut, jaket, dan pakaian khusus.";

            this.labelEstimasiSatuan.AutoSize = true;
            this.labelEstimasiSatuan.BackColor = Color.Transparent;
            this.labelEstimasiSatuan.Font = new Font("Segoe UI", 8F);
            this.labelEstimasiSatuan.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelEstimasiSatuan.Location = new Point(14, 68);
            this.labelEstimasiSatuan.Name = "labelEstimasiSatuan";
            this.labelEstimasiSatuan.Size = new Size(112, 19);
            this.labelEstimasiSatuan.TabIndex = 3;
            this.labelEstimasiSatuan.Text = "Estimasi 2–3 hari";

            this.labelHargaSatuan.AutoSize = true;
            this.labelHargaSatuan.BackColor = Color.Transparent;
            this.labelHargaSatuan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelHargaSatuan.Location = new Point(14, 92);
            this.labelHargaSatuan.Name = "labelHargaSatuan";
            this.labelHargaSatuan.Size = new Size(158, 25);
            this.labelHargaSatuan.TabIndex = 4;
            this.labelHargaSatuan.Text = "Rp 25.000 / item";

            this.labelJudulJumlahCucian.AutoSize = true;
            this.labelJudulJumlahCucian.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelJudulJumlahCucian.Location = new Point(34, 452);
            this.labelJudulJumlahCucian.Name = "labelJudulJumlahCucian";
            this.labelJudulJumlahCucian.Size = new Size(137, 25);
            this.labelJudulJumlahCucian.TabIndex = 6;
            this.labelJudulJumlahCucian.Text = "Jumlah cucian";

            this.panelJumlahCucian.BackColor = Color.White;
            this.panelJumlahCucian.BorderStyle = BorderStyle.FixedSingle;
            this.panelJumlahCucian.Controls.Add(this.labelPerkiraanBerat);
            this.panelJumlahCucian.Controls.Add(this.labelKeteranganBerat);
            this.panelJumlahCucian.Controls.Add(this.buttonKurang);
            this.panelJumlahCucian.Controls.Add(this.labelBeratKilogram);
            this.panelJumlahCucian.Controls.Add(this.buttonTambah);
            this.panelJumlahCucian.Location = new Point(34, 482);
            this.panelJumlahCucian.Name = "panelJumlahCucian";
            this.panelJumlahCucian.Size = new Size(708, 68);
            this.panelJumlahCucian.TabIndex = 5;

            this.labelPerkiraanBerat.AutoSize = true;
            this.labelPerkiraanBerat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelPerkiraanBerat.Location = new Point(16, 13);
            this.labelPerkiraanBerat.Name = "labelPerkiraanBerat";
            this.labelPerkiraanBerat.Size = new Size(116, 20);
            this.labelPerkiraanBerat.TabIndex = 0;
            this.labelPerkiraanBerat.Text = "Perkiraan berat";

            this.labelKeteranganBerat.AutoSize = true;
            this.labelKeteranganBerat.Font = new Font("Segoe UI", 8F);
            this.labelKeteranganBerat.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelKeteranganBerat.Location = new Point(16, 36);
            this.labelKeteranganBerat.Name = "labelKeteranganBerat";
            this.labelKeteranganBerat.Size = new Size(289, 19);
            this.labelKeteranganBerat.TabIndex = 1;
            this.labelKeteranganBerat.Text = "Perkiraan saja, berat akhir ditimbang di outlet.";

            this.buttonKurang.BackColor = Color.White;
            this.buttonKurang.FlatStyle = FlatStyle.Flat;
            this.buttonKurang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.buttonKurang.Location = new Point(526, 15);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new Size(39, 36);
            this.buttonKurang.TabIndex = 2;
            this.buttonKurang.Text = "−";
            this.buttonKurang.UseVisualStyleBackColor = false;

            this.labelBeratKilogram.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelBeratKilogram.Location = new Point(569, 15);
            this.labelBeratKilogram.Name = "labelBeratKilogram";
            this.labelBeratKilogram.Size = new Size(69, 36);
            this.labelBeratKilogram.TabIndex = 3;
            this.labelBeratKilogram.Text = "5 kg";
            this.labelBeratKilogram.TextAlign = ContentAlignment.MiddleCenter;

            this.buttonTambah.BackColor = Color.White;
            this.buttonTambah.FlatStyle = FlatStyle.Flat;
            this.buttonTambah.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.buttonTambah.Location = new Point(642, 15);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new Size(39, 36);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = false;

            this.labelJudulLayananTambahan.AutoSize = true;
            this.labelJudulLayananTambahan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelJudulLayananTambahan.Location = new Point(34, 570);
            this.labelJudulLayananTambahan.Name = "labelJudulLayananTambahan";
            this.labelJudulLayananTambahan.Size = new Size(180, 25);
            this.labelJudulLayananTambahan.TabIndex = 4;
            this.labelJudulLayananTambahan.Text = "Layanan tambahan";

            this.panelJemputAntar.BackColor = Color.FromArgb(225, 239, 235);
            this.panelJemputAntar.BorderStyle = BorderStyle.FixedSingle;
            this.panelJemputAntar.Controls.Add(this.checkBoxJemputAntar);
            this.panelJemputAntar.Controls.Add(this.labelKeteranganJemputAntar);
            this.panelJemputAntar.Controls.Add(this.labelHargaJemputAntar);
            this.panelJemputAntar.Location = new Point(34, 599);
            this.panelJemputAntar.Name = "panelJemputAntar";
            this.panelJemputAntar.Size = new Size(708, 53);
            this.panelJemputAntar.TabIndex = 3;

            this.checkBoxJemputAntar.AutoSize = true;
            this.checkBoxJemputAntar.BackColor = Color.Transparent;
            this.checkBoxJemputAntar.Checked = true;
            this.checkBoxJemputAntar.CheckState = CheckState.Checked;
            this.checkBoxJemputAntar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.checkBoxJemputAntar.Location = new Point(14, 6);
            this.checkBoxJemputAntar.Name = "checkBoxJemputAntar";
            this.checkBoxJemputAntar.Size = new Size(155, 24);
            this.checkBoxJemputAntar.TabIndex = 0;
            this.checkBoxJemputAntar.Text = "Jemput dan antar";
            this.checkBoxJemputAntar.UseVisualStyleBackColor = false;

            this.labelKeteranganJemputAntar.AutoSize = true;
            this.labelKeteranganJemputAntar.BackColor = Color.Transparent;
            this.labelKeteranganJemputAntar.Font = new Font("Segoe UI", 8F);
            this.labelKeteranganJemputAntar.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelKeteranganJemputAntar.Location = new Point(37, 30);
            this.labelKeteranganJemputAntar.Name = "labelKeteranganJemputAntar";
            this.labelKeteranganJemputAntar.Size = new Size(338, 19);
            this.labelKeteranganJemputAntar.TabIndex = 1;
            this.labelKeteranganJemputAntar.Text = "Kurir menjemput dan mengantar cucian ke alamatmu.";

            this.labelHargaJemputAntar.BackColor = Color.Transparent;
            this.labelHargaJemputAntar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelHargaJemputAntar.Location = new Point(549, 9);
            this.labelHargaJemputAntar.Name = "labelHargaJemputAntar";
            this.labelHargaJemputAntar.Size = new Size(144, 21);
            this.labelHargaJemputAntar.TabIndex = 2;
            this.labelHargaJemputAntar.Text = "+ Rp 5.000";
            this.labelHargaJemputAntar.TextAlign = ContentAlignment.MiddleRight;

            this.panelPewangiPremium.BackColor = Color.White;
            this.panelPewangiPremium.BorderStyle = BorderStyle.FixedSingle;
            this.panelPewangiPremium.Controls.Add(this.checkBoxPewangiPremium);
            this.panelPewangiPremium.Controls.Add(this.labelKeteranganPewangiPremium);
            this.panelPewangiPremium.Controls.Add(this.labelHargaPewangiPremium);
            this.panelPewangiPremium.Location = new Point(34, 659);
            this.panelPewangiPremium.Name = "panelPewangiPremium";
            this.panelPewangiPremium.Size = new Size(708, 53);
            this.panelPewangiPremium.TabIndex = 2;

            this.checkBoxPewangiPremium.AutoSize = true;
            this.checkBoxPewangiPremium.BackColor = Color.Transparent;
            this.checkBoxPewangiPremium.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.checkBoxPewangiPremium.Location = new Point(14, 6);
            this.checkBoxPewangiPremium.Name = "checkBoxPewangiPremium";
            this.checkBoxPewangiPremium.Size = new Size(158, 24);
            this.checkBoxPewangiPremium.TabIndex = 0;
            this.checkBoxPewangiPremium.Text = "Pewangi premium";
            this.checkBoxPewangiPremium.UseVisualStyleBackColor = false;

            this.labelKeteranganPewangiPremium.AutoSize = true;
            this.labelKeteranganPewangiPremium.BackColor = Color.Transparent;
            this.labelKeteranganPewangiPremium.Font = new Font("Segoe UI", 8F);
            this.labelKeteranganPewangiPremium.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelKeteranganPewangiPremium.Location = new Point(37, 30);
            this.labelKeteranganPewangiPremium.Name = "labelKeteranganPewangiPremium";
            this.labelKeteranganPewangiPremium.Size = new Size(200, 19);
            this.labelKeteranganPewangiPremium.TabIndex = 1;
            this.labelKeteranganPewangiPremium.Text = "Pilihan aroma lebih tahan lama.";

            this.labelHargaPewangiPremium.BackColor = Color.Transparent;
            this.labelHargaPewangiPremium.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelHargaPewangiPremium.Location = new Point(549, 9);
            this.labelHargaPewangiPremium.Name = "labelHargaPewangiPremium";
            this.labelHargaPewangiPremium.Size = new Size(144, 21);
            this.labelHargaPewangiPremium.TabIndex = 2;
            this.labelHargaPewangiPremium.Text = "+ Rp 3.000";
            this.labelHargaPewangiPremium.TextAlign = ContentAlignment.MiddleRight;

            this.panelPisahkanPakaianPutih.BackColor = Color.White;
            this.panelPisahkanPakaianPutih.BorderStyle = BorderStyle.FixedSingle;
            this.panelPisahkanPakaianPutih.Controls.Add(this.checkBoxPisahkanPakaianPutih);
            this.panelPisahkanPakaianPutih.Controls.Add(this.labelKeteranganPisahkanPakaianPutih);
            this.panelPisahkanPakaianPutih.Controls.Add(this.labelHargaPisahkanPakaianPutih);
            this.panelPisahkanPakaianPutih.Location = new Point(34, 719);
            this.panelPisahkanPakaianPutih.Name = "panelPisahkanPakaianPutih";
            this.panelPisahkanPakaianPutih.Size = new Size(708, 53);
            this.panelPisahkanPakaianPutih.TabIndex = 1;

            this.checkBoxPisahkanPakaianPutih.AutoSize = true;
            this.checkBoxPisahkanPakaianPutih.BackColor = Color.Transparent;
            this.checkBoxPisahkanPakaianPutih.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.checkBoxPisahkanPakaianPutih.Location = new Point(14, 6);
            this.checkBoxPisahkanPakaianPutih.Name = "checkBoxPisahkanPakaianPutih";
            this.checkBoxPisahkanPakaianPutih.Size = new Size(192, 24);
            this.checkBoxPisahkanPakaianPutih.TabIndex = 0;
            this.checkBoxPisahkanPakaianPutih.Text = "Pisahkan pakaian putih";
            this.checkBoxPisahkanPakaianPutih.UseVisualStyleBackColor = false;

            this.labelKeteranganPisahkanPakaianPutih.AutoSize = true;
            this.labelKeteranganPisahkanPakaianPutih.BackColor = Color.Transparent;
            this.labelKeteranganPisahkanPakaianPutih.Font = new Font("Segoe UI", 8F);
            this.labelKeteranganPisahkanPakaianPutih.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelKeteranganPisahkanPakaianPutih.Location = new Point(37, 30);
            this.labelKeteranganPisahkanPakaianPutih.Name = "labelKeteranganPisahkanPakaianPutih";
            this.labelKeteranganPisahkanPakaianPutih.Size = new Size(248, 19);
            this.labelKeteranganPisahkanPakaianPutih.TabIndex = 1;
            this.labelKeteranganPisahkanPakaianPutih.Text = "Dicuci terpisah agar warna tidak luntur.";

            this.labelHargaPisahkanPakaianPutih.BackColor = Color.Transparent;
            this.labelHargaPisahkanPakaianPutih.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelHargaPisahkanPakaianPutih.Location = new Point(549, 9);
            this.labelHargaPisahkanPakaianPutih.Name = "labelHargaPisahkanPakaianPutih";
            this.labelHargaPisahkanPakaianPutih.Size = new Size(144, 21);
            this.labelHargaPisahkanPakaianPutih.TabIndex = 2;
            this.labelHargaPisahkanPakaianPutih.Text = "Gratis";
            this.labelHargaPisahkanPakaianPutih.TextAlign = ContentAlignment.MiddleRight;

            this.panelRingkasanPesanan.BackColor = Color.White;
            this.panelRingkasanPesanan.BorderStyle = BorderStyle.FixedSingle;
            this.panelRingkasanPesanan.Controls.Add(this.labelJudulRingkasan);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanNamaPaket);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanRincianPaket);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanHargaPaket);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanJemputAntar);
            this.panelRingkasanPesanan.Controls.Add(this.labelRingkasanHargaJemputAntar);
            this.panelRingkasanPesanan.Controls.Add(this.panelGarisPemisah);
            this.panelRingkasanPesanan.Controls.Add(this.labelKeteranganTotal);
            this.panelRingkasanPesanan.Controls.Add(this.labelTotalHarga);
            this.panelRingkasanPesanan.Controls.Add(this.labelCatatanHarga);
            this.panelRingkasanPesanan.Controls.Add(this.buttonLanjutKePenjemputan);
            this.panelRingkasanPesanan.Location = new Point(777, 96);
            this.panelRingkasanPesanan.Name = "panelRingkasanPesanan";
            this.panelRingkasanPesanan.Size = new Size(320, 320);
            this.panelRingkasanPesanan.TabIndex = 0;

            this.labelJudulRingkasan.AutoSize = true;
            this.labelJudulRingkasan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.labelJudulRingkasan.Location = new Point(18, 15);
            this.labelJudulRingkasan.Name = "labelJudulRingkasan";
            this.labelJudulRingkasan.Size = new Size(193, 28);
            this.labelJudulRingkasan.TabIndex = 0;
            this.labelJudulRingkasan.Text = "Ringkasan pesanan";

            this.labelRingkasanNamaPaket.AutoSize = true;
            this.labelRingkasanNamaPaket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelRingkasanNamaPaket.Location = new Point(18, 55);
            this.labelRingkasanNamaPaket.Name = "labelRingkasanNamaPaket";
            this.labelRingkasanNamaPaket.Size = new Size(105, 20);
            this.labelRingkasanNamaPaket.TabIndex = 1;
            this.labelRingkasanNamaPaket.Text = "Cuci + Setrika";

            this.labelRingkasanRincianPaket.AutoSize = true;
            this.labelRingkasanRincianPaket.Font = new Font("Segoe UI", 8F);
            this.labelRingkasanRincianPaket.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelRingkasanRincianPaket.Location = new Point(18, 77);
            this.labelRingkasanRincianPaket.Name = "labelRingkasanRincianPaket";
            this.labelRingkasanRincianPaket.Size = new Size(109, 19);
            this.labelRingkasanRincianPaket.TabIndex = 2;
            this.labelRingkasanRincianPaket.Text = "5 kg × Rp 9.000";

            this.labelRingkasanHargaPaket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelRingkasanHargaPaket.Location = new Point(171, 55);
            this.labelRingkasanHargaPaket.Name = "labelRingkasanHargaPaket";
            this.labelRingkasanHargaPaket.Size = new Size(128, 21);
            this.labelRingkasanHargaPaket.TabIndex = 3;
            this.labelRingkasanHargaPaket.Text = "Rp 45.000";
            this.labelRingkasanHargaPaket.TextAlign = ContentAlignment.MiddleRight;

            this.labelRingkasanJemputAntar.AutoSize = true;
            this.labelRingkasanJemputAntar.Font = new Font("Segoe UI", 8.5F);
            this.labelRingkasanJemputAntar.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelRingkasanJemputAntar.Location = new Point(18, 109);
            this.labelRingkasanJemputAntar.Name = "labelRingkasanJemputAntar";
            this.labelRingkasanJemputAntar.Size = new Size(124, 20);
            this.labelRingkasanJemputAntar.TabIndex = 4;
            this.labelRingkasanJemputAntar.Text = "Jemput dan antar";

            this.labelRingkasanHargaJemputAntar.Font = new Font("Segoe UI", 8.5F);
            this.labelRingkasanHargaJemputAntar.Location = new Point(171, 109);
            this.labelRingkasanHargaJemputAntar.Name = "labelRingkasanHargaJemputAntar";
            this.labelRingkasanHargaJemputAntar.Size = new Size(128, 21);
            this.labelRingkasanHargaJemputAntar.TabIndex = 5;
            this.labelRingkasanHargaJemputAntar.Text = "Rp 5.000";
            this.labelRingkasanHargaJemputAntar.TextAlign = ContentAlignment.MiddleRight;

            this.panelGarisPemisah.BackColor = Color.FromArgb(209, 213, 219);
            this.panelGarisPemisah.Location = new Point(18, 143);
            this.panelGarisPemisah.Name = "panelGarisPemisah";
            this.panelGarisPemisah.Size = new Size(281, 1);
            this.panelGarisPemisah.TabIndex = 6;

            this.labelKeteranganTotal.AutoSize = true;
            this.labelKeteranganTotal.Font = new Font("Segoe UI", 9F);
            this.labelKeteranganTotal.Location = new Point(18, 166);
            this.labelKeteranganTotal.Name = "labelKeteranganTotal";
            this.labelKeteranganTotal.Size = new Size(104, 20);
            this.labelKeteranganTotal.TabIndex = 7;
            this.labelKeteranganTotal.Text = "Perkiraan total";

            this.labelTotalHarga.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.labelTotalHarga.Location = new Point(126, 156);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new Size(174, 34);
            this.labelTotalHarga.TabIndex = 8;
            this.labelTotalHarga.Text = "Rp 50.000";
            this.labelTotalHarga.TextAlign = ContentAlignment.MiddleRight;

            this.labelCatatanHarga.Font = new Font("Segoe UI", 8F);
            this.labelCatatanHarga.ForeColor = Color.FromArgb(107, 114, 128);
            this.labelCatatanHarga.Location = new Point(18, 201);
            this.labelCatatanHarga.Name = "labelCatatanHarga";
            this.labelCatatanHarga.Size = new Size(281, 47);
            this.labelCatatanHarga.TabIndex = 9;
            this.labelCatatanHarga.Text = "Harga di halaman ini hanya contoh. Berat akhir ditimbang saat cucian diterima, jadi total bisa berubah.";

            this.buttonLanjutKePenjemputan.BackColor = Color.FromArgb(47, 115, 102);
            this.buttonLanjutKePenjemputan.FlatAppearance.BorderSize = 0;
            this.buttonLanjutKePenjemputan.FlatStyle = FlatStyle.Flat;
            this.buttonLanjutKePenjemputan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonLanjutKePenjemputan.ForeColor = Color.White;
            this.buttonLanjutKePenjemputan.Location = new Point(18, 260);
            this.buttonLanjutKePenjemputan.Name = "buttonLanjutKePenjemputan";
            this.buttonLanjutKePenjemputan.Size = new Size(281, 45);
            this.buttonLanjutKePenjemputan.TabIndex = 10;
            this.buttonLanjutKePenjemputan.Text = "Lanjut ke Penjemputan";
            this.buttonLanjutKePenjemputan.UseVisualStyleBackColor = false;

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.ClientSize = new Size(1120, 800);
            this.Controls.Add(this.panelRingkasanPesanan);
            this.Controls.Add(this.panelPisahkanPakaianPutih);
            this.Controls.Add(this.panelPewangiPremium);
            this.Controls.Add(this.panelJemputAntar);
            this.Controls.Add(this.labelJudulLayananTambahan);
            this.Controls.Add(this.panelJumlahCucian);
            this.Controls.Add(this.labelJudulJumlahCucian);
            this.Controls.Add(this.panelSatuan);
            this.Controls.Add(this.panelExpress24Jam);
            this.Controls.Add(this.panelCuciSetrika);
            this.Controls.Add(this.panelCuciKiloan);
            this.Controls.Add(this.labelSubjudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.labelLangkah);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Pilih Paket Laundry";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCuciKiloan.ResumeLayout(false);
            this.panelCuciKiloan.PerformLayout();
            this.panelCuciSetrika.ResumeLayout(false);
            this.panelCuciSetrika.PerformLayout();
            this.panelExpress24Jam.ResumeLayout(false);
            this.panelExpress24Jam.PerformLayout();
            this.panelSatuan.ResumeLayout(false);
            this.panelSatuan.PerformLayout();
            this.panelJumlahCucian.ResumeLayout(false);
            this.panelJumlahCucian.PerformLayout();
            this.panelJemputAntar.ResumeLayout(false);
            this.panelJemputAntar.PerformLayout();
            this.panelPewangiPremium.ResumeLayout(false);
            this.panelPewangiPremium.PerformLayout();
            this.panelPisahkanPakaianPutih.ResumeLayout(false);
            this.panelPisahkanPakaianPutih.PerformLayout();
            this.panelRingkasanPesanan.ResumeLayout(false);
            this.panelRingkasanPesanan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label labelLogo;
        private Label labelBeranda;
        private Label labelPesanLaundry;
        private Label labelLacakCucian;
        private Label labelPelanggan;
        private LinkLabel linkLabelKeluar;
        private Label labelLangkah;
        private Label labelJudul;
        private Label labelSubjudul;
        private Panel panelCuciKiloan;
        private RadioButton radioButtonCuciKiloan;
        private Label labelNamaCuciKiloan;
        private Label labelDeskripsiCuciKiloan;
        private Label labelEstimasiCuciKiloan;
        private Label labelHargaCuciKiloan;
        private Panel panelCuciSetrika;
        private RadioButton radioButtonCuciSetrika;
        private Label labelNamaCuciSetrika;
        private Label labelPalingPopuler;
        private Label labelDeskripsiCuciSetrika;
        private Label labelEstimasiCuciSetrika;
        private Label labelHargaCuciSetrika;
        private Panel panelExpress24Jam;
        private RadioButton radioButtonExpress24Jam;
        private Label labelNamaExpress24Jam;
        private Label labelDeskripsiExpress24Jam;
        private Label labelEstimasiExpress24Jam;
        private Label labelHargaExpress24Jam;
        private Panel panelSatuan;
        private RadioButton radioButtonSatuan;
        private Label labelNamaSatuan;
        private Label labelDeskripsiSatuan;
        private Label labelEstimasiSatuan;
        private Label labelHargaSatuan;
        private Label labelJudulJumlahCucian;
        private Panel panelJumlahCucian;
        private Label labelPerkiraanBerat;
        private Label labelKeteranganBerat;
        private Button buttonKurang;
        private Label labelBeratKilogram;
        private Button buttonTambah;
        private Label labelJudulLayananTambahan;
        private Panel panelJemputAntar;
        private CheckBox checkBoxJemputAntar;
        private Label labelKeteranganJemputAntar;
        private Label labelHargaJemputAntar;
        private Panel panelPewangiPremium;
        private CheckBox checkBoxPewangiPremium;
        private Label labelKeteranganPewangiPremium;
        private Label labelHargaPewangiPremium;
        private Panel panelPisahkanPakaianPutih;
        private CheckBox checkBoxPisahkanPakaianPutih;
        private Label labelKeteranganPisahkanPakaianPutih;
        private Label labelHargaPisahkanPakaianPutih;
        private Panel panelRingkasanPesanan;
        private Label labelJudulRingkasan;
        private Label labelRingkasanNamaPaket;
        private Label labelRingkasanRincianPaket;
        private Label labelRingkasanHargaPaket;
        private Label labelRingkasanJemputAntar;
        private Label labelRingkasanHargaJemputAntar;
        private Panel panelGarisPemisah;
        private Label labelKeteranganTotal;
        private Label labelTotalHarga;
        private Label labelCatatanHarga;
        private Button buttonLanjutKePenjemputan;
    }
}