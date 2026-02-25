using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200138E RID: 5006
	[Token(Token = "0x200138E")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		// Token: 0x06007725 RID: 30501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007725")]
		[Address(RVA = "0xC086", Offset = "0xC086", VA = "0xC086")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x6007726")]
		[Address(RVA = "0xC087", Offset = "0xC087", VA = "0xC087", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x6007727")]
		[Address(RVA = "0xC088", Offset = "0xC088", VA = "0xC088", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00015A38 File Offset: 0x00013C38
		[Token(Token = "0x6007728")]
		[Address(RVA = "0xC089", Offset = "0xC089", VA = "0xC089", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x6007729")]
		[Address(RVA = "0xC08A", Offset = "0xC08A", VA = "0xC08A", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00015A68 File Offset: 0x00013C68
		[Token(Token = "0x600772A")]
		[Address(RVA = "0xC08B", Offset = "0xC08B", VA = "0xC08B", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772B")]
		[Address(RVA = "0xC08C", Offset = "0xC08C", VA = "0xC08C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772C")]
		[Address(RVA = "0xC08D", Offset = "0xC08D", VA = "0xC08D", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772D")]
		[Address(RVA = "0xC08E", Offset = "0xC08E", VA = "0xC08E")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
}
