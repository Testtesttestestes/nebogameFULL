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
			return default(bool);
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776E")]
		[Address(RVA = "0xC0CF", Offset = "0xC0CF", VA = "0xC0CF", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776F")]
		[Address(RVA = "0xC0D0", Offset = "0xC0D0", VA = "0xC0D0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007770")]
		[Address(RVA = "0xC0D1", Offset = "0xC0D1", VA = "0xC0D1")]
		public LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}
	}
}
