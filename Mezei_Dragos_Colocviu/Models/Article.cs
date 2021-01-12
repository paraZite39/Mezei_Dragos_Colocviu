﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mezei_Dragos_Colocviu.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime ArticleDate { get; set; } = DateTime.Today;
    }
}
