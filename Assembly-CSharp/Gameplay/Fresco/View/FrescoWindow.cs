using System;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.Fresco.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	public class FrescoWindow : ClosableBaseWindow<FrescoWindow.FrescoWindowArgs>
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000965")]
		public override string WindowId
		{
			[Token(Token = "0x6002FF7")]
			[Address(RVA = "0x805D", Offset = "0x805D", VA = "0x805D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x805E", Offset = "0x805E", VA = "0x805E", Slot = "22")]
		protected override void OnShow(FrescoWindow.FrescoWindowArgs args)
		{
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x805F", Offset = "0x805F", VA = "0x805F", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x8060", Offset = "0x8060", VA = "0x8060")]
		public FrescoWindow()
		{
		}

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Fresco/FrescoWindow";

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FrescoView _view;

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x020007FB RID: 2043
		[Token(Token = "0x20007FB")]
		public class FrescoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002FFB RID: 12283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FFB")]
			[Address(RVA = "0x8061", Offset = "0x8061", VA = "0x8061")]
			public FrescoWindowArgs(FrescoController controller, UserData owner)
			{
			}

			// Token: 0x04001A3F RID: 6719
			[Token(Token = "0x4001A3F")]
			[FieldOffset(Offset = "0x18")]
			public readonly FrescoController Controller;

			// Token: 0x04001A40 RID: 6720
			[Token(Token = "0x4001A40")]
			[FieldOffset(Offset = "0x1C")]
			public readonly UserData Owner;
		}
	}
}
