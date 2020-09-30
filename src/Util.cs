//
// Utility methods and small helper classes.
//
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using Q42.HueApi.Models.Groups;

namespace Andriks.HueApiDemo
{
    #region decrapated
    /*
    /// <summary>
    /// Helper class to encapsulate bridge info. Can be removed if future versions of the library
    /// override the ToString method too.
    /// </summary>
    internal class BridgeDisplay
    {
        /// <summary>
        /// Create a new BridgeDisplay object.
        /// </summary>
        /// <param name="bridge">The located bridge.</param>
        public BridgeDisplay(LocatedBridge bridge)
        {
            Bridge = bridge;
        }

        /// <summary>
        /// The encapsulated bridge.
        /// </summary>
        public LocatedBridge Bridge;

        /// <summary>
        /// A string representation of the bridge.
        /// </summary>
        public override string ToString()
        {
            if (Bridge == null)
                return base.ToString();
            else
                return String.Format("Bridge {0} at {1}", Bridge.BridgeId, Bridge.IpAddress);
        }
    }

    */
    #endregion decrapated

    /// <summary>
    /// Helper class with internal static methods.
    /// </summary>
    internal static class Util
    {
        // Used to encrypt/decrypt. Do not change after first use!
        private const string keyPhrase = "Errro: cannot determine type of the lamp. The returned value is {0}";
        private const string ivPhrase = "Error: ID André.";
        private const int tabSize = 4;

        #region Public functions

