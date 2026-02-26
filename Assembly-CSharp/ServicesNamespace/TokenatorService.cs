using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public class TokenatorService : AbstractService
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x170000B1")]
		public override short ServiceId
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x5A99", Offset = "0x5A99", VA = "0x5A99", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5A9A", Offset = "0x5A9A", VA = "0x5A9A")]
		public OpToken<IMessage, object> GenIdToken(string clientId, string scope)
		{
			return null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x5A9B", Offset = "0x5A9B", VA = "0x5A9B")]
		public TokenatorService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		int * ServicesNamespace_TokenatorService__get_ServiceId
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tokenator_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tokenator_GenIDTokenCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_GenIDTokenCmd_Types_Ans___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5b7bf = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    uVar2 = unnamed_function_1417(Protocol_Tokenator_GenIDTokenCmd_TypeInfo);
		    Protocol_Tokenator_GenIDTokenCmd__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		    Protocol_Tokenator_GenIDTokenCmd__get_ClientId(uVar2,param2,0);
		    Protocol_Tokenator_GenIDTokenCmd__get_Scope(uVar2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,1,uVar2,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Tokenator_Commands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_GenIDTokenCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

}
