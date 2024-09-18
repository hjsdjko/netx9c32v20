using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 订单
    /// </summary>
    [SugarTable("orders")]
	public class OrdersDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 订单编号
		/// </summary>
        [SugarColumn(ColumnName = "orderid", IsOnlyIgnoreUpdate = true)]
		public string Orderid { get; set; }

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
		/// Desc: 商品图片
		/// </summary>
		[SugarColumn(ColumnName = "picture")]
		public string Picture { get; set; }

		/// <summary>
		/// Desc: 购买数量
		/// </summary>
        [SugarColumn(ColumnName = "buynumber")]
		public int? Buynumber { get; set; } = 0;

		/// <summary>
		/// Desc: 价格
		/// </summary>
        [SugarColumn(ColumnName = "price")]
		public double? Price { get; set; } = 0;

		/// <summary>
		/// Desc: 总价格
		/// </summary>
        [SugarColumn(ColumnName = "total")]
		public double? Total { get; set; } = 0;

		/// <summary>
		/// Desc: 支付类型
		/// </summary>
        [SugarColumn(ColumnName = "type")]
		public int? Type { get; set; } = 0;

		/// <summary>
		/// Desc: 状态
		/// </summary>
		[SugarColumn(ColumnName = "status")]
		public string Status { get; set; }

		/// <summary>
		/// Desc: 地址
		/// </summary>
		[SugarColumn(ColumnName = "address")]
		public string Address { get; set; }

		/// <summary>
		/// Desc: 电话
		/// </summary>
		[SugarColumn(ColumnName = "tel")]
		public string Tel { get; set; }

		/// <summary>
		/// Desc: 收货人
		/// </summary>
		[SugarColumn(ColumnName = "consignee")]
		public string Consignee { get; set; }

		/// <summary>
		/// Desc: 物流
		/// </summary>
		[SugarColumn(ColumnName = "logistics")]
		public string Logistics { get; set; }

		/// <summary>
		/// Desc: 备注
		/// </summary>
		[SugarColumn(ColumnName = "remark")]
		public string Remark { get; set; }

		/// <summary>
		/// Desc: 是否审核
		/// </summary>
		[SugarColumn(ColumnName = "sfsh")]
		public string Sfsh { get; set; }

		/// <summary>
		/// Desc: 审核回复
		/// </summary>
		[SugarColumn(ColumnName = "shhf")]
		public string Shhf { get; set; }

		/// <summary>
		/// Desc: 用户角色
		/// </summary>
		[SugarColumn(ColumnName = "role")]
		public string Role { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
