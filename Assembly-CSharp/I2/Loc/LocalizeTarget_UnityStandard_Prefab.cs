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
			return default(bool);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774F")]
		[Address(RVA = "0xC0B0", Offset = "0xC0B0", VA = "0xC0B0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007750")]
		[Address(RVA = "0xC0B1", Offset = "0xC0B1", VA = "0xC0B1", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007751")]
		[Address(RVA = "0xC0B2", Offset = "0xC0B2", VA = "0xC0B2")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007752")]
		[Address(RVA = "0xC0B3", Offset = "0xC0B3", VA = "0xC0B3")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
}
