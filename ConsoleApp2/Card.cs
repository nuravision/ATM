namespace ConsoleApp2
{
	public class Card
	{
		public string Pan { get; set; }
		public string Pin { get; set; }
		public string Cvc { get; set; }
		public string ExpireDate { get; set; }
		public decimal Balance { get; set; }

		public Card(string pan, string pin, string cvc, string expireDate, decimal balance)
		{
			Pan = pan;
			Pin = pin;
			Cvc = cvc;
			ExpireDate = expireDate;
			Balance = balance;
		}
		public override string ToString()
		{
			return $"PAN: {Pan}\nPIN: {Pin}\nCVC: {Cvc}\nExpire Date: {ExpireDate}\nBalance: {Balance}";
		}

	}
}
