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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_RouteToAuchanActionOnEvent__get_SortOrder
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57503 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57503 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x80d9b7dc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80d9b7dc:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowBank(param1_00,0);
		  return;
		}
		*/

}
