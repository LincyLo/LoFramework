using System;
using System.Collections.Generic;
using System.Text;

namespace Lo.Data.Attributes
{
    /// <summary>
    /// 主键字段
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class PrimaryKeyAttribute : Attribute
    {
        private string _name;
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public PrimaryKeyAttribute()
        {

        }

        public PrimaryKeyAttribute(string name)
        {
            _name = name;
        }
    }
}
