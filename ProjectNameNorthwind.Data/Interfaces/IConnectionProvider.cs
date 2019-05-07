/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
**************************************************************/

using System;
using System.Data.SqlClient;

namespace ProjectNameNorthwind.Data.Interfaces
{
    //IzProjectNameNorthwindConn_TxConnectionProvider
    public partial interface IConnectionProvider
	{
		void OpenConnection();
		void CloseConnection(bool commit);
		void BeginTransaction(string trans);
		void CommitTransaction();
		void RollbackTransaction(string trans);
		SqlTransaction CurrentTransaction	{	get;	}
		SqlConnection Connection	{	get;	}
		Int32 TransactionCount { get; set; }
	}
}
