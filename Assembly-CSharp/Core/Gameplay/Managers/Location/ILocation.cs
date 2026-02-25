using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Location
{
	// Token: 0x020011BC RID: 4540
	[Token(Token = "0x20011BC")]
	public interface ILocation
	{
		// Token: 0x06006BF4 RID: 27636
		[Token(Token = "0x6006BF4")]
		UniTask ForwardLocation();
	}
}
