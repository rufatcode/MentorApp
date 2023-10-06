using System;
using System.ComponentModel.DataAnnotations;

namespace MentorApp.ViewModel.AccountVM
{
	public class LoginVM
	{
		public string UserNameOrEmail { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
		public LoginVM()
		{
		}
	}
}

