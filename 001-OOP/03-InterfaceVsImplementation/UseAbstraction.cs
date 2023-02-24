namespace _00P._03_InterfaceVsImplementation
{
	internal class UseAbstraction
	{
		private readonly IRepository _repository;

		internal UseAbstraction(IRepository repository)
		{
			_repository = repository;
		}

		internal void Process()
		{
			_repository.Add();
		}
	}
}
