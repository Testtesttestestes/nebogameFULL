using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class ClanWarsService : AbstractService
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x17000098")]
		public override short ServiceId
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x58A7", Offset = "0x58A7", VA = "0x58A7", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003C")]
		public event Action<ProtoNewWarDeclaredEvt> NewWarDeclaredEvent
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x58A8", Offset = "0x58A8", VA = "0x58A8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x58A9", Offset = "0x58A9", VA = "0x58A9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003D")]
		public event Action<ProtoWarStateChangedEvt> WarStateChanged
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x58AA", Offset = "0x58AA", VA = "0x58AA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x58AB", Offset = "0x58AB", VA = "0x58AB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003E")]
		public event Action<ProtoPlayersCountChangedEvt> PlayersCountChangedEvent
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x58AC", Offset = "0x58AC", VA = "0x58AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x58AD", Offset = "0x58AD", VA = "0x58AD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003F")]
		public event Action<ProtoClanWarCompleteEvt> ClanWarCompletedEvent
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x58AE", Offset = "0x58AE", VA = "0x58AE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x58AF", Offset = "0x58AF", VA = "0x58AF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000040")]
		public event Action<ProtoSeasonStartedEvt> SeasonStartedEvent
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x58B0", Offset = "0x58B0", VA = "0x58B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x58B1", Offset = "0x58B1", VA = "0x58B1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000041")]
		public event Action<ProtoSeasonFinishedEvt> SeasonFinishedEvent
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x58B2", Offset = "0x58B2", VA = "0x58B2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x58B3", Offset = "0x58B3", VA = "0x58B3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000042")]
		public event Action<ProtoWarModeChangedEvt> WarModeChangedEvent
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x58B4", Offset = "0x58B4", VA = "0x58B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x58B5", Offset = "0x58B5", VA = "0x58B5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x58B6", Offset = "0x58B6", VA = "0x58B6", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_ClanWarsService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62913 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetSeasonBankDistributionAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62913 = '\x01';
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
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetSeasonBankDistributionAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x58B7", Offset = "0x58B7", VA = "0x58B7")]
		public OpToken<IMessage, object> GetSeasonBankDistribution()
		{
		/* --- GHIDRA: GetSeasonBankDistribution ---
		int * ServicesNamespace_ClanWarsService__GetSeasonBankDistribution
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62914 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoRequestClanPolicyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62914 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,2,param2,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoRequestClanPolicyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x58B8", Offset = "0x58B8", VA = "0x58B8")]
		public OpToken<IMessage, object> RequestPolitics(ProtoRequestClanPolicyCmd msg)
		{
		/* --- GHIDRA: RequestPolitics ---
		int * ServicesNamespace_ClanWarsService__RequestPolitics(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62915 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetActiveWarInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62915 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0xc,0,0);
		    local_8 = 0xcffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetActiveWarInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x58B9", Offset = "0x58B9", VA = "0x58B9")]
		public OpToken<IMessage, object> GetActiveWarInfo()
		{
		/* --- GHIDRA: GetActiveWarInfo ---
		int * ServicesNamespace_ClanWarsService__GetActiveWarInfo
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62916 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoGetWarsHistoryCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetWarsHistoryAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62916 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoGetWarsHistoryCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0x10) = param3;
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,0xb,iVar2,0);
		    local_8 = 0xbffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetWarsHistoryAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x58BA", Offset = "0x58BA", VA = "0x58BA")]
		public OpToken<IMessage, object> GetWarsHistory(uint linesCount, uint previousWarId)
		{
		/* --- GHIDRA: GetWarsHistory ---
		int * ServicesNamespace_ClanWarsService__GetWarsHistory(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62917 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetCurrentSeasonInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62917 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,0xd,0,0);
		    local_8 = 0xdffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetCurrentSeasonInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x58BB", Offset = "0x58BB", VA = "0x58BB")]
		public OpToken<IMessage, object> GetCurrentSeasonInfo()
		{
		/* --- GHIDRA: GetCurrentSeasonInfo ---
		int * ServicesNamespace_ClanWarsService__GetCurrentSeasonInfo(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62918 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62918 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,6,0,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
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

			return null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x58BC", Offset = "0x58BC", VA = "0x58BC")]
		public OpToken<IMessage, object> TakeOutGolem()
		{
		/* --- GHIDRA: TakeOutGolem ---
		int * ServicesNamespace_ClanWarsService__TakeOutGolem(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62919 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoRepairGolemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62919 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoRepairGolemCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,5,uVar2,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
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

		// Token: 0x06000492 RID: 1170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x58BD", Offset = "0x58BD", VA = "0x58BD")]
		public OpToken<IMessage, object> RepairGolem()
		{
		/* --- GHIDRA: RepairGolem ---
		int * ServicesNamespace_ClanWarsService__RepairGolem
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6291a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoDeclarateWarCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDeclarateWarAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6291a = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoDeclarateWarCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,1,iVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoDeclarateWarAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x58BE", Offset = "0x58BE", VA = "0x58BE")]
		public OpToken<IMessage, object> DeclareWar(ulong clanId)
		{
		/* --- GHIDRA: DeclareWar ---
		int * ServicesNamespace_ClanWarsService__DeclareWar(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6291b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoPayOffCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6291b = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoPayOffCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,4,iVar2,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
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

		// Token: 0x06000494 RID: 1172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x58BF", Offset = "0x58BF", VA = "0x58BF")]
		public OpToken<IMessage, object> PayOff(uint warId)
		{
		/* --- GHIDRA: PayOff ---
		int * ServicesNamespace_ClanWarsService__PayOff(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6291c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoAcceleratePreparationCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoAcceleratePreparationAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6291c = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoAcceleratePreparationCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,3,iVar2,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoAcceleratePreparationAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x58C0", Offset = "0x58C0", VA = "0x58C0")]
		public OpToken<IMessage, object> AcceleratePreparation(uint warId)
		{
		/* --- GHIDRA: AcceleratePreparation ---
		int * ServicesNamespace_ClanWarsService__AcceleratePreparation
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6291d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoCancelAccelerationCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6291d = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoCancelAccelerationCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,8,iVar2,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
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

		// Token: 0x06000496 RID: 1174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x58C1", Offset = "0x58C1", VA = "0x58C1")]
		public OpToken<IMessage, object> CancelAcceleration(uint warId)
		{
		/* --- GHIDRA: CancelAcceleration ---
		int * ServicesNamespace_ClanWarsService__CancelAcceleration
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6291e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoJoinClanCombatAsViewerCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6291e = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoJoinClanCombatAsViewerCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,9,iVar2,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x58C2", Offset = "0x58C2", VA = "0x58C2")]
		public OpToken<IMessage, object> JoinCombatAsViewer(uint clanWarId)
		{
		/* --- GHIDRA: JoinCombatAsViewer ---
		int * ServicesNamespace_ClanWarsService__JoinCombatAsViewer
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6291f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoJoinClanCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinClanCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6291f = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoJoinClanCombatCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,7,iVar2,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinClanCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x58C3", Offset = "0x58C3", VA = "0x58C3")]
		public OpToken<IMessage, object> RequestClanCombat(uint clanWarId)
		{
		/* --- GHIDRA: RequestClanCombat ---
		int * ServicesNamespace_ClanWarsService__RequestClanCombat(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62920 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoUnjoinClanCombatAsViewerCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinClanCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62920 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_ClanWar_ProtoUnjoinClanCombatAsViewerCmd_TypeInfo);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,10,uVar2,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_ClanWar_ClanWarCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinClanCombatAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x58C4", Offset = "0x58C4", VA = "0x58C4")]
		public OpToken<IMessage, object> UnjoinCombatAsViewer()
		{
			return null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x58C5", Offset = "0x58C5", VA = "0x58C5")]
		public ClanWarsService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_ClanWarsService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62904 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewWarDeclaredEvt__TypeInfo);
		    DAT_ram_00a62904 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewWarDeclaredEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewWarDeclaredEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_NewWarDeclaredEvent ---
		void ServicesNamespace_ClanWarsService__add_NewWarDeclaredEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62905 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewWarDeclaredEvt__TypeInfo);
		    DAT_ram_00a62905 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewWarDeclaredEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewWarDeclaredEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_NewWarDeclaredEvent ---
		void ServicesNamespace_ClanWarsService__remove_NewWarDeclaredEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62906 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoWarStateChangedEvt__TypeInfo);
		    DAT_ram_00a62906 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoWarStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoWarStateChangedEvt__TypeInfo), iVar2 == 0)
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


		/* --- GHIDRA: add_WarStateChanged ---
		void ServicesNamespace_ClanWarsService__add_WarStateChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62907 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoWarStateChangedEvt__TypeInfo);
		    DAT_ram_00a62907 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoWarStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoWarStateChangedEvt__TypeInfo), iVar2 == 0)
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


		/* --- GHIDRA: remove_WarStateChanged ---
		void ServicesNamespace_ClanWarsService__remove_WarStateChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62908 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayersCountChangedEvt__TypeInfo);
		    DAT_ram_00a62908 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPlayersCountChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPlayersCountChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_PlayersCountChangedEvent ---
		void ServicesNamespace_ClanWarsService__add_PlayersCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62909 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayersCountChangedEvt__TypeInfo);
		    DAT_ram_00a62909 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPlayersCountChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPlayersCountChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_PlayersCountChangedEvent ---
		void ServicesNamespace_ClanWarsService__remove_PlayersCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6290a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		    DAT_ram_00a6290a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanWarCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanWarCompleteEvt__TypeInfo), iVar2 == 0)
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


		/* --- GHIDRA: add_ClanWarCompletedEvent ---
		void ServicesNamespace_ClanWarsService__add_ClanWarCompletedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6290b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		    DAT_ram_00a6290b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoClanWarCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoClanWarCompleteEvt__TypeInfo), iVar2 == 0)
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


		/* --- GHIDRA: remove_ClanWarCompletedEvent ---
		void ServicesNamespace_ClanWarsService__remove_ClanWarCompletedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6290c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSeasonStartedEvt__TypeInfo);
		    DAT_ram_00a6290c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSeasonStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSeasonStartedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_SeasonStartedEvent ---
		void ServicesNamespace_ClanWarsService__add_SeasonStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6290d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSeasonStartedEvt__TypeInfo);
		    DAT_ram_00a6290d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSeasonStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSeasonStartedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_SeasonStartedEvent ---
		void ServicesNamespace_ClanWarsService__remove_SeasonStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6290e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSeasonFinishedEvt__TypeInfo);
		    DAT_ram_00a6290e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSeasonFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSeasonFinishedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_SeasonFinishedEvent ---
		void ServicesNamespace_ClanWarsService__add_SeasonFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6290f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSeasonFinishedEvt__TypeInfo);
		    DAT_ram_00a6290f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSeasonFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSeasonFinishedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_SeasonFinishedEvent ---
		void ServicesNamespace_ClanWarsService__remove_SeasonFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62910 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoWarModeChangedEvt__TypeInfo);
		    DAT_ram_00a62910 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoWarModeChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoWarModeChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_WarModeChangedEvent ---
		void ServicesNamespace_ClanWarsService__add_WarModeChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62911 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoWarModeChangedEvt__TypeInfo);
		    DAT_ram_00a62911 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoWarModeChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoWarModeChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_WarModeChangedEvent ---
		void ServicesNamespace_ClanWarsService__remove_WarModeChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a62912 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ClanWarEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoClanWarCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoNewWarDeclaredEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoPlayersCountChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoSeasonFinishedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoSeasonStartedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoWarModeChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoWarStateChangedEvt_TypeInfo);
		    DAT_ram_00a62912 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ClanWarEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_ClanWar_ProtoNewWarDeclaredEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_ClanWar_ProtoNewWarDeclaredEvt_TypeInfo);
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
		       (Protocol_ClanWar_ProtoWarStateChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_ClanWar_ProtoWarStateChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 == 3) {
		      return;
		    }
		    if (iVar1 == 4) {
		      iVar1 = *(int *)(param1 + 0x1c);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_ClanWar_ProtoPlayersCountChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_ClanWar_ProtoPlayersCountChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 5) {
		      iVar1 = *(int *)(param1 + 0x20);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_ClanWar_ProtoClanWarCompleteEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_ClanWar_ProtoClanWarCompleteEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 6) {
		      iVar1 = *(int *)(param1 + 0x24);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_ClanWar_ProtoSeasonStartedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_ClanWar_ProtoSeasonStartedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 7) {
		      iVar1 = *(int *)(param1 + 0x28);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_ClanWar_ProtoSeasonFinishedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_ClanWar_ProtoSeasonFinishedEvt_TypeInfo)
		        ;
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar1 != 8) {
		        return;
		      }
		      iVar1 = *(int *)(param1 + 0x2c);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_ClanWar_ProtoWarModeChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_ClanWar_ProtoWarModeChangedEvt_TypeInfo)
		        ;
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
