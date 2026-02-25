using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	public class IntTag_1 : AbstractTag
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x17000900")]
		public double Value
		{
			[Token(Token = "0x6002E7A")]
			[Address(RVA = "0x7EF5", Offset = "0x7EF5", VA = "0x7EF5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x7EF6", Offset = "0x7EF6", VA = "0x7EF6", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x7EF7", Offset = "0x7EF7", VA = "0x7EF7")]
		public IntTag_1()
		{
		}
	}
}
