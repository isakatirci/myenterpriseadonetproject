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
	///This is the interface definition for the Supplier repository
	///</Summary>
	public partial interface ISupplierRepository : IGenericRepository<IDAOSupplier>, IRepositoryConnection
	{
		void Insert(IDAOSupplier daoSupplier);
		void Update(IDAOSupplier daoSupplier);
		void Delete(IDAOSupplier daoSupplier);
		IDAOSupplier SelectOne(Int32? id);
	}
}
