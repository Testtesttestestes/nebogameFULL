using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public class ClanIsleService : AbstractService
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x17000097")]
		public override short ServiceId
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x5893", Offset = "0x5893", VA = "0x5893", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000036")]
		public event Action<ProtoBuildingAcceleratedEvt> BuildingAcceleratedEvent
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x5894", Offset = "0x5894", VA = "0x5894")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x5895", Offset = "0x5895", VA = "0x5895")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000037")]
		public event Action<ProtoBuildingFinishedEvt> BuildingFinishedEvent
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x5896", Offset = "0x5896", VA = "0x5896")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x5897", Offset = "0x5897", VA = "0x5897")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000038")]
		public event Action<ProtoBuildingStartedEvt> BuildingStartedEvent
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x5898", Offset = "0x5898", VA = "0x5898")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x5899", Offset = "0x5899", VA = "0x5899")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000039")]
		public event Action<ProtoBuildingCanceledEvt> BuildingCanceledEvent
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x589A", Offset = "0x589A", VA = "0x589A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x589B", Offset = "0x589B", VA = "0x589B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003A")]
		public event Action<ProtoGolemStateChangedEvt> GolemStateChangedEvent
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x589C", Offset = "0x589C", VA = "0x589C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x589D", Offset = "0x589D", VA = "0x589D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003B")]
		public event Action<ProtoClanRemovedEvt> ClanRemovedEvent
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x589E", Offset = "0x589E", VA = "0x589E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x589F", Offset = "0x589F", VA = "0x589F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x58A0", Offset = "0x58A0", VA = "0x58A0", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_ClanIsleService__ServerEventHandler
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  local_c = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGetIsleInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetIsleInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a628ff = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanIsle_ProtoGetIsleInfoCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,1,iVar2,0);
		    param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		    local_14 = 0x1ffffffff;
		    local_18 = Protocol_ClanIsle_ClanIsleCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    *(undefined4 *)(param1_00 + 0x10) = uVar3;
		    *(undefined4 *)(param1_00 + 0x14) = StringLiteral_118;
		    uVar3 = func_ii_8783(&local_8,0);
		    *(undefined4 *)(param1_00 + 0x18) = uVar3;
		    *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_118;
		    uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x20) = uVar3;
		    uVar3 = System_Single__ToString(param1_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetIsleInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x58A1", Offset = "0x58A1", VA = "0x58A1")]
		public OpToken<IMessage, object> GetClanIsleInfo(ulong clanId, uint flags)
		{
		/* --- GHIDRA: GetClanIsleInfo ---
		int * ServicesNamespace_ClanIsleService__GetClanIsleInfo
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62900 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanBuildingTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoStartBuildingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoStartBuildingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a62900 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanIsle_ProtoStartBuildingCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,2,iVar2,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_ClanIsle_ClanIsleCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Consts_ClanBuildingTypes_TypeInfo;
		    local_10 = param2;
		    param3_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar3,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoStartBuildingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x58A2", Offset = "0x58A2", VA = "0x58A2")]
		public OpToken<IMessage, object> StartClanBuild(ClanBuildingTypes typeId)
		{
		/* --- GHIDRA: StartClanBuild ---
		int * ServicesNamespace_ClanIsleService__StartClanBuild
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62901 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanBuildingTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoAccelerateBuildingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoAccelerateBuildingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a62901 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanIsle_ProtoAccelerateBuildingCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,3,iVar2,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_ClanIsle_ClanIsleCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Consts_ClanBuildingTypes_TypeInfo;
		    local_10 = param2;
		    param3_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar3,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoAccelerateBuildingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x58A3", Offset = "0x58A3", VA = "0x58A3")]
		public OpToken<IMessage, object> AccelerateClanBuilding(ClanBuildingTypes typeId)
		{
		/* --- GHIDRA: AccelerateClanBuilding ---
		int * ServicesNamespace_ClanIsleService__AccelerateClanBuilding
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62902 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanBuildingTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoCancelBuildingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a62902 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanIsle_ProtoCancelBuildingCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,4,iVar2,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_ClanIsle_ClanIsleCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Consts_ClanBuildingTypes_TypeInfo;
		    local_10 = param2;
		    param3_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar3,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x58A4", Offset = "0x58A4", VA = "0x58A4")]
		public OpToken<IMessage, object> CancelClanBuilding(ClanBuildingTypes typeId)
		{
		/* --- GHIDRA: CancelClanBuilding ---
		int * ServicesNamespace_ClanIsleService__CancelClanBuilding
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a62903 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoKickFromIsleCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoKickFromIsleAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a62903 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanIsle_ProtoKickFromIsleCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,5,iVar2,0);
		    local_10 = 0x5ffffffff;
		    local_14 = Protocol_ClanIsle_ClanIsleCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param3_00 = func_ii_8783(&local_8,0);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar3,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoKickFromIsleAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x58A5", Offset = "0x58A5", VA = "0x58A5")]
		public OpToken<IMessage, object> KickFromIsle(ulong userId)
		{
			return null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x58A6", Offset = "0x58A6", VA = "0x58A6")]
		public ClanIsleService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_ClanIsleService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    DAT_ram_00a628f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingAcceleratedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingAcceleratedEvt__TypeInfo),
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


		/* --- GHIDRA: add_BuildingAcceleratedEvent ---
		void ServicesNamespace_ClanIsleService__add_BuildingAcceleratedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    DAT_ram_00a628f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingAcceleratedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingAcceleratedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_BuildingAcceleratedEvent ---
		void ServicesNamespace_ClanIsleService__remove_BuildingAcceleratedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    DAT_ram_00a628f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingFinishedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: add_BuildingFinishedEvent ---
		void ServicesNamespace_ClanIsleService__add_BuildingFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    DAT_ram_00a628f5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingFinishedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: remove_BuildingFinishedEvent ---
		void ServicesNamespace_ClanIsleService__remove_BuildingFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    DAT_ram_00a628f6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingStartedEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: add_BuildingStartedEvent ---
		void ServicesNamespace_ClanIsleService__add_BuildingStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    DAT_ram_00a628f7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingStartedEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: remove_BuildingStartedEvent ---
		void ServicesNamespace_ClanIsleService__remove_BuildingStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    DAT_ram_00a628f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingCanceledEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: add_BuildingCanceledEvent ---
		void ServicesNamespace_ClanIsleService__add_BuildingCanceledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    DAT_ram_00a628f9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingCanceledEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: remove_BuildingCanceledEvent ---
		void ServicesNamespace_ClanIsleService__remove_BuildingCanceledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGolemStateChangedEvt__TypeInfo);
		    DAT_ram_00a628fa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGolemStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGolemStateChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_GolemStateChangedEvent ---
		void ServicesNamespace_ClanIsleService__add_GolemStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGolemStateChangedEvt__TypeInfo);
		    DAT_ram_00a628fb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGolemStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGolemStateChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_GolemStateChangedEvent ---
		void ServicesNamespace_ClanIsleService__remove_GolemStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanRemovedEvt__TypeInfo);
		    DAT_ram_00a628fc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanRemovedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_ClanRemovedEvent ---
		void ServicesNamespace_ClanIsleService__add_ClanRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanRemovedEvt__TypeInfo);
		    DAT_ram_00a628fd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanRemovedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_ClanRemovedEvent ---
		void ServicesNamespace_ClanIsleService__remove_ClanRemovedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a628fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ClanIsleEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoBuildingAcceleratedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoBuildingCanceledEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoBuildingFinishedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoBuildingStartedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoClanRemovedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGolemStateChangedEvt_TypeInfo);
		    DAT_ram_00a628fe = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ClanIsleEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_ClanIsle_ProtoBuildingAcceleratedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_ClanIsle_ProtoBuildingAcceleratedEvt_TypeInfo);
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
		       (Protocol_ClanIsle_ProtoBuildingFinishedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_ClanIsle_ProtoBuildingFinishedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 3) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_ClanIsle_ProtoBuildingCanceledEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_ClanIsle_ProtoBuildingCanceledEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 4) {
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_ClanIsle_ProtoBuildingStartedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_ClanIsle_ProtoBuildingStartedEvt_TypeInfo)
		      ;
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
		       (Protocol_ClanIsle_ProtoGolemStateChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_ClanIsle_ProtoGolemStateChangedEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_ClanIsle_ProtoClanRemovedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_ClanIsle_ProtoClanRemovedEvt_TypeInfo);
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
