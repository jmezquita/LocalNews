using System;
using System.Collections.Generic;
using System.Text;

namespace LocalNews.Models
{

    public enum eCategory { Business, Entertainment, General, Health, Science, Sports, Technology, All };
    public class Category
    {
    public string Id { get; set; }
    public eCategory Name { get; set; }

    }
}
