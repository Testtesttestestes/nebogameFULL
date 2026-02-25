using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	public class ItemsTag_11 : AbstractTag
	{
		// Token: 0x06002E83 RID: 11907 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x7EFE", Offset = "0x7EFE", VA = "0x7EFE", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x7EFF", Offset = "0x7EFF", VA = "0x7EFF")]
		public ItemsTag_11()
		{
		}
	}
}
