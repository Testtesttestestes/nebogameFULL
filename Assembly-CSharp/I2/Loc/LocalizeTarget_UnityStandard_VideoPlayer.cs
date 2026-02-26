using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace I2.Loc
{
	// Token: 0x02001396 RID: 5014
	[Token(Token = "0x2001396")]
	public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
	{
		// Token: 0x06007768 RID: 30568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007768")]
		[Address(RVA = "0xC0C9", Offset = "0xC0C9", VA = "0xC0C9")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		/* --- GHIDRA: AutoRegister ---
		undefined4
		I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer__AutoRegister
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  return 0xb;
		}
		*/

		}

		// Token: 0x06007769 RID: 30569 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x6007769")]
		[Address(RVA = "0xC0CA", Offset = "0xC0CA", VA = "0xC0CA", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x600776A")]
		[Address(RVA = "0xC0CB", Offset = "0xC0CB", VA = "0xC0CB", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00015D68 File Offset: 0x00013F68
		[Token(Token = "0x600776B")]
		[Address(RVA = "0xC0CC", Offset = "0xC0CC", VA = "0xC0CC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x600776C")]
		[Address(RVA = "0xC0CD", Offset = "0xC0CD", VA = "0xC0CD", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x600776D")]
		[Address(RVA = "0xC0CE", Offset = "0xC0CE", VA = "0xC0CE", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
		/* --- GHIDRA: AllowSecondTermToBeRTL ---
		void I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer__AllowSecondTermToBeRTL
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 *param5,
		               undefined4 *param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54de5 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54de5 = '\x01';
		  }
		  uVar1 = UnityEngine_Experimental_Video_VideoClipPlayable__Equals(*(undefined4 *)(param1 + 0xc),0);
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

		// Token: 0x0600776E RID: 30574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776E")]
		[Address(RVA = "0xC0CF", Offset = "0xC0CF", VA = "0xC0CF", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		/* --- GHIDRA: GetFinalTerms ---
		void I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer__GetFinalTerms
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54de6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_Localize_FindTranslatedObject_VideoClip___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54de6 = '\x01';
		  }
		  uVar1 = UnityEngine_Experimental_Video_VideoClipPlayable__Equals(*(undefined4 *)(param1 + 0xc),0);
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
		                    (param2,param3,Method_I2_Loc_Localize_FindTranslatedObject_VideoClip___);
		  UnityEngine_Video_VideoPlayer__get_clip(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776F")]
		[Address(RVA = "0xC0D0", Offset = "0xC0D0", VA = "0xC0D0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		/* --- GHIDRA: DoLocalize ---
		void I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer__DoLocalize
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54de7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_LocalizeTarget_VideoPlayer___ctor__);
		    DAT_ram_00a54de7 = '\x01';
		  }
		  Sirenix_OdinInspector_SerializedStateMachineBehaviour__OnBeforeSerialize
		            (param1,Method_I2_Loc_LocalizeTarget_VideoPlayer___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007770")]
		[Address(RVA = "0xC0D1", Offset = "0xC0D1", VA = "0xC0D1")]
		public LocalizeTarget_UnityStandard_VideoPlayer()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityUI_Image___cctor(0);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void I2_Loc_LocalizeTarget_UnityStandard_VideoPlayer___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a54de4 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_I2_Loc_LocalizeTargetDesc_Type_VideoPlayer__LocalizeTarget_UnityStandard_VideoPlayer___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               I2_Loc_LocalizeTargetDesc_Type_VideoPlayer__LocalizeTarget_UnityStandard_VideoPlayer__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_17693);
		    DAT_ram_00a54de4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        I2_Loc_LocalizeTargetDesc_Type_VideoPlayer__LocalizeTarget_UnityStandard_VideoPlayer__TypeInfo
		                        );
		  uVar1 = StringLiteral_17693;
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
