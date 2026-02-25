using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x20007A8")]
	public class IntervalTag_16 : AbstractTag
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x17000901")]
		public double Value
		{
			[Token(Token = "0x6002E7D")]
			[Address(RVA = "0x7EF8", Offset = "0x7EF8", VA = "0x7EF8")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x7EF9", Offset = "0x7EF9", VA = "0x7EF9", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x7EFA", Offset = "0x7EFA", VA = "0x7EFA")]
		public IntervalTag_16()
		{
		}

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		public const string INTERVAL_NAME = "interval";
	}
}
