using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 购物车表
    /// </summary>
    [SugarTable("cart")]
	public class CartDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 商品表名
		/// </summary>
		[SugarColumn(ColumnName = "tablename")]
		public string Tablename { get; set; }

		/// <summary>
		/// Desc: 用户id
		/// </summary>
        [SugarColumn(ColumnName = "userid")]
		public long? Userid { get; set; } = 0;

		/// <summary>
		/// Desc: 商品id
		/// </summary>
        [SugarColumn(ColumnName = "goodid")]
		public long? Goodid { get; set; } = 0;

		/// <summary>
		/// Desc: 商品名称
		/// </summary>
		[SugarColumn(ColumnName = "goodname")]
		public string Goodname { get; set; }

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "picture")]
		public string Picture { get; set; }

		/// <summary>
		/// Desc: 购买数量
		/// </summary>
        [SugarColumn(ColumnName = "buynumber")]
		public int? Buynumber { get; set; } = 0;

		/// <summary>
		/// Desc: 单价
		/// </summary>
        [SugarColumn(ColumnName = "price")]
		public double? Price { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
