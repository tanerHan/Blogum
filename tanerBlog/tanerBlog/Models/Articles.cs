using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tanerBlog.Models
{
    public class Articles
    {
        public Articles()
        {
            this.Tarih = DateTime.Now;
        }
        public int ArticlesId { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        [DataType(DataType.Date, ErrorMessage="Date format is wrong please try again.")]
        public DateTime Tarih { get; set; }

        [DataType(DataType.Html, ErrorMessage = "Enter article content in HTML format")]
        public string Icerik { get; set; }

    }
}