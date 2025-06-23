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
                openFileDialog.Title = "QR 코드 이미지 선택";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 선택된 이미지를 PictureBox에 로드
                        pbQRCodeImage.Image = new Bitmap(openFileDialog.FileName);

                        // QR 코드 디코딩 시도
                        // Bitmap을 직접 Decode 메서드에 전달
                        DecodeQRCode(new Bitmap(openFileDialog.FileName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("이미지를 로드하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DecodeQRCode(Bitmap barcodeBitmap)
        {
            // BarcodeReader 인스턴스 생성 (여기서는 더 이상 Bitmap을 생성자에 전달하지 않습니다.)
            var reader = new BarcodeReader(); // 기본 생성자를 사용합니다.

            // 디코딩 옵션 설정 (이 부분은 이전과 동일하게 BarcodeReader 인스턴스에 속성으로 설정)
            reader.AutoRotate = true; // 이미지 자동 회전 시도
            //reader.TryHarder = true; // 더 많은 패턴을 탐색하여 인식률을 높이지만 시간이 더 걸릴 수 있습니다.
            reader.Options = new DecodingOptions
            {
                PossibleFormats = new BarcodeFormat[] { BarcodeFormat.QR_CODE } // QR 코드만 인식하도록 지정
            };

            // 이미지에서 QR 코드 디코딩
            // Decode 메서드에 Bitmap 객체를 직접 전달합니다.
            Result result = reader.Decode(barcodeBitmap);

            // 결과 표시
            if (result != null)
            {
                txtResult.Text = "성공적으로 디코딩되었습니다:\r\n" + result.Text;
            }
            else
            {
                txtResult.Text = "QR 코드를 찾을 수 없거나 디코딩에 실패했습니다.";
            }
        }
    }
}
