/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ProjectNameNorthwind.Data.Interfaces;

namespace ProjectNameNorthwind.Data
{
	public partial class DAOOrder : BaseData, IDAOOrder
	{
		#region member variables
		protected Int32? _id;
		protected DateTime? _orderDate;
		protected string _orderNumber;
		protected Int32? _customerId;
		protected decimal? _totalAmount;
		protected Int32? _ctrVersion;
		#endregion

		#region class methods
		public DAOOrder()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table Order based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOOrder
		///</returns>
		///<parameters>
		///Int32? id
		///</parameters>
		public static IDAOOrder SelectOne(Int32? id)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Order");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				DAOOrder retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOOrder();
					retObj._id					 = Convert.IsDBNull(dt.Rows[0]["Id"]) ? (Int32?)null : (Int32?)dt.Rows[0]["Id"];
					retObj._orderDate					 = Convert.IsDBNull(dt.Rows[0]["OrderDate"]) ? (DateTime?)null : (DateTime?)dt.Rows[0]["OrderDate"];
					retObj._orderNumber					 = Convert.IsDBNull(dt.Rows[0]["OrderNumber"]) ? null : (string)dt.Rows[0]["OrderNumber"];
					retObj._customerId					 = Convert.IsDBNull(dt.Rows[0]["CustomerId"]) ? (Int32?)null : (Int32?)dt.Rows[0]["CustomerId"];
					retObj._totalAmount					 = Convert.IsDBNull(dt.Rows[0]["TotalAmount"]) ? (decimal?)null : (decimal?)dt.Rows[0]["TotalAmount"];
					retObj._ctrVersion					 = Convert.IsDBNull(dt.Rows[0]["ctr_version"]) ? (Int32?)null : (Int32?)dt.Rows[0]["ctr_version"];
				}
				return retObj;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table Order based on its primary key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			Doing(this);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_DeleteOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(this);

			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows by foreign key
		///This method returns all data rows in the table Order based on a foreign key
		///</Summary>
		///<returns>
		///IList-IDAOOrder.
		///</returns>
		///<parameters>
		///Int32? customerId
		///</parameters>
		public static IList<IDAOOrder> SelectAllByCustomerId(Int32? customerId)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_SelectAllByCustomerId;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Order");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)customerId?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOOrder> objList = new List<IDAOOrder>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOOrder retObj = new DAOOrder();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._orderDate					 = Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"];
						retObj._orderNumber					 = Convert.IsDBNull(row["OrderNumber"]) ? null : (string)row["OrderNumber"];
						retObj._customerId					 = Convert.IsDBNull(row["CustomerId"]) ? (Int32?)null : (Int32?)row["CustomerId"];
						retObj._totalAmount					 = Convert.IsDBNull(row["TotalAmount"]) ? (decimal?)null : (decimal?)row["TotalAmount"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? (Int32?)null : (Int32?)row["ctr_version"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///Int32? customerId
		///</parameters>
		public static Int32 SelectAllByCustomerIdCount(Int32? customerId)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_SelectAllByCustomerIdCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)customerId?? (object)DBNull.Value));

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();
				Done(null);

				return retCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Delete all by foreign key
		///This method deletes all rows in the table Order with a given foreign key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///IzProjectNameNorthwindConn_TxConnectionProvider connectionProvider, Int32? customerId
		///</parameters>
		public static void DeleteAllByCustomerId(IConnectionProvider connectionProvider, Int32? customerId)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_DeleteAllByCustomerId;
			command.CommandType = CommandType.Text;
			command.Connection = connectionProvider.Connection;
			command.Transaction = connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@CustomerId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)customerId?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(null);

			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Insert a new row
		///This method saves a new object to the table Order
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Insert()
		{
			Doing(this);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(CtSqlParameter.Get("@OrderDate", SqlDbType.DateTime, 8, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_orderDate?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@OrderNumber", SqlDbType.NVarChar, 10, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_orderNumber?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CustomerId", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_customerId?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@TotalAmount", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, true, 12, 2, "", DataRowVersion.Proposed, (object)_totalAmount?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ctr_version", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Id"].Value;
				_orderDate					 = Convert.IsDBNull(command.Parameters["@OrderDate"].Value) ? (DateTime?)null : (DateTime?)command.Parameters["@OrderDate"].Value;
				_orderNumber					 = Convert.IsDBNull(command.Parameters["@OrderNumber"].Value) ? null : (string)command.Parameters["@OrderNumber"].Value;
				_customerId					 = Convert.IsDBNull(command.Parameters["@CustomerId"].Value) ? (Int32?)null : (Int32?)command.Parameters["@CustomerId"].Value;
				_totalAmount					 = Convert.IsDBNull(command.Parameters["@TotalAmount"].Value) ? (decimal?)null : (decimal?)command.Parameters["@TotalAmount"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["@ctr_version"].Value) ? (Int32?)null : (Int32?)command.Parameters["@ctr_version"].Value;

			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows
		///This method returns all data rows in the table Order
		///</Summary>
		///<returns>
		///IList-IDAOOrder.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOOrder> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Order");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOOrder> objList = new List<IDAOOrder>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOOrder retObj = new DAOOrder();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._orderDate					 = Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"];
						retObj._orderNumber					 = Convert.IsDBNull(row["OrderNumber"]) ? null : (string)row["OrderNumber"];
						retObj._customerId					 = Convert.IsDBNull(row["CustomerId"]) ? (Int32?)null : (Int32?)row["CustomerId"];
						retObj._totalAmount					 = Convert.IsDBNull(row["TotalAmount"]) ? (decimal?)null : (decimal?)row["TotalAmount"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? (Int32?)null : (Int32?)row["ctr_version"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 SelectAllCount()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_SelectAllCount;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();
				Done(null);

				return retCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select specific fields of all rows using criteriaquery api
		///This method returns specific fields of all data rows in the table using criteriaquery apiOrder
		///</Summary>
		///<returns>
		///IDictionary-string, IList-object..
		///</returns>
		///<parameters>
		///IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprOrder_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Order");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				IDictionary<string, IList<object>> dict = new Dictionary<string, IList<object>>();
				foreach (IDataProjection projection in listProjection)
				{
					IList<object> lst = new List<object>();
					dict.Add(projection.Member, lst);
					foreach (DataRow row in dt.Rows)
					{
						if (string.Compare(projection.Member, "Id", true) == 0) lst.Add(Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"]);
						if (string.Compare(projection.Member, "OrderDate", true) == 0) lst.Add(Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"]);
						if (string.Compare(projection.Member, "OrderNumber", true) == 0) lst.Add(Convert.IsDBNull(row["OrderNumber"]) ? null : (string)row["OrderNumber"]);
						if (string.Compare(projection.Member, "CustomerId", true) == 0) lst.Add(Convert.IsDBNull(row["CustomerId"]) ? (Int32?)null : (Int32?)row["CustomerId"]);
						if (string.Compare(projection.Member, "TotalAmount", true) == 0) lst.Add(Convert.IsDBNull(row["TotalAmount"]) ? (decimal?)null : (decimal?)row["TotalAmount"]);
					}
				}
				return dict;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select all rows by filter criteria
		///This method returns all data rows in the table using criteriaquery api Order
		///</Summary>
		///<returns>
		///IList-IDAOOrder.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOOrder> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprOrder_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Order");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOOrder> objList = new List<IDAOOrder>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOOrder retObj = new DAOOrder();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._orderDate					 = Convert.IsDBNull(row["OrderDate"]) ? (DateTime?)null : (DateTime?)row["OrderDate"];
						retObj._orderNumber					 = Convert.IsDBNull(row["OrderNumber"]) ? null : (string)row["OrderNumber"];
						retObj._customerId					 = Convert.IsDBNull(row["CustomerId"]) ? (Int32?)null : (Int32?)row["CustomerId"];
						retObj._totalAmount					 = Convert.IsDBNull(row["TotalAmount"]) ? (decimal?)null : (decimal?)row["TotalAmount"];
						retObj._ctrVersion					 = Convert.IsDBNull(row["ctr_version"]) ? (Int32?)null : (Int32?)row["ctr_version"];
						objList.Add(retObj);
					}
				}
				return objList;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Select count of all rows using criteriaquery api
		///This method returns all data rows in the table using criteriaquery api Order
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion
		///</parameters>
		public static Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprOrder_SelectAllByCriteriaCount, null, listCriterion, null);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			try
			{

				staticConnection.Open();
				Int32 retCount = (Int32)command.ExecuteScalar();
				Done(null);

				return retCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
			finally
			{
				staticConnection.Close();
				command.Dispose();
			}
		}

		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table Order based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprOrder_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@OrderDate", SqlDbType.DateTime, 8, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_orderDate?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@OrderNumber", SqlDbType.NVarChar, 10, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_orderNumber?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CustomerId", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_customerId?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@TotalAmount", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, true, 12, 2, "", DataRowVersion.Proposed, (object)_totalAmount?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ctr_version", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_ctrVersion?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Id"].Value;
				_orderDate					 = Convert.IsDBNull(command.Parameters["@OrderDate"].Value) ? (DateTime?)null : (DateTime?)command.Parameters["@OrderDate"].Value;
				_orderNumber					 = Convert.IsDBNull(command.Parameters["@OrderNumber"].Value) ? null : (string)command.Parameters["@OrderNumber"].Value;
				_customerId					 = Convert.IsDBNull(command.Parameters["@CustomerId"].Value) ? (Int32?)null : (Int32?)command.Parameters["@CustomerId"].Value;
				_totalAmount					 = Convert.IsDBNull(command.Parameters["@TotalAmount"].Value) ? (decimal?)null : (decimal?)command.Parameters["@TotalAmount"].Value;
				_ctrVersion					 = Convert.IsDBNull(command.Parameters["@ctr_version"].Value) ? (Int32?)null : (Int32?)command.Parameters["@ctr_version"].Value;

			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
			finally
			{
				command.Dispose();
			}
		}

		#endregion

		#region member properties

		public Int32? Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public DateTime? OrderDate
		{
			get
			{
				return _orderDate;
			}
			set
			{
				_orderDate = value;
			}
		}

		public string OrderNumber
		{
			get
			{
				return _orderNumber;
			}
			set
			{
				_orderNumber = value;
			}
		}

		public Int32? CustomerId
		{
			get
			{
				return _customerId;
			}
			set
			{
				_customerId = value;
			}
		}

		public decimal? TotalAmount
		{
			get
			{
				return _totalAmount;
			}
			set
			{
				_totalAmount = value;
			}
		}

		public Int32? CtrVersion
		{
			get
			{
				return _ctrVersion;
			}
			set
			{
				_ctrVersion = value;
			}
		}

		#endregion
	}
}

