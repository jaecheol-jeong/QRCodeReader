using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace QRCodeReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "QR �ڵ� �̹��� ����";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // ���õ� �̹����� PictureBox�� �ε�
                        pbQRCodeImage.Image = new Bitmap(openFileDialog.FileName);

                        // QR �ڵ� ���ڵ� �õ�
                        // Bitmap�� ���� Decode �޼��忡 ����
                        DecodeQRCode(new Bitmap(openFileDialog.FileName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("�̹����� �ε��ϴ� �� ������ �߻��߽��ϴ�: " + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DecodeQRCode(Bitmap barcodeBitmap)
        {
            // BarcodeReader �ν��Ͻ� ���� (���⼭�� �� �̻� Bitmap�� �����ڿ� �������� �ʽ��ϴ�.)
            var reader = new BarcodeReader(); // �⺻ �����ڸ� ����մϴ�.

            // ���ڵ� �ɼ� ���� (�� �κ��� ������ �����ϰ� BarcodeReader �ν��Ͻ��� �Ӽ����� ����)
            reader.AutoRotate = true; // �̹��� �ڵ� ȸ�� �õ�
            //reader.TryHarder = true; // �� ���� ������ Ž���Ͽ� �νķ��� �������� �ð��� �� �ɸ� �� �ֽ��ϴ�.
            reader.Options = new DecodingOptions
            {
                PossibleFormats = new BarcodeFormat[] { BarcodeFormat.QR_CODE } // QR �ڵ常 �ν��ϵ��� ����
            };

            // �̹������� QR �ڵ� ���ڵ�
            // Decode �޼��忡 Bitmap ��ü�� ���� �����մϴ�.
            Result result = reader.Decode(barcodeBitmap);

            // ��� ǥ��
            if (result != null)
            {
                txtResult.Text = "���������� ���ڵ��Ǿ����ϴ�:\r\n" + result.Text;
            }
            else
            {
                txtResult.Text = "QR �ڵ带 ã�� �� ���ų� ���ڵ��� �����߽��ϴ�.";
            }
        }
    }
}
