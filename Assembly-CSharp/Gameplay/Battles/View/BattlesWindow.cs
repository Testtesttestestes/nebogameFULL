using System;
using Gameplay.Battles.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Battles.View
{
	// Token: 0x02000C28 RID: 3112
	[Token(Token = "0x2000C28")]
	public class BattlesWindow : ClosableBaseWindow<BattlesWindow.BattlesWindowArgs>
	{
		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F4A")]
		public override string WindowId
		{
			[Token(Token = "0x6004BE6")]
			[Address(RVA = "0x9A2A", Offset = "0x9A2A", VA = "0x9A2A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F4B")]
		public BattlesWndButton[] Buttons
		{
			[Token(Token = "0x6004BE7")]
			[Address(RVA = "0x9A2B", Offset = "0x9A2B", VA = "0x9A2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x9A2C", Offset = "0x9A2C", VA = "0x9A2C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x9A2D", Offset = "0x9A2D", VA = "0x9A2D", Slot = "22")]
		protected override void OnShow(BattlesWindow.BattlesWindowArgs args)
		{
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x9A2E", Offset = "0x9A2E", VA = "0x9A2E")]
		public BattlesWindow()
		{
		}

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Battles/BattlesWindow";

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BattlesWndButton[] _buttons;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x40")]
		private BattlesViewMediator _mediator;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x44")]
		private bool _mvcSetUp;

		// Token: 0x02000C29 RID: 3113
		[Token(Token = "0x2000C29")]
		public class BattlesWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004BEB RID: 19435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BEB")]
			[Address(RVA = "0x9A2F", Offset = "0x9A2F", VA = "0x9A2F")]
			public BattlesWindowArgs()
			{
			}
		}
	}
}
