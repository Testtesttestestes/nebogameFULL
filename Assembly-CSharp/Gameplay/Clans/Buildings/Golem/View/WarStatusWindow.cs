using System;
using AssetContent;
using Gameplay.Clans.Buildings.Golem.Controller;
using Il2CppDummyDll;
using UI.Elements.RightPanel;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2000AD0")]
	public class WarStatusWindow : ClosableBaseWindow<WarStatusWindow.WarStatusWindowArgs>
	{
		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D29")]
		public override string WindowId
		{
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x915F", Offset = "0x915F", VA = "0x915F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2A")]
		public TitleWithLevel TitleGroup
		{
			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x9160", Offset = "0x9160", VA = "0x9160")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2B")]
		public TruceStatusView TruceStatusView
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x9161", Offset = "0x9161", VA = "0x9161")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2C")]
		public WarStatusView WarStatusView
		{
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x9162", Offset = "0x9162", VA = "0x9162")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x9163", Offset = "0x9163", VA = "0x9163", Slot = "22")]
		protected override void OnShow(WarStatusWindow.WarStatusWindowArgs args)
		{
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B0")]
		[Address(RVA = "0x9164", Offset = "0x9164", VA = "0x9164", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B1")]
		[Address(RVA = "0x9165", Offset = "0x9165", VA = "0x9165")]
		public WarStatusWindow()
		{
		}

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/WarStatusWindow";

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TitleWithLevel _titleGroup;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40024DD")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TruceStatusView _truceStatusView;

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WarStatusView _warStatusView;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x4C")]
		private WarStatusViewMasterMediator _mediator;

		// Token: 0x02000AD1 RID: 2769
		[Token(Token = "0x2000AD1")]
		public class WarStatusWindowArgs : BaseWindowArgs
		{
			// Token: 0x060042B2 RID: 17074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60042B2")]
			[Address(RVA = "0x9166", Offset = "0x9166", VA = "0x9166")]
			public WarStatusWindowArgs()
			{
			}

			// Token: 0x040024E0 RID: 9440
			[Token(Token = "0x40024E0")]
			[FieldOffset(Offset = "0x18")]
			public string AprAssetId;

			// Token: 0x040024E1 RID: 9441
			[Token(Token = "0x40024E1")]
			[FieldOffset(Offset = "0x1C")]
			public WarStatusViewMasterMediator Mediator;
		}
	}
}
