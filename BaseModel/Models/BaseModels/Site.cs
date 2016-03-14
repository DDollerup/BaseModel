using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseModel.Models.BaseModels
{
    public class Site : BaseModel
    {
        public int PageID { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
    }
}