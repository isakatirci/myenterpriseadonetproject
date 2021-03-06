/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using ProjectNameNorthwind.Data;
using ProjectNameNorthwind.Data.Interfaces;
using ProjectNameNorthwind.Business.Repository.Interfaces;

namespace ProjectNameNorthwind.Business.Repository
{
	///<Summary>
	///Class definition
	///This is the definition of the OrderRepository.
	///</Summary>
	public partial class OrderRepository : IOrderRepository, IDisposable
	{
		#region member variables
		IConnectionProvider _connectionProvider;
		bool _isDisposed = false;
		#endregion

		#region disposable interface support
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool isDisposing)
		{
			if(!_isDisposed)
			{
				if(isDisposing)
				{
					if(_connectionProvider != null)
					{
						((IDisposable)_connectionProvider).Dispose();
						_connectionProvider = null;
					}
				}
			}
			_isDisposed = true;
		}
		#endregion

		#region methods
		public virtual IBaseData BaseData(IDAOOrder daoOrder)
		{	return (IBaseData)(DAOOrder)daoOrder;	}

		public virtual IDAOOrder New()
		{	return new DAOOrder();	}

		public virtual void Insert(IDAOOrder daoOrder)
		{	daoOrder.Insert();	}

		public virtual void Update(IDAOOrder daoOrder)
		{	daoOrder.Update();	}

		public virtual void Delete(IDAOOrder daoOrder)
		{	daoOrder.Delete();	}

		public virtual IList<IDAOOrder> SelectAll()
		{	return DAOOrder.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOOrder.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrder.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOOrder> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrder.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOOrder.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOOrder SelectOne(Int32? id)
		{	return DAOOrder.SelectOne(id);	}

		public virtual IList<IDAOOrder> SelectAllByCustomerId(Int32? customerId)
		{	return DAOOrder.SelectAllByCustomerId(customerId);	}

		public virtual void DeleteAllByCustomerId(Int32? customerId)
		{	DAOOrder.DeleteAllByCustomerId(ConnectionProvider, customerId);	}

		#endregion

		#region properties
		public virtual IConnectionProvider ConnectionProvider
		{
			get { return _connectionProvider; }
			set { _connectionProvider = value; }
		}

		#endregion

	}
}
