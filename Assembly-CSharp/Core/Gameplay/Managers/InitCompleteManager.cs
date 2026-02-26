using System;
using System.Runtime.CompilerServices;
using Core.Data.User;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001169 RID: 4457
	[Token(Token = "0x2001169")]
	public class InitCompleteManager : IGameManager, IBaseManager, IUserSettings
	{
		// Token: 0x1400028A RID: 650
		// (add) Token: 0x0600693A RID: 26938 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600693B RID: 26939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600693A")]
			[Address(RVA = "0xB45E", Offset = "0xB45E", VA = "0xB45E", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600693B")]
			[Address(RVA = "0xB45F", Offset = "0xB45F", VA = "0xB45F", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400028B RID: 651
		// (add) Token: 0x0600693C RID: 26940 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600693D RID: 26941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600693C")]
			[Address(RVA = "0xB460", Offset = "0xB460", VA = "0xB460", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600693D")]
			[Address(RVA = "0xB461", Offset = "0xB461", VA = "0xB461", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600693F RID: 26943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001588")]
		public UserSettings Settings
		{
			[Token(Token = "0x600693E")]
			[Address(RVA = "0xB462", Offset = "0xB462", VA = "0xB462", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600693F")]
			[Address(RVA = "0xB463", Offset = "0xB463", VA = "0xB463")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006940")]
		[Address(RVA = "0xB464", Offset = "0xB464", VA = "0xB464", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_InitCompleteManager__Init(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a637e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_UserSettings___);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoInitCompleteAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SettingsScope_SettingsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_UserSettings_TypeInfo);
		    DAT_ram_00a637e7 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoInitCompleteAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoInitCompleteAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = func_ii_5995(param1_01[3],Method_UnityEngine_JsonUtility_FromJson_UserSettings___);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(Core_Data_User_UserSettings_TypeInfo);
		    Core_Data_User_TutorialUserSettings__get_GuideEnabled(iVar1,0);
		  }
		  *(int *)(param1 + 0x10) = iVar1;
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x24) + 8);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param4 = *(undefined4 *)(param1 + 0x10);
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_SettingsScope_SettingsEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_00,param2_00,param3_00,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006941")]
		[Address(RVA = "0xB465", Offset = "0xB465", VA = "0xB465")]
		private void InitCompleteSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006942")]
		[Address(RVA = "0xB466", Offset = "0xB466", VA = "0xB466", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_InitCompleteManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_9365);
		    DAT_ram_00a637e8 = '\x01';
		  }
		  return StringLiteral_9365;
		}
		*/

		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06006943 RID: 26947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001589")]
		public string Name
		{
			[Token(Token = "0x6006943")]
			[Address(RVA = "0xB467", Offset = "0xB467", VA = "0xB467", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006944")]
		[Address(RVA = "0xB468", Offset = "0xB468", VA = "0xB468", Slot = "12")]
		public void CommitSettings()
		{
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006945")]
		[Address(RVA = "0xB469", Offset = "0xB469", VA = "0xB469")]
		public InitCompleteManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_InitCompleteManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637ea == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_10940);
		    DAT_ram_00a637ea = '\x01';
		  }
		  return StringLiteral_10940;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_InitCompleteManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637e3 = '\x01';
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
		void Core_Gameplay_Managers_InitCompleteManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637e4 = '\x01';
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
		void Core_Gameplay_Managers_InitCompleteManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637e5 = '\x01';
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


		/* --- GHIDRA: set_Settings ---
		void Core_Gameplay_Managers_InitCompleteManager__set_Settings(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a637e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_InitCompleteManager_InitCompleteSuccessHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a637e6 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__SwapSlots(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_InitCompleteManager_InitCompleteSuccessHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_InitCompleteManager__get_Name(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a637e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SettingsScope_SettingsEventArgs_TypeInfo);
		    DAT_ram_00a637e9 = '\x01';
		  }
		  uVar1 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  ServicesNamespace_MainService__SplitStackableItems(uVar2,uVar1,0);
		  iVar3 = System_Uri___ctor(0);
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x24) + 0xc);
		  if (iVar3 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param4 = *(undefined4 *)(param1 + 0x10);
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar2 = unnamed_function_1417(Core_Events_Scopes_SettingsScope_SettingsEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar2,uVar1,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

}
