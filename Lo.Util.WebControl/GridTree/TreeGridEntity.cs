﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lo.Util.WebControl.GridTree
{
    /// <summary>
    /// 树表格实体
    /// </summary>
    public class TreeGridEntity
    {
        public string parentId { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string entityJson { get; set; }
        public bool expanded { get; set; }
        public bool hasChildren { get; set; }
    }
}
