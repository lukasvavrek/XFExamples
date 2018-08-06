namespace XFExamples.Services.MessageBroker
{
	public interface IMessageBrokerService
    {
		void SendMessage<T>(T message) where T : IMessage;
		T ReceiveMessage<T>() where T : IMessage;
    }
}
