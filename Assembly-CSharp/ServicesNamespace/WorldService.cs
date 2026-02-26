using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.World;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public class WorldService : AbstractService
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x170000B5")]
		public override short ServiceId
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x5AC3", Offset = "0x5AC3", VA = "0x5AC3", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B3")]
		public event Action<ProtoBuildingAcceleratedEvt> BuildingAcceleratedEvent
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x5AC4", Offset = "0x5AC4", VA = "0x5AC4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x5AC5", Offset = "0x5AC5", VA = "0x5AC5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B4")]
		public event Action<ProtoBuildingFinishedEvt> BuildingFinishedEvent
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x5AC6", Offset = "0x5AC6", VA = "0x5AC6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x5AC7", Offset = "0x5AC7", VA = "0x5AC7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B5")]
		public event Action<ProtoBuildingCanceledEvt> BuildingCanceledEvent
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x5AC8", Offset = "0x5AC8", VA = "0x5AC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x5AC9", Offset = "0x5AC9", VA = "0x5AC9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B6")]
		public event Action<ProtoBuildingStartedEvt> BuildingStartedEvent
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x5ACA", Offset = "0x5ACA", VA = "0x5ACA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x5ACB", Offset = "0x5ACB", VA = "0x5ACB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B7")]
		public event Action<ProtoGoHomeEvt> GoHomeEvent
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x5ACC", Offset = "0x5ACC", VA = "0x5ACC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x5ACD", Offset = "0x5ACD", VA = "0x5ACD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B8")]
		public event Action<ProtoUserAprChangedEvt> UserAprChangedEvent
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x5ACE", Offset = "0x5ACE", VA = "0x5ACE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x5ACF", Offset = "0x5ACF", VA = "0x5ACF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B9")]
		public event Action<ProtoAnimationStartedEvt> AnimationStartedEvent
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x5AD0", Offset = "0x5AD0", VA = "0x5AD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x5AD1", Offset = "0x5AD1", VA = "0x5AD1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BA")]
		public event Action<ProtoIsleMonsterInfoChangedEvt> IsleMonsterInfoChangedEvent
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x5AD2", Offset = "0x5AD2", VA = "0x5AD2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x5AD3", Offset = "0x5AD3", VA = "0x5AD3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BB")]
		public event Action<ProtoUserIsleBuildingViewChangedEvt> UserIsleBuildingViewChangedEvent
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5AD4", Offset = "0x5AD4", VA = "0x5AD4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x5AD5", Offset = "0x5AD5", VA = "0x5AD5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BC")]
		public event Action<ProtoUserIsleDecorationAddedEvt> UserIsleDecorationAddedEvent
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x5AD6", Offset = "0x5AD6", VA = "0x5AD6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x5AD7", Offset = "0x5AD7", VA = "0x5AD7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006DC RID: 1756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BD")]
		public event Action<ProtoUserIsleDecorationRemovedEvt> UserIsleDecorationRemovedEvent
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x5AD8", Offset = "0x5AD8", VA = "0x5AD8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x5AD9", Offset = "0x5AD9", VA = "0x5AD9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BE")]
		public event Action<ProtoIsleMonsterFlewAwayEvt> IsleMonsterFlewAwayEvent
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x5ADA", Offset = "0x5ADA", VA = "0x5ADA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x5ADB", Offset = "0x5ADB", VA = "0x5ADB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x5ADC", Offset = "0x5ADC", VA = "0x5ADC", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_WorldService__ServerEventHandler
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param4_00;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a5b7fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetUserIsleInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_World_ProtoGetUserIsleInfoCmd_Types_RequestedTypeInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserIsleInfoAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17963);
		    DAT_ram_00a5b7fa = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoGetUserIsleInfoCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    uVar2 = func_ii_8783(&local_8,0);
		    local_10 = 0xffffffff;
		    local_14 = Protocol_World_ProtoGetUserIsleInfoCmd_Types_RequestedTypeInfo_TypeInfo;
		    local_c = param3;
		    param4_00 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    uVar2 = System_Int32__ToString(StringLiteral_17963,uVar2,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserIsleInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x5ADD", Offset = "0x5ADD", VA = "0x5ADD")]
		public OpToken<IMessage, object> GetUserIsleInfo(ulong userId, ProtoGetUserIsleInfoCmd.Types.RequestedTypeInfo flag)
		{
		/* --- GHIDRA: GetUserIsleInfo ---
		int * ServicesNamespace_WorldService__GetUserIsleInfo
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoAttackMonsterCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRequestCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17961);
		    DAT_ram_00a5b7fb = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoAttackMonsterCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xd,iVar1,0);
		    local_8 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_17961,uVar2,0);
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

			return null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5ADE", Offset = "0x5ADE", VA = "0x5ADE")]
		public OpToken<IMessage, object> AttackMonster(ulong ownerId)
		{
		/* --- GHIDRA: AttackMonster ---
		int * ServicesNamespace_WorldService__AttackMonster
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  local_c = param3;
		  local_8 = param2;
		  if (DAT_ram_00a5b7fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoKickMonsterCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoKickMonsterAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a5b7fc = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoKickMonsterCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xc,iVar1,0);
		    param1_01 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		    local_14 = 0xcffffffff;
		    local_18 = Protocol_World_WorldCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    *(undefined4 *)(param1_01 + 0x10) = uVar2;
		    *(undefined4 *)(param1_01 + 0x14) = StringLiteral_118;
		    uVar2 = func_ii_8783(&local_8,0);
		    *(undefined4 *)(param1_01 + 0x18) = uVar2;
		    *(undefined4 *)(param1_01 + 0x1c) = StringLiteral_118;
		    uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x20) = uVar2;
		    uVar2 = System_Single__ToString(param1_01,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoKickMonsterAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5ADF", Offset = "0x5ADF", VA = "0x5ADF")]
		public OpToken<IMessage, object> KickMonster(ulong ownerId, uint monsterId)
		{
		/* --- GHIDRA: KickMonster ---
		int * ServicesNamespace_WorldService__KickMonster(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetMonsterInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetMonsterInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17964);
		    DAT_ram_00a5b7fd = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoGetMonsterInfoCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,10,iVar1,0);
		    local_8 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_17964,uVar2,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetMonsterInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x5AE0", Offset = "0x5AE0", VA = "0x5AE0")]
		public OpToken<IMessage, object> GetMonsterInfo(ulong ownerId)
		{
		/* --- GHIDRA: GetMonsterInfo ---
		int * ServicesNamespace_WorldService__GetMonsterInfo
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b7fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoStartBuildingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoStartBuildingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17965);
		    DAT_ram_00a5b7fe = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoStartBuildingCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    local_4 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_17965,uVar2,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStartBuildingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5AE1", Offset = "0x5AE1", VA = "0x5AE1")]
		public OpToken<IMessage, object> StartBuilding(uint buildingType)
		{
		/* --- GHIDRA: StartBuilding ---
		int * ServicesNamespace_WorldService__StartBuilding
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b7ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoAccelerateBuildingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoAccelerateBuildingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17960);
		    DAT_ram_00a5b7ff = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoAccelerateBuildingCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,8,iVar1,0);
		    local_4 = param3;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    local_10 = param2;
		    param3_00 = func_ii_1081(DAT_ram_00a66968,&local_10);
		    uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_17960,uVar2,param3_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoAccelerateBuildingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x5AE2", Offset = "0x5AE2", VA = "0x5AE2")]
		public OpToken<IMessage, object> AccelerateBuilding(ulong ownerId, uint buildingType)
		{
		/* --- GHIDRA: AccelerateBuilding ---
		int * ServicesNamespace_WorldService__AccelerateBuilding
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b800 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoCancelBuildingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17962);
		    DAT_ram_00a5b800 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoCancelBuildingCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,9,iVar1,0);
		    local_4 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_17962,uVar2,0);
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

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x5AE3", Offset = "0x5AE3", VA = "0x5AE3")]
		public OpToken<IMessage, object> CancelBuilding(uint buildingType)
		{
		/* --- GHIDRA: CancelBuilding ---
		int * ServicesNamespace_WorldService__CancelBuilding(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b801 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetAnimationInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetAnimationsInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a5b801 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_World_ProtoGetAnimationInfoCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x10,uVar2,0);
		    local_8 = 0x10ffffffff;
		    local_c = Protocol_World_WorldCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetAnimationsInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5AE4", Offset = "0x5AE4", VA = "0x5AE4")]
		public OpToken<IMessage, object> GetAnimationsInfo()
		{
		/* --- GHIDRA: GetAnimationsInfo ---
		int * ServicesNamespace_WorldService__GetAnimationsInfo
		                (int *param1,undefined4 param2,undefined8 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b802 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoStartAnimationCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoStartAnimationAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a5b802 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoStartAnimationCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x1c) = param4;
		    *(undefined8 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0x18) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xf,iVar1,0);
		    local_8 = 0x10ffffffff;
		    local_c = Protocol_World_WorldCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStartAnimationAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x5AE5", Offset = "0x5AE5", VA = "0x5AE5")]
		public OpToken<IMessage, object> StartAnimation(uint animationId, ulong ownerId, uint launchesAtTime)
		{
		/* --- GHIDRA: StartAnimation ---
		int * ServicesNamespace_WorldService__StartAnimation
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b803 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoKickFromIsleCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a5b803 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoKickFromIsleCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xe,iVar1,0);
		    local_8 = 0xeffffffff;
		    local_c = Protocol_World_WorldCommands_TypeInfo;
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

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x5AE6", Offset = "0x5AE6", VA = "0x5AE6")]
		public OpToken<IMessage, object> KickFromIsle(ulong userId)
		{
		/* --- GHIDRA: KickFromIsle ---
		int * ServicesNamespace_WorldService__KickFromIsle(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b804 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetHordeInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetHordeInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a5b804 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoGetHordeInfoCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0xc) = (undefined1)param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x11,iVar1,0);
		    local_8 = 0x11ffffffff;
		    local_c = Protocol_World_WorldCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetHordeInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x5AE7", Offset = "0x5AE7", VA = "0x5AE7")]
		public OpToken<IMessage, object> GetHordeInfo(bool isCave)
		{
		/* --- GHIDRA: GetHordeInfo ---
		int * ServicesNamespace_WorldService__GetHordeInfo(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b805 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoExitHordeCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    DAT_ram_00a5b805 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_World_ProtoExitHordeCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0xc) = (undefined1)param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x12,iVar1,0);
		    local_8 = 0x12ffffffff;
		    local_c = Protocol_World_WorldCommands_TypeInfo;
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

		// Token: 0x060006EB RID: 1771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x5AE8", Offset = "0x5AE8", VA = "0x5AE8")]
		public OpToken<IMessage, object> ExitHorde(bool isCave)
		{
		/* --- GHIDRA: ExitHorde ---
		void ServicesNamespace_WorldService__ExitHorde(undefined4 param1,undefined4 param2)
		
		{
		  Core_Net_AbstractService__ServerEventHandler(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x5AE9", Offset = "0x5AE9", VA = "0x5AE9")]
		public WorldService()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 ServicesNamespace_WorldService___ctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a5b806 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b806 = '\x01';
		  }
		  return **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_WorldService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    DAT_ram_00a5b7e1 = '\x01';
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
		void ServicesNamespace_WorldService__add_BuildingAcceleratedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    DAT_ram_00a5b7e2 = '\x01';
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
		void ServicesNamespace_WorldService__remove_BuildingAcceleratedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    DAT_ram_00a5b7e3 = '\x01';
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
		void ServicesNamespace_WorldService__add_BuildingFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    DAT_ram_00a5b7e4 = '\x01';
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
		void ServicesNamespace_WorldService__remove_BuildingFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    DAT_ram_00a5b7e5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingCanceledEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: add_BuildingCanceledEvent ---
		void ServicesNamespace_WorldService__add_BuildingCanceledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    DAT_ram_00a5b7e6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingCanceledEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: remove_BuildingCanceledEvent ---
		void ServicesNamespace_WorldService__remove_BuildingCanceledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    DAT_ram_00a5b7e7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingStartedEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: add_BuildingStartedEvent ---
		void ServicesNamespace_WorldService__add_BuildingStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    DAT_ram_00a5b7e8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBuildingStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBuildingStartedEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: remove_BuildingStartedEvent ---
		void ServicesNamespace_WorldService__remove_BuildingStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGoHomeEvt__TypeInfo);
		    DAT_ram_00a5b7e9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGoHomeEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGoHomeEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_GoHomeEvent ---
		void ServicesNamespace_WorldService__add_GoHomeEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGoHomeEvt__TypeInfo);
		    DAT_ram_00a5b7ea = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGoHomeEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGoHomeEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_GoHomeEvent ---
		void ServicesNamespace_WorldService__remove_GoHomeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserAprChangedEvt__TypeInfo);
		    DAT_ram_00a5b7eb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserAprChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserAprChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_UserAprChangedEvent ---
		void ServicesNamespace_WorldService__add_UserAprChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserAprChangedEvt__TypeInfo);
		    DAT_ram_00a5b7ec = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserAprChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserAprChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_UserAprChangedEvent ---
		void ServicesNamespace_WorldService__remove_UserAprChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAnimationStartedEvt__TypeInfo);
		    DAT_ram_00a5b7ed = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAnimationStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAnimationStartedEvt__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: add_AnimationStartedEvent ---
		void ServicesNamespace_WorldService__add_AnimationStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAnimationStartedEvt__TypeInfo);
		    DAT_ram_00a5b7ee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAnimationStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAnimationStartedEvt__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_AnimationStartedEvent ---
		void ServicesNamespace_WorldService__remove_AnimationStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo);
		    DAT_ram_00a5b7ef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: add_IsleMonsterInfoChangedEvent ---
		void ServicesNamespace_WorldService__add_IsleMonsterInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo);
		    DAT_ram_00a5b7f0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_IsleMonsterInfoChangedEvent ---
		void ServicesNamespace_WorldService__remove_IsleMonsterInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo);
		    DAT_ram_00a5b7f1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: add_UserIsleBuildingViewChangedEvent ---
		void ServicesNamespace_WorldService__add_UserIsleBuildingViewChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo);
		    DAT_ram_00a5b7f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserIsleBuildingViewChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UserIsleBuildingViewChangedEvent ---
		void ServicesNamespace_WorldService__remove_UserIsleBuildingViewChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo);
		    DAT_ram_00a5b7f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: add_UserIsleDecorationAddedEvent ---
		void ServicesNamespace_WorldService__add_UserIsleDecorationAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo);
		    DAT_ram_00a5b7f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserIsleDecorationAddedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UserIsleDecorationAddedEvent ---
		void ServicesNamespace_WorldService__remove_UserIsleDecorationAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo);
		    DAT_ram_00a5b7f5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: add_UserIsleDecorationRemovedEvent ---
		void ServicesNamespace_WorldService__add_UserIsleDecorationRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo);
		    DAT_ram_00a5b7f6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserIsleDecorationRemovedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UserIsleDecorationRemovedEvent ---
		void ServicesNamespace_WorldService__remove_UserIsleDecorationRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		    DAT_ram_00a5b7f7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: add_IsleMonsterFlewAwayEvent ---
		void ServicesNamespace_WorldService__add_IsleMonsterFlewAwayEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		    DAT_ram_00a5b7f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: remove_IsleMonsterFlewAwayEvent ---
		void ServicesNamespace_WorldService__remove_IsleMonsterFlewAwayEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5b7f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_WorldEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoAnimationStartedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoBuildingAcceleratedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoBuildingCanceledEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoBuildingFinishedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoBuildingStartedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGoHomeEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoIsleMonsterFlewAwayEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoIsleMonsterInfoChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoUserAprChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoUserIsleBuildingViewChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoUserIsleDecorationAddedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoUserIsleDecorationRemovedEvt_TypeInfo);
		    DAT_ram_00a5b7f9 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_WorldEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoBuildingAcceleratedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_World_ProtoBuildingAcceleratedEvt_TypeInfo);
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
		       (Protocol_World_ProtoBuildingFinishedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_World_ProtoBuildingFinishedEvt_TypeInfo);
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
		       (Protocol_World_ProtoBuildingCanceledEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_World_ProtoBuildingCanceledEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_World_ProtoBuildingStartedEvt_TypeInfo != *param1_00)
		       ) {
		      System_Activator__CreateInstance(param1_00,Protocol_World_ProtoBuildingStartedEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_World_ProtoGoHomeEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_World_ProtoGoHomeEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 6) {
		    iVar1 = *(int *)(param1 + 0x28);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_World_ProtoUserAprChangedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_World_ProtoUserAprChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 7) {
		    iVar1 = *(int *)(param1 + 0x2c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoAnimationStartedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_World_ProtoAnimationStartedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 8) {
		    iVar1 = *(int *)(param1 + 0x30);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoIsleMonsterInfoChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_World_ProtoIsleMonsterInfoChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 9) {
		    iVar1 = *(int *)(param1 + 0x34);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoUserIsleBuildingViewChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_World_ProtoUserIsleBuildingViewChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 10) {
		    iVar1 = *(int *)(param1 + 0x38);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoUserIsleDecorationAddedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_World_ProtoUserIsleDecorationAddedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 0xb) {
		    iVar1 = *(int *)(param1 + 0x3c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoUserIsleDecorationRemovedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_World_ProtoUserIsleDecorationRemovedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 != 0xc) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x40);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_World_ProtoIsleMonsterFlewAwayEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_World_ProtoIsleMonsterFlewAwayEvt_TypeInfo);
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
