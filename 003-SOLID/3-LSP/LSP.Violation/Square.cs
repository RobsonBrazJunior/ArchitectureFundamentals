namespace SOLID._3_LSP.LSP.Violation
{
	internal class Square : Rectangle
	{
		public override double Height
		{
			set { base.Height = base.Width = value; }
		}

		public override double Width
		{
			set { base.Height = base.Width = value; }
		}
	}
}
