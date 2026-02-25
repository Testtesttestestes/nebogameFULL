using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.Sliders;
using UI.Windows;
using UnityEngine;
using Utils;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D13 RID: 3347
	[Token(Token = "0x2000D13")]
	public sealed class IsleAnimationMultipleLaunchesDialog : BaseDialogWindow<IsleAnimationMultipleLaunchesDialog.Args>
	{
		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001087")]
		public override string WindowId
		{
			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x9F8B", Offset = "0x9F8B", VA = "0x9F8B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001088")]
		public SliderWithButtons Slider
		{
			[Token(Token = "0x60051B2")]
			[Address(RVA = "0x9F8C", Offset = "0x9F8C", VA = "0x9F8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001F1 RID: 497
		// (add) Token: 0x060051B3 RID: 20915 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051B4 RID: 20916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F1")]
		public event Action<IsleAnimationMultipleLaunchesDialog> SelectedEvent
		{
			[Token(Token = "0x60051B3")]
			[Address(RVA = "0x9F8D", Offset = "0x9F8D", VA = "0x9F8D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051B4")]
			[Address(RVA = "0x9F8E", Offset = "0x9F8E", VA = "0x9F8E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001F2 RID: 498
		// (add) Token: 0x060051B5 RID: 20917 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051B6 RID: 20918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F2")]
		public event Action<IsleAnimationMultipleLaunchesDialog> RequestQuickSelectionValueEvent
		{
			[Token(Token = "0x60051B5")]
			[Address(RVA = "0x9F8F", Offset = "0x9F8F", VA = "0x9F8F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051B6")]
			[Address(RVA = "0x9F90", Offset = "0x9F90", VA = "0x9F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x9F91", Offset = "0x9F91", VA = "0x9F91", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x9F92", Offset = "0x9F92", VA = "0x9F92", Slot = "22")]
		protected override void OnShow(IsleAnimationMultipleLaunchesDialog.Args args)
		{
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x9F93", Offset = "0x9F93", VA = "0x9F93")]
		private void SliderButtonOnLongTapEvent(LongTap sender)
		{
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x9F94", Offset = "0x9F94", VA = "0x9F94")]
		private void HandleClickPriceButtonEvent()
		{
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x9F95", Offset = "0x9F95", VA = "0x9F95")]
		private void SliderOnOnValueChangedEvent(int value)
		{
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x9F96", Offset = "0x9F96", VA = "0x9F96")]
		private void DisplayPrice(int multiplier)
		{
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x9F97", Offset = "0x9F97", VA = "0x9F97")]
		private void DisplaySelectedValues(int current, int total)
		{
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x9F98", Offset = "0x9F98", VA = "0x9F98")]
		public IsleAnimationMultipleLaunchesDialog()
		{
		}

		// Token: 0x04002C66 RID: 11366
		[Token(Token = "0x4002C66")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IsleAnimation/IsleAnimationMultipleLaunchesDialog";

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _selectedValueField;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SliderWithButtons _slider;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private LongTap[] _sliderButtons;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _availQuickSelectionMinCount;

		// Token: 0x02000D14 RID: 3348
		[Token(Token = "0x2000D14")]
		public sealed class Args : BaseDialogWindow<IsleAnimationMultipleLaunchesDialog.Args>.BaseDialogWindowArgs
		{
			// Token: 0x060051BF RID: 20927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60051BF")]
			[Address(RVA = "0x9F99", Offset = "0x9F99", VA = "0x9F99")]
			public Args(int current, int min, int max, Money price, IsleAnimationsDic isleAnimationsDict, ulong userIsleId, UserData user)
			{
			}

			// Token: 0x04002C6E RID: 11374
			[Token(Token = "0x4002C6E")]
			[FieldOffset(Offset = "0x2C")]
			public readonly int Current;

			// Token: 0x04002C6F RID: 11375
			[Token(Token = "0x4002C6F")]
			[FieldOffset(Offset = "0x30")]
			public readonly int Min;

			// Token: 0x04002C70 RID: 11376
			[Token(Token = "0x4002C70")]
			[FieldOffset(Offset = "0x34")]
			public readonly int Max;

			// Token: 0x04002C71 RID: 11377
			[Token(Token = "0x4002C71")]
			[FieldOffset(Offset = "0x38")]
			public readonly Money Price;

			// Token: 0x04002C72 RID: 11378
			[Token(Token = "0x4002C72")]
			[FieldOffset(Offset = "0x3C")]
			public readonly UserData User;

			// Token: 0x04002C73 RID: 11379
			[Token(Token = "0x4002C73")]
			[FieldOffset(Offset = "0x40")]
			public readonly IsleAnimationsDic IsleAnimationsDict;

			// Token: 0x04002C74 RID: 11380
			[Token(Token = "0x4002C74")]
			[FieldOffset(Offset = "0x48")]
			public readonly ulong UserIsleId;
		}
	}
}
