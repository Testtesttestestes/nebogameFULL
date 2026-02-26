using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider.HeavensBank;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public class UIAPBillingProvider : IBillingProvider, IDisposable
	{
		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x17000F45")]
		public BillingProviderId ProviderId
		{
			[Token(Token = "0x6004B78")]
			[Address(RVA = "0x99C7", Offset = "0x99C7", VA = "0x99C7", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return BillingProviderId.Unknown;
			}
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B79")]
		[Address(RVA = "0x99C8", Offset = "0x99C8", VA = "0x99C8", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0x99C9", Offset = "0x99C9", VA = "0x99C9")]
		public UIAPBillingProvider(BillingProviderId billingProviderId, IStoreProvider store)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UIAPBillingProvider___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_BillingProvider_UnityIAP_UIAPBillingProvider_SetToken__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x99CA", Offset = "0x99CA", VA = "0x99CA", Slot = "5")]
		public void SetToken(string value)
		{
		/* --- GHIDRA: SetToken ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UIAPBillingProvider__SetToken
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(param2 + 0xc) * 4))
		            (*(undefined4 *)(param2 + 0x20),0x7fc00000,*(undefined4 *)(param2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0x99CB", Offset = "0x99CB", VA = "0x99CB", Slot = "6")]
		public void GetBalance(Action<float> callback)
		{
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x99CC", Offset = "0x99CC", VA = "0x99CC", Slot = "7")]
		public string GetCurrencyCode(AbstractBillingModel model)
		{
		/* --- GHIDRA: GetCurrencyCode ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UIAPBillingProvider__GetCurrencyCode
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 *param2_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 param2_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6093d == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Purchasing_IStoreController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_UnityIAP_IStoreProvider_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse_TypeInfo
		              );
		    DAT_ram_00a6093d = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse_TypeInfo
		                    );
		  piVar6 = *(int **)(param1 + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Billing_BillingProvider_UnityIAP_IStoreProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (undefined4 *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		        ;
		        goto code_r0x81d018fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                      Gameplay_Billing_BillingProvider_UnityIAP_IStoreProvider_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81d01aae:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x81d018fe:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81d01aae;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x1b,param3,0)
		    ;
		    if (DAT_ram_009d3e38 != 1) {
		      uVar1 = 0;
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (UnityEngine_Purchasing_IStoreController_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (undefined4 *)
		                     (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81d01a08;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                          UnityEngine_Purchasing_IStoreController_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x81d01a08:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(*puVar3,piVar6,uVar4,puVar3[1]);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          if (DAT_ram_00a6095d == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&
		                       Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse_Status_TypeInfo
		                      );
		            DAT_ram_00a6095d = '\x01';
		          }
		          local_8 = 0x4ffffffff;
		          local_c = 
		          Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse_Status_TypeInfo
		          ;
		          uVar4 = Spine_SkeletonJson__GetFloat(&local_c,0);
		          *(undefined4 *)(iVar2 + 8) = uVar4;
		          (**(code **)((ulonglong)*(uint *)(param5 + 0xc) * 4))
		                    (*(undefined4 *)(param5 + 0x20),iVar2,*(undefined4 *)(param5 + 0x14));
		          return;
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar3);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar5 != 0) {
		          param2_01 = *puVar3;
		          import::env::__cxa_end_catch();
		          uVar4 = unnamed_function_2232(&StringLiteral_28579);
		          uVar4 = func_ii_4419(uVar4,param2_01,0);
		          iVar7 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar7 + 0x74) == 0) {
		            func_ii_306000(iVar7);
		          }
		          func_ii_7109(uVar4,0);
		          Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse__GetStatus
		                    (iVar2,3,uVar4);
		          (**(code **)((ulonglong)*(uint *)(param5 + 0xc) * 4))
		                    (*(undefined4 *)(param5 + 0x20),iVar2,*(undefined4 *)(param5 + 0x14));
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81d01c20;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81d01c20:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7E")]
		[Address(RVA = "0x99CD", Offset = "0x99CD", VA = "0x99CD", Slot = "8")]
		public void RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, Action<HVBillingVo.PaymentStatusChangedResponse> callback)
		{
		/* --- GHIDRA: RunPurchase ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UIAPBillingProvider__RunPurchase
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6093e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_PurchaseEventArgs__PurchaseProcessingResult__TypeInfo)
		    ;
		    DAT_ram_00a6093e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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

		/* --- GHIDRA: RunPurchase ---
		void Gameplay_Billing_BillingProvider_UnityIAP_UIAPBillingProvider__RunPurchase
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6093e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_PurchaseEventArgs__PurchaseProcessingResult__TypeInfo)
		    ;
		    DAT_ram_00a6093e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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

		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x99CE", Offset = "0x99CE", VA = "0x99CE", Slot = "9")]
		public UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, CancellationToken cancellationToken)
		{
			return default(UniTask<HVBillingVo.PaymentStatusChangedResponse>);
		}

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0xC")]
		private IStoreProvider _store;
	}
}
