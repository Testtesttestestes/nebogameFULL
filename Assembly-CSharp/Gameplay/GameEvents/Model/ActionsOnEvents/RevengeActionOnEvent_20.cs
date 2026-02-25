using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x20007D8")]
	public class RevengeActionOnEvent_20 : AbstractActionOnEvent
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x1700092F")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F09")]
			[Address(RVA = "0x7F76", Offset = "0x7F76", VA = "0x7F76", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x7F77", Offset = "0x7F77", VA = "0x7F77", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x7F78", Offset = "0x7F78", VA = "0x7F78")]
		public RevengeActionOnEvent_20()
		{
		}
	}
}
