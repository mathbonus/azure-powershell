﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using System.Collections.Generic;
using System.Xml;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Common.Authentication;
using Microsoft.Azure.Common.Authentication.Models;
using System.Threading;
using Hyak.Common;
using Microsoft.Azure.Commands.AzureBackup.Properties;
using System.Net;
using Microsoft.Azure.Commands.AzureBackup.Models;

namespace Microsoft.Azure.Commands.AzureBackup.Cmdlets
{
    public abstract class AzureRMBackupItemCmdletBase : AzureBackupCmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, HelpMessage = AzureBackupCmdletHelpMessage.AzureBackupItem, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public AzureRMBackupContainerContextObject Item { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            WriteDebug(String.Format(Resources.CmdletCalled, Item.ResourceGroupName, Item.ResourceName, Item.Location));
            InitializeAzureBackupCmdlet(Item.ResourceGroupName, Item.ResourceName);
        }
    }
}

