using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02001398 RID: 5016
	[Token(Token = "0x2001398")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		// Token: 0x0600777C RID: 30588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600777C")]
		[Address(RVA = "0xC0DD", Offset = "0xC0DD", VA = "0xC0DD")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00015E28 File Offset: 0x00014028
		[Token(Token = "0x600777D")]
		[Address(RVA = "0xC0DE", Offset = "0xC0DE", VA = "0xC0DE", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x00015E40 File Offset: 0x00014040
		[Token(Token = "0x600777E")]
		[Address(RVA = "0xC0DF", Offset = "0xC0DF", VA = "0xC0DF", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00015E58 File Offset: 0x00014058
		[Token(Token = "0x600777F")]
		[Address(RVA = "0xC0E0", Offset = "0xC0E0", VA = "0xC0E0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x6007780")]
		[Address(RVA = "0xC0E1", Offset = "0xC0E1", VA = "0xC0E1", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x00015E88 File Offset: 0x00014088
		[Token(Token = "0x6007781")]
		[Address(RVA = "0xC0E2", Offset = "0xC0E2", VA = "0xC0E2", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityUI_RawImage__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54dee == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54dee = '\x01';
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
		  *param6 = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007782")]
		[Address(RVA = "0xC0E3", Offset = "0xC0E3", VA = "0xC0E3", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityUI_RawImage__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54def == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_Texture___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54def = '\x01';
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
		                    (param2,param3,Method_I2_Loc_Localize_FindTranslatedObject_Texture___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		            (param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007783")]
		[Address(RVA = "0xC0E4", Offset = "0xC0E4", VA = "0xC0E4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityUI_RawImage__DoLocalize(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54df0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_RawImage___ctor__);
		    DAT_ram_00a54df0 = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_RawImage___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007784 RID: 30596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007784")]
		[Address(RVA = "0xC0E5", Offset = "0xC0E5", VA = "0xC0E5")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityUI_RawImage___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityUI_Text___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityUI_RawImage___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a54ded == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_RawImage__LocalizeTarget_UnityUI_RawImage___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&I2_Loc_LocalizeTargetDesc_Type_RawImage__LocalizeTarget_UnityUI_RawImage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13340);
		    DAT_ram_00a54ded = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_RawImage__LocalizeTarget_UnityUI_RawImage__TypeInfo
		                        );
		  uVar1 = StringLiteral_13340;
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
