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
			return default(bool);
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007782")]
		[Address(RVA = "0xC0E3", Offset = "0xC0E3", VA = "0xC0E3", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007783")]
		[Address(RVA = "0xC0E4", Offset = "0xC0E4", VA = "0xC0E4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007784")]
		[Address(RVA = "0xC0E5", Offset = "0xC0E5", VA = "0xC0E5")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
}
