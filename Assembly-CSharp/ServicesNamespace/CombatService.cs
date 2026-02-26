using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class CombatService : AbstractService, ICombatService
	{
		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004E")]
		public event Action<ProtoJumpToCombatEvt> JumpToCombatEvent
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x5918", Offset = "0x5918", VA = "0x5918", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x5919", Offset = "0x5919", VA = "0x5919", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004F")]
		public event Action<ProtoSwitchTurnEvt> SwitchTurnEvent
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x591A", Offset = "0x591A", VA = "0x591A", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x591B", Offset = "0x591B", VA = "0x591B", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000050")]
		public event Action<ProtoFieldChangedEvt> FieldChangedEvent
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x591C", Offset = "0x591C", VA = "0x591C", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x591D", Offset = "0x591D", VA = "0x591D", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000051")]
		public event Action<ProtoPlayerActionEvt> PlayersActionEvent
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x591E", Offset = "0x591E", VA = "0x591E", Slot = "13")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x591F", Offset = "0x591F", VA = "0x591F", Slot = "14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000052")]
		public event Action<ProtoCombatEventsEvt> CombatEventsEvent
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x5920", Offset = "0x5920", VA = "0x5920", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x5921", Offset = "0x5921", VA = "0x5921", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000053")]
		public event Action<ProtoCombatCompleteEvt> CombatCompleteEvent
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x5922", Offset = "0x5922", VA = "0x5922", Slot = "17")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x5923", Offset = "0x5923", VA = "0x5923", Slot = "18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000054")]
		public event Action<ProtoShowHintEvt> ShowHintEvent
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x5924", Offset = "0x5924", VA = "0x5924", Slot = "19")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x5925", Offset = "0x5925", VA = "0x5925", Slot = "20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000055")]
		public event Action<ProtoCombatTerminatedEvt> CombatTerminatedEvent
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x5926", Offset = "0x5926", VA = "0x5926", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x5927", Offset = "0x5927", VA = "0x5927", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000056")]
		public event Action<ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x5928", Offset = "0x5928", VA = "0x5928", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x5929", Offset = "0x5929", VA = "0x5929", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000057")]
		public event Action<ProtoSpellCoolDownChangedEvt> CooldownChangedEvent
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x592A", Offset = "0x592A", VA = "0x592A", Slot = "25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x592B", Offset = "0x592B", VA = "0x592B", Slot = "26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000058")]
		public event Action<ProtoSpellAppliedEvt> SpellAppliedEvent
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x592C", Offset = "0x592C", VA = "0x592C", Slot = "27")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x592D", Offset = "0x592D", VA = "0x592D", Slot = "28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000059")]
		public event Action<ProtoEffectsChangedEvt> EffectsChangedEvent
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x592E", Offset = "0x592E", VA = "0x592E", Slot = "29")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x592F", Offset = "0x592F", VA = "0x592F", Slot = "30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005A")]
		public event Action<ProtoChatEvt> ChatEventEvent
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x5930", Offset = "0x5930", VA = "0x5930", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x5931", Offset = "0x5931", VA = "0x5931", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005B")]
		public event Action<ProtoPlayerAddedEvt> PlayerAddedEvent
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x5932", Offset = "0x5932", VA = "0x5932", Slot = "33")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x5933", Offset = "0x5933", VA = "0x5933", Slot = "34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005C")]
		public event Action<ProtoDefaultUserCmd> PlayerRemovedEvent
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x5934", Offset = "0x5934", VA = "0x5934", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x5935", Offset = "0x5935", VA = "0x5935", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005D")]
		public event Action<ProtoThemeScoreChangedEvt> ThemeScoreChangedEvt
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x5936", Offset = "0x5936", VA = "0x5936", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x5937", Offset = "0x5937", VA = "0x5937", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005E")]
		public event Action<ProtoAntiqEffectTriggeredEvt> AntiqEffectTriggeredEvt
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x5938", Offset = "0x5938", VA = "0x5938", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x5939", Offset = "0x5939", VA = "0x5939", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x593A", Offset = "0x593A", VA = "0x593A")]
		public CombatService()
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x1700009C")]
		public override short ServiceId
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x593B", Offset = "0x593B", VA = "0x593B", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x593C", Offset = "0x593C", VA = "0x593C", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_CombatService__ServerEventHandler
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55960 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoRequestCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRequestCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55960 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Combat_ProtoRequestCombatCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,6,iVar1,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Combat_CombatCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
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

		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x593D", Offset = "0x593D", VA = "0x593D", Slot = "45")]
		public virtual OpToken<IMessage, object> PutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes arenaCombatType, CombatTypes combatType)
		{
		/* --- GHIDRA: PutJoinRequest ---
		int * ServicesNamespace_CombatService__PutJoinRequest(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55961 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55961 = '\x01';
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
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Combat_CombatCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x593E", Offset = "0x593E", VA = "0x593E", Slot = "46")]
		public virtual OpToken<IMessage, object> JoinToCombat()
		{
		/* --- GHIDRA: JoinToCombat ---
		int * ServicesNamespace_CombatService__JoinToCombat
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                ,undefined4 param6,undefined4 param7)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55962 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_PlayerActionTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoPlayerActionCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a55962 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Combat_ProtoPlayerActionCmd_TypeInfo);
		    Protocol_Combat_ProtoPlayerActionCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0x18) = param5;
		    *(undefined4 *)(iVar1 + 0x14) = param4;
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    Google_Protobuf_Collections_RepeatedField_ulong___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0x1c),param6,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Combat_CombatCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Combat_PlayerActionTypes_TypeInfo;
		    local_10 = param2;
		    param3_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_19176,param3_00,0);
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

		// Token: 0x06000514 RID: 1300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x593F", Offset = "0x593F", VA = "0x593F", Slot = "43")]
		public OpToken<IMessage, object> PlayerAction(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, params ulong[] targetUserIds)
		{
		/* --- GHIDRA: PlayerAction ---
		int * ServicesNamespace_CombatService__PlayerAction(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55963 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55963 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,8,0,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Combat_CombatCommands_TypeInfo;
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

		// Token: 0x06000515 RID: 1301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5940", Offset = "0x5940", VA = "0x5940", Slot = "44")]
		public OpToken<IMessage, object> RewardsGot()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_JumpToCombatEvent ---
		void ServicesNamespace_CombatService__add_JumpToCombatEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5593e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJumpToCombatEvt__TypeInfo);
		    DAT_ram_00a5593e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
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


		/* --- GHIDRA: remove_JumpToCombatEvent ---
		void ServicesNamespace_CombatService__remove_JumpToCombatEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5593f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    DAT_ram_00a5593f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSwitchTurnEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSwitchTurnEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_SwitchTurnEvent ---
		void ServicesNamespace_CombatService__add_SwitchTurnEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55940 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    DAT_ram_00a55940 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSwitchTurnEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSwitchTurnEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_SwitchTurnEvent ---
		void ServicesNamespace_CombatService__remove_SwitchTurnEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55941 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    DAT_ram_00a55941 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFieldChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFieldChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_FieldChangedEvent ---
		void ServicesNamespace_CombatService__add_FieldChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55942 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    DAT_ram_00a55942 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFieldChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFieldChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_FieldChangedEvent ---
		void ServicesNamespace_CombatService__remove_FieldChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55943 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerActionEvt__TypeInfo);
		    DAT_ram_00a55943 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPlayerActionEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPlayerActionEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_PlayersActionEvent ---
		void ServicesNamespace_CombatService__add_PlayersActionEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55944 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerActionEvt__TypeInfo);
		    DAT_ram_00a55944 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPlayerActionEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPlayerActionEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_PlayersActionEvent ---
		void ServicesNamespace_CombatService__remove_PlayersActionEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55945 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatEventsEvt__TypeInfo);
		    DAT_ram_00a55945 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatEventsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatEventsEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_CombatEventsEvent ---
		void ServicesNamespace_CombatService__add_CombatEventsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55946 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatEventsEvt__TypeInfo);
		    DAT_ram_00a55946 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatEventsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatEventsEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_CombatEventsEvent ---
		void ServicesNamespace_CombatService__remove_CombatEventsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55947 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a55947 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatCompleteEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_CombatCompleteEvent ---
		void ServicesNamespace_CombatService__add_CombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55948 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a55948 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatCompleteEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatCompleteEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_CombatCompleteEvent ---
		void ServicesNamespace_CombatService__remove_CombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55949 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoShowHintEvt__TypeInfo);
		    DAT_ram_00a55949 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoShowHintEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoShowHintEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_ShowHintEvent ---
		void ServicesNamespace_CombatService__add_ShowHintEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5594a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoShowHintEvt__TypeInfo);
		    DAT_ram_00a5594a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoShowHintEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoShowHintEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_ShowHintEvent ---
		void ServicesNamespace_CombatService__remove_ShowHintEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5594b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatTerminatedEvt__TypeInfo);
		    DAT_ram_00a5594b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatTerminatedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatTerminatedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: add_CombatTerminatedEvent ---
		void ServicesNamespace_CombatService__add_CombatTerminatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5594c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatTerminatedEvt__TypeInfo);
		    DAT_ram_00a5594c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCombatTerminatedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCombatTerminatedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: remove_CombatTerminatedEvent ---
		void ServicesNamespace_CombatService__remove_CombatTerminatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5594d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a5594d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSkillsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSkillsChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_SkillsChangedEvent ---
		void ServicesNamespace_CombatService__add_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5594e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a5594e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSkillsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSkillsChangedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_SkillsChangedEvent ---
		void ServicesNamespace_CombatService__remove_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5594f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo);
		    DAT_ram_00a5594f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_CooldownChangedEvent ---
		void ServicesNamespace_CombatService__add_CooldownChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55950 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo);
		    DAT_ram_00a55950 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_CooldownChangedEvent ---
		void ServicesNamespace_CombatService__remove_CooldownChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55951 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellAppliedEvt__TypeInfo);
		    DAT_ram_00a55951 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellAppliedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellAppliedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_SpellAppliedEvent ---
		void ServicesNamespace_CombatService__add_SpellAppliedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55952 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellAppliedEvt__TypeInfo);
		    DAT_ram_00a55952 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellAppliedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellAppliedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_SpellAppliedEvent ---
		void ServicesNamespace_CombatService__remove_SpellAppliedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55953 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoEffectsChangedEvt__TypeInfo);
		    DAT_ram_00a55953 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoEffectsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoEffectsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_EffectsChangedEvent ---
		void ServicesNamespace_CombatService__add_EffectsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55954 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoEffectsChangedEvt__TypeInfo);
		    DAT_ram_00a55954 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoEffectsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoEffectsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_EffectsChangedEvent ---
		void ServicesNamespace_CombatService__remove_EffectsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55955 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatEvt__TypeInfo);
		    DAT_ram_00a55955 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoChatEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoChatEvt__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: add_ChatEventEvent ---
		void ServicesNamespace_CombatService__add_ChatEventEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55956 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatEvt__TypeInfo);
		    DAT_ram_00a55956 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoChatEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoChatEvt__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ChatEventEvent ---
		void ServicesNamespace_CombatService__remove_ChatEventEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55957 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerAddedEvt__TypeInfo);
		    DAT_ram_00a55957 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPlayerAddedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPlayerAddedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: add_PlayerAddedEvent ---
		void ServicesNamespace_CombatService__add_PlayerAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55958 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerAddedEvt__TypeInfo);
		    DAT_ram_00a55958 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPlayerAddedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPlayerAddedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: remove_PlayerAddedEvent ---
		void ServicesNamespace_CombatService__remove_PlayerAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55959 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDefaultUserCmd__TypeInfo);
		    DAT_ram_00a55959 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoDefaultUserCmd__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoDefaultUserCmd__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: add_PlayerRemovedEvent ---
		void ServicesNamespace_CombatService__add_PlayerRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5595a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDefaultUserCmd__TypeInfo);
		    DAT_ram_00a5595a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoDefaultUserCmd__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoDefaultUserCmd__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_PlayerRemovedEvent ---
		void ServicesNamespace_CombatService__remove_PlayerRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5595b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    DAT_ram_00a5595b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoThemeScoreChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
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


		/* --- GHIDRA: add_ThemeScoreChangedEvt ---
		void ServicesNamespace_CombatService__add_ThemeScoreChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5595c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    DAT_ram_00a5595c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoThemeScoreChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ThemeScoreChangedEvt ---
		void ServicesNamespace_CombatService__remove_ThemeScoreChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5595d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo);
		    DAT_ram_00a5595d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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


		/* --- GHIDRA: add_AntiqEffectTriggeredEvt ---
		void ServicesNamespace_CombatService__add_AntiqEffectTriggeredEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5595e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo);
		    DAT_ram_00a5595e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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
		void ServicesNamespace_CombatService__get_ServiceId(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5595f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoAntiqEffectTriggeredEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoChatEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoCombatCompleteEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoCombatEventsEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoCombatTerminatedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultUserCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoEffectsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoFieldChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoJumpToCombatEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoPlayerActionEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoPlayerAddedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoShowHintEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoSkillsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoSpellAppliedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoSpellCoolDownChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoSwitchTurnEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoThemeScoreChangedEvt_TypeInfo);
		    DAT_ram_00a5595f = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoJumpToCombatEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoJumpToCombatEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 2) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoPlayerActionEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoPlayerActionEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 3) {
		    iVar1 = *(int *)(param1 + 0x18);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoSwitchTurnEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoSwitchTurnEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoFieldChangedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoFieldChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 5) {
		    iVar1 = *(int *)(param1 + 0x34);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoSkillsChangedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoSkillsChangedEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoCombatEventsEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoCombatEventsEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 7) {
		    iVar1 = *(int *)(param1 + 0x44);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoChatEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoChatEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 8) {
		    iVar1 = *(int *)(param1 + 0x2c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoShowHintEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoShowHintEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 9) {
		    iVar1 = *(int *)(param1 + 0x38);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Combat_ProtoSpellCoolDownChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Combat_ProtoSpellCoolDownChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 10) {
		    iVar1 = *(int *)(param1 + 0x40);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoEffectsChangedEvt_TypeInfo != *param1_00)
		       ) {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoEffectsChangedEvt_TypeInfo);
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
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoSpellAppliedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoSpellAppliedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 == 0xc) {
		      return;
		    }
		    if (iVar1 == 0xd) {
		      iVar1 = *(int *)(param1 + 0x48);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoPlayerAddedEvt_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoPlayerAddedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0xe) {
		      iVar1 = *(int *)(param1 + 0x4c);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Common_ProtoDefaultUserCmd_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Common_ProtoDefaultUserCmd_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0xf) {
		      iVar1 = *(int *)(param1 + 0x50);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Combat_ProtoThemeScoreChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_Combat_ProtoThemeScoreChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar1 == 0x10) {
		        return;
		      }
		      if (iVar1 == 0x11) {
		        iVar1 = *(int *)(param1 + 0x28);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) &&
		           (Protocol_Combat_ProtoCombatCompleteEvt_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance
		                    (param1_00,Protocol_Combat_ProtoCombatCompleteEvt_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      else if (iVar1 == 0x12) {
		        iVar1 = *(int *)(param1 + 0x30);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) &&
		           (Protocol_Combat_ProtoCombatTerminatedEvt_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance
		                    (param1_00,Protocol_Combat_ProtoCombatTerminatedEvt_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      else {
		        if (iVar1 != 0x13) {
		          return;
		        }
		        iVar1 = *(int *)(param1 + 0x54);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) &&
		           (Protocol_Combat_ProtoAntiqEffectTriggeredEvt_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance
		                    (param1_00,Protocol_Combat_ProtoAntiqEffectTriggeredEvt_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
