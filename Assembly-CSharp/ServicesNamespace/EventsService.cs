using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Events;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public class EventsService : AbstractService
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x170000A1")]
		public override short ServiceId
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x597A", Offset = "0x597A", VA = "0x597A", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x597B", Offset = "0x597B", VA = "0x597B", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_EventsService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55996 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventsListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a55996 = '\x01';
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
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,1,0,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Events_EventsCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventsListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x597C", Offset = "0x597C", VA = "0x597C")]
		public OpToken<IMessage, object> GetEventsList()
		{
		/* --- GHIDRA: GetEventsList ---
		int * ServicesNamespace_EventsService__GetEventsList
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55997 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoDeleteEventsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a55997 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Events_ProtoDeleteEventsCmd_TypeInfo);
		    Protocol_Events_ProtoDeleteEventsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_ulong___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Events_EventsCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x597D", Offset = "0x597D", VA = "0x597D")]
		public OpToken<IMessage, object> DeleteEvents(ulong[] eventsIds)
		{
		/* --- GHIDRA: DeleteEvents ---
		int * ServicesNamespace_EventsService__DeleteEvents(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a55998 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoGetEventRewardCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventRewardAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a55998 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Events_ProtoGetEventRewardCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,3,iVar1,0);
		    local_10 = 0x3ffffffff;
		    local_14 = Protocol_Events_EventsCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param3_00 = func_ii_8783(&local_8,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventRewardAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x597E", Offset = "0x597E", VA = "0x597E")]
		public OpToken<IMessage, object> GetEventReward(ulong eventId)
		{
		/* --- GHIDRA: GetEventReward ---
		int * ServicesNamespace_EventsService__GetEventReward
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a55999 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoProcessEventCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoProcessEventAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a55999 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Events_ProtoProcessEventCmd_TypeInfo);
		    Protocol_Events_ProtoProcessEventCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_uint____ctor
		              (*(undefined4 *)(iVar1 + 0x18),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,iVar1,0);
		    local_10 = 0x4ffffffff;
		    local_14 = Protocol_Events_EventsCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param3_00 = func_ii_8783(&local_8,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoProcessEventAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x597F", Offset = "0x597F", VA = "0x597F")]
		public OpToken<IMessage, object> ProcessEvent(ulong eventId, uint[] actions)
		{
		/* --- GHIDRA: ProcessEvent ---
		int * ServicesNamespace_EventsService__ProcessEvent(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  int param1_02;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5599a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoClearArchiveCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5599a = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Events_ProtoClearArchiveCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_02 = Core_Net_SrvCommand___ctor(param1_01,5,uVar2,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Events_EventsCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_02 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_02,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_02,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5980", Offset = "0x5980", VA = "0x5980")]
		public OpToken<IMessage, object> ClearArchive()
		{
			return null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x5981", Offset = "0x5981", VA = "0x5981")]
		public OpToken<IMessage, object> ShareReward()
		{
			return null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x5982", Offset = "0x5982", VA = "0x5982")]
		public EventsService()
		{
		}

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x14")]
		public Action<ProtoGetEventsListAns> ThereIsNewEvent;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_EventsService__get_ServiceId(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a55995 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_EventsEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoGetEventsListAns_TypeInfo);
		    DAT_ram_00a55995 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_EventsEvents___);
		  if ((iVar1 == 1) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Events_ProtoGetEventsListAns_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Events_ProtoGetEventsListAns_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
