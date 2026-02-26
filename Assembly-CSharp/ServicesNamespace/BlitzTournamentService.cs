using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using Protocol.Tournaments;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class BlitzTournamentService : AbstractService
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000018")]
		public event Action<Protocol.BlitzTournaments.ProtoStateChangedEvt> StateChangedEvent
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x5826", Offset = "0x5826", VA = "0x5826")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x5827", Offset = "0x5827", VA = "0x5827")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000019")]
		public event Action<ProtoCurrentTnmCombatCompleteEvt> CurrentBattleCompleteEvent
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x5828", Offset = "0x5828", VA = "0x5828")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x5829", Offset = "0x5829", VA = "0x5829")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001A")]
		public event Action<ProtoFinalTnmCombatCompleteEvt> FinalBattleCompleteEvent
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x582A", Offset = "0x582A", VA = "0x582A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x582B", Offset = "0x582B", VA = "0x582B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001B")]
		public event Action<ProtoHealthChangedEvt> HealthChangedEvent
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x582C", Offset = "0x582C", VA = "0x582C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x582D", Offset = "0x582D", VA = "0x582D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001C")]
		public event Action<ProtoRequestCanceledEvt> JoinRequestCancelledEvent
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x582E", Offset = "0x582E", VA = "0x582E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x582F", Offset = "0x582F", VA = "0x582F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001D")]
		public event Action<ProtoFighterCountChangedEvt> FightersCountChangedEvent
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x5830", Offset = "0x5830", VA = "0x5830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x5831", Offset = "0x5831", VA = "0x5831")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x17000093")]
		public override short ServiceId
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x5832", Offset = "0x5832", VA = "0x5832", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x5833", Offset = "0x5833", VA = "0x5833", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_BlitzTournamentService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6289a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoGetTournamentInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetTournamentInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6289a = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_BlitzTournaments_ProtoGetTournamentInfoCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,1,uVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_BlitzTournaments_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetTournamentInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x5834", Offset = "0x5834", VA = "0x5834")]
		public OpToken<IMessage, object> GetTournamentInfo()
		{
		/* --- GHIDRA: GetTournamentInfo ---
		int * ServicesNamespace_BlitzTournamentService__GetTournamentInfo(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6289b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetTournamentListAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6289b = '\x01';
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
		    local_c = Protocol_BlitzTournaments_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetTournamentListAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x5835", Offset = "0x5835", VA = "0x5835")]
		public OpToken<IMessage, object> GetTournamentList()
		{
		/* --- GHIDRA: GetTournamentList ---
		int * ServicesNamespace_BlitzTournamentService__GetTournamentList
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6289c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoJoinQueueCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinQueueAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6289c = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_BlitzTournaments_ProtoJoinQueueCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,4,iVar2,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_BlitzTournaments_Commands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinQueueAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x5836", Offset = "0x5836", VA = "0x5836")]
		public OpToken<IMessage, object> JoinQueue(uint tournamentType)
		{
		/* --- GHIDRA: JoinQueue ---
		int * ServicesNamespace_BlitzTournamentService__JoinQueue(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6289d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoLeaveQueueCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoLeaveQueueAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6289d = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_BlitzTournaments_ProtoLeaveQueueCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,5,uVar2,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_BlitzTournaments_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoLeaveQueueAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x5837", Offset = "0x5837", VA = "0x5837")]
		public OpToken<IMessage, object> LeaveQueue()
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5838", Offset = "0x5838", VA = "0x5838")]
		public BlitzTournamentService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_StateChangedEvent ---
		void ServicesNamespace_BlitzTournamentService__add_StateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6288e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    DAT_ram_00a6288e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoStateChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_StateChangedEvent ---
		void ServicesNamespace_BlitzTournamentService__remove_StateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6288f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a6288f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: add_CurrentBattleCompleteEvent ---
		void ServicesNamespace_BlitzTournamentService__add_CurrentBattleCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62890 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a62890 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: remove_CurrentBattleCompleteEvent ---
		void ServicesNamespace_BlitzTournamentService__remove_CurrentBattleCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62891 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a62891 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: add_FinalBattleCompleteEvent ---
		void ServicesNamespace_BlitzTournamentService__add_FinalBattleCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62892 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a62892 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo),
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


		/* --- GHIDRA: remove_FinalBattleCompleteEvent ---
		void ServicesNamespace_BlitzTournamentService__remove_FinalBattleCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62893 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealthChangedEvt__TypeInfo);
		    DAT_ram_00a62893 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoHealthChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoHealthChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_HealthChangedEvent ---
		void ServicesNamespace_BlitzTournamentService__add_HealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62894 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealthChangedEvt__TypeInfo);
		    DAT_ram_00a62894 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoHealthChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoHealthChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_HealthChangedEvent ---
		void ServicesNamespace_BlitzTournamentService__remove_HealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62895 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRequestCanceledEvt__TypeInfo);
		    DAT_ram_00a62895 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRequestCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRequestCanceledEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: add_JoinRequestCancelledEvent ---
		void ServicesNamespace_BlitzTournamentService__add_JoinRequestCancelledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62896 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRequestCanceledEvt__TypeInfo);
		    DAT_ram_00a62896 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRequestCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRequestCanceledEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: remove_JoinRequestCancelledEvent ---
		void ServicesNamespace_BlitzTournamentService__remove_JoinRequestCancelledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62897 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFighterCountChangedEvt__TypeInfo);
		    DAT_ram_00a62897 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFighterCountChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFighterCountChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_FightersCountChangedEvent ---
		void ServicesNamespace_BlitzTournamentService__add_FightersCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62898 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFighterCountChangedEvt__TypeInfo);
		    DAT_ram_00a62898 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFighterCountChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFighterCountChangedEvt__TypeInfo),
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


		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_BlitzTournamentService__get_ServiceId
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a62899 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_BlitzTournamentEvents___)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoCurrentTnmCombatCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoFighterCountChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoFinalTnmCombatCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoHealthChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoRequestCanceledEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoStateChangedEvt_TypeInfo);
		    DAT_ram_00a62899 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_BlitzTournamentEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_BlitzTournaments_ProtoStateChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_BlitzTournaments_ProtoStateChangedEvt_TypeInfo);
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
		       (Protocol_Tournaments_ProtoCurrentTnmCombatCompleteEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Tournaments_ProtoCurrentTnmCombatCompleteEvt_TypeInfo);
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
		       (Protocol_Tournaments_ProtoFinalTnmCombatCompleteEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Tournaments_ProtoFinalTnmCombatCompleteEvt_TypeInfo);
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
		       (Protocol_BlitzTournaments_ProtoHealthChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_BlitzTournaments_ProtoHealthChangedEvt_TypeInfo);
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
		       (Protocol_BlitzTournaments_ProtoRequestCanceledEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_BlitzTournaments_ProtoRequestCanceledEvt_TypeInfo);
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
		       (Protocol_BlitzTournaments_ProtoFighterCountChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_BlitzTournaments_ProtoFighterCountChangedEvt_TypeInfo);
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
