using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001391 RID: 5009
	[Token(Token = "0x2001391")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		// Token: 0x0600773C RID: 30524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773C")]
		[Address(RVA = "0xC09D", Offset = "0xC09D", VA = "0xC09D")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		/* --- GHIDRA: AutoRegister ---
		undefined4
		I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer__AutoRegister
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  return 8;
		}
		*/

		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x600773D")]
		[Address(RVA = "0xC09E", Offset = "0xC09E", VA = "0xC09E", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
		/* --- GHIDRA: GetPrimaryTermType ---
		undefined4
		I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer__GetPrimaryTermType
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  return 6;
		}
		*/

			return eTermType.Text;
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x600773E")]
		[Address(RVA = "0xC09F", Offset = "0xC09F", VA = "0xC09F", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x600773F")]
		[Address(RVA = "0xC0A0", Offset = "0xC0A0", VA = "0xC0A0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00015B70 File Offset: 0x00013D70
		[Token(Token = "0x6007740")]
		[Address(RVA = "0xC0A1", Offset = "0xC0A1", VA = "0xC0A1", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x6007741")]
		[Address(RVA = "0xC0A2", Offset = "0xC0A2", VA = "0xC0A2", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a60541 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MeshFilter___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60541 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = func_ii_3812(uVar3,0,0);
		  if (iVar2 == 0) {
		    uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0xc),
		                         Method_UnityEngine_Component_GetComponent_MeshFilter___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar1 = 0;
		    iVar2 = func_ii_3812(uVar3,0,0);
		    if (iVar2 == 0) {
		      param1_00 = UnityEngine_MeshFilter__DontStripMeshFilter(uVar3,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = func_ii_3812(param1_00,0,0);
		      if (iVar2 == 0) {
		        uVar3 = UnityEngine_MeshFilter__DontStripMeshFilter(uVar3,0);
		        uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar3,0);
		      }
		    }
		  }
		  else {
		    *param6 = 0;
		  }
		  *param5 = uVar1;
		  uVar1 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = 0;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if (iVar2 == 0) {
		    uVar1 = UnityEngine_Renderer__set_material(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = func_ii_3812(uVar1,0,0);
		    if (iVar2 == 0) {
		      uVar3 = UnityEngine_Renderer__set_material(*(undefined4 *)(param1 + 0xc),0);
		      uVar3 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar3,0);
		    }
		  }
		  *param6 = uVar3;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007742")]
		[Address(RVA = "0xC0A3", Offset = "0xC0A3", VA = "0xC0A3", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_8 = param4;
		  local_4 = param3;
		  if (DAT_ram_00a60542 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MeshFilter___);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_Mesh___);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Material___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60542 = '\x01';
		  }
		  uVar1 = I2_Loc_Localize__GetObject_object_
		                    (param2,&local_4,&local_8,
		                     Method_I2_Loc_Localize_GetSecondaryTranslatedObj_Material___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar3 = UnityEngine_Renderer__set_material(*(undefined4 *)(param1 + 0xc),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,uVar1,0);
		    if (iVar2 != 0) {
		      UnityEngine_Renderer__get_sharedMaterial(*(undefined4 *)(param1 + 0xc),uVar1,0);
		    }
		  }
		  uVar1 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                    (param2,local_4,Method_I2_Loc_Localize_FindTranslatedObject_Mesh___);
		  uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0xc),
		                       Method_UnityEngine_Component_GetComponent_MeshFilter___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    param1_00 = UnityEngine_MeshFilter__DontStripMeshFilter(uVar3,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,uVar1,0);
		    if (iVar2 != 0) {
		      UnityEngine_MeshFilter__get_mesh(uVar3,uVar1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007743")]
		[Address(RVA = "0xC0A4", Offset = "0xC0A4", VA = "0xC0A4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer__DoLocalize
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60543 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_MeshRenderer___ctor__);
		    DAT_ram_00a60543 = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_MeshRenderer___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007744")]
		[Address(RVA = "0xC0A5", Offset = "0xC0A5", VA = "0xC0A5")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a60540 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_MeshRenderer__LocalizeTarget_UnityStandard_MeshRenderer___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_MeshRenderer__LocalizeTarget_UnityStandard_MeshRenderer__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_11004);
		    DAT_ram_00a60540 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_MeshRenderer__LocalizeTarget_UnityStandard_MeshRenderer__TypeInfo
		                        );
		  uVar1 = StringLiteral_11004;
		  *(undefined4 *)(param1_00 + 0xc) = 800;
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
