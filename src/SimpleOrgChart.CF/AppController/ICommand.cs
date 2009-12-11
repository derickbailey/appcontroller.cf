namespace SimpleOrgChart.AppController
{
	public interface ICommand
	{
	}

	public interface ICommand<T>: ICommand
	{
		void Execute(T commandData);
	}
}