namespace _00P._04_InheritanceVsComposition.Case02
{
	internal interface IRepository<T>
	{
		void Add(T obj);
		void Delete(T obj);
	}
}
