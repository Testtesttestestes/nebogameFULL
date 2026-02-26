using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E5 RID: 4837
	[Token(Token = "0x20012E5")]
	public class UiAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001747")]
		protected override string Theme
		{
			[Token(Token = "0x6007313")]
			[Address(RVA = "0xBD1C", Offset = "0xBD1C", VA = "0xBD1C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007314")]
		[Address(RVA = "0xBD1D", Offset = "0xBD1D", VA = "0xBD1D", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_UiAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59648 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UiAnalyticsListener_FxActivatedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UiAnalyticsListener_ToolTipShownEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UiAnalyticsListener_WindowOpenedEvent__);
		    DAT_ram_00a59648 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UiAnalyticsListener_WindowOpenedEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_WindowOpenedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_UiScope_WindowOpenedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UiAnalyticsListener_ToolTipShownEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_ToolTipShownEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_UiScope_ToolTipShownEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UiAnalyticsListener_FxActivatedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_FxActivatedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_UiScope_FxActivatedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007315")]
		[Address(RVA = "0xBD1E", Offset = "0xBD1E", VA = "0xBD1E", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_UiAnalyticsListener__Deinit(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a59649 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23287);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23286);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25190);
		    DAT_ram_00a59649 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  func_ii_2946(param1_00,StringLiteral_23286,*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_1 = *(undefined1 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  func_ii_2946(param1_00,StringLiteral_25190,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23287;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81041bf7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81041bf7:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007316 RID: 29462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007316")]
		[Address(RVA = "0xBD1F", Offset = "0xBD1F", VA = "0xBD1F")]
		private void FxActivatedEvent(UiScope.FxActivatedEventArgs e)
		{
		/* --- GHIDRA: FxActivatedEvent ---
		void Core_Analytics_Listeners_UiAnalyticsListener__FxActivatedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5964a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27766);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27765);
		    DAT_ram_00a5964a = '\x01';
		  }
		  if (param1[4] < 4) {
		    param1[4] = param1[4] + 1;
		    uVar2 = 0;
		    param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		    piVar5 = *(int **)(param2 + 0x10);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (UI_ToolTip_IToolTipSource_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81041ce9;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,UI_ToolTip_IToolTipSource_TypeInfo,0);
		code_r0x81041ce9:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar2 = 0;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (UI_ToolTip_IToolTipDataProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)
		           ) {
		          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81041d6b;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,UI_ToolTip_IToolTipDataProvider_TypeInfo,0);
		code_r0x81041d6b:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar2 = 0;
		    func_ii_2946(param1_00,StringLiteral_27765,*(undefined4 *)(iVar6 + 8),
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    piVar5 = (int *)param1[2];
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    uVar1 = StringLiteral_27766;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		          goto code_r0x81041e2f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81041e2f:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar4,uVar1,param1_00,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007317 RID: 29463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007317")]
		[Address(RVA = "0xBD20", Offset = "0xBD20", VA = "0xBD20")]
		private void ToolTipShownEvent(UiScope.ToolTipShownEventArgs e)
		{
		/* --- GHIDRA: ToolTipShownEvent ---
		void Core_Analytics_Listeners_UiAnalyticsListener__ToolTipShownEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5964b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12649);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19677);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12611);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20464);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12622);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12602);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23323);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12671);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19941);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12660);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27343);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12553);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12621);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12554);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12633);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26303);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23325);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25282);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21871);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12571);
		    DAT_ram_00a5964b = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x10);
		  uVar1 = Mono_Math_Prime_Generator_SequentialSearchPrimeGeneratorBase___ctor(param1_00,0);
		  if (uVar1 < 0x9ee299ba) {
		    if (uVar1 < 0x43804be7) {
		      if (uVar1 == 0x20dd6e2b) {
		        iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12649,0);
		        if (iVar2 != 0) {
		          Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                    (param1,StringLiteral_25282,param2,0,0x20dd6e2b);
		          return;
		        }
		      }
		      else if ((uVar1 == 0x43804be6) &&
		              (iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12660,0),
		              iVar2 != 0)) {
		        Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                  (param1,StringLiteral_26303,param2,0,0x43804be6);
		        return;
		      }
		    }
		    else if (uVar1 == 0x88a7f403) {
		      iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12554,0);
		      if (iVar2 != 0) {
		        Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                  (param1,StringLiteral_19677,param2,0,0x88a7f403);
		        return;
		      }
		    }
		    else if (uVar1 == 0x9ee299b9) {
		      iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12602,0);
		      if (iVar2 != 0) {
		        Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                  (param1,StringLiteral_21871,param2,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x14)
		                   ,0x9ee299b9);
		      }
		    }
		    else if ((uVar1 == 0x62fe20d6) &&
		            (iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12622,0),
		            iVar2 != 0)) {
		      Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                (param1,StringLiteral_23323,param2,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x14),
		                 0x62fe20d6);
		      return;
		    }
		  }
		  else if (uVar1 < 0xa98a00a7) {
		    if (uVar1 == 0xa36d9cad) {
		      iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12671,0);
		      if (iVar2 != 0) {
		        Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                  (param1,StringLiteral_27343,param2,0,0xa36d9cad);
		        return;
		      }
		    }
		    else if (uVar1 == 0xa5af5e4a) {
		      iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12621,0);
		      if (iVar2 != 0) {
		        Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                  (param1,StringLiteral_23325,param2,0,0xa5af5e4a);
		        return;
		      }
		    }
		    else if ((uVar1 == 0xa98a00a6) &&
		            (iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12633,0),
		            iVar2 != 0)) {
		      Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                (param1,StringLiteral_19941,param2,0,0xa98a00a6);
		      return;
		    }
		  }
		  else if (uVar1 == 0xb841ec41) {
		    iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12611,0);
		    if (iVar2 != 0) {
		      Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		                (param1,StringLiteral_22692,param2,0,0xb841ec41);
		      return;
		    }
		  }
		  else if (uVar1 == 0xc025bcde) {
		    iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12553,0);
		    if (iVar2 != 0) {
		      Core_Analytics_Listeners_UiAnalyticsListener__WindowOpenedEvent(param1,param2,0xc025bcde);
		      return;
		    }
		  }
		  else if ((uVar1 == 0xf902646b) &&
		          (iVar2 = System_Collections_CollectionBase___ctor(param1_00,StringLiteral_12571,0),
		          iVar2 != 0)) {
		    Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		              (param1,StringLiteral_20464,param2,0,0xf902646b);
		    return;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007318 RID: 29464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007318")]
		[Address(RVA = "0xBD21", Offset = "0xBD21", VA = "0xBD21")]
		private void WindowOpenedEvent(UiScope.WindowOpenedEventArgs e)
		{
		/* --- GHIDRA: WindowOpenedEvent ---
		void Core_Analytics_Listeners_UiAnalyticsListener__WindowOpenedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5964c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_View_AccountWindow_AccountWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19676);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19678);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19679);
		    DAT_ram_00a5964c = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  piVar4 = *(int **)(param2 + 0x14);
		  if (piVar4 != (int *)0x0) {
		    if ((((uint)*(byte *)(Gameplay_Accounts_View_AccountWindow_AccountWindowArgs_TypeInfo + 0xb8) <=
		          (uint)*(byte *)(*piVar4 + 0xb8)) &&
		        (*(int *)(*(int *)(*piVar4 + 100) +
		                  (uint)*(byte *)(Gameplay_Accounts_View_AccountWindow_AccountWindowArgs_TypeInfo +
		                                 0xb8) * 4 + -4) ==
		         Gameplay_Accounts_View_AccountWindow_AccountWindowArgs_TypeInfo)) &&
		       (piVar5 = (int *)piVar4[7], piVar5 != (int *)0x0)) {
		      uVar1 = 0;
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		            goto code_r0x81042592;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,
		                                    Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		code_r0x81042592:
		      iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      if (iVar6 != 0) {
		        uVar1 = 0;
		        piVar5 = (int *)piVar4[7];
		        iVar6 = *piVar5;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		                *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		              goto code_r0x81042614;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar5,
		                                      Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1)
		        ;
		code_r0x81042614:
		        iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		        local_4 = *(undefined4 *)(iVar6 + 0xc);
		        uVar1 = 0;
		        uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		        func_ii_2946(param1_00,StringLiteral_19676,uVar3,
		                     Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		        piVar4 = (int *)piVar4[7];
		        iVar6 = *piVar4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		                *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		              goto code_r0x810426c9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar4,
		                                      Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1)
		        ;
		code_r0x810426c9:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		        uVar3 = Core_GameLocalization__GetValue(uVar3,0);
		        func_ii_2946(param1_00,StringLiteral_19678,uVar3,
		                     Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      }
		    }
		  }
		  Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		            (param1,StringLiteral_19679,param2,param1_00,param2);
		  return;
		}
		*/

		}

		// Token: 0x06007319 RID: 29465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007319")]
		[Address(RVA = "0xBD22", Offset = "0xBD22", VA = "0xBD22")]
		private void LogAccountWindowOpened(UiScope.WindowOpenedEventArgs e)
		{
		/* --- GHIDRA: LogAccountWindowOpened ---
		void Core_Analytics_Listeners_UiAnalyticsListener__LogAccountWindowOpened
		               (int *param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  int local_24;
		  undefined8 *local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a5964d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__object__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Value__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27321);
		    DAT_ram_00a5964d = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_1c = *(undefined4 *)(*(int *)(param3 + 0x14) + 0x10);
		  local_20 = (undefined8 *)0xffffffff;
		  local_24 = UI_Windows_WindowOpenReasonSource_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_24,0);
		  func_ii_2946(param1_00,StringLiteral_27321,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  if (param4 != 0) {
		    System_Collections_Generic_List_object___GetEnumerator
		              (&local_18,param4,
		               Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		    local_24 = 0;
		    local_20 = &local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8104232f;
		      }
		      if (iVar3 == 0) goto code_r0x81042385;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_00,uStack_c,local_8,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar6 != 1);
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8104232f:
		    iVar6 = global_1;
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar3) {
		      piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		      iVar3 = *piVar5;
		      DAT_ram_009d3e38 = 0;
		      local_24 = iVar3;
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
		        goto code_r0x81042385;
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33f,&local_24);
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
		code_r0x81042385:
		  piVar5 = (int *)param1[2];
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81042419;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81042419:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,param2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731A")]
		[Address(RVA = "0xBD23", Offset = "0xBD23", VA = "0xBD23")]
		private void LogWindowOpenedEvent(string eventName, UiScope.WindowOpenedEventArgs e, [Optional] Dictionary<string, object> extraProperties)
		{
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731B")]
		[Address(RVA = "0xBD24", Offset = "0xBD24", VA = "0xBD24")]
		public UiAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Analytics_Listeners_UiAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5964e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28165);
		    DAT_ram_00a5964e = '\x01';
		  }
		  return StringLiteral_28165;
		}
		*/

		}

		// Token: 0x04003C41 RID: 15425
		[Token(Token = "0x4003C41")]
		private const string BANK_WINDOW_OPENED = "bank_window_opened";

		// Token: 0x04003C42 RID: 15426
		[Token(Token = "0x4003C42")]
		private const string DISCOUNTS_WINDOW_OPENED = "discounts_window_opened";

		// Token: 0x04003C43 RID: 15427
		[Token(Token = "0x4003C43")]
		private const string SPECIAL_OFFERS_WINDOW_OPENED = "special_offers_window_opened";

		// Token: 0x04003C44 RID: 15428
		[Token(Token = "0x4003C44")]
		private const string MARKET_WINDOW_OPENED = "market_window_opened";

		// Token: 0x04003C45 RID: 15429
		[Token(Token = "0x4003C45")]
		private const string ARTIFACT_COMPARER_WINDOW_OPENED = "artifact_comparer_window_opened";

		// Token: 0x04003C46 RID: 15430
		[Token(Token = "0x4003C46")]
		private const string ACCOUNT_LIST_WINDOW_OPENED = "account_list_window_opened";

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		private const string ACCOUNT_WINDOW_OPENED = "account_window_opened";

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		private const string RATE_GAME_WINDOW = "rate_game_window_opened";

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		private const string GDEVENTS_OPENED = "gdevents_list_opened";

		// Token: 0x04003C4A RID: 15434
		[Token(Token = "0x4003C4A")]
		private const string GDEVENT_OPENED = "gdevent_opened";

		// Token: 0x04003C4B RID: 15435
		[Token(Token = "0x4003C4B")]
		private const string COMPETITION_OPENED = "competition_opened";

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		private const string TOOLTIP_SHOWN = "tooltip_shown";

		// Token: 0x04003C4D RID: 15437
		[Token(Token = "0x4003C4D")]
		private const string FX_SHOWN = "fx_shown";

		// Token: 0x04003C4E RID: 15438
		[Token(Token = "0x4003C4E")]
		private const int MaxToolTipEventNum = 3;

		// Token: 0x04003C4F RID: 15439
		[Token(Token = "0x4003C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _toolTipEventCounterCounter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_UiAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59647 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UiAnalyticsListener_FxActivatedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UiAnalyticsListener_ToolTipShownEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UiAnalyticsListener_WindowOpenedEvent__);
		    DAT_ram_00a59647 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UiAnalyticsListener_WindowOpenedEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_WindowOpenedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_UiScope_WindowOpenedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UiAnalyticsListener_ToolTipShownEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_ToolTipShownEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_UiScope_ToolTipShownEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_ToolTipShownEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UiAnalyticsListener_FxActivatedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_FxActivatedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_UiScope_FxActivatedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_FxActivatedEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
