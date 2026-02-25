using System;
using Il2CppDummyDll;
using TMPro;

namespace Gameplay.FeedbackForm.Model
{
	// Token: 0x02000820 RID: 2080
	[Token(Token = "0x2000820")]
	public class FeedbackThemeOption : TMP_Dropdown.OptionData
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x8159", Offset = "0x8159", VA = "0x8159")]
		public FeedbackThemeOption(Themes theme)
		{
		}

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x20")]
		public readonly Themes Theme;
	}
}
