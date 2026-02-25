using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public class MarketActionOnEvent_4 : AbstractActionOnEvent
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x1700092C")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F00")]
			[Address(RVA = "0x7F6D", Offset = "0x7F6D", VA = "0x7F6D", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x7F6E", Offset = "0x7F6E", VA = "0x7F6E", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x7F6F", Offset = "0x7F6F", VA = "0x7F6F")]
		public MarketActionOnEvent_4()
		{
		}
	}
}