        /// <summary>
        /// Check if a certain 'user' is already a registered user of the bridge.
        /// </summary>
        /// <param name="bridge">The bridge for which to check.</param>
        /// <param name="appKey">The appkey for the user.</param>
        /// <returns></returns>
        public async static Task<bool> ClientAlreadyRegistered(LocatedBridge bridge,
                                                               string appKey)
        {
            ILocalHueClient client = null;
            try
            {
                // see if initialized
                if ((bridge == null) || String.IsNullOrEmpty(appKey)) return false;
                client = new LocalHueClient(bridge.IpAddress);
                client.Initialize(appKey);
                // Only initializing is not enough to check the appKey, so check:
                bool isConnected = await client.CheckConnection();
                return isConnected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Something went while connecting. The error was '{0}'.",
                                              ex.Message),
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// Create textual multiline information with most of a bridge's properties.
        /// </summary>
        /// <param name="bridge">The bridge for which to return information.</param>
        /// <param name="nrTabs">The initial number of tabs to use for indentation.</param>
        /// <returns></returns>
        public static string CreateBridgeInfo(Bridge bridge, int nrTabs)
        {
            string tabs = new String(' ', nrTabs * tabSize);
            StringBuilder sb = new StringBuilder();
            if (bridge != null)
            {
                sb.AppendLine(String.Format("{0}Bridge:", tabs));
                BridgeConfig config = bridge.Config;
                if (config != null)
                {
                    tabs = new String(' ', (nrTabs + 1) * tabSize);
                    sb.AppendLine(String.Format("{0}ID              : {1}", tabs, config.BridgeId));
                    sb.AppendLine(String.Format("{0}Name            : {1}", tabs, config.Name));
                    sb.AppendLine();
                    sb.AppendLine(String.Format("{0}IP address      : {1}", tabs, config.IpAddress));
                    sb.AppendLine(String.Format("{0}Gateway         : {1}", tabs, config.Gateway));
                    sb.AppendLine(String.Format("{0}DHCP            : {1}", tabs, config.Dhcp));
                    sb.AppendLine(String.Format("{0}NetMask         : {1}", tabs, config.NetMask));
                    sb.AppendLine(String.Format("{0}Portal connect  : {1}", tabs, config.PortalConnection));
                    sb.AppendLine(String.Format("{0}Zigbee channel  : {1}", tabs, config.ZigbeeChannel));
                    sb.AppendLine();
                    sb.AppendLine(String.Format("{0}Api version     : {1}", tabs, config.ApiVersion));
                    sb.AppendLine(String.Format("{0}SoftwareVersion : {1}", tabs, config.SoftwareVersion));
                    sb.AppendLine(String.Format("{0}DS version      : {1}", tabs, config.DataStoreVersion));
                    sb.AppendLine(String.Format("{0}Model           : {1}", tabs, config.ModelId));
                    sb.AppendLine(String.Format("{0}FactoryNew      : {1}", tabs, config.FactoryNew));
                    sb.AppendLine(String.Format("{0}Time zone       : {1}", tabs, config.TimeZone));
                    if (config.Utc.HasValue) sb.AppendLine(String.Format("{0}Date/time UTC   : {1}", tabs, ((DateTime)(config.Utc.Value)).ToString("yyyy-MM-dd HH:mm:ss")));
                    sb.AppendLine();
                }
                if (bridge.WhiteList != null)
                {
                    sb.AppendLine(String.Format("{0}White list", tabs));
                    List<WhiteList> whiteLst = (List<WhiteList>)bridge.WhiteList;
                    foreach (WhiteList w in whiteLst)
                    {
                        sb.AppendLine(String.Format("{0}  ID              : {1}", tabs, w.Id));
                        sb.AppendLine(String.Format("{0}  Name            : {1}", tabs, w.Name));
                    }
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }


        /// <summary>
        /// Create textual multiline information with most of a group's properties.
        /// </summary>
        /// <param name="group">The group for which to return information.</param>
        /// <param name="nrTabs">The initial number of tabs to use for indentation.</param>
        /// <returns></returns>
        public static string CreateGroupInfo(Group group, int nrTabs)
        {
            string tabs = new String(' ', nrTabs * tabSize);
            StringBuilder sb = new StringBuilder();
            if (group != null)
            {
                sb.AppendLine(String.Format("{0}Group:", tabs));
                tabs = new String(' ', (nrTabs + 1) * tabSize);
                sb.AppendLine(String.Format("{0}ID              : {1}", tabs, group.Id));
                sb.AppendLine(String.Format("{0}Name            : {1}", tabs, group.Name));
                if (group.Type.HasValue)
                    sb.AppendLine(String.Format("{0}Type            : {1}", tabs, group.Type));
                if (group.Class.HasValue)
                    sb.AppendLine(String.Format("{0}Class           : {1}", tabs, group.Class));
                sb.AppendLine(String.Format("{0}State all on    : {1}", tabs, group.State.AllOn));
                sb.AppendLine(String.Format("{0}State any on    : {1}", tabs, group.State.AnyOn));
                if ((group.Lights != null) && (group.Lights.Count > 0))
                {
                    StringBuilder sb2 = new StringBuilder();
                    sb2.AppendFormat("{0}Lights in group : ", tabs);
                    foreach (string lightID in group.Lights)
                    {
                        sb2.Append(String.Format("{0}  ", lightID));
                    }
                    sb.AppendLine(sb2.ToString());
                }
                if ((group.Sensors != null) && (group.Sensors.Count > 0))
                {
                    StringBuilder sb2 = new StringBuilder();
                    sb2.AppendFormat("{0}Sensors in group : ", tabs);
                    foreach (string sensorID in group.Lights)
                    {
                        sb2.Append(String.Format("{0}  ", sensorID));
                    }
                    sb.AppendLine(sb2.ToString());
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }


        /// <summary>
        /// Create textual multiline information with most of a light's properties.
        /// </summary>
        /// <param name="light">The light for which to return information.</param>
        /// <param name="nrTabs">The initial number of tabs to use for indentation.</param>
        /// <returns></returns>
        public static string CreateLightInfo(Light light, int nrTabs)
        {
            string tabs = new String(' ', nrTabs * tabSize);
            StringBuilder sb = new StringBuilder();
            if (light != null)
            {
                sb.AppendLine(String.Format("{0}Light:", tabs));
                tabs = new String(' ', (nrTabs + 1) * tabSize);
                sb.AppendLine(String.Format("{0}ID              : {1}", tabs, light.Id));
                sb.AppendLine(String.Format("{0}Name            : {1}", tabs, light.Name));
                sb.AppendLine(String.Format("{0}Manufacturer    : {1}", tabs, light.ManufacturerName));
                sb.AppendLine(String.Format("{0}Light type      : {1}", tabs, light.Type));
                sb.AppendLine(String.Format("{0}Light state     : ", tabs));
                if (light.State != null)
                {
                    sb.AppendLine(String.Format("{0}  Brightness    : {1}", tabs, light.State.Brightness));
                    sb.AppendLine(String.Format("{0}  Colour-mode   : {1}", tabs, light.State.ColorMode));
                    if (light.State.ColorTemperature.HasValue)
                        sb.AppendLine(String.Format("{0}  Colour temp.  : {1}", tabs, light.State.ColorTemperature));
                    if (light.State.Hue.HasValue)
                        sb.AppendLine(String.Format("{0}  Hue           : {1}", tabs, light.State.Hue));
                    sb.AppendLine(String.Format("{0}  Mode          : {1}", tabs, light.State.Mode));
                    sb.AppendLine(String.Format("{0}  On            : {1}", tabs, light.State.On));
                    if (light.State.Saturation.HasValue)
                        sb.AppendLine(String.Format("{0}  Saturation  : {0}", tabs, light.State.Saturation));
                    if (light.State.TransitionTime.HasValue)
                        sb.AppendLine(String.Format("{0}  Transition  : {0:0.00}", tabs, light.State.TransitionTime.Value.TotalSeconds));
                }
                if (light.Config != null)
                {
                    sb.AppendLine(String.Format("{0}Light configuration", tabs));
                    sb.AppendLine(String.Format("{0}  ArcheType     : {1}", tabs, light.Config.ArcheType));
                    sb.AppendLine(String.Format("{0}  Direction     : {1}", tabs, light.Config.Direction));
                    sb.AppendLine(String.Format("{0}  Function      : {1}", tabs, light.Config.Function));
                    if (light.Config.Startup != null)
                    {
                        if (light.Config.Startup.Configured.HasValue)
                            sb.AppendLine(String.Format("{0}  Startup config: {1}", tabs, light.Config.Startup.Configured));
                        if (light.Config.Startup.Mode.HasValue)
                            sb.AppendLine(String.Format("{0}  Startup mode  : {1}", tabs, light.Config.Startup.Mode.Value));
                    }
                }
                if (light.Capabilities != null)
                {
                    sb.AppendLine(String.Format("{0}Light capabilities", tabs));
                    sb.AppendLine(String.Format("{0}  Certified     : {1}", tabs, light.Capabilities.Certified));
                    if (light.Capabilities.Control != null)
                    {
                        sb.AppendLine(String.Format("{0}  Col gamut type: {1}", tabs, light.Capabilities.Control.ColorGamutType));
                        if (light.Capabilities.Control.ColorTemperature != null)
                            sb.AppendLine(String.Format("{0}  Colour temp.  : {1} - {2}", tabs,
                                light.Capabilities.Control.ColorTemperature.Min,
                                light.Capabilities.Control.ColorTemperature.Max));
                        if (light.Capabilities.Control.MaxLumen.HasValue)
                            sb.AppendLine(String.Format("{0}  Max lumen     : {1}", tabs, light.Capabilities.Control.MaxLumen));
                        if (light.Capabilities.Control.MinDimLevel.HasValue)
                            sb.AppendLine(String.Format("{0}  Min dim level : {1}", tabs, light.Capabilities.Control.MinDimLevel));

                    }
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }


        /// <summary>
        /// Decrypt a string.
        /// </summary>
        /// <param name="cipherText">Encrypted string.</param>
        /// <returns>Plaintext string.</returns>
        public static string DecryptString(string cipherText)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");


            byte[] iv = getValues(ivPhrase, 16);
            byte[] key = getValues(keyPhrase, 32);
            byte[] encrypted = Convert.FromBase64String(cipherText);
            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AES object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(encrypted))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    // Read the decrypted bytes from the decrypting stream
                    // and place them in a string.
                    plaintext = srDecrypt.ReadToEnd();
                }
            }
            return plaintext;
        }


        /// <summary>
        /// Encrypt a string.
        /// </summary>
        /// <param name="plainText">Plaintext string.</param>
        /// <returns>Encrypted string.</returns>
        public static string EncryptString(string plainText)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");

            byte[] iv = getValues(ivPhrase, 16);
            byte[] key = getValues(keyPhrase, 32);
            byte[] encrypted;

            // Create an AES object with the specified key and IV.

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                    string x = msEncrypt.ToString();
                }
            }
            // Return the encrypted bytes from the memory stream as a string.
            return Convert.ToBase64String(encrypted);
        }

