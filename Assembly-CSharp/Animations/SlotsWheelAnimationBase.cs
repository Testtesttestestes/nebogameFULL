using System;
using System.Runtime.CompilerServices;
using Core.Animations;
using Il2CppDummyDll;
using Spine;
using UnityEngine;

namespace Animations
{
	// Token: 0x02001333 RID: 4915
	[Token(Token = "0x2001333")]
	public class SlotsWheelAnimationBase : GameSpineUiAnimation
	{
		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06007464 RID: 29796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001772")]
		public virtual string Prefix
		{
			[Token(Token = "0x6007464")]
			[Address(RVA = "0xBE30", Offset = "0xBE30", VA = "0xBE30", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007465")]
		[Address(RVA = "0xBE31", Offset = "0xBE31", VA = "0xBE31")]
		public void Init(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		/* --- GHIDRA: Init ---
		void Animations_SlotsWheelAnimationBase__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596af == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_SlotsWheelAnimationBase_AnimationStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a596af = '\x01';
		  }
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  param1_00 = *(undefined4 *)(iVar1 + 0xdc);
		  uVar2 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar2,param1,Method_Animations_SlotsWheelAnimationBase_AnimationStateOnComplete__,0);
		  Spine_AnimationState__remove_Dispose(param1_00,uVar2,0);
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  *(undefined4 *)(iVar1 + 0x94) = 0x3f800000;
		  uVar2 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x34),0);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x38);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x38),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007466")]
		[Address(RVA = "0xBE32", Offset = "0xBE32", VA = "0xBE32")]
		public void Spin()
		{
		/* --- GHIDRA: Spin ---
		void Animations_SlotsWheelAnimationBase__Spin(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_SlotsWheelAnimationBase_AnimationStopStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a596b0 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  param3_00 = Animations_SlotsWheelAnimationBase__GetStartAnimationName(param1,param2,param1);
		  uVar2 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x34),0);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x38);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x38),0);
		  }
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  param1_00 = *(undefined4 *)(iVar1 + 0xdc);
		  uVar2 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar2,param1,Method_Animations_SlotsWheelAnimationBase_AnimationStopStateOnComplete__,0
		            );
		  Spine_AnimationState__remove_Dispose(param1_00,uVar2,0);
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_AnimationState__SetCurrent(*(undefined4 *)(iVar1 + 0xdc),0,param3_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06007467 RID: 29799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007467")]
		[Address(RVA = "0xBE33", Offset = "0xBE33", VA = "0xBE33")]
		public void Stop(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		/* --- GHIDRA: Stop ---
		void Animations_SlotsWheelAnimationBase__Stop(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a596b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_SlotsWheelAnimationBase_AnimationStateOnComplete__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_SlotsWheelAnimationBase_AnimationStopStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a596b1 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  uVar1 = Animations_SlotsWheelAnimationBase__AnimationStateOnComplete(param1,param2,param1);
		  uVar4 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if (iVar2 != 0) {
		    UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x34),0);
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x38);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if (iVar2 != 0) {
		    UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x38),0);
		  }
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  uVar5 = *(undefined4 *)(iVar2 + 0xdc);
		  uVar4 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar4,param1,Method_Animations_SlotsWheelAnimationBase_AnimationStateOnComplete__,0);
		  Spine_AnimationState__add_Complete(uVar5,uVar4,0);
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  uVar5 = *(undefined4 *)(iVar2 + 0xdc);
		  uVar4 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar4,param1,Method_Animations_SlotsWheelAnimationBase_AnimationStopStateOnComplete__,0
		            );
		  Spine_AnimationState__add_Complete(uVar5,uVar4,0);
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_AnimationState__SetCurrent(*(undefined4 *)(iVar2 + 0xdc),0,uVar1,0,0);
		  piVar3 = (int *)DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x328) * 4))
		            (piVar3,0,*(undefined4 *)(*piVar3 + 0x32c));
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_Unity_SkeletonGraphic__ApplyAnimation(uVar1,0);
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  *(undefined4 *)(iVar2 + 0x94) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007468")]
		[Address(RVA = "0xBE34", Offset = "0xBE34", VA = "0xBE34")]
		public void Reset(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		/* --- GHIDRA: Reset ---
		void Animations_SlotsWheelAnimationBase__Reset(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_SlotsWheelAnimationBase_AnimationStopStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    DAT_ram_00a596b2 = '\x01';
		  }
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  param1_00 = *(undefined4 *)(iVar1 + 0xdc);
		  uVar2 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar2,param1,Method_Animations_SlotsWheelAnimationBase_AnimationStopStateOnComplete__,0
		            );
		  Spine_AnimationState__add_Complete(param1_00,uVar2,0);
		  Animations_SlotsWheelAnimationBase__AnimationStateOnComplete
		            (param1,*(undefined4 *)(param1 + 0x3c),param1);
		  uVar2 = Animations_SlotsWheelAnimationBase__AnimationStateOnComplete
		                    (param1,*(undefined4 *)(param1 + 0x3c),param1);
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_AnimationState__SetCurrent(*(undefined4 *)(iVar1 + 0xdc),0,uVar2,0,0);
		  piVar3 = (int *)DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x328) * 4))
		            (piVar3,0,*(undefined4 *)(*piVar3 + 0x32c));
		  uVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_Unity_SkeletonGraphic__ApplyAnimation(uVar2,0);
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  *(undefined4 *)(iVar1 + 0x94) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06007469 RID: 29801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007469")]
		[Address(RVA = "0xBE35", Offset = "0xBE35", VA = "0xBE35")]
		private void AnimationStopStateOnComplete(TrackEntry trackEntry)
		{
		/* --- GHIDRA: AnimationStopStateOnComplete ---
		void Animations_SlotsWheelAnimationBase__AnimationStopStateOnComplete
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Animations_SlotsWheelAnimationBase_AnimationStateOnComplete__);
		    Mono_Security_ASN1__get_Item(&Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27351);
		    DAT_ram_00a596b3 = '\x01';
		  }
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  uVar3 = *(undefined4 *)(iVar1 + 0xdc);
		  uVar2 = unnamed_function_1417(Spine_AnimationState_TrackEntryDelegate_TypeInfo);
		  Spine_AnimationState____ctor_b__45_0
		            (uVar2,param1,Method_Animations_SlotsWheelAnimationBase_AnimationStateOnComplete__,0);
		  Spine_AnimationState__add_Complete(uVar3,uVar2,0);
		  iVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  uVar2 = StringLiteral_27351;
		  param1_00 = *(undefined4 *)(iVar1 + 0xdc);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x184));
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,uVar2,0);
		  Spine_AnimationState__SetCurrent(param1_00,0,uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600746A RID: 29802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600746A")]
		[Address(RVA = "0xBE36", Offset = "0xBE36", VA = "0xBE36")]
		private void AnimationStateOnComplete(TrackEntry trackEntry)
		{
		/* --- GHIDRA: AnimationStateOnComplete ---
		undefined4
		Animations_SlotsWheelAnimationBase__AnimationStateOnComplete
		          (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a596b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_23012);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22049);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22661);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21134);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22948);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21243);
		    DAT_ram_00a596b4 = '\x01';
		  }
		  if (param2 - 1U < 7) {
		    param2_00 = *(undefined4 *)(&PTR_StringLiteral_21243_ram_005a362c)[param2 - 1U];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x184));
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,param2_00,0);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600746B")]
		[Address(RVA = "0xBE37", Offset = "0xBE37", VA = "0xBE37")]
		private string GetStartAnimationName(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		/* --- GHIDRA: GetStartAnimationName ---
		undefined4
		Animations_SlotsWheelAnimationBase__GetStartAnimationName(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a596b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22050);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21244);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22949);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21135);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22662);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23013);
		    DAT_ram_00a596b5 = '\x01';
		  }
		  if (param2 - 1U < 7) {
		    param2_00 = *(undefined4 *)(&PTR_StringLiteral_21244_ram_005a3648)[param2 - 1U];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x184));
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,param2_00,0);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600746C")]
		[Address(RVA = "0xBE38", Offset = "0xBE38", VA = "0xBE38")]
		private string GetStopAnimationName(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		/* --- GHIDRA: GetStopAnimationName ---
		undefined4
		Animations_SlotsWheelAnimationBase__GetStopAnimationName
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x184));
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,param2,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600746D")]
		[Address(RVA = "0xBE39", Offset = "0xBE39", VA = "0xBE39")]
		private string GetNameWithPrefix(string name)
		{
			return null;
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600746E")]
		[Address(RVA = "0xBE3A", Offset = "0xBE3A", VA = "0xBE3A")]
		public SlotsWheelAnimationBase()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Animations_SlotsWheelAnimationBase___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a596b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22660);
		    DAT_ram_00a596b6 = '\x01';
		  }
		  return StringLiteral_22660;
		}
		*/

		}

		// Token: 0x04003CFD RID: 15613
		[Token(Token = "0x4003CFD")]
		public const string CHEST_START = "chest_start";

		// Token: 0x04003CFE RID: 15614
		[Token(Token = "0x4003CFE")]
		public const string CHEST_STOP = "chest_stop";

		// Token: 0x04003CFF RID: 15615
		[Token(Token = "0x4003CFF")]
		public const string CLOVER_START = "clover_start";

		// Token: 0x04003D00 RID: 15616
		[Token(Token = "0x4003D00")]
		public const string CLOVER_STOP = "clover_stop";

		// Token: 0x04003D01 RID: 15617
		[Token(Token = "0x4003D01")]
		public const string DIAMOND_START = "diamond_start";

		// Token: 0x04003D02 RID: 15618
		[Token(Token = "0x4003D02")]
		public const string DIAMOND_STOP = "diamond_stop";

		// Token: 0x04003D03 RID: 15619
		[Token(Token = "0x4003D03")]
		public const string ENERGY_START = "energy_start";

		// Token: 0x04003D04 RID: 15620
		[Token(Token = "0x4003D04")]
		public const string ENERGY_STOP = "energy_stop";

		// Token: 0x04003D05 RID: 15621
		[Token(Token = "0x4003D05")]
		public const string ETHYR_START = "ethyr_start";

		// Token: 0x04003D06 RID: 15622
		[Token(Token = "0x4003D06")]
		public const string ETHYR_STOP = "ethyr_stop";

		// Token: 0x04003D07 RID: 15623
		[Token(Token = "0x4003D07")]
		public const string CRYSTAL_START = "crystal_start";

		// Token: 0x04003D08 RID: 15624
		[Token(Token = "0x4003D08")]
		public const string CRYSTAL_STOP = "crystal_stop";

		// Token: 0x04003D09 RID: 15625
		[Token(Token = "0x4003D09")]
		public const string SPIN = "spin";

		// Token: 0x04003D0A RID: 15626
		[Token(Token = "0x4003D0A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ParticleSystem _ps1;

		// Token: 0x04003D0B RID: 15627
		[Token(Token = "0x4003D0B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem _ps2;

		// Token: 0x04003D0C RID: 15628
		[Token(Token = "0x4003D0C")]
		[FieldOffset(Offset = "0x3C")]
		private SlotsWheelAnimationBase.SlotsWheelState _currentState;

		// Token: 0x02001334 RID: 4916
		[Token(Token = "0x2001334")]
		public enum SlotsWheelState
		{
			// Token: 0x04003D0E RID: 15630
			[Token(Token = "0x4003D0E")]
			DiamondChest = 5,
			// Token: 0x04003D0F RID: 15631
			[Token(Token = "0x4003D0F")]
			Clover = 1,
			// Token: 0x04003D10 RID: 15632
			[Token(Token = "0x4003D10")]
			Diamond = 3,
			// Token: 0x04003D11 RID: 15633
			[Token(Token = "0x4003D11")]
			Energy,
			// Token: 0x04003D12 RID: 15634
			[Token(Token = "0x4003D12")]
			Ethyr = 6,
			// Token: 0x04003D13 RID: 15635
			[Token(Token = "0x4003D13")]
			Crystal = 2,
			// Token: 0x04003D14 RID: 15636
			[Token(Token = "0x4003D14")]
			OnyxChest = 7
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Prefix ---
		void Animations_SlotsWheelAnimationBase__get_Prefix(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  uVar1 = Animations_SlotsWheelAnimationBase__AnimationStateOnComplete(param1,param2,param1);
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_AnimationState__SetCurrent(*(undefined4 *)(iVar2 + 0xdc),0,uVar1,0,0);
		  piVar3 = (int *)DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x328) * 4))
		            (piVar3,0,*(undefined4 *)(*piVar3 + 0x32c));
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  Spine_Unity_SkeletonGraphic__ApplyAnimation(uVar1,0);
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  *(undefined4 *)(iVar2 + 0x94) = 0;
		  return;
		}
		*/

}
