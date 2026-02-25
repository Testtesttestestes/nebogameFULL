using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	public class StringTag_44 : AbstractTag
	{
		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x1700090F")]
		public int IndexInStringParams
		{
			[Token(Token = "0x6002EA1")]
			[Address(RVA = "0x7F1C", Offset = "0x7F1C", VA = "0x7F1C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x7F1D", Offset = "0x7F1D", VA = "0x7F1D", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x7F1E", Offset = "0x7F1E", VA = "0x7F1E")]
		public StringTag_44()
		{
		}
	}
}
