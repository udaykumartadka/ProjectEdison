﻿using System;

namespace Edison.DeviceProvisioning.Models
{
    public class DeviceSecretKeysCreationModel
    {
        public Guid DeviceId { get; set; }
        public string AccessPointPassword { get; set; }
        public string PortalPassword { get; set; }
        public string EncryptionKey { get; set; }
    }
}
