using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Partycombat;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class PartyCombatService : CombatService
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x170000A7")]
		public override short ServiceId
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x59DA", Offset = "0x59DA", VA = "0x59DA", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000089")]
		public new event Action<Protocol.Partycombat.ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x59DB", Offset = "0x59DB", VA = "0x59DB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x59DC", Offset = "0x59DC", VA = "0x59DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008A")]
		public new event Action<Protocol.Partycombat.ProtoFieldChangedEvt> FieldChangedEvent
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x59DD", Offset = "0x59DD", VA = "0x59DD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x59DE", Offset = "0x59DE", VA = "0x59DE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008B")]
		public new event Action<Protocol.Partycombat.ProtoCombatCompleteEvt> CombatCompleteEvent
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x59DF", Offset = "0x59DF", VA = "0x59DF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x59E0", Offset = "0x59E0", VA = "0x59E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x59E1", Offset = "0x59E1", VA = "0x59E1", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_PartyCombatService__ServerEventHandler
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_ProtoRequestCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRequestCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559f0 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    iVar1 = unnamed_function_1417(Protocol_Partycombat_ProtoRequestCombatCmd_TypeInfo);
		    Protocol_Partycombat_ProtoRequestCombatCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0)
		    ;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    Google_Protobuf_Collections_RepeatedField_long___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0x10),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_long__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,6,iVar1,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Combat_CombatCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoRequestCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x59E2", Offset = "0x59E2", VA = "0x59E2")]
		public OpToken<IMessage, object> PutJoinRequest(CombatTypes combatType, params long[] parameters)
		{
		/* --- GHIDRA: PutJoinRequest ---
		int * ServicesNamespace_PartyCombatService__PutJoinRequest(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559f1 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,0,0);
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Combat_CombatCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x59E3", Offset = "0x59E3", VA = "0x59E3", Slot = "46")]
		public override OpToken<IMessage, object> JoinToCombat()
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x59E4", Offset = "0x59E4", VA = "0x59E4")]
		public PartyCombatService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_PartyCombatService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a559e9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x58);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSkillsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSkillsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x58,iVar2,param1_00);
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


		/* --- GHIDRA: add_SkillsChangedEvent ---
		void ServicesNamespace_PartyCombatService__add_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a559ea = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x58);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSkillsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSkillsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x58,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SkillsChangedEvent ---
		void ServicesNamespace_PartyCombatService__remove_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    DAT_ram_00a559eb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFieldChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFieldChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
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


		/* --- GHIDRA: add_FieldChangedEvent ---
		void ServicesNamespace_PartyCombatService__add_FieldChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    DAT_ram_00a559ec = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFieldChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFieldChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_FieldChangedEvent ---
		void ServicesNamespace_PartyCombatService__remove_FieldChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a559ed = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatCompleteEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: add_CombatCompleteEvent ---
		void ServicesNamespace_PartyCombatService__add_CombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a559ee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatCompleteEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: remove_CombatCompleteEvent ---
		void ServicesNamespace_PartyCombatService__remove_CombatCompleteEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a559ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_ProtoCombatCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_ProtoFieldChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_ProtoSkillsChangedEvt_TypeInfo);
		    DAT_ram_00a559ef = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  if (iVar1 == 4) {
		    UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		              (param1,4,*(undefined4 *)(param2 + 0x20),
		               Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		    iVar1 = *(int *)(param1 + 0x5c);
		    if (iVar1 != 0) {
		      piVar2 = *(int **)(param2 + 0x20);
		      if ((piVar2 != (int *)0x0) && (Protocol_Partycombat_ProtoFieldChangedEvt_TypeInfo != *piVar2))
		      {
		        System_Activator__CreateInstance(piVar2,Protocol_Partycombat_ProtoFieldChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),piVar2,*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  else if (iVar1 == 5) {
		    UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		              (param1,5,*(undefined4 *)(param2 + 0x20),
		               Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		    iVar1 = *(int *)(param1 + 0x58);
		    if (iVar1 != 0) {
		      piVar2 = *(int **)(param2 + 0x20);
		      if ((piVar2 != (int *)0x0) && (Protocol_Partycombat_ProtoSkillsChangedEvt_TypeInfo != *piVar2)
		         ) {
		        System_Activator__CreateInstance(piVar2,Protocol_Partycombat_ProtoSkillsChangedEvt_TypeInfo)
		        ;
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),piVar2,*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  else if ((((((iVar1 == 6) || (iVar1 == 7)) || (iVar1 == 8)) || ((iVar1 == 9 || (iVar1 == 10)))) ||
		           ((iVar1 == 0xb || ((iVar1 == 0xc || (iVar1 == 0xd)))))) ||
		          ((iVar1 == 0xe || (((iVar1 == 0xf || (iVar1 == 0x10)) || (iVar1 != 0x11)))))) {
		    ServicesNamespace_CombatService__get_ServiceId(param1,param2,param2);
		  }
		  else {
		    UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		              (param1,0x11,*(undefined4 *)(param2 + 0x20),
		               Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		    iVar1 = *(int *)(param1 + 0x60);
		    if (iVar1 != 0) {
		      piVar2 = *(int **)(param2 + 0x20);
		      if ((piVar2 != (int *)0x0) &&
		         (Protocol_Partycombat_ProtoCombatCompleteEvt_TypeInfo != *piVar2)) {
		        System_Activator__CreateInstance
		                  (piVar2,Protocol_Partycombat_ProtoCombatCompleteEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),piVar2,*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

}
