using System.ComponentModel.DataAnnotations;

namespace beactivefootballacademy.Models
{
	public class ContactUsModel
	{
		[Required]
		public string Name;
		[Required]
		public string EmailAddress;
		[Required]
		public string Message;
		public (string success, string failure) ShowFeedBack { get; set; } = ("hidden", "hidden");
	}
}
