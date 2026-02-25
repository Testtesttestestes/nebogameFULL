using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C4D RID: 3149
	[Token(Token = "0x2000C4D")]
	public class SelectBillingDialogWindow : BaseDialogWindow<SelectBillingDialogWindow.SelectBillingDialogWindowArgs>
	{
		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F7B")]
		public override string WindowId
		{
			[Token(Token = "0x6004CC6")]
			[Address(RVA = "0x9B03", Offset = "0x9B03", VA = "0x9B03", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x9B04", Offset = "0x9B04", VA = "0x9B04", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x9B05", Offset = "0x9B05", VA = "0x9B05")]
		public static SelectBillingDialogWindow Show(IGame game, BankOptionData option, SelectBillingDialogWindow.SelectBillingDialogWindowArgs.Config[] items, Action<BillingProviderId, BankOptionData> callback)
		{
			return null;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x9B06", Offset = "0x9B06", VA = "0x9B06")]
		public SelectBillingDialogWindow()
		{
		}

		// Token: 0x040029E9 RID: 10729
		[Token(Token = "0x40029E9")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/SelectBillingDialogWindow";

		// Token: 0x040029EA RID: 10730
		[Token(Token = "0x40029EA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _billingImages;

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameAssetViewRawImage _imagePrefab;

		// Token: 0x02000C4E RID: 3150
		[Token(Token = "0x2000C4E")]
		public class SelectBillingDialogWindowArgs : BaseDialogWindow<SelectBillingDialogWindow.SelectBillingDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06004CCA RID: 19658 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7C")]
			public IGame Game
			{
				[Token(Token = "0x6004CCA")]
				[Address(RVA = "0x9B07", Offset = "0x9B07", VA = "0x9B07")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x06004CCB RID: 19659 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7D")]
			public BankOptionData Option
			{
				[Token(Token = "0x6004CCB")]
				[Address(RVA = "0x9B08", Offset = "0x9B08", VA = "0x9B08")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x06004CCC RID: 19660 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7E")]
			public SelectBillingDialogWindow.SelectBillingDialogWindowArgs.Config[] Configs
			{
				[Token(Token = "0x6004CCC")]
				[Address(RVA = "0x9B09", Offset = "0x9B09", VA = "0x9B09")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x06004CCD RID: 19661 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7F")]
			public Action<BillingProviderId, BankOptionData> Callback
			{
				[Token(Token = "0x6004CCD")]
				[Address(RVA = "0x9B0A", Offset = "0x9B0A", VA = "0x9B0A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06004CCE RID: 19662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CCE")]
			[Address(RVA = "0x9B0B", Offset = "0x9B0B", VA = "0x9B0B")]
			public SelectBillingDialogWindowArgs(IGame game, BankOptionData option, SelectBillingDialogWindow.SelectBillingDialogWindowArgs.Config[] configs, Action<BillingProviderId, BankOptionData> callback)
			{
			}

			// Token: 0x02000C4F RID: 3151
			[Token(Token = "0x2000C4F")]
			public class Config
			{
				// Token: 0x06004CCF RID: 19663 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004CCF")]
				[Address(RVA = "0x9B0C", Offset = "0x9B0C", VA = "0x9B0C")]
				public Config(BillingProviderId id, string buttonLabelLocaleKey, string uiResourceKey)
				{
				}

				// Token: 0x040029F0 RID: 10736
				[Token(Token = "0x40029F0")]
				[FieldOffset(Offset = "0x8")]
				public readonly BillingProviderId Id;

				// Token: 0x040029F1 RID: 10737
				[Token(Token = "0x40029F1")]
				[FieldOffset(Offset = "0xC")]
				public readonly string ButtonLabelLocaleKey;

				// Token: 0x040029F2 RID: 10738
				[Token(Token = "0x40029F2")]
				[FieldOffset(Offset = "0x10")]
				public readonly string UIResourceKey;
			}
		}
	}
}
