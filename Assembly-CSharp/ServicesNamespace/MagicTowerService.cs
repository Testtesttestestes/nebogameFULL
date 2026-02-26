using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.MagicTower;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	public class MagicTowerService : AbstractService
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x170000A4")]
		public override short ServiceId
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x5995", Offset = "0x5995", VA = "0x5995", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007B")]
		public event Action<ProtoLearnSpellAcceleratedEvt> LearnSpellAcceleratedEvent
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x5996", Offset = "0x5996", VA = "0x5996")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x5997", Offset = "0x5997", VA = "0x5997")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007C")]
		public event Action<ProtoLearnSpellFinishedEvt> LearnSpellFinishedEvent
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x5998", Offset = "0x5998", VA = "0x5998")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x5999", Offset = "0x5999", VA = "0x5999")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007D")]
		public event Action<ProtoLearnSpellCanceledEvt> LearnSpellCanceledEvent
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x599A", Offset = "0x599A", VA = "0x599A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x599B", Offset = "0x599B", VA = "0x599B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007E")]
		public event Action<ProtoLearnSpellStartedEvt> LearnSpellStartedEvent
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x599C", Offset = "0x599C", VA = "0x599C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x599D", Offset = "0x599D", VA = "0x599D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007F")]
		public event Action<ProtoSpellUsedEvt> SpellUsedEvent
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x599E", Offset = "0x599E", VA = "0x599E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x599F", Offset = "0x599F", VA = "0x599F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000080")]
		public event Action<ProtoSpellActionExpiredEvt> SpellActionExpiredEvent
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x59A0", Offset = "0x59A0", VA = "0x59A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x59A1", Offset = "0x59A1", VA = "0x59A1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x59A2", Offset = "0x59A2", VA = "0x59A2", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_MagicTowerService__ServerEventHandler
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_MagicTowerCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoGetMagicTowerInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetSchoolInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559b6 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_MagicTower_ProtoGetMagicTowerInfoCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,iVar1,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_MagicTower_MagicTowerCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetSchoolInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x59A3", Offset = "0x59A3", VA = "0x59A3")]
		public OpToken<IMessage, object> GetMagicTowerInfo(ulong clanId)
		{
		/* --- GHIDRA: GetMagicTowerInfo ---
		int * ServicesNamespace_MagicTowerService__GetMagicTowerInfo
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_MagicTowerCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoStartLearnSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoStartLearnSpellAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559b7 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_MagicTower_ProtoStartLearnSpellCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_MagicTower_MagicTowerCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStartLearnSpellAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x59A4", Offset = "0x59A4", VA = "0x59A4")]
		public OpToken<IMessage, object> StartLearnSpell(uint spellId)
		{
		/* --- GHIDRA: StartLearnSpell ---
		int * ServicesNamespace_MagicTowerService__StartLearnSpell
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_MagicTowerCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoCancelLearnSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559b8 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_MagicTower_ProtoCancelLearnSpellCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,3,iVar1,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_MagicTower_MagicTowerCommands_TypeInfo;
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

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x59A5", Offset = "0x59A5", VA = "0x59A5")]
		public OpToken<IMessage, object> CancelLearnSpell(uint spellId)
		{
		/* --- GHIDRA: CancelLearnSpell ---
		int * ServicesNamespace_MagicTowerService__CancelLearnSpell
		                (int *param1,undefined4 param2,undefined8 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_MagicTowerCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoAccelerateLearnSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoAccelerateLearnSpellAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559b9 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_MagicTower_ProtoAccelerateLearnSpellCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0x18) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,iVar1,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_MagicTower_MagicTowerCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoAccelerateLearnSpellAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x59A6", Offset = "0x59A6", VA = "0x59A6")]
		public OpToken<IMessage, object> AccelerateLearnSpell(uint spellId, ulong clanId)
		{
		/* --- GHIDRA: AccelerateLearnSpell ---
		int * ServicesNamespace_MagicTowerService__AccelerateLearnSpell
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_MagicTowerCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoUseSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559ba = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_MagicTower_ProtoUseSpellCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,iVar1,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_MagicTower_MagicTowerCommands_TypeInfo;
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

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x59A7", Offset = "0x59A7", VA = "0x59A7")]
		public OpToken<IMessage, object> UseSpell(uint spellId)
		{
			return null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x59A8", Offset = "0x59A8", VA = "0x59A8")]
		public MagicTowerService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_MagicTowerService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    DAT_ram_00a559a9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellAcceleratedEvent ---
		void ServicesNamespace_MagicTowerService__add_LearnSpellAcceleratedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    DAT_ram_00a559aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellAcceleratedEvent ---
		void ServicesNamespace_MagicTowerService__remove_LearnSpellAcceleratedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    DAT_ram_00a559ab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellFinishedEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellFinishedEvent ---
		void ServicesNamespace_MagicTowerService__add_LearnSpellFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    DAT_ram_00a559ac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellFinishedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellFinishedEvent ---
		void ServicesNamespace_MagicTowerService__remove_LearnSpellFinishedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    DAT_ram_00a559ad = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellCanceledEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellCanceledEvent ---
		void ServicesNamespace_MagicTowerService__add_LearnSpellCanceledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    DAT_ram_00a559ae = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellCanceledEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellCanceledEvent ---
		void ServicesNamespace_MagicTowerService__remove_LearnSpellCanceledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    DAT_ram_00a559af = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellStartedEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellStartedEvent ---
		void ServicesNamespace_MagicTowerService__add_LearnSpellStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    DAT_ram_00a559b0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellStartedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellStartedEvent ---
		void ServicesNamespace_MagicTowerService__remove_LearnSpellStartedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellUsedEvt__TypeInfo);
		    DAT_ram_00a559b1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellUsedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellUsedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_SpellUsedEvent ---
		void ServicesNamespace_MagicTowerService__add_SpellUsedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellUsedEvt__TypeInfo);
		    DAT_ram_00a559b2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellUsedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellUsedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_SpellUsedEvent ---
		void ServicesNamespace_MagicTowerService__remove_SpellUsedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellActionExpiredEvt__TypeInfo);
		    DAT_ram_00a559b3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellActionExpiredEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellActionExpiredEvt__TypeInfo),
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


		/* --- GHIDRA: add_SpellActionExpiredEvent ---
		void ServicesNamespace_MagicTowerService__add_SpellActionExpiredEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellActionExpiredEvt__TypeInfo);
		    DAT_ram_00a559b4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSpellActionExpiredEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSpellActionExpiredEvt__TypeInfo),
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


		/* --- GHIDRA: remove_SpellActionExpiredEvent ---
		void ServicesNamespace_MagicTowerService__remove_SpellActionExpiredEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a559b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_MagicTowerEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoLearnSpellAcceleratedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoLearnSpellCanceledEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoLearnSpellFinishedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoLearnSpellStartedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoSpellActionExpiredEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoSpellUsedEvt_TypeInfo);
		    DAT_ram_00a559b5 = '\x01';
		  }
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_MagicTowerEvents___);
		  iVar2 = *(int *)(param2 + 0x10);
		  if (iVar2 != 0) {
		    if (iVar2 == 1) {
		      iVar2 = *(int *)(param1 + 0x14);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_MagicTower_ProtoLearnSpellAcceleratedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_MagicTower_ProtoLearnSpellAcceleratedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 2) {
		      iVar2 = *(int *)(param1 + 0x18);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_MagicTower_ProtoLearnSpellFinishedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_MagicTower_ProtoLearnSpellFinishedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 3) {
		      iVar2 = *(int *)(param1 + 0x1c);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_MagicTower_ProtoLearnSpellCanceledEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_MagicTower_ProtoLearnSpellCanceledEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 4) {
		      iVar2 = *(int *)(param1 + 0x20);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_MagicTower_ProtoLearnSpellStartedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_MagicTower_ProtoLearnSpellStartedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 5) {
		      iVar2 = *(int *)(param1 + 0x24);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_MagicTower_ProtoSpellUsedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_MagicTower_ProtoSpellUsedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar2 != 6) {
		        uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		        uVar1 = unnamed_function_1417(uVar1);
		        System_ArgumentNullException___ctor(uVar1,0);
		        param2_00 = unnamed_function_2232
		                              (&Method_ServicesNamespace_MagicTowerService_ServerEventHandler__);
		        func_ii_1050(uVar1,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = *(int *)(param1 + 0x28);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_MagicTower_ProtoSpellActionExpiredEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_MagicTower_ProtoSpellActionExpiredEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

}
