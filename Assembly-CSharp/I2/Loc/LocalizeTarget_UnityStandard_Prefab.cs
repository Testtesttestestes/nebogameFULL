using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001393 RID: 5011
	[Token(Token = "0x2001393")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		// Token: 0x06007748 RID: 30536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007748")]
		[Address(RVA = "0xC0A9", Offset = "0xC0A9", VA = "0xC0A9")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x6007749")]
		[Address(RVA = "0xC0AA", Offset = "0xC0AA", VA = "0xC0AA", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
		/* --- GHIDRA: IsValid ---
		undefined4
		I2_Loc_LocalizeTarget_UnityStandard_Prefab__IsValid
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  return 4;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00015BD0 File Offset: 0x00013DD0
		[Token(Token = "0x600774A")]
		[Address(RVA = "0xC0AB", Offset = "0xC0AB", VA = "0xC0AB", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00015BE8 File Offset: 0x00013DE8
		[Token(Token = "0x600774B")]
		[Address(RVA = "0xC0AC", Offset = "0xC0AC", VA = "0xC0AC", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x600774C")]
		[Address(RVA = "0xC0AD", Offset = "0xC0AD", VA = "0xC0AD", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x600774D")]
		[Address(RVA = "0xC0AE", Offset = "0xC0AE", VA = "0xC0AE", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00015C30 File Offset: 0x00013E30
		[Token(Token = "0x600774E")]
		[Address(RVA = "0xC0AF", Offset = "0xC0AF", VA = "0xC0AF", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityStandard_Prefab__AllowSecondTermToBeRTL
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 *param5,undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(param2,0);
		  *param5 = uVar1;
		  *param6 = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774F")]
		[Address(RVA = "0xC0B0", Offset = "0xC0B0", VA = "0xC0B0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_Prefab__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a60546 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60546 = '\x01';
		  }
		  iVar2 = func_ii_4769(param3,0);
		  if (iVar2 == 0) {
		    uVar5 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Component__GetComponent_object_(uVar5,0);
		    if (iVar2 != 0) {
		      uVar5 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                        (*(undefined4 *)(param1 + 0xc),0);
		      iVar2 = System_Collections_CollectionBase___ctor(uVar5,param3,0);
		      if (iVar2 != 0) {
		        return;
		      }
		    }
		    uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param2,0);
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    iVar2 = System_String__LastIndexOf
		                      (param3,*(undefined4 *)
		                               (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		    uVar3 = param3;
		    if (-1 < iVar2) {
		      uVar3 = System_String__get_Chars(param3,iVar2 + 1,0);
		    }
		    param1_00 = I2_Loc_LocalizeTarget_UnityStandard_Prefab__DoLocalize(param1,param2,param3,param3);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = func_ii_3812(param1_00,0,0);
		    if (iVar2 == 0) {
		      UnityEngine_Texture2D___ctor(param1_00,uVar3,0);
		      iVar2 = UnityEngine_Transform__InverseTransformPoint(uVar5,0);
		      iVar2 = iVar2 + -1;
		      if (-1 < iVar2) {
		        do {
		          uVar3 = UnityEngine_Transform__GetEnumerator(uVar5,iVar2,0);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,param1_00,0);
		          if (iVar4 != 0) {
		            uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (uVar3,0);
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              func_ii_306000(UnityEngine_Object_TypeInfo);
		            }
		            UnityEngine_Application__get_isPlaying(uVar3,0);
		          }
		          bVar1 = 0 < iVar2;
		          iVar2 = iVar2 + -1;
		        } while (bVar1);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007750")]
		[Address(RVA = "0xC0B1", Offset = "0xC0B1", VA = "0xC0B1", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		undefined4
		I2_Loc_LocalizeTarget_UnityStandard_Prefab__DoLocalize
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_01;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60547 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a60547 = '\x01';
		  }
		  uVar1 = I2_Loc_LocalizationManager__GetTranslatedObjectByTermName_object_
		                    (param2,param3,Method_I2_Loc_Localize_FindTranslatedObject_GameObject___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param1_00 = 0;
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if (iVar2 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar1 = func_ii_5950(uVar1,Method_UnityEngine_Object_Instantiate_GameObject___);
		    *(undefined4 *)(param1 + 0xc) = uVar1;
		    iVar2 = func_ii_3812(uVar1,0,0);
		    if (iVar2 == 0) {
		      uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param2,0);
		      param1_00 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0xc),0);
		      UnityEngine_Transform__GetParent(param1_00,uVar1,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(param1_01,0);
		      if (iVar2 != 0) {
		        uVar1 = UnityEngine_UI_Selectable__set_interactable(param1_01,0);
		      }
		      UnityEngine_Transform__get_forward(&local_10,uVar1,0);
		      local_28 = local_8;
		      local_30 = local_10;
		      UnityEngine_Transform__get_rotation(param1_00,&local_30,0);
		      func_ii_7888(&local_1c,uVar1,0);
		      local_38 = local_14;
		      local_40 = local_1c;
		      UnityEngine_Transform__get_position(param1_00,&local_40,0);
		    }
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007751")]
		[Address(RVA = "0xC0B2", Offset = "0xC0B2", VA = "0xC0B2")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
		/* --- GHIDRA: InstantiateNewPrefab ---
		void I2_Loc_LocalizeTarget_UnityStandard_Prefab__InstantiateNewPrefab
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60548 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_GameObject___ctor__);
		    DAT_ram_00a60548 = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_GameObject___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007752")]
		[Address(RVA = "0xC0B3", Offset = "0xC0B3", VA = "0xC0B3")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_Prefab___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityStandard_SpriteRenderer___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_Prefab___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a60545 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizeTargetDesc_Prefab_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12517);
		    DAT_ram_00a60545 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_LocalizeTargetDesc_Prefab_TypeInfo);
		  if (DAT_ram_00a60544 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizeTargetDesc_LocalizeTarget_UnityStandard_Prefab___ctor__);
		    DAT_ram_00a60544 = '\x01';
		  }
		  uVar1 = StringLiteral_12517;
		  *(undefined4 *)(param1_00 + 0xc) = 0xfa;
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
