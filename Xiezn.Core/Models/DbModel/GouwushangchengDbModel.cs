using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 购物商城
    /// </summary>
    [SugarTable("gouwushangcheng")]
	public class GouwushangchengDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 商品编号
		/// </summary>
		[SugarColumn(ColumnName = "shangpinbianhao")]
		public string Shangpinbianhao { get; set; }

		/// <summary>
		/// Desc: 商品名称
		/// </summary>
		[SugarColumn(ColumnName = "shangpinmingcheng")]
		public string Shangpinmingcheng { get; set; }

		/// <summary>
		/// Desc: 商品分类
		/// </summary>
		[SugarColumn(ColumnName = "shangpinfenlei")]
		public string Shangpinfenlei { get; set; }

		/// <summary>
		/// Desc: 商品图片
		/// </summary>
		[SugarColumn(ColumnName = "shangpintupian")]
		public string Shangpintupian { get; set; }

		/// <summary>
		/// Desc: 上架时间
		/// </summary>
        [SugarColumn(ColumnName = "shangjiashijian")]
		[JsonConverter(typeof(Common.Helpers.DateFormatConverter), "yyyy-MM-dd")]
		public DateTime Shangjiashijian { get; set; }

		/// <summary>
		/// Desc: 商品规格
		/// </summary>
		[SugarColumn(ColumnName = "shangpinguige")]
		public string Shangpinguige { get; set; }

		/// <summary>
		/// Desc: 商品详情
		/// </summary>
		[SugarColumn(ColumnName = "shangpinxiangqing")]
		public string Shangpinxiangqing { get; set; }

		/// <summary>
		/// Desc: 单限
		/// </summary>
        [SugarColumn(ColumnName = "onelimittimes")]
		public int? Onelimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 库存
		/// </summary>
        [SugarColumn(ColumnName = "alllimittimes")]
		public int? Alllimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 最近点击时间
		/// </summary>
        [SugarColumn(ColumnName = "clicktime")]
		public DateTime? Clicktime { get; set; }

		/// <summary>
		/// Desc: 点击次数
		/// </summary>
        [SugarColumn(ColumnName = "clicknum")]
		public int? Clicknum { get; set; } = 0;

		/// <summary>
		/// Desc: 评论数
		/// </summary>
        [SugarColumn(ColumnName = "discussnum")]
		public int? Discussnum { get; set; } = 0;

		/// <summary>
		/// Desc: 价格
		/// </summary>
        [SugarColumn(ColumnName = "price")]
		public double? Price { get; set; } = 0;

		/// <summary>
		/// Desc: 收藏数
		/// </summary>
        [SugarColumn(ColumnName = "storeupnum")]
		public int? Storeupnum { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
