using System;
using System.Collections.Generic;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Notifier;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class NotifierService : AbstractService
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x170000A6")]
		public override short ServiceId
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x59D6", Offset = "0x59D6", VA = "0x59D6", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x59D7", Offset = "0x59D7", VA = "0x59D7")]
		public OpToken<IMessage, object> GetGroups()
		{
		/* --- GHIDRA: GetGroups ---
		int * ServicesNamespace_NotifierService__GetGroups(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GroupSettings__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetGroupsCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Notifier_UpdateGroupsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11665);
		    DAT_ram_00a559e8 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Notifier_UpdateGroupsCmd_TypeInfo);
		    Protocol_Notifier_UpdateGroupsCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_GroupSettings__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,iVar1,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_11665;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_GetGroupsCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x59D8", Offset = "0x59D8", VA = "0x59D8")]
		public OpToken<IMessage, object> UpdateGroups(IEnumerable<GroupSettings> groupSettings)
		{
			return null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x59D9", Offset = "0x59D9", VA = "0x59D9")]
		public NotifierService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		int * ServicesNamespace_NotifierService__get_ServiceId(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GetGroupsCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11664);
		    DAT_ram_00a559e7 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,0,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_11664;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_GetGroupsCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

}
