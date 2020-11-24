using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class GoodsBLL
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
        public int Add(DAL.Goods Data)
        {
            try
            {
                //向数据上下文数据表中增加一个 模型对象(实体)
                objDAL.Goods.InsertOnSubmit(Data);
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
        public int Delete(DAL.Goods Data)
        {
            try
            {
                //找到数据上下文中，满足条件的记录
                DAL.Goods objT = objDAL.Goods.First(x => x.gid == Data.gid);
                //删除该记录
                objDAL.Goods.DeleteOnSubmit(objT);
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
        public int Update(DAL.Goods Data)
        {
            try
            {
                //找到数据上下文中，满足条件的记录
                DAL.Goods objT = objDAL.Goods.First(x => x.gid == Data.gid);
                //修改数据记录
                objT.gtype = Data.gtype;
                objT.gname = Data.gname;
                objT.gprice = Data.gprice;
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
        public List<DAL.Goods> GetList(System.Linq.Expressions.Expression<Func<DAL.Goods, bool>> condition)
        {
            return objDAL.Goods.Where(condition).ToList<DAL.Goods>();
        }

        /// <summary>
        /// 根据uid查询一个数据模型，即表中一行数据，没找到对应数据返回null
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public DAL.Goods GetModel(int uid)
        {
            return objDAL.Goods.First(x => x.gid == uid);
        }
    }
}
