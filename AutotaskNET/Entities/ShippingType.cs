﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Shipping Type. A Shipping Type defines a carrier for a product shipment and can be associated with a Quote entity.<br />
    /// <br />
    /// In Autotask, Shipping Types are set up in the Admin module and added to a Quote in the CRM module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ShippingType : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public string Name { get; set; } //ReadOnly Length:100
        public bool? IsActive { get; set; } //ReadOnly
        public string Description { get; set; } //ReadOnly Length:2000
        public int? AllocationCodeID { get; set; } //ReadOnly [AllocationCode]

        #endregion //ReadOnly Fields
        
    } //end ShippingType

}