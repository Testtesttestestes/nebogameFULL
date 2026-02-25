using System;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	public class PortalsMonsterInfoView : MonsterInfoView2
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000661")]
		public Button ReturnButton
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x7447", Offset = "0x7447", VA = "0x7447")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000662")]
		public Price ReturnPrice
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x7448", Offset = "0x7448", VA = "0x7448")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x7449", Offset = "0x7449", VA = "0x7449")]
		public void SetLevel(uint level)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x744A", Offset = "0x744A", VA = "0x744A")]
		public PortalsMonsterInfoView()
		{
		}

		// Token: 0x0400130B RID: 4875
		[Token(Token = "0x400130B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ButtonWithCost _returnButton;
	}
}
