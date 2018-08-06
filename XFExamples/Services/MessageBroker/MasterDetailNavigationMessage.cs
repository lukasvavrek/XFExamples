namespace XFExamples.Services.MessageBroker
{
	public class MasterDetailNavigationMessage : IMessage
    {
		public string Message { get; }

		public MasterDetailNavigationMessage(string message)
		{
			Message = message;
		}
    }
}
