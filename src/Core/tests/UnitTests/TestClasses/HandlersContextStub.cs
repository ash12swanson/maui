using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Maui.Tests
{ 
	class HandlersContextStub : IMauiContext
	{
		readonly IServiceProvider _services;
		readonly IMauiHandlersServiceProvider _mauiHandlersServiceProvider;

		public HandlersContextStub(IServiceProvider services)
		{
			_services = services;
			_mauiHandlersServiceProvider = Services.GetService<IMauiHandlersServiceProvider>() ?? throw new NullReferenceException(nameof(IMauiServiceProvider));
		}
		
		public IServiceProvider Services => _services;

		public IMauiHandlersServiceProvider Handlers => _mauiHandlersServiceProvider;
	}
}