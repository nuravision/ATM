namespace ConsoleApp2
{
	public class User
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public Card CreditCard { get; set; }
		public User(string name, string surname, Card creditCard)
		{
			Name = name;
			Surname = surname;
			CreditCard = creditCard;
		}
	}
}
