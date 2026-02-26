using System;
using System.Runtime.InteropServices;
using System.Threading;
using Core.Gameplay;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.HeavensBank
{
	// Token: 0x02000C1E RID: 3102
	[Token(Token = "0x2000C1E")]
	public class HvBillingProvider : IBillingProvider, IDisposable
	{
		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x17000F46")]
		public BillingProviderId ProviderId
		{
			[Token(Token = "0x6004BBF")]
			[Address(RVA = "0x9A05", Offset = "0x9A05", VA = "0x9A05", Slot = "4")]
			get
			{
				return BillingProviderId.Unknown;
			}
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x9A06", Offset = "0x9A06", VA = "0x9A06", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x9A07", Offset = "0x9A07", VA = "0x9A07")]
		public HvBillingProvider(IAuthTokenSource authTokenSource)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___HvBillingProvider__GetBalance_d__6_
		            (param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x9A08", Offset = "0x9A08", VA = "0x9A08", Slot = "5")]
		public void SetToken(string value)
		{
		/* --- GHIDRA: SetToken ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider__SetToken
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6095f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_HvBillingProvider__GetBalance_d__6___
		              );
		    DAT_ram_00a6095f = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_GroupListWindow__OnShow_d__8_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_HvBillingProvider__GetBalance_d__6___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x9A09", Offset = "0x9A09", VA = "0x9A09", Slot = "6")]
		public void GetBalance(Action<float> callback)
		{
		/* --- GHIDRA: GetBalance ---
		undefined4
		Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider__GetBalance
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0xc),0);
		  if (iVar1 != 0) {
		    uVar2 = Core_ExternAppMethods__CopyToClipboard(0);
		    *(undefined4 *)(param1 + 0xc) = uVar2;
		    return uVar2;
		  }
		  return *(undefined4 *)(param1 + 0xc);
		}
		*/

		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x9A0A", Offset = "0x9A0A", VA = "0x9A0A", Slot = "7")]
		public string GetCurrencyCode(AbstractBillingModel model)
		{
		/* --- GHIDRA: GetCurrencyCode ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider__GetCurrencyCode
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60960 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_HvBillingProvider__RunPurchase_d__9___
		              );
		    DAT_ram_00a60960 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_40,0);
		  local_24 = local_38;
		  local_30 = 0xffffffff;
		  local_2c = local_40;
		  local_1c = param1;
		  local_18 = param3;
		  local_14 = param4;
		  local_10 = param5;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_HvBillingProvider__GetBalance_d__6_
		            (&local_2c,&local_30,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_HvBillingProvider__RunPurchase_d__9___
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x9A0B", Offset = "0x9A0B", VA = "0x9A0B", Slot = "8")]
		public void RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, [Optional] Action<HVBillingVo.PaymentStatusChangedResponse> callback)
		{
		/* --- GHIDRA: RunPurchase ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider__RunPurchase
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider_RunPurchase__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: RunPurchase ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider__RunPurchase
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_BillingProvider_HeavensBank_HvBillingProvider_RunPurchase__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x9A0C", Offset = "0x9A0C", VA = "0x9A0C", Slot = "9")]
		public UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, CancellationToken cancellationToken)
		{
			return default(UniTask<HVBillingVo.PaymentStatusChangedResponse>);
		}

		// Token: 0x0400293A RID: 10554
		[Token(Token = "0x400293A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IAuthTokenSource _authTokenSource;

		// Token: 0x0400293B RID: 10555
		[Token(Token = "0x400293B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string _currencyCode;
	}
}
