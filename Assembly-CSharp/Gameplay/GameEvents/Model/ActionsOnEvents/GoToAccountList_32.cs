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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_GoToAccountList_32__get_SortOrder
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a574ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a574ff = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1f8);
		        goto code_r0x80d9abec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80d9abec:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_AccountsManager__Init(param1_00,0);
		  return;
		}
		*/

}
