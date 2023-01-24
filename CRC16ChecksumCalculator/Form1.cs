namespace CRC16ChecksumCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string input = txtTID.Text.Replace(" ", "") + txtEPC.Text.Replace(" ", "");
            var bytes = HexToBytes(input);
            string hex = Crc16.ComputeChecksum(bytes).ToString("x2");
            txtResult.Text = txtEPC.Text + " " + hex;
            txtChecksum.Text = hex;
                }
        static byte[] HexToBytes(string input)
        {
            byte[] result = new byte[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }

        public static class Crc16
        {
            const ushort polynomial = 0xA001;
            static readonly ushort[] table = new ushort[256];

            public static ushort ComputeChecksum(byte[] bytes)
            {
                ushort crc = 0;
                for (int i = 0; i < bytes.Length; ++i)
                {
                    byte index = (byte)(crc ^ bytes[i]);
                    crc = (ushort)((crc >> 8) ^ table[index]);
                }
                return crc;
            }

            static Crc16()
            {
                ushort value;
                ushort temp;
                for (ushort i = 0; i < table.Length; ++i)
                {
                    value = 0;
                    temp = i;
                    for (byte j = 0; j < 8; ++j)
                    {
                        if (((value ^ temp) & 0x0001) != 0)
                        {
                            value = (ushort)((value >> 1) ^ polynomial);
                        }
                        else
                        {
                            value >>= 1;
                        }
                        temp >>= 1;
                    }
                    table[i] = value;
                }
            }
        }
    }
}