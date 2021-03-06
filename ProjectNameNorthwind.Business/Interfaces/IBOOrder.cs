/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using ProjectNameNorthwind.Data.Interfaces;
using ProjectNameNorthwind.Business.Repository.Interfaces;

namespace ProjectNameNorthwind.Business.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOOrder.
	///</Summary>
	public partial interface IBOOrder 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Order record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void SaveNew();
		
		///<Summary>
		///Update
		///This method updates one Order record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrder
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Order record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///OrderItemCollection
		///This method returns its collection of BOOrderItem objects
		///</Summary>
		///<returns>
		///IList[IBOOrderItem]
		///</returns>
		///<parameters>
		///BOOrder
		///</parameters>
		IList<IBOOrderItem> OrderItemCollection();
		
		///<Summary>
		///LoadOrderItemCollection
		///This method loads the internal collection of BOOrderItem objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadOrderItemCollection();
		
		///<Summary>
		///AddOrderItem
		///This method persists a BOOrderItem object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderItem
		///</parameters>
		void AddOrderItem(IBOOrderItem boOrderItem);
		
		///<Summary>
		///DeleteAllOrderItem
		///This method deletes all BOOrderItem objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllOrderItem();
		
		#endregion

		#region member properties
		
		IOrderRepository OrderRepository	{	set;}
		
		IOrderItemRepository OrderItemRepository	{	set;}
		
		Int32? Id	{	get;	set;}
		
		DateTime? OrderDate	{	get;	set;}
		
		string OrderNumber	{	get;	set;}
		
		Int32? CustomerId	{	get;	set;}
		
		decimal? TotalAmount	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
