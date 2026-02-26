using System;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x20007D6")]
	public class NextEventAction_9 : AbstractActionOnEvent
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x1700092D")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F03")]
			[Address(RVA = "0x7F70", Offset = "0x7F70", VA = "0x7F70", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x7F71", Offset = "0x7F71", VA = "0x7F71", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x7F72", Offset = "0x7F72", VA = "0x7F72")]
		public NextEventAction_9()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_NextEventAction_9__get_SortOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_GameEvents_Control_GameEventsController__HandleEventActions
		            (param2,*(undefined4 *)(param1 + 0x10),param1);
		  return;
		}
		*/

}
