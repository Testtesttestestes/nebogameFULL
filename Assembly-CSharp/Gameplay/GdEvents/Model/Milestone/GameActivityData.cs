using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model.Milestone
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	public class GameActivityData
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008A3")]
		public string Uri
		{
			[Token(Token = "0x6002CCC")]
			[Address(RVA = "0x7D52", Offset = "0x7D52", VA = "0x7D52")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x7D53", Offset = "0x7D53", VA = "0x7D53")]
		public GameActivityData(GameActivityDic dict, GameActivityDic.Types.URI activity)
		{
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x7D54", Offset = "0x7D54", VA = "0x7D54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		[FieldOffset(Offset = "0x8")]
		public readonly GameActivityDic Dict;

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0xC")]
		private GameActivityDic.Types.URI _activity;
	}
}
