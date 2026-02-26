using System;
using Core.Animations;
using Il2CppDummyDll;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace Animations
{
	// Token: 0x0200133A RID: 4922
	[Token(Token = "0x200133A")]
	public class InIdleOutSpineAnimation : MonoBehaviour
	{
		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001779")]
		public TextMeshProUGUI TextLabel
		{
			[Token(Token = "0x600748A")]
			[Address(RVA = "0xBE56", Offset = "0xBE56", VA = "0xBE56")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600748B RID: 29835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177A")]
		public ParticleSystem[] Particles
		{
			[Token(Token = "0x600748B")]
			[Address(RVA = "0xBE57", Offset = "0xBE57", VA = "0xBE57")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748C")]
		[Address(RVA = "0xBE58", Offset = "0xBE58", VA = "0xBE58")]
		public void StartAnimation()
		{
		/* --- GHIDRA: StartAnimation ---
		void Animations_InIdleOutSpineAnimation__StartAnimation
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a596bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_InIdleOutSpineAnimation_AnimationOnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24507);
		    DAT_ram_00a596bf = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (iVar1 != 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x10);
		    param1_00 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,Method_Animations_InIdleOutSpineAnimation_AnimationOnCompleteEvent__
		               ,0);
		    Core_Animations_GameSpineUiAnimation__add_CompleteEvent(param1_01,param1_00,0);
		    UnityEngine_WaitForSeconds___ctor(*(undefined4 *)(param1 + 0x10),StringLiteral_24507,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748D")]
		[Address(RVA = "0xBE59", Offset = "0xBE59", VA = "0xBE59")]
		private void AnimationOnCompleteEvent(IGameAnimation obj)
		{
		/* --- GHIDRA: AnimationOnCompleteEvent ---
		void Animations_InIdleOutSpineAnimation__AnimationOnCompleteEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_InIdleOutSpineAnimation_AnimationOnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8060);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22923);
		    DAT_ram_00a596c0 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		    uVar2 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Animations_InIdleOutSpineAnimation_AnimationOnCompleteEvent__,0);
		    Core_Animations_GameSpineUiAnimation__add_CompleteEvent(param1_00,uVar2,0);
		    UnityEngine_WaitForSeconds___ctor(*(undefined4 *)(param1 + 0x10),StringLiteral_22923,0,0);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_AnimatorStateInfo__get_speedMultiplier
		              (*(undefined4 *)(param1 + 0x14),StringLiteral_8060,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748E")]
		[Address(RVA = "0xBE5A", Offset = "0xBE5A", VA = "0xBE5A")]
		public void FinishAnimation()
		{
		/* --- GHIDRA: FinishAnimation ---
		void Animations_InIdleOutSpineAnimation__FinishAnimation(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  if ((iVar2 != 0) && (0 < *(int *)(iVar2 + 0xc))) {
		    iVar1 = 0;
		    do {
		      UnityEngine_ParticleSystem__Simulate(*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748F")]
		[Address(RVA = "0xBE5B", Offset = "0xBE5B", VA = "0xBE5B")]
		[UsedImplicitly]
		public void StartParticleAnimations()
		{
		/* --- GHIDRA: StartParticleAnimations ---
		void Animations_InIdleOutSpineAnimation__StartParticleAnimations(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  if ((iVar2 != 0) && (0 < *(int *)(iVar2 + 0xc))) {
		    iVar1 = 0;
		    do {
		      UnityEngine_ParticleSystem__Stop(*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007490")]
		[Address(RVA = "0xBE5C", Offset = "0xBE5C", VA = "0xBE5C")]
		[UsedImplicitly]
		public void StopParticleAnimations()
		{
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007491")]
		[Address(RVA = "0xBE5D", Offset = "0xBE5D", VA = "0xBE5D")]
		public InIdleOutSpineAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Animations_InIdleOutSpineAnimation___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		    DAT_ram_00a596c1 = '\x01';
		  }
		  iVar1 = func_ii_4769(param1,0);
		  if (iVar1 == 0) {
		    if (*(int *)(Mycom_Tracker_Unity_LibraryLogger_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		    }
		    param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                          (**(undefined4 **)(Mycom_Tracker_Unity_LibraryLogger_TypeInfo + 0x5c),
		                           param1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04003D24 RID: 15652
		[Token(Token = "0x4003D24")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineUiAnimation _animation;

		// Token: 0x04003D25 RID: 15653
		[Token(Token = "0x4003D25")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04003D26 RID: 15654
		[Token(Token = "0x4003D26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem[] _particleSystems;

		// Token: 0x04003D27 RID: 15655
		[Token(Token = "0x4003D27")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _textLabel;

		// Token: 0x04003D28 RID: 15656
		[Token(Token = "0x4003D28")]
		public const string STATE_START = "start";

		// Token: 0x04003D29 RID: 15657
		[Token(Token = "0x4003D29")]
		public const string STATE_IDLE = "idle";

		// Token: 0x04003D2A RID: 15658
		[Token(Token = "0x4003D2A")]
		public const string STATE_END = "end";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Particles ---
		void Animations_InIdleOutSpineAnimation__get_Particles(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a596be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_InIdleOutSpineAnimation_AnimationOnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27389);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14604);
		    DAT_ram_00a596be = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (iVar1 != 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x10);
		    param1_00 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,Method_Animations_InIdleOutSpineAnimation_AnimationOnCompleteEvent__
		               ,0);
		    Core_Animations_GameSpineUiAnimation__remove_ClickEvent(param1_01,param1_00,0);
		    UnityEngine_WaitForSeconds___ctor(*(undefined4 *)(param1 + 0x10),StringLiteral_27389,0,0);
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x14),0);
		  if (iVar1 != 0) {
		    UnityEngine_AnimatorStateInfo__get_speedMultiplier
		              (*(undefined4 *)(param1 + 0x14),StringLiteral_14604,0);
		  }
		  return;
		}
		*/

}