        #region Bitmap creation code.

        /// <summary>
        /// Create a brightness bitmap. Used to fabricate the png files used in the LightControl. I left it
        /// in, so you can generate new files easily (with different dimensions if you wish).
        /// </summary>
        public static void PaintBrightness()
        {
            Bitmap bmp = new Bitmap(290, 25);
            Graphics gr = Graphics.FromImage(bmp);
            int start;
            gr.Clear(Color.Transparent);
            for (int h = 0; h < bmp.Width; h++)
            {
                start = (int)(bmp.Height * (1.0 - 1.0 * h / bmp.Width));
                using (Pen p = new Pen(Color.Yellow))
                    gr.DrawLine(p, h, start, h, bmp.Height);
            }
            bmp.Save("brightness.png");
        }

        /// <summary>
        /// Create a colour temperature bitmap. Used to fabricate the png files used in the LightControl. I left it
        /// in, so you can generate new files easily (with different dimensions if you wish).
        /// </summary>
        public static void PaintCT()
        {
            Bitmap bmp = new Bitmap(290, 25);
            Graphics gr = Graphics.FromImage(bmp);
            Color cMin, cMax, c;
            cMin = Color.LightBlue;
            cMax = Color.FromArgb(255, 255, 192);
            double dR = cMax.R - cMin.R;
            double dG = cMax.G - cMin.G;
            double dB = cMax.B - cMin.B;
            double f;
            int r, g, b;
            for (int h = 0; h < bmp.Width; h++)
            {
                f = 1.0 * h / bmp.Width;
                r = (int)(cMin.R + dR * f);
                g = (int)(cMin.G + dG * f);
                b = (int)(cMin.B + dB * f);
                c = Color.FromArgb(r, g, b);
                using (Pen p = new Pen(c))
                    gr.DrawLine(p, h, 0, h, bmp.Height);
            }
            bmp.Save("ct.png");
        }

