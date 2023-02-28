using _00P._02_OOP_Pillars.StateAndBehavior;

namespace _00P._04_InheritanceVsComposition.Case01
{
	internal class InheritanceVsCompositionTest
	{
		public InheritanceVsCompositionTest()
		{
			var personInheritance = new PersonExample01()
			{
				Name = "Foo",
				Birthday = DateTime.Now,
				Cpf = "123456789110"
			};

			var personComposition = new PersonExample02()
			{
				Person = new Person()
				{
					Name = "Jhon",
					Birthday= DateTime.Now
				},
				Cpf = "123456789110"
			};

			var nameInheritance = personInheritance.Name;
			var nameComposition = personComposition.Person.Name;
		}
	}
}