#region inline sql procs
namespace ProjectNameNorthwind.Data
{
	public partial class InlineProcs
	{
		internal static string ctprOrder_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[Id]
			,[OrderDate]
			,[OrderNumber]
			,[CustomerId]
			,[TotalAmount]
			,[ctr_version]
			FROM [dbo].[Order]
			WHERE 
			[Id] = @Id
			";

		internal static string ctprOrder_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[Order]
			WHERE 
			[Id] = @Id
			";

		internal static string ctprOrder_SelectAllByCustomerId = @"
			-- Select all rows based on a foreign key
			-- selects all rows from the table
			SELECT 
			[Id]
			,[OrderDate]
			,[OrderNumber]
			,[CustomerId]
			,[TotalAmount]
			,[ctr_version]
			FROM [dbo].[Order]
			WHERE 
			[CustomerId] = @CustomerId OR ([CustomerId] IS NULL AND @CustomerId IS NULL)
			";

		internal static string ctprOrder_SelectAllByCustomerIdCount = @"
			-- Get count of rows returnable by this query
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Order]
			WHERE 
			[CustomerId] = @CustomerId OR ([CustomerId] IS NULL AND @CustomerId IS NULL)
			";

		internal static string ctprOrder_DeleteAllByCustomerId = @"
			
			-- delete all matching from the table
			DELETE [dbo].[Order]
			WHERE 
			[CustomerId] = @CustomerId OR ([CustomerId] IS NULL AND @CustomerId IS NULL)
			";

