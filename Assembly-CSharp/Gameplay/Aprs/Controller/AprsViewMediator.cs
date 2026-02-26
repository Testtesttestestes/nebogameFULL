using System;
using System.Collections.Generic;
using Gameplay.Aprs.Controller.Filters;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Gameplay.Aprs.Model.Tabs;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;
using UI.Tabs;

namespace Gameplay.Aprs.Controller
{
	// Token: 0x02000D73 RID: 3443
	[Token(Token = "0x2000D73")]
	public class AprsViewMediator : AbstractViewMediator<AprsModel, AprsEvents, AprsController, AprsWindow>
	{
		// Token: 0x06005463 RID: 21603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005463")]
		[Address(RVA = "0xA219", Offset = "0xA219", VA = "0xA219")]
		public AprsViewMediator(AprsModel model, AprsEvents events, AprsController controller)
		{
		/* --- GHIDRA: <GetCurrentTabs>b__13_0 ---
		void Gameplay_Aprs_Controller_AprsViewMediator___GetCurrentTabs_b__13_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59476 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo);
		    DAT_ram_00a59476 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Aprs_Controller_AprsViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Controller_AprsViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5946c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator_AprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator_InitEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator_OwnerChangedEvent__);
		    DAT_ram_00a5946c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_InitEventHandler__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo);
		    Gameplay_Aprs_Events_AprsEvents___ctor
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_AprChangedEvent__,
		               param1);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
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
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_OwnerChangedEvent__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_InitEventHandler__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo);
		    Gameplay_Aprs_Events_AprsEvents___ctor
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_AprChangedEvent__,
		               param1);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
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
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_OwnerChangedEvent__,0);
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

		// Token: 0x17001128 RID: 4392
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001128")]
		public override AprsEvents Events
		{
			[Token(Token = "0x6005464")]
			[Address(RVA = "0xA21A", Offset = "0xA21A", VA = "0xA21A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005465")]
		[Address(RVA = "0xA21B", Offset = "0xA21B", VA = "0xA21B")]
		private void OwnerChangedEvent()
		{
		/* --- GHIDRA: OwnerChangedEvent ---
		void Gameplay_Aprs_Controller_AprsViewMediator__OwnerChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5946e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		              );
		    DAT_ram_00a5946e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0xb4),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005466")]
		[Address(RVA = "0xA21C", Offset = "0xA21C", VA = "0xA21C")]
		private void AprChangedEvent(AprData aprData, uint medalId)
		{
		/* --- GHIDRA: AprChangedEvent ---
		void Gameplay_Aprs_Controller_AprsViewMediator__AprChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5946f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator_FiltersViewOnChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator_TabBarOnChangeEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator_ViewOnAprClickEvent__);
		    DAT_ram_00a5946f = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x3c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_TabBarOnChangeEvent__,0
		              );
		    UI_Tabs_TabBar__add_ChangeEvent(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_AprData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_ViewOnAprClickEvent__,0
		              );
		    if (DAT_ram_00a59419 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_AprData__TypeInfo);
		      DAT_ram_00a59419 = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x48);
		    do {
		      iVar2 = 0;
		      iVar5 = func_ii_7048(iVar7,uVar3,0);
		      uVar6 = System_Action_AprData__TypeInfo;
		      if ((iVar5 != 0) && (iVar2 = func_ii_1082(iVar5,System_Action_AprData__TypeInfo), iVar2 == 0))
		      {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x48,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Aprs_Controller_AprsViewMediator_FiltersViewOnChangedEvent__,0);
		    UI_Filters_FiltersView__add_ChangedEvent(uVar6,uVar3,0);
		  }
		  param1[5] = param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x3c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_TabBarOnChangeEvent__,0
		              );
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_AprData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprsViewMediator_ViewOnAprClickEvent__,0
		              );
		    if (DAT_ram_00a59418 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_AprData__TypeInfo);
		      DAT_ram_00a59418 = '\x01';
		    }
		    iVar7 = *(int *)(iVar4 + 0x48);
		    do {
		      iVar2 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar7,uVar3,0);
		      uVar6 = System_Action_AprData__TypeInfo;
		      if ((iVar5 != 0) && (iVar2 = func_ii_1082(iVar5,System_Action_AprData__TypeInfo), iVar2 == 0))
		      {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x48,iVar2,iVar7);
		      bVar1 = iVar2 != iVar7;
		      iVar7 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar4 + 0x40) + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(param1[2] + 0x14) == *(int *)(param1[2] + 8)),0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar4 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Aprs_Controller_AprsViewMediator_FiltersViewOnChangedEvent__,0);
		    UI_Filters_FiltersView__get_PriceFilterButton(uVar6,uVar3,0);
		    Gameplay_Aprs_Controller_AprsViewMediator__FiltersViewOnChangedEvent(param1,uVar6);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar4 + 9) != '\0') {
		      iVar7 = *param1;
		      iVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                        (param1,*(undefined4 *)(iVar7 + 0x15c));
		      uVar6 = *(undefined4 *)(iVar4 + 0x3c);
		      uVar3 = Gameplay_Aprs_Controller_AprsViewMediator__InitEventHandler(param1,iVar7);
		      UI_Tabs_TabBar__HandleSelected(uVar6,uVar3,0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                (*(undefined4 *)(iVar4 + 0x3c),0,0,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001129 RID: 4393
		// (set) Token: 0x06005467 RID: 21607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001129")]
		public override AprsWindow View
		{
			[Token(Token = "0x6005467")]
			[Address(RVA = "0xA21D", Offset = "0xA21D", VA = "0xA21D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005468")]
		[Address(RVA = "0xA21E", Offset = "0xA21E", VA = "0xA21E")]
		private void FiltersViewOnChangedEvent()
		{
		/* --- GHIDRA: FiltersViewOnChangedEvent ---
		void Gameplay_Aprs_Controller_AprsViewMediator__FiltersViewOnChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59470 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprsWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IAprFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IAprFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IAprFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_IAprFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IAprFilter__GetEnumerator__
		              );
		    DAT_ram_00a59470 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[6],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IAprFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IAprFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100a5cd;
		    }
		    if (iVar3 == 0) goto code_r0x8100a623;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[6],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__get_Item__
		                              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100a5cd;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100a5cd;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                       *(undefined4 *)(*(int *)(iVar3 + 0x40) + 0x38),uVar2,
		                       Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Aprs_Controller_Filters_IAprFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x8100a55a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Aprs_Controller_Filters_IAprFilter_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8100a55a:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8100a5cd:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8100a623:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar6 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprsWindowArgs__get_WindowArgs__);
		      if (*(int *)(iVar6 + 0x20) != 0) {
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar6 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprsWindowArgs__get_WindowArgs__);
		        param1[7] = *(int *)(iVar6 + 0x20);
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2cf,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005469")]
		[Address(RVA = "0xA21F", Offset = "0xA21F", VA = "0xA21F")]
		private void SetFiltersData()
		{
		/* --- GHIDRA: SetFiltersData ---
		void Gameplay_Aprs_Controller_AprsViewMediator__SetFiltersData
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param5;
		  int *param1_01;
		  int iVar3;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a59471 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__get_List__);
		    DAT_ram_00a59471 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x138);
		        goto code_r0x8100b5b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x8100b5b8:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3_00 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x44) + 0xb4) + 0xc);
		  param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x14c));
		  param5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x13c));
		  Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		            (param1_00,param2,param3_00,param4,param5,param1[2],0);
		  return;
		}
		*/

		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546A")]
		[Address(RVA = "0xA220", Offset = "0xA220", VA = "0xA220")]
		private void ViewOnAprClickEvent(AprData aprData)
		{
		/* --- GHIDRA: ViewOnAprClickEvent ---
		void Gameplay_Aprs_Controller_AprsViewMediator__ViewOnAprClickEvent(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  param2_00 = Gameplay_Aprs_Controller_AprsViewMediator__InitEventHandler(param1,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546B")]
		[Address(RVA = "0xA221", Offset = "0xA221", VA = "0xA221")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		/* WARNING: Removing unreachable block (ram,0x8100aa4b) */
		
		int Gameplay_Aprs_Controller_AprsViewMediator__InitEventHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59472 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_Tabs_AprsTabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprsViewMediator__GetCurrentTabs_b__13_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_AprData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_AprData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalCategoryDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData___Insert__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_AprsTabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_AprsTabBarItemData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9110);
		    DAT_ram_00a59472 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,
		             Method_System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData____ctor__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(*(int *)(param1 + 8) + 0x20),
		             Method_System_Collections_Generic_List_MedalCategoryDic__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                         Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__MoveNext__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8100ab11;
		      }
		      iVar7 = local_20;
		      if (iVar2 == 0) goto code_r0x8100ab5a;
		      iVar2 = local_8._4_4_;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                         *(undefined4 *)(*(int *)(param1 + 8) + 0x24),
		                         *(undefined4 *)(local_8._4_4_ + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8100ab11;
		      }
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Func_AprData__bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8100a99f:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8100ab11;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,param2_00,param1,
		                 Method_Gameplay_Aprs_Controller_AprsViewMediator__GetCurrentTabs_b__13_0__,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8100a99f;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf6,uVar4,param2_00,
		                         Method_System_Linq_Enumerable_Any_AprData___);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8100ab11;
		      }
		    } while (iVar3 == 0);
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100ab11;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9d,iVar2,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100ab11;
		    }
		    *(undefined4 *)(iVar7 + 0x10) = uVar4;
		    *(undefined4 *)(iVar7 + 0x14) = *(undefined4 *)(iVar2 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Aprs_Model_Tabs_AprsTabBarItemData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100ab11;
		    }
		    *(undefined4 *)(iVar2 + 8) = 2;
		    *(int *)(iVar7 + 0x20) = iVar2;
		    iVar2 = Method_System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData___Add__;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar1 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar6 + 1;
		      *(int *)(*(int *)(iVar1 + 8) + uVar6 * 4 + 0x10) = iVar7;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,iVar7,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8100ab11:
		        iVar7 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar2) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar7 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		code_r0x8100ab5a:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            iVar7 = unnamed_function_1417(UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo);
		            if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_GameLocalization_TypeInfo);
		            }
		            uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9110,1,0,1,0,0,0,0);
		            *(undefined4 *)(iVar7 + 0x14) = 0;
		            *(undefined4 *)(iVar7 + 0x10) = uVar4;
		            iVar2 = unnamed_function_1417(Gameplay_Aprs_Model_Tabs_AprsTabBarItemData_TypeInfo);
		            *(undefined4 *)(iVar2 + 8) = 1;
		            *(int *)(iVar7 + 0x20) = iVar2;
		            System_Collections_Generic_List_IntPtr___AddWithResize
		                      (iVar1,0,iVar7,
		                       Method_System_Collections_Generic_List_TabBarItemData_AprsTabBarItemData___Insert__
		                      );
		            return iVar1;
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d0,&local_20);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          import::env::__resumeException(uVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600546C")]
		[Address(RVA = "0xA222", Offset = "0xA222", VA = "0xA222")]
		private List<TabBarItemData<AprsTabBarItemData>> GetCurrentTabs()
		{
		/* --- GHIDRA: GetCurrentTabs ---
		void Gameplay_Aprs_Controller_AprsViewMediator__GetCurrentTabs(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),0,0,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546D")]
		[Address(RVA = "0xA223", Offset = "0xA223", VA = "0xA223")]
		private void SelectDefaultTab()
		{
		/* --- GHIDRA: SelectDefaultTab ---
		void Gameplay_Aprs_Controller_AprsViewMediator__SelectDefaultTab
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_Controller_AprsViewMediator__TabBarOnChangeEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546E")]
		[Address(RVA = "0xA224", Offset = "0xA224", VA = "0xA224")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		void Gameplay_Aprs_Controller_AprsViewMediator__TabBarOnChangeEvent(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59473 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_AprsTabBarItemData__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo);
		    DAT_ram_00a59473 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo + 0xb8) * 4 +
		                -4) != UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,UI_Tabs_TabBarItemData_AprsTabBarItemData__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_AprData___ctor__);
		  if (*(int *)(param1_00[8] + 8) == 1) {
		    uVar2 = *(undefined4 *)(param1[2] + 0x28);
		  }
		  else if (*(int *)(param1_00[8] + 8) == 2) {
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(param1[2] + 0x24),param1_00[5],
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__)
		    ;
		  }
		  uVar2 = Gameplay_Aprs_Controller_AprsViewMediator__RedrawCurrentTab
		                    (param1,uVar2,&local_4,&local_8,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Aprs_View_AprsOsaGridView__RemoveItemsFrom(*(undefined4 *)(iVar1 + 0x44),uVar2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		            (*(undefined4 *)(iVar1 + 0x40),local_4,local_8,0);
		  return;
		}
		*/

		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546F")]
		[Address(RVA = "0xA225", Offset = "0xA225", VA = "0xA225")]
		private void RedrawCurrentTab()
		{
		/* --- GHIDRA: RedrawCurrentTab ---
		/* WARNING: Removing unreachable block (ram,0x8100b225) */
		
		int Gameplay_Aprs_Controller_AprsViewMediator__RedrawCurrentTab
		              (int param1,undefined4 param2,int *param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  int *piVar11;
		  int local_38;
		  undefined1 *local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59474 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAprFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAprFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAprFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_Filters_IAprFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IAprFilter__GetEnumerator__
		              );
		    DAT_ram_00a59474 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  iVar3 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,Method_System_Collections_Generic_List_AprData___ctor__);
		  *param3 = 0;
		  *param4 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,param2,Method_System_Collections_Generic_List_AprData__GetEnumerator__);
		  local_8 = local_28;
		  local_38 = 0;
		  local_34 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AprData__MoveNext__);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x8100b43a;
		    }
		    iVar10 = local_38;
		    if (iVar4 == 0) goto code_r0x8100b481;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = local_8._4_4_;
		    uVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9f,
		                       *(undefined4 *)(param1 + 0x18),
		                       Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAprFilter__get_Values__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x8100b43a;
		    }
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_30,uVar8,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IAprFilter__GetEnumerator__
		              );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x8100b43a;
		    }
		    local_18 = local_28;
		    local_20 = CONCAT44(puStack_2c,local_30);
		    local_30 = 0;
		    puStack_2c = &local_20;
		    do {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_20,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAprFilter__MoveNext__
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8100b19d:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar10 == iVar7) {
		          piVar9 = (int *)import::env::__cxa_begin_catch(uVar8);
		          iVar7 = *piVar9;
		          iVar2 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_30 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          uVar5 = 1;
		          if (iVar10 != 1) goto code_r0x8100b1f7;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d1,&local_30);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) goto code_r0x8100b43a;
		        goto code_r0x8100b4d5;
		      }
		      if (uVar5 == 0) break;
		      piVar9 = local_18._4_4_;
		      iVar10 = *local_18._4_4_;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (Gameplay_Aprs_Controller_Filters_IAprFilter_TypeInfo == *piVar11) {
		            puVar6 = (undefined4 *)(piVar11[1] * 8 + iVar10 + 0xd0);
		            goto code_r0x8100b146;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_18._4_4_,
		                          Gameplay_Aprs_Controller_Filters_IAprFilter_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8100b19d;
		code_r0x8100b146:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iiii(*puVar6,piVar9,iVar4,puVar6[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8100b19d;
		    } while (iVar10 != 0);
		    uVar5 = uVar5 ^ 1;
		    iVar2 = 6;
		    iVar7 = 0;
		code_r0x8100b1f7:
		    if (iVar7 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar7);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 1) {
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x8100b43a;
		    }
		    if ((iVar2 != 0) &&
		       ((((iVar10 = local_38, iVar2 == 1 || (iVar2 == 2)) || (iVar2 == 3)) ||
		        (((iVar2 == 4 || (iVar2 == 5)) || (iVar2 != 6)))))) goto code_r0x8100b481;
		    if (uVar5 != 0) {
		      iVar10 = *(int *)(param1 + 0x1c);
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iiii
		                        (*(undefined4 *)(iVar10 + 0xc),*(undefined4 *)(iVar10 + 0x20),iVar4,
		                         *(undefined4 *)(iVar10 + 0x14));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x8100b43a;
		      }
		      if (iVar7 != 0) {
		        *param4 = *param4 + 1;
		        if (DAT_ram_00a59431 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__
		                    );
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar10 = global_1;
		            goto code_r0x8100b43a;
		          }
		          DAT_ram_00a59431 = '\x01';
		        }
		        if (0 < *(int *)(*(int *)(iVar4 + 0x28) + 0x10)) {
		          *param3 = *param3 + 1;
		        }
		        iVar10 = Method_System_Collections_Generic_List_AprData__Add__;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        uVar5 = *(uint *)(iVar3 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		          *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		          *(int *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = iVar4;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,iVar4,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar10 = global_1;
		code_r0x8100b43a:
		            iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar4 == iVar10) {
		              piVar9 = (int *)import::env::__cxa_begin_catch(uVar8);
		              iVar10 = *piVar9;
		              DAT_ram_009d3e38 = 0;
		              local_38 = iVar10;
		              import::env::invoke_v(0x123);
		              iVar4 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar4 != 1) {
		code_r0x8100b481:
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 != 0) {
		                  System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		                return iVar3;
		              }
		              uVar8 = import::env::__cxa_find_matching_catch_2();
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d2,&local_38);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 != 1) {
		              import::env::__resumeException(uVar8);
		              do {
		                halt_trap();
		              } while( true );
		            }
		code_r0x8100b4d5:
		            DAT_ram_009d3e38 = 0;
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		      }
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005470")]
		[Address(RVA = "0xA226", Offset = "0xA226", VA = "0xA226")]
		private List<AprData> FilterAprs(List<AprData> aprs, out int achievedCount, out int totalCount)
		{
		/* --- GHIDRA: FilterAprs ---
		void Gameplay_Aprs_Controller_AprsViewMediator__FilterAprs(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59475 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__Dispose__
		              );
		    DAT_ram_00a59475 = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprsWindow__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005471")]
		[Address(RVA = "0xA227", Offset = "0xA227", VA = "0xA227", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Gameplay_Aprs_Controller_AprsViewMediator__Dispose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x1c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IAprFilter> _filters;

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0x1C")]
		private Predicate<AprData> _customFilter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Aprs_Controller_AprsViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5946d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		              );
		    DAT_ram_00a5946d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0xb4),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_AprData__NotifyListChangedExternally__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Aprs_Controller_AprsViewMediator__set_View(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_Controller_AprsViewMediator__FiltersViewOnChangedEvent(param1,param1);
		  Gameplay_Aprs_Controller_AprsViewMediator__TabBarOnChangeEvent(param1,param1);
		  return;
		}
		*/

}
