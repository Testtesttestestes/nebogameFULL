using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Notifications.Controller;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A9 RID: 4521
	[Token(Token = "0x20011A9")]
	public class NotificationSettingsWindow : ClosableBaseWindow<NotificationSettingsWindow.NotificationSettingsWindowArgs>
	{
		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06006B70 RID: 27504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E7")]
		public NotificationSettingsView SettingsView
		{
			[Token(Token = "0x6006B70")]
			[Address(RVA = "0xB66E", Offset = "0xB66E", VA = "0xB66E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E8")]
		public override string WindowId
		{
			[Token(Token = "0x6006B71")]
			[Address(RVA = "0xB66F", Offset = "0xB66F", VA = "0xB66F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B72")]
		[Address(RVA = "0xB670", Offset = "0xB670", VA = "0xB670", Slot = "22")]
		protected override void OnShow(NotificationSettingsWindow.NotificationSettingsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Core_Gameplay_Managers_Notifications_View_NotificationSettingsWindow__OnShow
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5a679 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_NotificationSettingsWindow_NotificationSettingsWindowArgs__OnClose__
		              );
		    DAT_ram_00a5a679 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_NotificationSettingsWindow_NotificationSettingsWindowArgs__OnClose__
		            );
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B73")]
		[Address(RVA = "0xB671", Offset = "0xB671", VA = "0xB671", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Core_Gameplay_Managers_Notifications_View_NotificationSettingsWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a67a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_NotificationSettingsWindow_NotificationSettingsWindowArgs___ctor__
		              );
		    DAT_ram_00a5a67a = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_NotificationSettingsWindow_NotificationSettingsWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B74")]
		[Address(RVA = "0xB672", Offset = "0xB672", VA = "0xB672")]
		public NotificationSettingsWindow()
		{
		}

		// Token: 0x040038B8 RID: 14520
		[Token(Token = "0x40038B8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private NotificationSettingsView _settingsView;

		// Token: 0x040038B9 RID: 14521
		[Token(Token = "0x40038B9")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/NotificationSettingsWindow";

		// Token: 0x040038BA RID: 14522
		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x40")]
		private GameNotificationSettingsWindowMediator _mediator;

		// Token: 0x020011AA RID: 4522
		[Token(Token = "0x20011AA")]
		public class NotificationSettingsWindowArgs : BaseWindowArgs
		{
			// Token: 0x170015E9 RID: 5609
			// (get) Token: 0x06006B75 RID: 27509 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170015E9")]
			public GameNotificationsController Controller
			{
				[Token(Token = "0x6006B75")]
				[Address(RVA = "0xB673", Offset = "0xB673", VA = "0xB673")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170015EA RID: 5610
			// (get) Token: 0x06006B76 RID: 27510 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170015EA")]
			public GameNotificationsEvents Events
			{
				[Token(Token = "0x6006B76")]
				[Address(RVA = "0xB674", Offset = "0xB674", VA = "0xB674")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170015EB RID: 5611
			// (get) Token: 0x06006B77 RID: 27511 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170015EB")]
			public GameNotificationsModel Model
			{
				[Token(Token = "0x6006B77")]
				[Address(RVA = "0xB675", Offset = "0xB675", VA = "0xB675")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B78 RID: 27512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B78")]
			[Address(RVA = "0xB676", Offset = "0xB676", VA = "0xB676")]
			public NotificationSettingsWindowArgs(GameNotificationsController controller, GameNotificationsModel model, GameNotificationsEvents events)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SettingsView ---
		undefined4
		Core_Gameplay_Managers_Notifications_View_NotificationSettingsWindow__get_SettingsView
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a677 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12656);
		    DAT_ram_00a5a677 = '\x01';
		  }
		  return StringLiteral_12656;
		}
		*/


		/* --- GHIDRA: get_WindowId ---
		void Core_Gameplay_Managers_Notifications_View_NotificationSettingsWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a678 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_NotificationSettingsWindow_NotificationSettingsWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator_TypeInfo
		              );
		    DAT_ram_00a5a678 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_NotificationSettingsWindow_NotificationSettingsWindowArgs__OnShow__
		              );
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param3_00 = *(undefined4 *)(param2 + 0x1c);
		  param2_00 = *(undefined4 *)(param2 + 0x20);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator_TypeInfo
		                               );
		  if (DAT_ram_00a5a685 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameNotificationsModel__GameNotificationsEvents__GameNotificationsController__NotificationSettingsView___ctor__
		              );
		    DAT_ram_00a5a685 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_GameNotificationsModel__GameNotificationsEvents__GameNotificationsController__NotificationSettingsView___ctor__
		            );
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
