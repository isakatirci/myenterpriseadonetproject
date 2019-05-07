/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 5/6/2019 1:07:04 PM
**************************************************************/

using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using ProjectNameNorthwind.Data.Interfaces;

namespace ProjectNameNorthwind.Data
{
	public partial class DataCriterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
	}

	public partial class DataDuplexCriterion
	{
		public virtual string PropertyName { get; set; }
		public virtual object PropertyValue1 { get; set; }
		public virtual object PropertyValue2 { get; set; }
		public virtual Func<object, string> Formatter { get; set; }
	}

	public partial class DataMultiCriterion
	{
		public virtual List<IDataCriterion> List { get; set; }
	}

	public class DataCriterionEq : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] = '" + propValue + "'";
		}
	}

	public class DataCriterionNotEq : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] != '" + propValue + "'";
		}
	}

	public class DataCriterionLt : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] < '" + propValue + "'";
		}
	}

	public class DataCriterionLte : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] <= '" + propValue + "'";
		}
	}

	public class DataCriterionGt : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] > '" + propValue + "'";
		}
	}

	public class DataCriterionGte : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] >= '" + propValue + "'";
		}
	}

	public partial class DataCriterionInSqlSubQuery : DataCriterion, IDataCriterion
	{
		public virtual string ToSql()
		{
			string quote = "";
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			return "[" + PropertyName + "] IN (" + quote + propValue + quote + ")";
		}
	}

	public class DataCriterionIn : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string quote = "";
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			propValue = propValue.Replace("\"", "'");
			return "[" + PropertyName + "] IN (" + quote + propValue + quote + ")";
		}
	}

	public class DataCriterionNull : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			return "[" + PropertyName + "] IS NULL";
		}
	}

	public class DataCriterionNotNull : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			return "[" + PropertyName + "] IS NOT NULL";
		}
	}

	public class DataCriterionLike : DataCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string quote = "";
			string propValue = Formatter != null ? Formatter(PropertyValue) : PropertyValue.ToString();
			if ((propValue != null) && !propValue.Contains("%")) quote = "%";
			if (propValue.StartsWith("'")) propValue = propValue.Substring(1, propValue.Length - 1);
			if (propValue.EndsWith("'")) propValue = propValue.Substring(0, propValue.Length - 1);
			return "[" + PropertyName + "] LIKE '" + quote + propValue + quote + "'";
		}
	}

	public class DataCriterionOr : DataMultiCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string ret = "";
			foreach(var condition in List)
			{
				ret += (ret == "") ? "" : " OR ";
				ret += condition.ToSql();
			}
			if(!string.IsNullOrEmpty(ret)) ret = "(" + ret + ")";
			return ret;
		}
	}

	public class DataCriterionBetween : DataDuplexCriterion, IDataCriterion
	{
		public string ToSql()
		{
			string propValue1 = Formatter != null ? Formatter(PropertyValue1) : PropertyValue1.ToString();
			string propValue2 = Formatter != null ? Formatter(PropertyValue2) : PropertyValue2.ToString();
			return "[" + PropertyName + "] > '" + propValue1 + "' AND [" + PropertyName + "] < '" + propValue2 + "'";
		}
	}

	public class DataOrderBy : IDataOrderBy
	{
		protected string _propertyName;
		protected string _direction;
		public DataOrderBy() { }
		public DataOrderBy(string propertyName, string direction)
		{
			_propertyName = propertyName;
			_direction = direction;
		}
		public virtual string ToSql()
		{
			return "[" + PropertyName + "] " + Direction;
		}
		public virtual string PropertyName
		{
			get { return _propertyName; }
			set { _propertyName = value; }
		}
		public virtual string Direction
		{
			get { return _direction; }
			set { _direction = value; }
		}
	}

	public class DataSkip : IDataSkip
	{
		protected int _val;
		public DataSkip() { }
		public DataSkip(int val) {	_val = val;	}
		public virtual string ToSql()
		{
			return "OFFSET " + _val.ToString() + " ROWS";
		}
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
	}

	public class DataTake : IDataTake
	{
		protected int _val;
		public DataTake() { }
		public DataTake(int val) {	_val = val;	}
		public virtual string ToSql()
		{
			return "FETCH NEXT " + _val.ToString() + " ROWS ONLY ";
		}
		public virtual int Value
		{
			get { return _val; }
			set { _val = value; }
		}
	}

	public partial class DataProjection : IDataProjection
	{
		public virtual string Member { get; set; }
		public virtual string ToSql() {  return "[" + Member + "]"; }
	}

}
