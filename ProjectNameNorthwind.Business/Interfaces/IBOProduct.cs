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
	///This is the interface definition for the class BOProduct.
	///</Summary>
	public partial interface IBOProduct 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Product record to the store
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
		///This method updates one Product record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOProduct
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Product record from the store
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
		///BOProduct
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
		
		IProductRepository ProductRepository	{	set;}
		
		IOrderItemRepository OrderItemRepository	{	set;}
		
		Int32? Id	{	get;	set;}
		
		string ProductName	{	get;	set;}
		
		Int32? SupplierId	{	get;	set;}
		
		decimal? UnitPrice	{	get;	set;}
		
		string Package	{	get;	set;}
		
		bool? IsDiscontinued	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}