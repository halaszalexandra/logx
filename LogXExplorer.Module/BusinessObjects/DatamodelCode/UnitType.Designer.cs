﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LogXExplorer.Module.BusinessObjects.Database
{

    public partial class UnitType : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        [Association(@"ProductReferencesUnitType")]
        public XPCollection<Product> Products { get { return GetCollection<Product>(nameof(Products)); } }
        [Association(@"QtyExchangeReferencesUnitType")]
        public XPCollection<QtyExchange> QtyExchanges { get { return GetCollection<QtyExchange>(nameof(QtyExchanges)); } }
    }

}