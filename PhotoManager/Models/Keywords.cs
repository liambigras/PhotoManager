using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoManager.Models
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Keyword()
        {
            Id = 0;
            Name = "";
        }
    }

    public class Keywords : DAL.RecordsDB<Keyword>
    {
        public Keywords(DAL.DataBase dataBase) : base(dataBase)
        {
            SetCache(true);
        }        
    }           

    public class PhotoKeyword
    {
        public int Id { get; set; }
        public int KeywordId { get; set; }
        public int PhotoId { get; set; }

        public PhotoKeyword(Photo Pid, Keyword Kid)
        {
            Id = 0;
            KeywordId = Kid.Id;
            PhotoId = Pid.Id;
        }
    }

    public class PhotosKeywords : DAL.RecordsDB<PhotoKeyword>
    {
        public PhotosKeywords(DAL.DataBase dataBase) : base(dataBase)
        {
            SetCache(true);
        }
    }
}