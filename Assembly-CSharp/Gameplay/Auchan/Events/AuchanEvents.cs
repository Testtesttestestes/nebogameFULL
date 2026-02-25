using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Auchan.Events
{
	// Token: 0x02000C97 RID: 3223
	[Token(Token = "0x2000C97")]
	public class AuchanEvents : AbstractMVCEvents
	{
		// Token: 0x06004E7B RID: 20091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E7B")]
		[Address(RVA = "0x9CAC", Offset = "0x9CAC", VA = "0x9CAC")]
		public AuchanEvents()
		{
		}

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x14")]
		public Action OnAuchanItemsInfoRequestedEvent;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		[FieldOffset(Offset = "0x18")]
		public Action OnAuchanItemBought;
	}
}
