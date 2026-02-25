using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001395 RID: 5013
	[Token(Token = "0x2001395")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		// Token: 0x0600775E RID: 30558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775E")]
		[Address(RVA = "0xC0BF", Offset = "0xC0BF", VA = "0xC0BF")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x600775F")]
		[Address(RVA = "0xC0C0", Offset = "0xC0C0", VA = "0xC0C0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x6007760")]
		[Address(RVA = "0xC0C1", Offset = "0xC0C1", VA = "0xC0C1", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x6007761")]
		[Address(RVA = "0xC0C2", Offset = "0xC0C2", VA = "0xC0C2", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x6007762")]
		[Address(RVA = "0xC0C3", Offset = "0xC0C3", VA = "0xC0C3", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x6007763")]
		[Address(RVA = "0xC0C4", Offset = "0xC0C4", VA = "0xC0C4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007764")]
		[Address(RVA = "0xC0C5", Offset = "0xC0C5", VA = "0xC0C5", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007765")]
		[Address(RVA = "0xC0C6", Offset = "0xC0C6", VA = "0xC0C6", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007766")]
		[Address(RVA = "0xC0C7", Offset = "0xC0C7", VA = "0xC0C7")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		// Token: 0x04003E52 RID: 15954
		[Token(Token = "0x4003E52")]
		[FieldOffset(Offset = "0x10")]
		private TextAlignment mAlignment_RTL;

		// Token: 0x04003E53 RID: 15955
		[Token(Token = "0x4003E53")]
		[FieldOffset(Offset = "0x14")]
		private TextAlignment mAlignment_LTR;

		// Token: 0x04003E54 RID: 15956
		[Token(Token = "0x4003E54")]
		[FieldOffset(Offset = "0x18")]
		private bool mAlignmentWasRTL;

		// Token: 0x04003E55 RID: 15957
		[Token(Token = "0x4003E55")]
		[FieldOffset(Offset = "0x19")]
		private bool mInitializeAlignment;
	}
}
