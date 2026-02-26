using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Main;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200114E RID: 4430
	[Token(Token = "0x200114E")]
	public class ClientStateManager : IClientState, IGameManager, IBaseManager
	{
		// Token: 0x14000270 RID: 624
		// (add) Token: 0x06006858 RID: 26712 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006859 RID: 26713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000270")]
		public event ClientStateManager.ClientStateChangedDelegate OnClientStateChangedEvent
		{
			[Token(Token = "0x6006858")]
			[Address(RVA = "0xB383", Offset = "0xB383", VA = "0xB383")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006859")]
			[Address(RVA = "0xB384", Offset = "0xB384", VA = "0xB384")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001560")]
		public IGame Game
		{
			[Token(Token = "0x600685A")]
			[Address(RVA = "0xB385", Offset = "0xB385", VA = "0xB385")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600685B")]
			[Address(RVA = "0xB386", Offset = "0xB386", VA = "0xB386")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600685C")]
		[Address(RVA = "0xB387", Offset = "0xB387", VA = "0xB387")]
		public ClientStateManager(IGame game)
		{
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001561")]
		public ProtoGetClientStateAns CurrentState
		{
			[Token(Token = "0x600685D")]
			[Address(RVA = "0xB388", Offset = "0xB388", VA = "0xB388")]
			get
			{
				return null;
			}
			[Token(Token = "0x600685E")]
			[Address(RVA = "0xB389", Offset = "0xB389", VA = "0xB389")]
			set
			{
			}
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600685F")]
		[Address(RVA = "0xB38A", Offset = "0xB38A", VA = "0xB38A")]
		private void HandleInitializeComplete()
		{
		/* --- GHIDRA: HandleInitializeComplete ---
		void Core_Gameplay_Managers_ClientStateManager__HandleInitializeComplete
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a9ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateManager_HandleGetClientStateRequest__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a9ed = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__GetShortUserInfo(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ClientStateManager_HandleGetClientStateRequest__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x10),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006860")]
		[Address(RVA = "0xB38B", Offset = "0xB38B", VA = "0xB38B")]
		public void RequestClientState()
		{
		/* --- GHIDRA: RequestClientState ---
		void Core_Gameplay_Managers_ClientStateManager__RequestClientState
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a9ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_ClientStateManager_HandleGetClientStateRequestForceUpdate__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    DAT_ram_00a5a9ee = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__GetShortUserInfo(uVar1,0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2_00,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2,
		             Method_Core_Gameplay_Managers_ClientStateManager_HandleGetClientStateRequestForceUpdate__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param2 + 0x10),uVar1,0);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult(&local_8,param2_00,0);
		  *param1 = local_8;
		  return;
		}
		*/

		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x6006861")]
		[Address(RVA = "0xB38C", Offset = "0xB38C", VA = "0xB38C", Slot = "4")]
		public UniTask ForceRequestClientState()
		{
		/* --- GHIDRA: ForceRequestClientState ---
		void Core_Gameplay_Managers_ClientStateManager__ForceRequestClientState
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetClientStateAns_TypeInfo);
		    DAT_ram_00a5a9ef = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x10),param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if (param1_00 == (int *)0x0) {
		    param1_01 = *(int *)(param1 + 0xc);
		    if (param1_01 == 0) {
		      return;
		    }
		  }
		  else {
		    if (Protocol_Main_ProtoGetClientStateAns_TypeInfo != *param1_00) {
		      System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetClientStateAns_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_01 = *(int *)(param1 + 0xc);
		    if (param1_01 == 0) {
		      *(int **)(param1 + 0xc) = param1_00;
		      Core_Gameplay_Managers_ClientStateManager__set_CurrentState(param1,param1);
		      return;
		    }
		  }
		  iVar1 = Protocol_Main_ProtoGetClientStateAns__Equals(param1_01,param1_00,0);
		  if (iVar1 == 0) {
		    *(int **)(param1 + 0xc) = param1_00;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_01,param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006862")]
		[Address(RVA = "0xB38D", Offset = "0xB38D", VA = "0xB38D")]
		private void HandleGetClientStateRequest(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetClientStateRequest ---
		void Core_Gameplay_Managers_ClientStateManager__HandleGetClientStateRequest
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5a9f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetClientStateAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    DAT_ram_00a5a9f0 = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x10),param2,0);
		  piVar1 = *(int **)(param2 + 0x20);
		  if (piVar1 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0xc) = 0;
		  }
		  else {
		    if (Protocol_Main_ProtoGetClientStateAns_TypeInfo != *piVar1) {
		      System_Activator__CreateInstance(piVar1,Protocol_Main_ProtoGetClientStateAns_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int **)(param1 + 0xc) = piVar1;
		    Core_Gameplay_Managers_ClientStateManager__set_CurrentState(param1,param2);
		  }
		  piVar1 = *(int **)(param2 + 0xc);
		  if (piVar1 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar1 + 0xb8) <
		         (uint)*(byte *)(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar1 + 100) +
		                 (uint)*(byte *)(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo + 0xb8) *
		                 4 + -4) != Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar1,Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(piVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006863")]
		[Address(RVA = "0xB38E", Offset = "0xB38E", VA = "0xB38E")]
		private void HandleGetClientStateRequestForceUpdate(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetClientStateRequestForceUpdate ---
		void Core_Gameplay_Managers_ClientStateManager__HandleGetClientStateRequestForceUpdate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9f1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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

		}

		// Token: 0x14000271 RID: 625
		// (add) Token: 0x06006864 RID: 26724 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006865 RID: 26725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000271")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006864")]
			[Address(RVA = "0xB38F", Offset = "0xB38F", VA = "0xB38F", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006865")]
			[Address(RVA = "0xB390", Offset = "0xB390", VA = "0xB390", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000272 RID: 626
		// (add) Token: 0x06006866 RID: 26726 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006867 RID: 26727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000272")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006866")]
			[Address(RVA = "0xB391", Offset = "0xB391", VA = "0xB391", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006867")]
			[Address(RVA = "0xB392", Offset = "0xB392", VA = "0xB392", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001562")]
		public string Name
		{
			[Token(Token = "0x6006868")]
			[Address(RVA = "0xB393", Offset = "0xB393", VA = "0xB393", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006869")]
		[Address(RVA = "0xB394", Offset = "0xB394", VA = "0xB394", Slot = "9")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ClientStateManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a9f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a9f6 = '\x01';
		  }
		  Utils_OpToken__Cancel(*(undefined4 *)(param1 + 0x10),0);
		  *(undefined8 *)(param1 + 0xc) = 0;
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x812a723e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812a723e:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x812a72c0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xc);
		code_r0x812a72c0:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x28);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x812a7341;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,5)
		  ;
		code_r0x812a7341:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,0,puVar2[1]);
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar4 = *(int *)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		            (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686A")]
		[Address(RVA = "0xB395", Offset = "0xB395", VA = "0xB395", Slot = "10")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ClientStateManager__Deinit
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x54;
		    }
		    else {
		      if (param2 == 0) {
		        uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x53;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x55;
		  return;
		}
		*/

		}

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0xC")]
		private ProtoGetClientStateAns _currentState;

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x10")]
		private OpTokenRepository _tokenRepository;

		// Token: 0x0200114F RID: 4431
		// (Invoke) Token: 0x0600686C RID: 26732
		[Token(Token = "0x200114F")]
		public delegate void ClientStateChangedDelegate(ProtoGetClientStateAns fromState, ProtoGetClientStateAns toState);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnClientStateChangedEvent ---
		void Core_Gameplay_Managers_ClientStateManager__add_OnClientStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a9ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		    DAT_ram_00a5a9ea = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo ==
		          *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo
		            );
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Core_Gameplay_Managers_ClientStateManager__set_Game
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a9eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a5a9eb = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param2;
		  param1_00 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: get_CurrentState ---
		void Core_Gameplay_Managers_ClientStateManager__get_CurrentState
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0xc);
		  if (param1_00 == 0) {
		    if (param2 != 0) {
		      *(int *)(param1 + 0xc) = param2;
		      Core_Gameplay_Managers_ClientStateManager__set_CurrentState(param1,param1);
		      return;
		    }
		  }
		  else {
		    iVar1 = Protocol_Main_ProtoGetClientStateAns__Equals(param1_00,param2,0);
		    if (iVar1 == 0) {
		      *(int *)(param1 + 0xc) = param2;
		      iVar1 = *(int *)(param1 + 8);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param1_00,param2,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentState ---
		void Core_Gameplay_Managers_ClientStateManager__set_CurrentState(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a9ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a9ec = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x812a6ae0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812a6ae0:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x812a6b62;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xc);
		code_r0x812a6b62:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x28);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x812a6be3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,5)
		  ;
		code_r0x812a6be3:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1,puVar2[1]);
		  iVar4 = *(int *)(param1 + 0x18);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ClientStateManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_ClientStateManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_ClientStateManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		undefined4
		Core_Gameplay_Managers_ClientStateManager__remove_DeinitCompleteEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5486);
		    DAT_ram_00a5a9f5 = '\x01';
		  }
		  return StringLiteral_5486;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ClientStateManager__get_Name(undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_ClientStateManager__HandleInitializeComplete(param1,param1);
		  return;
		}
		*/

}
