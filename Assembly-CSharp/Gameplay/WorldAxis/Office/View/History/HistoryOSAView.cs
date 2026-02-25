using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	public class HistoryOSAView : OSADynamicBase<HistoryViewsHolder, BattleHistoryListElement.BattleHistoryListElementArgs>
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x170002C0")]
		protected override int MinElementsToUpdate
		{
			[Token(Token = "0x6001239")]
			[Address(RVA = "0x6433", Offset = "0x6433", VA = "0x6433", Slot = "122")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x6434", Offset = "0x6434", VA = "0x6434", Slot = "119")]
		protected override HistoryViewsHolder CreateViewsHolder()
		{
			return null;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x6435", Offset = "0x6435", VA = "0x6435")]
		public HistoryOSAView()
		{
		}

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		private const int MIN_ELEMENTS_TO_UPDATE = 10;
	}
}
