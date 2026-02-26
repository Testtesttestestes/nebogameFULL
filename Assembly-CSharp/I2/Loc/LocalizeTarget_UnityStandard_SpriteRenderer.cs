using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001394 RID: 5012
	[Token(Token = "0x2001394")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		// Token: 0x06007754 RID: 30548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007754")]
		[Address(RVA = "0xC0B5", Offset = "0xC0B5", VA = "0xC0B5")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		/* --- GHIDRA: AutoRegister ---
		undefined4
		I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer__AutoRegister
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  return 5;
		}
		*/

		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00015C48 File Offset: 0x00013E48
		[Token(Token = "0x6007755")]
		[Address(RVA = "0xC0B6", Offset = "0xC0B6", VA = "0xC0B6", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00015C60 File Offset: 0x00013E60
		[Token(Token = "0x6007756")]
		[Address(RVA = "0xC0B7", Offset = "0xC0B7", VA = "0xC0B7", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x6007757")]
		[Address(RVA = "0xC0B8", Offset = "0xC0B8", VA = "0xC0B8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x6007758")]
		[Address(RVA = "0xC0B9", Offset = "0xC0B9", VA = "0xC0B9", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x6007759")]
		[Address(RVA = "0xC0BA", Offset = "0xC0BA", VA = "0xC0BA", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6054a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6054a = '\x01';
		  }
		  uVar1 = func_ii_7884(*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
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

		// Token: 0x0600775A RID: 30554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775A")]
		[Address(RVA = "0xC0BB", Offset = "0xC0BB", VA = "0xC0BB", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6054b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_Sprite___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6054b = '\x01';
		  }
		  uVar1 = func_ii_7884(*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if (iVar2 == 0) {
		    uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		    iVar2 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (uVar1,param3,0);
		    if (iVar2 == 0) {
		      return;
		    }
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                    (param2,param3,Method_I2_Loc_Localize_FindTranslatedObject_Sprite___);
		  Core_Extensions_SpriteAtlasExt__TryGetSprite(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775B")]
		[Address(RVA = "0xC0BC", Offset = "0xC0BC", VA = "0xC0BC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer__DoLocalize
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6054c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_SpriteRenderer___ctor__);
		    DAT_ram_00a6054c = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_SpriteRenderer___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775C")]
		[Address(RVA = "0xC0BD", Offset = "0xC0BD", VA = "0xC0BD")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityStandard_TextMesh___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a60549 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_SpriteRenderer__LocalizeTarget_UnityStandard_SpriteRenderer___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_SpriteRenderer__LocalizeTarget_UnityStandard_SpriteRenderer__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_14583);
		    DAT_ram_00a60549 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_SpriteRenderer__LocalizeTarget_UnityStandard_SpriteRenderer__TypeInfo
		                        );
		  uVar1 = StringLiteral_14583;
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
