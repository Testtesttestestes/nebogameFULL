using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	public class RouteToAuchanActionOnEvent : AbstractActionOnEvent
	{
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x17000930")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F0C")]
			[Address(RVA = "0x7F79", Offset = "0x7F79", VA = "0x7F79", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0D")]
		[Address(RVA = "0x7F7A", Offset = "0x7F7A", VA = "0x7F7A", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x7F7B", Offset = "0x7F7B", VA = "0x7F7B")]
		public RouteToAuchanActionOnEvent()
		{
		}
	}
}
