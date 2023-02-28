using _00P._02_OOP_Pillars.StateAndBehavior;

namespace _00P._04_InheritanceVsComposition.Case02
{
	internal class InheritanceVsCompositionTest02
	{
		public InheritanceVsCompositionTest02()
		{
			var repoInheritance = new RepositoryInheritancePerson();
			repoInheritance.Add(new Person());
			repoInheritance.Delete(new Person());

			var repoComposition = new RepositoryCompositionPerson(new Repository<Person>());
			repoComposition.Add(new Person());
		}
	}
}
