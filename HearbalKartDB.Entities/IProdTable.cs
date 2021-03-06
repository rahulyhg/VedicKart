﻿using System;
using System.ComponentModel;

namespace HearbalKartDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'ProdTable' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IProdTable 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ProdTable"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// ItemID : 
		/// </summary>
		System.Int32?  ItemId  { get; set; }
		
		/// <summary>
		/// CategoryID : 
		/// </summary>
		System.Int32?  CategoryId  { get; set; }
		
		/// <summary>
		/// CompanyID : 
		/// </summary>
		System.Int32?  CompanyId  { get; set; }
		
		/// <summary>
		/// TypeID : 
		/// </summary>
		System.Int32?  TypeId  { get; set; }
		
		/// <summary>
		/// SupplementID : 
		/// </summary>
		System.Int32?  SupplementId  { get; set; }
		
		/// <summary>
		/// MedicineForID : 
		/// </summary>
		System.Int32?  MedicineForId  { get; set; }
		
		/// <summary>
		/// PurchaseID : 
		/// </summary>
		System.Int32?  PurchaseId  { get; set; }
		
		/// <summary>
		/// SellID : 
		/// </summary>
		System.Int32?  SellId  { get; set; }
		
		/// <summary>
		/// OfferID : 
		/// </summary>
		System.Int32?  OfferId  { get; set; }
		
		/// <summary>
		/// IsActive : 
		/// </summary>
		System.Boolean?  IsActive  { get; set; }
		
		/// <summary>
		/// CreatedDate : 
		/// </summary>
		System.DateTime?  CreatedDate  { get; set; }
		
		/// <summary>
		/// ModifiedDate : 
		/// </summary>
		System.DateTime?  ModifiedDate  { get; set; }
		
		/// <summary>
		/// DeletedDate : 
		/// </summary>
		System.DateTime?  DeletedDate  { get; set; }
		
		/// <summary>
		/// ImageUrl : 
		/// </summary>
		System.String  ImageUrl  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


