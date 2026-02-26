using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.View.ActionsOnEvens
{
	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	public class ActionOnEventTextBox : AbstractActionOnEventView
	{
		// Token: 0x06002E04 RID: 11780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x7E82", Offset = "0x7E82", VA = "0x7E82")]
		private void Start()
		{
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x7E83", Offset = "0x7E83", VA = "0x7E83")]
		public ActionOnEventTextBox()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventTextBox___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x24);
		  uVar1 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,4,0);
		  return uVar1;
		}
		*/

		}
	}
}
