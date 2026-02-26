using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DD RID: 4573
	[Token(Token = "0x20011DD")]
	public class MagicSchoolBuilding : AbstractPathNode
	{
		// Token: 0x06006CC6 RID: 27846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC6")]
		[Address(RVA = "0xB7B2", Offset = "0xB7B2", VA = "0xB7B2", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		/* --- GHIDRA: ExecuteTransition ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_MagicSchoolBuilding__ExecuteTransition
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a722 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a722 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x81261b74;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81261b74:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Gameplay_Isles_Base_Model_BaseIsleModel__GetBuildingLevel
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x20) + 0x10),4,&local_4,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x6006CC7")]
		[Address(RVA = "0xB7B3", Offset = "0xB7B3", VA = "0xB7B3", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC8")]
		[Address(RVA = "0xB7B4", Offset = "0xB7B4", VA = "0xB7B4", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC9")]
		[Address(RVA = "0xB7B5", Offset = "0xB7B5", VA = "0xB7B5")]
		public MagicSchoolBuilding()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_MagicSchoolBuilding___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a723 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		    DAT_ram_00a5a723 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x81261c51;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81261c51:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar3 = Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),3,
		                     Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		                    );
		  if (iVar3 != 0) {
		    Core_ExternAppMethods__OpenPaymentWindow
		              (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		    return;
		  }
		  Utils_OpToken_object__object___DisposeHandlers
		            (param3,param1,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		  return;
		}
		*/

		}
	}
}
