using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200138C RID: 5004
	[Token(Token = "0x200138C")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		// Token: 0x0600770D RID: 30477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600770D")]
		[Address(RVA = "0xC06E", Offset = "0xC06E", VA = "0xC06E")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00015918 File Offset: 0x00013B18
		[Token(Token = "0x600770E")]
		[Address(RVA = "0xC06F", Offset = "0xC06F", VA = "0xC06F", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x600770F")]
		[Address(RVA = "0xC070", Offset = "0xC070", VA = "0xC070", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x6007710")]
		[Address(RVA = "0xC071", Offset = "0xC071", VA = "0xC071", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00015960 File Offset: 0x00013B60
		[Token(Token = "0x6007711")]
		[Address(RVA = "0xC072", Offset = "0xC072", VA = "0xC072", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00015978 File Offset: 0x00013B78
		[Token(Token = "0x6007712")]
		[Address(RVA = "0xC073", Offset = "0xC073", VA = "0xC073", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6052e == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6052e = '\x01';
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

		// Token: 0x06007713 RID: 30483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007713")]
		[Address(RVA = "0xC074", Offset = "0xC074", VA = "0xC074", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label__GetFinalTerms
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
		  if (DAT_ram_00a6052f == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Material___);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_TMP_FontAsset___)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6052f = '\x01';
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
		    goto code_r0x81ca1d02;
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
		code_r0x81ca1cc4:
		      *(int *)(param1 + 0x10) = local_c;
		      *(int *)(param1 + 0x14) = local_10;
		    }
		  }
		  else if (local_c != *(int *)(param1 + 0x10)) goto code_r0x81ca1cc4;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  *(undefined1 *)(param1 + 0x18) =
		       *(undefined1 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd);
		code_r0x81ca1d02:
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
		      uVar2 = *(undefined4 *)(param1 + 0xc);
		      if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		      }
		      TMPro_TMP_Text__get_isRightToLeftText
		                (uVar2,(uint)*(byte *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd),0
		                );
		      if (*(char *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0xd) != '\0') {
		        local_4 = I2_Loc_HindiFixer___c___Fix_b__0_0(local_4,0);
		      }
		      iVar3 = **(int **)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (*(int **)(param1 + 0xc),local_4,*(undefined4 *)(iVar3 + 0x2d4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007714 RID: 30484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007714")]
		[Address(RVA = "0xC075", Offset = "0xC075", VA = "0xC075", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		undefined4
		I2_Loc_LocalizeTarget_TextMeshPro_Label__DoLocalize(undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  int param2_00;
		  
		  if (DAT_ram_00a60530 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetObject_TMP_FontAsset___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_181);
		    DAT_ram_00a60530 = '\x01';
		  }
		  param1_00 = StringLiteral_181;
		  param2_00 = *(int *)(param2 + 8) + -1;
		  if (0 < param2_00) {
		    do {
		      while( true ) {
		        uVar2 = func_ii_3010(param2,param2_00,0);
		        iVar3 = System_Xml_Schema_XmlSchemaException___ctor(param1_00,uVar2,0);
		        if (-1 < iVar3) break;
		        uVar2 = System_Data_DataSet__ReadXmlSchema(param2,0,param2_00 + 1,0);
		        uVar2 = I2_Loc_Localize__FindTranslatedObject_object_
		                          (param1,uVar2,Method_I2_Loc_Localize_GetObject_TMP_FontAsset___);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		        if (iVar3 != 0) {
		          return uVar2;
		        }
		        if (param2_00 < 1) {
		          return 0;
		        }
		        while( true ) {
		          uVar2 = func_ii_3010(param2,param2_00,0);
		          iVar3 = System_Xml_Schema_XmlSchemaException___ctor(param1_00,uVar2,0);
		          if (-1 < iVar3) break;
		          bVar1 = param2_00 < 2;
		          param2_00 = param2_00 + -1;
		          if (bVar1) {
		            return 0;
		          }
		        }
		      }
		      bVar1 = 1 < param2_00;
		      param2_00 = param2_00 + -1;
		    } while (bVar1);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007715")]
		[Address(RVA = "0xC076", Offset = "0xC076", VA = "0xC076")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
		/* --- GHIDRA: GetTMPFontFromMaterial ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label__GetTMPFontFromMaterial
		               (int param1,char *param2,undefined4 *param3,undefined4 *param4,undefined4 param5)
		
		{
		  *param4 = param2;
		  *param3 = param2;
		  if (param1 == 0) {
		    if ((int)param2 < 0x405) {
		      if ((int)param2 < 0x202) {
		        if (param2 == (char *)0x101) {
		          *param4 = 0x104;
		          return;
		        }
		        if ((param2 != (char *)0x102) && (param2 != (char *)0x103)) {
		          if (param2 == (char *)0x104) {
		            *param4 = 0x101;
		            return;
		          }
		          if (param2 == (char *)0x201) {
		            *param4 = 0x204;
		            return;
		          }
		        }
		      }
		      else {
		        if (param2 == (char *)0x401) {
		          *param4 = &DAT_ram_00000404;
		          return;
		        }
		        if ((param2 != (char *)0x402) && (param2 != (char *)0x403)) {
		          if (param2 == &DAT_ram_00000404) {
		            *param4 = 0x401;
		            return;
		          }
		          if (param2 == (char *)0x204) {
		            *param4 = 0x201;
		            return;
		          }
		        }
		      }
		    }
		    else if (param2 < s_struct_Uniforms___color__array<v_ram_00000f84 + 0x7e) {
		      if (param2 == s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ac) {
		        *param4 = s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1af;
		        return;
		      }
		      if ((param2 != s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ad) &&
		         (param2 != s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ae)) {
		        if (param2 == s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1af) {
		          *param4 = s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ac;
		          return;
		        }
		        if (param2 == s_struct_Uniforms___color__array<v_ram_00000f84 + 0x7d) {
		          *param4 = s_struct_Uniforms___color__array<v_ram_00000f84 + 0x80;
		          return;
		        }
		      }
		    }
		    else if (param2 == s_struct_Uniforms___color__array<v_ram_00001f04 + 0xfd) {
		      *param4 = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x100;
		    }
		    else if ((param2 != s_struct_Uniforms___color__array<v_ram_00001f04 + 0xfe) &&
		            (param2 != s_struct_Uniforms___color__array<v_ram_00001f04 + 0xff)) {
		      if (param2 == s_struct_Uniforms___color__array<v_ram_00001f04 + 0x100) {
		        *param4 = s_struct_Uniforms___color__array<v_ram_00001f04 + 0xfd;
		        return;
		      }
		      if (param2 == s_struct_Uniforms___color__array<v_ram_00000f84 + 0x80) {
		        *param4 = s_struct_Uniforms___color__array<v_ram_00000f84 + 0x7d;
		        return;
		      }
		    }
		  }
		  else if ((int)param2 < 0x405) {
		    if ((int)param2 < 0x202) {
		      if (param2 == (char *)0x101) {
		        *param3 = 0x104;
		        return;
		      }
		      if ((param2 != (char *)0x102) && (param2 != (char *)0x103)) {
		        if (param2 == (char *)0x104) {
		          *param3 = 0x101;
		          return;
		        }
		        if (param2 == (char *)0x201) {
		          *param3 = 0x204;
		          return;
		        }
		      }
		    }
		    else {
		      if (param2 == (char *)0x401) {
		        *param3 = &DAT_ram_00000404;
		        return;
		      }
		      if ((param2 != (char *)0x402) && (param2 != (char *)0x403)) {
		        if (param2 == &DAT_ram_00000404) {
		          *param3 = 0x401;
		          return;
		        }
		        if (param2 == (char *)0x204) {
		          *param3 = 0x201;
		          return;
		        }
		      }
		    }
		  }
		  else if (param2 < s_struct_Uniforms___color__array<v_ram_00000f84 + 0x7e) {
		    if (param2 == s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ac) {
		      *param3 = s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1af;
		      return;
		    }
		    if ((param2 != s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ad) &&
		       (param2 != s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ae)) {
		      if (param2 == s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1af) {
		        *param3 = s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1ac;
		        return;
		      }
		      if (param2 == s_struct_Uniforms___color__array<v_ram_00000f84 + 0x7d) {
		        *param3 = s_struct_Uniforms___color__array<v_ram_00000f84 + 0x80;
		        return;
		      }
		    }
		  }
		  else {
		    if (param2 == s_struct_Uniforms___color__array<v_ram_00001f04 + 0xfd) {
		      *param3 = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x100;
		      return;
		    }
		    if ((param2 != s_struct_Uniforms___color__array<v_ram_00001f04 + 0xfe) &&
		       (param2 != s_struct_Uniforms___color__array<v_ram_00001f04 + 0xff)) {
		      if (param2 == s_struct_Uniforms___color__array<v_ram_00001f04 + 0x100) {
		        *param3 = s_struct_Uniforms___color__array<v_ram_00001f04 + 0xfd;
		        return;
		      }
		      if (param2 == s_struct_Uniforms___color__array<v_ram_00000f84 + 0x80) {
		        *param3 = s_struct_Uniforms___color__array<v_ram_00000f84 + 0x7d;
		        return;
		      }
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007716")]
		[Address(RVA = "0xC077", Offset = "0xC077", VA = "0xC077")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		/* --- GHIDRA: InitAlignment_TMPro ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label__InitAlignment_TMPro
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  while( true ) {
		    if (DAT_ram_00a60531 == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a60531 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x90);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,param2,0);
		    if (iVar1 != 0) {
		      TMPro_TMP_Text__get_font(param1,param2,0);
		    }
		    uVar2 = *(undefined4 *)(param1 + 600);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar1 == 0) break;
		    param1 = *(int *)(param1 + 600);
		    if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007717")]
		[Address(RVA = "0xC078", Offset = "0xC078", VA = "0xC078")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		/* --- GHIDRA: SetFont ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label__SetFont
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  while( true ) {
		    if (DAT_ram_00a60532 == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a60532 = '\x01';
		    }
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x2d8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x2dc));
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,param2,0);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e0) * 4))
		                (param1,param2,*(undefined4 *)(*param1 + 0x2e4));
		    }
		    iVar1 = param1[0x96];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar1,0,0);
		    if (iVar1 == 0) break;
		    param1 = (int *)param1[0x96];
		    if (*(int *)(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LocalizeTarget_TextMeshPro_Label_TypeInfo);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007718")]
		[Address(RVA = "0xC079", Offset = "0xC079", VA = "0xC079")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		/* --- GHIDRA: SetMaterial ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label__SetMaterial(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60533 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_TextMeshPro___ctor__);
		    DAT_ram_00a60533 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x19) = 1;
		  *(undefined8 *)(param1 + 0x10) = 0x20100000204;
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_TextMeshPro___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007719")]
		[Address(RVA = "0xC07A", Offset = "0xC07A", VA = "0xC07A")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_TextMeshPro_UGUI___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_TextMeshPro_Label___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a6052d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_TextMeshPro__LocalizeTarget_TextMeshPro_Label___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_TextMeshPro__LocalizeTarget_TextMeshPro_Label__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_15395);
		    DAT_ram_00a6052d = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_TextMeshPro__LocalizeTarget_TextMeshPro_Label__TypeInfo
		                        );
		  uVar1 = StringLiteral_15395;
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

		// Token: 0x04003E4A RID: 15946
		[Token(Token = "0x4003E4A")]
		[FieldOffset(Offset = "0x10")]
		private TextAlignmentOptions mAlignment_RTL;

		// Token: 0x04003E4B RID: 15947
		[Token(Token = "0x4003E4B")]
		[FieldOffset(Offset = "0x14")]
		private TextAlignmentOptions mAlignment_LTR;

		// Token: 0x04003E4C RID: 15948
		[Token(Token = "0x4003E4C")]
		[FieldOffset(Offset = "0x18")]
		private bool mAlignmentWasRTL;

		// Token: 0x04003E4D RID: 15949
		[Token(Token = "0x4003E4D")]
		[FieldOffset(Offset = "0x19")]
		private bool mInitializeAlignment;
	}
}
