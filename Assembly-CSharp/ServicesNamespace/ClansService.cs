using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Main;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public class ClansService : AbstractService
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x17000099")]
		public override short ServiceId
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x58C6", Offset = "0x58C6", VA = "0x58C6", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000043")]
		public event Action<ProtoStackableChangesAns> GolemSlotsChangedEvent
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x58C7", Offset = "0x58C7", VA = "0x58C7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x58C8", Offset = "0x58C8", VA = "0x58C8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000044")]
		public event Action<ProtoTreasuryChangedEvt> TreasuryChangedEvent
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x58C9", Offset = "0x58C9", VA = "0x58C9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x58CA", Offset = "0x58CA", VA = "0x58CA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000045")]
		public event Action<ProtoUserLeftClanEvt> UserLeftClanEvent
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x58CB", Offset = "0x58CB", VA = "0x58CB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x58CC", Offset = "0x58CC", VA = "0x58CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000046")]
		public event Action<ProtoClanLeaderChangedEvt> ClanLeaderChangedEvent
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x58CD", Offset = "0x58CD", VA = "0x58CD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x58CE", Offset = "0x58CE", VA = "0x58CE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000047")]
		public event Action<ProtoClanRestrictionChangedEvt> ClanRestrictionsChangedEvent
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x58CF", Offset = "0x58CF", VA = "0x58CF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x58D0", Offset = "0x58D0", VA = "0x58D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000048")]
		public event Action<ProtoCreateClanAns> ClanCreatedEvent
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x58D1", Offset = "0x58D1", VA = "0x58D1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x58D2", Offset = "0x58D2", VA = "0x58D2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000049")]
		public event Action<ProtoUnregisterClanAns> ClanUnregisteredEvent
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x58D3", Offset = "0x58D3", VA = "0x58D3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x58D4", Offset = "0x58D4", VA = "0x58D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x58D5", Offset = "0x58D5", VA = "0x58D5", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_ClansService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62930 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetOwnClanInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetOwnClanInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62930 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Clans_ProtoGetOwnClanInfoCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,4,uVar2,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetOwnClanInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x58D6", Offset = "0x58D6", VA = "0x58D6")]
		public OpToken<IMessage, object> GetOwnClanInfo()
		{
		/* --- GHIDRA: GetOwnClanInfo ---
		int * ServicesNamespace_ClansService__GetOwnClanInfo
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62931 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetShortClansInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetShortClansInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62931 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoGetShortClansInfoCmd_TypeInfo);
		    Protocol_Clans_ProtoGetShortClansInfoCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		    Google_Protobuf_Collections_RepeatedField_ulong___AddEntriesFrom
		              (*(undefined4 *)(iVar2 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x17,iVar2,0);
		    local_8 = 0x17ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetShortClansInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x58D7", Offset = "0x58D7", VA = "0x58D7")]
		public OpToken<IMessage, object> GetShortClansInfo(params ulong[] ids)
		{
		/* --- GHIDRA: GetShortClansInfo ---
		int * ServicesNamespace_ClansService__GetShortClansInfo
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62932 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetClanVacanciesListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62932 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0xd,param2,0);
		    local_8 = 0xdffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetClanVacanciesListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x58D8", Offset = "0x58D8", VA = "0x58D8")]
		public OpToken<IMessage, object> GetClanVacanciesList(ProtoGetClanVacanciesListCmd msg)
		{
		/* --- GHIDRA: GetClanVacanciesList ---
		int * ServicesNamespace_ClansService__GetClanVacanciesList
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62933 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoPutRequestForJoinCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoPutRequestForJoinAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62933 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoPutRequestForJoinCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,7,iVar2,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoPutRequestForJoinAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x58D9", Offset = "0x58D9", VA = "0x58D9")]
		public OpToken<IMessage, object> PutRequestForJoin(ulong clanId)
		{
		/* --- GHIDRA: PutRequestForJoin ---
		int * ServicesNamespace_ClansService__PutRequestForJoin(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62934 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoCancelRequestForJoinCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62934 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Clans_ProtoCancelRequestForJoinCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,8,uVar2,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x58DA", Offset = "0x58DA", VA = "0x58DA")]
		public OpToken<IMessage, object> CancelRequestForJoin()
		{
		/* --- GHIDRA: CancelRequestForJoin ---
		int * ServicesNamespace_ClansService__CancelRequestForJoin
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62935 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetMembersListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetMembersListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62935 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoGetMembersListCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,6,iVar2,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetMembersListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x58DB", Offset = "0x58DB", VA = "0x58DB")]
		public OpToken<IMessage, object> GetMembersList(ulong clanId)
		{
		/* --- GHIDRA: GetMembersList ---
		int * ServicesNamespace_ClansService__GetMembersList
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62936 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoChangeClanInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoChangeClanInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62936 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoChangeClanInfoCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x11,iVar2,0);
		    local_8 = 0x11ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoChangeClanInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x58DC", Offset = "0x58DC", VA = "0x58DC")]
		public OpToken<IMessage, object> ChangeClanInfo(ulong clanId, ProtoCreateClanCmd clanSetting)
		{
		/* --- GHIDRA: ChangeClanInfo ---
		int * ServicesNamespace_ClansService__ChangeClanInfo
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62937 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoKickMemberCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoKickMemberAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62937 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoKickMemberCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,9,iVar2,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoKickMemberAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x58DD", Offset = "0x58DD", VA = "0x58DD")]
		public OpToken<IMessage, object> KickMember(ulong clanId, ulong userId)
		{
		/* --- GHIDRA: KickMember ---
		int * ServicesNamespace_ClansService__KickMember
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62938 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoAppointHeadCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoAppointHeadAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62938 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoAppointHeadCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,10,iVar2,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoAppointHeadAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x58DE", Offset = "0x58DE", VA = "0x58DE")]
		public OpToken<IMessage, object> AppointHead(ulong clanId, ulong userId)
		{
		/* --- GHIDRA: AppointHead ---
		int * ServicesNamespace_ClansService__AppointHead(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62939 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoBuyAddPlaceCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62939 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoBuyAddPlaceCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xb,iVar2,0);
		    local_8 = 0xbffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
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

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x58DF", Offset = "0x58DF", VA = "0x58DF")]
		public OpToken<IMessage, object> BuyAddPlace(ulong clanId)
		{
		/* --- GHIDRA: BuyAddPlace ---
		int * ServicesNamespace_ClansService__BuyAddPlace
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6293a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoSetClanStateFlagsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6293a = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoSetClanStateFlagsCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x10,iVar2,0);
		    local_8 = 0x10ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x58E0", Offset = "0x58E0", VA = "0x58E0")]
		public OpToken<IMessage, object> SetClanStateFlags(ulong clanId, uint flags)
		{
		/* --- GHIDRA: SetClanStateFlags ---
		int * ServicesNamespace_ClansService__SetClanStateFlags(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6293b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanTreasuryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetClanTreasuryAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6293b = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Clans_ProtoGetClanTreasuryCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,3,uVar2,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetClanTreasuryAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x58E1", Offset = "0x58E1", VA = "0x58E1")]
		public OpToken<IMessage, object> GetClanTreasury()
		{
		/* --- GHIDRA: GetClanTreasury ---
		int * ServicesNamespace_ClansService__GetClanTreasury
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6293c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoAddToTreasuryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoAddToTreasuryAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6293c = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoAddToTreasuryCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,5,iVar2,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoAddToTreasuryAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x58E2", Offset = "0x58E2", VA = "0x58E2")]
		public OpToken<IMessage, object> AddToTreasury(ulong clanId, ResourceSet resourceSet)
		{
		/* --- GHIDRA: AddToTreasury ---
		int * ServicesNamespace_ClansService__AddToTreasury(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6293d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetJoinRequestListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6293d = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0xc,param2,0);
		    local_8 = 0xcffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetJoinRequestListAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x58E3", Offset = "0x58E3", VA = "0x58E3")]
		public OpToken<IMessage, object> GetJoinRequestList(ProtoGetJoinRequestListCmd msg)
		{
		/* --- GHIDRA: GetJoinRequestList ---
		int * ServicesNamespace_ClansService__GetJoinRequestList
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6293e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoApproveJoinRequestCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoApproveJoinRequestAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6293e = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoApproveJoinRequestCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xe,iVar2,0);
		    local_8 = 0xeffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoApproveJoinRequestAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x58E4", Offset = "0x58E4", VA = "0x58E4")]
		public OpToken<IMessage, object> ApproveJoinRequest(ulong clanId, ulong userId)
		{
		/* --- GHIDRA: ApproveJoinRequest ---
		int * ServicesNamespace_ClansService__ApproveJoinRequest
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6293f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoRefuseJoinRequestsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoRefuseJoinRequestsCmd___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6293f = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoRefuseJoinRequestsCmd_TypeInfo);
		    Protocol_Clans_ProtoRefuseJoinRequestsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_ulong___Add
		              (*(undefined4 *)(iVar2 + 0x18),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xf,iVar2,0);
		    local_8 = 0xfffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoRefuseJoinRequestsCmd___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x58E5", Offset = "0x58E5", VA = "0x58E5")]
		public OpToken<IMessage, object> RefuseJoinRequests(ulong clanId, params ulong[] userIds)
		{
		/* --- GHIDRA: RefuseJoinRequests ---
		int * ServicesNamespace_ClansService__RefuseJoinRequests
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62940 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ClansService_OnCreateClan__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoCreateClanCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoCreateClanAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62940 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoCreateClanCmd_TypeInfo);
		    Protocol_Clans_ProtoCreateClanCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		    Protocol_Clans_ProtoCreateClanCmd__get_Name(iVar2,param2,0);
		    Protocol_Clans_ProtoCreateClanCmd__get_Description(iVar2,param3,0);
		    *(undefined4 *)(iVar2 + 0x14) = param4;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,1,iVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,Method_ServicesNamespace_ClansService_OnCreateClan__,0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoCreateClanAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x58E6", Offset = "0x58E6", VA = "0x58E6")]
		public OpToken<IMessage, object> CreateClan(string name, string description, uint flags)
		{
		/* --- GHIDRA: CreateClan ---
		void ServicesNamespace_ClansService__CreateClan
		               (int *param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62941 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoCreateClanAns_TypeInfo);
		    DAT_ram_00a62941 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		            (param1,param2,param3,*(undefined4 *)(*param1 + 0xec));
		  iVar1 = param1[10];
		  if (iVar1 != 0) {
		    if (param3 == (int *)0x0) {
		      param3 = (int *)0x0;
		    }
		    else if (*param3 != Protocol_Clans_ProtoCreateClanAns_TypeInfo) {
		      param3 = (int *)0x0;
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x58E7", Offset = "0x58E7", VA = "0x58E7")]
		private void OnCreateClan(SrvCommand cmd, IMessage args)
		{
		/* --- GHIDRA: OnCreateClan ---
		int * ServicesNamespace_ClansService__OnCreateClan(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62942 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62942 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0x20,0,0);
		    local_8 = 0x20ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x58E8", Offset = "0x58E8", VA = "0x58E8")]
		public OpToken<IMessage, object> RepayCreditDebt()
		{
		/* --- GHIDRA: RepayCreditDebt ---
		int * ServicesNamespace_ClansService__RepayCreditDebt
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62943 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetGolemArtifactsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62943 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoGetGolemArtifactsCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x19,iVar2,0);
		    local_8 = 0x19ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x58E9", Offset = "0x58E9", VA = "0x58E9")]
		public OpToken<IMessage, object> GetGolemArtifacts(ulong golemId)
		{
		/* --- GHIDRA: GetGolemArtifacts ---
		int * ServicesNamespace_ClansService__GetGolemArtifacts
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62944 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSwapSlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62944 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Main_ProtoSwapSlotsCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x10) = param3;
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x13,iVar2,0);
		    local_8 = 0x13ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x58EA", Offset = "0x58EA", VA = "0x58EA")]
		public OpToken<IMessage, object> SwapGolemSlots(int slotIdFrom, int slotIdTo)
		{
		/* --- GHIDRA: SwapGolemSlots ---
		int * ServicesNamespace_ClansService__SwapGolemSlots
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62945 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoPutUserItemToGolemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62945 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoPutUserItemToGolemCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x18) = param3;
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x14,iVar2,0);
		    local_8 = 0x14ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x58EB", Offset = "0x58EB", VA = "0x58EB")]
		public OpToken<IMessage, object> PutUserItemToGolem(ulong artId, uint slotIdTo)
		{
		/* --- GHIDRA: PutUserItemToGolem ---
		int * ServicesNamespace_ClansService__PutUserItemToGolem
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62946 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoSellGolemItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62946 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoSellGolemItemCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x15,iVar2,0);
		    local_8 = 0x15ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x58EC", Offset = "0x58EC", VA = "0x58EC")]
		public OpToken<IMessage, object> SellGolemItem(int slotId)
		{
		/* --- GHIDRA: SellGolemItem ---
		int * ServicesNamespace_ClansService__SellGolemItem(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62947 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ClansService_OnUnregisterClan__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoUnregisterClanCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoUnregisterClanAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62947 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Clans_ProtoUnregisterClanCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,0x18,uVar2,0);
		    local_8 = 0x18ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,Method_ServicesNamespace_ClansService_OnUnregisterClan__,0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoUnregisterClanAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x58ED", Offset = "0x58ED", VA = "0x58ED")]
		public OpToken<IMessage, object> UnregisterClan()
		{
		/* --- GHIDRA: UnregisterClan ---
		void ServicesNamespace_ClansService__UnregisterClan
		               (int *param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62948 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoUnregisterClanAns_TypeInfo);
		    DAT_ram_00a62948 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		            (param1,param2,param3,*(undefined4 *)(*param1 + 0xec));
		  iVar1 = param1[0xb];
		  if (iVar1 != 0) {
		    if (param3 == (int *)0x0) {
		      param3 = (int *)0x0;
		    }
		    else if (*param3 != Protocol_Clans_ProtoUnregisterClanAns_TypeInfo) {
		      param3 = (int *)0x0;
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x58EE", Offset = "0x58EE", VA = "0x58EE")]
		private void OnUnregisterClan(SrvCommand cmd, IMessage args)
		{
		/* --- GHIDRA: OnUnregisterClan ---
		int * ServicesNamespace_ClansService__OnUnregisterClan
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62949 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoLeaveClanCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoKickMemberAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62949 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Clans_ProtoLeaveClanCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0x12,iVar2,0);
		    local_8 = 0x12ffffffff;
		    local_c = Protocol_Clans_ClansCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoKickMemberAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x58EF", Offset = "0x58EF", VA = "0x58EF")]
		public OpToken<IMessage, object> LeaveClan(ulong clanId)
		{
			return null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x58F0", Offset = "0x58F0", VA = "0x58F0")]
		public ClansService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_ClansService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62921 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStackableChangesAns__TypeInfo);
		    DAT_ram_00a62921 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoStackableChangesAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoStackableChangesAns__TypeInfo), iVar2 == 0
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


		/* --- GHIDRA: add_GolemSlotsChangedEvent ---
		void ServicesNamespace_ClansService__add_GolemSlotsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62922 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStackableChangesAns__TypeInfo);
		    DAT_ram_00a62922 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoStackableChangesAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoStackableChangesAns__TypeInfo), iVar2 == 0
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


		/* --- GHIDRA: remove_GolemSlotsChangedEvent ---
		void ServicesNamespace_ClansService__remove_GolemSlotsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62923 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    DAT_ram_00a62923 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTreasuryChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTreasuryChangedEvt__TypeInfo), iVar2 == 0)
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


		/* --- GHIDRA: add_TreasuryChangedEvent ---
		void ServicesNamespace_ClansService__add_TreasuryChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62924 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    DAT_ram_00a62924 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTreasuryChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTreasuryChangedEvt__TypeInfo), iVar2 == 0)
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


		/* --- GHIDRA: remove_TreasuryChangedEvent ---
		void ServicesNamespace_ClansService__remove_TreasuryChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62925 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    DAT_ram_00a62925 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserLeftClanEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserLeftClanEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_UserLeftClanEvent ---
		void ServicesNamespace_ClansService__add_UserLeftClanEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62926 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    DAT_ram_00a62926 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserLeftClanEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserLeftClanEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_UserLeftClanEvent ---
		void ServicesNamespace_ClansService__remove_UserLeftClanEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62927 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanLeaderChangedEvt__TypeInfo);
		    DAT_ram_00a62927 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanLeaderChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanLeaderChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_ClanLeaderChangedEvent ---
		void ServicesNamespace_ClansService__add_ClanLeaderChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62928 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanLeaderChangedEvt__TypeInfo);
		    DAT_ram_00a62928 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanLeaderChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanLeaderChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_ClanLeaderChangedEvent ---
		void ServicesNamespace_ClansService__remove_ClanLeaderChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62929 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanRestrictionChangedEvt__TypeInfo);
		    DAT_ram_00a62929 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanRestrictionChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanRestrictionChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_ClanRestrictionsChangedEvent ---
		void ServicesNamespace_ClansService__add_ClanRestrictionsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6292a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanRestrictionChangedEvt__TypeInfo);
		    DAT_ram_00a6292a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanRestrictionChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanRestrictionChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_ClanRestrictionsChangedEvent ---
		void ServicesNamespace_ClansService__remove_ClanRestrictionsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6292b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCreateClanAns__TypeInfo);
		    DAT_ram_00a6292b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCreateClanAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCreateClanAns__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_ClanCreatedEvent ---
		void ServicesNamespace_ClansService__add_ClanCreatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6292c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCreateClanAns__TypeInfo);
		    DAT_ram_00a6292c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCreateClanAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCreateClanAns__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_ClanCreatedEvent ---
		void ServicesNamespace_ClansService__remove_ClanCreatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6292d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    DAT_ram_00a6292d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUnregisterClanAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUnregisterClanAns__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_ClanUnregisteredEvent ---
		void ServicesNamespace_ClansService__add_ClanUnregisteredEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6292e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    DAT_ram_00a6292e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUnregisterClanAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUnregisterClanAns__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_ClanUnregisteredEvent ---
		void ServicesNamespace_ClansService__remove_ClanUnregisteredEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a6292f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ClansEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoClanLeaderChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoClanRestrictionChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoTreasuryChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoUserLeftClanEvt_TypeInfo);
		    DAT_ram_00a6292f = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ClansEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_00)
		       ) {
		      System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoTreasuryChangedEvt_TypeInfo != *param1_00)
		       ) {
		      System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoTreasuryChangedEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoUserLeftClanEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoUserLeftClanEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 == 4) {
		      return;
		    }
		    if (iVar1 == 5) {
		      iVar1 = *(int *)(param1 + 0x20);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Clans_ProtoClanLeaderChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_Clans_ProtoClanLeaderChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar1 != 6) {
		        return;
		      }
		      iVar1 = *(int *)(param1 + 0x24);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Clans_ProtoClanRestrictionChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_Clans_ProtoClanRestrictionChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
