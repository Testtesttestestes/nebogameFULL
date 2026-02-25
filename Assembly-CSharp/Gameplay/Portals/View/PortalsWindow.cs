using System;
using Gameplay.Portals.Controller;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B5 RID: 1461
	[Token(Token = "0x20005B5")]
	public class PortalsWindow : ClosableBaseWindow<PortalsWindow.PortalsWindowArgs>
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067C")]
		public PortalsView PortalsView
		{
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x746B", Offset = "0x746B", VA = "0x746B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067D")]
		public override string WindowId
		{
			[Token(Token = "0x6002318")]
			[Address(RVA = "0x746C", Offset = "0x746C", VA = "0x746C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x746D", Offset = "0x746D", VA = "0x746D", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x746E", Offset = "0x746E", VA = "0x746E", Slot = "22")]
		protected override void OnShow(PortalsWindow.PortalsWindowArgs args)
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x746F", Offset = "0x746F", VA = "0x746F")]
		private void SetupMVC()
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x7470", Offset = "0x7470", VA = "0x7470")]
		private void DestroyMVC()
		{
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x7471", Offset = "0x7471", VA = "0x7471", Slot = "29")]
		protected override void HandleBackButton()
		{
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x7472", Offset = "0x7472", VA = "0x7472", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x7473", Offset = "0x7473", VA = "0x7473")]
		public PortalsWindow()
		{
		}

		// Token: 0x0400133A RID: 4922
		[Token(Token = "0x400133A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Portals/PortalsWindow";

		// Token: 0x0400133B RID: 4923
		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private PortalsView _portalsView;

		// Token: 0x0400133C RID: 4924
		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0x40")]
		private PortalsViewMediator _mediator;

		// Token: 0x0400133D RID: 4925
		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x44")]
		private bool _mvcSetUp;

		// Token: 0x020005B6 RID: 1462
		[Token(Token = "0x20005B6")]
		public class PortalsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x7474", Offset = "0x7474", VA = "0x7474")]
			public PortalsWindowArgs(PortalsTargets targetForShow)
			{
			}

			// Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x7475", Offset = "0x7475", VA = "0x7475")]
			public PortalsWindowArgs()
			{
			}

			// Token: 0x0400133E RID: 4926
			[Token(Token = "0x400133E")]
			[FieldOffset(Offset = "0x18")]
			public readonly PortalsTargets TargetForShow;
		}
	}
}
