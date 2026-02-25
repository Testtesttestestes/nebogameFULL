using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Buttons
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public class BuildButtonWithStates : ImageWithStates<BuildButtonWithStates.State>
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E3")]
		public ButtonWithCost ButtonWithCost
		{
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x60BF", Offset = "0x60BF", VA = "0x60BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x60C0", Offset = "0x60C0", VA = "0x60C0", Slot = "4")]
		protected override void HandleCurrentStateChanged(BuildButtonWithStates.State fromState, BuildButtonWithStates.State toState)
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x60C1", Offset = "0x60C1", VA = "0x60C1")]
		private string GetLocalizationKey(BuildButtonWithStates.State state)
		{
			return null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x60C2", Offset = "0x60C2", VA = "0x60C2")]
		public BuildButtonWithStates()
		{
		}

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x02000240 RID: 576
		[Token(Token = "0x2000240")]
		public enum State
		{
			// Token: 0x04000707 RID: 1799
			[Token(Token = "0x4000707")]
			UNKNOWN_STATE,
			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			Build,
			// Token: 0x04000709 RID: 1801
			[Token(Token = "0x4000709")]
			Upgrade,
			// Token: 0x0400070A RID: 1802
			[Token(Token = "0x400070A")]
			Accelerate
		}
	}
}
