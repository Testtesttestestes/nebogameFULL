using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Cave;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public class CaveService : AbstractService
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000029")]
		public event Action<ProtoGetCaveInfoAns> NewMonsterInCave
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x5865", Offset = "0x5865", VA = "0x5865")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x5866", Offset = "0x5866", VA = "0x5866")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x17000095")]
		public override short ServiceId
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x5867", Offset = "0x5867", VA = "0x5867", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x5868", Offset = "0x5868", VA = "0x5868", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		undefined4 ServicesNamespace_CaveService__ServerEventHandler(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_CaveService_CaveRequest_ProtoSearchCaveAns___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5093);
		    DAT_ram_00a628cb = '\x01';
		  }
		  uVar1 = Facebook_Unity_CallbackManager__TryCallCallback___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_5093,1,
		                     Method_ServicesNamespace_CaveService_CaveRequest_ProtoSearchCaveAns___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x5869", Offset = "0x5869", VA = "0x5869")]
		public OpToken<IMessage, object> SearchCave()
		{
		/* --- GHIDRA: SearchCave ---
		undefined4 ServicesNamespace_CaveService__SearchCave(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_CaveService_CaveRequest_ProtoGetCaveInfoAns___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5092);
		    DAT_ram_00a628cc = '\x01';
		  }
		  uVar1 = Facebook_Unity_CallbackManager__TryCallCallback___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_5092,2,
		                     Method_ServicesNamespace_CaveService_CaveRequest_ProtoGetCaveInfoAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x586A", Offset = "0x586A", VA = "0x586A")]
		public OpToken<IMessage, object> GetCaveInfo()
		{
			return null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043E")]
		private OpToken<IMessage, object> CaveRequest<TAns>(string cmdName, CaveCommands command) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x586B", Offset = "0x586B", VA = "0x586B")]
		public CaveService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_NewMonsterInCave ---
		void ServicesNamespace_CaveService__add_NewMonsterInCave
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetCaveInfoAns__TypeInfo);
		    DAT_ram_00a628c9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetCaveInfoAns__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetCaveInfoAns__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_CaveService__get_ServiceId(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a628ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_CaveEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Cave_ProtoGetCaveInfoAns_TypeInfo);
		    DAT_ram_00a628ca = '\x01';
		  }
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_CaveEvents___);
		  if (*(int *)(param2 + 0x10) != 0) {
		    if (*(int *)(param2 + 0x10) != 1) {
		      uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		      uVar1 = unnamed_function_1417(uVar1);
		      System_ArgumentNullException___ctor(uVar1,0);
		      param2_00 = unnamed_function_2232(&Method_ServicesNamespace_CaveService_ServerEventHandler__);
		      func_ii_1050(uVar1,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *(int *)(param1 + 0x14);
		    if (iVar2 != 0) {
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Cave_ProtoGetCaveInfoAns_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Cave_ProtoGetCaveInfoAns_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: CaveRequest<object> ---
		int * ServicesNamespace_CaveService__CaveRequest_object_
		                (int *param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (*(int *)(param4 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param4 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
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
		    unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,(int)(short)param3,0,0);
		    *(undefined4 *)(iVar1 + 0x14) = param2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    (**(code **)((ulonglong)*(uint *)**(undefined4 **)(param4 + 0x1c) * 4))
		              (iVar1,uVar2,(uint *)**(undefined4 **)(param4 + 0x1c));
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: CaveRequest<__Il2CppFullySharedGenericType> ---
		int * ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                (int *param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (*(int *)(param4 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param4 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,(int)(short)param2,param3,0);
		    local_8 = 0xffffffff;
		    local_c = Protocol_Chat_ChatCommands_TypeInfo;
		    local_4 = param2;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_(iVar1,uVar2,**(undefined4 **)(param4 + 0x1c));
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

}
