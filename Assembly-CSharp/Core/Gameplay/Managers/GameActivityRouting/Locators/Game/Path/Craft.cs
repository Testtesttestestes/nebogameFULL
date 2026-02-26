using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D5 RID: 4565
	[Token(Token = "0x20011D5")]
	public class Craft : AbstractPathNode
	{
		// Token: 0x06006CAB RID: 27819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAB")]
		[Address(RVA = "0xB797", Offset = "0xB797", VA = "0xB797", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAC")]
		[Address(RVA = "0xB798", Offset = "0xB798", VA = "0xB798", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAD")]
		[Address(RVA = "0xB799", Offset = "0xB799", VA = "0xB799")]
		public Craft()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Craft___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a716 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_21070);
		    DAT_ram_00a5a716 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar2 = Core_Rounting_LocatorPayload___ctor(param4,StringLiteral_21070,param1,&local_4,0);
		  if ((iVar2 != 0) && (iVar2 = System_UInt32__Parse(local_4,&local_8,0), iVar2 != 0)) {
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x170);
		          goto code_r0x81260822;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x81260822:
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    Core_Gameplay_Managers_DailyQuestsManager__SetView(param1_00,local_8,0);
		    Core_ExternAppMethods__OpenPaymentWindow
		              (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  }
		  return;
		}
		*/

		}
	}
}
