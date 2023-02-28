using _00P._02_OOP_Pillars.StateAndBehavior;

namespace _00P._04_InheritanceVsComposition.Case02
{
	internal class RepositoryCompositionPerson : IRepositoryPerson
	{
		private readonly IRepository<Person> _repositoryPerson;

		public RepositoryCompositionPerson(IRepository<Person> repositoryPerson)
		{
			_repositoryPerson = repositoryPerson;
		}

		public void Add(Person obj)
		{
			_repositoryPerson.Add(obj);
		}
	}
}
