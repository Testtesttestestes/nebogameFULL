using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	public class SendGiftActionOnEvent_17 : AbstractActionOnEvent
	{
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x17000932")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x7F83", Offset = "0x7F83", VA = "0x7F83", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x7F84", Offset = "0x7F84", VA = "0x7F84", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x7F85", Offset = "0x7F85", VA = "0x7F85")]
		public SendGiftActionOnEvent_17()
		{
		}
	}
}
