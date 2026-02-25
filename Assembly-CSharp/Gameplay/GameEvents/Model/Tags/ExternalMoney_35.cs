using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	public class ExternalMoney_35 : AbstractTag
	{
		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x170008FE")]
		public double ExternalMoney
		{
			[Token(Token = "0x6002E74")]
			[Address(RVA = "0x7EEF", Offset = "0x7EEF", VA = "0x7EEF")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x7EF0", Offset = "0x7EF0", VA = "0x7EF0", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x7EF1", Offset = "0x7EF1", VA = "0x7EF1")]
		public ExternalMoney_35()
		{
		}
	}
}
