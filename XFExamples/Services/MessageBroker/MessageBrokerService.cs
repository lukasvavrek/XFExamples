using System.Collections.Generic;
using System.Linq;

namespace XFExamples.Services.MessageBroker
{
	public class MessageBrokerService : IMessageBrokerService
	{
		private object _messagesLock = new object();
		private List<IMessage> _messages = new List<IMessage>();

		public void SendMessage<T>(T message) where T : IMessage
		{
			lock(_messagesLock)
			{
				_messages = _messages.Where(m => m.GetType() != typeof(T)).ToList();
				_messages.Add(message);
			}
		}

		public T ReceiveMessage<T>() where T : IMessage
		{
			lock (_messagesLock)
			{
				return _messages.OfType<T>().FirstOrDefault();
			}
		}
    }
}
