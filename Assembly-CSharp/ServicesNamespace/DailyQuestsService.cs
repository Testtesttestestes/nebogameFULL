using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.DailyQuests;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class DailyQuestsService : AbstractService
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x1700009F")]
		public override short ServiceId
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x5961", Offset = "0x5961", VA = "0x5961", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000064")]
		public event Action<ProtoDailyQuestsChangedEvt> DailyQuestsChangedEvent
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x5962", Offset = "0x5962", VA = "0x5962")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x5963", Offset = "0x5963", VA = "0x5963")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x5964", Offset = "0x5964", VA = "0x5964", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		undefined4
		ServicesNamespace_DailyQuestsService__ServerEventHandler
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55983 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_DailyQuestsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoGetQuestsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetQuestsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55983 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = Core_Net_AbstractService__PushCommand
		                        (param1,*(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0
		                        );
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = unnamed_function_1417(Protocol_DailyQuests_ProtoGetQuestsCmd_TypeInfo);
		    Protocol_DailyQuests_ProtoGetQuestsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0x10),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,iVar1,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_DailyQuests_DailyQuestsCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetQuestsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x5965", Offset = "0x5965", VA = "0x5965")]
		public OpToken<IMessage, object> GetQuests(ProtoGetQuestsCmd.Types.Kind kind, IEnumerable<uint> ids)
		{
		/* --- GHIDRA: GetQuests ---
		undefined4
		ServicesNamespace_DailyQuestsService__GetQuests(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55985 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_DailyQuestsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoTakeDailyQuestRewardCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55985 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = Core_Net_AbstractService__PushCommand
		                        (param1,*(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0
		                        );
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = unnamed_function_1417(Protocol_DailyQuests_ProtoTakeDailyQuestRewardCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_DailyQuests_DailyQuestsCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		/* --- GHIDRA: GetQuests ---
		undefined4
		ServicesNamespace_DailyQuestsService__GetQuests(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55985 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_DailyQuestsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoTakeDailyQuestRewardCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55985 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = Core_Net_AbstractService__PushCommand
		                        (param1,*(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0
		                        );
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = unnamed_function_1417(Protocol_DailyQuests_ProtoTakeDailyQuestRewardCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_DailyQuests_DailyQuestsCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x5966", Offset = "0x5966", VA = "0x5966")]
		public OpToken<IMessage, object> GetQuests(ProtoGetQuestsCmd.Types.Kind kind)
		{
			return null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x5967", Offset = "0x5967", VA = "0x5967")]
		public OpToken<IMessage, object> TakeDailyQuestReward(uint questId)
		{
		/* --- GHIDRA: TakeDailyQuestReward ---
		undefined4
		ServicesNamespace_DailyQuestsService__TakeDailyQuestReward
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55986 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_DailyQuestsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoTakeGoalRewardCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55986 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = Core_Net_AbstractService__PushCommand
		                        (param1,*(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0
		                        );
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = unnamed_function_1417(Protocol_DailyQuests_ProtoTakeGoalRewardCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,iVar1,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_DailyQuests_DailyQuestsCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x5968", Offset = "0x5968", VA = "0x5968")]
		public OpToken<IMessage, object> TakeGoalReward(uint goalId)
		{
			return null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x5969", Offset = "0x5969", VA = "0x5969")]
		public DailyQuestsService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_DailyQuestsService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55980 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDailyQuestsChangedEvt__TypeInfo);
		    DAT_ram_00a55980 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoDailyQuestsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoDailyQuestsChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_DailyQuestsChangedEvent ---
		void ServicesNamespace_DailyQuestsService__add_DailyQuestsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55981 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDailyQuestsChangedEvt__TypeInfo);
		    DAT_ram_00a55981 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoDailyQuestsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoDailyQuestsChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_DailyQuestsChangedEvent ---
		void ServicesNamespace_DailyQuestsService__remove_DailyQuestsChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a55982 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_DailyQuestsEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_ProtoDailyQuestsChangedEvt_TypeInfo);
		    DAT_ram_00a55982 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar3,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_DailyQuestsEvents___);
		  if (iVar3 == 1) {
		    iVar3 = *(int *)(param1 + 0x14);
		    if (iVar3 != 0) {
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_DailyQuests_ProtoDailyQuestsChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_DailyQuests_ProtoDailyQuestsChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		    }
		    return;
		  }
		  local_4 = iVar3;
		  uVar1 = unnamed_function_2232(&Protocol_DailyQuests_DailyQuestsEvents_TypeInfo);
		  uVar1 = func_ii_1081(uVar1,&local_4);
		  uVar2 = unnamed_function_2232(&StringLiteral_28613);
		  param2_00 = unnamed_function_2232(&StringLiteral_6259);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar2,param2_00,uVar1,0);
		  uVar2 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  func_ii_6353(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232(&Method_ServicesNamespace_DailyQuestsService_ServerEventHandler__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
