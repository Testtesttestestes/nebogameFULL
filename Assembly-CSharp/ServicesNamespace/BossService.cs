using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Boss;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public class BossService : AbstractService
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x17000094")]
		public override short ServiceId
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x5839", Offset = "0x5839", VA = "0x5839", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001E")]
		public event Action<InstanceInfoEvt> InstanceInfoEvent
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x583A", Offset = "0x583A", VA = "0x583A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x583B", Offset = "0x583B", VA = "0x583B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001F")]
		public event Action<ActiveTeamArchivedEvt> ActiveTeamArchivedEvent
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x583C", Offset = "0x583C", VA = "0x583C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x583D", Offset = "0x583D", VA = "0x583D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000020")]
		public event Action<TeamTimeoutEvt> ActiveTeamTimeoutEvent
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x583E", Offset = "0x583E", VA = "0x583E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x583F", Offset = "0x583F", VA = "0x583F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000021")]
		public event Action<CreateRequestEvt> CreateRequestEvent
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x5840", Offset = "0x5840", VA = "0x5840")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x5841", Offset = "0x5841", VA = "0x5841")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000022")]
		public event Action<TeamInfo> TeamInfoChangedEvent
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x5842", Offset = "0x5842", VA = "0x5842")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x5843", Offset = "0x5843", VA = "0x5843")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000023")]
		public event Action<MonsterHealthEvt> MonsterHealthChangedEvent
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x5844", Offset = "0x5844", VA = "0x5844")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x5845", Offset = "0x5845", VA = "0x5845")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000024")]
		public event Action<InstanceState> InstanceStateChangedEvent
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x5846", Offset = "0x5846", VA = "0x5846")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x5847", Offset = "0x5847", VA = "0x5847")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000025")]
		public event Action<MercenaryInvitesEvt> MercenaryInvitesChangedEvent
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x5848", Offset = "0x5848", VA = "0x5848")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x5849", Offset = "0x5849", VA = "0x5849")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000026")]
		public event Action<MercenaryTeamsEvt> MercenaryTeamsChangedEvent
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x584A", Offset = "0x584A", VA = "0x584A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x584B", Offset = "0x584B", VA = "0x584B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000027")]
		public event Action<MinionAttackEvt> MinionAttackEvent
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x584C", Offset = "0x584C", VA = "0x584C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x584D", Offset = "0x584D", VA = "0x584D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000028")]
		public event Action<MinionAttackServerCancelationEvt> MinionAttackServerCancelationEvent
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x584E", Offset = "0x584E", VA = "0x584E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x584F", Offset = "0x584F", VA = "0x584F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x5850", Offset = "0x5850", VA = "0x5850", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_BossService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a628b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetInstanceListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetInstanceListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628b5 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Boss_GetInstanceListCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,1,uVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_GetInstanceListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5851", Offset = "0x5851", VA = "0x5851")]
		public OpToken<IMessage, object> GetInstanceList()
		{
		/* --- GHIDRA: GetInstanceList ---
		int * ServicesNamespace_BossService__GetInstanceList(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a628b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_CreateTeamAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628b6 = '\x01';
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
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,2,0,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_CreateTeamAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5852", Offset = "0x5852", VA = "0x5852")]
		public OpToken<IMessage, object> CreateTeam()
		{
		/* --- GHIDRA: CreateTeam ---
		int * ServicesNamespace_BossService__CreateTeam(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a628b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_InviteMercenaryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_InviteMercenaryAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628b7 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_InviteMercenaryCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,3,iVar2,0);
		    local_10 = 0x3ffffffff;
		    local_14 = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param2_00 = func_ii_8783(&local_8,0);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,param2_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_InviteMercenaryAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x5853", Offset = "0x5853", VA = "0x5853")]
		public OpToken<IMessage, object> InviteAssistant(ulong userId)
		{
		/* --- GHIDRA: InviteAssistant ---
		int * ServicesNamespace_BossService__InviteAssistant
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_KickMercenaryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628b8 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_KickMercenaryCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,4,iVar2,0);
		    local_18 = 0x4ffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = func_ii_8783(&local_10,0);
		    param4_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5854", Offset = "0x5854", VA = "0x5854")]
		public OpToken<IMessage, object> KickAssistant(long instanceId, ulong userId)
		{
		/* --- GHIDRA: KickAssistant ---
		int * ServicesNamespace_BossService__KickAssistant
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_AcceptInvitationCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628b9 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_AcceptInvitationCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,5,iVar2,0);
		    local_18 = 0x5ffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = func_ii_8783(&local_10,0);
		    param4_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5855", Offset = "0x5855", VA = "0x5855")]
		public OpToken<IMessage, object> AcceptInvitation(long instanceId, ulong userId)
		{
		/* --- GHIDRA: AcceptInvitation ---
		int * ServicesNamespace_BossService__AcceptInvitation
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_RefuseInvitationCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628ba = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_RefuseInvitationCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,6,iVar2,0);
		    local_18 = 0x6ffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = func_ii_8783(&local_10,0);
		    param4_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x5856", Offset = "0x5856", VA = "0x5856")]
		public OpToken<IMessage, object> RefuseInvitation(long instanceId, ulong userId)
		{
		/* --- GHIDRA: RefuseInvitation ---
		int * ServicesNamespace_BossService__RefuseInvitation
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetTeamInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetTeamInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628bb = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_GetTeamInfoCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,7,iVar2,0);
		    local_18 = 0x7ffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = func_ii_8783(&local_10,0);
		    param4_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_GetTeamInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5857", Offset = "0x5857", VA = "0x5857")]
		public OpToken<IMessage, object> GetTeamInfo(long instanceId, ulong teamId)
		{
		/* --- GHIDRA: GetTeamInfo ---
		int * ServicesNamespace_BossService__GetTeamInfo
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetActiveTeamInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetTeamInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628bc = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_GetActiveTeamInfoCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,8,iVar2,0);
		    local_18 = 0x8ffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = func_ii_8783(&local_10,0);
		    param4_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_GetTeamInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x5858", Offset = "0x5858", VA = "0x5858")]
		public OpToken<IMessage, object> GetActiveTeamInfo(long instanceId, ulong captainId)
		{
		/* --- GHIDRA: GetActiveTeamInfo ---
		int * ServicesNamespace_BossService__GetActiveTeamInfo
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_DistributeRewardsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_DistributeRewardsCmd_Types_UserReward__AddRange__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628bd = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_DistributeRewardsCmd_TypeInfo);
		    Protocol_Boss_DistributeRewardsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		              (*(undefined4 *)(iVar2 + 0x20),param4,
		               Method_Google_Protobuf_Collections_RepeatedField_DistributeRewardsCmd_Types_UserReward__AddRange__
		              );
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,9,iVar2,0);
		    local_18 = 0x9ffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    param4_00 = func_ii_8783(&local_10,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_DefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x5859", Offset = "0x5859", VA = "0x5859")]
		public OpToken<IMessage, object> DistributeRewards(long instanceId, ulong teamId, List<DistributeRewardsCmd.Types.UserReward> userRewards)
		{
		/* --- GHIDRA: DistributeRewards ---
		int * ServicesNamespace_BossService__DistributeRewards
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetTeamRewardsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetTeamRewardsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628be = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_GetTeamRewardsCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,10,iVar2,0);
		    local_18 = 0xaffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    param4_00 = func_ii_8783(&local_10,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_GetTeamRewardsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x585A", Offset = "0x585A", VA = "0x585A")]
		public OpToken<IMessage, object> GetTeamRewards(long instanceId, ulong teamId)
		{
		/* --- GHIDRA: GetTeamRewards ---
		int * ServicesNamespace_BossService__GetTeamRewards
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  local_c = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_BeginBattleCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_BeginBattleAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628bf = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_BeginBattleCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xb,iVar2,0);
		    local_14 = 0xbffffffff;
		    local_18 = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    param4_00 = func_ii_4443(&local_c,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_BeginBattleAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x585B", Offset = "0x585B", VA = "0x585B")]
		public OpToken<IMessage, object> BeginBattle(long optionId, int variantId)
		{
		/* --- GHIDRA: BeginBattle ---
		int * ServicesNamespace_BossService__BeginBattle
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a628c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetCaptainTeamListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetCaptainTeamListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a628c0 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_GetCaptainTeamListCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xc,iVar2,0);
		    local_18 = 0xcffffffff;
		    local_1c = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    param4_00 = func_ii_8783(&local_10,0);
		    uVar3 = System_Int32__ToString(uVar3,param2_00,StringLiteral_19176,param4_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_GetCaptainTeamListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x585C", Offset = "0x585C", VA = "0x585C")]
		public OpToken<IMessage, object> GetCaptainTeamList(long instanceId, ulong captainId)
		{
		/* --- GHIDRA: GetCaptainTeamList ---
		int * ServicesNamespace_BossService__GetCaptainTeamList
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a628c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetRatingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c1 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_GetRatingCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xe,iVar2,0);
		    local_10 = 0xeffffffff;
		    local_14 = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,param2_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_GetRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x585D", Offset = "0x585D", VA = "0x585D")]
		public OpToken<IMessage, object> GetRating(long instanceId)
		{
		/* --- GHIDRA: GetRating ---
		int * ServicesNamespace_BossService__GetRating(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a628c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_BuyLicenseAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c2 = '\x01';
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
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0xf,0,0);
		    local_8 = 0xfffffffff;
		    local_c = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_BuyLicenseAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x585E", Offset = "0x585E", VA = "0x585E")]
		public OpToken<IMessage, object> BuyLicence()
		{
		/* --- GHIDRA: BuyLicence ---
		int * ServicesNamespace_BossService__BuyLicence(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a628c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetPlaceCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetPlaceAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c3 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Boss_GetPlaceCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x10,iVar2,0);
		    local_10 = 0x10ffffffff;
		    local_14 = Protocol_Boss_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,param2_00,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_GetPlaceAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x585F", Offset = "0x585F", VA = "0x585F")]
		public OpToken<IMessage, object> GetPlace(long instanceId)
		{
		/* --- GHIDRA: GetPlace ---
		int * ServicesNamespace_BossService__GetPlace(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 param2_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a628c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetMercenariesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c4 = '\x01';
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
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0x11,0,0);
		    local_10 = 0x11ffffffff;
		    local_14 = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_GetMercenariesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x5860", Offset = "0x5860", VA = "0x5860")]
		public OpToken<IMessage, object> GetPossibleMercenaries(long instanceId)
		{
		/* --- GHIDRA: GetPossibleMercenaries ---
		int * ServicesNamespace_BossService__GetPossibleMercenaries(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a628c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c5 = '\x01';
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
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0x12,0,0);
		    local_8 = 0x12ffffffff;
		    local_c = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x5861", Offset = "0x5861", VA = "0x5861")]
		public OpToken<IMessage, object> ReadyToListen()
		{
		/* --- GHIDRA: ReadyToListen ---
		int * ServicesNamespace_BossService__ReadyToListen(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a628c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_MinionAttackCancelAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c6 = '\x01';
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
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0x13,0,0);
		    local_8 = 0x13ffffffff;
		    local_c = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_MinionAttackCancelAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x5862", Offset = "0x5862", VA = "0x5862")]
		public OpToken<IMessage, object> MinionAttackCancel()
		{
		/* --- GHIDRA: MinionAttackCancel ---
		int * ServicesNamespace_BossService__MinionAttackCancel(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a628c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MinionJumpToCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_MinionJumpToCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a628c7 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Boss_MinionJumpToCombatCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0x14,param3,0);
		    local_8 = 0x14ffffffff;
		    local_c = Protocol_Boss_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_MinionJumpToCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x5863", Offset = "0x5863", VA = "0x5863")]
		public OpToken<IMessage, object> MinionJumpToCombat()
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x5864", Offset = "0x5864", VA = "0x5864")]
		public BossService()
		{
		/* --- GHIDRA: .ctor ---
		void ServicesNamespace_BossService___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetCaveInfoAns__TypeInfo);
		    DAT_ram_00a628c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetCaveInfoAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetCaveInfoAns__TypeInfo), iVar2 == 0))
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
		void ServicesNamespace_BossService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6289e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceInfoEvt__TypeInfo);
		    DAT_ram_00a6289e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_InstanceInfoEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_InstanceInfoEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_InstanceInfoEvent ---
		void ServicesNamespace_BossService__add_InstanceInfoEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6289f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceInfoEvt__TypeInfo);
		    DAT_ram_00a6289f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_InstanceInfoEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_InstanceInfoEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_InstanceInfoEvent ---
		void ServicesNamespace_BossService__remove_InstanceInfoEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ActiveTeamArchivedEvt__TypeInfo);
		    DAT_ram_00a628a0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ActiveTeamArchivedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ActiveTeamArchivedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_ActiveTeamArchivedEvent ---
		void ServicesNamespace_BossService__add_ActiveTeamArchivedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ActiveTeamArchivedEvt__TypeInfo);
		    DAT_ram_00a628a1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ActiveTeamArchivedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ActiveTeamArchivedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_ActiveTeamArchivedEvent ---
		void ServicesNamespace_BossService__remove_ActiveTeamArchivedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamTimeoutEvt__TypeInfo);
		    DAT_ram_00a628a2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TeamTimeoutEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamTimeoutEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_ActiveTeamTimeoutEvent ---
		void ServicesNamespace_BossService__add_ActiveTeamTimeoutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamTimeoutEvt__TypeInfo);
		    DAT_ram_00a628a3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TeamTimeoutEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamTimeoutEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ActiveTeamTimeoutEvent ---
		void ServicesNamespace_BossService__remove_ActiveTeamTimeoutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CreateRequestEvt__TypeInfo);
		    DAT_ram_00a628a4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CreateRequestEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CreateRequestEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_CreateRequestEvent ---
		void ServicesNamespace_BossService__add_CreateRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CreateRequestEvt__TypeInfo);
		    DAT_ram_00a628a5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CreateRequestEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CreateRequestEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_CreateRequestEvent ---
		void ServicesNamespace_BossService__remove_CreateRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamInfo__TypeInfo);
		    DAT_ram_00a628a6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TeamInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamInfo__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_TeamInfoChangedEvent ---
		void ServicesNamespace_BossService__add_TeamInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamInfo__TypeInfo);
		    DAT_ram_00a628a7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TeamInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamInfo__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_TeamInfoChangedEvent ---
		void ServicesNamespace_BossService__remove_TeamInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterHealthEvt__TypeInfo);
		    DAT_ram_00a628a8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MonsterHealthEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MonsterHealthEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_MonsterHealthChangedEvent ---
		void ServicesNamespace_BossService__add_MonsterHealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterHealthEvt__TypeInfo);
		    DAT_ram_00a628a9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MonsterHealthEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MonsterHealthEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_MonsterHealthChangedEvent ---
		void ServicesNamespace_BossService__remove_MonsterHealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceState__TypeInfo);
		    DAT_ram_00a628aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_InstanceState__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_InstanceState__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_InstanceStateChangedEvent ---
		void ServicesNamespace_BossService__add_InstanceStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceState__TypeInfo);
		    DAT_ram_00a628ab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_InstanceState__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_InstanceState__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_InstanceStateChangedEvent ---
		void ServicesNamespace_BossService__remove_InstanceStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryInvitesEvt__TypeInfo);
		    DAT_ram_00a628ac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MercenaryInvitesEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MercenaryInvitesEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_MercenaryInvitesChangedEvent ---
		void ServicesNamespace_BossService__add_MercenaryInvitesChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryInvitesEvt__TypeInfo);
		    DAT_ram_00a628ad = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MercenaryInvitesEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MercenaryInvitesEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_MercenaryInvitesChangedEvent ---
		void ServicesNamespace_BossService__remove_MercenaryInvitesChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628ae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryTeamsEvt__TypeInfo);
		    DAT_ram_00a628ae = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MercenaryTeamsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MercenaryTeamsEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_MercenaryTeamsChangedEvent ---
		void ServicesNamespace_BossService__add_MercenaryTeamsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryTeamsEvt__TypeInfo);
		    DAT_ram_00a628af = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MercenaryTeamsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MercenaryTeamsEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_MercenaryTeamsChangedEvent ---
		void ServicesNamespace_BossService__remove_MercenaryTeamsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackEvt__TypeInfo);
		    DAT_ram_00a628b0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MinionAttackEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MinionAttackEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_MinionAttackEvent ---
		void ServicesNamespace_BossService__add_MinionAttackEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackEvt__TypeInfo);
		    DAT_ram_00a628b1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MinionAttackEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MinionAttackEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_MinionAttackEvent ---
		void ServicesNamespace_BossService__remove_MinionAttackEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		    DAT_ram_00a628b2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MinionAttackServerCancelationEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MinionAttackServerCancelationEvt__TypeInfo),
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


		/* --- GHIDRA: add_MinionAttackServerCancelationEvent ---
		void ServicesNamespace_BossService__add_MinionAttackServerCancelationEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		    DAT_ram_00a628b3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MinionAttackServerCancelationEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MinionAttackServerCancelationEvt__TypeInfo),
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


		/* --- GHIDRA: remove_MinionAttackServerCancelationEvent ---
		void ServicesNamespace_BossService__remove_MinionAttackServerCancelationEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a628b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_Events___);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_ActiveTeamArchivedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_CreateRequestEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_InstanceInfoEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_InstanceState_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MercenaryInvitesEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MercenaryTeamsEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MinionAttackEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MinionAttackServerCancelationEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MonsterHealthEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_TeamInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_TeamTimeoutEvt_TypeInfo);
		    DAT_ram_00a628b4 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_Events___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x2c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_InstanceState_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_InstanceState_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 2) {
		    iVar1 = *(int *)(param1 + 0x24);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_TeamInfo_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_TeamInfo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 3) {
		    iVar1 = *(int *)(param1 + 0x28);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_MonsterHealthEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_MonsterHealthEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 4) {
		    iVar1 = *(int *)(param1 + 0x34);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_MercenaryTeamsEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_MercenaryTeamsEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 5) {
		    iVar1 = *(int *)(param1 + 0x30);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_MercenaryInvitesEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_MercenaryInvitesEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 6) {
		    iVar1 = *(int *)(param1 + 0x18);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_ActiveTeamArchivedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_ActiveTeamArchivedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 7) {
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_TeamTimeoutEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_TeamTimeoutEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 8) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_InstanceInfoEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_InstanceInfoEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 9) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_CreateRequestEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_CreateRequestEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Boss_MinionAttackEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Boss_MinionAttackEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 != 0xb) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x3c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Boss_MinionAttackServerCancelationEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Boss_MinionAttackServerCancelationEvt_TypeInfo);
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
