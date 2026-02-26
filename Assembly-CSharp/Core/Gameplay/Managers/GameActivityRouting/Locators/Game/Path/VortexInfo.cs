using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E8 RID: 4584
	[Token(Token = "0x20011E8")]
	public class VortexInfo : AbstractPathNode
	{
		// Token: 0x06006CEA RID: 27882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEA")]
		[Address(RVA = "0xB7D6", Offset = "0xB7D6", VA = "0xB7D6", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEB")]
		[Address(RVA = "0xB7D7", Offset = "0xB7D7", VA = "0xB7D7", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEC")]
		[Address(RVA = "0xB7D8", Offset = "0xB7D8", VA = "0xB7D8")]
		public VortexInfo()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_VortexInfo___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a730 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Enum_TryParse_SlotMachineType___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25239);
		    DAT_ram_00a5a730 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar2 = Core_Rounting_LocatorPayload___ctor(param4,StringLiteral_25239,param1,&local_4,0);
		  uVar4 = local_4;
		  if (iVar2 == 0) {
		    Utils_OpToken_object__object___DisposeHandlers
		              (param3,param1,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		  }
		  else {
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar2 = Sirenix_Utilities_EmitUtilities__CreateWeakInstanceMethodCallerFunc___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (uVar4,&local_8,Method_System_Enum_TryParse_SlotMachineType___);
		    if (iVar2 == 0) {
		      Utils_OpToken_object__object___DisposeHandlers
		                (param3,param1,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		    }
		    else {
		      iVar2 = *param2;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1b8);
		            goto code_r0x81263bed;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x81263bed:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		      Core_Gameplay_Managers_SmallGamesManager__Deinit(uVar4,local_8,0);
		      Core_ExternAppMethods__OpenPaymentWindow
		                (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		    }
		  }
		  return;
		}
		*/

		}
	}
}
