using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Q42.HueApi;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.Interfaces;

namespace Andriks.HueApiDemo
{
    public partial class LightControl : UserControl
    {
        #region Private variables

        private ILocalHueClient client = null;
        private Light light = null;

        #endregion Private variables

        /// <summary>
        /// Create a new control.
        /// </summary>
        public LightControl()
        {
            InitializeComponent();
        }

        #region Public methods and properties

        /// <summary>
        /// The client for sending commands to.
        /// </summary>
        public ILocalHueClient Client
        {
            get { return client; }
            set { client = value; }
        }


        /// <summary>
        /// The light to control from this instance.
        /// </summary>
        public Light Light
        {
            get { return light; }
            set
            {
                light = value;

                if (light == null)
                    labelInfo.Text = "";
                else
                {
                    string mask = Properties.Settings.Default.LocationDisplayMask;
                    labelInfo.Text = String.Format(mask, Light.Id, light.Name, light.Config.ArcheType);
                }
                Resync();
            }
        }

        /// <summary>
        /// Synchronize displayed values with actual values.
        /// </summary>
        public void Resync()
        {
            // disable all controls
            panelBrightness.Enabled = trackBarBrightness.Enabled =
                labelBrightness.Enabled = labelB0.Enabled =
                labelB254.Enabled = false;
            panelColTemp.Enabled = trackBarColTemp.Enabled =
                labelColTemp.Enabled = labelCTCool.Enabled = labelCTWarm.Enabled = false;
            panelHue.Enabled = trackBarHue.Enabled =
                labelHue.Enabled = false;

            if (light != null)
            {
                // On / off
                checkBoxOn.Checked = light.State.On;

                // Brightness (if dimmable)
                if (light.State.Brightness < 255)
                {
                    panelBrightness.Enabled = trackBarBrightness.Enabled =
                        labelBrightness.Enabled = labelB0.Enabled = labelB254.Enabled = true;

                    trackBarBrightness.Value = light.State.Brightness;
                }

                // Colour mode
                if (light.State.ColorMode != null)
                {
                    if (light.State.ColorMode.Equals("ct", StringComparison.InvariantCultureIgnoreCase))
                    {
                        panelColTemp.Enabled = trackBarColTemp.Enabled =
                            labelColTemp.Enabled = labelCTCool.Enabled = labelCTWarm.Enabled = true;

                        trackBarColTemp.Value =
                        trackBarColTemp.Minimum = light.Capabilities.Control.ColorTemperature.Min;
                        trackBarColTemp.Maximum = light.Capabilities.Control.ColorTemperature.Max;
                        if (light.State.ColorTemperature.HasValue)
                            trackBarColTemp.Value = light.State.ColorTemperature.Value;
                    }
                    else if (light.State.ColorMode.Equals("??", StringComparison.InvariantCultureIgnoreCase))
                    {
                        panelHue.Enabled = trackBarHue.Enabled =
                            labelHue.Enabled = true;

                        trackBarHue.Value = 0;
                        trackBarHue.Minimum = 0;
                        trackBarHue.Maximum = HSB.HueMaxValue;
                        if (light.State.Hue.HasValue)
                            trackBarHue.Value = light.State.Hue.Value;
                    }
                }
            }
        }

        #endregion Public methods and properties

        #region Private methods

        private async void checkBoxOn_CheckedChanged(object sender, EventArgs e)
        {
            if ((client != null) && (light != null))
            {
                try
                {
                    LightCommand cmd = new LightCommand();
                    cmd.On = checkBoxOn.Checked;
                    if (trackBarBrightness.Enabled) cmd.Brightness = (byte)trackBarBrightness.Value;
                    if (trackBarColTemp.Enabled) cmd.ColorTemperature = (int)trackBarColTemp.Value;
                    if (trackBarHue.Enabled) cmd.Hue = (int)trackBarHue.Value;
                    await client.SendCommandAsync(cmd, new List<string> { light.Id });
                }
                catch (Q42.HueApi.HueException) { }
            }
        }

        private async void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            if ((client != null) && (light != null))
            {
                try
                {
                    LightCommand cmd = new LightCommand();
                    cmd.Brightness = (byte)trackBarBrightness.Value;
                    await client.SendCommandAsync(cmd, new List<string> { light.Id });
                }
                catch (Q42.HueApi.HueException) { }
            }
        }

        private async void trackBarColTemp_ValueChanged(object sender, EventArgs e)
        {
            if ((client != null) && (light != null))
            {
                try
                {
                    LightCommand cmd = new LightCommand();
                    cmd.ColorTemperature = (int)trackBarColTemp.Value;
                    await client.SendCommandAsync(cmd, new List<string> { light.Id });
                }
                catch (Q42.HueApi.HueException) { }
            }
        }

        private async void trackBarHue_ValueChanged(object sender, EventArgs e)
        {
            if ((client != null) && (light != null))
            {
                try
                {
                    LightCommand cmd = new LightCommand();
                    cmd.Hue = (int)trackBarHue.Value;
                    await client.SendCommandAsync(cmd, new List<string> { light.Id });
                }
                catch (Q42.HueApi.HueException) { }
            }
        }

        #endregion Private methods
    }
}
