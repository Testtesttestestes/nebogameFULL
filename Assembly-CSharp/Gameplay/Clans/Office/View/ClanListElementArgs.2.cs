using System;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FA RID: 2554
	[Token(Token = "0x20009FA")]
	public class ClanListElementArgs<TExtraInfo, YListElement> : ClanListElementArgs<YListElement>
	{
		// Token: 0x06003CD8 RID: 15576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD8")]
		public ClanListElementArgs()
		{
		}

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x0")]
		public TExtraInfo ExtraClanInfo;
	}
}
