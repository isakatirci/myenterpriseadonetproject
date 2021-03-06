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
	///This is the interface definition for the Product repository
	///</Summary>
	public partial interface IProductRepository : IGenericRepository<IDAOProduct>, IRepositoryConnection
	{
		void Insert(IDAOProduct daoProduct);
		void Update(IDAOProduct daoProduct);
		void Delete(IDAOProduct daoProduct);
		IDAOProduct SelectOne(Int32? id);
		IList<IDAOProduct> SelectAllBySupplierId(Int32? supplierId);
		void DeleteAllBySupplierId(Int32? supplierId);
	}
}
