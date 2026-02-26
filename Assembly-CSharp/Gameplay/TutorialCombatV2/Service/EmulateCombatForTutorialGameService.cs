using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Gameplay.TutorialV2.Controller;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.TutorialCombatV2.Service
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	public class EmulateCombatForTutorialGameService : AbstractService, ICombatService
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x1700048C")]
		public override short ServiceId
		{
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x6B75", Offset = "0x6B75", VA = "0x6B75", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400011C RID: 284
		// (add) Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019DF RID: 6623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011C")]
		public event Action<ProtoJumpToCombatEvt> JumpToCombatEvent
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x6B76", Offset = "0x6B76", VA = "0x6B76", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x6B77", Offset = "0x6B77", VA = "0x6B77", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400011D RID: 285
		// (add) Token: 0x060019E0 RID: 6624 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E1 RID: 6625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011D")]
		public event Action<ProtoSwitchTurnEvt> SwitchTurnEvent
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x6B78", Offset = "0x6B78", VA = "0x6B78", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x6B79", Offset = "0x6B79", VA = "0x6B79", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400011E RID: 286
		// (add) Token: 0x060019E2 RID: 6626 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E3 RID: 6627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011E")]
		public event Action<ProtoFieldChangedEvt> FieldChangedEvent
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x6B7A", Offset = "0x6B7A", VA = "0x6B7A", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x6B7B", Offset = "0x6B7B", VA = "0x6B7B", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400011F RID: 287
		// (add) Token: 0x060019E4 RID: 6628 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E5 RID: 6629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011F")]
		public event Action<ProtoPlayerActionEvt> PlayersActionEvent
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x6B7C", Offset = "0x6B7C", VA = "0x6B7C", Slot = "13")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x6B7D", Offset = "0x6B7D", VA = "0x6B7D", Slot = "14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000120 RID: 288
		// (add) Token: 0x060019E6 RID: 6630 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E7 RID: 6631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000120")]
		public event Action<ProtoCombatEventsEvt> CombatEventsEvent
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x6B7E", Offset = "0x6B7E", VA = "0x6B7E", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x6B7F", Offset = "0x6B7F", VA = "0x6B7F", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000121 RID: 289
		// (add) Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E9 RID: 6633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000121")]
		public event Action<ProtoCombatCompleteEvt> CombatCompleteEvent
		{
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x6B80", Offset = "0x6B80", VA = "0x6B80", Slot = "17")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x6B81", Offset = "0x6B81", VA = "0x6B81", Slot = "18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000122 RID: 290
		// (add) Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000122")]
		public event Action<ProtoShowHintEvt> ShowHintEvent
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x6B82", Offset = "0x6B82", VA = "0x6B82", Slot = "19")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x6B83", Offset = "0x6B83", VA = "0x6B83", Slot = "20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000123 RID: 291
		// (add) Token: 0x060019EC RID: 6636 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019ED RID: 6637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000123")]
		public event Action<ProtoCombatTerminatedEvt> CombatTerminatedEvent
		{
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x6B84", Offset = "0x6B84", VA = "0x6B84", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x6B85", Offset = "0x6B85", VA = "0x6B85", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000124 RID: 292
		// (add) Token: 0x060019EE RID: 6638 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000124")]
		public event Action<ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x6B86", Offset = "0x6B86", VA = "0x6B86", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019EF")]
			[Address(RVA = "0x6B87", Offset = "0x6B87", VA = "0x6B87", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000125 RID: 293
		// (add) Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F1 RID: 6641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000125")]
		public event Action<ProtoSpellCoolDownChangedEvt> CooldownChangedEvent
		{
			[Token(Token = "0x60019F0")]
			[Address(RVA = "0x6B88", Offset = "0x6B88", VA = "0x6B88", Slot = "25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F1")]
			[Address(RVA = "0x6B89", Offset = "0x6B89", VA = "0x6B89", Slot = "26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000126 RID: 294
		// (add) Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F3 RID: 6643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000126")]
		public event Action<ProtoSpellAppliedEvt> SpellAppliedEvent
		{
			[Token(Token = "0x60019F2")]
			[Address(RVA = "0x6B8A", Offset = "0x6B8A", VA = "0x6B8A", Slot = "27")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F3")]
			[Address(RVA = "0x6B8B", Offset = "0x6B8B", VA = "0x6B8B", Slot = "28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000127 RID: 295
		// (add) Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000127")]
		public event Action<ProtoEffectsChangedEvt> EffectsChangedEvent
		{
			[Token(Token = "0x60019F4")]
			[Address(RVA = "0x6B8C", Offset = "0x6B8C", VA = "0x6B8C", Slot = "29")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x6B8D", Offset = "0x6B8D", VA = "0x6B8D", Slot = "30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000128 RID: 296
		// (add) Token: 0x060019F6 RID: 6646 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F7 RID: 6647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000128")]
		public event Action<ProtoChatEvt> ChatEventEvent
		{
			[Token(Token = "0x60019F6")]
			[Address(RVA = "0x6B8E", Offset = "0x6B8E", VA = "0x6B8E", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F7")]
			[Address(RVA = "0x6B8F", Offset = "0x6B8F", VA = "0x6B8F", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000129 RID: 297
		// (add) Token: 0x060019F8 RID: 6648 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F9 RID: 6649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000129")]
		public event Action<ProtoPlayerAddedEvt> PlayerAddedEvent
		{
			[Token(Token = "0x60019F8")]
			[Address(RVA = "0x6B90", Offset = "0x6B90", VA = "0x6B90", Slot = "33")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x6B91", Offset = "0x6B91", VA = "0x6B91", Slot = "34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400012A RID: 298
		// (add) Token: 0x060019FA RID: 6650 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019FB RID: 6651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012A")]
		public event Action<ProtoDefaultUserCmd> PlayerRemovedEvent
		{
			[Token(Token = "0x60019FA")]
			[Address(RVA = "0x6B92", Offset = "0x6B92", VA = "0x6B92", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019FB")]
			[Address(RVA = "0x6B93", Offset = "0x6B93", VA = "0x6B93", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400012B RID: 299
		// (add) Token: 0x060019FC RID: 6652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012B")]
		public event Action<ProtoThemeScoreChangedEvt> ThemeScoreChangedEvt
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x6B94", Offset = "0x6B94", VA = "0x6B94", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x6B95", Offset = "0x6B95", VA = "0x6B95", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400012C RID: 300
		// (add) Token: 0x060019FE RID: 6654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019FF RID: 6655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012C")]
		public event Action<ProtoAntiqEffectTriggeredEvt> AntiqEffectTriggeredEvt
		{
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x6B96", Offset = "0x6B96", VA = "0x6B96", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x6B97", Offset = "0x6B97", VA = "0x6B97", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x6B98", Offset = "0x6B98", VA = "0x6B98", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__ServerEventHandler
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58412 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoRequestCombatCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRequestCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a58412 = '\x01';
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

		// Token: 0x06001A01 RID: 6657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x6B99", Offset = "0x6B99", VA = "0x6B99", Slot = "41")]
		public OpToken<IMessage, object> PutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes arenaCombatType, CombatTypes combatType)
		{
		/* --- GHIDRA: PutJoinRequest ---
		int * Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__PutJoinRequest
		                (int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58413 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService_HandleJointCmd__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoJoinToCombatAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a58413 = '\x01';
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
		              (uVar2,param1,
		               Method_Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService_HandleJointCmd__
		               ,0);
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

		// Token: 0x06001A02 RID: 6658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x6B9A", Offset = "0x6B9A", VA = "0x6B9A", Slot = "42")]
		public OpToken<IMessage, object> JoinToCombat()
		{
		/* --- GHIDRA: JoinToCombat ---
		int * Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__JoinToCombat
		                (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		                undefined4 param5,undefined4 param6,undefined4 param7)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58414 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__Complete__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a58414 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_ProtoDefaultAns_TypeInfo);
		  Protocol_Common_ProtoDefaultAns__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_01 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x110) * 4))
		            (param1_01,*(undefined4 *)(*param1_01 + 0x114));
		  if (DAT_ram_00a58419 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75___
		              );
		    DAT_ram_00a58419 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param1;
		  local_14 = param3;
		  local_10 = param4;
		  local_c = param1_00;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_DefaultSystemDisconnectResolver__Resolve_d__7_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75___
		            );
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param1_01,param1_00,Method_Utils_OpToken_IMessage__object__Complete__);
		  return param1_01;
		}
		*/

			return null;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x6B9B", Offset = "0x6B9B", VA = "0x6B9B", Slot = "43")]
		public OpToken<IMessage, object> PlayerAction(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, params ulong[] targetUserIds)
		{
		/* --- GHIDRA: PlayerAction ---
		int * Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__PlayerAction
		                (undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a58415 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a58415 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar1 = (int *)Core_Net_AbstractService__PushCommand
		                            (param1,*(undefined4 *)
		                                     (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0x114));
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x118) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0x11c));
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x6B9C", Offset = "0x6B9C", VA = "0x6B9C", Slot = "44")]
		public OpToken<IMessage, object> RewardsGot()
		{
		/* --- GHIDRA: RewardsGot ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__RewardsGot
		               (int param1,undefined4 param2,undefined4 param3,undefined8 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58416 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StonesTypes___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_StonesTypes__TypeInfo);
		    DAT_ram_00a58416 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_StonesTypes__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (uVar2,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes___ctor__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,5,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,2,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,5,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,2,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,5,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,2,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,5,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,5,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,2,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,1,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,2,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,3,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  Google_Protobuf_Collections_RepeatedField_Int32Enum____ctor
		            (uVar2,4,Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__Add__);
		  *(undefined4 *)(param1 + 0x84) = uVar2;
		  Core_Net_AbstractService__ServerEventHandler(param1,0);
		  *(undefined4 *)(param1 + 0xc) = param2;
		  uVar2 = Core_Net_Connection_SSLConnection___c__DisplayClass15_0___Send_b__0(0);
		  Core_Net_AbstractService__get_Connection(param1,uVar2,0);
		  *(undefined8 *)(param1 + 0x68) = param4;
		  *(undefined4 *)(param1 + 0x88) = param3;
		  if (DAT_ram_00a5841d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetTurnChanges_d__79_TypeInfo
		              );
		    DAT_ram_00a5841d = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetTurnChanges_d__79_TypeInfo
		                    );
		  *(int *)(iVar3 + 0x10) = param1;
		  *(undefined4 *)(iVar3 + 8) = 0;
		  *(int *)(param1 + 0x70) = iVar3;
		  if (DAT_ram_00a5841f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetSkillChanged_d__81_TypeInfo
		              );
		    DAT_ram_00a5841f = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetSkillChanged_d__81_TypeInfo
		                    );
		  *(int *)(iVar3 + 0x10) = param1;
		  *(undefined4 *)(iVar3 + 8) = 0;
		  *(int *)(param1 + 0x74) = iVar3;
		  if (DAT_ram_00a5841e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetFieldChange_d__80_TypeInfo
		              );
		    DAT_ram_00a5841e = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetFieldChange_d__80_TypeInfo
		                    );
		  *(undefined8 *)(iVar3 + 0x10) = param4;
		  *(undefined4 *)(iVar3 + 8) = 0;
		  *(int *)(param1 + 0x78) = iVar3;
		  if (DAT_ram_00a5841c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetAvailUserSwaps_d__78_TypeInfo
		              );
		    DAT_ram_00a5841c = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetAvailUserSwaps_d__78_TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 8) = 0;
		  *(int *)(param1 + 0x7c) = iVar3;
		  if (DAT_ram_00a5841b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetOpponentSwaps_d__77_TypeInfo
		              );
		    DAT_ram_00a5841b = '\x01';
		  }
		  uVar1 = 0;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetOpponentSwaps_d__77_TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 8) = 0;
		  *(int *)(param1 + 0x80) = iVar3;
		  param1_00 = *(int **)(param1 + 0x7c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (System_Collections_IEnumerator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ee27f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,System_Collections_IEnumerator_TypeInfo,0);
		code_r0x80ee27f2:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x6B9D", Offset = "0x6B9D", VA = "0x6B9D")]
		public EmulateCombatForTutorialGameService(ProtocolCommandInfoProvider protocolInfoProvider, TutorialStepsConveyor tutorialStepsConveyor, ulong myUserId)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58417 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		    DAT_ram_00a58417 = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_uint___Clear
		                    (*(undefined4 *)(param2 + 0x1c),
		                     Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		  *(int *)(param1 + 0x5c) = param2;
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x6B9E", Offset = "0x6B9E", VA = "0x6B9E")]
		private void SetOpponentPlayer(PlayerInfo player)
		{
		/* --- GHIDRA: SetOpponentPlayer ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__SetOpponentPlayer
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58418 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		    DAT_ram_00a58418 = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_uint___Clear
		                    (*(undefined4 *)(param2 + 0x1c),
		                     Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		  *(int *)(param1 + 0x58) = param2;
		  *(undefined4 *)(param1 + 100) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x6B9F", Offset = "0x6B9F", VA = "0x6B9F")]
		private void SetMyPlayer(PlayerInfo player)
		{
		/* --- GHIDRA: SetMyPlayer ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__SetMyPlayer
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58419 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75___
		              );
		    DAT_ram_00a58419 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param1;
		  local_14 = param3;
		  local_10 = param4;
		  local_c = param6;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_DefaultSystemDisconnectResolver__Resolve_d__7_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x6BA0", Offset = "0x6BA0", VA = "0x6BA0")]
		private void PlayerActionEmulate(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, ProtoDefaultAns msg, params ulong[] targetUserIds)
		{
		/* --- GHIDRA: PlayerActionEmulate ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__PlayerActionEmulate
		               (int *param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  uint *puVar4;
		  int iVar5;
		  longlong lVar6;
		  int iVar7;
		  undefined4 param1_00;
		  int *piVar8;
		  int iVar9;
		  longlong lVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5841a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_PlayerInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__set_Item__);
		    DAT_ram_00a5841a = '\x01';
		  }
		  if ((param3 != (int *)0x0) && (Protocol_Combat_ProtoJoinToCombatAns_TypeInfo != *param3)) {
		    System_Activator__CreateInstance(param3,Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = param3[4];
		  *(undefined4 *)(iVar5 + 0x18) = 0x7fffffff;
		  iVar7 = param1[0x21];
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    iVar5 = 0;
		    do {
		      param1_00 = *(undefined4 *)(*(int *)(param3[4] + 0x28) + 0xc);
		      uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar7,iVar5,
		                         Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__get_Item__);
		      Google_Protobuf_Collections_RepeatedField_Int32Enum___get_Item
		                (param1_00,iVar5,uVar2,
		                 Method_Google_Protobuf_Collections_RepeatedField_StonesTypes__set_Item__);
		      iVar5 = iVar5 + 1;
		      iVar7 = param1[0x21];
		    } while (iVar5 < *(int *)(iVar7 + 0xc));
		    iVar5 = param3[4];
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar5 + 0x30),
		                              Method_Google_Protobuf_Collections_RepeatedField_PlayerInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80ee4ea6:
		  do {
		    piVar3 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar1 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80ee4f3e;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ee4f8a:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ee5200;
		    }
		code_r0x80ee4f3e:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar1,piVar3,puVar1[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ee4f8a;
		    if (iVar7 == 0) {
		      iVar7 = 7;
		      iVar5 = 0;
		      goto code_r0x80ee524b;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_Generic_IEnumerator_PlayerInfo__TypeInfo == *piVar8) {
		          puVar1 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80ee502f;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_PlayerInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ee51eb:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ee5200;
		    }
		code_r0x80ee502f:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar1,piVar3,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ee51eb;
		    lVar6 = *(longlong *)(param1 + 0x1a);
		    lVar10 = *(longlong *)(*(int *)(iVar7 + 0xc) + 0x10);
		    if (lVar6 == lVar10) {
		      if (DAT_ram_00a58418 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a58418 = '\x01';
		          goto code_r0x80ee50c9;
		        }
		      }
		      else {
		code_r0x80ee50c9:
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x15f,
		                           *(undefined4 *)(iVar7 + 0x1c),
		                           Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		        if (DAT_ram_009d3e38 != 1) {
		          param1[0x16] = iVar7;
		          param1[0x19] = iVar5;
		          lVar10 = *(longlong *)(*(int *)(iVar7 + 0xc) + 0x10);
		          lVar6 = *(longlong *)(param1 + 0x1a);
		          goto code_r0x80ee5127;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ee5200;
		    }
		code_r0x80ee5127:
		  } while (lVar6 == lVar10);
		  if (DAT_ram_00a58417 == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (0x7ff,&Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ee51df;
		    DAT_ram_00a58417 = '\x01';
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar5 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x15f,
		                     *(undefined4 *)(iVar7 + 0x1c),
		                     Method_Google_Protobuf_Collections_RepeatedField_PlayerSkill__Clone__);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80ee51df;
		  param1[0x17] = iVar7;
		  param1[0x18] = iVar5;
		  goto code_r0x80ee4ea6;
		code_r0x80ee51df:
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ee5200:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar5 = *piVar3;
		    iVar7 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar5;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80ee524b:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar11 = 0;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ee52c3;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ee52c3:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar5 == 0) {
		        if ((iVar7 == 0) ||
		           ((((iVar7 != 1 && (iVar7 != 2)) && (iVar7 != 3)) &&
		            (((iVar7 != 4 && (iVar7 != 5)) && ((iVar7 != 6 && (iVar7 == 7)))))))) {
		          (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,param2,param3,*(undefined4 *)(*param1 + 0xec));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x160,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x6BA1", Offset = "0x6BA1", VA = "0x6BA1")]
		private void HandleJointCmd(SrvCommand cmd, IMessage msg)
		{
		/* --- GHIDRA: HandleJointCmd ---
		int Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__HandleJointCmd
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5841b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetOpponentSwaps_d__77_TypeInfo
		              );
		    DAT_ram_00a5841b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetOpponentSwaps_d__77_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x6BA2", Offset = "0x6BA2", VA = "0x6BA2")]
		private IEnumerator<EmulateCombatForTutorialGameService.Swap> GetOpponentSwaps()
		{
		/* --- GHIDRA: GetOpponentSwaps ---
		int Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetOpponentSwaps
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5841c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetAvailUserSwaps_d__78_TypeInfo
		              );
		    DAT_ram_00a5841c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetAvailUserSwaps_d__78_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x6BA3", Offset = "0x6BA3", VA = "0x6BA3")]
		private IEnumerator<EmulateCombatForTutorialGameService.Swap> GetAvailUserSwaps()
		{
		/* --- GHIDRA: GetAvailUserSwaps ---
		int Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetAvailUserSwaps
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5841d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetTurnChanges_d__79_TypeInfo
		              );
		    DAT_ram_00a5841d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetTurnChanges_d__79_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x6BA4", Offset = "0x6BA4", VA = "0x6BA4")]
		private IEnumerator<ProtoSwitchTurnEvt> GetTurnChanges()
		{
		/* --- GHIDRA: GetTurnChanges ---
		int Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetTurnChanges
		              (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5841e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetFieldChange_d__80_TypeInfo
		              );
		    DAT_ram_00a5841e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetFieldChange_d__80_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x6BA5", Offset = "0x6BA5", VA = "0x6BA5")]
		private IEnumerator<ProtoFieldChangedEvt[]> GetFieldChange(ulong myUserId)
		{
		/* --- GHIDRA: GetFieldChange ---
		int Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetFieldChange
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5841f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetSkillChanged_d__81_TypeInfo
		              );
		    DAT_ram_00a5841f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__GetSkillChanged_d__81_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x6BA6", Offset = "0x6BA6", VA = "0x6BA6")]
		private IEnumerator<ProtoSkillsChangedEvt> GetSkillChanged()
		{
			return null;
		}

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		private const int TURN_TIMEOUT = 2147483647;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x58")]
		private PlayerInfo _myPlayer;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x5C")]
		private PlayerInfo _opponentPlayer;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x60")]
		private RepeatedField<PlayerSkill> _opponentPlayerOriginSkills;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x64")]
		private RepeatedField<PlayerSkill> _myPlayerOriginSkills;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x68")]
		private readonly ulong _myUserId;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x70")]
		private readonly IEnumerator<ProtoSwitchTurnEvt> _turns;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x74")]
		private readonly IEnumerator<ProtoSkillsChangedEvt> _skills;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x78")]
		private readonly IEnumerator<ProtoFieldChangedEvt[]> _field;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x7C")]
		private readonly IEnumerator<EmulateCombatForTutorialGameService.Swap> _availUserSwaps;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x80")]
		private readonly IEnumerator<EmulateCombatForTutorialGameService.Swap> _opponentSwaps;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x84")]
		private readonly RepeatedField<StonesTypes> _firstTimeField;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x88")]
		private TutorialStepsConveyor _conveyor;

		// Token: 0x0200044A RID: 1098
		[Token(Token = "0x200044A")]
		private class Swap
		{
			// Token: 0x06001A0F RID: 6671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x6BA7", Offset = "0x6BA7", VA = "0x6BA7")]
			public Swap(Point from, Point to)
			{
			}

			// Token: 0x04000E02 RID: 3586
			[Token(Token = "0x4000E02")]
			[FieldOffset(Offset = "0x8")]
			public readonly Point From;

			// Token: 0x04000E03 RID: 3587
			[Token(Token = "0x4000E03")]
			[FieldOffset(Offset = "0xC")]
			public readonly Point To;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJumpToCombatEvt__TypeInfo);
		    DAT_ram_00a583ef = '\x01';
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


		/* --- GHIDRA: add_JumpToCombatEvent ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_JumpToCombatEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJumpToCombatEvt__TypeInfo);
		    DAT_ram_00a583f0 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_JumpToCombatEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    DAT_ram_00a583f1 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_SwitchTurnEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    DAT_ram_00a583f2 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_SwitchTurnEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    DAT_ram_00a583f3 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_FieldChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    DAT_ram_00a583f4 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_FieldChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerActionEvt__TypeInfo);
		    DAT_ram_00a583f5 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_PlayersActionEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerActionEvt__TypeInfo);
		    DAT_ram_00a583f6 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_PlayersActionEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatEventsEvt__TypeInfo);
		    DAT_ram_00a583f7 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_CombatEventsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatEventsEvt__TypeInfo);
		    DAT_ram_00a583f8 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_CombatEventsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a583f9 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_CombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    DAT_ram_00a583fa = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_CombatCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoShowHintEvt__TypeInfo);
		    DAT_ram_00a583fb = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_ShowHintEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoShowHintEvt__TypeInfo);
		    DAT_ram_00a583fc = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_ShowHintEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatTerminatedEvt__TypeInfo);
		    DAT_ram_00a583fd = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_CombatTerminatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatTerminatedEvt__TypeInfo);
		    DAT_ram_00a583fe = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_CombatTerminatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a583ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a583ff = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58400 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a58400 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58401 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo);
		    DAT_ram_00a58401 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_CooldownChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58402 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellCoolDownChangedEvt__TypeInfo);
		    DAT_ram_00a58402 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_CooldownChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58403 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellAppliedEvt__TypeInfo);
		    DAT_ram_00a58403 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_SpellAppliedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58404 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellAppliedEvt__TypeInfo);
		    DAT_ram_00a58404 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_SpellAppliedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58405 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoEffectsChangedEvt__TypeInfo);
		    DAT_ram_00a58405 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_EffectsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58406 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoEffectsChangedEvt__TypeInfo);
		    DAT_ram_00a58406 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_EffectsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58407 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatEvt__TypeInfo);
		    DAT_ram_00a58407 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_ChatEventEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58408 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatEvt__TypeInfo);
		    DAT_ram_00a58408 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_ChatEventEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58409 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerAddedEvt__TypeInfo);
		    DAT_ram_00a58409 = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_PlayerAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5840a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerAddedEvt__TypeInfo);
		    DAT_ram_00a5840a = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_PlayerAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5840b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDefaultUserCmd__TypeInfo);
		    DAT_ram_00a5840b = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_PlayerRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5840c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDefaultUserCmd__TypeInfo);
		    DAT_ram_00a5840c = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_PlayerRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5840d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    DAT_ram_00a5840d = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_ThemeScoreChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5840e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    DAT_ram_00a5840e = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_ThemeScoreChangedEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5840f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo);
		    DAT_ram_00a5840f = '\x01';
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
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__add_AntiqEffectTriggeredEvt
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58410 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAntiqEffectTriggeredEvt__TypeInfo);
		    DAT_ram_00a58410 = '\x01';
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


		/* --- GHIDRA: remove_AntiqEffectTriggeredEvt ---
		void Gameplay_TutorialCombatV2_Service_EmulateCombatForTutorialGameService__remove_AntiqEffectTriggeredEvt
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58411 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoJumpToCombatEvt_TypeInfo);
		    DAT_ram_00a58411 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_CombatEvents___);
		  if ((iVar1 == 1) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoJumpToCombatEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoJumpToCombatEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
