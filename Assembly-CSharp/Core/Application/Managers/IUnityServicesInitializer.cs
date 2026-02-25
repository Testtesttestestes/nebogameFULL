using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200125E RID: 4702
	[Token(Token = "0x200125E")]
	public interface IUnityServicesInitializer
	{
		// Token: 0x06006F79 RID: 28537
		[Token(Token = "0x6006F79")]
		UniTask Run();
	}
}
