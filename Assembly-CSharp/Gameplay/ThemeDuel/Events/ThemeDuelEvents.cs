using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ThemeDuel.Events
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	public class ThemeDuelEvents : AbstractMVCEvents
	{
		// Token: 0x06001E06 RID: 7686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x6F84", Offset = "0x6F84", VA = "0x6F84")]
		public ThemeDuelEvents()
		{
		}

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x14")]
		public Action GetStoreItemsInfoEvent;
	}
}
