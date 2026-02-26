using System;
using System.Collections;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.Menu.Settings.Model;
using Gameplay.UserInterface.Menu.Settings.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings.Control
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public class SettingsViewMediator : AbstractViewMediator<SettingsModel, SettingsEvents, SettingsController, SettingsView>
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x68F3", Offset = "0x68F3", VA = "0x68F3", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5988f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_AudioControlViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5988f = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView___ctor__
		            );
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x8107eb7e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x8107eb7e:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (*(int **)(iVar4 + 0x18),*(undefined4 *)(iVar5 + 0x104));
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x8107ec1f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x8107ec1f:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                        (*(int **)(iVar4 + 0x18),*(undefined4 *)(iVar5 + 0x114));
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x8107ecc0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x8107ecc0:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4_00 = *(undefined4 *)(iVar4 + 0x18);
		  param1_00 = unnamed_function_1417(Gameplay_Sound_Control_AudioControlViewMediator_TypeInfo);
		  Gameplay_Sound_Control_AudioControlViewMediator__Dispose
		            (param1_00,param2_00,param3_00,param4_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x68F4", Offset = "0x68F4", VA = "0x68F4")]
		public SettingsViewMediator(SettingsModel model, SettingsEvents events, SettingsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59890 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView__set_View__
		              );
		    DAT_ram_00a59890 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000405 RID: 1029
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		public override SettingsView View
		{
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x68F5", Offset = "0x68F5", VA = "0x68F5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x68F6", Offset = "0x68F6", VA = "0x68F6")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59892 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatAnimationsEnabled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatSpellAnimationsEnabled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleWorldMovementAnimationsEnabled__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a59892 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xc0);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatAnimationsEnabled__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xc0);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatSpellAnimationsEnabled__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0xc0);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleWorldMovementAnimationsEnabled__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  piVar6 = (int *)param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x160) * 4))
		            (piVar6,*(undefined4 *)(iVar2 + 0x10),*(undefined4 *)(iVar7 + 0x164));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x14);
		  piVar6 = *(int **)(param1[2] + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107f6fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107f6fe:
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  func_ii_7603(uVar3,(uint)*(byte *)(iVar2 + 10),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x18);
		  piVar6 = *(int **)(param1[2] + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107f7aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107f7aa:
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  func_ii_7603(uVar3,(uint)*(byte *)(iVar2 + 0xb),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		  piVar6 = *(int **)(param1[2] + 0x10);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107f856;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107f856:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  func_ii_7603(uVar3,(uint)*(byte *)(iVar2 + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x68F7", Offset = "0x68F7", VA = "0x68F7")]
		private void SetView()
		{
		/* --- GHIDRA: SetView ---
		int Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__SetView
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59893 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__RestartRoutine_d__7_TypeInfo
		              );
		    DAT_ram_00a59893 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__RestartRoutine_d__7_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x68F8", Offset = "0x68F8", VA = "0x68F8")]
		private IEnumerator RestartRoutine()
		{
		/* --- GHIDRA: RestartRoutine ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__RestartRoutine
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_UserInterface_Menu_Settings_Control_SettingsController___ctor(param1_00,param2,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x68F9", Offset = "0x68F9", VA = "0x68F9")]
		private void HandleCombatAnimationsEnabled(bool value)
		{
		/* --- GHIDRA: HandleCombatAnimationsEnabled ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__HandleCombatAnimationsEnabled
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_UserInterface_Menu_Settings_Control_SettingsController__SetCombatAnimationsEnabled
		            (param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x68FA", Offset = "0x68FA", VA = "0x68FA")]
		private void HandleCombatSpellAnimationsEnabled(bool value)
		{
		/* --- GHIDRA: HandleCombatSpellAnimationsEnabled ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__HandleCombatSpellAnimationsEnabled
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_UserInterface_Menu_Settings_Control_SettingsController__SetCombatSpellAnimationsEnabled
		            (param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x68FB", Offset = "0x68FB", VA = "0x68FB")]
		private void HandleWorldMovementAnimationsEnabled(bool value)
		{
		}

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x18")]
		private AudioControlViewMediator _audioControlViewMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59891 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatAnimationsEnabled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatSpellAnimationsEnabled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleWorldMovementAnimationsEnabled__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a59891 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatAnimationsEnabled__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleCombatSpellAnimationsEnabled__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_HandleWorldMovementAnimationsEnabled__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar3,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

}
