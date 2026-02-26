using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001395 RID: 5013
	[Token(Token = "0x2001395")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		// Token: 0x0600775E RID: 30558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775E")]
		[Address(RVA = "0xC0BF", Offset = "0xC0BF", VA = "0xC0BF")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x600775F")]
		[Address(RVA = "0xC0C0", Offset = "0xC0C0", VA = "0xC0C0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x6007760")]
		[Address(RVA = "0xC0C1", Offset = "0xC0C1", VA = "0xC0C1", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x6007761")]
		[Address(RVA = "0xC0C2", Offset = "0xC0C2", VA = "0xC0C2", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x6007762")]
		[Address(RVA = "0xC0C3", Offset = "0xC0C3", VA = "0xC0C3", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x6007763")]
		[Address(RVA = "0xC0C4", Offset = "0xC0C4", VA = "0xC0C4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityStandard_TextMesh__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a54de1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54de1 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  if (iVar2 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = UnityEngine_TextGenerator_BindingsMarshaller__ConvertToNative
		                      (*(undefined4 *)(param1 + 0xc),0);
		  }
		  *param5 = uVar3;
		  iVar2 = func_ii_4769(param4,0);
		  if (iVar2 != 0) {
		    uVar3 = UnityEngine_TextMesh__set_text(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		    if (iVar2 != 0) {
		      uVar3 = UnityEngine_TextMesh__set_text(*(undefined4 *)(param1 + 0xc),0);
		      uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar3,0);
		    }
		  }
		  *param6 = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007764")]
		[Address(RVA = "0xC0C5", Offset = "0xC0C5", VA = "0xC0C5", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_TextMesh__GetFinalTerms
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  char cVar4;
		  undefined4 local_8;
		  int local_4;
		  
		  local_8 = param4;
		  local_4 = param3;
		  if (DAT_ram_00a54de2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_MeshRenderer___);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Font___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54de2 = '\x01';
		  }
		  uVar1 = I2_Loc_Localize__GetObject_object_
		                    (param2,&local_4,&local_8,
		                     Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Font___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar3 = UnityEngine_TextMesh__set_text(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,uVar1,0);
		    if (iVar2 != 0) {
		      UnityEngine_TextMesh__get_font(*(undefined4 *)(param1 + 0xc),uVar1,0);
		      uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                        (*(undefined4 *)(param1 + 0xc),
		                         Method_UnityEngine_Component_GetComponentInChildren_MeshRenderer___);
		      uVar1 = UnityEngine_Font__remove_textureRebuilt(uVar1,0);
		      UnityEngine_Renderer__get_sharedMaterial(uVar3,uVar1,0);
		    }
		  }
		  if (*(char *)(param1 + 0x19) != '\0') {
		    *(undefined1 *)(param1 + 0x19) = 0;
		    uVar1 = UnityEngine_TextMesh__set_font(*(undefined4 *)(param1 + 0xc),0);
		    *(undefined4 *)(param1 + 0x14) = uVar1;
		    *(undefined4 *)(param1 + 0x10) = uVar1;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    iVar2 = I2_Loc_LocalizationManager_TypeInfo;
		    cVar4 = *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		    if ((cVar4 != '\0') && (*(int *)(param1 + 0x10) == 2)) {
		      *(undefined4 *)(param1 + 0x14) = 0;
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		      cVar4 = *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		    }
		    if ((cVar4 == '\0') && (*(int *)(param1 + 0x14) == 0)) {
		      *(undefined4 *)(param1 + 0x10) = 2;
		    }
		  }
		  if (local_4 != 0) {
		    uVar1 = UnityEngine_TextGenerator_BindingsMarshaller__ConvertToNative
		                      (*(undefined4 *)(param1 + 0xc),0);
		    iVar2 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (uVar1,local_4,0);
		    if (iVar2 != 0) {
		      if ((*(char *)(param2 + 0x41) != '\0') &&
		         (iVar2 = UnityEngine_TextMesh__set_font(*(undefined4 *)(param1 + 0xc),0), iVar2 != 1)) {
		        uVar1 = *(undefined4 *)(param1 + 0xc);
		        iVar2 = 0x10;
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) == '\0') {
		          iVar2 = 0x14;
		        }
		        UnityEngine_TextMesh__get_alignment(uVar1,*(undefined4 *)(param1 + iVar2),0);
		      }
		      uVar1 = UnityEngine_TextMesh__set_text(*(undefined4 *)(param1 + 0xc),0);
		      UnityEngine_Font__RequestCharactersInTexture(uVar1,local_4,0);
		      UnityEngine_TextMesh__get_text(*(undefined4 *)(param1 + 0xc),local_4,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007765")]
		[Address(RVA = "0xC0C6", Offset = "0xC0C6", VA = "0xC0C6", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityStandard_TextMesh__DoLocalize(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54de3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_TextMesh___ctor__);
		    DAT_ram_00a54de3 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x19) = 1;
		  *(undefined4 *)(param1 + 0x10) = 2;
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_TextMesh___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007766")]
		[Address(RVA = "0xC0C7", Offset = "0xC0C7", VA = "0xC0C7")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_TextMesh___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_TextMesh___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a54de0 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_TextMesh__LocalizeTarget_UnityStandard_TextMesh___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_TextMesh__LocalizeTarget_UnityStandard_TextMesh__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_15394);
		    DAT_ram_00a54de0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_TextMesh__LocalizeTarget_UnityStandard_TextMesh__TypeInfo
		                        );
		  uVar1 = StringLiteral_15394;
		  *(undefined4 *)(param1_00 + 0xc) = 100;
		  *(undefined4 *)(param1_00 + 8) = uVar1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__DetectDeviceLanguage(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04003E52 RID: 15954
		[Token(Token = "0x4003E52")]
		[FieldOffset(Offset = "0x10")]
		private TextAlignment mAlignment_RTL;

		// Token: 0x04003E53 RID: 15955
		[Token(Token = "0x4003E53")]
		[FieldOffset(Offset = "0x14")]
		private TextAlignment mAlignment_LTR;

		// Token: 0x04003E54 RID: 15956
		[Token(Token = "0x4003E54")]
		[FieldOffset(Offset = "0x18")]
		private bool mAlignmentWasRTL;

		// Token: 0x04003E55 RID: 15957
		[Token(Token = "0x4003E55")]
		[FieldOffset(Offset = "0x19")]
		private bool mInitializeAlignment;
	}
}
