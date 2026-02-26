using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200138E RID: 5006
	[Token(Token = "0x200138E")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		// Token: 0x06007725 RID: 30501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007725")]
		[Address(RVA = "0xC086", Offset = "0xC086", VA = "0xC086")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x6007726")]
		[Address(RVA = "0xC087", Offset = "0xC087", VA = "0xC087", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x6007727")]
		[Address(RVA = "0xC088", Offset = "0xC088", VA = "0xC088", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00015A38 File Offset: 0x00013C38
		[Token(Token = "0x6007728")]
		[Address(RVA = "0xC089", Offset = "0xC089", VA = "0xC089", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x6007729")]
		[Address(RVA = "0xC08A", Offset = "0xC08A", VA = "0xC08A", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00015A68 File Offset: 0x00013C68
		[Token(Token = "0x600772A")]
		[Address(RVA = "0xC08B", Offset = "0xC08B", VA = "0xC08B", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityStandard_AudioSource__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60539 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60539 = '\x01';
		  }
		  uVar1 = UnityEngine_AudioSource__set_pitch(*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  if (iVar2 == 0) {
		    uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		  }
		  *param5 = uVar1;
		  *param6 = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772B")]
		[Address(RVA = "0xC08C", Offset = "0xC08C", VA = "0xC08C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_AudioSource__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a6053a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_AudioClip___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6053a = '\x01';
		  }
		  iVar1 = UnityEngine_AudioSource__PlayOneShot(*(undefined4 *)(param1 + 0xc),0);
		  if ((iVar1 == 0) &&
		     (iVar1 = UnityEngine_AudioSource__PlayClipAtPoint(*(undefined4 *)(param1 + 0xc),0), iVar1 == 0)
		     ) {
		    iVar1 = 0;
		  }
		  else {
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    iVar1 = func_ii_3441(0);
		  }
		  uVar2 = UnityEngine_AudioSource__set_pitch(*(undefined4 *)(param1 + 0xc),0);
		  param2_00 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                        (param2,param3,Method_I2_Loc_Localize_FindTranslatedObject_AudioClip___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,param2_00,0);
		  if (iVar3 != 0) {
		    UnityEngine_AudioSource__get_resource(*(undefined4 *)(param1 + 0xc),param2_00,0);
		  }
		  if (iVar1 != 0) {
		    uVar2 = UnityEngine_AudioSource__set_pitch(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 != 0) {
		      UnityEngine_AudioSource__get_outputAudioMixerGroup(*(undefined4 *)(param1 + 0xc),0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772C")]
		[Address(RVA = "0xC08D", Offset = "0xC08D", VA = "0xC08D", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityStandard_AudioSource__DoLocalize
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6053b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_AudioSource___ctor__);
		    DAT_ram_00a6053b = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_AudioSource___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772D")]
		[Address(RVA = "0xC08E", Offset = "0xC08E", VA = "0xC08E")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_AudioSource___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a60538 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_AudioSource__LocalizeTarget_UnityStandard_AudioSource___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_AudioSource__LocalizeTarget_UnityStandard_AudioSource__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3436);
		    DAT_ram_00a60538 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_AudioSource__LocalizeTarget_UnityStandard_AudioSource__TypeInfo
		                        );
		  uVar1 = StringLiteral_3436;
		  *(undefined4 *)(param1_00 + 0xc) = 100;
		  *(undefined4 *)(param1_00 + 8) = uVar1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__DetectDeviceLanguage(param1_00,param1_00);
		  return;
		}
		*/

		}
	}
}
