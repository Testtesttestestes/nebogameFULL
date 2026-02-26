using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Fresco;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class FrescoService : AbstractService
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x170000A2")]
		public override short ServiceId
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x5983", Offset = "0x5983", VA = "0x5983", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000068")]
		public event Action<ProtoFrescoUpdatedEvt> FrescoUpdatedEvent
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x5984", Offset = "0x5984", VA = "0x5984")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x5985", Offset = "0x5985", VA = "0x5985")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000069")]
		public event Action<ProtoFrescoUniversalFragmentsChangedEvt> FrescoUniversalFragmentsChangedEvent
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x5986", Offset = "0x5986", VA = "0x5986")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x5987", Offset = "0x5987", VA = "0x5987")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x5988", Offset = "0x5988", VA = "0x5988", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_FrescoService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  
		  if (DAT_ram_00a559a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoGetUserFrescoesCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserFrescoesAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8539);
		    DAT_ram_00a559a0 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Fresco_ProtoGetUserFrescoesCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,param3,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_8539;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserFrescoesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x5989", Offset = "0x5989", VA = "0x5989")]
		public OpToken<IMessage, object> GetUserFrescoes()
		{
		/* --- GHIDRA: GetUserFrescoes ---
		int * ServicesNamespace_FrescoService__GetUserFrescoes
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoGetOtherUserFrescoesCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetOtherUserFrescoesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8511);
		    DAT_ram_00a559a1 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Fresco_ProtoGetOtherUserFrescoesCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_8511;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetOtherUserFrescoesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x598A", Offset = "0x598A", VA = "0x598A")]
		public OpToken<IMessage, object> GetOtherUserFrescoes(ulong userId)
		{
		/* --- GHIDRA: GetOtherUserFrescoes ---
		int * ServicesNamespace_FrescoService__GetOtherUserFrescoes
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoFillFrescoSlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoFillFrescoSlotsAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8052);
		    DAT_ram_00a559a2 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Fresco_ProtoFillFrescoSlotsCmd_TypeInfo);
		    Protocol_Fresco_ProtoFillFrescoSlotsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0x18),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,iVar1,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_8052;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoFillFrescoSlotsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x598B", Offset = "0x598B", VA = "0x598B")]
		public OpToken<IMessage, object> FillFrescoSlots(ulong frescoId, uint[] index)
		{
		/* --- GHIDRA: FillFrescoSlots ---
		int * ServicesNamespace_FrescoService__FillFrescoSlots
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoCompleteFrescoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoCompleteFrescoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5637);
		    DAT_ram_00a559a3 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Fresco_ProtoCompleteFrescoCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,3,iVar1,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_5637;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoCompleteFrescoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x598C", Offset = "0x598C", VA = "0x598C")]
		public OpToken<IMessage, object> CompleteFresco(ulong frescoId)
		{
		/* --- GHIDRA: CompleteFresco ---
		int * ServicesNamespace_FrescoService__CompleteFresco
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoCollectFrescoRewardCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoCollectFrescoRewardAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5534);
		    DAT_ram_00a559a4 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Fresco_ProtoCollectFrescoRewardCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,iVar1,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_5534;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoCollectFrescoRewardAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x598D", Offset = "0x598D", VA = "0x598D")]
		public OpToken<IMessage, object> CollectFrescoReward(ulong frescoId)
		{
		/* --- GHIDRA: CollectFrescoReward ---
		int * ServicesNamespace_FrescoService__CollectFrescoReward
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoInstallUniversalFragmentsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoInstallUniversalFragmentsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9417);
		    DAT_ram_00a559a5 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Fresco_ProtoInstallUniversalFragmentsCmd_TypeInfo);
		    Protocol_Fresco_ProtoInstallUniversalFragmentsCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		              (iVar1,0);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0x18),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,iVar1,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_9417;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoInstallUniversalFragmentsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x598E", Offset = "0x598E", VA = "0x598E")]
		public OpToken<IMessage, object> InstallUniversalFragments(ulong frescoId, uint[] index)
		{
		/* --- GHIDRA: InstallUniversalFragments ---
		int * ServicesNamespace_FrescoService__InstallUniversalFragments(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  
		  if (DAT_ram_00a559a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoGetUniversalFragmentsCountCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUniversalFragmentsCountAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8537);
		    DAT_ram_00a559a6 = '\x01';
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
		    param3 = unnamed_function_1417(Protocol_Fresco_ProtoGetUniversalFragmentsCountCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,6,param3,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_8537;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetUniversalFragmentsCountAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x598F", Offset = "0x598F", VA = "0x598F")]
		public OpToken<IMessage, object> GetUniversalFragmentsCount()
		{
			return null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5990", Offset = "0x5990", VA = "0x5990")]
		public FrescoService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_FrescoService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5599b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUpdatedEvt__TypeInfo);
		    DAT_ram_00a5599b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFrescoUpdatedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFrescoUpdatedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_FrescoUpdatedEvent ---
		void ServicesNamespace_FrescoService__add_FrescoUpdatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5599c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUpdatedEvt__TypeInfo);
		    DAT_ram_00a5599c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFrescoUpdatedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoFrescoUpdatedEvt__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_FrescoUpdatedEvent ---
		void ServicesNamespace_FrescoService__remove_FrescoUpdatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5599d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo);
		    DAT_ram_00a5599d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_FrescoUniversalFragmentsChangedEvent ---
		void ServicesNamespace_FrescoService__add_FrescoUniversalFragmentsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5599e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo);
		    DAT_ram_00a5599e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_FrescoUniversalFragmentsChangedEvent ---
		void ServicesNamespace_FrescoService__remove_FrescoUniversalFragmentsChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5599f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_FrescoEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoFrescoUniversalFragmentsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoFrescoUpdatedEvt_TypeInfo);
		    DAT_ram_00a5599f = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_FrescoEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Fresco_ProtoFrescoUpdatedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Fresco_ProtoFrescoUpdatedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 != 2) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x18);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Fresco_ProtoFrescoUniversalFragmentsChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Fresco_ProtoFrescoUniversalFragmentsChangedEvt_TypeInfo);
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
