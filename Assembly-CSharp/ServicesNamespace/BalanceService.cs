using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Balance;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public class BalanceService : AbstractService
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x17000092")]
		public override short ServiceId
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x581C", Offset = "0x581C", VA = "0x581C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000016")]
		public event Action<ProtoResourcesChangedEvt> BalanceChangedEvent
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x581D", Offset = "0x581D", VA = "0x581D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x581E", Offset = "0x581E", VA = "0x581E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000017")]
		public event Action<double> ExternalMoneyChangedEvent
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x581F", Offset = "0x581F", VA = "0x581F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x5820", Offset = "0x5820", VA = "0x5820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x5821", Offset = "0x5821", VA = "0x5821", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_BalanceService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  int param1_00;
		  
		  if (DAT_ram_00a6288b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserBalanceAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3769);
		    DAT_ram_00a6288b = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar1 = (int *)Core_Net_AbstractService__PushCommand
		                            (param1,*(undefined4 *)
		                                     (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  if (piVar1[2] == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    param3 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,1,param3,0);
		    *(undefined4 *)(param1_00 + 0x14) = StringLiteral_3769;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserBalanceAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x5822", Offset = "0x5822", VA = "0x5822")]
		public OpToken<IMessage, object> GetUserBalance()
		{
		/* --- GHIDRA: GetUserBalance ---
		int * ServicesNamespace_BalanceService__GetUserBalance(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6288c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_BalanceCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetEnergyRegenStatusAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6288c = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar1 = (int *)Core_Net_AbstractService__PushCommand
		                            (param1,*(undefined4 *)
		                                     (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  if (piVar1[2] == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    param3 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,2,param3,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Balance_BalanceCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetEnergyRegenStatusAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5823", Offset = "0x5823", VA = "0x5823")]
		public OpToken<IMessage, object> GetEnergyRegenStatus()
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5824", Offset = "0x5824", VA = "0x5824")]
		public void ChangeBalance(ProtoResourcesChangedEvt value)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5825", Offset = "0x5825", VA = "0x5825")]
		public BalanceService()
		{
		/* --- GHIDRA: .ctor ---
		void ServicesNamespace_BalanceService___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6288d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    DAT_ram_00a6288d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoStateChangedEvt__TypeInfo), iVar2 == 0))
		    break;
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

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_BalanceService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62886 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoResourcesChangedEvt__TypeInfo);
		    DAT_ram_00a62886 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoResourcesChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoResourcesChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: add_BalanceChangedEvent ---
		void ServicesNamespace_BalanceService__add_BalanceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62887 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoResourcesChangedEvt__TypeInfo);
		    DAT_ram_00a62887 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoResourcesChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoResourcesChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: remove_BalanceChangedEvent ---
		void ServicesNamespace_BalanceService__remove_BalanceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62888 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    DAT_ram_00a62888 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_double__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_double__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_ExternalMoneyChangedEvent ---
		void ServicesNamespace_BalanceService__add_ExternalMoneyChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62889 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    DAT_ram_00a62889 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_double__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_double__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ExternalMoneyChangedEvent ---
		void ServicesNamespace_BalanceService__remove_ExternalMoneyChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6288a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_BalanceEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoBalanceChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoResourcesChangedEvt_TypeInfo);
		    DAT_ram_00a6288a = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar2,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_BalanceEvents___);
		  if (iVar2 == 4) {
		    piVar1 = *(int **)(param2 + 0x20);
		    if ((piVar1 != (int *)0x0) && (Protocol_Balance_ProtoBalanceChangedEvt_TypeInfo != *piVar1)) {
		      System_Activator__CreateInstance(piVar1,Protocol_Balance_ProtoBalanceChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *(int *)(param1 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(double *)(piVar1 + 4) / 100.0,
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  else if (((iVar2 != 5) && (iVar2 == 6)) && (iVar2 = *(int *)(param1 + 0x14), iVar2 != 0)) {
		    piVar1 = *(int **)(param2 + 0x20);
		    if ((piVar1 != (int *)0x0) && (Protocol_Balance_ProtoResourcesChangedEvt_TypeInfo != *piVar1)) {
		      System_Activator__CreateInstance(piVar1,Protocol_Balance_ProtoResourcesChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),CONCAT44(in_register_20000014,piVar1),
		               *(undefined4 *)(iVar2 + 0x14));
		    return;
		  }
		  return;
		}
		*/

}
