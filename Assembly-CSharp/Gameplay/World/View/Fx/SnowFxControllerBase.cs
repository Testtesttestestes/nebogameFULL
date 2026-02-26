using System;
using System.Collections;
using System.Runtime.InteropServices;
using Core.Data.User;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.World.View.Fx
{
	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	public abstract class SnowFxControllerBase : MonoBehaviour
	{
		// Token: 0x060013AC RID: 5036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x659C", Offset = "0x659C", VA = "0x659C")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__Start(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58c6e == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_View_Fx_SnowFxControllerBase_ButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_View_Fx_SnowFxControllerBase_LongTapOnLongTapEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58c6e = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_World_View_Fx_SnowFxControllerBase_ButtonClickHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Utils_LongTap_LongTapHandler_TypeInfo);
		  Utils_LongTap___cctor
		            (uVar1,param1,Method_Gameplay_World_View_Fx_SnowFxControllerBase_LongTapOnLongTapEvent__
		             ,0);
		  Utils_LongTap__add_LongTapEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x659D", Offset = "0x659D", VA = "0x659D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param3_00;
		  uint uVar4;
		  int iVar5;
		  undefined4 local_4;
		  
		  uVar4 = 0;
		  if (DAT_ram_00a58c6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_FxActivatedEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27304);
		    DAT_ram_00a58c6f = '\x01';
		  }
		  *(char *)(param1 + 0x21) = (char)param2;
		  *(undefined1 *)(param1 + 0x20) = 1;
		  Gameplay_World_View_Fx_SnowFxControllerBase__LoadProps(param1,0);
		  param1_01 = *(int **)(param1 + 0x24);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f9219a;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80f9219a:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  if (*(char *)(iVar3 + 0xc) != '\0') {
		    if (DAT_ram_00a58c70 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_World_View_Fx_SnowFxControllerBase__TrackCameraPosition_d__19_TypeInfo);
		      DAT_ram_00a58c70 = '\x01';
		    }
		    iVar3 = unnamed_function_1417
		                      (
		                      Gameplay_World_View_Fx_SnowFxControllerBase__TrackCameraPosition_d__19_TypeInfo
		                      );
		    *(int *)(iVar3 + 0x10) = param1;
		    *(undefined4 *)(iVar3 + 8) = 0;
		    uVar2 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar3,0);
		    *(undefined4 *)(param1 + 0x28) = uVar2;
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  *(char *)(iVar3 + 0x20) = (char)param2;
		  iVar5 = 0x14;
		  if (param2 == 0) {
		    iVar5 = 0x10;
		  }
		  local_4 = *(undefined4 *)(iVar3 + iVar5);
		  UnityEngine_ParticleSystem_EmissionModule___ctor(&local_4,1,0);
		  iVar3 = System_Uri___ctor(0);
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x44) + 0x14);
		  if (iVar3 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_UiScope_FxActivatedEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_FxActivatedEventArgs__get_LongTapped
		              (param1_00,uVar2,param3_00,StringLiteral_27304,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x659E", Offset = "0x659E", VA = "0x659E")]
		private void StartSnowAnimation(bool windy)
		{
		/* --- GHIDRA: StartSnowAnimation ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__StartSnowAnimation(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  *(undefined2 *)(param1 + 0x20) = 0;
		  Gameplay_World_View_Fx_SnowFxControllerBase__LoadProps(param1,param1);
		  if (*(int *)(param1 + 0x28) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x28),0);
		  }
		  iVar1 = 0x14;
		  if (*(char *)(*(int *)(param1 + 0x10) + 0x20) == '\0') {
		    iVar1 = 0x10;
		  }
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x10) + iVar1);
		  UnityEngine_ParticleSystem_EmissionModule___ctor(&local_4,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x659F", Offset = "0x659F", VA = "0x659F")]
		private void StopSnowAnimation()
		{
		/* --- GHIDRA: StopSnowAnimation ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__StopSnowAnimation
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)((int)param1 + 0x23) = 1;
		  if ((char)param1[8] == '\0') {
		    Gameplay_World_View_Fx_SnowFxControllerBase__OnDestroy(param1,1,param1);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		              (param1,(char)param1[8] == '\0',*(undefined4 *)(*param1 + 0xe4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x65A0", Offset = "0x65A0", VA = "0x65A0")]
		private void LongTapOnLongTapEvent([Optional] LongTap _)
		{
		/* --- GHIDRA: LongTapOnLongTapEvent ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__LongTapOnLongTapEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (*(char *)((int)param1 + 0x23) == '\0') {
		    if ((char)param1[8] == '\0') {
		      Gameplay_World_View_Fx_SnowFxControllerBase__OnDestroy(param1,0,param1);
		    }
		    else {
		      *(undefined2 *)(param1 + 8) = 0;
		      Gameplay_World_View_Fx_SnowFxControllerBase__LoadProps(param1,param1);
		      if (param1[10] != 0) {
		        func_ii_20511(param1,param1[10],0);
		      }
		      iVar1 = 0x14;
		      if (*(char *)(param1[4] + 0x20) == '\0') {
		        iVar1 = 0x10;
		      }
		      local_4 = *(undefined4 *)(param1[4] + iVar1);
		      UnityEngine_ParticleSystem_EmissionModule___ctor(&local_4,0,0);
		    }
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		              (param1,(char)param1[8] == '\0',*(undefined4 *)(*param1 + 0xe4));
		  }
		  else {
		    *(undefined1 *)((int)param1 + 0x23) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x65A1", Offset = "0x65A1", VA = "0x65A1")]
		private void ButtonClickHandler()
		{
		/* --- GHIDRA: ButtonClickHandler ---
		int Gameplay_World_View_Fx_SnowFxControllerBase__ButtonClickHandler
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c70 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_View_Fx_SnowFxControllerBase__TrackCameraPosition_d__19_TypeInfo);
		    DAT_ram_00a58c70 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_World_View_Fx_SnowFxControllerBase__TrackCameraPosition_d__19_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x65A2", Offset = "0x65A2", VA = "0x65A2")]
		private IEnumerator TrackCameraPosition()
		{
		/* --- GHIDRA: TrackCameraPosition ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__TrackCameraPosition(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_40;
		  undefined8 local_3c;
		  undefined4 local_34;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a58c71 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Names_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Scopes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8195);
		    DAT_ram_00a58c71 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar1,StringLiteral_8195,StringLiteral_1773,0);
		  uVar1 = Utils_LocalProps___ctor(uVar1,0);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  local_18 = 0xffffffff;
		  local_1c = Utils_LocalProps_Scopes_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_1c,0);
		  local_24 = 0x2ffffffff;
		  local_28 = Utils_LocalProps_Names_TypeInfo;
		  uVar3 = Spine_SkeletonJson__GetFloat(&local_28,0);
		  Utils_LocalProps__SetProp(uVar1,uVar2,uVar3,&local_8,0,0);
		  uVar3 = *(undefined4 *)(param1 + 0x38);
		  local_30 = 0xffffffff;
		  local_34 = Utils_LocalProps_Scopes_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_34,0);
		  local_3c = 0x3ffffffff;
		  local_40 = Utils_LocalProps_Names_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_40,0);
		  Utils_LocalProps__SetProp(uVar3,uVar1,uVar2,&local_10,0,0);
		  *(bool *)(param1 + 0x20) = 0 < local_8;
		  *(bool *)(param1 + 0x21) = 0 < local_10;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x65A3", Offset = "0x65A3", VA = "0x65A3")]
		private void LoadProps()
		{
		/* --- GHIDRA: LoadProps ---
		void Gameplay_World_View_Fx_SnowFxControllerBase__LoadProps(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58c72 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Names_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Scopes_TypeInfo);
		    DAT_ram_00a58c72 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x38);
		  local_8 = 0xffffffff;
		  local_c = Utils_LocalProps_Scopes_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  local_14 = 0x2ffffffff;
		  local_18 = Utils_LocalProps_Names_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_18,0);
		  Utils_LocalProps__TryGetProp(uVar3,uVar1,uVar2,(ulonglong)*(byte *)(param1 + 0x20),0,0);
		  uVar3 = *(undefined4 *)(param1 + 0x38);
		  local_8 = 0xffffffff;
		  local_c = Utils_LocalProps_Scopes_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  local_14 = 0x3ffffffff;
		  local_18 = Utils_LocalProps_Names_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_18,0);
		  Utils_LocalProps__TryGetProp(uVar3,uVar1,uVar2,(ulonglong)*(byte *)(param1 + 0x21),0,0);
		  Utils_LocalProps__SetProp(*(undefined4 *)(param1 + 0x38),0);
		  return;
		}
		*/

		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x65A4", Offset = "0x65A4", VA = "0x65A4")]
		private void SaveProps()
		{
		}

		// Token: 0x060013B5 RID: 5045
		[Token(Token = "0x60013B5")]
		protected abstract void ValidateEnable(bool enable);

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x65A5", Offset = "0x65A5", VA = "0x65A5")]
		protected SnowFxControllerBase()
		{
		}

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected SnowFxView _fxView;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Button _button;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected LongTap _longTap;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Camera _worldCamera;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		private const string FxName = "snow";

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _fxEnabled;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _windy;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _wasReset;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool _longTapped;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private IUserSettings _userSettings;

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine _trackCameraRoutine;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 _cameraPosition;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LocalProps _fxLocalProps;
	}
}
