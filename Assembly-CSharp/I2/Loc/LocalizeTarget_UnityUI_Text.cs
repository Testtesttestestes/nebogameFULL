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
			return default(bool);
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778C")]
		[Address(RVA = "0xC0ED", Offset = "0xC0ED", VA = "0xC0ED", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778D")]
		[Address(RVA = "0xC0EE", Offset = "0xC0EE", VA = "0xC0EE", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778E")]
		[Address(RVA = "0xC0EF", Offset = "0xC0EF", VA = "0xC0EF")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600778F")]
		[Address(RVA = "0xC0F0", Offset = "0xC0F0", VA = "0xC0F0")]
		public LocalizeTarget_UnityUI_Text()
		{
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
