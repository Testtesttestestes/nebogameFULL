using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02001399 RID: 5017
	[Token(Token = "0x2001399")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		// Token: 0x06007786 RID: 30598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007786")]
		[Address(RVA = "0xC0E7", Offset = "0xC0E7", VA = "0xC0E7")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00015EA0 File Offset: 0x000140A0
		[Token(Token = "0x6007787")]
		[Address(RVA = "0xC0E8", Offset = "0xC0E8", VA = "0xC0E8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x6007788")]
		[Address(RVA = "0xC0E9", Offset = "0xC0E9", VA = "0xC0E9", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x6007789")]
		[Address(RVA = "0xC0EA", Offset = "0xC0EA", VA = "0xC0EA", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x600778A")]
		[Address(RVA = "0xC0EB", Offset = "0xC0EB", VA = "0xC0EB", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x00015F00 File Offset: 0x00014100
		[Token(Token = "0x600778B")]
		[Address(RVA = "0xC0EC", Offset = "0xC0EC", VA = "0xC0EC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityUI_Text__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54df2 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54df2 = '\x01';
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
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x310) * 4))
		                      (*(int **)(param1 + 0xc),*(undefined4 *)(iVar1 + 0x314));
		  }
		  *param5 = uVar2;
		  uVar2 = UnityEngine_UI_Text__get_mainTexture(*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 == 0) {
		    *param6 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    return;
		  }
		  uVar2 = UnityEngine_UI_Text__get_mainTexture(*(undefined4 *)(param1 + 0xc),0);
		  uVar2 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar2,0);
		  *param6 = uVar2;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778C")]
		[Address(RVA = "0xC0ED", Offset = "0xC0ED", VA = "0xC0ED", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityUI_Text__GetFinalTerms
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  char cVar1;
		  uint uVar2;
		  undefined *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param2_00;
		  uint uVar6;
		  undefined *puVar7;
		  undefined4 local_8;
		  int local_4;
		  
		  local_8 = param4;
		  local_4 = param3;
		  if (DAT_ram_00a54df3 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Font___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54df3 = '\x01';
		  }
		  uVar4 = I2_Loc_Localize__GetObject_object_
		                    (param2,&local_4,&local_8,
		                     Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Font___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if (iVar5 != 0) {
		    param2_00 = UnityEngine_UI_Text__get_mainTexture(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar5 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,param2_00,0);
		    if (iVar5 != 0) {
		      UnityEngine_UI_Text__get_font(*(undefined4 *)(param1 + 0xc),uVar4,0);
		    }
		  }
		  if (*(char *)(param1 + 0x19) != '\0') {
		    *(undefined1 *)(param1 + 0x19) = 0;
		    if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		    }
		    cVar1 = *(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		    *(char *)(param1 + 0x18) = cVar1;
		    iVar5 = UnityEngine_UI_Text__set_resizeTextMaxSize(*(undefined4 *)(param1 + 0xc),0);
		    *(int *)(param1 + 0x14) = iVar5;
		    *(int *)(param1 + 0x10) = iVar5;
		    if (cVar1 == '\0') {
		      if (iVar5 == 0) {
		        *(undefined4 *)(param1 + 0x10) = 2;
		      }
		      else if (iVar5 != 1) {
		        if (iVar5 == 2) {
		          *(undefined4 *)(param1 + 0x10) = 0;
		        }
		        else if (iVar5 == 3) {
		          *(undefined4 *)(param1 + 0x10) = 5;
		        }
		        else if (iVar5 != 4) {
		          if (iVar5 == 5) {
		            *(undefined4 *)(param1 + 0x10) = 3;
		          }
		          else if (iVar5 == 6) {
		            *(undefined4 *)(param1 + 0x10) = 8;
		          }
		          else if ((iVar5 != 7) && (iVar5 == 8)) {
		            *(undefined4 *)(param1 + 0x10) = 6;
		          }
		        }
		      }
		    }
		    else if (iVar5 == 0) {
		      *(undefined4 *)(param1 + 0x14) = 2;
		    }
		    else if (iVar5 != 1) {
		      if (iVar5 == 2) {
		        *(undefined4 *)(param1 + 0x14) = 0;
		      }
		      else if (iVar5 == 3) {
		        *(undefined4 *)(param1 + 0x14) = 5;
		      }
		      else if (iVar5 != 4) {
		        if (iVar5 == 5) {
		          *(undefined4 *)(param1 + 0x14) = 3;
		        }
		        else if (iVar5 == 6) {
		          *(undefined4 *)(param1 + 0x14) = 8;
		        }
		        else if ((iVar5 != 7) && (iVar5 == 8)) {
		          *(undefined4 *)(param1 + 0x14) = 6;
		        }
		      }
		    }
		    goto code_r0x80b1d671;
		  }
		  cVar1 = *(char *)(param1 + 0x18);
		  uVar6 = UnityEngine_UI_Text__set_resizeTextMaxSize(*(undefined4 *)(param1 + 0xc),0);
		  uVar2 = uVar6;
		  if (cVar1 == '\0') {
		    if ((uVar6 < 9) && ((0x16dU >> (uVar6 & 0x1f) & 1) != 0)) {
		      puVar3 = &DAT_ram_005a358c;
		      puVar7 = &DAT_ram_005a35b0;
		code_r0x80b1d5f4:
		      iVar5 = uVar6 * 4;
		      uVar6 = *(uint *)(puVar7 + iVar5);
		      uVar2 = *(uint *)(puVar3 + iVar5);
		    }
		  }
		  else if ((uVar6 < 9) && ((0x16dU >> (uVar6 & 0x1f) & 1) != 0)) {
		    puVar3 = &DAT_ram_005a35b0;
		    puVar7 = &DAT_ram_005a358c;
		    goto code_r0x80b1d5f4;
		  }
		  if (*(char *)(param1 + 0x18) == '\0') {
		    if (*(uint *)(param1 + 0x14) != uVar6) {
		code_r0x80b1d633:
		      *(uint *)(param1 + 0x10) = uVar2;
		      *(uint *)(param1 + 0x14) = uVar6;
		    }
		  }
		  else if (*(uint *)(param1 + 0x10) != uVar2) goto code_r0x80b1d633;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  *(undefined1 *)(param1 + 0x18) =
		       *(undefined1 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		code_r0x80b1d671:
		  if (local_4 != 0) {
		    iVar5 = **(int **)(param1 + 0xc);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x310) * 4))
		                      (*(int **)(param1 + 0xc),*(undefined4 *)(iVar5 + 0x314));
		    iVar5 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (uVar4,local_4,0);
		    if (iVar5 != 0) {
		      if (*(char *)(param2 + 0x41) != '\0') {
		        uVar4 = *(undefined4 *)(param1 + 0xc);
		        iVar5 = 0x10;
		        if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		        }
		        if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) == '\0') {
		          iVar5 = 0x14;
		        }
		        UnityEngine_UI_Text__get_alignment(uVar4,*(undefined4 *)(param1 + iVar5),0);
		      }
		      iVar5 = **(int **)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x318) * 4))
		                (*(int **)(param1 + 0xc),local_4,*(undefined4 *)(iVar5 + 0x31c));
		      iVar5 = **(int **)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x1a0) * 4))
		                (*(int **)(param1 + 0xc),*(undefined4 *)(iVar5 + 0x1a4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778D")]
		[Address(RVA = "0xC0EE", Offset = "0xC0EE", VA = "0xC0EE", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityUI_Text__DoLocalize
		               (undefined4 param1,int param2,int param3,int *param4,int *param5,undefined4 param6)
		
		{
		  *param5 = param3;
		  *param4 = param3;
		  if (param2 == 0) {
		    if (param3 == 0) {
		      *param5 = 2;
		      return;
		    }
		    if (param3 != 1) {
		      if (param3 == 2) {
		        *param5 = 0;
		        return;
		      }
		      if (param3 == 3) {
		        *param5 = 5;
		        return;
		      }
		      if (param3 != 4) {
		        if (param3 == 5) {
		          *param5 = 3;
		          return;
		        }
		        if (param3 == 6) {
		          *param5 = 8;
		        }
		        else if ((param3 != 7) && (param3 == 8)) {
		          *param5 = 6;
		          return;
		        }
		      }
		    }
		  }
		  else {
		    if (param3 == 0) {
		      *param4 = 2;
		      return;
		    }
		    if (param3 != 1) {
		      if (param3 == 2) {
		        *param4 = 0;
		        return;
		      }
		      if (param3 == 3) {
		        *param4 = 5;
		        return;
		      }
		      if (param3 != 4) {
		        if (param3 == 5) {
		          *param4 = 3;
		          return;
		        }
		        if (param3 == 6) {
		          *param4 = 8;
		          return;
		        }
		        if ((param3 != 7) && (param3 == 8)) {
		          *param4 = 6;
		          return;
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600778E RID: 30606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778E")]
		[Address(RVA = "0xC0EF", Offset = "0xC0EF", VA = "0xC0EF")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		/* --- GHIDRA: InitAlignment ---
		void I2_Loc_LocalizeTarget_UnityUI_Text__InitAlignment(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54df4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_Text___ctor__);
		    DAT_ram_00a54df4 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x19) = 1;
		  *(undefined4 *)(param1 + 0x10) = 2;
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_Text___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778F")]
		[Address(RVA = "0xC0F0", Offset = "0xC0F0", VA = "0xC0F0")]
		public LocalizeTarget_UnityUI_Text()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		I2_Loc_LocalizeTarget_UnityUI_Text___ctor
		          (int param1,int param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a54df5 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SpecializationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18854);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18955);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54df5 = '\x01';
		  }
		  param1_00 = *(int *)(*(int *)(param1 + 0x14) + param2 * 4 + 0x10);
		  if (param1_00 != 0) {
		    if (*(int *)(I2_Loc_SpecializationManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_SpecializationManager_TypeInfo);
		    }
		    uVar1 = I2_Loc_SpecializationManager___ctor(param1_00,param3,0);
		    if (param4 == 0) {
		      uVar1 = func_ii_7088(uVar1,StringLiteral_18955,StringLiteral_5,0);
		      uVar1 = func_ii_7088(uVar1,StringLiteral_18854,StringLiteral_5,0);
		    }
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityUI_Text___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a54df1 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizeTargetDesc_Type_Text__LocalizeTarget_UnityUI_Text___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&I2_Loc_LocalizeTargetDesc_Type_Text__LocalizeTarget_UnityUI_Text__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15379);
		    DAT_ram_00a54df1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (I2_Loc_LocalizeTargetDesc_Type_Text__LocalizeTarget_UnityUI_Text__TypeInfo)
		  ;
		  uVar1 = StringLiteral_15379;
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

		// Token: 0x04003E56 RID: 15958
		[Token(Token = "0x4003E56")]
		[FieldOffset(Offset = "0x10")]
		private TextAnchor mAlignment_RTL;

		// Token: 0x04003E57 RID: 15959
		[Token(Token = "0x4003E57")]
		[FieldOffset(Offset = "0x14")]
		private TextAnchor mAlignment_LTR;

		// Token: 0x04003E58 RID: 15960
		[Token(Token = "0x4003E58")]
		[FieldOffset(Offset = "0x18")]
		private bool mAlignmentWasRTL;

		// Token: 0x04003E59 RID: 15961
		[Token(Token = "0x4003E59")]
		[FieldOffset(Offset = "0x19")]
		private bool mInitializeAlignment;
	}
}
