//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using JetCoders.Shared;

namespace Connections
{
    [Serializable]
    public partial class TransactionLookup : IEntityBase
    {
        #region Primitive Properties
    
        public virtual int TransactionLookupId
        {
            get;
            set;
        }
    
        public virtual System.DateTime TransactionDate
        {
            get;
            set;
        }
    
        public virtual string ContactName
        {
            get;
            set;
        }
    
        public virtual string DocNumber
        {
            get;
            set;
        }
    
        public virtual string Remarks
        {
            get;
            set;
        }
    
    	public TransactionType TransactionType
    	{
    		get { return (TransactionType) TransactionType_Enum; }
    		set { TransactionType_Enum = (short) value; }
    	}
        public virtual short TransactionType_Enum
        {
            get;
            set;
        }
    
        public virtual decimal NetAmount
        {
            get;
            set;
        }
    
        public virtual string TransactionPartyRef
        {
            get;
            set;
        }
    
        public virtual string MemoNumber
        {
            get;
            set;
        }
    
        public virtual System.DateTime AccessedDate
        {
            get;
            set;
        }
    
        public virtual int AccessedBy
        {
            get;
            set;
        }
    
        public virtual string FinancialYearCode
        {
            get;
            set;
        }
    
    
    	private TransactionLookupDetail _properties = null;
    	
    	public virtual TransactionLookupDetail Properties
    	{
    		get 
    		{
    			if ( _properties == null )
    				_properties = new TransactionLookupDetail();
    				
    			return _properties;
    		}
    		
    		set { _properties = value; }
    	}
        private string TransactionLookupDetail_Xml
        {
    		get { return this.Properties.Serialize<TransactionLookupDetail>().ToString(); }
    		set { this.Properties = DataContractHelper.Deserialize<TransactionLookupDetail>(value); }
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<JewelTransaction> JewelTransactions
        {
            get
            {
                if (_jewelTransactions == null)
                {
                    var newCollection = new FixupCollection<JewelTransaction>();
                    newCollection.CollectionChanged += FixupJewelTransactions;
                    _jewelTransactions = newCollection;
                }
                return _jewelTransactions;
            }
            set
            {
                if (!ReferenceEquals(_jewelTransactions, value))
                {
                    var previousValue = _jewelTransactions as FixupCollection<JewelTransaction>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupJewelTransactions;
                    }
                    _jewelTransactions = value;
                    var newValue = value as FixupCollection<JewelTransaction>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupJewelTransactions;
                    }
                }
            }
        }
        private ICollection<JewelTransaction> _jewelTransactions;

        #endregion

        #region Association Fixup
    
        private void FixupJewelTransactions(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (JewelTransaction item in e.NewItems)
                {
                    item.TransactionLookup = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (JewelTransaction item in e.OldItems)
                {
                    if (ReferenceEquals(item.TransactionLookup, this))
                    {
                        item.TransactionLookup = null;
                    }
                }
            }
        }

        #endregion

    }
}
