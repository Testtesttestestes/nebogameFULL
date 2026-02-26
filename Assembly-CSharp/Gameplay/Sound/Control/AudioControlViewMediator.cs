using System;
using Gameplay.Sound.Model;
using Gameplay.Sound.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C77 RID: 3191
	[Token(Token = "0x2000C77")]
	public class AudioControlViewMediator : AbstractViewMediator<AudioModel, AudioEvents, AudioController, AudioControlsView>
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x9C21", Offset = "0x9C21", VA = "0x9C21", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Sound_Control_AudioControlViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a59828 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__AudioControlsView___ctor__
		              );
		    DAT_ram_00a59828 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__AudioControlsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x9C22", Offset = "0x9C22", VA = "0x9C22")]
		public AudioControlViewMediator(AudioModel model, AudioEvents events, AudioController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Sound_Control_AudioControlViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59829 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__AudioControlsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Sound_Control_AudioControlViewMediator_HandleMusicOnValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Sound_Control_AudioControlViewMediator_HandleSoundFXOnValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a59829 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Sound_Control_AudioControlViewMediator_HandleMusicOnValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Sound_Control_AudioControlViewMediator_HandleSoundFXOnValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Sound_Control_AudioControlViewMediator_HandleMusicOnValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_Sound_Control_AudioControlViewMediator_HandleSoundFXOnValueChangedEvent__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Gameplay_Sound_Control_AudioControlViewMediator__HandleMusicOnValueChangedEvent(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FCE RID: 4046
		// (set) Token: 0x06004DEB RID: 19947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FCE")]
		public override AudioControlsView View
		{
			[Token(Token = "0x6004DEB")]
			[Address(RVA = "0x9C23", Offset = "0x9C23", VA = "0x9C23", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x9C24", Offset = "0x9C24", VA = "0x9C24")]
		private void HandleSoundFXOnValueChangedEvent(bool value)
		{
		/* --- GHIDRA: HandleSoundFXOnValueChangedEvent ---
		void Gameplay_Sound_Control_AudioControlViewMediator__HandleSoundFXOnValueChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Sound_Control_AudioController__SetSoundFXEnabled(param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x9C25", Offset = "0x9C25", VA = "0x9C25")]
		private void HandleMusicOnValueChangedEvent(bool value)
		{
		/* --- GHIDRA: HandleMusicOnValueChangedEvent ---
		void Gameplay_Sound_Control_AudioControlViewMediator__HandleMusicOnValueChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a5982a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__AudioControlsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5982a = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x14);
		  piVar5 = *(int **)(param1[2] + 0xc);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107689e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107689e:
		  uVar1 = 0;
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  func_ii_7603(uVar4,(uint)*(byte *)(iVar2 + 9),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x10);
		  piVar5 = *(int **)(param1[2] + 0xc);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107694a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107694a:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  func_ii_7603(uVar4,(uint)*(byte *)(iVar2 + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x9C26", Offset = "0x9C26", VA = "0x9C26")]
		private void SetupView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Sound_Control_AudioControlViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Sound_Control_AudioController__PlayMusic(param1_00,param2,param1);
		  return;
		}
		*/

}
