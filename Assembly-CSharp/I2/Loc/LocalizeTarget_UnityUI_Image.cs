using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02001397 RID: 5015
	[Token(Token = "0x2001397")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		// Token: 0x06007772 RID: 30578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007772")]
		[Address(RVA = "0xC0D3", Offset = "0xC0D3", VA = "0xC0D3")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x6007773")]
		[Address(RVA = "0xC0D4", Offset = "0xC0D4", VA = "0xC0D4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x6007774")]
		[Address(RVA = "0xC0D5", Offset = "0xC0D5", VA = "0xC0D5", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x6007775")]
		[Address(RVA = "0xC0D6", Offset = "0xC0D6", VA = "0xC0D6", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		undefined4
		I2_Loc_LocalizeTarget_UnityUI_Image__AllowSecondTermToBeRTL
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54de9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54de9 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x80);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = 2;
		  iVar1 = func_ii_3812(param1_00,0,0);
		  if (iVar1 == 0) {
		    uVar2 = 5;
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00015DF8 File Offset: 0x00013FF8
		[Token(Token = "0x6007776")]
		[Address(RVA = "0xC0D7", Offset = "0xC0D7", VA = "0xC0D7", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x6007777")]
		[Address(RVA = "0xC0D8", Offset = "0xC0D8", VA = "0xC0D8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
		/* --- GHIDRA: GetSecondaryTermType ---
		void I2_Loc_LocalizeTarget_UnityUI_Image__GetSecondaryTermType
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a54dea == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1480);
		    DAT_ram_00a54dea = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0xc);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1d8) * 4))
		                    (*(int **)(param1 + 0xc),*(undefined4 *)(iVar2 + 0x1dc));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  uVar1 = StringLiteral_5;
		  if (iVar2 != 0) {
		    iVar2 = **(int **)(param1 + 0xc);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1d8) * 4))
		                      (*(int **)(param1 + 0xc),*(undefined4 *)(iVar2 + 0x1dc));
		    uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		  }
		  *param5 = uVar1;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x80);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                      (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x80),0);
		    iVar2 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (uVar1,*param5,0);
		    if (iVar2 != 0) {
		      param1_00 = *param5;
		      uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                        (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x80),0);
		      uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (param1_00,StringLiteral_1480,uVar1,0);
		      *param5 = uVar1;
		    }
		  }
		  *param6 = 0;
		  return;
		}
		*/

			return eTermType.Text;
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007778")]
		[Address(RVA = "0xC0D9", Offset = "0xC0D9", VA = "0xC0D9", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityUI_Image__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54deb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_Sprite___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54deb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x80);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 == 0) {
		    uVar2 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar2,0);
		    iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (uVar2,param3,0);
		    if (iVar1 == 0) {
		      return;
		    }
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xc);
		  uVar2 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                    (param2,param3,Method_I2_Loc_Localize_FindTranslatedObject_Sprite___);
		  func_ii_7050(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007779")]
		[Address(RVA = "0xC0DA", Offset = "0xC0DA", VA = "0xC0DA", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityUI_Image__DoLocalize(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54dec == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_Image___ctor__);
		    DAT_ram_00a54dec = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_Image___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600777A RID: 30586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600777A")]
		[Address(RVA = "0xC0DB", Offset = "0xC0DB", VA = "0xC0DB")]
		public LocalizeTarget_UnityUI_Image()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityUI_Image___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityUI_RawImage___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityUI_Image___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a54de8 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizeTargetDesc_Type_Image__LocalizeTarget_UnityUI_Image___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&I2_Loc_LocalizeTargetDesc_Type_Image__LocalizeTarget_UnityUI_Image__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9270);
		    DAT_ram_00a54de8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_Image__LocalizeTarget_UnityUI_Image__TypeInfo
		                        );
		  uVar1 = StringLiteral_9270;
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
	}
}
