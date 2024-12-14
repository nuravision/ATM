namespace ConsoleApp2
{
	public class MyExceptions:Exception
	{
		
		public string Message { get; set; }
		public MyExceptions(string message):base(message)
		{
			Message = message;
		}

	}
}
