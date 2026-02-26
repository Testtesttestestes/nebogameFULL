using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace Core.Application.Managers
{
	// Token: 0x0200124C RID: 4684
	[Token(Token = "0x200124C")]
	public class AppBuildInfoManager : IAppManager, IBaseManager, IClientVersionProvider
	{
		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016AB")]
		public string Name
		{
			[Token(Token = "0x6006EF6")]
			[Address(RVA = "0xB973", Offset = "0xB973", VA = "0xB973", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002E4 RID: 740
		// (add) Token: 0x06006EF7 RID: 28407 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EF8 RID: 28408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006EF7")]
			[Address(RVA = "0xB974", Offset = "0xB974", VA = "0xB974", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EF8")]
			[Address(RVA = "0xB975", Offset = "0xB975", VA = "0xB975", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E5 RID: 741
		// (add) Token: 0x06006EF9 RID: 28409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EFA RID: 28410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006EF9")]
			[Address(RVA = "0xB976", Offset = "0xB976", VA = "0xB976", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EFA")]
			[Address(RVA = "0xB977", Offset = "0xB977", VA = "0xB977", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006EFB")]
		[Address(RVA = "0x228A", Offset = "0x228A", VA = "0x228A", Slot = "11")]
		public string GetVersion()
		{
		/* --- GHIDRA: GetVersion ---
		int * Core_Application_Managers_AppBuildInfoManager__GetVersion
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                ,undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9,
		                undefined4 param10,undefined4 param11,undefined4 param12)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a62880 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_RegisterCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_RegisterCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3445);
		    DAT_ram_00a62880 = '\x01';
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
		    iVar2 = unnamed_function_1417(Protocol_Auth2_RegisterCmd_TypeInfo);
		    Protocol_Auth2_RegisterCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		    *(undefined4 *)(iVar2 + 0x1c) = param3;
		    *(undefined4 *)(iVar2 + 0xc) = param2;
		    Protocol_Auth2_RegisterCmd__get_ProviderUserId(iVar2,param4,0);
		    Protocol_Auth2_RegisterCmd__get_Token(iVar2,param5,0);
		    Protocol_Auth2_RegisterCmd__get_Language(iVar2,param6,0);
		    Protocol_Auth2_RegisterCmd__get_Version(iVar2,param9,0);
		    Protocol_Auth2_RegisterCmd__get_Nick(iVar2,param7,0);
		    *(undefined4 *)(iVar2 + 0x28) = param8;
		    Protocol_Auth2_RegisterCmd__get_Params(iVar2,param10,0);
		    Protocol_Auth2_RegisterCmd__get_IdentityCode(iVar2,param11,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar2 = Core_Net_SrvCommand___ctor(uVar3,2,iVar2,0);
		    *(undefined4 *)(iVar2 + 0x14) = StringLiteral_3445;
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_RegisterCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFC")]
		[Address(RVA = "0xB978", Offset = "0xB978", VA = "0xB978", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0xB979", Offset = "0xB979", VA = "0xB979", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0xB97A", Offset = "0xB97A", VA = "0xB97A")]
		public AppBuildInfoManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Application_Managers_AppBuildInfoManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a815 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_6421);
		    DAT_ram_00a5a815 = '\x01';
		  }
		  return StringLiteral_6421;
		}
		*/

		}

		// Token: 0x04003A02 RID: 14850
		[Token(Token = "0x4003A02")]
		[FieldOffset(Offset = "0x10")]
		private AppBuildInfo _appBuildInfo;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Application_Managers_AppBuildInfoManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a810 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a810 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_AppBuildInfoManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a811 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a811 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Application_Managers_AppBuildInfoManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a812 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a812 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Application_Managers_AppBuildInfoManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a813 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a813 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Application_Managers_AppBuildInfoManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5a814 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Resources_Load_AppBuildInfo___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17754);
		    DAT_ram_00a5a814 = '\x01';
		  }
		  uVar1 = Core_ProtocolMessageFactoriesRepository___ctor(0);
		  iVar2 = UnityEngine_Resources__GetBuiltinResource_object_
		                    (uVar1,Method_UnityEngine_Resources_Load_AppBuildInfo___);
		  *(int *)(param1 + 0x10) = iVar2;
		  if (iVar2 == 0) {
		    uVar1 = Utils_AppBuildInfo__GetValues(0);
		  }
		  else {
		    iVar2 = **(int **)(param1 + 0x10);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xd8) * 4))
		                      (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xdc));
		  }
		  uVar3 = System_String__CreateString(0,0x3d,0x19,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_17754,uVar1,0);
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  uVar3 = System_String__CreateString(0,0x3d,0x19,0);
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(uVar3,param1);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		    iVar2 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x18) + 0x20);
		  iVar2 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

}
