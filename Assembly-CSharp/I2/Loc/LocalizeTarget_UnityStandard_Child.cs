using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001390 RID: 5008
	[Token(Token = "0x2001390")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		// Token: 0x06007731 RID: 30513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007731")]
		[Address(RVA = "0xC092", Offset = "0xC092", VA = "0xC092")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		/* --- GHIDRA: AutoRegister ---
		uint I2_Loc_LocalizeTarget_UnityStandard_Child__AutoRegister
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param2,0);
		  iVar1 = UnityEngine_Transform__InverseTransformPoint(param1_00,0);
		  return (uint)(1 < iVar1);
		}
		*/

		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00015A98 File Offset: 0x00013C98
		[Token(Token = "0x6007732")]
		[Address(RVA = "0xC093", Offset = "0xC093", VA = "0xC093", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00015AB0 File Offset: 0x00013CB0
		[Token(Token = "0x6007733")]
		[Address(RVA = "0xC094", Offset = "0xC094", VA = "0xC094", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00015AC8 File Offset: 0x00013CC8
		[Token(Token = "0x6007734")]
		[Address(RVA = "0xC095", Offset = "0xC095", VA = "0xC095", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00015AE0 File Offset: 0x00013CE0
		[Token(Token = "0x6007735")]
		[Address(RVA = "0xC096", Offset = "0xC096", VA = "0xC096", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x00015AF8 File Offset: 0x00013CF8
		[Token(Token = "0x6007736")]
		[Address(RVA = "0xC097", Offset = "0xC097", VA = "0xC097", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00015B10 File Offset: 0x00013D10
		[Token(Token = "0x6007737")]
		[Address(RVA = "0xC098", Offset = "0xC098", VA = "0xC098", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007738")]
		[Address(RVA = "0xC099", Offset = "0xC099", VA = "0xC099", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_Child__GetFinalTerms
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6053e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    DAT_ram_00a6053e = '\x01';
		  }
		  iVar1 = func_ii_4769(param3,0);
		  if (iVar1 == 0) {
		    param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param2,0);
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    iVar1 = System_String__LastIndexOf
		                      (param3,*(undefined4 *)
		                               (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		    if (-1 < iVar1) {
		      param3 = System_String__get_Chars(param3,iVar1 + 1,0);
		    }
		    iVar1 = 0;
		    iVar2 = UnityEngine_Transform__InverseTransformPoint(param1_00,0);
		    if (0 < iVar2) {
		      do {
		        uVar3 = UnityEngine_Transform__GetEnumerator(param1_00,iVar1,0);
		        param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (uVar3,0);
		        uVar3 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar3,0);
		        uVar3 = System_Collections_CollectionBase___ctor(uVar3,param3,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (param1_01,uVar3,0);
		        iVar2 = UnityEngine_Transform__InverseTransformPoint(param1_00,0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < iVar2);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007739")]
		[Address(RVA = "0xC09A", Offset = "0xC09A", VA = "0xC09A", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityStandard_Child__DoLocalize(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6053f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_GameObject___ctor__);
		    DAT_ram_00a6053f = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_GameObject___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773A")]
		[Address(RVA = "0xC09B", Offset = "0xC09B", VA = "0xC09B")]
		public LocalizeTarget_UnityStandard_Child()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_Child___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityStandard_MeshRenderer___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_Child___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a6053d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizeTargetDesc_Child_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5368);
		    DAT_ram_00a6053d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_LocalizeTargetDesc_Child_TypeInfo);
		  if (DAT_ram_00a6053c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizeTargetDesc_LocalizeTarget_UnityStandard_Child___ctor__);
		    DAT_ram_00a6053c = '\x01';
		  }
		  uVar1 = StringLiteral_5368;
		  *(undefined4 *)(param1_00 + 0xc) = 200;
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
