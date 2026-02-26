using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Services;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public class ServicesService : AbstractService
	{
		// Token: 0x1400009A RID: 154
		// (add) Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009A")]
		public event Action<ProtoAuchanButtonBacklightEvt> AuchanBacklightChangedEvent
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x5A2E", Offset = "0x5A2E", VA = "0x5A2E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x5A2F", Offset = "0x5A2F", VA = "0x5A2F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009B")]
		public event Action<AccountInfo> AccountChangedEvent
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x5A30", Offset = "0x5A30", VA = "0x5A30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x5A31", Offset = "0x5A31", VA = "0x5A31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x06000631 RID: 1585 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009C")]
		public event Action PaymentBonusAchievedEvent
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x5A32", Offset = "0x5A32", VA = "0x5A32")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x5A33", Offset = "0x5A33", VA = "0x5A33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009D")]
		public event Action<RefPayEvt> RefPayEvent
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x5A34", Offset = "0x5A34", VA = "0x5A34")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x5A35", Offset = "0x5A35", VA = "0x5A35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009E RID: 158
		// (add) Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009E")]
		public event Action<AdTransactionClosedEvt> TransactionClosedEvent
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x5A36", Offset = "0x5A36", VA = "0x5A36")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x5A37", Offset = "0x5A37", VA = "0x5A37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400009F RID: 159
		// (add) Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400009F")]
		public event Action<ProtoPaymentRewardsChangedEvt> PaymentRewardsChangedEvent
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x5A38", Offset = "0x5A38", VA = "0x5A38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x5A39", Offset = "0x5A39", VA = "0x5A39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x170000AB")]
		public override short ServiceId
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x5A3A", Offset = "0x5A3A", VA = "0x5A3A", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x5A3B", Offset = "0x5A3B", VA = "0x5A3B", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_ServicesService__ServerEventHandler
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a42 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuySlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuySlotsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a42 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoBuySlotsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoBuySlotsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x5A3C", Offset = "0x5A3C", VA = "0x5A3C")]
		public OpToken<IMessage, object> BuyUserSlots(uint quantity)
		{
		/* --- GHIDRA: BuyUserSlots ---
		int * ServicesNamespace_ServicesService__BuyUserSlots(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a43 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a43 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,3,0,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
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

		// Token: 0x0600063C RID: 1596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x5A3D", Offset = "0x5A3D", VA = "0x5A3D")]
		public OpToken<IMessage, object> BuyNextLevel()
		{
		/* --- GHIDRA: BuyNextLevel ---
		int * ServicesNamespace_ServicesService__BuyNextLevel
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a44 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoChangeNickCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoChangeNickAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a44 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoChangeNickCmd_TypeInfo);
		    Protocol_Services_ProtoChangeNickCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Protocol_Services_ProtoChangeNickCmd__get_NewNick(iVar1,param2,0);
		    *(undefined1 *)(iVar1 + 0x10) = (undefined1)param3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,iVar1,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoChangeNickAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x5A3E", Offset = "0x5A3E", VA = "0x5A3E")]
		public OpToken<IMessage, object> ChangeNick(string nick, bool checkOnly)
		{
		/* --- GHIDRA: ChangeNick ---
		int * ServicesNamespace_ServicesService__ChangeNick
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a45 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoChangeAprCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoChangeAprAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a45 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoChangeAprCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0x10) = (undefined1)param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,6,iVar1,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoChangeAprAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x5A3F", Offset = "0x5A3F", VA = "0x5A3F")]
		public OpToken<IMessage, object> ChangeApr(uint aprId, bool checkOnly)
		{
		/* --- GHIDRA: ChangeApr ---
		int * ServicesNamespace_ServicesService__ChangeApr(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuyMedalCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyMedalAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a46 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoBuyMedalCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,8,iVar1,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyMedalAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x5A40", Offset = "0x5A40", VA = "0x5A40")]
		public OpToken<IMessage, object> BuyMedal(uint medalId)
		{
		/* --- GHIDRA: BuyMedal ---
		int * ServicesNamespace_ServicesService__BuyMedal(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a47 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoApplyMedalAprCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoApplyMedalAprAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a47 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoApplyMedalAprCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,9,iVar1,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoApplyMedalAprAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x5A41", Offset = "0x5A41", VA = "0x5A41")]
		public OpToken<IMessage, object> ApplyMedalApr(uint medalId)
		{
		/* --- GHIDRA: ApplyMedalApr ---
		int * ServicesNamespace_ServicesService__ApplyMedalApr(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a48 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoEvaluatePaymentRewardsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a48 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xf,0,0);
		    local_8 = 0xfffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEvaluatePaymentRewardsAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x5A42", Offset = "0x5A42", VA = "0x5A42")]
		public OpToken<IMessage, object> EvaluatePaymentRewards()
		{
		/* --- GHIDRA: EvaluatePaymentRewards ---
		int * ServicesNamespace_ServicesService__EvaluatePaymentRewards(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a49 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetPaymentBonusAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a49 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x11,0,0);
		    local_8 = 0x11ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetPaymentBonusAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x5A43", Offset = "0x5A43", VA = "0x5A43")]
		public OpToken<IMessage, object> GetPaymentBonus()
		{
		/* --- GHIDRA: GetPaymentBonus ---
		int * ServicesNamespace_ServicesService__GetPaymentBonus
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a4a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_OptionEntry__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_OptionEntry__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_OptionEntry__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionEntry__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetPaymentDataCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_OptionEntry__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetPaymentDataAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a4a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar2 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar2 == 0) {
		    return param1_00;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  iVar2 = unnamed_function_1417(Protocol_Services_ProtoGetPaymentDataCmd_TypeInfo);
		  Protocol_Services_ProtoGetPaymentDataCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		  *(undefined4 *)(iVar2 + 0x10) = param3;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param2,Method_System_Collections_Generic_List_OptionEntry__GetEnumerator__);
		  local_1c = 0;
		  local_18 = CONCAT44(local_18._4_4_,&local_10);
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_OptionEntry__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80bb2337;
		    }
		    if (iVar3 == 0) goto code_r0x80bb238d;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x162,*(undefined4 *)(iVar2 + 0xc),
		               local_8._4_4_,Method_Google_Protobuf_Collections_RepeatedField_OptionEntry__Add__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80bb2337:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_1c = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80bb238d:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4));
		      if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		      }
		      iVar2 = Core_Net_SrvCommand___ctor(uVar4,0x17,iVar2,0);
		      local_18 = 0x17ffffffff;
		      local_1c = Protocol_Services_ServicesCommands_TypeInfo;
		      uVar4 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		      *(undefined4 *)(iVar2 + 0x14) = uVar4;
		      uVar4 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		      System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                (uVar4,param1,*(undefined4 *)(*param1 + 0xec),0);
		      Core_Data_Spells_SpellData__Create_object_
		                (iVar2,uVar4,Method_Core_Net_SrvCommand_SetCallback_ProtoGetPaymentDataAns___);
		      Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		      return param1_00;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x163,&local_1c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar4);
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

			return null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x5A44", Offset = "0x5A44", VA = "0x5A44")]
		public OpToken<IMessage, object> GetPaymentData(List<OptionEntry> options, ProtoGetPaymentDataCmd.Types.Format format)
		{
		/* --- GHIDRA: GetPaymentData ---
		int * ServicesNamespace_ServicesService__GetPaymentData
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a4b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoDoExchangeCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a4b = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoDoExchangeCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,iVar1,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
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

		// Token: 0x06000644 RID: 1604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x5A45", Offset = "0x5A45", VA = "0x5A45")]
		public OpToken<IMessage, object> DoExchange(uint optionId)
		{
		/* --- GHIDRA: DoExchange ---
		int * ServicesNamespace_ServicesService__DoExchange(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a4c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetOptionArtikulsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetOptionArtikulsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a4c = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoGetOptionArtikulsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x16,iVar1,0);
		    local_8 = 0x16ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetOptionArtikulsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x5A46", Offset = "0x5A46", VA = "0x5A46")]
		public OpToken<IMessage, object> GetOptionArtikuls(uint optionId)
		{
		/* --- GHIDRA: GetOptionArtikuls ---
		int * ServicesNamespace_ServicesService__GetOptionArtikuls(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a4d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetActivePromotionsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a4d = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x1e,0,0);
		    local_8 = 0x1effffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetActivePromotionsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x5A47", Offset = "0x5A47", VA = "0x5A47")]
		public OpToken<IMessage, object> GetActivePromotions()
		{
		/* --- GHIDRA: GetActivePromotions ---
		int * ServicesNamespace_ServicesService__GetActivePromotions
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoRepairItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRepairItemAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a4e = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoRepairItemCmd_TypeInfo);
		    Protocol_Services_ProtoRepairItemCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,iVar1,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoRepairItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x5A48", Offset = "0x5A48", VA = "0x5A48")]
		public OpToken<IMessage, object> RepairUserItem(params uint[] slotIds)
		{
		/* --- GHIDRA: RepairUserItem ---
		int * ServicesNamespace_ServicesService__RepairUserItem
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a4f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoRestoreUserItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRestoreUserItemAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a4f = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoRestoreUserItemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x14,iVar1,0);
		    local_8 = 0x14ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoRestoreUserItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x5A49", Offset = "0x5A49", VA = "0x5A49")]
		public OpToken<IMessage, object> RestoreUserItem(uint slotId)
		{
		/* --- GHIDRA: RestoreUserItem ---
		int * ServicesNamespace_ServicesService__RestoreUserItem
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a50 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoReforgeItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoReforgeItemAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a50 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoReforgeItemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoReforgeItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x5A4A", Offset = "0x5A4A", VA = "0x5A4A")]
		public OpToken<IMessage, object> ReforgeUserItem(uint slotId)
		{
		/* --- GHIDRA: ReforgeUserItem ---
		int * ServicesNamespace_ServicesService__ReforgeUserItem(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a51 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetAccountOptionsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a51 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x1c,0,0);
		    local_8 = 0x1cffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetAccountOptionsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x5A4B", Offset = "0x5A4B", VA = "0x5A4B")]
		public OpToken<IMessage, object> GetAccountOptions()
		{
		/* --- GHIDRA: GetAccountOptions ---
		int * ServicesNamespace_ServicesService__GetAccountOptions
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuyAccountCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a52 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoBuyAccountCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,10,iVar1,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
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

		// Token: 0x0600064B RID: 1611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x5A4C", Offset = "0x5A4C", VA = "0x5A4C")]
		public OpToken<IMessage, object> BuyAccount(uint optionId)
		{
		/* --- GHIDRA: BuyAccount ---
		int * ServicesNamespace_ServicesService__BuyAccount(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a53 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetSpecialOfferAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a53 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x1a,uVar2,0);
		    local_8 = 0x1affffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetSpecialOfferAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x5A4D", Offset = "0x5A4D", VA = "0x5A4D")]
		public OpToken<IMessage, object> GetSpecialOffer()
		{
		/* --- GHIDRA: GetSpecialOffer ---
		int * ServicesNamespace_ServicesService__GetSpecialOffer
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a54 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoCancelSpecialOfferCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetSpecialOfferAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a54 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoCancelSpecialOfferCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0x10) = (undefined1)param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x1a,iVar1,0);
		    local_8 = 0x1affffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetSpecialOfferAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x5A4E", Offset = "0x5A4E", VA = "0x5A4E")]
		public OpToken<IMessage, object> CancelSpecialOffer(uint optionId, bool purchased)
		{
		/* --- GHIDRA: CancelSpecialOffer ---
		int * ServicesNamespace_ServicesService__CancelSpecialOffer(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a55 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetDiscountsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a55 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x18,0,0);
		    local_8 = 0x18ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetDiscountsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x5A4F", Offset = "0x5A4F", VA = "0x5A4F")]
		public OpToken<IMessage, object> GetDiscounts()
		{
		/* --- GHIDRA: GetDiscounts ---
		int * ServicesNamespace_ServicesService__GetDiscounts(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a56 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetAssistantsStatusAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a56 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x20,0,0);
		    local_8 = 0x20ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetAssistantsStatusAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x5A50", Offset = "0x5A50", VA = "0x5A50")]
		public OpToken<IMessage, object> GetAssistantsStatus()
		{
		/* --- GHIDRA: GetAssistantsStatus ---
		int * ServicesNamespace_ServicesService__GetAssistantsStatus
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a57 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoBuyGolemSlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyGolemSlotsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a57 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoBuyGolemSlotsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xd,iVar1,0);
		    local_8 = 0xdffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyGolemSlotsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x5A51", Offset = "0x5A51", VA = "0x5A51")]
		public OpToken<IMessage, object> BuyGolemSlots(uint quantity)
		{
		/* --- GHIDRA: BuyGolemSlots ---
		int * ServicesNamespace_ServicesService__BuyGolemSlots
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a58 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoRepairGolemItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRepairItemAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a58 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoRepairGolemItemCmd_TypeInfo);
		    Protocol_Services_ProtoRepairGolemItemCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xb,iVar1,0);
		    local_8 = 0xbffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoRepairItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x5A52", Offset = "0x5A52", VA = "0x5A52")]
		public OpToken<IMessage, object> RepairGolemItem(params uint[] slotIds)
		{
		/* --- GHIDRA: RepairGolemItem ---
		int * ServicesNamespace_ServicesService__RepairGolemItem
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a59 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoReforgeGolemItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoReforgeItemAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a59 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoReforgeGolemItemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xc,iVar1,0);
		    local_8 = 0xcffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoReforgeItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x5A53", Offset = "0x5A53", VA = "0x5A53")]
		public OpToken<IMessage, object> ReforgeGolemItem(uint slotId)
		{
		/* --- GHIDRA: ReforgeGolemItem ---
		int * ServicesNamespace_ServicesService__ReforgeGolemItem
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a5a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoRestoreGolemItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoRestoreUserItemAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a5a = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_ProtoRestoreGolemItemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x1f,iVar1,0);
		    local_8 = 0x1fffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoRestoreUserItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x5A54", Offset = "0x5A54", VA = "0x5A54")]
		public OpToken<IMessage, object> RestoreGolemItem(uint slotId)
		{
		/* --- GHIDRA: RestoreGolemItem ---
		int * ServicesNamespace_ServicesService__RestoreGolemItem(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a5b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoPayoffBanCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoPayoffBanAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a5b = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Services_ProtoPayoffBanCmd_TypeInfo);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x10,uVar2,0);
		    local_8 = 0x10ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoPayoffBanAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x5A55", Offset = "0x5A55", VA = "0x5A55")]
		public OpToken<IMessage, object> PayoffBan()
		{
		/* --- GHIDRA: PayoffBan ---
		int * ServicesNamespace_ServicesService__PayoffBan
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a5c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_GetAdPlacementsInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_GetAdPlacementsInfoCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a5c = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_GetAdPlacementsInfoCmd_TypeInfo);
		    Protocol_Services_GetAdPlacementsInfoCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x21,iVar1,0);
		    local_8 = 0x21ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_GetAdPlacementsInfoCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x5A56", Offset = "0x5A56", VA = "0x5A56")]
		public OpToken<IMessage, object> GetAdPlacementInfo(IEnumerable<uint> placementIds, uint sourceId)
		{
		/* --- GHIDRA: GetAdPlacementInfo ---
		int * ServicesNamespace_ServicesService__GetAdPlacementInfo
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a5d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_CreateAdPlacementTxCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_CreateAdPlacementTxCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a5d = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Services_CreateAdPlacementTxCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x14) = param4;
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x22,iVar1,0);
		    local_8 = 0x22ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_CreateAdPlacementTxCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x5A57", Offset = "0x5A57", VA = "0x5A57")]
		public OpToken<IMessage, object> CreateAdPlacementTx(AdPlacement placementId, uint sourceId, uint optionId)
		{
		/* --- GHIDRA: CreateAdPlacementTx ---
		int * ServicesNamespace_ServicesService__CreateAdPlacementTx
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a5e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_RejectAdPlacementTxCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_RejectAdPlacementTxCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a5e = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Services_RejectAdPlacementTxCmd_TypeInfo);
		    Protocol_Services_RejectAdPlacementTxCmd__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		    Protocol_Services_RejectAdPlacementTxCmd__get_TransactionId(uVar2,param2,0);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x23,uVar2,0);
		    local_8 = 0x23ffffffff;
		    local_c = Protocol_Services_ServicesCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_RejectAdPlacementTxCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x5A58", Offset = "0x5A58", VA = "0x5A58")]
		public OpToken<IMessage, object> RejectAdPlacement(string transactionId)
		{
		/* --- GHIDRA: RejectAdPlacement ---
		int * ServicesNamespace_ServicesService__RejectAdPlacement(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a55a5f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetEndlessPaymentOptionsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a5f = '\x01';
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
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,0x24,0,0);
		    param1_01 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (param1_01,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,param1_01,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetEndlessPaymentOptionsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x5A59", Offset = "0x5A59", VA = "0x5A59")]
		public OpToken<IMessage, object> GetEndlessPaymentOptions()
		{
		/* --- GHIDRA: GetEndlessPaymentOptions ---
		int * ServicesNamespace_ServicesService__GetEndlessPaymentOptions(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a55a60 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetNickPriceCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetNickPriceAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a60 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Services_ProtoGetNickPriceCmd_TypeInfo);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar3,0x25,uVar2,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetNickPriceAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5A5A", Offset = "0x5A5A", VA = "0x5A5A")]
		public OpToken<IMessage, object> GetNickPrice()
		{
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x5A5B", Offset = "0x5A5B", VA = "0x5A5B")]
		public ServicesService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AuchanBacklightChangedEvent ---
		void ServicesNamespace_ServicesService__add_AuchanBacklightChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a36 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAuchanButtonBacklightEvt__TypeInfo);
		    DAT_ram_00a55a36 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAuchanButtonBacklightEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAuchanButtonBacklightEvt__TypeInfo),
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


		/* --- GHIDRA: remove_AuchanBacklightChangedEvent ---
		void ServicesNamespace_ServicesService__remove_AuchanBacklightChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a37 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    DAT_ram_00a55a37 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_AccountInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AccountInfo__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_AccountChangedEvent ---
		void ServicesNamespace_ServicesService__add_AccountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a38 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    DAT_ram_00a55a38 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_AccountInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AccountInfo__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_AccountChangedEvent ---
		void ServicesNamespace_ServicesService__remove_AccountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a55a39 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a55a39 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_PaymentBonusAchievedEvent ---
		void ServicesNamespace_ServicesService__add_PaymentBonusAchievedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a55a3a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a55a3a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_PaymentBonusAchievedEvent ---
		void ServicesNamespace_ServicesService__remove_PaymentBonusAchievedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a3b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RefPayEvt__TypeInfo);
		    DAT_ram_00a55a3b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_RefPayEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_RefPayEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_RefPayEvent ---
		void ServicesNamespace_ServicesService__add_RefPayEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a3c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RefPayEvt__TypeInfo);
		    DAT_ram_00a55a3c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_RefPayEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_RefPayEvt__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_RefPayEvent ---
		void ServicesNamespace_ServicesService__remove_RefPayEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a3d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AdTransactionClosedEvt__TypeInfo);
		    DAT_ram_00a55a3d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_AdTransactionClosedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AdTransactionClosedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_TransactionClosedEvent ---
		void ServicesNamespace_ServicesService__add_TransactionClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a3e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AdTransactionClosedEvt__TypeInfo);
		    DAT_ram_00a55a3e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_AdTransactionClosedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AdTransactionClosedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_TransactionClosedEvent ---
		void ServicesNamespace_ServicesService__remove_TransactionClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a3f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo);
		    DAT_ram_00a55a3f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_PaymentRewardsChangedEvent ---
		void ServicesNamespace_ServicesService__add_PaymentRewardsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a40 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo);
		    DAT_ram_00a55a40 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoPaymentRewardsChangedEvt__TypeInfo),
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
		void ServicesNamespace_ServicesService__get_ServiceId(int param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a55a41 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ServiceEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_AccountInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdTransactionClosedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoAuchanButtonBacklightEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoPaymentRewardsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_RefPayEvt_TypeInfo);
		    DAT_ram_00a55a41 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar2,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ServiceEvents___);
		  if (iVar2 == 1) {
		    iVar2 = *(int *)(param1 + 0x18);
		    if (iVar2 != 0) {
		      piVar1 = *(int **)(param2 + 0x20);
		      if ((piVar1 != (int *)0x0) && (Protocol_Common_AccountInfo_TypeInfo != *piVar1)) {
		        System_Activator__CreateInstance(piVar1,Protocol_Common_AccountInfo_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),piVar1,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else if (iVar2 == 2) {
		    iVar2 = *(int *)(param1 + 0x1c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else if (iVar2 == 3) {
		    iVar2 = *(int *)(param1 + 0x14);
		    if (iVar2 != 0) {
		      piVar1 = *(int **)(param2 + 0x20);
		      if ((piVar1 != (int *)0x0) &&
		         (Protocol_Services_ProtoAuchanButtonBacklightEvt_TypeInfo != *piVar1)) {
		        System_Activator__CreateInstance
		                  (piVar1,Protocol_Services_ProtoAuchanButtonBacklightEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),piVar1,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else if (iVar2 == 4) {
		    iVar2 = *(int *)(param1 + 0x24);
		    if (iVar2 != 0) {
		      piVar1 = *(int **)(param2 + 0x20);
		      if ((piVar1 != (int *)0x0) && (Protocol_Services_AdTransactionClosedEvt_TypeInfo != *piVar1))
		      {
		        System_Activator__CreateInstance(piVar1,Protocol_Services_AdTransactionClosedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),piVar1,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else if (iVar2 == 5) {
		    iVar2 = *(int *)(param1 + 0x20);
		    if (iVar2 != 0) {
		      piVar1 = *(int **)(param2 + 0x20);
		      if ((piVar1 != (int *)0x0) && (Protocol_Services_RefPayEvt_TypeInfo != *piVar1)) {
		        System_Activator__CreateInstance(piVar1,Protocol_Services_RefPayEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),piVar1,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else if ((iVar2 == 6) && (iVar2 = *(int *)(param1 + 0x28), iVar2 != 0)) {
		    piVar1 = *(int **)(param2 + 0x20);
		    if ((piVar1 != (int *)0x0) &&
		       (Protocol_Services_ProtoPaymentRewardsChangedEvt_TypeInfo != *piVar1)) {
		      System_Activator__CreateInstance
		                (piVar1,Protocol_Services_ProtoPaymentRewardsChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),piVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

}
