using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Module03Week01.Models
{
	public class Post
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		/*[DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd/MM/yyyy HH:mm}",
			ApplyFormatInEditMode = true)]*/
		public DateTime TimeOfPosting { get; set; }
		public string Message { get; set; }
		public bool IsSticky { get; set; }
		public int Priority { get; set; }
		public PostType postType { get; set; }
	}

	public enum PostType
	{
		Text,
		Photo
	};
}