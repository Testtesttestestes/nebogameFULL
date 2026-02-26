using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameplay.Sound.Model;
using Gameplay.Sound.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Sound.Control
{
	// Token: 0x02000C7B RID: 3195
	[Token(Token = "0x2000C7B")]
	public class AudioSourceMediator : AbstractViewMediator<AudioModel, AudioEvents, AudioController, GameAudioSource>
	{
		// Token: 0x06004E07 RID: 19975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x9C3E", Offset = "0x9C3E", VA = "0x9C3E")]
		public AudioSourceMediator(AudioModel model, AudioEvents events, AudioController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Sound_Control_AudioSourceMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a59838 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__GameAudioSource__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AudioClip__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Sound_Control_AudioSourceMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Sound_Control_AudioSourceMediator_HandleStopMusicEvent__);
		    DAT_ram_00a59838 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_AudioClip__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,*(undefined4 *)(*param1 + 0x16c),0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_AudioClip__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_AudioClip__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_AudioClip__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,*(undefined4 *)(*param1 + 0x174),0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_AudioClip__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_AudioClip__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_Sound_Control_AudioSourceMediator_HandleStopMusicEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 8);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_Sound_Control_AudioSourceMediator_HandleInitEvent__,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 8) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_AudioClip__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,*(undefined4 *)(*param1 + 0x16c),0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_AudioClip__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_AudioClip__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_AudioClip__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,*(undefined4 *)(*param1 + 0x174),0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_AudioClip__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_AudioClip__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_AudioClip__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_Sound_Control_AudioSourceMediator_HandleStopMusicEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x1c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 8);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_Sound_Control_AudioSourceMediator_HandleInitEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 8) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 8) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FD2 RID: 4050
		// (set) Token: 0x06004E08 RID: 19976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FD2")]
		public override AudioEvents Events
		{
			[Token(Token = "0x6004E08")]
			[Address(RVA = "0x9C3F", Offset = "0x9C3F", VA = "0x9C3F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E09")]
		[Address(RVA = "0x9C40", Offset = "0x9C40", VA = "0x9C40")]
		private void StopFade()
		{
		/* --- GHIDRA: StopFade ---
		void Gameplay_Sound_Control_AudioSourceMediator__StopFade(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Sound_Control_AudioController__PlaySound(param1_00,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x9C41", Offset = "0x9C41", VA = "0x9C41")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_Sound_Control_AudioSourceMediator__HandleInitEvent(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint uVar4;
		  
		  if (DAT_ram_00a5983a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__GameAudioSource__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___Add__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Sound_Control_AudioSourceMediator___c__DisplayClass6_0__HandleStopMusicEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Sound_Control_AudioSourceMediator___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a5983a = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Sound_Control_AudioSourceMediator___c__DisplayClass6_0_TypeInfo);
		  *(int **)(iVar1 + 0xc) = param1;
		  Gameplay_Sound_Control_AudioSourceMediator__set_Events(param1,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = UnityEngine_AudioSource__set_resource(*(undefined4 *)(iVar3 + 0x10),0);
		  uVar2 = UnityEngine_Audio_AudioMixer__GetFloat_Injected(uVar2,0);
		  iVar3 = param1[2];
		  uVar2 = DG_Tweening_DOTweenModuleAudio__DOPitch
		                    (uVar2,*(undefined4 *)(iVar3 + 0x30),*(float *)(iVar3 + 0x2c),
		                     *(float *)(iVar3 + 0x20),0);
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,iVar1,
		             Method_Gameplay_Sound_Control_AudioSourceMediator___c__DisplayClass6_0__HandleStopMusicEvent_b__0__
		             ,0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		                    );
		  iVar1 = Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___Add__;
		  iVar3 = param1[6];
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar3,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0B")]
		[Address(RVA = "0x9C42", Offset = "0x9C42", VA = "0x9C42")]
		private void HandleStopMusicEvent()
		{
		/* --- GHIDRA: HandleStopMusicEvent ---
		void Gameplay_Sound_Control_AudioSourceMediator__HandleStopMusicEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_AudioSource__Play(*(undefined4 *)(iVar1 + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0C")]
		[Address(RVA = "0x9C43", Offset = "0x9C43", VA = "0x9C43", Slot = "21")]
		protected virtual void HandlePlaySoundEvent(AudioClip audioClip)
		{
		/* --- GHIDRA: HandlePlaySoundEvent ---
		void Gameplay_Sound_Control_AudioSourceMediator__HandlePlaySoundEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a5983b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AudioModel__AudioEvents__AudioController__GameAudioSource__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Sound_Control_AudioSourceMediator__HandlePlayMusicEvent_b__8_0__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___Add__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a5983b = '\x01';
		  }
		  Gameplay_Sound_Control_AudioSourceMediator__set_Events(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_AudioSource__get_resource(*(undefined4 *)(iVar1 + 0x10),param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_AudioSource__get_outputAudioMixerGroup(*(undefined4 *)(iVar1 + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = UnityEngine_AudioSource__set_resource(*(undefined4 *)(iVar1 + 0x10),0);
		  uVar2 = UnityEngine_Audio_AudioMixer__GetFloat_Injected(uVar2,0);
		  iVar1 = param1[2];
		  uVar2 = DG_Tweening_DOTweenModuleAudio__DOPitch
		                    (uVar2,*(undefined4 *)(iVar1 + 0x30),*(float *)(iVar1 + 0x28),
		                     *(float *)(iVar1 + 0x24),0);
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,
		             Method_Gameplay_Sound_Control_AudioSourceMediator__HandlePlayMusicEvent_b__8_0__,0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		                    );
		  iVar1 = Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___Add__;
		  param1_01 = param1[6];
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0D")]
		[Address(RVA = "0x9C44", Offset = "0x9C44", VA = "0x9C44", Slot = "22")]
		protected virtual void HandlePlayMusicEvent(AudioClip audioClip)
		{
		/* --- GHIDRA: HandlePlayMusicEvent ---
		void Gameplay_Sound_Control_AudioSourceMediator__HandlePlayMusicEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Sound_Control_AudioSourceMediator__set_Events(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x18")]
		private List<TweenerCore<float, float, FloatOptions>> _fadeTweeners;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Sound_Control_AudioSourceMediator__set_Events(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a59839 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___get_Item__
		              );
		    DAT_ram_00a59839 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x18);
		  iVar3 = *(int *)(iVar2 + 0xc);
		  if (0 < iVar3) {
		    do {
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x18),iVar1,
		                             Method_System_Collections_Generic_List_TweenerCore_float__float__FloatOptions___get_Item__
		                            );
		      func_ii_7891(param1_00,0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar3);
		    iVar1 = *(int *)(param1 + 0x18);
		    iVar2 = *(int *)(iVar1 + 0xc);
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    if (0 < iVar2) {
		      func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		    }
		    return;
		  }
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  return;
		}
		*/

}
