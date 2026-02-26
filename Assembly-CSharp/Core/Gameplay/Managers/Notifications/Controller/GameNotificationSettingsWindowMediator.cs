using System;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Core.Gameplay.Managers.Notifications.View;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Notifications.Controller
{
	// Token: 0x020011B1 RID: 4529
	[Token(Token = "0x20011B1")]
	public class GameNotificationSettingsWindowMediator : AbstractViewMediator<GameNotificationsModel, GameNotificationsEvents, GameNotificationsController, NotificationSettingsView>
	{
		// Token: 0x06006B96 RID: 27542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B96")]
		[Address(RVA = "0xB690", Offset = "0xB690", VA = "0xB690")]
		public GameNotificationSettingsWindowMediator(GameNotificationsModel model, GameNotificationsEvents events, GameNotificationsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a686 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameNotificationsModel__GameNotificationsEvents__GameNotificationsController__NotificationSettingsView__set_Events__
		              );
		    DAT_ram_00a5a686 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  param1[3] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x170015F4 RID: 5620
		// (set) Token: 0x06006B97 RID: 27543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F4")]
		public override GameNotificationsEvents Events
		{
			[Token(Token = "0x6006B97")]
			[Address(RVA = "0xB691", Offset = "0xB691", VA = "0xB691", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (set) Token: 0x06006B98 RID: 27544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F5")]
		public override NotificationSettingsView View
		{
			[Token(Token = "0x6006B98")]
			[Address(RVA = "0xB692", Offset = "0xB692", VA = "0xB692", Slot = "20")]
			set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a5a687 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameNotificationsModel__GameNotificationsEvents__GameNotificationsController__NotificationSettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameNotificationsModel__GameNotificationsEvents__GameNotificationsController__NotificationSettingsView__set_View__
		              );
		    DAT_ram_00a5a687 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		              (piVar3,*(undefined4 *)(param1[2] + 0xc),*(undefined4 *)(*piVar3 + 0x13c));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator__set_View
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a688 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_GameNotificationsModel__GameNotificationsEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_AbstractBaseNotificationScheduler__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_NotifierService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a688 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_AbstractBaseNotificationScheduler__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_AbstractBaseNotificationScheduler___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_GameNotificationsModel__GameNotificationsEvents___ctor__)
		  ;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_NotifierService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

}
