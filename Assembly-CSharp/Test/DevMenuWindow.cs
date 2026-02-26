using System;
using Core.Analytics.Service.Android;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations;
using UI.Windows;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Test
{
	// Token: 0x02000E41 RID: 3649
	[Token(Token = "0x2000E41")]
	public class DevMenuWindow : WindowWhitCloseButton<BaseWindowArgs>
	{
		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700123F")]
		public override string WindowId
		{
			[Token(Token = "0x600596F")]
			[Address(RVA = "0xA69B", Offset = "0xA69B", VA = "0xA69B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x17001240")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6005970")]
			[Address(RVA = "0xA69C", Offset = "0xA69C", VA = "0xA69C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005971")]
		[Address(RVA = "0xA69D", Offset = "0xA69D", VA = "0xA69D", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: <Awake>b__17_0 ---
		void Test_DevMenuWindow___Awake_b__17_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c17 == '\0') {
		    Mono_Security_ASN1__get_Item(&Test_DevMenuWindow___c_TypeInfo);
		    DAT_ram_00a63c17 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Test_DevMenuWindow___c_TypeInfo);
		  **(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Awake ---
		void Test_DevMenuWindow__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a63c0f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4417);
		    DAT_ram_00a63c0f = '\x01';
		  }
		  uVar1 = Core_Analytics_Service_Android_CombatCollector___c___ToString_b__17_0
		                    (*(undefined4 *)(param1 + 100),0,0);
		  Core_ExternAppMethods__SendLogToWeb(uVar1,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_4417,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005972")]
		[Address(RVA = "0xA69E", Offset = "0xA69E", VA = "0xA69E")]
		public void OnCopyDeviceId()
		{
		/* --- GHIDRA: OnCopyDeviceId ---
		void Test_DevMenuWindow__OnCopyDeviceId(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  Gameplay_Clans_Combat_ClanCombat__InitMVC(**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),0)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005973")]
		[Address(RVA = "0xA69F", Offset = "0xA69F", VA = "0xA69F")]
		private void TryRunViewModeClanCombat()
		{
		/* --- GHIDRA: TryRunViewModeClanCombat ---
		void Test_DevMenuWindow__TryRunViewModeClanCombat(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a63c10 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameRestart_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22571);
		    DAT_ram_00a63c10 = '\x01';
		  }
		  UnityEngine_PlayerPrefs__TrySetSetString(StringLiteral_22571,2,0);
		  func_ii_10838(0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8236d03d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8236d03d:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x168);
		        goto code_r0x8236d0bf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x15);
		code_r0x8236d0bf:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGameRestart_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8236d16e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGameRestart_TypeInfo,0);
		code_r0x8236d16e:
		  (**(code **)((ulonglong)*puVar2 * 4))(auStack_8,piVar3,uVar5,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005974")]
		[Address(RVA = "0xA6A0", Offset = "0xA6A0", VA = "0xA6A0")]
		private void RestartGameWhitGoogleBilling()
		{
		/* --- GHIDRA: RestartGameWhitGoogleBilling ---
		void Test_DevMenuWindow__RestartGameWhitGoogleBilling(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a63c11 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameRestart_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22571);
		    DAT_ram_00a63c11 = '\x01';
		  }
		  UnityEngine_PlayerPrefs__TrySetSetString(StringLiteral_22571,1,0);
		  func_ii_10838(0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8236d276;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8236d276:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x168);
		        goto code_r0x8236d2f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x15);
		code_r0x8236d2f8:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGameRestart_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8236d3a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGameRestart_TypeInfo,0);
		code_r0x8236d3a7:
		  (**(code **)((ulonglong)*puVar2 * 4))(auStack_8,piVar3,uVar5,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005975")]
		[Address(RVA = "0xA6A1", Offset = "0xA6A1", VA = "0xA6A1")]
		private void RestarGameWhitHvBilling()
		{
		/* --- GHIDRA: RestarGameWhitHvBilling ---
		void Test_DevMenuWindow__RestarGameWhitHvBilling(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c12 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SystemService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63c12 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_SystemService___);
		  Unity_Services_LevelPlay_LevelPlayRewardedAd___SetupEvents_b__29_2(param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005976")]
		[Address(RVA = "0xA6A2", Offset = "0xA6A2", VA = "0xA6A2")]
		private void EmulateDisconnectCode()
		{
		/* --- GHIDRA: EmulateDisconnectCode ---
		void Test_DevMenuWindow__EmulateDisconnectCode(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a63c13 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoResourcesChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63c13 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x8236d4f9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8236d4f9:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar4 = func_ii_7112(uVar3,0);
		  *(double *)(param1_00 + 0x18) = *(double *)(*(int *)(iVar4 + 0x78) + 0x18) + -1.0;
		  iVar4 = unnamed_function_1417(Protocol_Balance_ProtoResourcesChangedEvt_TypeInfo);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__ToRewardData(param1_00,0);
		  *(undefined4 *)(iVar4 + 0xc) = uVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  Unity_Services_LevelPlay_LevelPlayRewardedAd___SetupEvents_b__29_2(uVar3,iVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005977")]
		[Address(RVA = "0xA6A3", Offset = "0xA6A3", VA = "0xA6A3")]
		private void EncreaseUserResources()
		{
		/* --- GHIDRA: EncreaseUserResources ---
		void Test_DevMenuWindow__EncreaseUserResources(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a63c14 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoNewLevelEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63c14 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  param2_00 = unnamed_function_1417(Protocol_Main_ProtoNewLevelEvt_TypeInfo);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x8236d66f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8236d66f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar4 = Core_Data_UserData__set_LevelDic(uVar3,0);
		  *(int *)(param2_00 + 0xc) = iVar4 + 1;
		  Unity_Services_LevelPlay_LevelPlayInterstitialAd___SetupEvents_b__26_3(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005978")]
		[Address(RVA = "0xA6A4", Offset = "0xA6A4", VA = "0xA6A4")]
		private void EncreaseUserLevel()
		{
		/* --- GHIDRA: EncreaseUserLevel ---
		void Test_DevMenuWindow__EncreaseUserLevel(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63c15 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_WindowWhitCloseButton_BaseWindowArgs___ctor__);
		    DAT_ram_00a63c15 = '\x01';
		  }
		  System_Linq_Enumerable_WhereSelectListIterator_JsonParser_JsonValue__Vector3___Where
		            (param1,Method_UI_Windows_WindowWhitCloseButton_BaseWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005979")]
		[Address(RVA = "0xA6A5", Offset = "0xA6A5", VA = "0xA6A5")]
		public DevMenuWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Test_DevMenuWindow___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  undefined4 *param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63c16 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14073);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14074);
		    DAT_ram_00a63c16 = '\x01';
		  }
		  if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) goto code_r0x8236d74c;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x8236d74c:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iii
		              (s___Scripting__UnityEngine__Render_ram_00004866 + 0x2b,StringLiteral_14074,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) goto code_r0x8236d86b;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
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
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        if (iVar2 != 0) {
		          piVar4 = (int *)*puVar3;
		          import::env::__cxa_end_catch();
		          iVar5 = *piVar4;
		          uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		                            (piVar4,*(undefined4 *)(iVar5 + 0xec));
		          param1_00 = unnamed_function_2232(&StringLiteral_21048);
		          uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param1_00,uVar1,0);
		          iVar5 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar5 + 0x74) == 0) {
		            func_ii_306000(iVar5);
		          }
		          System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		code_r0x8236d86b:
		          if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_SceneManagement_SceneManager_TypeInfo);
		          }
		          UnityEngine_SceneManagement_SceneManager__remove_activeSceneChanged
		                    (StringLiteral_14073,1,0);
		          System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0)
		          ;
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8236d917;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x8236d917:
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

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DevMenuWindow";

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _loadSceneButton;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _infoText;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _restarGameDefault;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _stopCurrentCombatButton;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _guideDevEditTool;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextToolTip _textTool;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextToolTip _textTool2;

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextToolTip _textToolBottomRight;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextToolTip _textToolTopLeft;

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _deviceId;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpriteAtlas _cloudSpriteAtlas;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x64")]
		private DeviceIDProvider _deviceIDProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsFullscreenWindow ---
		void Test_DevMenuWindow__get_IsFullscreenWindow(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 *puVar9;
		  uint uVar10;
		  int iVar11;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63c0e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Test_DevMenuWindow__Awake_b__17_0__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Test_DevMenuWindow___c__Awake_b__17_1__);
		    Mono_Security_ASN1__get_Item(&Method_Test_DevMenuWindow___c__Awake_b__17_2__);
		    Mono_Security_ASN1__get_Item(&Method_Test_DevMenuWindow___c__Awake_b__17_3__);
		    Mono_Security_ASN1__get_Item(&Test_DevMenuWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28166);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3974);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9200);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13394);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3118);
		    DAT_ram_00a63c0e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = unnamed_function_1417(Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		  *(undefined4 *)(param1 + 100) = uVar1;
		  *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x28) = StringLiteral_3118;
		  *(undefined4 *)(*(int *)(param1 + 0x50) + 0x28) = StringLiteral_13394;
		  *(undefined4 *)(*(int *)(param1 + 0x54) + 0x28) = StringLiteral_3974;
		  *(undefined4 *)(*(int *)(param1 + 0x58) + 0x28) = StringLiteral_16363;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar10 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8236c7f5;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8236c7f5:
		  uVar4 = CONCAT44(in_register_20000014,puVar2[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (iVar6 != 0) {
		    piVar5 = *(int **)(param1 + 0x3c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x8236c8a8;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8236c8a8:
		    uVar4 = CONCAT44(uVar1,puVar2[1]);
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar4);
		    uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar3 = func_ii_7112(uVar3,0);
		    local_20 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar3,0);
		    uVar3 = func_ii_1081(DAT_ram_00a66968,&local_20);
		    uVar3 = func_ii_4419(StringLiteral_28166,uVar3,0);
		    iVar6 = *piVar5;
		    uVar4 = CONCAT44(uVar1,uVar3);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar5,uVar4,*(undefined4 *)(iVar6 + 0x2d4));
		    uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x1a0);
		        goto code_r0x8236c999;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x8236c999:
		  uVar4 = CONCAT44(uVar1,puVar2[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (iVar6 != 0) {
		    piVar5 = *(int **)(param1 + 0x3c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x1a0);
		          goto code_r0x8236ca4c;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x8236ca4c:
		    uVar4 = CONCAT44(uVar1,puVar2[1]);
		    piVar7 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar4);
		    uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar10 = 0;
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0xd8);
		          goto code_r0x8236cace;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,3
		                                 );
		code_r0x8236cace:
		    uVar4 = CONCAT44(uVar1,puVar2[1]);
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar4);
		    uVar1 = StringLiteral_28166;
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    if (iVar6 == 0) {
		      local_8 = 0;
		      local_10 = 0;
		    }
		    else {
		      uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(iVar6,0);
		      local_18 = 0;
		      local_20 = 0;
		      Core_Log_Files_FileDownloadLogger__LogDownload
		                (&local_20,uVar4,Method_System_Nullable_ulong___ctor__);
		      uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      local_8 = local_18;
		      local_10 = local_20;
		    }
		    local_18 = local_8;
		    local_20 = local_10;
		    uVar8 = func_ii_1081(System_Nullable_ulong__TypeInfo,&local_20);
		    uVar1 = func_ii_4419(uVar1,uVar8,0);
		    iVar6 = *piVar5;
		    uVar4 = CONCAT44(uVar3,uVar1);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar5,uVar4,*(undefined4 *)(iVar6 + 0x2d4));
		    uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  }
		  uVar8 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar3,param1,Method_Test_DevMenuWindow__Awake_b__17_0__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar8,uVar3,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4);
		  if (*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Test_DevMenuWindow___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c);
		  iVar6 = puVar9[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Test_DevMenuWindow___c_TypeInfo);
		      puVar9 = *(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c);
		    }
		    uVar8 = *puVar9;
		    iVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull(iVar6,uVar8,Method_Test_DevMenuWindow___c__Awake_b__17_1__,0);
		    *(int *)(*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,iVar6,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xb4);
		  if (*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Test_DevMenuWindow___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c);
		  iVar6 = puVar9[2];
		  if (iVar6 == 0) {
		    if (*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Test_DevMenuWindow___c_TypeInfo);
		      puVar9 = *(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c);
		    }
		    uVar8 = *puVar9;
		    iVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull(iVar6,uVar8,Method_Test_DevMenuWindow___c__Awake_b__17_2__,0);
		    *(int *)(*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x5c) + 8) = iVar6;
		  }
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,iVar6,0);
		  uVar3 = *(undefined4 *)(param1 + 0x48);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x1e8);
		        goto code_r0x8236cd7b;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x8236cd7b:
		  uVar4 = CONCAT44(uVar1,puVar2[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  iVar11 = **(int **)(iVar6 + 0x10);
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),*(undefined4 *)(iVar11 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))(*(int **)(iVar6 + 0x10),uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  UnityEngine_UI_Toggle__get_isOn(uVar3,(uint)*(byte *)(iVar6 + 0x1c),0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x48) + 0xc0);
		  if (*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Test_DevMenuWindow___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c);
		  iVar6 = puVar9[3];
		  if (iVar6 == 0) {
		    if (*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Test_DevMenuWindow___c_TypeInfo);
		      puVar9 = *(undefined4 **)(Test_DevMenuWindow___c_TypeInfo + 0x5c);
		    }
		    uVar8 = *puVar9;
		    iVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group(iVar6,uVar8,Method_Test_DevMenuWindow___c__Awake_b__17_3__,0);
		    *(int *)(*(int *)(Test_DevMenuWindow___c_TypeInfo + 0x5c) + 0xc) = iVar6;
		  }
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,iVar6,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  piVar5 = *(int **)(param1 + 0x5c);
		  uVar3 = Core_Analytics_Service_Android_CombatCollector___c___ToString_b__17_0
		                    (*(undefined4 *)(param1 + 100),0,0);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_9200,uVar3,0);
		  iVar6 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar5,CONCAT44(uVar1,uVar3),*(undefined4 *)(iVar6 + 0x2d4));
		  return;
		}
		*/

}
