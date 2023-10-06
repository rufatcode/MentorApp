using System;
using System.ComponentModel.DataAnnotations;

namespace MentorApp.ViewModel.AccountVM
{
	public class RegisterVM
	{
		public string UserName { get; set; }
		public string FullName { get; set; }
		[EmailAddress,DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
        [DataType(DataType.Password),Compare("Password")]
        public string RepeatPassword { get; set; }
		public RegisterVM()
		{
		}
	}
}

