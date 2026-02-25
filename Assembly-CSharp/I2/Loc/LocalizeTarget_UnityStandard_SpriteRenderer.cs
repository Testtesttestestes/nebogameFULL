using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001394 RID: 5012
	[Token(Token = "0x2001394")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		// Token: 0x06007754 RID: 30548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007754")]
		[Address(RVA = "0xC0B5", Offset = "0xC0B5", VA = "0xC0B5")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00015C48 File Offset: 0x00013E48
		[Token(Token = "0x6007755")]
		[Address(RVA = "0xC0B6", Offset = "0xC0B6", VA = "0xC0B6", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00015C60 File Offset: 0x00013E60
		[Token(Token = "0x6007756")]
		[Address(RVA = "0xC0B7", Offset = "0xC0B7", VA = "0xC0B7", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x6007757")]
		[Address(RVA = "0xC0B8", Offset = "0xC0B8", VA = "0xC0B8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x6007758")]
		[Address(RVA = "0xC0B9", Offset = "0xC0B9", VA = "0xC0B9", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x6007759")]
		[Address(RVA = "0xC0BA", Offset = "0xC0BA", VA = "0xC0BA", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775A")]
		[Address(RVA = "0xC0BB", Offset = "0xC0BB", VA = "0xC0BB", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775B")]
		[Address(RVA = "0xC0BC", Offset = "0xC0BC", VA = "0xC0BC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775C")]
		[Address(RVA = "0xC0BD", Offset = "0xC0BD", VA = "0xC0BD")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
}
