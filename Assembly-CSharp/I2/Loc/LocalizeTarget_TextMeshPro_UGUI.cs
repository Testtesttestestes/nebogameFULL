using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200138D RID: 5005
	[Token(Token = "0x200138D")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		// Token: 0x0600771B RID: 30491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771B")]
		[Address(RVA = "0xC07C", Offset = "0xC07C", VA = "0xC07C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x600771C")]
		[Address(RVA = "0xC07D", Offset = "0xC07D", VA = "0xC07D", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
		/* --- GHIDRA: GetPrimaryTermType ---
		undefined4
		I2_Loc_LocalizeTarget_TextMeshPro_UGUI__GetPrimaryTermType
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  return 9;
		}
		*/

			return eTermType.Text;
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x600771D")]
		[Address(RVA = "0xC07E", Offset = "0xC07E", VA = "0xC07E", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x000159C0 File Offset: 0x00013BC0
		[Token(Token = "0x600771E")]
		[Address(RVA = "0xC07F", Offset = "0xC07F", VA = "0xC07F", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x000159D8 File Offset: 0x00013BD8
		[Token(Token = "0x600771F")]
		[Address(RVA = "0xC080", Offset = "0xC080", VA = "0xC080", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x6007720")]
		[Address(RVA = "0xC081", Offset = "0xC081", VA = "0xC081", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_TextMeshPro_UGUI__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60535 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60535 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = **(int **)(param1 + 0xc);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2c8) * 4))
		                      (*(int **)(param1 + 0xc),*(undefined4 *)(iVar1 + 0x2cc));
		  }
		  *param5 = uVar2;
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x90);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 == 0) {
		    *param6 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    return;
		  }
		  uVar2 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                    (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x90),0);
		  *param6 = uVar2;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007721")]
		[Address(RVA = "0xC082", Offset = "0xC082", VA = "0xC082", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_TextMeshPro_UGUI__GetFinalTerms
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int local_10;
		  int local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  local_8 = param4;
		  local_4 = param3;
		  if (DAT_ram_00a60536 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Material___);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_TMP_FontAsset___)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60536 = '\x01';
		  }
		  local_c = 0;
		  local_10 = 0;
		  uVar2 = I2_Loc_Localize__GetObject_object_
		                    (param2,&local_4,&local_8,
		                     Method_I2_Loc_Localize_GetSecondaryTranslatedObj_TMP_FontAsset___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar3 == 0) {
		    uVar2 = I2_Loc_Localize__GetObject_object_
		                      (param2,&local_4,&local_8,
		                       Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Material___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar3 != 0) {
		      uVar4 = TMPro_TMP_Text__set_fontSharedMaterials(*(undefined4 *)(param1 + 0xc),0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,uVar2,0);
		      if (iVar3 != 0) {
		        uVar4 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar2,0);
		        uVar5 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                          (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x90),0);
		        iVar3 = System_String__Substring(uVar4,uVar5,4,0);
		        uVar4 = local_8;
		        if (iVar3 == 0) {
		          uVar5 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar2,0);
		          iVar3 = func_ii_16527(uVar4,uVar5,4,0);
		          uVar4 = local_8;
		          if (iVar3 == 0) {
		            uVar4 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar2,0);
		          }
		          if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		          }
		          uVar4 = I2_Loc_LocalizeTarget_TextMeshPro_Label__DoLocalize(param2,uVar4,&local_10);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		          if (iVar3 != 0) {
		            uVar5 = *(undefined4 *)(param1 + 0xc);
		            if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		              func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		            }
		            I2_Loc_LocalizeTarget_TextMeshPro_Label__InitAlignment_TMPro(uVar5,uVar4,&local_10);
		          }
		        }
		        uVar4 = *(undefined4 *)(param1 + 0xc);
		        if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		        }
		        I2_Loc_LocalizeTarget_TextMeshPro_Label__SetFont(uVar4,uVar2,&local_10);
		      }
		    }
		  }
		  else {
		    uVar4 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		    }
		    I2_Loc_LocalizeTarget_TextMeshPro_Label__InitAlignment_TMPro(uVar4,uVar2,&local_10);
		  }
		  if (*(char *)(param1 + 0x19) != '\0') {
		    *(undefined1 *)(param1 + 0x19) = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    cVar1 = *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		    *(char *)(param1 + 0x18) = cVar1;
		    uVar2 = TMPro_TMP_Text__set_verticalAlignment(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		    }
		    I2_Loc_LocalizeTarget_TextMeshPro_Label__GetTMPFontFromMaterial
		              ((uint)(cVar1 != '\0'),uVar2,param1 + 0x14,param1 + 0x10,&local_10);
		    goto code_r0x81ca279f;
		  }
		  cVar1 = *(char *)(param1 + 0x18);
		  uVar2 = TMPro_TMP_Text__set_verticalAlignment(*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		  }
		  I2_Loc_LocalizeTarget_TextMeshPro_Label__GetTMPFontFromMaterial
		            ((uint)(cVar1 != '\0'),uVar2,&local_10,&local_c,&local_10);
		  if (*(char *)(param1 + 0x18) == '\0') {
		    if (local_10 != *(int *)(param1 + 0x14)) {
		code_r0x81ca2761:
		      *(int *)(param1 + 0x10) = local_c;
		      *(int *)(param1 + 0x14) = local_10;
		    }
		  }
		  else if (local_c != *(int *)(param1 + 0x10)) goto code_r0x81ca2761;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  *(undefined1 *)(param1 + 0x18) =
		       *(undefined1 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		code_r0x81ca279f:
		  if (local_4 != 0) {
		    iVar3 = **(int **)(param1 + 0xc);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2c8) * 4))
		                      (*(int **)(param1 + 0xc),*(undefined4 *)(iVar3 + 0x2cc));
		    iVar3 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (uVar2,local_4,0);
		    if (iVar3 != 0) {
		      if (*(char *)(param2 + 0x41) != '\0') {
		        uVar2 = *(undefined4 *)(param1 + 0xc);
		        iVar3 = 0x10;
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) == '\0') {
		          iVar3 = 0x14;
		        }
		        TMPro_TMP_Text__get_alignment(uVar2,*(undefined4 *)(param1 + iVar3),0);
		      }
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) != '\0') {
		        local_4 = I2_Loc_HindiFixer___c___Fix_b__0_0(local_4,0);
		      }
		      uVar2 = *(undefined4 *)(param1 + 0xc);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      TMPro_TMP_Text__get_isRightToLeftText
		                (uVar2,(uint)*(byte *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd),0
		                );
		      iVar3 = **(int **)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (*(int **)(param1 + 0xc),local_4,*(undefined4 *)(iVar3 + 0x2d4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007722")]
		[Address(RVA = "0xC083", Offset = "0xC083", VA = "0xC083", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_TextMeshPro_UGUI__DoLocalize(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60537 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_TextMeshProUGUI___ctor__);
		    DAT_ram_00a60537 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x19) = 1;
		  *(undefined8 *)(param1 + 0x10) = 0x20100000204;
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_TextMeshProUGUI___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007723 RID: 30499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007723")]
		[Address(RVA = "0xC084", Offset = "0xC084", VA = "0xC084")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_TextMeshPro_UGUI___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityStandard_AudioSource___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_TextMeshPro_UGUI___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a60534 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_TextMeshProUGUI__LocalizeTarget_TextMeshPro_UGUI___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_TextMeshProUGUI__LocalizeTarget_TextMeshPro_UGUI__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_15396);
		    DAT_ram_00a60534 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_TextMeshProUGUI__LocalizeTarget_TextMeshPro_UGUI__TypeInfo
		                        );
		  uVar1 = StringLiteral_15396;
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

		// Token: 0x04003E4E RID: 15950
		[Token(Token = "0x4003E4E")]
		[FieldOffset(Offset = "0x10")]
		public TextAlignmentOptions mAlignment_RTL;

		// Token: 0x04003E4F RID: 15951
		[Token(Token = "0x4003E4F")]
		[FieldOffset(Offset = "0x14")]
		public TextAlignmentOptions mAlignment_LTR;

		// Token: 0x04003E50 RID: 15952
		[Token(Token = "0x4003E50")]
		[FieldOffset(Offset = "0x18")]
		public bool mAlignmentWasRTL;

		// Token: 0x04003E51 RID: 15953
		[Token(Token = "0x4003E51")]
		[FieldOffset(Offset = "0x19")]
		public bool mInitializeAlignment;
	}
}
