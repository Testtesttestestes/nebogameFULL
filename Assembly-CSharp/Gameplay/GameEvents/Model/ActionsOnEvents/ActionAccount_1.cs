using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x20007C9")]
	public class ActionAccount_1 : AbstractActionOnEvent
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x17000929")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0x7F59", Offset = "0x7F59", VA = "0x7F59", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EED")]
		[Address(RVA = "0x7F5A", Offset = "0x7F5A", VA = "0x7F5A", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEE")]
		[Address(RVA = "0x7F5B", Offset = "0x7F5B", VA = "0x7F5B")]
		public ActionAccount_1()
		{
		}
	}
}
