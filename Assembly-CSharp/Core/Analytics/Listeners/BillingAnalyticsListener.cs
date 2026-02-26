using System;
using System.Collections.Generic;
using Core.Events;
using Core.Events.Scopes;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C4 RID: 4804
	[Token(Token = "0x20012C4")]
	public class BillingAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x0600721A RID: 29210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001728")]
		protected override string Theme
		{
			[Token(Token = "0x600721A")]
			[Address(RVA = "0xBC23", Offset = "0xBC23", VA = "0xBC23", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721B")]
		[Address(RVA = "0xBC24", Offset = "0xBC24", VA = "0xBC24", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59573 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionCancelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionPendingPurchaseEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestInfoEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestMarketEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_CurrencyConvertErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_InvalidProductsInfoEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_OnRestoreTransactionCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_ProviderSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseInfoEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseRequirementsErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_RefPayEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_RequestProductsErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_ShowSelectBillingDialogEvent__
		              );
		    DAT_ram_00a59573 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionSuccessEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionErrorEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseInfoEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x2c) = iVar3;
		    uVar2 = System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417
		                    (System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_CurrencyConvertErrorEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo)
		    ;
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x30) = iVar3;
		    uVar2 = System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo)
		    ;
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionPendingPurchaseEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionCancelEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_OnRestoreTransactionCompleteEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestInfoEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestMarketEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_InvalidProductsInfoEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_RequestProductsErrorEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseRequirementsErrorEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_ShowSelectBillingDialogEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x38) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x38) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_ProviderSelectedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x3c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x3c) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BillingAnalyticsListener_RefPayEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x40) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x40) = iVar3;
		    uVar2 = System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
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

		// Token: 0x0600721C RID: 29212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721C")]
		[Address(RVA = "0xBC25", Offset = "0xBC25", VA = "0xBC25", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__Deinit
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59574 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26353);
		    DAT_ram_00a59574 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param2_00,param2[6],param2);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_26353;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102c785;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102c785:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721D")]
		[Address(RVA = "0xBC26", Offset = "0xBC26", VA = "0xBC26")]
		private void RefPayEvent(BillingScope.RefPayInfoEventArgs e)
		{
		/* --- GHIDRA: RefPayEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__RefPayEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59575 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26200);
		    DAT_ram_00a59575 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param2_00,param2[5],param2);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_26200;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102c940;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102c940:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721E")]
		[Address(RVA = "0xBC27", Offset = "0xBC27", VA = "0xBC27")]
		private void ProviderSelectedEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: ProviderSelectedEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__ProviderSelectedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59576 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27205);
		    DAT_ram_00a59576 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param2_00,param2[5],param2);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_27205;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102ca38;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102ca38:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600721F")]
		[Address(RVA = "0xBC28", Offset = "0xBC28", VA = "0xBC28")]
		private void ShowSelectBillingDialogEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: ShowSelectBillingDialogEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__ShowSelectBillingDialogEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59577 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26229);
		    DAT_ram_00a59577 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param2_00,param2[5],param2);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_26229;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102cb30;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102cb30:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007220")]
		[Address(RVA = "0xBC29", Offset = "0xBC29", VA = "0xBC29")]
		private void PurchaseRequirementsErrorEvent(BillingScope.BuyOptionErrorEventArgs e)
		{
		/* --- GHIDRA: PurchaseRequirementsErrorEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__PurchaseRequirementsErrorEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59578 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24688);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24689);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22970);
		    DAT_ram_00a59578 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  if (param2[6] != 0) {
		    uVar2 = func_ii_7793(StringLiteral_1236,param2[6],0);
		    func_ii_2946(param1_00,StringLiteral_24688,uVar2,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  if (param2[5] != 0) {
		    func_ii_2946(param1_00,StringLiteral_22970,param2[5],
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  param1_01 = (int *)param1[2];
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_24689;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102cc91;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102cc91:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007221")]
		[Address(RVA = "0xBC2A", Offset = "0xBC2A", VA = "0xBC2A")]
		private void RequestProductsErrorEvent(BillingScope.RequestProductsInfoArgs e)
		{
		/* --- GHIDRA: RequestProductsErrorEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__RequestProductsErrorEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59579 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24688);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26422);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22970);
		    DAT_ram_00a59579 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  if (param2[6] != 0) {
		    uVar2 = func_ii_7793(StringLiteral_1236,param2[6],0);
		    func_ii_2946(param1_00,StringLiteral_24688,uVar2,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  if (param2[5] != 0) {
		    func_ii_2946(param1_00,StringLiteral_22970,param2[5],
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  param1_01 = (int *)param1[2];
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26422;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102ce44;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102ce44:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007222")]
		[Address(RVA = "0xBC2B", Offset = "0xBC2B", VA = "0xBC2B")]
		private void InvalidProductsInfoEvent(BillingScope.RequestProductsInfoArgs e)
		{
		/* --- GHIDRA: InvalidProductsInfoEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__InvalidProductsInfoEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a5957a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27204);
		    DAT_ram_00a5957a = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param1_00,param2[5],param2);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		            (param2,param1_00,param2[6],param2);
		  iVar6 = param2[7];
		  if (DAT_ram_00a59584 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25676);
		    DAT_ram_00a59584 = '\x01';
		  }
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(iVar6,0);
		  uVar2 = StringLiteral_24944;
		  if (iVar3 != 0) {
		    iVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_25676,iVar6,0);
		  }
		  uVar1 = 0;
		  func_ii_2946(param1_00,uVar2,iVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27204;
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102d011;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102d011:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007223")]
		[Address(RVA = "0xBC2C", Offset = "0xBC2C", VA = "0xBC2C")]
		private void BuyOptionRequestMarketEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: BuyOptionRequestMarketEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionRequestMarketEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5957b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26421);
		    DAT_ram_00a5957b = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  uVar1 = 0;
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent(0,param1_00,param2[5],0);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload(0,param1_00,param2[6],0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26421;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102d2f1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102d2f1:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007224 RID: 29220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007224")]
		[Address(RVA = "0xBC2D", Offset = "0xBC2D", VA = "0xBC2D")]
		private void BuyOptionRequestInfoEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: BuyOptionRequestInfoEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionRequestInfoEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5957c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25818);
		    DAT_ram_00a5957c = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_25818;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102d42e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102d42e:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007225 RID: 29221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007225")]
		[Address(RVA = "0xBC2E", Offset = "0xBC2E", VA = "0xBC2E")]
		private void OnRestoreTransactionCompleteEvent(BaseEventBusEventArgs e)
		{
		/* --- GHIDRA: OnRestoreTransactionCompleteEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__OnRestoreTransactionCompleteEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a5957d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26223);
		    DAT_ram_00a5957d = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param1_00,param2[5],param2);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		            (param2,param1_00,param2[6],param2);
		  iVar6 = param2[7];
		  if (DAT_ram_00a59584 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25676);
		    DAT_ram_00a59584 = '\x01';
		  }
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(iVar6,0);
		  uVar2 = StringLiteral_24944;
		  if (iVar3 != 0) {
		    iVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_25676,iVar6,0);
		  }
		  uVar1 = 0;
		  func_ii_2946(param1_00,uVar2,iVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26223;
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102d5fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102d5fb:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007226 RID: 29222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007226")]
		[Address(RVA = "0xBC2F", Offset = "0xBC2F", VA = "0xBC2F")]
		private void BuyOptionCancelEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: BuyOptionCancelEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionCancelEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a5957e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26230);
		    DAT_ram_00a5957e = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param1_00,param2[5],param2);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		            (param2,param1_00,param2[6],param2);
		  iVar6 = param2[7];
		  if (DAT_ram_00a59584 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25676);
		    DAT_ram_00a59584 = '\x01';
		  }
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(iVar6,0);
		  uVar2 = StringLiteral_24944;
		  if (iVar3 != 0) {
		    iVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_25676,iVar6,0);
		  }
		  uVar1 = 0;
		  func_ii_2946(param1_00,uVar2,iVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26230;
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102d7c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102d7c8:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007227 RID: 29223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007227")]
		[Address(RVA = "0xBC30", Offset = "0xBC30", VA = "0xBC30")]
		private void BuyOptionPendingPurchaseEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: BuyOptionPendingPurchaseEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionPendingPurchaseEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5957f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22525);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21392);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27876);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22117);
		    DAT_ram_00a5957f = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  func_ii_2946(param1_00,StringLiteral_21392,param2[0xc],
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_22525,param2[8],
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined8 *)(param2 + 10);
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27876,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_22117;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102d998;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102d998:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007228 RID: 29224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007228")]
		[Address(RVA = "0xBC31", Offset = "0xBC31", VA = "0xBC31")]
		private void CurrencyConvertErrorEvent(BillingScope.CurrencyConverterErrorEventArgs e)
		{
		/* --- GHIDRA: CurrencyConvertErrorEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__CurrencyConvertErrorEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined8 in_i3q;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  float fVar8;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar5 = (undefined4)((ulonglong)in_i3q >> 0x20);
		  if (DAT_ram_00a59580 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26159);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26237);
		    DAT_ram_00a59580 = '\x01';
		  }
		  iVar7 = *param2;
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(iVar7 + 0xe4));
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (0,param2_00,param2[5],iVar7);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		            (iVar7,param2_00,param2[6],iVar7);
		  local_4 = (float4)param2[8];
		  uVar2 = func_ii_1081(DAT_ram_00a6696c,&local_4);
		  func_ii_2946(param2_00,StringLiteral_26159,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar6 = *(int **)(param1 + 8);
		  local_8 = (float4)param2[8];
		  uVar3 = func_ii_1081(DAT_ram_00a6696c,&local_8);
		  uVar2 = StringLiteral_26237;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x8102daf5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,2);
		code_r0x8102daf5:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar2,uVar3,CONCAT44(uVar5,puVar4[1]));
		  piVar6 = *(int **)(param1 + 8);
		  uVar1 = 0;
		  uVar5 = func_ii_14094(param2[5],0);
		  fVar8 = (float)param2[8];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x8102db91;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Analytics_Service_IAnalyticsApi_TypeInfo,4);
		code_r0x8102db91:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar5,1,(double)fVar8,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007229")]
		[Address(RVA = "0xBC32", Offset = "0xBC32", VA = "0xBC32")]
		private void PurchaseInfoEvent(BillingScope.PurchaseInfoEventArgs e)
		{
		/* --- GHIDRA: PurchaseInfoEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__PurchaseInfoEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  int iVar6;
		  int local_4;
		  
		  if (DAT_ram_00a59581 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22982);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26225);
		    DAT_ram_00a59581 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  iVar6 = *param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(iVar6 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (iVar6,param1_00,param2[5],iVar6);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		            (iVar6,param1_00,param2[6],iVar6);
		  iVar6 = param2[7];
		  if (DAT_ram_00a59584 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25676);
		    DAT_ram_00a59584 = '\x01';
		  }
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(iVar6,0);
		  uVar2 = StringLiteral_24944;
		  if (iVar3 != 0) {
		    iVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_25676,iVar6,0);
		  }
		  uVar1 = 0;
		  func_ii_2946(param1_00,uVar2,iVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = param2[9];
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  func_ii_2946(param1_00,StringLiteral_22980,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_22982,param2[8],
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26225;
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102ddd6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102ddd6:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722A")]
		[Address(RVA = "0xBC33", Offset = "0xBC33", VA = "0xBC33")]
		private void BuyOptionErrorEvent(BillingScope.BuyOptionErrorEventArgs e)
		{
		/* --- GHIDRA: BuyOptionErrorEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionErrorEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a59582 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26233);
		    DAT_ram_00a59582 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		            (param2,param1_00,param2[5],param2);
		  Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		            (param2,param1_00,param2[6],param2);
		  iVar6 = param2[7];
		  if (DAT_ram_00a59584 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25676);
		    DAT_ram_00a59584 = '\x01';
		  }
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(iVar6,0);
		  uVar2 = StringLiteral_24944;
		  if (iVar3 != 0) {
		    iVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_25676,iVar6,0);
		  }
		  uVar1 = 0;
		  func_ii_2946(param1_00,uVar2,iVar6,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26233;
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8102dfaa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102dfaa:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722B")]
		[Address(RVA = "0xBC34", Offset = "0xBC34", VA = "0xBC34")]
		private void BuyOptionSuccessEvent(BillingScope.BuyOptionEventArgs e)
		{
		/* --- GHIDRA: BuyOptionSuccessEvent ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__BuyOptionSuccessEvent
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a59583 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27256);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27228);
		    DAT_ram_00a59583 = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = func_ii_14094(param3,0);
		    func_ii_2946(param2,StringLiteral_27256,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    func_ii_2946(param2,StringLiteral_26152,*(undefined4 *)(*(int *)(param3 + 0x18) + 0x18),
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    local_1 = *(undefined1 *)(param3 + 0x6c);
		    uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		    func_ii_2946(param2,StringLiteral_27228,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600722C RID: 29228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722C")]
		[Address(RVA = "0xBC35", Offset = "0xBC35", VA = "0xBC35")]
		private void AppendBankOptionDataProperties(Dictionary<string, object> properties, BankOptionData optionData)
		{
		/* --- GHIDRA: AppendBankOptionDataProperties ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__AppendBankOptionDataProperties
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a59584 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24944);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25676);
		    DAT_ram_00a59584 = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param3,0);
		  param2_00 = StringLiteral_24944;
		  if (iVar1 != 0) {
		    param3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_25676,param3,0);
		  }
		  func_ii_2946(param2,param2_00,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x0600722D RID: 29229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722D")]
		[Address(RVA = "0xBC36", Offset = "0xBC36", VA = "0xBC36")]
		private void AppendJsonPayload(Dictionary<string, object> properties, string jsonPayload)
		{
		/* --- GHIDRA: AppendJsonPayload ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__AppendJsonPayload
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59585 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26227);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26228);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25163);
		    DAT_ram_00a59585 = '\x01';
		  }
		  if (param3 != 0) {
		    if (*(char *)(param3 + 0xc) != '\0') {
		      func_ii_2946(param2,StringLiteral_26226,*(undefined4 *)(param3 + 0x10),
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      local_4 = *(undefined4 *)(param3 + 0x14);
		      param3_00 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      func_ii_2946(param2,StringLiteral_26227,param3_00,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    }
		    if (*(int *)(param3 + 8) != 0) {
		      func_ii_2946(param2,StringLiteral_26228,*(undefined4 *)(*(int *)(param3 + 8) + 8),
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		      func_ii_2946(param2,StringLiteral_25163,*(undefined4 *)(*(int *)(param3 + 8) + 0xc),
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    }
		    if (*(int *)(param3 + 0x18) != 0) {
		      func_ii_2946(param2,StringLiteral_26236,*(int *)(param3 + 0x18),
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722E")]
		[Address(RVA = "0xBC37", Offset = "0xBC37", VA = "0xBC37")]
		private void AppendPurchaseProperties(Dictionary<string, object> properties, PurchaseDto purchase)
		{
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600722F")]
		[Address(RVA = "0xBC38", Offset = "0xBC38", VA = "0xBC38")]
		public BillingAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_BillingAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59586 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20575);
		    DAT_ram_00a59586 = '\x01';
		  }
		  return StringLiteral_20575;
		}
		*/

		}

		// Token: 0x04003BCB RID: 15307
		[Token(Token = "0x4003BCB")]
		private const string REQUEST_OPTION_INFO = "request_option_info";

		// Token: 0x04003BCC RID: 15308
		[Token(Token = "0x4003BCC")]
		private const string SHOW_PURCHASE_DIALOG = "show_purchase_dialog";

		// Token: 0x04003BCD RID: 15309
		[Token(Token = "0x4003BCD")]
		private const string ON_RESTORE_TRANSACTION = "on_restore_transaction";

		// Token: 0x04003BCE RID: 15310
		[Token(Token = "0x4003BCE")]
		private const string PURCHASE_CANCELED = "purchase_canceled";

		// Token: 0x04003BCF RID: 15311
		[Token(Token = "0x4003BCF")]
		private const string PURCHASE_PENDING = "purchase_pending";

		// Token: 0x04003BD0 RID: 15312
		[Token(Token = "0x4003BD0")]
		private const string PURCHASE_SUCCESS = "purchase_success";

		// Token: 0x04003BD1 RID: 15313
		[Token(Token = "0x4003BD1")]
		private const string PURCHASE_ERROR = "purchase_error";

		// Token: 0x04003BD2 RID: 15314
		[Token(Token = "0x4003BD2")]
		private const string CURRENCY_CONVERTER_ERROR = "currency_converter_error";

		// Token: 0x04003BD3 RID: 15315
		[Token(Token = "0x4003BD3")]
		private const string INVALID_PRODUCTS = "invalid_products";

		// Token: 0x04003BD4 RID: 15316
		[Token(Token = "0x4003BD4")]
		private const string REQUEST_PRODUCTS_ERROR = "request_products_error";

		// Token: 0x04003BD5 RID: 15317
		[Token(Token = "0x4003BD5")]
		private const string PURCHASE_INTENT_FAILED = "purchase_intent_failed";

		// Token: 0x04003BD6 RID: 15318
		[Token(Token = "0x4003BD6")]
		private const string SHOW_SELECT_BILLING_DIALOG = "show_select_billing_dialog";

		// Token: 0x04003BD7 RID: 15319
		[Token(Token = "0x4003BD7")]
		private const string PROVIDER_SELECTED = "provider_selected";

		// Token: 0x04003BD8 RID: 15320
		[Token(Token = "0x4003BD8")]
		private const string REF_PAY = "ref_pay";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_BillingAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59572 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionCancelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionErrorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionPendingPurchaseEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestInfoEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestMarketEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_CurrencyConvertErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_InvalidProductsInfoEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_OnRestoreTransactionCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_ProviderSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseInfoEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseRequirementsErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_RefPayEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_BillingAnalyticsListener_RequestProductsErrorEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_BillingAnalyticsListener_ShowSelectBillingDialogEvent__
		              );
		    DAT_ram_00a59572 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionSuccessEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionErrorEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseInfoEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x2c) = iVar3;
		    uVar2 = System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_PurchaseInfoEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417
		                    (System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_CurrencyConvertErrorEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo)
		    ;
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x30) = iVar3;
		    uVar2 = System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_CurrencyConverterErrorEventArgs__TypeInfo)
		    ;
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionPendingPurchaseEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionCancelEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_OnRestoreTransactionCompleteEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestInfoEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_BuyOptionRequestMarketEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_InvalidProductsInfoEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_RequestProductsErrorEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_RequestProductsInfoArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_PurchaseRequirementsErrorEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionErrorEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_ShowSelectBillingDialogEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x38) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x38) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_BillingAnalyticsListener_ProviderSelectedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x3c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x3c) = iVar3;
		    uVar2 = System_Action_BillingScope_BuyOptionEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_BuyOptionEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x20);
		  uVar5 = *(undefined4 *)(iVar4 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_BillingAnalyticsListener_RefPayEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x40) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x40) = iVar3;
		    uVar2 = System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BillingScope_RefPayInfoEventArgs__TypeInfo);
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
