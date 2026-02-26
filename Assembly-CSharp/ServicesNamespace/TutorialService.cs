using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Tutorial;
using Protocol.World;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	public class TutorialService : AbstractService
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x170000B4")]
		public override short ServiceId
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x5ABB", Offset = "0x5ABB", VA = "0x5ABB", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x5ABC", Offset = "0x5ABC", VA = "0x5ABC")]
		public OpToken<IMessage, object> StartTutorial(string language, ClientPlatform platform)
		{
		/* --- GHIDRA: StartTutorial ---
		undefined4
		ServicesNamespace_TutorialService__StartTutorial
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoLogTutorialStepCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_TutorialService_Request_ProtoLogTutorialStepAns__ProtoLogTutorialStepCmd___
		              );
		    DAT_ram_00a5b7dc = '\x01';
		  }
		  local_8 = 0x3ffffffff;
		  local_c = Protocol_Tutorial_TutorialCommands_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  param1_00 = unnamed_function_1417(Protocol_Tutorial_ProtoLogTutorialStepCmd_TypeInfo);
		  Protocol_Tutorial_ProtoLogTutorialStepCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x10) = param3;
		  *(undefined4 *)(param1_00 + 0xc) = param2;
		  Protocol_Tutorial_ProtoLogTutorialStepCmd__get_Params(param1_00,param4,0);
		  uVar1 = ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		                    (param1,uVar1,3,param1_00,
		                     Method_ServicesNamespace_TutorialService_Request_ProtoLogTutorialStepAns__ProtoLogTutorialStepCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x5ABD", Offset = "0x5ABD", VA = "0x5ABD")]
		public OpToken<IMessage, object> LogTutorialStep(uint tutorialId, uint stepId, string parameters)
		{
		/* --- GHIDRA: LogTutorialStep ---
		undefined4 ServicesNamespace_TutorialService__LogTutorialStep(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param4;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoStartTutorialBattleCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_TutorialService_Request_ProtoDefaultAns__ProtoStartTutorialBattleCmd___
		              );
		    DAT_ram_00a5b7dd = '\x01';
		  }
		  local_8 = 0x4ffffffff;
		  local_c = Protocol_Tutorial_TutorialCommands_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  param4 = unnamed_function_1417(Protocol_Tutorial_ProtoStartTutorialBattleCmd_TypeInfo);
		  uVar1 = ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		                    (param1,uVar1,4,param4,
		                     Method_ServicesNamespace_TutorialService_Request_ProtoDefaultAns__ProtoStartTutorialBattleCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x5ABE", Offset = "0x5ABE", VA = "0x5ABE")]
		public OpToken<IMessage, object> StartTutorialBattle()
		{
		/* --- GHIDRA: StartTutorialBattle ---
		undefined4
		ServicesNamespace_TutorialService__StartTutorialBattle(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param4;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7de == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoResumeTutorialBattleCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_TutorialService_Request_ProtoResumeTutorialBattleAns__ProtoResumeTutorialBattleCmd___
		              );
		    DAT_ram_00a5b7de = '\x01';
		  }
		  local_8 = 0x5ffffffff;
		  local_c = Protocol_Tutorial_TutorialCommands_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  param4 = unnamed_function_1417(Protocol_Tutorial_ProtoResumeTutorialBattleCmd_TypeInfo);
		  uVar1 = ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		                    (param1,uVar1,5,param4,
		                     Method_ServicesNamespace_TutorialService_Request_ProtoResumeTutorialBattleAns__ProtoResumeTutorialBattleCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5ABF", Offset = "0x5ABF", VA = "0x5ABF")]
		public OpToken<IMessage, object> ResumeTutorialBattle()
		{
		/* --- GHIDRA: ResumeTutorialBattle ---
		undefined4
		ServicesNamespace_TutorialService__ResumeTutorialBattle(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param4;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7df == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoGetTutorialUserInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_TutorialService_Request_ProtoGetTutorialUserInfoAns__ProtoGetTutorialUserInfoCmd___
		              );
		    DAT_ram_00a5b7df = '\x01';
		  }
		  local_8 = 0x13ffffffff;
		  local_c = Protocol_Tutorial_TutorialCommands_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  param4 = unnamed_function_1417(Protocol_Tutorial_ProtoGetTutorialUserInfoCmd_TypeInfo);
		  uVar1 = ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		                    (param1,uVar1,0x13,param4,
		                     Method_ServicesNamespace_TutorialService_Request_ProtoGetTutorialUserInfoAns__ProtoGetTutorialUserInfoCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5AC0", Offset = "0x5AC0", VA = "0x5AC0")]
		public OpToken<IMessage, object> GetUserInfo()
		{
		/* --- GHIDRA: GetUserInfo ---
		undefined4
		ServicesNamespace_TutorialService__GetUserInfo
		          (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param4_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetUserIsleInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_TutorialService_Request_ProtoGetUserIsleInfoAns__ProtoGetUserIsleInfoCmd___
		              );
		    DAT_ram_00a5b7e0 = '\x01';
		  }
		  local_8 = 0x2ffffffff;
		  local_c = Protocol_Tutorial_TutorialCommands_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  param4_00 = unnamed_function_1417(Protocol_World_ProtoGetUserIsleInfoCmd_TypeInfo);
		  *(undefined4 *)(param4_00 + 0x18) = param3;
		  *(undefined8 *)(param4_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		                    (param1,uVar1,2,param4_00,
		                     Method_ServicesNamespace_TutorialService_Request_ProtoGetUserIsleInfoAns__ProtoGetUserIsleInfoCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5AC1", Offset = "0x5AC1", VA = "0x5AC1")]
		public OpToken<IMessage, object> GetUserIsleInfo(ulong userId, ProtoGetUserIsleInfoCmd.Types.RequestedTypeInfo flag)
		{
			return null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C3")]
		private OpToken<IMessage, object> Request<TAns>(string cmdName, TutorialCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C4")]
		private OpToken<IMessage, object> Request<TAns, TMsg>(string cmdName, TutorialCommands command, IMessage<TMsg> msg) where TAns : IMessage, new() where TMsg : IMessage<TMsg>
		{
			return null;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5AC2", Offset = "0x5AC2", VA = "0x5AC2")]
		public TutorialService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		undefined4
		ServicesNamespace_TutorialService__get_ServiceId
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7db == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoStartTutorialCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_TutorialService_Request_ProtoStartTutorialAns__ProtoStartTutorialCmd___
		              );
		    DAT_ram_00a5b7db = '\x01';
		  }
		  local_8 = 0x1ffffffff;
		  local_c = Protocol_Tutorial_TutorialCommands_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  param1_00 = unnamed_function_1417(Protocol_Tutorial_ProtoStartTutorialCmd_TypeInfo);
		  Protocol_Tutorial_ProtoStartTutorialCmd__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  Protocol_Tutorial_ProtoStartTutorialCmd__get_Language(param1_00,param2,0);
		  *(undefined4 *)(param1_00 + 0x14) = param3;
		  uVar1 = ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		                    (param1,uVar1,1,param1_00,
		                     Method_ServicesNamespace_TutorialService_Request_ProtoStartTutorialAns__ProtoStartTutorialCmd___
		                    );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Request<object> ---
		int * ServicesNamespace_TutorialService__Request_object_
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,(int)(short)param3,param4,0);
		    *(undefined4 *)(iVar1 + 0x14) = param2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    (**(code **)((ulonglong)*(uint *)**(undefined4 **)(param5 + 0x1c) * 4))
		              (iVar1,uVar2,(uint *)**(undefined4 **)(param5 + 0x1c));
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: Request<__Il2CppFullySharedGenericType> ---
		undefined4
		ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType_
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param5 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param5);
		    iVar2 = *(int *)(param5 + 0x1c);
		  }
		  uVar1 = System_Tuple__Create___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (param1,param2,param3,param4,*(undefined4 *)(iVar2 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Request<object, object> ---
		undefined4
		ServicesNamespace_TutorialService__Request_object__object_
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param5 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param5);
		    iVar2 = *(int *)(param5 + 0x1c);
		  }
		  uVar1 = (**(code **)((ulonglong)**(uint **)(iVar2 + 4) * 4))
		                    (param1,param2,param3,param4,*(uint **)(iVar2 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Request<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		undefined4
		ServicesNamespace_TutorialService__Request___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		          (int param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  undefined4 *param2_00;
		  int *param1_01;
		  
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  if (*(char *)(*(int *)(DG_Tweening_DOTween_TypeInfo + 0x5c) + 4) == '\0') {
		    (**(code **)((ulonglong)*(uint *)(param1 + 0xc) * 4))
		              (*(undefined4 *)(param1 + 0x20),param3,*(undefined4 *)(param1 + 0x14));
		    return 1;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viii
		            (*(uint *)(param1 + 0xc),*(undefined4 *)(param1 + 0x20),param3,
		             *(undefined4 *)(param1 + 0x14));
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    DAT_ram_009d3e38 = 0;
		    return 1;
		  }
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar4 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar2) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        if (iVar2 != 0) {
		          param1_01 = (int *)*puVar3;
		          import::env::__cxa_end_catch();
		          iVar4 = DG_Tweening_Core_Debugger__SetLogPriority(0);
		          if (iVar4 != 0) {
		            uVar1 = System_Exception__get_InnerException(param1_01,0);
		            param3_00 = (**(code **)((ulonglong)*(uint *)(*param1_01 + 0xe8) * 4))
		                                  (param1_01,*(undefined4 *)(*param1_01 + 0xec));
		            param1_00 = unnamed_function_2232(&StringLiteral_3070);
		            uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                              (param1_00,uVar1,param3_00,0);
		            DG_Tweening_Core_Debugger__LogError(uVar1,param2,0);
		          }
		          iVar4 = unnamed_function_2232(&DG_Tweening_DOTween_TypeInfo);
		          if (*(int *)(iVar4 + 0x74) == 0) {
		            func_ii_306000(iVar4);
		          }
		          iVar4 = unnamed_function_2232(&DG_Tweening_DOTween_TypeInfo);
		          DG_Tweening_Core_SafeModeReport__set_totUnsetErrors(*(int *)(iVar4 + 0x5c) + 0x68,2,0);
		          return 0;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x825b7b0d;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x825b7b0d:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
