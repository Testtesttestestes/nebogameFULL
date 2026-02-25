using System;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.VortexRating.View.VortexTab
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	public class VortexView : MonoBehaviour
	{
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000378")]
		public ButtonWithCost InVortexButton
		{
			[Token(Token = "0x600151A")]
			[Address(RVA = "0x66DC", Offset = "0x66DC", VA = "0x66DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x66DD", Offset = "0x66DD", VA = "0x66DD")]
		public VortexView()
		{
		}

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4000B33")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ButtonWithCost _inVortexButton;
	}
}
