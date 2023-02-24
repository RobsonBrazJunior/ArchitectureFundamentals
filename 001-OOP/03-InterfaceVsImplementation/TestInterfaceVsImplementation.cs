namespace _00P._03_InterfaceVsImplementation
{
	internal class TestInterfaceVsImplementation
	{
		public TestInterfaceVsImplementation()
		{
			var repoImp = new UseImplementation();
			repoImp.Process();

			var repoAbs = new UseAbstraction(new Repository());
			repoAbs.Process();

			var repoAbsFake = new UseAbstraction(new RepositoryFake());
			repoAbsFake.Process();
		}
	}
}
