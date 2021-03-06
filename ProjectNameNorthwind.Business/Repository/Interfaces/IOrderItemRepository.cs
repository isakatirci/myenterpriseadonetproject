/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using ProjectNameNorthwind.Data.Interfaces;

namespace ProjectNameNorthwind.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the OrderItem repository
	///</Summary>
	public partial interface IOrderItemRepository : IGenericRepository<IDAOOrderItem>, IRepositoryConnection
	{
		void Insert(IDAOOrderItem daoOrderItem);
		void Update(IDAOOrderItem daoOrderItem);
		void Delete(IDAOOrderItem daoOrderItem);
		IDAOOrderItem SelectOne(Int32? id);
		IList<IDAOOrderItem> SelectAllByOrderId(Int32? orderId);
		void DeleteAllByOrderId(Int32? orderId);
		IList<IDAOOrderItem> SelectAllByProductId(Int32? productId);
		void DeleteAllByProductId(Int32? productId);
	}
}
