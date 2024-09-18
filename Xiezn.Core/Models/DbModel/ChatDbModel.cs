using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 在线客服
    /// </summary>
    [SugarTable("chat")]
	public class ChatDbModel
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
		/// Desc: 管理员id
		/// </summary>
        [SugarColumn(ColumnName = "adminid")]
		public long? Adminid { get; set; } = 0;

		/// <summary>
		/// Desc: 提问
		/// </summary>
		[SugarColumn(ColumnName = "ask")]
		public string Ask { get; set; }

		/// <summary>
		/// Desc: 回复
		/// </summary>
		[SugarColumn(ColumnName = "reply")]
		public string Reply { get; set; }

		/// <summary>
		/// Desc: 是否回复
		/// </summary>
        [SugarColumn(ColumnName = "isreply")]
		public int? Isreply { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
