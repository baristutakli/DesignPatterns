using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Category : PrototypeCategory
    {
        public Category(int ıd, string title, string metaTitle, string body)
        {
            Id = ıd;
            Title = title;
            MetaTitle = metaTitle;
            Body = body;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Body { get; set; }
        /// <summary>
        /// Copy the current object
        /// </summary>
        /// <returns></returns>
        public override PrototypeCategory Clone()
        {
           return  this.MemberwiseClone() as PrototypeCategory;
        }
    }
}
