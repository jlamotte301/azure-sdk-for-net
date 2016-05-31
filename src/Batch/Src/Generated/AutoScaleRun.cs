//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The results and errors from an evaluation or execution of a pool autoscale formula.
    /// </summary>
    public partial class AutoScaleRun : IPropertyMetadata
    {
        private readonly AutoScaleRunError error;
        private readonly string results;
        private readonly DateTime timestamp;

        #region Constructors

        internal AutoScaleRun(Models.AutoScaleRun protocolObject)
        {
            this.error = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Error, o => new AutoScaleRunError(o).Freeze());
            this.results = protocolObject.Results;
            this.timestamp = protocolObject.Timestamp;
        }

        #endregion Constructors

        #region AutoScaleRun

        /// <summary>
        /// Gets details of the error encountered evaluating the autoscale formula on the pool, if the evaluation was unsuccessful.
        /// </summary>
        public AutoScaleRunError Error
        {
            get { return this.error; }
        }

        /// <summary>
        /// Gets the final values of all variables used in the evaluation of the autoscale formula. Each variable value is 
        /// returned in the form $variable=value, and variables are separated by semicolons.
        /// </summary>
        public string Results
        {
            get { return this.results; }
        }

        /// <summary>
        /// Gets the time at which the autoscale formula was last evaluated.
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp; }
        }

        #endregion // AutoScaleRun

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}