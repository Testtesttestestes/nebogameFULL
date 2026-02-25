using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DE RID: 2014
	[Token(Token = "0x20007DE")]
	public class TextEventAction_10 : AbstractActionOnEvent
	{
		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x17000933")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F1B")]
			[Address(RVA = "0x7F88", Offset = "0x7F88", VA = "0x7F88", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x7F89", Offset = "0x7F89", VA = "0x7F89", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x7F8A", Offset = "0x7F8A", VA = "0x7F8A")]
		public TextEventAction_10()
		{
		}
	}
}
