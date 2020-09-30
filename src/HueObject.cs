using System;
using System.Collections.Generic;
using Q42.HueApi;

namespace Andriks.HueApiDemo
{
    /// <summary>
    /// Class to buffer info and to have one item for all 'things' that contain <see cref="42.HueApi.Light"/>s.
    /// </summary>
    public class HueObject
    {
        private string id;
        private bool isBridge = false;
        private bool isGroup = false;
        private bool isLight = false;
        private string name;
        private List<string> lightIDs;
        private object value;

        /// <summary>
        /// Create a new information object.
        /// </summary>
        /// <param name="infoObject">Either a <see cref="Q42.HueApi.Light"/> or a <see cref="Q42.HueApi.Models.Groups.Group"/></param>
        public HueObject(object infoObject)
        {
            if (infoObject.GetType() == typeof(Q42.HueApi.Bridge))
            {
                Bridge bridge = (Q42.HueApi.Bridge)infoObject;
                BridgeConfig config = bridge.Config;
                if (config == null)
                {
                    id = "-1";
                    name = "Bridge";
                }
                else
                {
                    id = config.BridgeId;
                    name = config.Name;
                }
                isBridge = true;
                lightIDs = new List<string>();
                value = infoObject;
            }
            else if (infoObject.GetType() == typeof(Q42.HueApi.Light))
            {
                Q42.HueApi.Light light = (Q42.HueApi.Light)infoObject;
                id = light.Id;
                name = light.Name;
                isLight = true;
                lightIDs = new List<string> { id };
                value = infoObject;
            }
            else if (infoObject.GetType() == typeof(Q42.HueApi.Models.Groups.Group))
            {
                Q42.HueApi.Models.Groups.Group grp = (Q42.HueApi.Models.Groups.Group)infoObject;
                id = grp.Id;
                name = grp.Name;
                isGroup = true;
                lightIDs = grp.Lights;
                value = infoObject;
            }
            else
            {
                throw new ArgumentException("Argument should be either Bridge, Group or Light.", "infoObject");
            }
        }


        /// <summary>
        /// The ID of the group or light.
        /// </summary>
        public string ID { get { return id; } }


        /// <summary>
        /// Is the type 'Bridge'?
        /// </summary>
        public bool IsBridge { get { return isBridge; } }


        /// <summary>
        /// Is the type 'Group'?
        /// </summary>
        public bool IsGroup { get { return isGroup; } }


        /// <summary>
        /// Is the type 'Light'?
        /// </summary>
        public bool IsLight { get { return isLight; } }


        /// <summary>
        /// The ID of the lights in the "group".
        /// </summary>
        public List<string> LightIDs { get { return lightIDs; } }


        /// <summary>
        /// The name of the bridge, group or light.
        /// </summary>
        public string Name { get { return name; } }


        /// <summary>
        /// The underlying object.
        /// </summary>
        public object Value { get { return value; } }


        /// <summary>
        /// For ease of use on listboxes, etc. returns id + name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}: {1}", id, name);
        }
    }
}
