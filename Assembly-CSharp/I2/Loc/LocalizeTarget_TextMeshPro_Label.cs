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
			return default(bool);
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007713")]
		[Address(RVA = "0xC074", Offset = "0xC074", VA = "0xC074", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007714")]
		[Address(RVA = "0xC075", Offset = "0xC075", VA = "0xC075", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007715")]
		[Address(RVA = "0xC076", Offset = "0xC076", VA = "0xC076")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007716")]
		[Address(RVA = "0xC077", Offset = "0xC077", VA = "0xC077")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007717")]
		[Address(RVA = "0xC078", Offset = "0xC078", VA = "0xC078")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007718")]
		[Address(RVA = "0xC079", Offset = "0xC079", VA = "0xC079")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007719")]
		[Address(RVA = "0xC07A", Offset = "0xC07A", VA = "0xC07A")]
		public LocalizeTarget_TextMeshPro_Label()
		{
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
