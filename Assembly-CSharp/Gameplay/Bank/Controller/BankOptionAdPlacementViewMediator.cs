using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Controller;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Model;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C63 RID: 3171
	[Token(Token = "0x2000C63")]
	public class BankOptionAdPlacementViewMediator : AbstractViewMediator<BankOptionsAdPlacementModel, BankOptionsAdPlacementEvents, BankOptionsAdPlacementController, BankOptionAdPlacementView>
	{
		// Token: 0x06004D79 RID: 19833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x9BB1", Offset = "0x9BB1", VA = "0x9BB1")]
		public BankOptionAdPlacementViewMediator(BankOptionsAdPlacementModel model, BankOptionsAdPlacementEvents events, BankOptionsAdPlacementController controller, BankOptionData bankOptionData)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a597ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_WatchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a597ee = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (param1[8] != 0) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      func_ii_20511(uVar1,param1[8],0);
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_WatchButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_WatchButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar2 + 0x14),1,0);
		    if (param1[8] == 0) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (DAT_ram_00a597f1 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateRoutine_d__10_TypeInfo
		                  );
		        DAT_ram_00a597f1 = '\x01';
		      }
		      iVar2 = unnamed_function_1417
		                        (
		                        Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateRoutine_d__10_TypeInfo
		                        );
		      *(int **)(iVar2 + 0x10) = param1;
		      *(undefined4 *)(iVar2 + 8) = 0;
		      iVar2 = UnityEngine_MonoBehaviour__StartCoroutine(uVar1,iVar2,0);
		      param1[8] = iVar2;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FAF RID: 4015
		// (set) Token: 0x06004D7A RID: 19834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAF")]
		public override BankOptionAdPlacementView View
		{
			[Token(Token = "0x6004D7A")]
			[Address(RVA = "0x9BB2", Offset = "0x9BB2", VA = "0x9BB2", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x9BB3", Offset = "0x9BB3", VA = "0x9BB3")]
		private void WatchButtonClickedEventHandler()
		{
		/* --- GHIDRA: WatchButtonClickedEventHandler ---
		void Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__WatchButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a597f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_ValidateState__);
		    DAT_ram_00a597f0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_ValidateState__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_ValidateState__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FB0 RID: 4016
		// (set) Token: 0x06004D7C RID: 19836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB0")]
		public override BankOptionsAdPlacementEvents Events
		{
			[Token(Token = "0x6004D7C")]
			[Address(RVA = "0x9BB4", Offset = "0x9BB4", VA = "0x9BB4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x9BB5", Offset = "0x9BB5", VA = "0x9BB5")]
		private void ValidateState()
		{
		/* --- GHIDRA: ValidateState ---
		int Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateState
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a597f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateRoutine_d__10_TypeInfo
		              );
		    DAT_ram_00a597f1 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateRoutine_d__10_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x9BB6", Offset = "0x9BB6", VA = "0x9BB6")]
		private IEnumerator ValidateRoutine()
		{
			return null;
		}

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x18")]
		private BankOptionData _bankOptionData;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x1C")]
		private bool _adAvailable;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _validateRoutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a597ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    DAT_ram_00a597ef = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = *(int **)(iVar2 + 0x18);
		  uVar3 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__IsAdAvailable
		                    (param1[2],0);
		  uVar5 = *(undefined4 *)(*(int *)(param1[6] + 0x38) + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81072176;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,
		                                Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo,0);
		code_r0x81072176:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar5,puVar4[1]);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (param1[8] == 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (DAT_ram_00a597f1 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateRoutine_d__10_TypeInfo
		                );
		      DAT_ram_00a597f1 = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator__ValidateRoutine_d__10_TypeInfo
		                      );
		    *(int **)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    iVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1_00,iVar1,0);
		    param1[8] = iVar1;
		  }
		  return;
		}
		*/

}
