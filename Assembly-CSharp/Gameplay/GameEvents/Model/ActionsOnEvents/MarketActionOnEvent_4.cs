using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public class MarketActionOnEvent_4 : AbstractActionOnEvent
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x1700092C")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F00")]
			[Address(RVA = "0x7F6D", Offset = "0x7F6D", VA = "0x7F6D", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x7F6E", Offset = "0x7F6E", VA = "0x7F6E", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x7F6F", Offset = "0x7F6F", VA = "0x7F6F")]
		public MarketActionOnEvent_4()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_MarketActionOnEvent_4__get_SortOrder
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57500 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57500 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1b0);
		        goto code_r0x80d9acc0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80d9acc0:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80d9ad6c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80d9ad6c:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowGifts(param1_00,uVar3,0);
		  return;
		}
		*/

}
