using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	public class RouteToBillingActionOnEvent : AbstractActionOnEvent
	{
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x17000931")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F0F")]
			[Address(RVA = "0x7F7C", Offset = "0x7F7C", VA = "0x7F7C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x7F7D", Offset = "0x7F7D", VA = "0x7F7D", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x7F7E", Offset = "0x7F7E", VA = "0x7F7E")]
		public RouteToBillingActionOnEvent()
		{
		}
	}
}
