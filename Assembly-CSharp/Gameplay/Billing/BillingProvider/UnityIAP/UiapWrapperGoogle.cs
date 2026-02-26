using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	public class UiapWrapperGoogle : IDetailedStoreListener, IStoreListener, IUiapWrapper
	{
		// Token: 0x140001D2 RID: 466
		// (add) Token: 0x06004B89 RID: 19337 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B8A RID: 19338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D2")]
		public event Func<PurchaseEventArgs, PurchaseProcessingResult> ProcessPurchaseEvent
		{
			[Token(Token = "0x6004B89")]
			[Address(RVA = "0x99CF", Offset = "0x99CF", VA = "0x99CF", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B8A")]
			[Address(RVA = "0x99D0", Offset = "0x99D0", VA = "0x99D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D3 RID: 467
		// (add) Token: 0x06004B8B RID: 19339 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B8C RID: 19340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D3")]
		public event Action<IStoreController, IExtensionProvider> InitEvent
		{
			[Token(Token = "0x6004B8B")]
			[Address(RVA = "0x99D1", Offset = "0x99D1", VA = "0x99D1", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B8C")]
			[Address(RVA = "0x99D2", Offset = "0x99D2", VA = "0x99D2", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D4 RID: 468
		// (add) Token: 0x06004B8D RID: 19341 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B8E RID: 19342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D4")]
		public event Action<InitializationFailureData> InitFailedEvent
		{
			[Token(Token = "0x6004B8D")]
			[Address(RVA = "0x99D3", Offset = "0x99D3", VA = "0x99D3", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B8E")]
			[Address(RVA = "0x99D4", Offset = "0x99D4", VA = "0x99D4", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D5 RID: 469
		// (add) Token: 0x06004B8F RID: 19343 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B90 RID: 19344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D5")]
		public event Action<Product, PurchaseFailureDescription> PurchaseFailedEvent
		{
			[Token(Token = "0x6004B8F")]
			[Address(RVA = "0x99D5", Offset = "0x99D5", VA = "0x99D5", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B90")]
			[Address(RVA = "0x99D6", Offset = "0x99D6", VA = "0x99D6", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D6 RID: 470
		// (add) Token: 0x06004B91 RID: 19345 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B92 RID: 19346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D6")]
		public event Action<Product> DeferredPurchaseEvent
		{
			[Token(Token = "0x6004B91")]
			[Address(RVA = "0x99D7", Offset = "0x99D7", VA = "0x99D7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B92")]
			[Address(RVA = "0x99D8", Offset = "0x99D8", VA = "0x99D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001D7 RID: 471
		// (add) Token: 0x06004B93 RID: 19347 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004B94 RID: 19348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D7")]
		public event Action DisconnectAtInitializeEvent
		{
			[Token(Token = "0x6004B93")]
			[Address(RVA = "0x99D9", Offset = "0x99D9", VA = "0x99D9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004B94")]
			[Address(RVA = "0x99DA", Offset = "0x99DA", VA = "0x99DA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x99DB", Offset = "0x99DB", VA = "0x99DB", Slot = "18")]
		public void Validate(IEnumerable<ProductDefinition> productDefinitions)
		{
		/* --- GHIDRA: Validate ---
		undefined4
		Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__Validate
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a6094b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Product__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_IPurchasingModule___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Purchasing_ConfigurationBuilder_Configure_IGooglePlayConfiguration___
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Purchasing_StandardPurchasingModule_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle_HandleQueryProductDetailsFailedListener__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle_HandleServiceDisconnect__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle_OnPurchaseDeferred__
		              );
		    DAT_ram_00a6094b = '\x01';
		  }
		  if ((*(char *)(param1 + 0x25) == '\0') && (*(char *)(param1 + 0x24) == '\0')) {
		    *(undefined1 *)(param1 + 0x25) = 1;
		    if (*(int *)(UnityEngine_Purchasing_StandardPurchasingModule_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Purchasing_StandardPurchasingModule_TypeInfo);
		    }
		    uVar1 = UnityEngine_Purchasing_StandardPurchasingModule__set_useFakeStoreAlways(0);
		    iVar6 = Method_System_Array_Empty_IPurchasingModule___;
		    iVar5 = *(int *)(Method_System_Array_Empty_IPurchasingModule___ + 0x1c);
		    if (iVar5 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference
		                (Method_System_Array_Empty_IPurchasingModule___);
		      iVar5 = *(int *)(iVar6 + 0x1c);
		    }
		    iVar5 = *(int *)(iVar5 + 8);
		    if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		      iVar5 = func_ii_1079(iVar5);
		    }
		    if (*(int *)(iVar5 + 0x74) == 0) {
		      func_ii_306000(iVar5);
		    }
		    uVar2 = 0;
		    iVar6 = *(int *)(*(int *)(iVar6 + 0x1c) + 8);
		    if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		      iVar6 = func_ii_1079(iVar6);
		    }
		    uVar1 = UnityEngine_Purchasing_ConfigurationBuilder__get_factory
		                      (uVar1,**(undefined4 **)(iVar6 + 0x5c),0);
		    param1_00 = (int *)Unity_Properties_ConcreteTypeVisitor__Unity_Properties_IPropertyBagVisitor_Visit___Il2CppFullySharedGenericType_
		                                 (uVar1,
		                                  Method_UnityEngine_Purchasing_ConfigurationBuilder_Configure_IGooglePlayConfiguration___
		                                 );
		    UnityEngine_Purchasing_ConfigurationBuilder__Instance(uVar1,param2,0);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		          goto code_r0x81d024e1;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo
		                                  ,3);
		code_r0x81d024e1:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,10,puVar3[1]);
		    uVar2 = 0;
		    uVar4 = unnamed_function_1417(System_Action_Product__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle_OnPurchaseDeferred__
		               ,0);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x81d0257c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo
		                                  ,2);
		code_r0x81d0257c:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,puVar3[1]);
		    uVar2 = 0;
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle_HandleServiceDisconnect__
		               ,0);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81d02617;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo
		                                  ,0);
		code_r0x81d02617:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,puVar3[1]);
		    uVar2 = 0;
		    uVar4 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle_HandleQueryProductDetailsFailedListener__
		               ,0);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81d026b2;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UnityEngine_Purchasing_IGooglePlayConfiguration_TypeInfo
		                                  ,1);
		code_r0x81d026b2:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,puVar3[1]);
		    UnityEngine_Purchasing_UnifiedReceiptExtensions__ToTransactionServer(param1,uVar1,0);
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x99DC", Offset = "0x99DC", VA = "0x99DC")]
		private bool TryInit(IEnumerable<ProductDefinition> productDefinitions)
		{
		/* --- GHIDRA: TryInit ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__TryInit
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6094c == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16746);
		    DAT_ram_00a6094c = '\x01';
		  }
		  local_4 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_16746,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x99DD", Offset = "0x99DD", VA = "0x99DD")]
		private void HandleQueryProductDetailsFailedListener(int value)
		{
		/* --- GHIDRA: HandleQueryProductDetailsFailedListener ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__HandleQueryProductDetailsFailedListener
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6094d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__HandleServiceDisconnect_b__27_0__
		              );
		    DAT_ram_00a6094d = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__HandleServiceDisconnect_b__27_0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_01,param1_00,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x99DE", Offset = "0x99DE", VA = "0x99DE")]
		private void HandleServiceDisconnect()
		{
		/* --- GHIDRA: HandleServiceDisconnect ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__HandleServiceDisconnect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6094e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass28_0__OnPurchaseDeferred_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass28_0_TypeInfo
		              );
		    DAT_ram_00a6094e = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass28_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param2_00,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass28_0__OnPurchaseDeferred_b__0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_01,param1_00,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B99")]
		[Address(RVA = "0x99DF", Offset = "0x99DF", VA = "0x99DF")]
		private void OnPurchaseDeferred(Product product)
		{
		/* --- GHIDRA: OnPurchaseDeferred ---
		undefined4
		Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__OnPurchaseDeferred
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6094f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass29_0__UnityEngine_Purchasing_IStoreListener_ProcessPurchase_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass29_0_TypeInfo
		              );
		    DAT_ram_00a6094f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass29_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 == 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param2_00,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass29_0__UnityEngine_Purchasing_IStoreListener_ProcessPurchase_b__0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_00,uVar1,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return 1;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x99E0", Offset = "0x99E0", VA = "0x99E0", Slot = "7")]
		private PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			return PurchaseProcessingResult.Complete;
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9B")]
		[Address(RVA = "0x99E1", Offset = "0x99E1", VA = "0x99E1", Slot = "8")]
		private void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9C")]
		[Address(RVA = "0x99E2", Offset = "0x99E2", VA = "0x99E2", Slot = "4")]
		private void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
		{
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9D")]
		[Address(RVA = "0x99E3", Offset = "0x99E3", VA = "0x99E3", Slot = "6")]
		private void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x99E4", Offset = "0x99E4", VA = "0x99E4", Slot = "5")]
		private void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x99E5", Offset = "0x99E5", VA = "0x99E5", Slot = "9")]
		private void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x99E6", Offset = "0x99E6", VA = "0x99E6")]
		public UiapWrapperGoogle()
		{
		}

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<Action> _events;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x24")]
		private bool _isInit;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x25")]
		private bool _isInitProcess;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x28")]
		private IStoreController _controller;

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		[FieldOffset(Offset = "0x2C")]
		private IExtensionProvider _extensions;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		[FieldOffset(Offset = "0x30")]
		private int _initCount;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ProcessPurchaseEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__add_ProcessPurchaseEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6093f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_PurchaseEventArgs__PurchaseProcessingResult__TypeInfo)
		    ;
		    DAT_ram_00a6093f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Func_PurchaseEventArgs__PurchaseProcessingResult__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Func_PurchaseEventArgs__PurchaseProcessingResult__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ProcessPurchaseEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__remove_ProcessPurchaseEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60940 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IStoreController__IExtensionProvider__TypeInfo);
		    DAT_ram_00a60940 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IStoreController__IExtensionProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IStoreController__IExtensionProvider__TypeInfo)
		       , iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_InitEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__add_InitEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60941 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IStoreController__IExtensionProvider__TypeInfo);
		    DAT_ram_00a60941 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IStoreController__IExtensionProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IStoreController__IExtensionProvider__TypeInfo)
		       , iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__remove_InitEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60942 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InitializationFailureData__TypeInfo);
		    DAT_ram_00a60942 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_InitializationFailureData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_InitializationFailureData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_InitFailedEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__add_InitFailedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60943 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InitializationFailureData__TypeInfo);
		    DAT_ram_00a60943 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_InitializationFailureData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_InitializationFailureData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitFailedEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__remove_InitFailedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60944 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Product__PurchaseFailureDescription__TypeInfo);
		    DAT_ram_00a60944 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_Product__PurchaseFailureDescription__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Product__PurchaseFailureDescription__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_PurchaseFailedEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__add_PurchaseFailedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60945 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Product__PurchaseFailureDescription__TypeInfo);
		    DAT_ram_00a60945 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_Product__PurchaseFailureDescription__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Product__PurchaseFailureDescription__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_PurchaseFailedEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__remove_PurchaseFailedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60946 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Product__TypeInfo);
		    DAT_ram_00a60946 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_Product__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Product__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeferredPurchaseEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__add_DeferredPurchaseEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60947 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Product__TypeInfo);
		    DAT_ram_00a60947 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_Product__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Product__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeferredPurchaseEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__remove_DeferredPurchaseEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60948 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60948 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DisconnectAtInitializeEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__add_DisconnectAtInitializeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60949 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60949 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DisconnectAtInitializeEvent ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__remove_DisconnectAtInitializeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6094a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Dequeue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__get_Count__);
		    DAT_ram_00a6094a = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__Validate(param1,param2,param2);
		  }
		  else {
		    if ((0 < *(int *)(param1 + 0x30)) && (iVar1 = *(int *)(param1 + 0xc), iVar1 != 0)) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x28),
		                 *(undefined4 *)(param1 + 0x2c),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = *(int *)(param1 + 0x20);
		    iVar2 = *(int *)(iVar1 + 0x14);
		    while (0 < iVar2) {
		      iVar1 = func_ii_7387(iVar1,Method_System_Collections_Generic_Queue_Action__Dequeue__);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      iVar1 = *(int *)(param1 + 0x20);
		      iVar2 = *(int *)(iVar1 + 0x14);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: UnityEngine.Purchasing.IStoreListener.OnPurchaseFailed ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__UnityEngine_Purchasing_IStoreListener_OnPurchaseFailed
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60950 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass31_0__UnityEngine_Purchasing_IDetailedStoreListener_OnPurchaseFailed_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass31_0_TypeInfo
		              );
		    DAT_ram_00a60950 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass31_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param3;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param2_00,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass31_0__UnityEngine_Purchasing_IDetailedStoreListener_OnPurchaseFailed_b__0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_01,param1_00,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: UnityEngine.Purchasing.IDetailedStoreListener.OnPurchaseFailed ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__UnityEngine_Purchasing_IDetailedStoreListener_OnPurchaseFailed
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60951 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_BillingProvider_UnityIAP_InitializationFailureData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass32_0__UnityEngine_Purchasing_IStoreListener_OnInitializeFailed_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass32_0_TypeInfo
		              );
		    DAT_ram_00a60951 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass32_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param1;
		  *(undefined2 *)(param1 + 0x24) = 0;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Billing_BillingProvider_UnityIAP_InitializationFailureData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param3;
		  *(undefined4 *)(iVar1 + 8) = param2;
		  *(int *)(param2_00 + 0xc) = iVar1;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (iVar2 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param2_00,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass32_0__UnityEngine_Purchasing_IStoreListener_OnInitializeFailed_b__0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_01,param1_00,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: UnityEngine.Purchasing.IStoreListener.OnInitializeFailed ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__UnityEngine_Purchasing_IStoreListener_OnInitializeFailed
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60952 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0__UnityEngine_Purchasing_IStoreListener_OnInitialized_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0_TypeInfo
		              );
		    DAT_ram_00a60952 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param3;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  *(undefined4 *)(param1 + 0x2c) = param3;
		  *(undefined4 *)(param1 + 0x28) = param2;
		  *(undefined2 *)(param1 + 0x24) = 1;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param2_00,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0__UnityEngine_Purchasing_IStoreListener_OnInitialized_b__0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_01,param1_00,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return;
		  }
		  *(int *)(param1 + 0x30) = *(int *)(param1 + 0x30) + 1;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: UnityEngine.Purchasing.IStoreListener.OnInitializeFailed ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__UnityEngine_Purchasing_IStoreListener_OnInitializeFailed
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60952 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0__UnityEngine_Purchasing_IStoreListener_OnInitialized_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0_TypeInfo
		              );
		    DAT_ram_00a60952 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param3;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  *(undefined4 *)(param1 + 0x2c) = param3;
		  *(undefined4 *)(param1 + 0x28) = param2;
		  *(undefined2 *)(param1 + 0x24) = 1;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param2_00,
		               Method_Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle___c__DisplayClass34_0__UnityEngine_Purchasing_IStoreListener_OnInitialized_b__0__
		               ,0);
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (param1_01,param1_00,Method_System_Collections_Generic_Queue_Action__Enqueue__);
		    return;
		  }
		  *(int *)(param1 + 0x30) = *(int *)(param1 + 0x30) + 1;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: UnityEngine.Purchasing.IStoreListener.OnInitialized ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UiapWrapperGoogle__UnityEngine_Purchasing_IStoreListener_OnInitialized
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60953 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Action___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_Action__TypeInfo);
		    DAT_ram_00a60953 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Queue_Action__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,Method_System_Collections_Generic_Queue_Action___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  return;
		}
		*/

}
