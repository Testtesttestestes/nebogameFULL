using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Model;
using Il2CppDummyDll;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.DailyQuests.Controller
{
	// Token: 0x02001212 RID: 4626
	[Token(Token = "0x2001212")]
	public class DailyQuestsAdPlacementController : AbstractAdPlacementController<DailyQuestsAdPlacementModel, DailyQuestsAdPlacementEvents>
	{
		// Token: 0x06006DB0 RID: 28080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB0")]
		[Address(RVA = "0xB870", Offset = "0xB870", VA = "0xB870")]
		public DailyQuestsAdPlacementController(DailyQuestsAdPlacementModel model, DailyQuestsAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_DailyQuests_Controller_DailyQuestsAdPlacementController___ctor
		          (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param3;
		  int *piVar5;
		  undefined1 local_2;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a5a793 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24705);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6256);
		    DAT_ram_00a5a793 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar5 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x8126b513;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,4);
		code_r0x8126b513:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  local_1 = (char)iVar2;
		  uVar4 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  local_2 = (char)iVar2;
		  param3 = func_ii_1081(DAT_ram_00a66944,&local_2);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_24705,uVar4,param3,0);
		  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_6256,uVar4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  if (iVar2 == 0) {
		    uVar4 = unnamed_function_1417(Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		              (uVar4,0,Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		  }
		  else {
		    piVar5 = (int *)param1[6];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = *(undefined4 *)(iVar2 + 0xc);
		    uVar1 = 0;
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x8126b653;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo
		                                  ,1);
		code_r0x8126b653:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar4,puVar3[1]);
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0xB871", Offset = "0xB871", VA = "0xB871")]
		public WaitForCallBack<bool> IsAdAvailable()
		{
		/* --- GHIDRA: IsAdAvailable ---
		void Core_Gameplay_Managers_Ad_Placements_DailyQuests_Controller_DailyQuestsAdPlacementController__IsAdAvailable
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  if (DAT_ram_00a5a794 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a794 = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1,param2,param5,param6,param7,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param4;
		  *(undefined4 *)(param1 + 0x24) = param3;
		  return;
		}
		*/

			return null;
		}
	}
}
