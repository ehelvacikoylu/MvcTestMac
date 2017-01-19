using System;
namespace MvcTestMac.Service
{

	public interface IMacView
	{
		void Add();
	}


	public class MyClass:IMacView
	{
		public MyClass()
		{
			
		}

		public void Add()
		{
			throw new NotImplementedException();
		}
	}
}
