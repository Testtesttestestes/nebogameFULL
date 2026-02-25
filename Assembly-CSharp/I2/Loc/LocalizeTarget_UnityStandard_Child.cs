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
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007739")]
		[Address(RVA = "0xC09A", Offset = "0xC09A", VA = "0xC09A", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773A")]
		[Address(RVA = "0xC09B", Offset = "0xC09B", VA = "0xC09B")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
}
