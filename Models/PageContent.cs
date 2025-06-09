using System;
using System.ComponentModel.DataAnnotations;

namespace CustomCMS.Models
    {
    public class PageContent
        {
        public int Id
            {
            get; set;
            }

        [Required]
        public string PageName
            {
            get; set;
            }

        [Required]
        public string Title
            {
            get; set;
            }

        [DataType(DataType.MultilineText)]
        public string Body
            {
            get; set;
            }

        public DateTime LastUpdated { get; set; } = DateTime.Now;
        }
    }
