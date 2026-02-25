using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x20007D7")]
	public class OpenPageGroupActionOnEvent_6 : AbstractActionOnEvent
	{
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x1700092E")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F06")]
			[Address(RVA = "0x7F73", Offset = "0x7F73", VA = "0x7F73", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x7F74", Offset = "0x7F74", VA = "0x7F74", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x7F75", Offset = "0x7F75", VA = "0x7F75")]
		public OpenPageGroupActionOnEvent_6()
		{
		}
	}
}
