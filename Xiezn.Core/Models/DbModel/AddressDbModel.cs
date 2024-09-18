using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 地址
    /// </summary>
    [SugarTable("address")]
	public class AddressDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 用户id
		/// </summary>
        [SugarColumn(ColumnName = "userid")]
		public long? Userid { get; set; } = 0;

		/// <summary>
		/// Desc: 地址
		/// </summary>
		[SugarColumn(ColumnName = "address")]
		public string Address { get; set; }

		/// <summary>
		/// Desc: 收货人
		/// </summary>
		[SugarColumn(ColumnName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Desc: 电话
		/// </summary>
		[SugarColumn(ColumnName = "phone")]
		public string Phone { get; set; }

		/// <summary>
		/// Desc: 是否默认地址[是/否]
		/// </summary>
		[SugarColumn(ColumnName = "isdefault")]
		public string Isdefault { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
