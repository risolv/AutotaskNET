﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes Price List information associated with a Material type AllocationCode.<br />
    /// <br />
    /// Price List information for Products, Services, Materials, and Labor(Work Types and Roles) is set up and managed in Autotask on the Price List page: from the Autotask menu select Admin > Features & Settings > Finance, Accounting, & Invoicing > Price List
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity"/>
    class PriceListMaterialCode : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PriceListMaterialCode() : base() { } //end PriceListMaterialCode()
        public PriceListMaterialCode(net.autotask.webservices.PriceListMaterialCode entity) : base(entity)
        {

        } //end PriceListMaterialCode(net.autotask.webservices.PriceListMaterialCode entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int AllocationCodeID { get; set; } //ReadOnly Required [AllocationCode]
        public int CurrencyID { get; set; } //ReadOnly Required [Currency]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public bool UsesInternalCurrencyPrice { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public decimal UnitPrice { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end PriceListMaterialCode

}
