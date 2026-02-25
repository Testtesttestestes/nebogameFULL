using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	public class GoToAccountList_32 : AbstractActionOnEvent
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x1700092B")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002EFD")]
			[Address(RVA = "0x7F6A", Offset = "0x7F6A", VA = "0x7F6A", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x7F6B", Offset = "0x7F6B", VA = "0x7F6B", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x7F6C", Offset = "0x7F6C", VA = "0x7F6C")]
		public GoToAccountList_32()
		{
		}
	}
}
