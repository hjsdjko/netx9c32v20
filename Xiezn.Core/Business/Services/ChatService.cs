using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiezn.Core.Common.Helpers;
using Xiezn.Core.Models;
using Xiezn.Core.Models.DbModel;


namespace Xiezn.Core.Business.Services
{
    public class ChatService : BaseService<ChatDbModel>
    {
        private readonly long _uid;
        private readonly string _role;
        private readonly string _tablename;

        public ChatService()
        {
            try
            {
                if (CacheHelper.TokenModel != null)
                {
                    _uid = CacheHelper.TokenModel.Uid;
                    _role = CacheHelper.TokenModel.Role;
                    _tablename = CacheHelper.TokenModel.Tablename;
                }
            }
            catch
            {
                _uid = 0;
                _role = "游客";
            }
        }






        public PageModel<ChatDbModel> GetPageList(int page, int limit, string sort, string order, List<IConditionalModel> conModels)
        {
            PageModel pageModel = new PageModel() { PageIndex = page, PageSize = limit };

            int totalNumber = 0;
            int totalPage = 0;
            string[] sortFields = sort.Split(',');
            string[] orderFields = order.Split(',');
            string mysort = "";
            for (int i = 0; i < sortFields.Length; i++)
            {
                if (i == sortFields.Length - 1)
                {
                    mysort += sortFields[i] + " " + orderFields[i];
                }
                else
                {
                    mysort += sortFields[i] + " " + orderFields[i] + ",";

                }

            }
            if (_role != "Admin" && !conModels.Any(item =>  item is ConditionalModel && (item as ConditionalModel).FieldName == "userid"))
            {
                conModels.Add(new ConditionalModel() { FieldName = "userid", ConditionalType = ConditionalType.Equal, FieldValue = _uid.ToString() });
            }

            List<ChatDbModel> ts = Db.Queryable<ChatDbModel>().Where(conModels).OrderBy(mysort).ToPageList(page, limit, ref totalNumber, ref totalPage);


            PageModel<ChatDbModel> t = new PageModel<ChatDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<ChatDbModel>()
                {
                    Total = totalNumber,
                    PageSize = limit,
                    TotalPage = totalPage,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }


        public int UpdateIsReply(long? userid)
        {
            return Db.Ado.ExecuteCommand("UPDATE chat SET isreply = 0");
        }






    }
}
