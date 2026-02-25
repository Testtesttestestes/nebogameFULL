using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02001397 RID: 5015
	[Token(Token = "0x2001397")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		// Token: 0x06007772 RID: 30578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007772")]
		[Address(RVA = "0xC0D3", Offset = "0xC0D3", VA = "0xC0D3")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x6007773")]
		[Address(RVA = "0xC0D4", Offset = "0xC0D4", VA = "0xC0D4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x6007774")]
		[Address(RVA = "0xC0D5", Offset = "0xC0D5", VA = "0xC0D5", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x6007775")]
		[Address(RVA = "0xC0D6", Offset = "0xC0D6", VA = "0xC0D6", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00015DF8 File Offset: 0x00013FF8
		[Token(Token = "0x6007776")]
		[Address(RVA = "0xC0D7", Offset = "0xC0D7", VA = "0xC0D7", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x6007777")]
		[Address(RVA = "0xC0D8", Offset = "0xC0D8", VA = "0xC0D8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007778")]
		[Address(RVA = "0xC0D9", Offset = "0xC0D9", VA = "0xC0D9", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007779")]
		[Address(RVA = "0xC0DA", Offset = "0xC0DA", VA = "0xC0DA", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600777A")]
		[Address(RVA = "0xC0DB", Offset = "0xC0DB", VA = "0xC0DB")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
}
