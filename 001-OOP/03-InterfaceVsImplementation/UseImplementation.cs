namespace _00P._03_InterfaceVsImplementation
{
	internal class UseImplementation
	{
		internal void Process()
		{
			var repository = new Repository();
			repository.Add();
		}
	}
}
