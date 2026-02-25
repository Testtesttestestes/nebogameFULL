using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200138D RID: 5005
	[Token(Token = "0x200138D")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		// Token: 0x0600771B RID: 30491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771B")]
		[Address(RVA = "0xC07C", Offset = "0xC07C", VA = "0xC07C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x600771C")]
		[Address(RVA = "0xC07D", Offset = "0xC07D", VA = "0xC07D", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x600771D")]
		[Address(RVA = "0xC07E", Offset = "0xC07E", VA = "0xC07E", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x000159C0 File Offset: 0x00013BC0
		[Token(Token = "0x600771E")]
		[Address(RVA = "0xC07F", Offset = "0xC07F", VA = "0xC07F", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x000159D8 File Offset: 0x00013BD8
		[Token(Token = "0x600771F")]
		[Address(RVA = "0xC080", Offset = "0xC080", VA = "0xC080", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x6007720")]
		[Address(RVA = "0xC081", Offset = "0xC081", VA = "0xC081", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007721")]
		[Address(RVA = "0xC082", Offset = "0xC082", VA = "0xC082", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007722")]
		[Address(RVA = "0xC083", Offset = "0xC083", VA = "0xC083", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007723")]
		[Address(RVA = "0xC084", Offset = "0xC084", VA = "0xC084")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		// Token: 0x04003E4E RID: 15950
		[Token(Token = "0x4003E4E")]
		[FieldOffset(Offset = "0x10")]
		public TextAlignmentOptions mAlignment_RTL;

		// Token: 0x04003E4F RID: 15951
		[Token(Token = "0x4003E4F")]
		[FieldOffset(Offset = "0x14")]
		public TextAlignmentOptions mAlignment_LTR;

		// Token: 0x04003E50 RID: 15952
		[Token(Token = "0x4003E50")]
		[FieldOffset(Offset = "0x18")]
		public bool mAlignmentWasRTL;

		// Token: 0x04003E51 RID: 15953
		[Token(Token = "0x4003E51")]
		[FieldOffset(Offset = "0x19")]
		public bool mInitializeAlignment;
	}
}
