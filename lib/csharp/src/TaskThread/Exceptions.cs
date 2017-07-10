//https://github.com/neosmart/TaskThreads
using System;

namespace Thrift.TaskThread
{
	public class ThreadStateException : Exception
	{
		public ThreadStateException(string message = "", Exception innerException = null)
			: base(message, innerException)
		{ }
	}

	public class ThreadAbortException: Exception
	{
		public ThreadAbortException(string message = "", Exception innerException = null)
					: base(message, innerException)
		{ }
	}
}
