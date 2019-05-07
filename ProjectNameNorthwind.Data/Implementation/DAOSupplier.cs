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
	public partial class DAOSupplier : BaseData, IDAOSupplier
	{
		#region member variables
		protected Int32? _id;
		protected string _companyName;
		protected string _contactName;
		protected string _contactTitle;
		protected string _city;
		protected string _country;
		protected string _phone;
		protected string _fax;
		protected Int32? _ctrVersion;
		#endregion

		#region class methods
		public DAOSupplier()
		{
		}
		///<Summary>
		///Select one row by primary key(s)
		///This method returns one row from the table Supplier based on the primary key(s)
		///</Summary>
		///<returns>
		///IDAOSupplier
		///</returns>
		///<parameters>
		///Int32? id
		///</parameters>
		public static IDAOSupplier SelectOne(Int32? id)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprSupplier_SelectOne;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Supplier");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, (object)id?? (object)DBNull.Value));

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				DAOSupplier retObj = null;
				if(dt.Rows.Count > 0)
				{
					retObj = new DAOSupplier();
					retObj._id					 = Convert.IsDBNull(dt.Rows[0]["Id"]) ? (Int32?)null : (Int32?)dt.Rows[0]["Id"];
					retObj._companyName					 = Convert.IsDBNull(dt.Rows[0]["CompanyName"]) ? null : (string)dt.Rows[0]["CompanyName"];
					retObj._contactName					 = Convert.IsDBNull(dt.Rows[0]["ContactName"]) ? null : (string)dt.Rows[0]["ContactName"];
					retObj._contactTitle					 = Convert.IsDBNull(dt.Rows[0]["ContactTitle"]) ? null : (string)dt.Rows[0]["ContactTitle"];
					retObj._city					 = Convert.IsDBNull(dt.Rows[0]["City"]) ? null : (string)dt.Rows[0]["City"];
					retObj._country					 = Convert.IsDBNull(dt.Rows[0]["Country"]) ? null : (string)dt.Rows[0]["Country"];
					retObj._phone					 = Convert.IsDBNull(dt.Rows[0]["Phone"]) ? null : (string)dt.Rows[0]["Phone"];
					retObj._fax					 = Convert.IsDBNull(dt.Rows[0]["Fax"]) ? null : (string)dt.Rows[0]["Fax"];
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
		///this method allows the object to delete itself from the table Supplier based on its primary key
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
			command.CommandText = InlineProcs.ctprSupplier_DeleteOne;
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
		///Insert a new row
		///This method saves a new object to the table Supplier
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
			command.CommandText = InlineProcs.ctprSupplier_InsertOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _id));
				command.Parameters.Add(CtSqlParameter.Get("@CompanyName", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_companyName?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ContactName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_contactName?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ContactTitle", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_contactTitle?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@City", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_city?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Country", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_country?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Phone", SqlDbType.NVarChar, 30, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_phone?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Fax", SqlDbType.NVarChar, 30, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_fax?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ctr_version", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _ctrVersion));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Id"].Value;
				_companyName					 = Convert.IsDBNull(command.Parameters["@CompanyName"].Value) ? null : (string)command.Parameters["@CompanyName"].Value;
				_contactName					 = Convert.IsDBNull(command.Parameters["@ContactName"].Value) ? null : (string)command.Parameters["@ContactName"].Value;
				_contactTitle					 = Convert.IsDBNull(command.Parameters["@ContactTitle"].Value) ? null : (string)command.Parameters["@ContactTitle"].Value;
				_city					 = Convert.IsDBNull(command.Parameters["@City"].Value) ? null : (string)command.Parameters["@City"].Value;
				_country					 = Convert.IsDBNull(command.Parameters["@Country"].Value) ? null : (string)command.Parameters["@Country"].Value;
				_phone					 = Convert.IsDBNull(command.Parameters["@Phone"].Value) ? null : (string)command.Parameters["@Phone"].Value;
				_fax					 = Convert.IsDBNull(command.Parameters["@Fax"].Value) ? null : (string)command.Parameters["@Fax"].Value;
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
		///This method returns all data rows in the table Supplier
		///</Summary>
		///<returns>
		///IList-IDAOSupplier.
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IDAOSupplier> SelectAll()
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = InlineProcs.ctprSupplier_SelectAll;
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Supplier");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOSupplier> objList = new List<IDAOSupplier>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOSupplier retObj = new DAOSupplier();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._contactName					 = Convert.IsDBNull(row["ContactName"]) ? null : (string)row["ContactName"];
						retObj._contactTitle					 = Convert.IsDBNull(row["ContactTitle"]) ? null : (string)row["ContactTitle"];
						retObj._city					 = Convert.IsDBNull(row["City"]) ? null : (string)row["City"];
						retObj._country					 = Convert.IsDBNull(row["Country"]) ? null : (string)row["Country"];
						retObj._phone					 = Convert.IsDBNull(row["Phone"]) ? null : (string)row["Phone"];
						retObj._fax					 = Convert.IsDBNull(row["Fax"]) ? null : (string)row["Fax"];
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
			command.CommandText = InlineProcs.ctprSupplier_SelectAllCount;
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
		///This method returns specific fields of all data rows in the table using criteriaquery apiSupplier
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprSupplier_SelectAllByCriteriaProjection, listProjection, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Supplier");
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
						if (string.Compare(projection.Member, "CompanyName", true) == 0) lst.Add(Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"]);
						if (string.Compare(projection.Member, "ContactName", true) == 0) lst.Add(Convert.IsDBNull(row["ContactName"]) ? null : (string)row["ContactName"]);
						if (string.Compare(projection.Member, "ContactTitle", true) == 0) lst.Add(Convert.IsDBNull(row["ContactTitle"]) ? null : (string)row["ContactTitle"]);
						if (string.Compare(projection.Member, "City", true) == 0) lst.Add(Convert.IsDBNull(row["City"]) ? null : (string)row["City"]);
						if (string.Compare(projection.Member, "Country", true) == 0) lst.Add(Convert.IsDBNull(row["Country"]) ? null : (string)row["Country"]);
						if (string.Compare(projection.Member, "Phone", true) == 0) lst.Add(Convert.IsDBNull(row["Phone"]) ? null : (string)row["Phone"]);
						if (string.Compare(projection.Member, "Fax", true) == 0) lst.Add(Convert.IsDBNull(row["Fax"]) ? null : (string)row["Fax"]);
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
		///This method returns all data rows in the table using criteriaquery api Supplier
		///</Summary>
		///<returns>
		///IList-IDAOSupplier.
		///</returns>
		///<parameters>
		///IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake
		///</parameters>
		public static IList<IDAOSupplier> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			Doing(null);
			SqlCommand	command = new SqlCommand();
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprSupplier_SelectAllByCriteria, null, listCriterion, listOrder, dataSkip, dataTake);
			command.CommandType = CommandType.Text;
			SqlConnection staticConnection = StaticSqlConnection;
			command.Connection = staticConnection;

			DataTable dt = new DataTable("Supplier");
			SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
			try
			{

				staticConnection.Open();
				sqlAdapter.Fill(dt);
				Done(null);

				List<IDAOSupplier> objList = new List<IDAOSupplier>();
				if(dt.Rows.Count > 0)
				{
					foreach(DataRow row in dt.Rows)
					{
						DAOSupplier retObj = new DAOSupplier();
						retObj._id					 = Convert.IsDBNull(row["Id"]) ? (Int32?)null : (Int32?)row["Id"];
						retObj._companyName					 = Convert.IsDBNull(row["CompanyName"]) ? null : (string)row["CompanyName"];
						retObj._contactName					 = Convert.IsDBNull(row["ContactName"]) ? null : (string)row["ContactName"];
						retObj._contactTitle					 = Convert.IsDBNull(row["ContactTitle"]) ? null : (string)row["ContactTitle"];
						retObj._city					 = Convert.IsDBNull(row["City"]) ? null : (string)row["City"];
						retObj._country					 = Convert.IsDBNull(row["Country"]) ? null : (string)row["Country"];
						retObj._phone					 = Convert.IsDBNull(row["Phone"]) ? null : (string)row["Phone"];
						retObj._fax					 = Convert.IsDBNull(row["Fax"]) ? null : (string)row["Fax"];
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
		///This method returns all data rows in the table using criteriaquery api Supplier
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
			command.CommandText = GetSelectionCriteria(InlineProcs.ctprSupplier_SelectAllByCriteriaCount, null, listCriterion, null);
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
		///This method allows the object to update itself in the table Supplier based on its primary key(s)
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
			command.CommandText = InlineProcs.ctprSupplier_UpdateOne;
			command.CommandType = CommandType.Text;
			command.Connection = _connectionProvider.Connection;
			command.Transaction = _connectionProvider.CurrentTransaction;

			try
			{
				command.Parameters.Add(CtSqlParameter.Get("@Id", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_id?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@CompanyName", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, false, 0, 0, "", DataRowVersion.Proposed, (object)_companyName?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ContactName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_contactName?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ContactTitle", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_contactTitle?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@City", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_city?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Country", SqlDbType.NVarChar, 40, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_country?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Phone", SqlDbType.NVarChar, 30, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_phone?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@Fax", SqlDbType.NVarChar, 30, ParameterDirection.InputOutput, true, 0, 0, "", DataRowVersion.Proposed, (object)_fax?? (object)DBNull.Value));
				command.Parameters.Add(CtSqlParameter.Get("@ctr_version", SqlDbType.Int, 4, ParameterDirection.InputOutput, false, 10, 0, "", DataRowVersion.Proposed, (object)_ctrVersion?? (object)DBNull.Value));

				command.ExecuteNonQuery();
				Done(this);

				_id					 = Convert.IsDBNull(command.Parameters["@Id"].Value) ? (Int32?)null : (Int32?)command.Parameters["@Id"].Value;
				_companyName					 = Convert.IsDBNull(command.Parameters["@CompanyName"].Value) ? null : (string)command.Parameters["@CompanyName"].Value;
				_contactName					 = Convert.IsDBNull(command.Parameters["@ContactName"].Value) ? null : (string)command.Parameters["@ContactName"].Value;
				_contactTitle					 = Convert.IsDBNull(command.Parameters["@ContactTitle"].Value) ? null : (string)command.Parameters["@ContactTitle"].Value;
				_city					 = Convert.IsDBNull(command.Parameters["@City"].Value) ? null : (string)command.Parameters["@City"].Value;
				_country					 = Convert.IsDBNull(command.Parameters["@Country"].Value) ? null : (string)command.Parameters["@Country"].Value;
				_phone					 = Convert.IsDBNull(command.Parameters["@Phone"].Value) ? null : (string)command.Parameters["@Phone"].Value;
				_fax					 = Convert.IsDBNull(command.Parameters["@Fax"].Value) ? null : (string)command.Parameters["@Fax"].Value;
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

		public string CompanyName
		{
			get
			{
				return _companyName;
			}
			set
			{
				_companyName = value;
			}
		}

		public string ContactName
		{
			get
			{
				return _contactName;
			}
			set
			{
				_contactName = value;
			}
		}

		public string ContactTitle
		{
			get
			{
				return _contactTitle;
			}
			set
			{
				_contactTitle = value;
			}
		}

		public string City
		{
			get
			{
				return _city;
			}
			set
			{
				_city = value;
			}
		}

		public string Country
		{
			get
			{
				return _country;
			}
			set
			{
				_country = value;
			}
		}

		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				_phone = value;
			}
		}

		public string Fax
		{
			get
			{
				return _fax;
			}
			set
			{
				_fax = value;
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
		internal static string ctprSupplier_SelectOne = @"
			-- Select one row based on the primary key(s)
			-- selects all rows from the table
			SELECT 
			[Id]
			,[CompanyName]
			,[ContactName]
			,[ContactTitle]
			,[City]
			,[Country]
			,[Phone]
			,[Fax]
			,[ctr_version]
			FROM [dbo].[Supplier]
			WHERE 
			[Id] = @Id
			";

		internal static string ctprSupplier_DeleteOne = @"
			-- Delete a row based on the primary key(s)
			-- delete all matching from the table
			DELETE [dbo].[Supplier]
			WHERE 
			[Id] = @Id
			";

		internal static string ctprSupplier_InsertOne = @"
			-- Insert a new row
			-- inserts a new row into the table
			INSERT [dbo].[Supplier]
			(
			[CompanyName]
			,[ContactName]
			,[ContactTitle]
			,[City]
			,[Country]
			,[Phone]
			,[Fax]
			)
			VALUES
			(
			@CompanyName
			,@ContactName
			,@ContactTitle
			,@City
			,@Country
			,@Phone
			,@Fax
			)
			SELECT 
			@Id = [Id]
			,@CompanyName = [CompanyName]
			,@ContactName = [ContactName]
			,@ContactTitle = [ContactTitle]
			,@City = [City]
			,@Country = [Country]
			,@Phone = [Phone]
			,@Fax = [Fax]
			,@ctr_version = [ctr_version]
			FROM [dbo].[Supplier]
			WHERE 
			[Id] = SCOPE_IDENTITY()
			";

		internal static string ctprSupplier_SelectAll = @"
			-- Select All rows
			-- selects all rows from the table
			SELECT 
			[Id]
			,[CompanyName]
			,[ContactName]
			,[ContactTitle]
			,[City]
			,[Country]
			,[Phone]
			,[Fax]
			,[ctr_version]
			FROM [dbo].[Supplier]
			";

		internal static string ctprSupplier_SelectAllCount = @"
			
			-- selects count of all rows from the table
			SELECT COUNT(*)
			FROM [dbo].[Supplier]
			";

		internal static string ctprSupplier_SelectAllByCriteriaProjection = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			##STARTFIELDS##
			##ENDFIELDS##
			FROM [dbo].[Supplier]
			##CRITERIA##
			";

		internal static string ctprSupplier_SelectAllByCriteria = @"
			
			-- selects all rows from the table by criteria
			SELECT 
			[Id]
			,[CompanyName]
			,[ContactName]
			,[ContactTitle]
			,[City]
			,[Country]
			,[Phone]
			,[Fax]
			,[ctr_version]
			FROM [dbo].[Supplier]
			##CRITERIA##
			";

		internal static string ctprSupplier_SelectAllByCriteriaCount = @"
			
			-- selects count of all rows from the table according to criteria
			SELECT COUNT(*)
			FROM [dbo].[Supplier]
			##CRITERIA##
			";

		internal static string ctprSupplier_UpdateOne = @"
			-- Update one row based on the primary key(s)
			-- updates a row in the table based on the primary key
			
			--data optimistic concurrency handling ----------------------------
			DECLARE @currVersion INT
			SELECT @currVersion = [ctr_version] FROM [dbo].[Supplier]
			WHERE [Id] = @Id
			
			IF @currVersion > @ctr_version
			RAISERROR('data concurrency issue updating this record, possible stale data. %s', 16, 1, 
			'[dbo].[Supplier] WHERE WHERE [Id] = @Id')
			
			IF @currVersion IS NULL
			RAISERROR('data concurrency issue updating this record, record not available (not found). %s', 16, 1, 
			'[dbo].[Supplier] WHERE WHERE [Id] = @Id')
			
			SET @ctr_version = @currVersion  + 1 
			-------------------------------------------------------------------
			UPDATE [dbo].[Supplier]
			SET
			[CompanyName] = @CompanyName
			,[ContactName] = @ContactName
			,[ContactTitle] = @ContactTitle
			,[City] = @City
			,[Country] = @Country
			,[Phone] = @Phone
			,[Fax] = @Fax
			,[ctr_version] = @ctr_version
			WHERE 
			[Id] = @Id
			SELECT 
			@Id = [Id]
			,@CompanyName = [CompanyName]
			,@ContactName = [ContactName]
			,@ContactTitle = [ContactTitle]
			,@City = [City]
			,@Country = [Country]
			,@Phone = [Phone]
			,@Fax = [Fax]
			,@ctr_version = [ctr_version]
			FROM [dbo].[Supplier]
			WHERE 
			[Id] = @Id
			";

	}
}
#endregion
