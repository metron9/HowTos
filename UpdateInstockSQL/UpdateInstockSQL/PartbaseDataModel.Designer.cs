﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 1/10/2019 4:22:29 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Reflection;
using System.Linq.Expressions;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata


#endregion

namespace CCSpecialModel
{

    #region CCSpecialEntities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CCSpecialEntities : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new CCSpecialEntities object.
        /// </summary>
        public CCSpecialEntities() : 
                base(@"name=CCSpecialEntitiesConnectionString", "CCSpecialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initializes a new CCSpecialEntities object using the connection string found in the 'CCSpecialEntities' section of the application configuration file.
        /// </summary>
        public CCSpecialEntities(string connectionString) : 
                base(connectionString, "CCSpecialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new CCSpecialEntities object.
        /// </summary>
        public CCSpecialEntities(EntityConnection connection) : base(connection, "CCSpecialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PARTBASE> PARTBASEs
        {
            get
            {
                if ((_PARTBASEs == null))
                {
                    _PARTBASEs = base.CreateObjectSet<PARTBASE>("PARTBASEs");
                }
                return _PARTBASEs;
            }
        }
        private ObjectSet<PARTBASE> _PARTBASEs;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the PARTBASEs EntitySet.
        /// </summary>
        public void AddToPARTBASEs(PARTBASE pARTBASE)
        {
            base.AddObject("PARTBASEs", pARTBASE);
        }

        #endregion
    }

    #endregion
}

namespace CCSpecialModel
{

    /// <summary>
    /// There are no comments for CCSpecialModel.PARTBASE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartBaseID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="CCSpecialModel", Name="PARTBASE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PARTBASE : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new PARTBASE object.
        /// </summary>
        /// <param name="partBaseID">Initial value of PartBaseID.</param>
        public static PARTBASE CreatePARTBASE(global::System.Guid partBaseID)
        {
            PARTBASE pARTBASE = new PARTBASE();
            pARTBASE.PartBaseID = partBaseID;
            return pARTBASE;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for JobNumber in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual global::System.Nullable<decimal> JobNumber
        {
            get
            {
                global::System.Nullable<decimal> value = _JobNumber;
                OnGetJobNumber(ref value);
                return value;
            }
            set
            {
                if (_JobNumber != value)
                {
                  OnJobNumberChanging(ref value);
                  ReportPropertyChanging("JobNumber");
                  _JobNumber = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("JobNumber");
                  OnJobNumberChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _JobNumber;
        partial void OnGetJobNumber(ref global::System.Nullable<decimal> value);
        partial void OnJobNumberChanging(ref global::System.Nullable<decimal> value);
        partial void OnJobNumberChanged();
    
        /// <summary>
        /// There are no comments for Unit in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual string Unit
        {
            get
            {
                string value = _Unit;
                OnGetUnit(ref value);
                return value;
            }
            set
            {
                if (_Unit != value)
                {
                  OnUnitChanging(ref value);
                  ReportPropertyChanging("Unit");
                  _Unit = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Unit");
                  OnUnitChanged();
              }
            }
        }
        private string _Unit;
        partial void OnGetUnit(ref string value);
        partial void OnUnitChanging(ref string value);
        partial void OnUnitChanged();
    
        /// <summary>
        /// There are no comments for PartNumber in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual string PartNumber
        {
            get
            {
                string value = _PartNumber;
                OnGetPartNumber(ref value);
                return value;
            }
            set
            {
                if (_PartNumber != value)
                {
                  OnPartNumberChanging(ref value);
                  ReportPropertyChanging("PartNumber");
                  _PartNumber = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PartNumber");
                  OnPartNumberChanged();
              }
            }
        }
        private string _PartNumber;
        partial void OnGetPartNumber(ref string value);
        partial void OnPartNumberChanging(ref string value);
        partial void OnPartNumberChanged();
    
        /// <summary>
        /// There are no comments for Description in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual string Description
        {
            get
            {
                string value = _Description;
                OnGetDescription(ref value);
                return value;
            }
            set
            {
                if (_Description != value)
                {
                  OnDescriptionChanging(ref value);
                  ReportPropertyChanging("Description");
                  _Description = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Description");
                  OnDescriptionChanged();
              }
            }
        }
        private string _Description;
        partial void OnGetDescription(ref string value);
        partial void OnDescriptionChanging(ref string value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// There are no comments for Price in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual global::System.Nullable<decimal> Price
        {
            get
            {
                global::System.Nullable<decimal> value = _Price;
                OnGetPrice(ref value);
                return value;
            }
            set
            {
                if (_Price != value)
                {
                  OnPriceChanging(ref value);
                  ReportPropertyChanging("Price");
                  _Price = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Price");
                  OnPriceChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _Price;
        partial void OnGetPrice(ref global::System.Nullable<decimal> value);
        partial void OnPriceChanging(ref global::System.Nullable<decimal> value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// There are no comments for OnShelf in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual global::System.Nullable<int> OnShelf
        {
            get
            {
                global::System.Nullable<int> value = _OnShelf;
                OnGetOnShelf(ref value);
                return value;
            }
            set
            {
                if (_OnShelf != value)
                {
                  OnOnShelfChanging(ref value);
                  ReportPropertyChanging("OnShelf");
                  _OnShelf = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("OnShelf");
                  OnOnShelfChanged();
              }
            }
        }
        private global::System.Nullable<int> _OnShelf;
        partial void OnGetOnShelf(ref global::System.Nullable<int> value);
        partial void OnOnShelfChanging(ref global::System.Nullable<int> value);
        partial void OnOnShelfChanged();
    
        /// <summary>
        /// There are no comments for BoxNumber in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual string BoxNumber
        {
            get
            {
                string value = _BoxNumber;
                OnGetBoxNumber(ref value);
                return value;
            }
            set
            {
                if (_BoxNumber != value)
                {
                  OnBoxNumberChanging(ref value);
                  ReportPropertyChanging("BoxNumber");
                  _BoxNumber = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("BoxNumber");
                  OnBoxNumberChanged();
              }
            }
        }
        private string _BoxNumber;
        partial void OnGetBoxNumber(ref string value);
        partial void OnBoxNumberChanging(ref string value);
        partial void OnBoxNumberChanged();
    
        /// <summary>
        /// There are no comments for PriceTableGuid in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual string PriceTableGuid
        {
            get
            {
                string value = _PriceTableGuid;
                OnGetPriceTableGuid(ref value);
                return value;
            }
            set
            {
                if (_PriceTableGuid != value)
                {
                  OnPriceTableGuidChanging(ref value);
                  ReportPropertyChanging("PriceTableGuid");
                  _PriceTableGuid = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PriceTableGuid");
                  OnPriceTableGuidChanged();
              }
            }
        }
        private string _PriceTableGuid;
        partial void OnGetPriceTableGuid(ref string value);
        partial void OnPriceTableGuidChanging(ref string value);
        partial void OnPriceTableGuidChanged();
    
        /// <summary>
        /// There are no comments for PartBaseID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Guid PartBaseID
        {
            get
            {
                global::System.Guid value = _PartBaseID;
                OnGetPartBaseID(ref value);
                return value;
            }
            set
            {
                if (_PartBaseID != value)
                {
                  OnPartBaseIDChanging(ref value);
                  ReportPropertyChanging("PartBaseID");
                  _PartBaseID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PartBaseID");
                  OnPartBaseIDChanged();
              }
            }
        }
        private global::System.Guid _PartBaseID;
        partial void OnGetPartBaseID(ref global::System.Guid value);
        partial void OnPartBaseIDChanging(ref global::System.Guid value);
        partial void OnPartBaseIDChanged();

        #endregion
    }

}