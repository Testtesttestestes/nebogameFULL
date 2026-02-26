using System;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A7 RID: 4519
	[Token(Token = "0x20011A7")]
	public class NotificationGroupsSettingsView : AbstractDataRenderer<NotificationGroupData>
	{
		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x00013D28 File Offset: 0x00011F28
		[Token(Token = "0x170015E5")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6006B67")]
			[Address(RVA = "0xB665", Offset = "0xB665", VA = "0xB665", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B68")]
		[Address(RVA = "0xB666", Offset = "0xB666", VA = "0xB666", Slot = "10")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView__Dispose
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a673 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView_HandleToggleChanged__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a5a673 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView_HandleToggleChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B69")]
		[Address(RVA = "0xB667", Offset = "0xB667", VA = "0xB667", Slot = "9")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView__Awake
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (*(byte *)(iVar1 + 0x10) != param2) {
		    *(char *)(iVar1 + 0x10) = (char)param2;
		    iVar2 = *(int *)(iVar1 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6A")]
		[Address(RVA = "0xB668", Offset = "0xB668", VA = "0xB668")]
		private void HandleToggleChanged(bool isOn)
		{
		/* --- GHIDRA: HandleToggleChanged ---
		void Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView__HandleToggleChanged
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    piVar3 = (int *)param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Core_Extensions_Dict_NotificationCategoryDicExt__GetTitle(*(undefined4 *)(iVar1 + 8),0);
		    iVar1 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    param1_00 = param1[10];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    func_ii_7603(param1_00,(uint)*(byte *)(iVar1 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6B")]
		[Address(RVA = "0xB669", Offset = "0xB669", VA = "0xB669", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a674 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_NotificationGroupData___ctor__);
		    DAT_ram_00a5a674 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_NotificationGroupData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6C")]
		[Address(RVA = "0xB66A", Offset = "0xB66A", VA = "0xB66A")]
		public NotificationGroupsSettingsView()
		{
		}

		// Token: 0x040038B4 RID: 14516
		[Token(Token = "0x40038B4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040038B5 RID: 14517
		[Token(Token = "0x40038B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _toggle;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ValidateDataImmediately ---
		void Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView__get_ValidateDataImmediately
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a672 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_NotificationGroupData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView_HandleToggleChanged__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a5a672 = '\x01';
		  }
		  UI_AbstractDataRenderer_object___CommitProperties
		            (param1,Method_UI_AbstractDataRenderer_NotificationGroupData__Dispose__);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Notifications_View_NotificationGroupsSettingsView_HandleToggleChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

}
