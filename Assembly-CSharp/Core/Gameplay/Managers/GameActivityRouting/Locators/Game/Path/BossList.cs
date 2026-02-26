using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CF RID: 4559
	[Token(Token = "0x20011CF")]
	public class BossList : AbstractPathNode
	{
		// Token: 0x06006C96 RID: 27798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C96")]
		[Address(RVA = "0xB782", Offset = "0xB782", VA = "0xB782", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C97")]
		[Address(RVA = "0xB783", Offset = "0xB783", VA = "0xB783", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C98")]
		[Address(RVA = "0xB784", Offset = "0xB784", VA = "0xB784")]
		public BossList()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_BossList___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a70c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		    DAT_ram_00a5a70c = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x8125f8c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125f8c8:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar3 = Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),5,
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
