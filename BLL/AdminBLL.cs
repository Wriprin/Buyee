using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AdminBLL
    {
        /// <summary>
        /// 为了调用DAL功能定义DAL类型的私有成员
        /// </summary>
        private DAL.DCDataContext objDAL = new DAL.DCDataContext();


        /// <summary>
        /// 根据Where条件生成数据列表
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public List<DAL.Admin> GetList(System.Linq.Expressions.Expression<Func<DAL.Admin, bool>> condition)
        {
            return objDAL.Admin.Where(condition).ToList<DAL.Admin>();
        }
        /// <summary>
        /// 根据用户名和密码，判断用户是否合法
        /// </summary>
        /// <param name="UName"></param>
        /// <param name="Upwd"></param>
        /// <returns></returns>
        public bool Login(string UName, string Upwd)
        {
            List<DAL.Admin> objL = this.GetList(x => x.pwd == Upwd);
            if (objL.Count > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 根据ID查询一个数据模型，即表中一行数据，没找到对应数据返回null
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DAL.Admin GetModel(int ID)
        {
            return objDAL.Admin.First(x => int.Parse(x.name) == ID);
        }
    }
}