		internal static string ctprOrder_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[Order]
			(
			[OrderDate]
			,[OrderNumber]
			,[CustomerId]
			,[TotalAmount]
			)
			VALUES
			(
			@OrderDate
			,@OrderNumber
			,@CustomerId
			,@TotalAmount
			)
			SELECT 
			@Id = [Id]
			,@OrderDate = [OrderDate]
			,@OrderNumber = [OrderNumber]
			,@CustomerId = [CustomerId]
			,@TotalAmount = [TotalAmount]
			,@ctr_version = [ctr_version]
			FROM [dbo].[Order]
			WHERE 
			[Id] = SCOPE_IDENTITY()
			";

		internal static string ctprOrder_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[Id]
			,[OrderDate]
			,[OrderNumber]
			,[CustomerId]
			,[TotalAmount]
			,[ctr_version]
			FROM [dbo].[Order]
			";

		internal static string ctprOrder_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Order]
			";

		internal static string ctprOrder_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Order]
			##CRITERIA##
			";

		internal static string ctprOrder_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[Id]
			,[OrderDate]
			,[OrderNumber]
			,[CustomerId]
			,[TotalAmount]
			,[ctr_version]
			FROM [dbo].[Order]
			##CRITERIA##
			";

		internal static string ctprOrder_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Order]
			##CRITERIA##
			";

		internal static string ctprOrder_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			--data optimistic concurrency handling ----------------------------
			DECLARE @currVersion INT
			SELECT @currVersion = [ctr_version] FROM [dbo].[Order]
			WHERE [Id] = @Id
			
			IF @currVersion > @ctr_version
			RAISERROR('data concurrency issue updating this record, possible stale data. %s', 16, 1, 
			'[dbo].[Order] WHERE WHERE [Id] = @Id')
			
			IF @currVersion IS NULL
			RAISERROR('data concurrency issue updating this record, record not available (not found). %s', 16, 1, 
			'[dbo].[Order] WHERE WHERE [Id] = @Id')
			
			SET @ctr_version = @currVersion  + 1 
			-------------------------------------------------------------------
			UPDATE [dbo].[Order]
			SET
			[OrderDate] = @OrderDate
			,[OrderNumber] = @OrderNumber
			,[CustomerId] = @CustomerId
			,[TotalAmount] = @TotalAmount
			,[ctr_version] = @ctr_version
			WHERE 
			[Id] = @Id
			SELECT 
			@Id = [Id]
			,@OrderDate = [OrderDate]
			,@OrderNumber = [OrderNumber]
			,@CustomerId = [CustomerId]
			,@TotalAmount = [TotalAmount]
			,@ctr_version = [ctr_version]
			FROM [dbo].[Order]
			WHERE 
			[Id] = @Id
			";

	}
}
#endregion