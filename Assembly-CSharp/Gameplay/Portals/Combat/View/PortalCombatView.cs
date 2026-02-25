using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.Combat.View
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	public class PortalCombatView : OneOnOneCombatView
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006DD")]
		public Button GetRewardButton
		{
			[Token(Token = "0x60024C3")]
			[Address(RVA = "0x7611", Offset = "0x7611", VA = "0x7611")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006DE")]
		public Button ShopButton
		{
			[Token(Token = "0x60024C4")]
			[Address(RVA = "0x7612", Offset = "0x7612", VA = "0x7612")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x7613", Offset = "0x7613", VA = "0x7613", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x7614", Offset = "0x7614", VA = "0x7614")]
		public PortalCombatView()
		{
		}

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _shopButton;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button _getRewardButton;
	}
}
