//https://github.com/neosmart/TaskThreads
namespace Thrift.TaskThread
{
	public enum ThreadPriority
	{
		Lowest,
		BelowNormal,
		Normal,
		AboveNormal,
		Highest
	}

	public enum ThreadState
	{
		Running,
		StopRequested,
		SuspendRequested,
		Background,
		Unstarted,
		Stopped,
		WaitSleepJoin,
		Suspended,
		AbortRequested,
		Aborted
	}

	enum StartType
	{
		Standard,
		Parameterized
	};
}
