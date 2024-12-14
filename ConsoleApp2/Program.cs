using ConsoleApp2;

Card card1 = new Card("1234567890123456", "1910", "192", "10.27", 500);
Card card2 = new Card("1234567890654321", "1019", "193", "08.21", 900);
Card card3 = new Card("9876543210123456", "8310", "229", "10.28", 200);
Card card4 = new Card("9123456789012345", "2312", "259", "05.27", 1200);
Card card5 = new Card("8123456789012345", "2219", "939", "05.27", 1200);
User user1 = new User("Nurane", "Ismayilzade", card1);
User user2 = new User("Alisa", "Ismayilzade", card2);
User user3 = new User("Denis", "Ismayilova", card3);
User user4 = new User("Alina", "Qasimova", card4);
User user5 = new User("Melissa", "Ismayilova", card5);
User[] users = new User[] { user1, user2, user3, user4, user5 };
while (true)
{
start: Console.WriteLine("--------Welcome-----------");
	Console.Write("Please,enter your pin:");
	string pin = Console.ReadLine();
	bool checkUser = true;
	try
	{
		foreach (User user in users)
		{
			if (user.CreditCard.Pin == pin)
			{
				checkUser = false;
			format: Console.Write($"{user.Name} {user.Surname} xos gelmisiniz.Zehmet" +
			$" olmasa asagidakilardan birini secin.\n");
			operation: Console.Write($"1.Balans\n2.Negd pul\n3.Edilen emeliyyatlarin siyahisi\n4.Kartdan karta kocurme\n5.Cixis\nSeciminiz:");
				try
				{
					int choice;
					bool choiceCheck = Int32.TryParse(Console.ReadLine(), out choice);
					if (choiceCheck)
					{
						if (choice == 1)
						{
							Console.WriteLine($"Balance:{user.CreditCard.Balance}");
							goto operation;
						}
						else if (choice == 2)
						{
							quantityLabel: Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin:");
							Console.Write("1.10AZN\n2.20AZN\n3.50AZN\n4.100AZN\n5.Diger\nSeciminiz:");
							int quantityChoice;
							bool quantityChoiceCheck = Int32.TryParse(Console.ReadLine(), out quantityChoice);
							try
							{
								if (quantityChoiceCheck)
								{
									if (quantityChoice == 1)
									{
										try
										{
											if (user.CreditCard.Balance >= 10)
											{
												user.CreditCard.Balance -= 10;
												Console.WriteLine($"Emeliyyat icra olundu!\n" +
													$"Balance:{user.CreditCard.Balance}");
													goto format;
											}
											else
											{
												throw new MyExceptions("Balansda kifayet qeder mebleg yoxdur!");
												goto format;

											}
										}
										catch (Exception ex) {
											Console.WriteLine($"Error:{ex.Message}");
											goto format;

										}
									}
									else if (quantityChoice == 2)
									{
										try
										{
											if (user.CreditCard.Balance >= 20)
											{
												user.CreditCard.Balance -= 20;
												Console.WriteLine($"Emeliyyat icra olundu!\n" +
													$"Balance:{user.CreditCard.Balance}");
													goto format;

											}
											else
											{
												throw new MyExceptions("Balansda kifayet qeder mebleg yoxdur!");
												goto format;

											}
										}
										catch (Exception ex)
										{
											Console.WriteLine($"Error:{ex.Message}");
											goto format;

										}
									}
									else if (quantityChoice == 3)
									{
										try
										{
											if (user.CreditCard.Balance >= 50)
											{
												user.CreditCard.Balance -= 50;
												Console.WriteLine($"Emeliyyat icra olundu!\n" +
													$"Balance:{user.CreditCard.Balance}");
												goto format;

											}
											else
											{
												throw new MyExceptions("Balansda kifayet qeder mebleg yoxdur!");
												goto format;

											}
										}
										catch (Exception ex)
										{
											Console.WriteLine($"Error:{ex.Message}");
											goto format;

										}
									}
									else if (quantityChoice == 4)
									{
										try
										{
											if (user.CreditCard.Balance >= 100)
											{
												user.CreditCard.Balance -= 100;
												Console.WriteLine($"Emeliyyat icra olundu!\n" +
													$"Balance:{user.CreditCard.Balance}");
												goto format;

											}
											else
											{
												throw new MyExceptions("Balansda kifayet qeder mebleg yoxdur!");
												goto format;

											}
										}
										catch (Exception ex)
										{
											Console.WriteLine($"Error:{ex.Message}");
											goto format;

										}
									}
									else if (quantityChoice == 5)
									{
										Console.Write("Cixarmaq istediyiniz meblegi daxil edin:");
										decimal determineQuantity;
										determineQuantity = decimal.Parse(Console.ReadLine());
										try
										{
											if (user.CreditCard.Balance >= determineQuantity)
											{
												user.CreditCard.Balance -= determineQuantity;
												Console.WriteLine($"Emeliyyat icra olundu movcud balans:{user.CreditCard.Balance}");
													goto format;
											}
											else
											{
												throw new MyExceptions($"Balansda kifayet qeder mebleg yoxdur!\nMovcud" +
													$" balans: {user.CreditCard.Balance}");
												goto format;

											}
										}
										catch (Exception ex)
										{
											Console.WriteLine($"Error:{ex.Message}");
											goto format;

										}

									}
									else
									{
										throw new MyExceptions("Secim yalnisdir!");
									}
								}
								else
								{
									throw new MyExceptions("Format is wrong!");
								}
							}
							catch (Exception e)
							{
								Console.WriteLine($"Error:{e.Message}");
								goto quantityLabel;
							}

						}
						else if (choice == 3) {
							Console.WriteLine(" Hansi vaxtda hansi emeliyyat yerine yetirildiyi haqqinda melumatlar\n Son 1,5,10 gun");
							goto format;
						}
						else if (choice == 4)
						{
							string sharedPin;
							bool check = true;
							sharedLabel: Console.Write("Kocurmek istediyiniz kartin pinini daxil edin:");
							sharedPin = Console.ReadLine();
							try
							{
								foreach (User Users in users)
								{
									if (Users.CreditCard.Pin == sharedPin)
									{
										Console.Write("Kocurmek istediyiniz meblegi daxil edin:");
										int sharedQuantity;
										sharedQuantity = Int32.Parse(Console.ReadLine());
										check = false;
										try
										{
											if (Users.CreditCard.Balance >= sharedQuantity)
											{
												user.CreditCard.Balance -= sharedQuantity;
												Users.CreditCard.Balance += sharedQuantity;
												Console.WriteLine($"Emeliyyat icra olundu!\nBalans:{user.CreditCard.Balance}");
												goto format;
											}
											else
											{
												throw new MyExceptions("Balansinizda kifayet qeder mebleg yoxdur!");
											}
										}
										catch (MyExceptions e) {
											Console.WriteLine($"Error:{e.Message}");
										}
									}
								}
								if (check)
								{
									throw new MyExceptions("bu PIN koda aid kart tapilmadi");
								}
							}
							catch(MyExceptions ex)
							{
								Console.WriteLine($"Error:{ex.Message}");
								goto sharedLabel;
							}
						}
						else if (choice == 5)
						{
							goto start;
						}
					}
					else
					{
						throw new MyExceptions("Yalnis format!");
						goto format;
					}
				}
				catch (MyExceptions ex)
				{
					Console.WriteLine($"Error:{ex.Message}");
					goto format;
				}
			}
		}
		if (checkUser)
		{
			throw new MyExceptions("Bele bir user tapilmadi!");
		}
	}
	catch (MyExceptions ex)
	{
		Console.WriteLine($"Error:{ex.Message}");
	}
}