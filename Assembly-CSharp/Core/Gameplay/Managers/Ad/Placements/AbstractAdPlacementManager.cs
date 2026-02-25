using System;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements
{
	// Token: 0x02001207 RID: 4615
	[Token(Token = "0x2001207")]
	public abstract class AbstractAdPlacementManager : IDisposable
	{
		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06006D7D RID: 28029
		[Token(Token = "0x17001640")]
		public abstract bool AdAvailableByServer { [Token(Token = "0x6006D7D")] get; }

		// Token: 0x06006D7E RID: 28030
		[Token(Token = "0x6006D7E")]
		public abstract void Dispose();

		// Token: 0x06006D7F RID: 28031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0xB854", Offset = "0xB854", VA = "0xB854")]
		protected AbstractAdPlacementManager()
		{
		}
	}
}
