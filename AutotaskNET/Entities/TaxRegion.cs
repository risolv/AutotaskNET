﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The TaxRegion entity describes a geographic area where billing items have the same tax rate.<br />
    /// The TaxRegion together with the TaxCategory determine the total tax charged to customers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaxRegion : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string Name { get; set; } //Required Length:200

        #endregion //Required Fields

        #region Optional Fields

        public bool? Active { get; set; }

        #endregion //Optional Fields
        
    } //end TaxRegion

}