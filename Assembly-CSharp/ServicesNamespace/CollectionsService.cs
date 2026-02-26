using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class CollectionsService : AbstractService
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x1700009A")]
		public override short ServiceId
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x58F1", Offset = "0x58F1", VA = "0x58F1", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x58F2", Offset = "0x58F2", VA = "0x58F2")]
		public OpToken<IMessage, object> GetUserCollections(ulong userId)
		{
		/* --- GHIDRA: GetUserCollections ---
		int * ServicesNamespace_CollectionsService__GetUserCollections
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6294b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_CollectionsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_ProtoImproveUserCollectionCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoImproveUserCollectionAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6294b = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Collections_ProtoImproveUserCollectionCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,2,iVar2,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Collections_CollectionsCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoImproveUserCollectionAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x58F3", Offset = "0x58F3", VA = "0x58F3")]
		public OpToken<IMessage, object> ImproveUserCollection(uint collectionId)
		{
		/* --- GHIDRA: ImproveUserCollection ---
		int * ServicesNamespace_CollectionsService__ImproveUserCollection
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6294c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_CollectionsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_ProtoBuyUserCollectionCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyUserCollectionAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6294c = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Collections_ProtoBuyUserCollectionCmd_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,3,iVar2,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Collections_CollectionsCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyUserCollectionAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x58F4", Offset = "0x58F4", VA = "0x58F4")]
		public OpToken<IMessage, object> BuyUserCollection(uint collectionId)
		{
			return null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x58F5", Offset = "0x58F5", VA = "0x58F5")]
		public CollectionsService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		int * ServicesNamespace_CollectionsService__get_ServiceId
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6294a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_CollectionsCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_ProtoGetUserCollectionsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserCollectionsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6294a = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Collections_ProtoGetUserCollectionsCmd_TypeInfo);
		    *(undefined8 *)(iVar2 + 0x10) = param2;
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,1,iVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Collections_CollectionsCommands_TypeInfo;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar3;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserCollectionsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

}
