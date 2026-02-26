using System;
using System.Runtime.CompilerServices;
using Core.Net.Connection;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;
using UI.Informer;
using UI.Windows;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001263 RID: 4707
	[Token(Token = "0x2001263")]
	public class ConnectionInformer : IDisposable
	{
		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06006F91 RID: 28561 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F92 RID: 28562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C4")]
		public ISystemDisconnectResolver DisconnectResolver
		{
			[Token(Token = "0x6006F91")]
			[Address(RVA = "0xB9F2", Offset = "0xB9F2", VA = "0xB9F2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F92")]
			[Address(RVA = "0xB9F3", Offset = "0xB9F3", VA = "0xB9F3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0xB9F4", Offset = "0xB9F4", VA = "0xB9F4", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: <ShowServerMaintenanceWindow>b__20_0 ---
		void Core_Application_Managers_Connection_ConnectionInformer___ShowServerMaintenanceWindow_b__20_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a865 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a865 = '\x01';
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

		/* --- GHIDRA: <TryNotifyServerReadyToStop>b__14_0 ---
		void Core_Application_Managers_Connection_ConnectionInformer___TryNotifyServerReadyToStop_b__14_0
		               (int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x20) = 0x7fc00000;
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Core_Application_Managers_Connection_ConnectionInformer__Dispose
		               (int param1,float param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 0x7fc00000;
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(float *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 8) = param5;
		  return;
		}
		*/

		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0xB9F5", Offset = "0xB9F5", VA = "0xB9F5")]
		public ConnectionInformer(float connectTimeoutToWarning, InformerView appCanvasInformerView, ILowResponseAbilityMonitor lowResponseAbilityMonitor, ISystemDisconnectResolver disconnectResolver)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Connection_ConnectionInformer___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  float fVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a862 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ResponseAbilityStatus__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionInformer_HandleResponseAbilityChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionInformer_HandleResponseTimeExceededEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_AbstractConnection_ErrorCodes_var);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo);
		    DAT_ram_00a5a862 = '\x01';
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (*(int *)(param2 + 8) != 0) {
		    if (*(int *)(param2 + 8) != 1) {
		      return;
		    }
		    piVar5 = *(int **)(param1 + 0x14);
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_ResponseAbilityStatus__TypeInfo);
		    System_Action_int___Invoke
		              (uVar3,param1,
		               Method_Core_Application_Managers_Connection_ConnectionInformer_HandleResponseAbilityChangedEvent__
		               ,0);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x812801c5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,
		                                  Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo
		                                  ,0);
		code_r0x812801c5:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar3,puVar2[1]);
		    piVar5 = *(int **)(param1 + 0x14);
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Core_Application_Managers_Connection_ConnectionInformer_HandleResponseTimeExceededEvent__
		               ,0);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x81280267;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,
		                                  Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo
		                                  ,2);
		code_r0x81280267:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar3,puVar2[1]);
		    *(undefined4 *)(param1 + 0x20) = 0x7fc00000;
		    if (*(int *)(param1 + 0x24) == 0) {
		      return;
		    }
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(int *)(param1 + 0x24),0,0);
		    return;
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(param1 + 8);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81280307;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo
		                                ,3);
		code_r0x81280307:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Core_Net_Connection_AbstractConnection_ErrorCodes_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0xc) + 0x10);
		  param2_00 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar6 = System_Enum__InternalGetNames(uVar3,param2_00,0);
		  if (iVar6 == 0) {
		    if (0x7f800000 < (*(uint *)(param1 + 0x20) & 0x7fffffff)) {
		      fVar4 = UnityEngine_SystemClock___cctor(0);
		      *(float *)(param1 + 0x20) = fVar4 + *(float *)(param1 + 0xc);
		    }
		    fVar4 = UnityEngine_SystemClock___cctor(0);
		    if (fVar4 <= *(float *)(param1 + 0x20)) goto code_r0x812803cc;
		  }
		  Core_Application_Managers_Connection_ConnectionInformer__set__awaitToWarningExpireTime
		            (param1,uVar3);
		code_r0x812803cc:
		  piVar5 = *(int **)(param1 + 0x14);
		  uVar1 = 0;
		  uVar3 = unnamed_function_1417(System_Action_ResponseAbilityStatus__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Application_Managers_Connection_ConnectionInformer_HandleResponseAbilityChangedEvent__
		             ,0);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x81280461;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo
		                                ,1);
		code_r0x81280461:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar3,puVar2[1]);
		  piVar5 = *(int **)(param1 + 0x14);
		  uVar1 = 0;
		  uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar3,param1,
		             Method_Core_Application_Managers_Connection_ConnectionInformer_HandleResponseTimeExceededEvent__
		             ,0);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81280503;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo
		                                ,3);
		code_r0x81280503:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar3,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F95")]
		[Address(RVA = "0xB9F6", Offset = "0xB9F6", VA = "0xB9F6")]
		public void SetState(ConnectionState state)
		{
		/* --- GHIDRA: SetState ---
		void Core_Application_Managers_Connection_ConnectionInformer__SetState
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Informer_InformerView___ctor(*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F96")]
		[Address(RVA = "0xB9F7", Offset = "0xB9F7", VA = "0xB9F7")]
		private void HandleResponseAbilityChangedEvent(ResponseAbilityStatus status)
		{
		/* --- GHIDRA: HandleResponseAbilityChangedEvent ---
		void Core_Application_Managers_Connection_ConnectionInformer__HandleResponseAbilityChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F97")]
		[Address(RVA = "0xB9F8", Offset = "0xB9F8", VA = "0xB9F8")]
		private void HandleResponseTimeExceededEvent(bool value)
		{
		/* --- GHIDRA: HandleResponseTimeExceededEvent ---
		uint Core_Application_Managers_Connection_ConnectionInformer__HandleResponseTimeExceededEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a863 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionInformer__TryNotifyServerReadyToStop_b__14_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13784);
		    DAT_ram_00a5a863 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (uVar1 == 0) {
		    param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(param1_00,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13784,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		    uVar2 = UI_Windows_UnityInstantiator___ctor(param1_00,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar2;
		    param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_01,param1,
		               Method_Core_Application_Managers_Connection_ConnectionInformer__TryNotifyServerReadyToStop_b__14_0__
		               ,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar2,param1_01,0);
		  }
		  return uVar1 ^ 1;
		}
		*/

		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x000144C0 File Offset: 0x000126C0
		[Token(Token = "0x6006F98")]
		[Address(RVA = "0xB9F9", Offset = "0xB9F9", VA = "0xB9F9")]
		public bool TryNotifyServerReadyToStop()
		{
			return default(bool);
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x000144D8 File Offset: 0x000126D8
		// (set) Token: 0x06006F9A RID: 28570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C5")]
		private float _awaitToWarningExpireTime
		{
			[Token(Token = "0x6006F99")]
			[Address(RVA = "0xB9FA", Offset = "0xB9FA", VA = "0xB9FA")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006F9A")]
			[Address(RVA = "0xB9FB", Offset = "0xB9FB", VA = "0xB9FB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0xB9FC", Offset = "0xB9FC", VA = "0xB9FC")]
		private void ShowServerMaintenanceWindow()
		{
		}

		// Token: 0x04003A45 RID: 14917
		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0xC")]
		public readonly float ConnectTimeoutToWarning;

		// Token: 0x04003A46 RID: 14918
		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x10")]
		private InformerView _appCanvasInformerView;

		// Token: 0x04003A47 RID: 14919
		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0x14")]
		private ILowResponseAbilityMonitor _lowResponseAbilityMonitor;

		// Token: 0x04003A48 RID: 14920
		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0x18")]
		private ConnectionState _state;

		// Token: 0x04003A49 RID: 14921
		[Token(Token = "0x4003A49")]
		[FieldOffset(Offset = "0x1C")]
		private DialogWindow _serverReadyToStopDialogWindow;

		// Token: 0x04003A4B RID: 14923
		[Token(Token = "0x4003A4B")]
		[FieldOffset(Offset = "0x24")]
		private DialogWindow _connectTimeoutOverWarningDialogWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DisconnectResolver ---
		void Core_Application_Managers_Connection_ConnectionInformer__set_DisconnectResolver
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a861 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5a861 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x24);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81280067;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x81280067:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x24) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set__awaitToWarningExpireTime ---
		void Core_Application_Managers_Connection_ConnectionInformer__set__awaitToWarningExpireTime
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a864 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionInformer__ShowServerMaintenanceWindow_b__20_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13783);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13782);
		    DAT_ram_00a5a864 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x24),0);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13783,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 0x18) = uVar2;
		    uVar2 = func_ii_7508(StringLiteral_13782,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 8) = 2;
		    *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		    uVar2 = UI_Windows_UnityInstantiator___ctor(iVar1,0);
		    *(undefined4 *)(param1 + 0x24) = uVar2;
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,
		               Method_Core_Application_Managers_Connection_ConnectionInformer__ShowServerMaintenanceWindow_b__20_0__
		               ,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar2,param1_00,0);
		  }
		  return;
		}
		*/

}
