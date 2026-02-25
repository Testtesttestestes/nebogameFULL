using System;
using Gameplay.TradeAndCraft.Controller;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.TradeAndCraft.View
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	public class CraftOptionsWindow : ClosableBaseWindow<CraftOptionsWindow.CraftWindowArgs>
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004D9")]
		public override string WindowId
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x6D41", Offset = "0x6D41", VA = "0x6D41", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DA")]
		public Button CraftButton
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x6D42", Offset = "0x6D42", VA = "0x6D42")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DB")]
		public Button ManufactureButton
		{
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0x6D43", Offset = "0x6D43", VA = "0x6D43")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DC")]
		public Button AccountsButton
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x6D44", Offset = "0x6D44", VA = "0x6D44")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x6D45", Offset = "0x6D45", VA = "0x6D45")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x6D46", Offset = "0x6D46", VA = "0x6D46", Slot = "22")]
		protected override void OnShow(CraftOptionsWindow.CraftWindowArgs args)
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x6D47", Offset = "0x6D47", VA = "0x6D47")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x6D48", Offset = "0x6D48", VA = "0x6D48")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x6D49", Offset = "0x6D49", VA = "0x6D49")]
		public CraftOptionsWindow()
		{
		}

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/TradeAndCraft/CraftOptionsWindow";

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _craftButton;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _manufactureButton;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _accountsButton;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x48")]
		private TradeAndCraftModel _model;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x4C")]
		private TradeAndCraftEvents _events;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x50")]
		private TradeAndCraftController _controller;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x54")]
		private CraftOptionsViewMediator _mediator;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x58")]
		private bool _mvcSetUp;

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		public class CraftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x6D4A", Offset = "0x6D4A", VA = "0x6D4A")]
			public CraftWindowArgs()
			{
			}
		}
	}
}
