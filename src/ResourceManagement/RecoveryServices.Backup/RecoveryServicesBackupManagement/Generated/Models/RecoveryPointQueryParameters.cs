// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The query filters that can be used with the list recovery points API.
    /// </summary>
    public partial class RecoveryPointQueryParameters
    {
        private string _endDate;
        
        /// <summary>
        /// Optional. Recovery points should have been created before this date.
        /// </summary>
        public string EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }
        
        private string _startDate;
        
        /// <summary>
        /// Optional. Recovery points should have been created after this date.
        /// </summary>
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryPointQueryParameters
        /// class.
        /// </summary>
        public RecoveryPointQueryParameters()
        {
        }
    }
}
