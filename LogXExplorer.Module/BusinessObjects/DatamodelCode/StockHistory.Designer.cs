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

    public partial class StockHistory : XPObject
    {
        Product fProduct;
        [Association(@"StockHistoryReferencesProduct")]
        public Product Product
        {
            get { return fProduct; }
            set { SetPropertyValue<Product>(nameof(Product), ref fProduct, value); }
        }
        LoadCarrier fLC;
        [Association(@"StockHistoryReferencesLoadCarrier")]
        public LoadCarrier LC
        {
            get { return fLC; }
            set { SetPropertyValue<LoadCarrier>(nameof(LC), ref fLC, value); }
        }
        string fSection;
        public string Section
        {
            get { return fSection; }
            set { SetPropertyValue<string>(nameof(Section), ref fSection, value); }
        }
        DateTime fTime;
        public DateTime Time
        {
            get { return fTime; }
            set { SetPropertyValue<DateTime>(nameof(Time), ref fTime, value); }
        }
        int fType;
        public int Type
        {
            get { return fType; }
            set { SetPropertyValue<int>(nameof(Type), ref fType, value); }
        }
        int fDirection;
        public int Direction
        {
            get { return fDirection; }
            set { SetPropertyValue<int>(nameof(Direction), ref fDirection, value); }
        }
        double fQuantity;
        public double Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<double>(nameof(Quantity), ref fQuantity, value); }
        }
        double fResentQty;
        public double ResentQty
        {
            get { return fResentQty; }
            set { SetPropertyValue<double>(nameof(ResentQty), ref fResentQty, value); }
        }
        CommonTrDetail fCommonDetail;
        [Association(@"StockHistoryReferencesCommonTrDetail")]
        public CommonTrDetail CommonDetail
        {
            get { return fCommonDetail; }
            set { SetPropertyValue<CommonTrDetail>(nameof(CommonDetail), ref fCommonDetail, value); }
        }
        bool fProcessed;
        public bool Processed
        {
            get { return fProcessed; }
            set { SetPropertyValue<bool>(nameof(Processed), ref fProcessed, value); }
        }
        bool fBooked;
        public bool Booked
        {
            get { return fBooked; }
            set { SetPropertyValue<bool>(nameof(Booked), ref fBooked, value); }
        }
    }

}