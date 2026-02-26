using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Auth2;
using Protocol.Consts;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public class Auth2Service : AbstractService
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x17000090")]
		public override short ServiceId
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x580F", Offset = "0x580F", VA = "0x580F", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x5810", Offset = "0x5810", VA = "0x5810")]
		public Auth2Service()
		{
		/* --- GHIDRA: .ctor ---
		void ServicesNamespace_Auth2Service___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6287c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MoveUserEvt__TypeInfo);
		    DAT_ram_00a6287c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MoveUserEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MoveUserEvt__TypeInfo), iVar2 == 0)) break;
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

		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000014")]
		public event Action<MoveUserEvt> MoveUserEvent
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x2285", Offset = "0x2285", VA = "0x2285")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x5811", Offset = "0x5811", VA = "0x5811")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x5812", Offset = "0x5812", VA = "0x5812", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_Auth2Service__ServerEventHandler
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a6287e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_GetPossibleNicksCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_GetPossibleNicksCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3444);
		    DAT_ram_00a6287e = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Auth2_GetPossibleNicksCmd_TypeInfo);
		    Protocol_Auth2_GetPossibleNicksCmd__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		    Protocol_Auth2_GetPossibleNicksCmd__get_Nick(uVar2,param2,0);
		    Protocol_Auth2_GetPossibleNicksCmd__get_Language(uVar2,param3,0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,5,uVar2,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3444,param2,0);
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_GetPossibleNicksCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x5813", Offset = "0x5813", VA = "0x5813")]
		public OpToken<IMessage, object> GetPossibleNicks(string nick, string lang)
		{
		/* --- GHIDRA: GetPossibleNicks ---
		int * ServicesNamespace_Auth2Service__GetPossibleNicks
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                ,undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a6287f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_LoginCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3443);
		    DAT_ram_00a6287f = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Auth2_LoginCmd_TypeInfo);
		    Protocol_Auth2_LoginCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		    *(undefined4 *)(iVar2 + 0x1c) = param2;
		    *(undefined4 *)(iVar2 + 0xc) = param3;
		    Protocol_Auth2_LoginCmd__get_ProviderUserId(iVar2,param4,0);
		    Protocol_Auth2_LoginCmd__get_Token(iVar2,param5,0);
		    Protocol_Auth2_LoginCmd__get_Language(iVar2,param6,0);
		    Protocol_Auth2_LoginCmd__get_Version(iVar2,param7,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,1,iVar2,0);
		    *(undefined4 *)(iVar2 + 0x14) = StringLiteral_3443;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_LoginCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5814", Offset = "0x5814", VA = "0x5814")]
		public OpToken<IMessage, object> Login(ClientPlatform platform, Provider provider, string providerUserId, string token, string languageCode, string version)
		{
		/* --- GHIDRA: Login ---
		int * ServicesNamespace_Auth2Service__Login(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62881 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_OTPCodeGetCmd_Types_Ans___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a62881 = '\x01';
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
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,3,0,0);
		    local_8 = 0x3ffffffff;
		    local_c = Protocol_Auth2_Commands_TypeInfo;
		    iVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar3 == 0) {
		      iVar3 = StringLiteral_5;
		    }
		    *(int *)(param1_00 + 0x14) = iVar3;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_OTPCodeGetCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x228B", Offset = "0x228B", VA = "0x228B")]
		public OpToken<IMessage, object> Register(Provider provider, ClientPlatform platform, string providerUserId, string token, string languageCode, string nick, uint aprId, string version, string marketingParams, string identityCode)
		{
			return null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x5815", Offset = "0x5815", VA = "0x5815")]
		public OpToken<IMessage, object> OTPCodeGet()
		{
		/* --- GHIDRA: OTPCodeGet ---
		int * ServicesNamespace_Auth2Service__OTPCodeGet(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar3;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62882 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_Commands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_OTPTokenGenCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_OTPTokenGenCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a62882 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Auth2_OTPTokenGenCmd_TypeInfo);
		    Protocol_Auth2_OTPTokenGenCmd__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		    Protocol_Auth2_OTPTokenGenCmd__get_Code(uVar2,param2,0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(param1_00,4,uVar2,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_Auth2_Commands_TypeInfo;
		    iVar3 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar3 == 0) {
		      iVar3 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar3;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_OTPTokenGenCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5816", Offset = "0x5816", VA = "0x5816")]
		public OpToken<IMessage, object> OTPTokenGen(string code)
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_MoveUserEvent ---
		void ServicesNamespace_Auth2Service__add_MoveUserEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDictionariesUpdatedEvt__TypeInfo);
		    DAT_ram_00a559c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoDictionariesUpdatedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoDictionariesUpdatedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_MoveUserEvent ---
		void ServicesNamespace_Auth2Service__remove_MoveUserEvent(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a6287d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_Events___);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_MoveUserEvt_TypeInfo);
		    DAT_ram_00a6287d = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_Events___);
		  if ((iVar1 == 2) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Auth2_MoveUserEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Auth2_MoveUserEvt_TypeInfo);
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
