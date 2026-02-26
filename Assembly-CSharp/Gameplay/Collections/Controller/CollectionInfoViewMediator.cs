using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Collections.Controller
{
	// Token: 0x020009E6 RID: 2534
	[Token(Token = "0x20009E6")]
	public class CollectionInfoViewMediator : AbstractViewMediator<CollectionsModel, CollectionsEvents, CollectionsController, CollectionInfoWindow>
	{
		// Token: 0x06003C7D RID: 15485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7D")]
		[Address(RVA = "0x8B44", Offset = "0x8B44", VA = "0x8B44")]
		public CollectionInfoViewMediator(CollectionsModel model, CollectionsEvents events, CollectionsController controller, uint collectionId, uint rank)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ed1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_NextButtonClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_PrevButtonClicked__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UpgradeButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57ed1 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UpgradeButtonClickEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_NextButtonClicked__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_PrevButtonClicked__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UpgradeButtonClickEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_NextButtonClicked__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_PrevButtonClicked__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar2 + 0x60),0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 8) != '\0') {
		      Gameplay_Collections_Controller_CollectionInfoViewMediator__set_View(param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000BEC RID: 3052
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEC")]
		public override CollectionInfoWindow View
		{
			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x8B45", Offset = "0x8B45", VA = "0x8B45", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x8B46", Offset = "0x8B46", VA = "0x8B46")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__Init(int param1,undefined4 param2)
		
		{
		  *(int *)(param1 + 0x20) = *(int *)(param1 + 0x20) + -1;
		  Gameplay_Collections_Controller_CollectionInfoViewMediator__CollectionUpgradeRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x8B47", Offset = "0x8B47", VA = "0x8B47")]
		private void PrevButtonClicked()
		{
		/* --- GHIDRA: PrevButtonClicked ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__PrevButtonClicked
		               (int param1,undefined4 param2)
		
		{
		  *(int *)(param1 + 0x20) = *(int *)(param1 + 0x20) + 1;
		  Gameplay_Collections_Controller_CollectionInfoViewMediator__CollectionUpgradeRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x8B48", Offset = "0x8B48", VA = "0x8B48")]
		private void NextButtonClicked()
		{
		/* --- GHIDRA: NextButtonClicked ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__NextButtonClicked
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x54),(uint)(param1[8] != 1),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x50);
		  iVar2 = param1[8];
		  iVar1 = Core_Data_CollectionData__get_CollectionsDic(param1[6],0);
		  System_Linq_Enumerable__First_object_(param1_00,(uint)(iVar2 != iVar1),0);
		  return;
		}
		*/

		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x8B49", Offset = "0x8B49", VA = "0x8B49")]
		private void ValidatePrevNextButtons()
		{
		/* --- GHIDRA: ValidatePrevNextButtons ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__ValidatePrevNextButtons
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Collections_Controller_CollectionsController__GetUserCollectionsSuccessHandler
		            (param1_00,param1[6],param1);
		  return;
		}
		*/

		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C83")]
		[Address(RVA = "0x8B4A", Offset = "0x8B4A", VA = "0x8B4A")]
		private void CollectionUpgradeRequestedEventHandler()
		{
		/* --- GHIDRA: CollectionUpgradeRequestedEventHandler ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__CollectionUpgradeRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int iVar3;
		  uint param2_01;
		  undefined4 local_c;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a57ed3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__get_Model__
		              );
		    DAT_ram_00a57ed3 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_8 = param1[6];
		  local_4 = param1[8];
		  local_c = uVar1;
		  Gameplay_Collections_View_CollectionInfoWindow___ctor(uVar1,&local_c,param1);
		  Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__UpdateStatusText_27_1
		            (uVar1,&local_c,param1);
		  Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__UpdateButtonText_27_0
		            (uVar1,&local_c,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x4c);
		  if (DAT_ram_00a57ed5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__get_Model__
		              );
		    DAT_ram_00a57ed5 = '\x01';
		  }
		  iVar3 = param1[2];
		  iVar2 = Gameplay_Collections_Model_CollectionDicGroup__GetMedal
		                    (*(undefined4 *)(param1[6] + 0x18),param1[8],param1);
		  param2_00 = Gameplay_Collections_Model_CollectionsModel__SortCollections
		                        (iVar3,*(undefined4 *)(iVar2 + 0x14),param1);
		  Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs___ctor
		            (uVar1,param2_00,*(undefined4 *)(param1[2] + 8),(uint)*(byte *)(param1[2] + 0x18),param1
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x48),0);
		  if (*(char *)(param1[2] + 0x18) == '\0') {
		    param2_01 = 0;
		  }
		  else {
		    param2_01 = (uint)(*(int *)(param1[6] + 0x1c) == param1[8] + -1);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_01,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x54),(uint)(param1[8] != 1),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x50);
		  iVar3 = param1[8];
		  iVar2 = Core_Data_CollectionData__get_CollectionsDic(param1[6],0);
		  System_Linq_Enumerable__First_object_(uVar1,(uint)(iVar3 != iVar2),0);
		  return;
		}
		*/

		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C84")]
		[Address(RVA = "0x8B4B", Offset = "0x8B4B", VA = "0x8B4B")]
		private void UpdateWindow()
		{
		/* --- GHIDRA: UpdateWindow ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__UpdateWindow
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57ed4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_Init__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UpdateWindow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UserCollectionImprovedEventHandler__
		              );
		    DAT_ram_00a57ed4 = '\x01';
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
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UserCollectionImprovedEventHandler__
		               ,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_Init__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UpdateWindow__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UserCollectionImprovedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_Init__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_UpdateWindow__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000BED RID: 3053
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BED")]
		public override CollectionsEvents Events
		{
			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x8B4C", Offset = "0x8B4C", VA = "0x8B4C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C86")]
		[Address(RVA = "0x8B4D", Offset = "0x8B4D", VA = "0x8B4D")]
		private void UserCollectionImprovedEventHandler()
		{
		/* --- GHIDRA: UserCollectionImprovedEventHandler ---
		undefined4
		Gameplay_Collections_Controller_CollectionInfoViewMediator__UserCollectionImprovedEventHandler
		          (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57ed5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__get_Model__
		              );
		    DAT_ram_00a57ed5 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 8);
		  iVar1 = Gameplay_Collections_Model_CollectionDicGroup__GetMedal
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x18),*(undefined4 *)(param1 + 0x20),
		                     param1);
		  uVar2 = Gameplay_Collections_Model_CollectionsModel__SortCollections
		                    (uVar2,*(undefined4 *)(iVar1 + 0x14),param1);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C87")]
		[Address(RVA = "0x8B4E", Offset = "0x8B4E", VA = "0x8B4E")]
		private List<CollectionsModel.CollectionMaterial> GetRequirements()
		{
		/* --- GHIDRA: GetRequirements ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__GetRequirements
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a57ed6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Collections_View_CollectionConfirmationWindow_CollectionConfirmationWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_CollectionUpgradeRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_CollectionConfirmationWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4372);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12598);
		    DAT_ram_00a57ed6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		        goto code_r0x80e7ab88;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e7ab88:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar5 = Core_Data_CollectionData__get_NextMedalDic(*(undefined4 *)(param1 + 0x18),0);
		  iVar5 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckPrice
		                    (uVar3,*(undefined4 *)(iVar5 + 0x14),
		                     *(undefined4 *)(*(int *)(param1 + 8) + 0x14),0);
		  uVar3 = System_Uri___ctor(0);
		  if (iVar5 != 0) {
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Collections_View_CollectionConfirmationWindow_CollectionConfirmationWindowArgs_TypeInfo
		                          );
		    UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		    iVar5 = *(int *)(param1 + 0x18);
		    *(int *)(param1_00 + 0x18) = iVar5;
		    if (DAT_ram_00a57ed5 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__get_Model__
		                );
		      DAT_ram_00a57ed5 = '\x01';
		      iVar5 = *(int *)(param1 + 0x18);
		    }
		    uVar4 = *(undefined4 *)(param1 + 8);
		    iVar5 = Gameplay_Collections_Model_CollectionDicGroup__GetMedal
		                      (*(undefined4 *)(iVar5 + 0x18),*(undefined4 *)(param1 + 0x20),param1_00);
		    uVar4 = Gameplay_Collections_Model_CollectionsModel__SortCollections
		                      (uVar4,*(undefined4 *)(iVar5 + 0x14),param1_00);
		    *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Collections_Controller_CollectionInfoViewMediator_CollectionUpgradeRequestedEventHandler__
		               ,0);
		    *(undefined4 *)(param1_00 + 0x24) = uVar4;
		    *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar3,StringLiteral_12598,param1_00,
		               Method_UI_Windows_PopupController_Show_CollectionConfirmationWindow___);
		    return;
		  }
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4372,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar3,1,uVar4,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x8B4F", Offset = "0x8B4F", VA = "0x8B4F")]
		private void UpgradeButtonClickEventHandler()
		{
		/* --- GHIDRA: UpgradeButtonClickEventHandler ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__UpgradeButtonClickEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ed7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_CollectionsModel__CollectionsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CollectionsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57ed7 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_CollectionsModel__CollectionsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CollectionsService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002178 RID: 8568
		[Token(Token = "0x4002178")]
		[FieldOffset(Offset = "0x18")]
		private CollectionData _collectionData;

		// Token: 0x04002179 RID: 8569
		[Token(Token = "0x4002179")]
		[FieldOffset(Offset = "0x1C")]
		private readonly uint _collectionId;

		// Token: 0x0400217A RID: 8570
		[Token(Token = "0x400217A")]
		[FieldOffset(Offset = "0x20")]
		private uint _rank;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57ed2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionData__get_Item__);
		    DAT_ram_00a57ed2 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x60),1,0);
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0x20),param1[7],
		                     Method_System_Collections_Generic_Dictionary_uint__CollectionData__get_Item__);
		  param1[6] = iVar1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(int *)(iVar1 + 0x1c) = param1[6];
		  Gameplay_Collections_Controller_CollectionInfoViewMediator__CollectionUpgradeRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Collections_Controller_CollectionInfoViewMediator__set_Events
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Data_CollectionData__get_MaxRank(*(undefined4 *)(param1 + 0x18),0);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  Gameplay_Collections_Controller_CollectionInfoViewMediator__CollectionUpgradeRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
