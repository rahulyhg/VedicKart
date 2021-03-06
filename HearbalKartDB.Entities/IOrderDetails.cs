﻿using System;
using System.ComponentModel;

namespace HearbalKartDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'OrderDetails' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IOrderDetails 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "OrderDetails"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// OrderId : 
		/// </summary>
		System.Int32?  OrderId  { get; set; }
		
		/// <summary>
		/// CustomerID : 
		/// </summary>
		System.Int32?  CustomerId  { get; set; }
		
		/// <summary>
		/// ItemID : 
		/// </summary>
		System.Int32?  ItemId  { get; set; }
		
		/// <summary>
		/// Amount : 
		/// </summary>
		System.Int64?  Amount  { get; set; }
		
		/// <summary>
		/// ISActive : 
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
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