        /// <summary>
        /// Create a hue bitmap. Used to fabricate the png files used in the LightControl. I left it
        /// in, so you can generate new files easily (with different dimensions if you wish).
        /// </summary>
        public static void PaintHue()
        {
            Bitmap bmp = new Bitmap(290, 25);
            Graphics gr = Graphics.FromImage(bmp);
            RGBColor rgbC = new RGBColor(0, 0, 0);
            HSB hsb = new HSB(0, 255, 255);
            Color c;
            int hue;
            for (int h = 0; h < bmp.Width; h++)
            {
                hue = (int)(HSB.HueMaxValue * 1.0 * h / bmp.Width);
                hsb.Hue = hue;
                rgbC = hsb.GetRGB();
                c = fromRGB(rgbC);
                using (Pen p = new Pen(c))
                    gr.DrawLine(p, h, 0, h, bmp.Height);
            }
            bmp.Save("hue.png");
        }

        #endregion Bitmap creation code.

        #endregion Public functions

        #region Private methods

        private static byte[] getValues(string phrase, int max)
        {
            byte[] rv = new byte[max];
            byte[] ib = Encoding.ASCII.GetBytes(phrase);
            for (int i = 0; i < max; i++)
            {
                if (i < ib.Length)
                    rv[i] = ib[i];
                else
                    // complete to desired bytes in length
                    rv[i] = (byte)i;
            }
            return rv;
        }

        private static RGBColor fromColor(Color c)
        {
            double r, g, b;
            r = c.R / 255.0;
            g = c.G / 255.0;
            b = c.B / 255.0;
            return new RGBColor(r, g, b);
        }

        private static Color fromRGB(RGBColor rgb)
        {
            int r, g, b;
            r = (int)(rgb.R * 255.0);
            g = (int)(rgb.G * 255.0);
            b = (int)(rgb.B * 255.0);
            return Color.FromArgb(r, g, b);
        }

        #endregion Private methods
    }
}
