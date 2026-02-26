using System;
using Core.Gameplay.Managers.Notifications.View;
using Gameplay.AccountLinker.ProgressSaver.View;
using Gameplay.AccountLinker.View;
using Gameplay.FeedbackForm.View;
using Gameplay.UserInterface.Menu.ExternalLinks.View;
using Gameplay.UserInterface.Menu.Settings.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Tabs;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.UserInterface.View.Menu
{
	// Token: 0x020003D3 RID: 979
	[Token(Token = "0x20003D3")]
	public class MenuView : MonoBehaviourWithStates<MenuWindow.MenuWindowArgs.SelectedTab>
	{
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E5")]
		public TabBar TabBar
		{
			[Token(Token = "0x60016EE")]
			[Address(RVA = "0x68AD", Offset = "0x68AD", VA = "0x68AD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E6")]
		public AccountLinkerView AccountLinker
		{
			[Token(Token = "0x60016EF")]
			[Address(RVA = "0x68AE", Offset = "0x68AE", VA = "0x68AE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E7")]
		public ProgressSaverView ProgressSaver
		{
			[Token(Token = "0x60016F0")]
			[Address(RVA = "0x68AF", Offset = "0x68AF", VA = "0x68AF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E8")]
		public SettingsView Settings
		{
			[Token(Token = "0x60016F1")]
			[Address(RVA = "0x68B0", Offset = "0x68B0", VA = "0x68B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003E9")]
		public NotificationSettingsView Notifications
		{
			[Token(Token = "0x60016F2")]
			[Address(RVA = "0x68B1", Offset = "0x68B1", VA = "0x68B1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003EA")]
		public FeedbackFormView FeedbackForm
		{
			[Token(Token = "0x60016F3")]
			[Address(RVA = "0x68B2", Offset = "0x68B2", VA = "0x68B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003EB")]
		public ExternalLinksView ExternalLinks
		{
			[Token(Token = "0x60016F4")]
			[Address(RVA = "0x68B3", Offset = "0x68B3", VA = "0x68B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x68B4", Offset = "0x68B4", VA = "0x68B4")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInterface_View_Menu_MenuView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5987b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_View_Menu_MenuView_HandleClickOnUserIdField__);
		    DAT_ram_00a5987b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_View_Menu_MenuView_HandleClickOnUserIdField__,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x68B5", Offset = "0x68B5", VA = "0x68B5")]
		private void Start()
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00005568 File Offset: 0x00003768
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EC")]
		public ulong UserId
		{
			[Token(Token = "0x60016F7")]
			[Address(RVA = "0x68B6", Offset = "0x68B6", VA = "0x68B6")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016F8")]
			[Address(RVA = "0x68B7", Offset = "0x68B7", VA = "0x68B7")]
			set
			{
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x68B8", Offset = "0x68B8", VA = "0x68B8")]
		private void HandleUserIdChanged()
		{
		/* --- GHIDRA: HandleUserIdChanged ---
		void Gameplay_UserInterface_View_Menu_MenuView__HandleUserIdChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5987d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4417);
		    DAT_ram_00a5987d = '\x01';
		  }
		  local_8 = *(undefined8 *)(param1 + 0x48);
		  uVar1 = func_ii_8783(&local_8,0);
		  Core_ExternAppMethods__SendLogToWeb(uVar1,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3_00 = func_ii_7508(StringLiteral_4417,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x68B9", Offset = "0x68B9", VA = "0x68B9")]
		private void HandleClickOnUserIdField(PointerEventData obj)
		{
		/* --- GHIDRA: HandleClickOnUserIdField ---
		void Gameplay_UserInterface_View_Menu_MenuView__HandleClickOnUserIdField
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5987e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab___ctor__);
		    DAT_ram_00a5987e = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x68BA", Offset = "0x68BA", VA = "0x68BA")]
		public MenuView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_UserInterface_View_Menu_MenuView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5987f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12653);
		    DAT_ram_00a5987f = '\x01';
		  }
		  return StringLiteral_12653;
		}
		*/

		}

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _yourUserIdField;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _idField;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MonoPointerClickHandler _userIdFieldClickHandler;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Header("Tabs")]
		private AccountLinkerView _accountLinker;

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressSaverView _progressSaver;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private SettingsView _settings;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NotificationSettingsView _notifications;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FeedbackFormView _feedbackForm;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ExternalLinksView _externalLinks;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x48")]
		private ulong _userId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ExternalLinks ---
		void Gameplay_UserInterface_View_Menu_MenuView__get_ExternalLinks(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5987a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_View_Menu_MenuView_HandleClickOnUserIdField__);
		    DAT_ram_00a5987a = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_View_Menu_MenuView_HandleClickOnUserIdField__,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_UserId ---
		void Gameplay_UserInterface_View_Menu_MenuView__get_UserId
		               (int param1,longlong param2,undefined4 param3)
		
		{
		  if (param2 != *(longlong *)(param1 + 0x48)) {
		    *(longlong *)(param1 + 0x48) = param2;
		    Gameplay_UserInterface_View_Menu_MenuView__set_UserId(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_UserId ---
		void Gameplay_UserInterface_View_Menu_MenuView__set_UserId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5987c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28176);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9058);
		    DAT_ram_00a5987c = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_18332,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_8 = *(undefined8 *)(param1 + 0x48);
		  iVar2 = func_ii_8783(&local_8,0);
		  if (iVar2 == 0) {
		    iVar2 = StringLiteral_5;
		  }
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_28176,iVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,param1_00,0);
		  iVar2 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  piVar3 = *(int **)(param1 + 0x20);
		  local_10 = *(undefined8 *)(param1 + 0x48);
		  uVar1 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  uVar1 = func_ii_4419(StringLiteral_9058,uVar1,0);
		  iVar2 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

}
