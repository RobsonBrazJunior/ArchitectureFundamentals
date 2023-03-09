namespace SOLID._3_LSP.LSP.Solution
{
	internal abstract class Parallelogram
	{
		public double Height { get; private set; }
		public double Width { get; private set; }
		public double Area
		{
			get { return Height * Width; }
		}

		protected Parallelogram(int height, int width)
		{
			Height = height;
			Width = width;
		}
	}
}
