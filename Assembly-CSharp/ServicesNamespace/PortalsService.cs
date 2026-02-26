using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Portal;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public class PortalsService : AbstractService
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x170000A8")]
		public override short ServiceId
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x59E5", Offset = "0x59E5", VA = "0x59E5", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008C")]
		public event Action<ProtoPortalStartedEvt> OnProtoPortalStartedEvt
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x59E6", Offset = "0x59E6", VA = "0x59E6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x59E7", Offset = "0x59E7", VA = "0x59E7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008D")]
		public event Action<ProtoPortalDoneEvt> OnProtoPortalDoneEvt
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x59E8", Offset = "0x59E8", VA = "0x59E8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x59E9", Offset = "0x59E9", VA = "0x59E9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008E")]
		public event Action<ProtoPortalStageInfoChangedEvt> OnProtoPortalStageInfoChangedEvt
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x59EA", Offset = "0x59EA", VA = "0x59EA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x59EB", Offset = "0x59EB", VA = "0x59EB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008F")]
		public event Action<ProtoPortalUserBetChangedEvt> OnProtoPortalUserBetChangedEvt
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x59EC", Offset = "0x59EC", VA = "0x59EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x59ED", Offset = "0x59ED", VA = "0x59ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000090")]
		public event Action<ProtoPortalUserInfoChangedEvt> OnProtoPortalUserInfoChangedEvt
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x59EE", Offset = "0x59EE", VA = "0x59EE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x59EF", Offset = "0x59EF", VA = "0x59EF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000091")]
		public event Action<ProtoPortalMonsterInfoChangedEvt> OnProtoPortalMonsterInfoChangedEvt
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x59F0", Offset = "0x59F0", VA = "0x59F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x59F1", Offset = "0x59F1", VA = "0x59F1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x59F2", Offset = "0x59F2", VA = "0x59F2", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_PortalsService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalRegisterCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoPortalRegisterAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559ff = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoPortalRegisterCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,param3,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoPortalRegisterAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x59F3", Offset = "0x59F3", VA = "0x59F3")]
		public OpToken<IMessage, object> RegisterUser()
		{
		/* --- GHIDRA: RegisterUser ---
		int * ServicesNamespace_PortalsService__RegisterUser(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a00 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalSubscribeCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoPortalSubscribeAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a00 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoPortalSubscribeCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,param3,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoPortalSubscribeAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x59F4", Offset = "0x59F4", VA = "0x59F4")]
		public OpToken<IMessage, object> Subscribe()
		{
		/* --- GHIDRA: Subscribe ---
		int * ServicesNamespace_PortalsService__Subscribe(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a01 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalUnSubscribeCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoPortalUnSubscribeAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a01 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoPortalUnSubscribeCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,3,param3,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoPortalUnSubscribeAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x59F5", Offset = "0x59F5", VA = "0x59F5")]
		public OpToken<IMessage, object> Unsubscribe()
		{
		/* --- GHIDRA: Unsubscribe ---
		int * ServicesNamespace_PortalsService__Unsubscribe(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a02 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetPortalInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetPortalInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a02 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetPortalInfoCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,param3,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetPortalInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x59F6", Offset = "0x59F6", VA = "0x59F6")]
		public OpToken<IMessage, object> GetPortalInfo()
		{
		/* --- GHIDRA: GetPortalInfo ---
		int * ServicesNamespace_PortalsService__GetPortalInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a03 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetPortalStageInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetPortalStageInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a03 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetPortalStageInfoCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,param3,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetPortalStageInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x59F7", Offset = "0x59F7", VA = "0x59F7")]
		public OpToken<IMessage, object> GetStageInfo()
		{
		/* --- GHIDRA: GetStageInfo ---
		int * ServicesNamespace_PortalsService__GetStageInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a04 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetPortalMonsterInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetPortalMonsterInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a04 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetPortalMonsterInfoCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,param3,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetPortalMonsterInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x59F8", Offset = "0x59F8", VA = "0x59F8")]
		public OpToken<IMessage, object> GetMonsterInfo()
		{
		/* --- GHIDRA: GetMonsterInfo ---
		int * ServicesNamespace_PortalsService__GetMonsterInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a05 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoComebackToStageCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoComebackToStageAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a05 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoComebackToStageCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xf,param3,0);
		    local_8 = 0xfffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoComebackToStageAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x59F9", Offset = "0x59F9", VA = "0x59F9")]
		public OpToken<IMessage, object> ComebackToStage()
		{
		/* --- GHIDRA: ComebackToStage ---
		int * ServicesNamespace_PortalsService__ComebackToStage
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a06 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetBetListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a06 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Portal_ProtoGetBetListCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,8,iVar1,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetBetListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x59FA", Offset = "0x59FA", VA = "0x59FA")]
		public OpToken<IMessage, object> GetBetList(ulong id = 0UL)
		{
		/* --- GHIDRA: GetBetList ---
		int * ServicesNamespace_PortalsService__GetBetList(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoUpdateBetListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoUpdateBetListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a07 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoUpdateBetListCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,9,param3,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoUpdateBetListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x59FB", Offset = "0x59FB", VA = "0x59FB")]
		public OpToken<IMessage, object> UpdateBetList()
		{
		/* --- GHIDRA: UpdateBetList ---
		int * ServicesNamespace_PortalsService__UpdateBetList
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a08 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoDoBetCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoDoBetCmd_Types_BetChoice__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDoBetAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a08 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Portal_ProtoDoBetCmd_TypeInfo);
		    Protocol_Portal_ProtoDoBetCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_object____ctor
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoDoBetCmd_Types_BetChoice__Add__
		              );
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,10,iVar1,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDoBetAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x59FC", Offset = "0x59FC", VA = "0x59FC")]
		public OpToken<IMessage, object> DoBet(IEnumerable<ProtoDoBetCmd.Types.BetChoice> bet)
		{
		/* --- GHIDRA: DoBet ---
		int * ServicesNamespace_PortalsService__DoBet(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a09 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetsHistoryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetBetsHistoryAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a09 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetBetsHistoryCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xb,param3,0);
		    local_8 = 0xbffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetBetsHistoryAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x59FD", Offset = "0x59FD", VA = "0x59FD")]
		public OpToken<IMessage, object> GetBetsHistory()
		{
		/* --- GHIDRA: GetBetsHistory ---
		int * ServicesNamespace_PortalsService__GetBetsHistory(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a0a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetArtifactItemsInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetArtifactItemsInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a0a = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetArtifactItemsInfoCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x14,param3,0);
		    local_8 = 0x14ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetArtifactItemsInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x59FE", Offset = "0x59FE", VA = "0x59FE")]
		public OpToken<IMessage, object> GetStoreItemsInfo()
		{
		/* --- GHIDRA: GetStoreItemsInfo ---
		int * ServicesNamespace_PortalsService__GetStoreItemsInfo
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a0b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoBuyArtifactItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyArtifactItemAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a0b = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Portal_ProtoBuyArtifactItemCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x20) = param2;
		    *(undefined4 *)(iVar1 + 0x18) = param4;
		    *(undefined8 *)(iVar1 + 0x10) = param3;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x15,iVar1,0);
		    local_8 = 0x15ffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyArtifactItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x59FF", Offset = "0x59FF", VA = "0x59FF")]
		public OpToken<IMessage, object> BuyShopItem(ulong price, ulong artId, uint destSlot)
		{
		/* --- GHIDRA: BuyShopItem ---
		int * ServicesNamespace_PortalsService__BuyShopItem(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a55a0c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoRequestPortalCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoRequestPortalCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a0c = '\x01';
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
		    uVar3 = unnamed_function_1417(Protocol_Portal_ProtoRequestPortalCombatCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,0xc,uVar3,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoRequestPortalCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x5A00", Offset = "0x5A00", VA = "0x5A00")]
		public OpToken<IMessage, object> RequestCombat()
		{
		/* --- GHIDRA: RequestCombat ---
		int * ServicesNamespace_PortalsService__RequestCombat(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a0d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetPoolInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetBetPoolInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a0d = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetBetPoolInfoCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xd,param3,0);
		    local_8 = 0xdffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetBetPoolInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x5A01", Offset = "0x5A01", VA = "0x5A01")]
		public OpToken<IMessage, object> GetBetPoolInfo()
		{
		/* --- GHIDRA: GetBetPoolInfo ---
		int * ServicesNamespace_PortalsService__GetBetPoolInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a0e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetJackpotInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetJackpotInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a0e = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Portal_ProtoGetJackpotInfoCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xe,param3,0);
		    local_8 = 0xeffffffff;
		    local_c = Protocol_Portal_PortalCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetJackpotInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x5A02", Offset = "0x5A02", VA = "0x5A02")]
		public OpToken<IMessage, object> GetJackpotInfo()
		{
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x5A03", Offset = "0x5A03", VA = "0x5A03")]
		public PortalsService()
		{
		/* --- GHIDRA: .ctor ---
		void ServicesNamespace_PortalsService___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a0f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTotalRatingChangedEvt__TypeInfo);
		    DAT_ram_00a55a0f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTotalRatingChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTotalRatingChangedEvt__TypeInfo),
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

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_PortalsService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStartedEvt__TypeInfo);
		    DAT_ram_00a559f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalStartedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_OnProtoPortalStartedEvt ---
		void ServicesNamespace_PortalsService__add_OnProtoPortalStartedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStartedEvt__TypeInfo);
		    DAT_ram_00a559f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalStartedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_OnProtoPortalStartedEvt ---
		void ServicesNamespace_PortalsService__remove_OnProtoPortalStartedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalDoneEvt__TypeInfo);
		    DAT_ram_00a559f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalDoneEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalDoneEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_OnProtoPortalDoneEvt ---
		void ServicesNamespace_PortalsService__add_OnProtoPortalDoneEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalDoneEvt__TypeInfo);
		    DAT_ram_00a559f5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalDoneEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalDoneEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_OnProtoPortalDoneEvt ---
		void ServicesNamespace_PortalsService__remove_OnProtoPortalDoneEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo);
		    DAT_ram_00a559f6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: add_OnProtoPortalStageInfoChangedEvt ---
		void ServicesNamespace_PortalsService__add_OnProtoPortalStageInfoChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo);
		    DAT_ram_00a559f7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_OnProtoPortalStageInfoChangedEvt ---
		void ServicesNamespace_PortalsService__remove_OnProtoPortalStageInfoChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserBetChangedEvt__TypeInfo);
		    DAT_ram_00a559f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalUserBetChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalUserBetChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: add_OnProtoPortalUserBetChangedEvt ---
		void ServicesNamespace_PortalsService__add_OnProtoPortalUserBetChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserBetChangedEvt__TypeInfo);
		    DAT_ram_00a559f9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalUserBetChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalUserBetChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_OnProtoPortalUserBetChangedEvt ---
		void ServicesNamespace_PortalsService__remove_OnProtoPortalUserBetChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo);
		    DAT_ram_00a559fa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnProtoPortalUserInfoChangedEvt ---
		void ServicesNamespace_PortalsService__add_OnProtoPortalUserInfoChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo);
		    DAT_ram_00a559fb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnProtoPortalUserInfoChangedEvt ---
		void ServicesNamespace_PortalsService__remove_OnProtoPortalUserInfoChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo);
		    DAT_ram_00a559fc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnProtoPortalMonsterInfoChangedEvt ---
		void ServicesNamespace_PortalsService__add_OnProtoPortalMonsterInfoChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo);
		    DAT_ram_00a559fd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnProtoPortalMonsterInfoChangedEvt ---
		void ServicesNamespace_PortalsService__remove_OnProtoPortalMonsterInfoChangedEvt
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a559fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_PortalEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalDoneEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalMonsterInfoChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalStageInfoChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalStartedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalUserBetChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalUserInfoChangedEvt_TypeInfo);
		    DAT_ram_00a559fe = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_PortalEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoPortalStartedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoPortalStartedEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoPortalDoneEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoPortalDoneEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Portal_ProtoPortalStageInfoChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Portal_ProtoPortalStageInfoChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 4) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Portal_ProtoPortalUserBetChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Portal_ProtoPortalUserBetChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 5) {
		    iVar1 = *(int *)(param1 + 0x24);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Portal_ProtoPortalUserInfoChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Portal_ProtoPortalUserInfoChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 != 6) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x28);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Portal_ProtoPortalMonsterInfoChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Portal_ProtoPortalMonsterInfoChangedEvt_TypeInfo);
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
