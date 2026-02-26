using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Events.Scopes;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DA RID: 4826
	[Token(Token = "0x20012DA")]
	public class PopupListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173E")]
		protected override string Theme
		{
			[Token(Token = "0x60072C5")]
			[Address(RVA = "0xBCCE", Offset = "0xBCCE", VA = "0xBCCE", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C6")]
		[Address(RVA = "0xBCCF", Offset = "0xBCCF", VA = "0xBCCF", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_PopupListener__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59607 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    DAT_ram_00a59607 = '\x01';
		  }
		  if (*(int *)(param2 + 0x14) == 0) {
		    local_8 = 0;
		  }
		  else {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_8,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 8) + 0xc),
		               Method_System_Nullable_uint___ctor__);
		  }
		  *(undefined8 *)(param1 + 0x18) = local_8;
		  return;
		}
		*/

		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C7")]
		[Address(RVA = "0xBCD0", Offset = "0xBCD0", VA = "0xBCD0")]
		private void HandleMilestoneSelectedEvent(GdEventsScope.Args args)
		{
		/* --- GHIDRA: HandleMilestoneSelectedEvent ---
		void Core_Analytics_Listeners_PopupListener__HandleMilestoneSelectedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined8 param1_00;
		  double dVar4;
		  undefined4 uVar5;
		  longlong param5;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59608 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankTabType_var);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankTabType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12571);
		    DAT_ram_00a59608 = '\x01';
		  }
		  uVar1 = Gameplay_Bank_Controller_BankTabType_var;
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  uVar5 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x14);
		  if (*(int *)(param1 + 0x14) == 0) {
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    uVar1 = func_ii_2734(uVar1,0);
		    local_30 = CONCAT44(local_30._4_4_,uVar5);
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_30);
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar3 = System_Enum__InternalGetNames(uVar1,uVar2,0);
		    if (iVar3 == 0) {
		      uVar5 = 0;
		    }
		    *(undefined4 *)(param1 + 0x14) = uVar5;
		  }
		  else {
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    uVar1 = func_ii_2734(uVar1,0);
		    local_30 = CONCAT44(local_30._4_4_,uVar5);
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_30);
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar3 = System_Enum__InternalGetNames(uVar1,uVar2,0);
		    if (iVar3 == 0) {
		      uVar5 = 0;
		    }
		    iVar3 = System_Collections_Generic_Dictionary_object__ValueTuple_object__DateTime____TryAdd
		                      (*(undefined4 *)(param1 + 0x20),StringLiteral_12571,&local_10,
		                       Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___TryGetValue__
		                      );
		    if (iVar3 != 0) {
		      if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTime_TypeInfo);
		      }
		      param1_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		      local_18 = System_DateTime__op_Subtraction(param1_00,local_8,0);
		      if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_TimeSpan_TypeInfo);
		      }
		      dVar4 = System_Net_FtpMethodInfo__GetMethodInfo(&local_18,0);
		      uVar1 = Gameplay_Bank_Controller_BankTabType_var;
		      if (ABS(dVar4) < 9.223372036854776e+18) {
		        param5 = (longlong)dVar4;
		      }
		      else {
		        param5 = -0x8000000000000000;
		      }
		      if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a669a0);
		      }
		      uVar1 = func_ii_2734(uVar1,0);
		      local_1c = uVar5;
		      uVar2 = func_ii_1081(Gameplay_Bank_Controller_BankTabType_TypeInfo,&local_1c);
		      if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a6697c);
		      }
		      uVar1 = System_Double__ToString(uVar1,uVar2,0);
		      uVar2 = func_ii_2734(Gameplay_Bank_Controller_BankTabType_var,0);
		      local_20 = *(undefined4 *)(param1 + 0x14);
		      param2_00 = func_ii_1081(Gameplay_Bank_Controller_BankTabType_TypeInfo,&local_20);
		      uVar2 = System_Double__ToString(uVar2,param2_00,0);
		      Core_Analytics_Listeners_PopupListener__SendDlgEndlessOptionEvent
		                (param1,(undefined4)local_10,uVar1,uVar2,param5,&local_40);
		      uVar1 = *(undefined4 *)(param1 + 0x20);
		      local_28 = 0;
		      local_30 = 0;
		      BestHTTP_HTTPRequest___cctor
		                (&local_30,(undefined4)local_10,param1_00,
		                 Method_System_ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___ctor__);
		      local_38 = local_28;
		      local_40 = local_30;
		      System_Collections_Generic_Dictionary_object__ValueTuple_object__DateTime____get_Values
		                (uVar1,StringLiteral_12571,&local_40,
		                 Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___set_Item__
		                );
		    }
		    *(undefined4 *)(param1 + 0x14) = uVar5;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C8")]
		[Address(RVA = "0xBCD1", Offset = "0xBCD1", VA = "0xBCD1")]
		private void BankTabChangedEvent(UiScope.BankTabChangedArgs args)
		{
		/* --- GHIDRA: BankTabChangedEvent ---
		void Core_Analytics_Listeners_PopupListener__BankTabChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Com_TheFallenGames_OSA_Core_OSA_object__object___get_Parameters
		                    (*(undefined4 *)(param2 + 0x10),0);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072C9")]
		[Address(RVA = "0xBCD2", Offset = "0xBCD2", VA = "0xBCD2")]
		private void OfferSelectionChangedEvent(UiScope.OfferSelectionChangedArgs args)
		{
		/* --- GHIDRA: OfferSelectionChangedEvent ---
		void Core_Analytics_Listeners_PopupListener__OfferSelectionChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59609 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventsScope_Args__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PopupListener_BankTabChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PopupListener_HandleMilestoneSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PopupListener_OfferSelectionChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Listeners_PopupListener_WindowClosedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Listeners_PopupListener_WindowOpenedEvent__)
		    ;
		    DAT_ram_00a59609 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_WindowOpenedEvent__,0);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_WindowClosedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_WindowClosedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_UiScope_WindowClosedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_OfferSelectionChangedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_BankTabChangedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_BankTabChangedArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_UiScope_BankTabChangedArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_Args__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PopupListener_HandleMilestoneSelectedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
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

		// Token: 0x060072CA RID: 29386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CA")]
		[Address(RVA = "0xBCD3", Offset = "0xBCD3", VA = "0xBCD3", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_PopupListener__Deinit(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined8 param1_00;
		  double dVar3;
		  undefined4 uVar4;
		  longlong param4;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5960a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankTabType_var);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankTabType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowCloseReason_var);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowCloseReason_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12670);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12622);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12671);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12615);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12571);
		    DAT_ram_00a5960a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = System_Collections_Generic_Dictionary_object__ValueTuple_object__DateTime____TryAdd
		                    (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param2 + 0x10),&local_10,
		                     Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    System_Collections_Generic_Dictionary_object__ValueTuple_object__DateTime____OnDeserialization
		              (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param2 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___Remove__
		              );
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    param1_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		    local_18 = System_DateTime__op_Subtraction(param1_00,local_8,0);
		    if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_TimeSpan_TypeInfo);
		    }
		    dVar3 = System_Net_FtpMethodInfo__GetMethodInfo(&local_18,0);
		    if (ABS(dVar3) < 9.223372036854776e+18) {
		      param4 = (longlong)dVar3;
		    }
		    else {
		      param4 = -0x8000000000000000;
		    }
		    uVar4 = *(undefined4 *)(param2 + 0x10);
		    iVar1 = System_Collections_CollectionBase___ctor(uVar4,StringLiteral_12671,0);
		    if ((iVar1 == 0) &&
		       (iVar1 = System_Collections_CollectionBase___ctor(uVar4,StringLiteral_12670,0), iVar1 == 0))
		    {
		      iVar1 = System_Collections_CollectionBase___ctor(uVar4,StringLiteral_12571,0);
		      uVar2 = UI_Windows_WindowCloseReason_var;
		      if (iVar1 == 0) {
		        iVar1 = System_Collections_CollectionBase___ctor(uVar4,StringLiteral_12622,0);
		        if (iVar1 == 0) {
		          iVar1 = System_Collections_CollectionBase___ctor(uVar4,StringLiteral_12615,0);
		          if (iVar1 != 0) {
		            Core_Analytics_Listeners_PopupListener__SendDlgOfferEvent
		                      (param1,(undefined4)local_10,param2,param4,&local_20);
		          }
		        }
		        else {
		          Core_Analytics_Listeners_PopupListener__SendDlgBankEvent
		                    (param1,(undefined4)local_10,&local_20,param4,&local_20);
		        }
		      }
		      else {
		        if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a669a0);
		        }
		        uVar4 = func_ii_2734(uVar2,0);
		        local_1c = *(undefined4 *)(param2 + 0x14);
		        uVar2 = func_ii_1081(UI_Windows_WindowCloseReason_TypeInfo,&local_1c);
		        if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		          func_ii_306000(DAT_ram_00a6697c);
		        }
		        uVar4 = System_Double__ToString(uVar4,uVar2,0);
		        uVar2 = func_ii_2734(Gameplay_Bank_Controller_BankTabType_var,0);
		        local_20 = *(undefined4 *)(param1 + 0x14);
		        param2_00 = func_ii_1081(Gameplay_Bank_Controller_BankTabType_TypeInfo,&local_20);
		        uVar2 = System_Double__ToString(uVar2,param2_00,0);
		        Core_Analytics_Listeners_PopupListener__SendDlgEndlessOptionEvent
		                  (param1,(undefined4)local_10,uVar4,uVar2,param4,&local_20);
		      }
		    }
		    else {
		      Core_Analytics_Listeners_PopupListener__WindowOpenedEvent
		                (param1,(undefined4)local_10,param2,param4,&local_20);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072CB RID: 29387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CB")]
		[Address(RVA = "0xBCD4", Offset = "0xBCD4", VA = "0xBCD4")]
		private void WindowClosedEvent(UiScope.WindowClosedEventArgs args)
		{
		/* --- GHIDRA: WindowClosedEvent ---
		void Core_Analytics_Listeners_PopupListener__WindowClosedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 param3_00;
		  undefined4 param3_01;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5960b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_WindowClosedEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12622);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12571);
		    DAT_ram_00a5960b = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_object__ValueTuple_object__DateTime____Clear
		                    (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param2 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___ContainsKey__
		                    );
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param2 + 0x10);
		    param3_01 = *(undefined4 *)(param2 + 0xc);
		    param1_00 = *(int **)(param2 + 8);
		    uVar2 = unnamed_function_1417(Core_Events_Scopes_UiScope_WindowClosedEventArgs_TypeInfo);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Core_Application_App_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Core_Application_App_TypeInfo + 0xb8) * 4 + -4) !=
		          Core_Application_App_TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,Core_Application_App_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (uVar2,param1_00,param3_01,uVar3,0,0);
		    Core_Analytics_Listeners_PopupListener__Deinit(param1,uVar2,&local_20);
		  }
		  iVar1 = System_Collections_CollectionBase___ctor
		                    (*(undefined4 *)(param2 + 0x10),StringLiteral_12571,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Collections_CollectionBase___ctor
		                      (*(undefined4 *)(param2 + 0x10),StringLiteral_12622,0);
		    if (iVar1 != 0) {
		      *(undefined8 *)(param1 + 0x18) = 0;
		    }
		  }
		  else {
		    *(undefined4 *)(param1 + 0x14) = 0;
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  param3_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  local_8 = 0;
		  local_10 = 0;
		  BestHTTP_HTTPRequest___cctor
		            (&local_10,param2,param3_00,
		             Method_System_ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___ctor__);
		  local_18 = local_8;
		  local_20 = local_10;
		  System_Collections_Generic_Dictionary_object__ValueTuple_object__DateTime_____ctor
		            (uVar3,uVar2,&local_20,
		             Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___Add__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CC")]
		[Address(RVA = "0xBCD5", Offset = "0xBCD5", VA = "0xBCD5")]
		private void WindowOpenedEvent(UiScope.WindowOpenedEventArgs args)
		{
		/* --- GHIDRA: WindowOpenedEvent ---
		void Core_Analytics_Listeners_PopupListener__WindowOpenedEvent
		               (int *param1,int param2,int param3,undefined8 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined4 *puVar6;
		  int iVar7;
		  undefined8 local_18;
		  int local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5960c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowCloseReason_var);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowCloseReason_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_var);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23272);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23066);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20019);
		    DAT_ram_00a5960c = '\x01';
		  }
		  param1_01 = (int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar3 = UI_Windows_WindowOpenReasonSource_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x10);
		  uVar4 = func_ii_1081(UI_Windows_WindowOpenReasonSource_TypeInfo,&local_4);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar3 = System_Double__ToString(uVar3,uVar4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23272,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar3 = func_ii_2734(UI_Windows_WindowCloseReason_var,0);
		  local_8 = *(undefined4 *)(param3 + 0x14);
		  uVar4 = func_ii_1081(UI_Windows_WindowCloseReason_TypeInfo,&local_8);
		  uVar3 = System_Double__ToString(uVar3,uVar4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23066,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  local_c = param1[4];
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27466,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  local_18 = param4;
		  uVar3 = func_ii_1081(DAT_ram_00a66964,&local_18);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27448,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar3 = StringLiteral_22708;
		  puVar6 = &StringLiteral_20019;
		  if (*(int *)(*(int *)(param2 + 0x14) + 0x10) == 0) {
		    puVar6 = &StringLiteral_25259;
		  }
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_25858,*puVar6,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  iVar7 = *param1_01;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x8103c1f5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103c1f5:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar2,uVar3,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CD")]
		[Address(RVA = "0xBCD6", Offset = "0xBCD6", VA = "0xBCD6")]
		private void SendDlgOfferEvent(UiScope.WindowOpenedEventArgs openArgs, UiScope.WindowClosedEventArgs closeArgs, long deltaTimeMs)
		{
		/* --- GHIDRA: SendDlgOfferEvent ---
		void Core_Analytics_Listeners_PopupListener__SendDlgOfferEvent
		               (int *param1,int param2,int param3,undefined8 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined4 *puVar6;
		  int iVar7;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5960d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowCloseReason_var);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowCloseReason_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_var);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23272);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23066);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22706);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20019);
		    DAT_ram_00a5960d = '\x01';
		  }
		  param1_01 = (int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar3 = UI_Windows_WindowOpenReasonSource_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x10);
		  uVar4 = func_ii_1081(UI_Windows_WindowOpenReasonSource_TypeInfo,&local_4);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar3 = System_Double__ToString(uVar3,uVar4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23272,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar3 = func_ii_2734(UI_Windows_WindowCloseReason_var,0);
		  local_8 = *(undefined4 *)(param3 + 0x14);
		  uVar4 = func_ii_1081(UI_Windows_WindowCloseReason_TypeInfo,&local_8);
		  uVar3 = System_Double__ToString(uVar3,uVar4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23066,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  local_10 = param4;
		  uVar3 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27448,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar3 = StringLiteral_22706;
		  puVar6 = &StringLiteral_20019;
		  if (*(int *)(*(int *)(param2 + 0x14) + 0x10) == 0) {
		    puVar6 = &StringLiteral_25259;
		  }
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_25858,*puVar6,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  iVar7 = *param1_01;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x8103bf24;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103bf24:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar2,uVar3,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CE")]
		[Address(RVA = "0xBCD7", Offset = "0xBCD7", VA = "0xBCD7")]
		private void SendDlgEndlessOptionEvent(UiScope.WindowOpenedEventArgs openArgs, UiScope.WindowClosedEventArgs closeArgs, long deltaTimeMs)
		{
		/* --- GHIDRA: SendDlgEndlessOptionEvent ---
		void Core_Analytics_Listeners_PopupListener__SendDlgEndlessOptionEvent
		               (int *param1,int param2,undefined4 param3,undefined4 param4,undefined8 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5960e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_var);
		    Mono_Security_ASN1__get_Item(&UI_Windows_WindowOpenReasonSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23272);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23066);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22705);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27890);
		    DAT_ram_00a5960e = '\x01';
		  }
		  param1_01 = (int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar3 = UI_Windows_WindowOpenReasonSource_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x10);
		  param2_00 = func_ii_1081(UI_Windows_WindowOpenReasonSource_TypeInfo,&local_4);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar3 = System_Double__ToString(uVar3,param2_00,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23272,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23066,param3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27890,param4,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  local_10 = param5;
		  uVar3 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27448,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar3 = StringLiteral_22705;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103b667;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103b667:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar2,uVar3,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072CF RID: 29391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072CF")]
		[Address(RVA = "0xBCD8", Offset = "0xBCD8", VA = "0xBCD8")]
		private void SendDlgBankEvent(UiScope.WindowOpenedEventArgs openArgs, string exit, string type, long deltaTimeMs)
		{
		/* --- GHIDRA: SendDlgBankEvent ---
		void Core_Analytics_Listeners_PopupListener__SendDlgBankEvent
		               (int *param1,int param2,undefined4 param3,undefined8 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int *param1_01;
		  undefined8 local_18;
		  undefined4 local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5960f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25394);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22707);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26016);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23035);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    DAT_ram_00a5960f = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(*(int *)(param2 + 0x14) + 0x14),StringLiteral_23035,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__object__TryGetValue__);
		  if ((iVar2 != 0) &&
		     (iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                        (*(undefined4 *)(*(int *)(param2 + 0x14) + 0x14),StringLiteral_23033,
		                         &local_8,
		                         Method_System_Collections_Generic_Dictionary_string__object__TryGetValue__)
		     , iVar2 != 0)) {
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*local_4 + 0xd8) * 4))
		                      (local_4,*(undefined4 *)(*local_4 + 0xdc));
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_23035,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    if (local_8 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*local_8 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(local_8,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar4 = (undefined4 *)func_ii_15774(local_8);
		    local_c = *puVar4;
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_26016,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    local_18 = param4;
		    uVar3 = func_ii_1081(DAT_ram_00a66964,&local_18);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_27448,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    if ((char)param1[6] != '\0') {
		      uVar3 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                        (param1 + 6,Method_System_Nullable_uint__get_Value__);
		      local_18 = CONCAT44(local_18._4_4_,uVar3);
		      uVar3 = func_ii_1081(DAT_ram_00a66958,&local_18);
		      System_Reflection_FieldInfo__get_IsStatic
		                (param1_00,StringLiteral_25394,uVar3,
		                 Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    }
		    param1_01 = (int *)param1[2];
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    uVar3 = StringLiteral_22707;
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		          goto code_r0x8103c4ab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103c4ab:
		    (**(code **)((ulonglong)*puVar6 * 4))(param1_01,uVar5,uVar3,param1_00,puVar6[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D0")]
		[Address(RVA = "0xBCD9", Offset = "0xBCD9", VA = "0xBCD9")]
		private void SendMilestoneSelected(UiScope.WindowOpenedEventArgs openArgs, UiScope.WindowClosedEventArgs closeArgs, long deltaTimeMs)
		{
		/* --- GHIDRA: SendMilestoneSelected ---
		void Core_Analytics_Listeners_PopupListener__SendMilestoneSelected(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59610 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___TypeInfo
		              );
		    DAT_ram_00a59610 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime___TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_string__ValueTuple_UiScope_WindowOpenedEventArgs__DateTime____ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D1")]
		[Address(RVA = "0xBCDA", Offset = "0xBCDA", VA = "0xBCDA")]
		public PopupListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Analytics_Listeners_PopupListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59611 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_26299);
		    DAT_ram_00a59611 = '\x01';
		  }
		  return StringLiteral_26299;
		}
		*/

		}

		// Token: 0x04003C1A RID: 15386
		[Token(Token = "0x4003C1A")]
		public const string THEME = "popup";

		// Token: 0x04003C1B RID: 15387
		[Token(Token = "0x4003C1B")]
		private const string DLG_ENDLESS_OPTION = "dlg_endless_option";

		// Token: 0x04003C1C RID: 15388
		[Token(Token = "0x4003C1C")]
		private const string DLG_OFFER = "dlg_offer";

		// Token: 0x04003C1D RID: 15389
		[Token(Token = "0x4003C1D")]
		private const string DLG_BANK = "dlg_bank";

		// Token: 0x04003C1E RID: 15390
		[Token(Token = "0x4003C1E")]
		private const string DLG_MILESTONE_SELECTED = "dlg_milestone_selected";

		// Token: 0x04003C1F RID: 15391
		[Token(Token = "0x4003C1F")]
		[FieldOffset(Offset = "0x10")]
		private uint _selectedOffer;

		// Token: 0x04003C20 RID: 15392
		[Token(Token = "0x4003C20")]
		[FieldOffset(Offset = "0x14")]
		private BankTabType _bankTabType;

		// Token: 0x04003C21 RID: 15393
		[Token(Token = "0x4003C21")]
		[FieldOffset(Offset = "0x18")]
		private uint? _milestoneNumber;

		// Token: 0x04003C22 RID: 15394
		[Token(Token = "0x4003C22")]
		[FieldOffset(Offset = "0x20")]
		[TupleElementNames(new string[]
		{
			"openArgs",
			"timestamp"
		})]
		private readonly Dictionary<string, ValueTuple<UiScope.WindowOpenedEventArgs, DateTime>> _openedWindows;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_PopupListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59606 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventsScope_Args__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PopupListener_BankTabChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PopupListener_HandleMilestoneSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_PopupListener_OfferSelectionChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Listeners_PopupListener_WindowClosedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Listeners_PopupListener_WindowOpenedEvent__)
		    ;
		    DAT_ram_00a59606 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x44);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_WindowOpenedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_WindowOpenedEvent__,0);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_WindowClosedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_WindowClosedEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_UiScope_WindowClosedEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_WindowClosedEventArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_OfferSelectionChangedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_OfferSelectionChangedArgs__TypeInfo);
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
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_PopupListener_BankTabChangedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UiScope_BankTabChangedArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_UiScope_BankTabChangedArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UiScope_BankTabChangedArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_Args__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_PopupListener_HandleMilestoneSelectedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
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
