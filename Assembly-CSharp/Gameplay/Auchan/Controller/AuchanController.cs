using System;
using Core.Data;
using Gameplay.Auchan.Events;
using Gameplay.Auchan.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Auchan.Controller
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	public class AuchanController : AbstractController<AuchanModel, AuchanEvents>
	{
		// Token: 0x06004E92 RID: 20114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x9CC3", Offset = "0x9CC3", VA = "0x9CC3")]
		public AuchanController(AuchanService service, AuchanModel model, AuchanEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_Controller_AuchanController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Auchan_Controller_AuchanController__BuyAuchanItemHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x9CC4", Offset = "0x9CC4", VA = "0x9CC4", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		undefined4
		Gameplay_Auchan_Controller_AuchanController__HandleRun
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint uVar7;
		  int iVar8;
		  uint uVar9;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5895f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9117);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2638);
		    DAT_ram_00a5895f = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x14);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0x120);
		        goto code_r0x80f4d01b;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f4d01b:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar8 = **(int **)(iVar2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x128) * 4))
		                    (*(int **)(iVar2 + 0x10),param2,*(undefined4 *)(iVar8 + 300));
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar8 + 0x14);
		  iVar8 = *piVar6;
		  uVar7 = (uint)*(ushort *)(iVar8 + 0xb6);
		  if (iVar2 == 0) {
		    if (uVar7 != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x80f4d2fe;
		        }
		        uVar9 = uVar9 + 1;
		      } while (uVar7 != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4d2fe:
		    piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar7 = 0;
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x80f4d37a;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,6);
		code_r0x80f4d37a:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_2638,1,0,1,0,0,0,0);
		    uVar5 = UI_Toast_ToastController_ToastData__GetUiResourceIdByTheme(3,uVar5,param2,0);
		    UI_Toast_ToastController__OnReleaseToast(uVar4,uVar5,0);
		  }
		  else {
		    if (uVar7 != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x120);
		          goto code_r0x80f4d0d9;
		        }
		        uVar9 = uVar9 + 1;
		      } while (uVar7 != uVar9);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f4d0d9:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar2 = Gameplay_Inventory_Model_InventoryBaseModel__ParseSlotChanges
		                      (*(undefined4 *)(iVar2 + 0x10),param2,&local_4,0);
		    uVar1 = local_4;
		    if (iVar2 == 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      piVar6 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x80f4d1c7;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4d1c7:
		      piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      uVar7 = 0;
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0xf0);
		            goto code_r0x80f4d247;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,6);
		code_r0x80f4d247:
		      uVar1 = 0;
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9117,1,0,1,0,0,0,0);
		      uVar5 = UI_Toast_ToastController_ToastData__GetUiResourceIdByTheme(3,uVar5,param2,0);
		      UI_Toast_ToastController__OnReleaseToast(uVar4,uVar5,0);
		    }
		    else {
		      local_10 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor(&local_10,local_4,Method_System_Nullable_uint___ctor__);
		      local_18 = local_10;
		      local_20 = local_10;
		      uVar1 = Gameplay_Auchan_Controller_AuchanController__TryStartBuy
		                        (param1,param2,&local_20,uVar1);
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x9CC5", Offset = "0x9CC5", VA = "0x9CC5")]
		public bool TryStartBuyAndEquip(ArtifactData item)
		{
		/* --- GHIDRA: TryStartBuyAndEquip ---
		undefined4
		Gameplay_Auchan_Controller_AuchanController__TryStartBuyAndEquip
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = 0;
		  local_8 = 0;
		  uVar1 = Gameplay_Auchan_Controller_AuchanController__TryStartBuy
		                    (param1,param2,&local_10,&local_10);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x9CC6", Offset = "0x9CC6", VA = "0x9CC6")]
		public bool TryStartBuy(ArtifactData item)
		{
		/* --- GHIDRA: TryStartBuy ---
		void Gameplay_Auchan_Controller_AuchanController__TryStartBuy
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined8 uVar7;
		  int *piVar8;
		  int *piVar9;
		  uint uVar10;
		  undefined4 *puVar11;
		  undefined4 uVar12;
		  undefined4 uVar13;
		  int local_4;
		  
		  if (DAT_ram_00a58961 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuchanScope_AuchanEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedAuchanError__ExpectedBillingErrors__ExpectedItemErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Auchan_ProtoBuyAuchanItemAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0__BuyAuchanItemHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9179);
		    DAT_ram_00a58961 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0_TypeInfo);
		  *(int **)(iVar1 + 8) = param1;
		  iVar2 = Core_Data_ArtifactData_TypeInfo;
		  piVar8 = *(int **)(param2 + 0x20);
		  if ((piVar8 != (int *)0x0) && (Protocol_Auchan_ProtoBuyAuchanItemAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance(piVar8,Protocol_Auchan_ProtoBuyAuchanItemAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9 = *(int **)(param2 + 0xc);
		  if (piVar9 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		code_r0x80f4d66b:
		    puVar11 = (undefined4 *)(iVar1 + 0xc);
		    uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar12 = *(undefined4 *)(iVar2 + 8);
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = 0;
		    piVar9 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x1f8);
		          goto code_r0x80f4d712;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f4d712:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar13 = *puVar11;
		    uVar10 = 0;
		    uVar5 = unnamed_function_1417(Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar5,uVar12,uVar4,uVar13,0);
		    uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    piVar9 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80f4d7ce;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f4d7ce:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar12 = *(undefined4 *)(iVar2 + 0x14);
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = 0;
		    piVar9 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x80f4d86e;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4d86e:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    piVar9 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = 0;
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x80f4d8f0;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,6);
		code_r0x80f4d8f0:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar2 = unnamed_function_1417(Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(iVar2,uVar12,uVar4,1,0);
		    uVar12 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar12,iVar1,
		               Method_Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0__BuyAuchanItemHandler_b__0__
		               ,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar12;
		    iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		                      (piVar8[3],uVar5,0,iVar2,
		                       Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedAuchanError__ExpectedBillingErrors__ExpectedItemErrors___
		                      );
		    if (iVar2 == 0) {
		      uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      piVar9 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar9;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x120)
		            ;
		            goto code_r0x80f4d9e0;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f4d9e0:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		                (*(undefined4 *)(iVar2 + 0x14),piVar8[4],
		                 Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		                );
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104)));
		      uVar7 = func_ii_7957(*puVar11,0);
		      iVar2 = Gameplay_Auchan_Model_AuchanModel___ctor(uVar6,uVar7,&local_4,0);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if ((iVar2 != 0) && (piVar8 = *(int **)(local_4 + 0x20), piVar8 != (int *)0x0)) {
		        uVar10 = 0;
		        iVar2 = *piVar8;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 200)
		              ;
		              goto code_r0x80f4dab2;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,Protocol_IActionInfo_TypeInfo,1);
		code_r0x80f4dab2:
		        uVar7 = CONCAT44(uVar6,puVar3[1]);
		        iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        uVar10 = 0;
		        iVar1 = *piVar8;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xd0
		                               );
		              goto code_r0x80f4db35;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,Protocol_IActionInfo_TypeInfo,2);
		code_r0x80f4db35:
		        uVar7 = CONCAT44(uVar6,iVar2 + -1);
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7,puVar3[1]);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      piVar8 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x80f4dbcd;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4dbcd:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      piVar8 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar10 = 0;
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x100)
		            ;
		            goto code_r0x80f4dc4f;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,8);
		code_r0x80f4dc4f:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x74) + 8);
		      if (iVar2 != 0) {
		        uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        uVar10 = 0;
		        piVar8 = *(int **)(iVar1 + 0x14);
		        iVar1 = *piVar8;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xe0
		                               );
		              goto code_r0x80f4dcf3;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4dcf3:
		        uVar7 = CONCAT44(uVar6,puVar3[1]);
		        uVar12 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		        uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        uVar5 = *(undefined4 *)(iVar1 + 0x14);
		        uVar13 = *puVar11;
		        uVar4 = unnamed_function_1417(Core_Events_Scopes_AuchanScope_AuchanEventArgs_TypeInfo);
		        Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar12,uVar5,uVar13,0);
		        uVar7 = CONCAT44(uVar6,uVar4);
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar7,*(undefined4 *)(iVar2 + 0x14));
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar10 = 0;
		      piVar8 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x80f4dde0;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4dde0:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      piVar8 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar10 = 0;
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xf8);
		            goto code_r0x80f4de62;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,7);
		code_r0x80f4de62:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      uVar12 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9179,1,0,1,0,0,0,0);
		      UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration(uVar12,uVar4,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x114)));
		      iVar2 = *(int *)(iVar2 + 0x18);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		    return;
		  }
		  uVar10 = (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8);
		  if ((uVar10 <= *(byte *)(*piVar9 + 0xb8)) &&
		     (*(int *)(*(int *)(*piVar9 + 100) + (uVar10 - 1) * 4) == Core_Data_ArtifactData_TypeInfo)) {
		    *(int **)(iVar1 + 0xc) = piVar9;
		    if ((uVar10 <= *(byte *)(*piVar9 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar9 + 100) + (uVar10 - 1) * 4) == iVar2)) goto code_r0x80f4d66b;
		  }
		  System_Activator__CreateInstance(piVar9,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: TryStartBuy ---
		void Gameplay_Auchan_Controller_AuchanController__TryStartBuy
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined8 uVar7;
		  int *piVar8;
		  int *piVar9;
		  uint uVar10;
		  undefined4 *puVar11;
		  undefined4 uVar12;
		  undefined4 uVar13;
		  int local_4;
		  
		  if (DAT_ram_00a58961 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuchanScope_AuchanEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedAuchanError__ExpectedBillingErrors__ExpectedItemErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Auchan_ProtoBuyAuchanItemAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0__BuyAuchanItemHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9179);
		    DAT_ram_00a58961 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0_TypeInfo);
		  *(int **)(iVar1 + 8) = param1;
		  iVar2 = Core_Data_ArtifactData_TypeInfo;
		  piVar8 = *(int **)(param2 + 0x20);
		  if ((piVar8 != (int *)0x0) && (Protocol_Auchan_ProtoBuyAuchanItemAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance(piVar8,Protocol_Auchan_ProtoBuyAuchanItemAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9 = *(int **)(param2 + 0xc);
		  if (piVar9 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		code_r0x80f4d66b:
		    puVar11 = (undefined4 *)(iVar1 + 0xc);
		    uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar12 = *(undefined4 *)(iVar2 + 8);
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = 0;
		    piVar9 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x1f8);
		          goto code_r0x80f4d712;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f4d712:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar13 = *puVar11;
		    uVar10 = 0;
		    uVar5 = unnamed_function_1417(Core_Errors_Expected_ExpectedAuchanError_ErrorArgs_TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar5,uVar12,uVar4,uVar13,0);
		    uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    piVar9 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80f4d7ce;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f4d7ce:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar12 = *(undefined4 *)(iVar2 + 0x14);
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = 0;
		    piVar9 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x80f4d86e;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4d86e:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    piVar9 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = 0;
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x80f4d8f0;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,6);
		code_r0x80f4d8f0:
		    uVar7 = CONCAT44(uVar6,puVar3[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		    uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar2 = unnamed_function_1417(Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(iVar2,uVar12,uVar4,1,0);
		    uVar12 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar12,iVar1,
		               Method_Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0__BuyAuchanItemHandler_b__0__
		               ,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar12;
		    iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		                      (piVar8[3],uVar5,0,iVar2,
		                       Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedAuchanError__ExpectedBillingErrors__ExpectedItemErrors___
		                      );
		    if (iVar2 == 0) {
		      uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      piVar9 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar9;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x120)
		            ;
		            goto code_r0x80f4d9e0;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80f4d9e0:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		                (*(undefined4 *)(iVar2 + 0x14),piVar8[4],
		                 Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		                );
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104)));
		      uVar7 = func_ii_7957(*puVar11,0);
		      iVar2 = Gameplay_Auchan_Model_AuchanModel___ctor(uVar6,uVar7,&local_4,0);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if ((iVar2 != 0) && (piVar8 = *(int **)(local_4 + 0x20), piVar8 != (int *)0x0)) {
		        uVar10 = 0;
		        iVar2 = *piVar8;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 200)
		              ;
		              goto code_r0x80f4dab2;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,Protocol_IActionInfo_TypeInfo,1);
		code_r0x80f4dab2:
		        uVar7 = CONCAT44(uVar6,puVar3[1]);
		        iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        uVar10 = 0;
		        iVar1 = *piVar8;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xd0
		                               );
		              goto code_r0x80f4db35;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,Protocol_IActionInfo_TypeInfo,2);
		code_r0x80f4db35:
		        uVar7 = CONCAT44(uVar6,iVar2 + -1);
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7,puVar3[1]);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      piVar8 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x80f4dbcd;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4dbcd:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      piVar8 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar10 = 0;
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x100)
		            ;
		            goto code_r0x80f4dc4f;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,8);
		code_r0x80f4dc4f:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      iVar2 = *(int *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x74) + 8);
		      if (iVar2 != 0) {
		        uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        uVar10 = 0;
		        piVar8 = *(int **)(iVar1 + 0x14);
		        iVar1 = *piVar8;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xe0
		                               );
		              goto code_r0x80f4dcf3;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4dcf3:
		        uVar7 = CONCAT44(uVar6,puVar3[1]);
		        uVar12 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		        uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        uVar5 = *(undefined4 *)(iVar1 + 0x14);
		        uVar13 = *puVar11;
		        uVar4 = unnamed_function_1417(Core_Events_Scopes_AuchanScope_AuchanEventArgs_TypeInfo);
		        Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar12,uVar5,uVar13,0);
		        uVar7 = CONCAT44(uVar6,uVar4);
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar7,*(undefined4 *)(iVar2 + 0x14));
		        uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      uVar7 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar10 = 0;
		      piVar8 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x80f4dde0;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4dde0:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      piVar8 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar10 = 0;
		      iVar2 = *piVar8;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0xf8);
		            goto code_r0x80f4de62;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,7);
		code_r0x80f4de62:
		      uVar7 = CONCAT44(uVar6,puVar3[1]);
		      uVar12 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,uVar7);
		      uVar6 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9179,1,0,1,0,0,0,0);
		      UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration(uVar12,uVar4,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x114)));
		      iVar2 = *(int *)(iVar2 + 0x18);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		    return;
		  }
		  uVar10 = (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8);
		  if ((uVar10 <= *(byte *)(*piVar9 + 0xb8)) &&
		     (*(int *)(*(int *)(*piVar9 + 100) + (uVar10 - 1) * 4) == Core_Data_ArtifactData_TypeInfo)) {
		    *(int **)(iVar1 + 0xc) = piVar9;
		    if ((uVar10 <= *(byte *)(*piVar9 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar9 + 100) + (uVar10 - 1) * 4) == iVar2)) goto code_r0x80f4d66b;
		  }
		  System_Activator__CreateInstance(piVar9,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x9CC7", Offset = "0x9CC7", VA = "0x9CC7")]
		private bool TryStartBuy(ArtifactData item, uint? slotId)
		{
			return default(bool);
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E97")]
		[Address(RVA = "0x9CC8", Offset = "0x9CC8", VA = "0x9CC8")]
		private void BuyAuchanItemHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyAuchanItemHandler ---
		void Gameplay_Auchan_Controller_AuchanController__BuyAuchanItemHandler(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58962 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanController_GetAuchanItemsInfoSuccessHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58962 = '\x01';
		  }
		  uVar1 = ServicesNamespace_AuchanService__get_ServiceId(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Auchan_Controller_AuchanController_GetAuchanItemsInfoSuccessHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E98")]
		[Address(RVA = "0x9CC9", Offset = "0x9CC9", VA = "0x9CC9")]
		private void GetAuchanItemsInfo()
		{
		/* --- GHIDRA: GetAuchanItemsInfo ---
		void Gameplay_Auchan_Controller_AuchanController__GetAuchanItemsInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58963 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Auchan_ProtoGetAuchanItemsInfoAns_TypeInfo);
		    DAT_ram_00a58963 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Auchan_ProtoGetAuchanItemsInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Auchan_ProtoGetAuchanItemsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Auchan_Model_AuchanModel__GetAllArtikulTypeFilters(param1_00,param1_01[3],0);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x9CCA", Offset = "0x9CCA", VA = "0x9CCA")]
		private void GetAuchanItemsInfoSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x9CCB", Offset = "0x9CCB", VA = "0x9CCB")]
		private void ValidateInit()
		{
		}

		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x18")]
		private readonly AuchanService _service;
	}
}
