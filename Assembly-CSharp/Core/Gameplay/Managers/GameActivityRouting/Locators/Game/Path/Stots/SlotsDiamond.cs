using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Stots
{
	// Token: 0x020011EA RID: 4586
	[Token(Token = "0x20011EA")]
	public class SlotsDiamond : AbstractPathNode
	{
		// Token: 0x06006CF0 RID: 27888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0xB7DC", Offset = "0xB7DC", VA = "0xB7DC", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0xB7DD", Offset = "0xB7DD", VA = "0xB7DD", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0xB7DE", Offset = "0xB7DE", VA = "0xB7DE")]
		public SlotsDiamond()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Stots_SlotsDiamond___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a732 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a732 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b8);
		        goto code_r0x81263d9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x81263d9e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__Deinit(param1_00,2,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
