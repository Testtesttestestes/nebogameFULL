using System;
using System.Collections;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C6B RID: 3179
	[Token(Token = "0x2000C6B")]
	public class PaymentBonusController : AbstractController<PaymentBonusModel, PaymentBonusEvents>
	{
		// Token: 0x06004DB1 RID: 19889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x9BE9", Offset = "0x9BE9", VA = "0x9BE9")]
		public PaymentBonusController(PaymentBonusModel model, PaymentBonusEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_PaymentBonusController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59816 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_PaymentBonusController_ServicesServiceOnPaymentBonusAchievedEvent__
		              );
		    DAT_ram_00a59816 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Bank_Controller_PaymentBonusController_ServicesServiceOnPaymentBonusAchievedEvent__
		             ,0);
		  ServicesNamespace_ServicesService__add_PaymentBonusAchievedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0x9BEA", Offset = "0x9BEA", VA = "0x9BEA", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Bank_Controller_PaymentBonusController__HandleStop(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59817 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_PaymentBonusController_ServicesServiceOnPaymentBonusAchievedEvent__
		              );
		    DAT_ram_00a59817 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Bank_Controller_PaymentBonusController_ServicesServiceOnPaymentBonusAchievedEvent__
		             ,0);
		  ServicesNamespace_ServicesService__remove_AccountChangedEvent(param1_01,param1_00,0);
		  Gameplay_Bank_Controller_PaymentBonusController__ServicesServiceOnPaymentBonusAchievedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x9BEB", Offset = "0x9BEB", VA = "0x9BEB", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Bank_Controller_PaymentBonusController__HandleRun(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59818 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12339);
		    DAT_ram_00a59818 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_12339,0);
		  Gameplay_Bank_Controller_PaymentBonusController__ServicesServiceOnPaymentBonusAchievedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x9BEC", Offset = "0x9BEC", VA = "0x9BEC")]
		private void ServicesServiceOnPaymentBonusAchievedEvent()
		{
		/* --- GHIDRA: ServicesServiceOnPaymentBonusAchievedEvent ---
		void Gameplay_Bank_Controller_PaymentBonusController__ServicesServiceOnPaymentBonusAchievedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59819 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_PaymentBonusController_HandleServiceGetPaymentBonus__
		              );
		    DAT_ram_00a59819 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__EvaluatePaymentRewards
		                    (*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Bank_Controller_PaymentBonusController_HandleServiceGetPaymentBonus__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x9BED", Offset = "0x9BED", VA = "0x9BED")]
		private void RequestPaymentBonus()
		{
		/* --- GHIDRA: RequestPaymentBonus ---
		void Gameplay_Bank_Controller_PaymentBonusController__RequestPaymentBonus
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5981a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BankScope_PaymentBonusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetPaymentBonusAns_TypeInfo);
		    DAT_ram_00a5981a = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Services_ProtoGetPaymentBonusAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Services_ProtoGetPaymentBonusAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Model_PaymentBonusModel___ctor(uVar1,param1_01,param1);
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		    param1[7] = 0;
		  }
		  if (DAT_ram_00a5981b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_Controller_PaymentBonusController__CheckBacktimer_d__8_TypeInfo);
		    DAT_ram_00a5981b = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Bank_Controller_PaymentBonusController__CheckBacktimer_d__8_TypeInfo);
		  *(int **)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  iVar2 = Utils_CoroutineSource__GetMono(iVar2,0);
		  param1[7] = iVar2;
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = System_Uri___ctor(0);
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x48) + 0xc);
		  if (iVar2 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_BankScope_PaymentBonusEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_00,uVar1,param3_00,param1_01,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x9BEE", Offset = "0x9BEE", VA = "0x9BEE")]
		private void HandleServiceGetPaymentBonus(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetPaymentBonus ---
		int Gameplay_Bank_Controller_PaymentBonusController__HandleServiceGetPaymentBonus
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5981b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_Controller_PaymentBonusController__CheckBacktimer_d__8_TypeInfo);
		    DAT_ram_00a5981b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Bank_Controller_PaymentBonusController__CheckBacktimer_d__8_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x9BEF", Offset = "0x9BEF", VA = "0x9BEF")]
		private IEnumerator CheckBacktimer()
		{
		/* --- GHIDRA: CheckBacktimer ---
		void Gameplay_Bank_Controller_PaymentBonusController__CheckBacktimer(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB8")]
		[Address(RVA = "0x9BF0", Offset = "0x9BF0", VA = "0x9BF0")]
		private void DestroyCheckBacktimerCoroutine()
		{
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB9")]
		[Address(RVA = "0x9BF1", Offset = "0x9BF1", VA = "0x9BF1")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Bank_Controller_PaymentBonusController__ValidateInit(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5981c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_PaymentBonusModel__PaymentBonusEvents__Dispose__);
		    DAT_ram_00a5981c = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_PaymentBonusModel__PaymentBonusEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DBA")]
		[Address(RVA = "0x9BF2", Offset = "0x9BF2", VA = "0x9BF2", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _servicesService;

		// Token: 0x04002A53 RID: 10835
		[Token(Token = "0x4002A53")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _checkBacktimerCoroutine;
	}
}
