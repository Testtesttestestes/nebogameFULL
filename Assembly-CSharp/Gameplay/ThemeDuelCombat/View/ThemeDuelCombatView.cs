using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UI.Elements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ThemeDuelCombat.View
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	public class ThemeDuelCombatView : OneOnOneCombatView
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000546")]
		public CommonElements.IconLabel ThemeDuelPointsLeft
		{
			[Token(Token = "0x6001D76")]
			[Address(RVA = "0x6EF5", Offset = "0x6EF5", VA = "0x6EF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000547")]
		public CommonElements.IconLabel ThemeDuelPointsRight
		{
			[Token(Token = "0x6001D77")]
			[Address(RVA = "0x6EF6", Offset = "0x6EF6", VA = "0x6EF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000548")]
		public Button TdShopButton
		{
			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x6EF7", Offset = "0x6EF7", VA = "0x6EF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x6EF8", Offset = "0x6EF8", VA = "0x6EF8", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x6EF9", Offset = "0x6EF9", VA = "0x6EF9")]
		public void ShowThemeDuelPoints(bool value)
		{
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x6EFA", Offset = "0x6EFA", VA = "0x6EFA")]
		public ThemeDuelCombatView()
		{
		}

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CommonElements.IconLabel _themeDuelPointsLeft;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private CommonElements.IconLabel _themeDuelPointsRight;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform[] _themeDuelPoints;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Button _tdShopButton;
	}
}
