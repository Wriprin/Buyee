using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UsersBLL
    {
        /// <summary>
        /// 为了调用DAL功能定义DAL类型的私有成员
        /// </summary>
        private DAL.DCDataContext objDAL = new DAL.DCDataContext();
        /// <summary>
        /// 根据模型数据，完成表格的插入
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public int Add(DAL.Users Data)
        {
            try
            {
                //向数据上下文数据表中增加一个 模型对象(实体)
                objDAL.Users.InsertOnSubmit(Data);
                //更新数据上下文改变到数据库
                objDAL.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

            //return objDAL.Add(Data);
        }
        /// <summary>
        /// 根据模型中的uid删除指定行
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public int Delete(DAL.Users Data)
        {
            try
            {
                //找到数据上下文中，满足条件的记录
                DAL.Users objT = objDAL.Users.First(x => x.uid == Data.uid);
                //删除该记录
                objDAL.Users.DeleteOnSubmit(objT);
                //更新数据上下文改变到数据库
                objDAL.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        /// <summary>
        /// 根据uid指定要删除的行，其余字段用于表示要修改的数据值
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public int Update(DAL.Users Data)
        {
            try
            {
                //找到数据上下文中，满足条件的记录
                DAL.Users objT = objDAL.Users.First(x => x.uid == Data.uid);
                //修改数据记录
                objT.uname = Data.uname;
                objT.usex = Data.usex;
                objT.upwd = Data.upwd;
                objT.uschool = Data.uschool;
                //更新数据上下文改变到数据库
                objDAL.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 根据Where条件生成数据列表
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public List<DAL.Users> GetList(System.Linq.Expressions.Expression<Func<DAL.Users, bool>> condition)
        {
            return objDAL.Users.Where(condition).ToList<DAL.Users>();
        }
        /// <summary>
        /// 根据用户名和密码，判断用户是否合法
        /// </summary>
        /// <param name="UName"></param>
        /// <param name="Upwd"></param>
        /// <returns></returns>
        public bool Login(string UName, string Upwd)
        {
            List<DAL.Users> objL = this.GetList(x => x.uname == UName && x.upwd == Upwd);
            if (objL.Count > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 根据uid查询一个数据模型，即表中一行数据，没找到对应数据返回null
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public DAL.Users GetModel(int uid)
        {
            return objDAL.Users.First(x => x.uid == uid);
        }
    }
}
