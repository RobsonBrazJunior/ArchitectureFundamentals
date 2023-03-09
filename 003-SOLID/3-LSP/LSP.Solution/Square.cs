namespace SOLID._3_LSP.LSP.Solution
{
	internal class Square : Parallelogram
	{
		public Square(int height, int width) : base(height, width)
		{
			if (height != width)
				throw new ArgumentException("Both sides need to be equal.");
		}
	}
}
