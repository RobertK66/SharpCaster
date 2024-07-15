﻿using Sharpcaster.Messages.Chromecast;
using Sharpcaster.Models.MultiZone;
using System.Runtime.Serialization;

namespace Sharpcaster.Messages.Multizone
{
    /// <summary>
    /// Media status message
    /// </summary>
    [DataContract]
    [ReceptionMessage]
    public class MultizoneStatusMessage : StatusMessage<MultiZoneStatus>
    {
    }
}
