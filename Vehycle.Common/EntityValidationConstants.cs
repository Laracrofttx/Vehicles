namespace Vehycle.Common
{
	public static class EntityValidationConstants
	{
		public static class User
		{
			public const int FirstNameMinLength = 2;
			public const int FirstNameMaxLength = 15;

			public const int LastNameMinLength = 2;
			public const int LastNameMaxLength = 15;

			public const int PasswordMinLength = 6;
			public const int PasswordMaxLength = 50;
		}
		public static class Category
		{
			public const int NameMinLength = 2;
			public const int NameMaxLength = 20;
		}
		public static class Contact
		{
			public const int EmailAdressMinLength = 5;
			public const int EmailAdressMaxLength = 25;

			public const int PhoneNumberMinLength = 10;
			public const int PhoneNumberMaxLength = 13;

			public const int MessageMinLength = 20;
			public const int MessageMaxLength = 500;
		}
		public static class Review
		{
			public const int NameMinLength = 2;
			public const int NameMaxLength = 25;

			public const int FeedBackMinLength = 25;
			public const int FeedBackMaxLength = 500;
		}
		public static class Vehycle
		{
			public const int BrandNameMinLength = 2;
			public const int BrandNameMaxLength = 35;

			public const int ModelNameMinLength = 3;
			public const int ModelNameMaxLength = 35;

			public const int VehycleInfoMinLength = 25;
			public const int VehycleInfoMaxLength = 500;
		}
		public static class ForumPost
		{
			public const int ContentMinLength = 50;
			public const int ContentMaxLength = 500;

			public const int ThemeMinLength = 10;
			public const int ThemeMaxLength = 100;
		}
	}
}
