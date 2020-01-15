using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using heal_fit.Models;

namespace heal_fit.Data
{
	public static class DbInitializer
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DatabaseContext>>()))
            {
				if (!context.Account.Any())
				{
					Account[] accounts = new Account[]
					{
						new Account
						{
							Email = "Admin@Admin.fr",
							Pseudo = "Admin",
							Password = "Admin"
						},
						new Account
						{
							Email = "User@User.fr",
							Pseudo = "User",
							Password = "User"
						},
						new Account
						{
							Email = "test@test.fr",
							Pseudo = "test",
							Password = "test"
						},
						new Account
						{
							Email = "blabla@blabla.fr",
							Pseudo = "blabla",
							Password = "blabla"
						}
					};

					foreach (Account account in accounts)
					{
						context.Add(account);
					}

					context.SaveChanges();
				}

				if (!context.Profile.Any())
				{
					Profile[] profiles = new Profile[]
					{
						new Profile
						{
							FirstName = "Maxime",
							LastName = "Cardinal",
							Age = 26,
							AccountID = context.Account.Find(1).ID
						},
						new Profile
						{
							FirstName = "Thibaud",
							LastName = "Philippi",
							Age = 22,
							AccountID = context.Account.Find(2).ID
						},
						new Profile
						{
							FirstName = "Nathan",
							LastName = "Ropars",
							Age = 22,
							AccountID = context.Account.Find(3).ID
						}
					};

					foreach (Profile profile in profiles)
					{
						context.Add(profile);
					}

					context.SaveChanges();
				}
			}
		}
	}
}