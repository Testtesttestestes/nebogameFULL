using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Tournaments;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public class TournamentsService : AbstractService
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x170000B2")]
		public override short ServiceId
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x5A9C", Offset = "0x5A9C", VA = "0x5A9C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AC")]
		public event Action<ProtoBetChangedEvt> BetChangedEvent
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x5A9D", Offset = "0x5A9D", VA = "0x5A9D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x5A9E", Offset = "0x5A9E", VA = "0x5A9E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AD")]
		public event Action<ProtoBetChangedOnPlayerEvt> BetChangedOnPlayerEvent
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x5A9F", Offset = "0x5A9F", VA = "0x5A9F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x5AA0", Offset = "0x5AA0", VA = "0x5AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AE")]
		public event Action<ProtoHealtChangedEvt> HealthChangedEvent
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x5AA1", Offset = "0x5AA1", VA = "0x5AA1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x5AA2", Offset = "0x5AA2", VA = "0x5AA2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AF")]
		public event Action<ProtoStateChangedEvt> StateChangedEvent
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x5AA3", Offset = "0x5AA3", VA = "0x5AA3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x5AA4", Offset = "0x5AA4", VA = "0x5AA4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B0")]
		public event Action<ProtoCurrentTnmCombatCompleteEvt> CurrentCombatCompleteEvent
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x5AA5", Offset = "0x5AA5", VA = "0x5AA5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x5AA6", Offset = "0x5AA6", VA = "0x5AA6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B1")]
		public event Action<ProtoFinalTnmCombatCompleteEvt> FinalCombatCompleteEvent
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x5AA7", Offset = "0x5AA7", VA = "0x5AA7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x5AA8", Offset = "0x5AA8", VA = "0x5AA8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x5AA9", Offset = "0x5AA9", VA = "0x5AA9", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_TournamentsService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetTournamentListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7cd = '\x01';
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
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetTournamentListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x5AAA", Offset = "0x5AAA", VA = "0x5AAA")]
		public OpToken<IMessage, object> GetTournamentsList()
		{
		/* --- GHIDRA: GetTournamentsList ---
		int * ServicesNamespace_TournamentsService__GetTournamentsList
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoAddBetCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoAddBetAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7ce = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Tournaments_ProtoAddBetCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoAddBetAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x5AAB", Offset = "0x5AAB", VA = "0x5AAB")]
		public OpToken<IMessage, object> AddBet(uint tournamentTypeId, ResourceSet betValue)
		{
		/* --- GHIDRA: AddBet ---
		int * ServicesNamespace_TournamentsService__AddBet
		                (int *param1,undefined4 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoSetBetCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSetBetAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7cf = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Tournaments_ProtoSetBetCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,3,iVar1,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSetBetAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x5AAC", Offset = "0x5AAC", VA = "0x5AAC")]
		public OpToken<IMessage, object> SetBet(uint tournamentTypeId, ulong userId)
		{
		/* --- GHIDRA: SetBet ---
		int * ServicesNamespace_TournamentsService__SetBet(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoJoinForBrowsingCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7d0 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Tournaments_ProtoJoinForBrowsingCombatCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,iVar1,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x5AAD", Offset = "0x5AAD", VA = "0x5AAD")]
		public OpToken<IMessage, object> BrowseCombat(ulong userId)
		{
		/* --- GHIDRA: BrowseCombat ---
		int * ServicesNamespace_TournamentsService__BrowseCombat(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoUnJoinForBrowsingCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7d1 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Tournaments_ProtoUnJoinForBrowsingCombatCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,6,uVar2,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x5AAE", Offset = "0x5AAE", VA = "0x5AAE")]
		public OpToken<IMessage, object> LeaveCombatBrowsing()
		{
		/* --- GHIDRA: LeaveCombatBrowsing ---
		int * ServicesNamespace_TournamentsService__LeaveCombatBrowsing
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoGetHistoryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetHistoryAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7d2 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Tournaments_ProtoGetHistoryCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetHistoryAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x5AAF", Offset = "0x5AAF", VA = "0x5AAF")]
		public OpToken<IMessage, object> GetTournamentHistory(uint tournamentTypeId)
		{
		/* --- GHIDRA: GetTournamentHistory ---
		int * ServicesNamespace_TournamentsService__GetTournamentHistory(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoSubscribeCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7d3 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Tournaments_ProtoSubscribeCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,8,uVar2,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x5AB0", Offset = "0x5AB0", VA = "0x5AB0")]
		public OpToken<IMessage, object> Subscribe()
		{
		/* --- GHIDRA: Subscribe ---
		int * ServicesNamespace_TournamentsService__Subscribe(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoUnsubscribeCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7d4 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Tournaments_ProtoUnsubscribeCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,9,uVar2,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x5AB1", Offset = "0x5AB1", VA = "0x5AB1")]
		public OpToken<IMessage, object> Unsubscribe()
		{
		/* --- GHIDRA: Unsubscribe ---
		int * ServicesNamespace_TournamentsService__Unsubscribe(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoLeaveTournamentCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoLeaveTournamentAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_TypeInfo);
		    DAT_ram_00a5b7d5 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Tournaments_ProtoLeaveTournamentCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x10,uVar2,0);
		    local_8 = 0x10ffffffff;
		    local_c = Protocol_Tournaments_TournamentCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoLeaveTournamentAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x5AB2", Offset = "0x5AB2", VA = "0x5AB2")]
		public OpToken<IMessage, object> LeaveTournament()
		{
			return null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x5AB3", Offset = "0x5AB3", VA = "0x5AB3")]
		public TournamentsService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_TournamentsService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedEvt__TypeInfo);
		    DAT_ram_00a5b7c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBetChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBetChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_BetChangedEvent ---
		void ServicesNamespace_TournamentsService__add_BetChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedEvt__TypeInfo);
		    DAT_ram_00a5b7c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBetChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBetChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_BetChangedEvent ---
		void ServicesNamespace_TournamentsService__remove_BetChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    DAT_ram_00a5b7c2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: add_BetChangedOnPlayerEvent ---
		void ServicesNamespace_TournamentsService__add_BetChangedOnPlayerEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    DAT_ram_00a5b7c3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_BetChangedOnPlayerEvent ---
		void ServicesNamespace_TournamentsService__remove_BetChangedOnPlayerEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealtChangedEvt__TypeInfo);
		    DAT_ram_00a5b7c4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoHealtChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoHealtChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_HealthChangedEvent ---
		void ServicesNamespace_TournamentsService__add_HealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealtChangedEvt__TypeInfo);
		    DAT_ram_00a5b7c5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoHealtChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoHealtChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_HealthChangedEvent ---
		void ServicesNamespace_TournamentsService__remove_HealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    DAT_ram_00a5b7c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoStateChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_StateChangedEvent ---
		void ServicesNamespace_TournamentsService__add_StateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    DAT_ram_00a5b7c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoStateChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_StateChangedEvent ---
		void ServicesNamespace_TournamentsService__remove_StateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a5b7c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: add_CurrentCombatCompleteEvent ---
		void ServicesNamespace_TournamentsService__add_CurrentCombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a5b7c9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: remove_CurrentCombatCompleteEvent ---
		void ServicesNamespace_TournamentsService__remove_CurrentCombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a5b7ca = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: add_FinalCombatCompleteEvent ---
		void ServicesNamespace_TournamentsService__add_FinalCombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a5b7cb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: remove_FinalCombatCompleteEvent ---
		void ServicesNamespace_TournamentsService__remove_FinalCombatCompleteEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5b7cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_TournamentEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoBetChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoBetChangedOnPlayerEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoCurrentTnmCombatCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoFinalTnmCombatCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoHealtChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoStateChangedEvt_TypeInfo);
		    DAT_ram_00a5b7cc = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_TournamentEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Tournaments_ProtoBetChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Tournaments_ProtoBetChangedEvt_TypeInfo);
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
		       (Protocol_Tournaments_ProtoBetChangedOnPlayerEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Tournaments_ProtoBetChangedOnPlayerEvt_TypeInfo);
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
		       (Protocol_Tournaments_ProtoHealtChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Tournaments_ProtoHealtChangedEvt_TypeInfo)
		      ;
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
		       (Protocol_Tournaments_ProtoStateChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Tournaments_ProtoStateChangedEvt_TypeInfo)
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
		       (Protocol_Tournaments_ProtoCurrentTnmCombatCompleteEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Tournaments_ProtoCurrentTnmCombatCompleteEvt_TypeInfo);
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
		       (Protocol_Tournaments_ProtoFinalTnmCombatCompleteEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Tournaments_ProtoFinalTnmCombatCompleteEvt_TypeInfo);
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
