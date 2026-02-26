using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Model;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Il2CppDummyDll;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.BankOptions.Controller
{
	// Token: 0x02001221 RID: 4641
	[Token(Token = "0x2001221")]
	public class BankOptionsAdPlacementController : AbstractAdPlacementController<BankOptionsAdPlacementModel, BankOptionsAdPlacementEvents>
	{
		// Token: 0x06006DE0 RID: 28128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0xB899", Offset = "0xB899", VA = "0xB899")]
		public BankOptionsAdPlacementController(BankOptionsAdPlacementModel model, BankOptionsAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BankOptions_Controller_BankOptionsAdPlacementController___ctor
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
		  
		  if (DAT_ram_00a5a7b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24705);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3783);
		    DAT_ram_00a5a7b3 = '\x01';
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
		        goto code_r0x8126e42e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,4);
		code_r0x8126e42e:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  local_1 = (char)iVar2;
		  uVar4 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  local_2 = (char)iVar2;
		  param3 = func_ii_1081(DAT_ram_00a66944,&local_2);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_24705,uVar4,param3,0);
		  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3783,uVar4,0);
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
		          goto code_r0x8126e56e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo
		                                  ,1);
		code_r0x8126e56e:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar4,puVar3[1]);
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DE1")]
		[Address(RVA = "0xB89A", Offset = "0xB89A", VA = "0xB89A")]
		public WaitForCallBack<bool> IsAdAvailable()
		{
			return null;
		}
	}
}
