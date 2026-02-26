using System;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Model;
using Gameplay.Billing.Events;
using Gameplay.Billing.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using OKG.Currencies;
using Protocol.Services;

namespace Gameplay.Billing.Controller
{
	// Token: 0x02000BF7 RID: 3063
	[Token(Token = "0x2000BF7")]
	public abstract class AbstractBillingController : AbstractController<AbstractBillingModel, BillingEvents>
	{
		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004B10 RID: 19216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F28")]
		private protected CurrencyConverter CurrencyConverter
		{
			[Token(Token = "0x6004B0F")]
			[Address(RVA = "0x996C", Offset = "0x996C", VA = "0x996C")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6004B10")]
			[Address(RVA = "0x996D", Offset = "0x996D", VA = "0x996D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x996E", Offset = "0x996E", VA = "0x996E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x996F", Offset = "0x996F", VA = "0x996F")]
		protected AbstractBillingController([NotNull] CurrencyConverter currencyConverter, [NotNull] AbstractBillingModel model, [NotNull] BillingEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Billing_Controller_AbstractBillingController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6092b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_Controller_AbstractBillingController_HandleRefPayEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_RefPayEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6092b = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  param1_01 = unnamed_function_1417(System_Action_RefPayEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Billing_Controller_AbstractBillingController_HandleRefPayEvent__,0);
		  ServicesNamespace_ServicesService__add_RefPayEvent(param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x9970", Offset = "0x9970", VA = "0x9970", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Billing_Controller_AbstractBillingController__HandleStop
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6092c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_Controller_AbstractBillingController_HandleRefPayEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_RefPayEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6092c = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  param1_01 = unnamed_function_1417(System_Action_RefPayEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Billing_Controller_AbstractBillingController_HandleRefPayEvent__,0);
		  ServicesNamespace_ServicesService__remove_PaymentBonusAchievedEvent(param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x9971", Offset = "0x9971", VA = "0x9971", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Billing_Controller_AbstractBillingController__HandleRun
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6092d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6092d = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x10);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 400);
		        goto code_r0x81cff366;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81cff366:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar2 = func_ii_6875(*(undefined4 *)(iVar2 + 0x2c),*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),
		                       &local_4,0);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x120) * 4))
		              (param1,local_4,param2,*(undefined4 *)(*param1 + 0x124));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x9972", Offset = "0x9972", VA = "0x9972")]
		private void HandleRefPayEvent(RefPayEvt msg)
		{
		/* --- GHIDRA: HandleRefPayEvent ---
		void Gameplay_Billing_Controller_AbstractBillingController__HandleRefPayEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a6092a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AbstractBillingModel__BillingEvents___ctor__);
		    DAT_ram_00a6092a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_AbstractBillingModel__BillingEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06004B16 RID: 19222
		[Token(Token = "0x6004B16")]
		protected abstract void RefPayHandler(BankOptionData option, RefPayEvt msg);

		// Token: 0x06004B17 RID: 19223
		[Token(Token = "0x6004B17")]
		public abstract void BuyOption(BankOptionData bankOptionData);

		// Token: 0x06004B18 RID: 19224
		[Token(Token = "0x6004B18")]
		public abstract void ConsumeIfExist();
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrencyConverter ---
		void Gameplay_Billing_Controller_AbstractBillingController__set_CurrencyConverter
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60929 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AbstractBillingModel__BillingEvents__Dispose__);
		    DAT_ram_00a60929 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_AbstractBillingModel__BillingEvents__Dispose__);
		  return;
		}
		*/

}
