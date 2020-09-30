using System;
using System.Windows.Forms;

namespace Andriks.HueApiDemo
{
    public static class Tests
    {
        public static void EncryptionTest()
        {
            string encryptText;
            string plainText1, plainText2;

            // round trip encryption/decryption:

            plainText1 = "ThisIsAPlainTextMessage";
            encryptText = Util.EncryptString(plainText1);
            plainText2 = Util.DecryptString(encryptText);
            if (plainText1 != plainText2)
                MessageBox.Show(String.Format("{0}\n{1}\n{2}", encryptText, plainText1, plainText2),
                        "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            plainText1 = "WHFw9x-9xkHFYpl12cmbcatlFdBuc3xtzstOUClJ";
            encryptText = Util.EncryptString(plainText1);
            plainText2 = Util.DecryptString(encryptText);
            if (plainText1 != plainText2)
                MessageBox.Show(String.Format("{0}\n{1}\n{2}", encryptText, plainText1, plainText2),
                        "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            plainText1 = "01234567890AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            encryptText = Util.EncryptString(plainText1);
            plainText2 = Util.DecryptString(encryptText);
            if (plainText1 != plainText2)
                MessageBox.Show(String.Format("{0}\n{1}\n{2}", encryptText, plainText1, plainText2),
                        "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
