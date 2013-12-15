using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Alex.Utilities
{
    /// <summary>
    /// 字符串操作类
    /// 
    /// Time: 2013/12/15
    /// Versions: 00.01
    /// 
    /// 1. public static bool isNumber( string str ) 检查一个字符串是否是纯数字构成的，一般用于查询字符串参数的有效性验证
    /// 2. public static bool isDecimal( string str ) 检查一个字符串是否是浮点数构成的，一般用于查询字符串参数的有效性验证
    /// </summary>
    public class StringHelper
    {
    #region  字符串组成的验证
        /// <summary>
        /// 检查一个字符串是否是纯数字构成的，一般用于查询字符串参数的有效性验证
        /// </summary>
        /// <param name="str">需验证的字符串</param>
        /// <returns>是否合法的bool值</returns>
        public static bool isNumber( string str )
        {
            try
            {
                int data = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                return false;
            	
            }
        }
        /// <summary>
        /// 检查一个字符串是否是浮点数构成的，一般用于查询字符串参数的有效性验证
        /// </summary>
        /// <param name="str">需验证的字符串</param>
        /// <returns>是否合法的bool值</returns>
        public static bool isDecimal( string str )
        {
            try
            {
                Decimal data = Convert.ToDecimal(str);
                return true;
            }
            catch
            {
                return false;

            }
        }
    #endregion
    }
}
