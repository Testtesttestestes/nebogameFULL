using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Colossus;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public class ColossusService : AbstractService
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x1700009B")]
		public override short ServiceId
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x58F6", Offset = "0x58F6", VA = "0x58F6", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004A")]
		public event Action<ProtoSlotsChanged> SlotsChangedEvent
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x58F7", Offset = "0x58F7", VA = "0x58F7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x58F8", Offset = "0x58F8", VA = "0x58F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004B")]
		public event Action<ProtoGetColossusInfoAns> ColossusChangedEvent
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x58F9", Offset = "0x58F9", VA = "0x58F9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x58FA", Offset = "0x58FA", VA = "0x58FA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004C")]
		public event Action<ProtoGetScheduleAns> ScheduleChangedEvent
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x58FB", Offset = "0x58FB", VA = "0x58FB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x58FC", Offset = "0x58FC", VA = "0x58FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004D")]
		public event Action<ProtoGetPartyInfoAns> SlotsResetEvent
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x58FD", Offset = "0x58FD", VA = "0x58FD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x58FE", Offset = "0x58FE", VA = "0x58FE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x58FF", Offset = "0x58FF", VA = "0x58FF", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_ColossusService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55926 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusInfoAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55926 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,1,uVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x5900", Offset = "0x5900", VA = "0x5900")]
		public OpToken<IMessage, object> GetColossusInfo()
		{
		/* --- GHIDRA: GetColossusInfo ---
		int * ServicesNamespace_ColossusService__GetColossusInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55927 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetPartyInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55927 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,2,uVar2,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetPartyInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x5901", Offset = "0x5901", VA = "0x5901")]
		public OpToken<IMessage, object> GetPartyInfo()
		{
		/* --- GHIDRA: GetPartyInfo ---
		int * ServicesNamespace_ColossusService__GetPartyInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55928 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetAvailDollsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55928 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,3,uVar2,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetAvailDollsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x5902", Offset = "0x5902", VA = "0x5902")]
		public OpToken<IMessage, object> GetAvailableDolls()
		{
		/* --- GHIDRA: GetAvailableDolls ---
		int * ServicesNamespace_ColossusService__GetAvailableDolls(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55929 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetScheduleAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55929 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,4,uVar2,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetScheduleAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x5903", Offset = "0x5903", VA = "0x5903")]
		public OpToken<IMessage, object> GetSchedule()
		{
		/* --- GHIDRA: GetSchedule ---
		int * ServicesNamespace_ColossusService__GetSchedule
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5592a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusRatingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5592a = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetColossusRatingCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,iVar1,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x5904", Offset = "0x5904", VA = "0x5904")]
		public OpToken<IMessage, object> GetColossusRating(uint colossusId)
		{
		/* --- GHIDRA: GetColossusRating ---
		int * ServicesNamespace_ColossusService__GetColossusRating
		                (int *param1,undefined4 param2,undefined4 param3,undefined8 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5592b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoSwapPartySlotCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5592b = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoSwapPartySlotCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x18) = param4;
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,6,iVar1,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x5905", Offset = "0x5905", VA = "0x5905")]
		public OpToken<IMessage, object> SwapPartySlot(uint partyId, uint slotId, ulong targetId)
		{
		/* --- GHIDRA: SwapPartySlot ---
		int * ServicesNamespace_ColossusService__SwapPartySlot
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5592c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoUserDollSelectCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5592c = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoUserDollSelectCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x5906", Offset = "0x5906", VA = "0x5906")]
		public OpToken<IMessage, object> UserDollSelect(ulong dollId)
		{
		/* --- GHIDRA: UserDollSelect ---
		int * ServicesNamespace_ColossusService__UserDollSelect(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5592d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5592d = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,8,uVar2,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x5907", Offset = "0x5907", VA = "0x5907")]
		public OpToken<IMessage, object> BuyParty()
		{
		/* --- GHIDRA: BuyParty ---
		int * ServicesNamespace_ColossusService__BuyParty(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5592e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoBuyPartySlotCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5592e = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoBuyPartySlotCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,9,iVar1,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSlotsChanged___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x5908", Offset = "0x5908", VA = "0x5908")]
		public OpToken<IMessage, object> BuyPartySlot(uint partyId)
		{
		/* --- GHIDRA: BuyPartySlot ---
		int * ServicesNamespace_ColossusService__BuyPartySlot
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5592f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetDollSlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5592f = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetDollSlotsCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,10,iVar1,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x5909", Offset = "0x5909", VA = "0x5909")]
		public OpToken<IMessage, object> GetDollSlots(ulong dollId, ulong userId)
		{
		/* --- GHIDRA: GetDollSlots ---
		int * ServicesNamespace_ColossusService__GetDollSlots
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55930 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoSwapDollSlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSwapSlotsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55930 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoSwapDollSlotsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x1c) = param4;
		    *(undefined4 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xb,iVar1,0);
		    local_8 = 0xbffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSwapSlotsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x590A", Offset = "0x590A", VA = "0x590A")]
		public OpToken<IMessage, object> SwapDollSlots(ulong dollId, uint fromSlotId, uint toSlotId)
		{
		/* --- GHIDRA: SwapDollSlots ---
		int * ServicesNamespace_ColossusService__SwapDollSlots
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55931 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoDollItemToGolemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55931 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoDollItemToGolemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xc,iVar1,0);
		    local_8 = 0xcffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x590B", Offset = "0x590B", VA = "0x590B")]
		public OpToken<IMessage, object> FromDollToGolem(ulong artifactId, uint toSlotId)
		{
		/* --- GHIDRA: FromDollToGolem ---
		int * ServicesNamespace_ColossusService__FromDollToGolem
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55932 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoDollItemFromGolemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55932 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoDollItemFromGolemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x20) = param4;
		    *(undefined8 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xd,iVar1,0);
		    local_8 = 0xdffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x590C", Offset = "0x590C", VA = "0x590C")]
		public OpToken<IMessage, object> FromGolemToDoll(ulong artifactId, ulong dollId, uint toSlotId)
		{
		/* --- GHIDRA: FromGolemToDoll ---
		int * ServicesNamespace_ColossusService__FromGolemToDoll
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55933 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetDollsSkillsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetDollsSkillsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55933 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetDollsSkillsCmd_TypeInfo);
		    Protocol_Colossus_ProtoGetDollsSkillsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_ulong___Add
		              (*(undefined4 *)(iVar1 + 0x18),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xe,iVar1,0);
		    local_8 = 0xeffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetDollsSkillsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x590D", Offset = "0x590D", VA = "0x590D")]
		public OpToken<IMessage, object> GetDollSkills(ulong userId, params ulong[] dollIds)
		{
		/* --- GHIDRA: GetDollSkills ---
		int * ServicesNamespace_ColossusService__GetDollSkills
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55934 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetTreasuryOptionsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetTreasuryOptionsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55934 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetTreasuryOptionsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xf,iVar1,0);
		    local_8 = 0xfffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetTreasuryOptionsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x590E", Offset = "0x590E", VA = "0x590E")]
		public OpToken<IMessage, object> GetTreasuryOptions(uint colossusId)
		{
		/* --- GHIDRA: GetTreasuryOptions ---
		int * ServicesNamespace_ColossusService__GetTreasuryOptions
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55935 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoBuyTreasuryItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyTreasuryItemAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55935 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoBuyTreasuryItemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x10,iVar1,0);
		    local_8 = 0x10ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyTreasuryItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x590F", Offset = "0x590F", VA = "0x590F")]
		public OpToken<IMessage, object> BuyTreasuryItem(uint optionId)
		{
		/* --- GHIDRA: BuyTreasuryItem ---
		int * ServicesNamespace_ColossusService__BuyTreasuryItem
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55936 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetDollSpellsInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetSchoolInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55936 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetDollSpellsInfoCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x11,iVar1,0);
		    local_8 = 0x11ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetSchoolInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x5910", Offset = "0x5910", VA = "0x5910")]
		public OpToken<IMessage, object> GetDollSpellsInfo(ulong dollId)
		{
		/* --- GHIDRA: GetDollSpellsInfo ---
		int * ServicesNamespace_ColossusService__GetDollSpellsInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55937 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetSeasonRatingAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55937 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x12,uVar2,0);
		    local_8 = 0x12ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetSeasonRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x5911", Offset = "0x5911", VA = "0x5911")]
		public OpToken<IMessage, object> GetSeasonRating()
		{
		/* --- GHIDRA: GetSeasonRating ---
		int * ServicesNamespace_ColossusService__GetSeasonRating(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55938 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetHeroesRatingAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55938 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x13,uVar2,0);
		    local_8 = 0x13ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetHeroesRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x5912", Offset = "0x5912", VA = "0x5912")]
		public OpToken<IMessage, object> GetHeroesRating()
		{
		/* --- GHIDRA: GetHeroesRating ---
		int * ServicesNamespace_ColossusService__GetHeroesRating
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55939 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoTakeOffDollArtsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55939 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoTakeOffDollArtsCmd_TypeInfo);
		    Protocol_Colossus_ProtoTakeOffDollArtsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_ulong___Add
		              (*(undefined4 *)(iVar1 + 0x18),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x14,iVar1,0);
		    local_8 = 0x14ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x5913", Offset = "0x5913", VA = "0x5913")]
		public OpToken<IMessage, object> TakeOffDollArtifacts(ulong ownerId, params ulong[] dollIds)
		{
		/* --- GHIDRA: TakeOffDollArtifacts ---
		int * ServicesNamespace_ColossusService__TakeOffDollArtifacts(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5593a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetDollArtsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5593a = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x15,uVar2,0);
		    local_8 = 0x15ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetDollArtsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x5914", Offset = "0x5914", VA = "0x5914")]
		public OpToken<IMessage, object> GetDollArtifacts()
		{
		/* --- GHIDRA: GetDollArtifacts ---
		int * ServicesNamespace_ColossusService__GetDollArtifacts
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5593b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusBattlesCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusBattlesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5593b = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetColossusBattlesCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0x14) = (undefined1)param4;
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x16,iVar1,0);
		    local_8 = 0x16ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusBattlesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x5915", Offset = "0x5915", VA = "0x5915")]
		public OpToken<IMessage, object> GetColossusBattles(uint pageNumber, uint colossusId, bool clanBattles)
		{
		/* --- GHIDRA: GetColossusBattles ---
		int * ServicesNamespace_ColossusService__GetColossusBattles
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5593c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusBattleInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusBattleInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5593c = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Colossus_ProtoGetColossusBattleInfoCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x17,iVar1,0);
		    local_8 = 0x17ffffffff;
		    local_c = Protocol_Colossus_ColossusCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetColossusBattleInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x5916", Offset = "0x5916", VA = "0x5916")]
		public OpToken<IMessage, object> GetColossusBattleInfo(ulong battleId)
		{
			return null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x5917", Offset = "0x5917", VA = "0x5917")]
		public ColossusService()
		{
		/* --- GHIDRA: .ctor ---
		void ServicesNamespace_ColossusService___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5593d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJumpToCombatEvt__TypeInfo);
		    DAT_ram_00a5593d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoJumpToCombatEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoJumpToCombatEvt__TypeInfo), iVar2 == 0))
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
		void ServicesNamespace_ColossusService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5591d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSlotsChanged__TypeInfo);
		    DAT_ram_00a5591d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSlotsChanged__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSlotsChanged__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_SlotsChangedEvent ---
		void ServicesNamespace_ColossusService__add_SlotsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5591e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSlotsChanged__TypeInfo);
		    DAT_ram_00a5591e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSlotsChanged__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSlotsChanged__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_SlotsChangedEvent ---
		void ServicesNamespace_ColossusService__remove_SlotsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5591f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetColossusInfoAns__TypeInfo);
		    DAT_ram_00a5591f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetColossusInfoAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetColossusInfoAns__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: add_ColossusChangedEvent ---
		void ServicesNamespace_ColossusService__add_ColossusChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55920 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetColossusInfoAns__TypeInfo);
		    DAT_ram_00a55920 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetColossusInfoAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetColossusInfoAns__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: remove_ColossusChangedEvent ---
		void ServicesNamespace_ColossusService__remove_ColossusChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55921 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetScheduleAns__TypeInfo);
		    DAT_ram_00a55921 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetScheduleAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetScheduleAns__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: add_ScheduleChangedEvent ---
		void ServicesNamespace_ColossusService__add_ScheduleChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55922 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetScheduleAns__TypeInfo);
		    DAT_ram_00a55922 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetScheduleAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetScheduleAns__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ScheduleChangedEvent ---
		void ServicesNamespace_ColossusService__remove_ScheduleChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55923 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetPartyInfoAns__TypeInfo);
		    DAT_ram_00a55923 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetPartyInfoAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetPartyInfoAns__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_SlotsResetEvent ---
		void ServicesNamespace_ColossusService__add_SlotsResetEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55924 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetPartyInfoAns__TypeInfo);
		    DAT_ram_00a55924 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetPartyInfoAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetPartyInfoAns__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SlotsResetEvent ---
		void ServicesNamespace_ColossusService__remove_SlotsResetEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a55925 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ColossusEvent___);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetScheduleAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoSlotsChanged_TypeInfo);
		    DAT_ram_00a55925 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ColossusEvent___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Colossus_ProtoSlotsChanged_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoSlotsChanged_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 2) {
		    iVar1 = *(int *)(param1 + 0x18);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo)
		      ;
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 3) {
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Colossus_ProtoGetScheduleAns_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoGetScheduleAns_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 != 4) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo != *param1_00)
		       ) {
		      System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
