using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Buttons
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	public class SpellButtonWithStates : ImageWithStates<SpellButtonWithStates.State>
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E8")]
		public ButtonWithCost ButtonWithCost
		{
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x60CA", Offset = "0x60CA", VA = "0x60CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x60CB", Offset = "0x60CB", VA = "0x60CB", Slot = "4")]
		protected override void HandleCurrentStateChanged(SpellButtonWithStates.State fromState, SpellButtonWithStates.State toState)
		{
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x60CC", Offset = "0x60CC", VA = "0x60CC")]
		private string GetLocalizationKey(SpellButtonWithStates.State state)
		{
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x60CD", Offset = "0x60CD", VA = "0x60CD")]
		public SpellButtonWithStates()
		{
		}

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x02000244 RID: 580
		[Token(Token = "0x2000244")]
		public enum State
		{
			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			UNKNOWN_STATE,
			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			Learn,
			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			Upgrade,
			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			Accelerate
		}
	}
}
