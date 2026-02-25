using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Elements.Sliders;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x200065B")]
	public class ConfirmSplitArtifactWindow : BaseDialogWindow<ConfirmSplitArtifactWindow.ConfirmSplitAtrifactWindowArgs>
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000775")]
		public override string WindowId
		{
			[Token(Token = "0x6002784")]
			[Address(RVA = "0x78B5", Offset = "0x78B5", VA = "0x78B5", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x17000776")]
		public uint Value
		{
			[Token(Token = "0x6002785")]
			[Address(RVA = "0x78B6", Offset = "0x78B6", VA = "0x78B6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x78B7", Offset = "0x78B7", VA = "0x78B7")]
		private void Start()
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x78B8", Offset = "0x78B8", VA = "0x78B8")]
		public static ConfirmSplitArtifactWindow Show(ArtifactData artifact, Action<uint, uint> resultCallback)
		{
			return null;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x78B9", Offset = "0x78B9", VA = "0x78B9", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x78BA", Offset = "0x78BA", VA = "0x78BA", Slot = "29")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x78BB", Offset = "0x78BB", VA = "0x78BB")]
		private void OnOk(SplitArtifactView.ArtifactSelection selection, int value)
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x78BC", Offset = "0x78BC", VA = "0x78BC")]
		private void OnArtifactSelectHandler(SplitArtifactView.ArtifactSelection selection)
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x78BD", Offset = "0x78BD", VA = "0x78BD")]
		private void OnSliderValueChangedEventHandler(int value)
		{
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x00007920 File Offset: 0x00005B20
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000777")]
		public int LeftArtifactValue
		{
			[Token(Token = "0x600278D")]
			[Address(RVA = "0x78BE", Offset = "0x78BE", VA = "0x78BE")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600278E")]
			[Address(RVA = "0x78BF", Offset = "0x78BF", VA = "0x78BF")]
			set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x00007938 File Offset: 0x00005B38
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000778")]
		public int RightArtifactValue
		{
			[Token(Token = "0x600278F")]
			[Address(RVA = "0x78C0", Offset = "0x78C0", VA = "0x78C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002790")]
			[Address(RVA = "0x78C1", Offset = "0x78C1", VA = "0x78C1")]
			set
			{
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x17000779")]
		public int ArtifactMaxValue
		{
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x78C2", Offset = "0x78C2", VA = "0x78C2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x1700077A")]
		public SplitArtifactView.ArtifactSelection CurrentArtifactSelection
		{
			[Token(Token = "0x6002792")]
			[Address(RVA = "0x78C3", Offset = "0x78C3", VA = "0x78C3")]
			get
			{
				return SplitArtifactView.ArtifactSelection.Left;
			}
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x78C4", Offset = "0x78C4", VA = "0x78C4")]
		public ConfirmSplitArtifactWindow()
		{
		}

		// Token: 0x040015AC RID: 5548
		[Token(Token = "0x40015AC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ConfirmSplitArtifactWindow";

		// Token: 0x040015AD RID: 5549
		[Token(Token = "0x40015AD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SplitSlider _slider;

		// Token: 0x040015AE RID: 5550
		[Token(Token = "0x40015AE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SplitArtifactView _artifactView;

		// Token: 0x040015AF RID: 5551
		[Token(Token = "0x40015AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private NumpadView _numpad;

		// Token: 0x040015B0 RID: 5552
		[Token(Token = "0x40015B0")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _separator;

		// Token: 0x040015B1 RID: 5553
		[Token(Token = "0x40015B1")]
		[FieldOffset(Offset = "0x60")]
		public Action<int> OnSliderChanged;

		// Token: 0x040015B2 RID: 5554
		[Token(Token = "0x40015B2")]
		[FieldOffset(Offset = "0x64")]
		public Action<SplitArtifactView.ArtifactSelection> OnArtifactSelect;

		// Token: 0x0200065C RID: 1628
		[Token(Token = "0x200065C")]
		public class ConfirmSplitAtrifactWindowArgs : BaseDialogWindow<ConfirmSplitArtifactWindow.ConfirmSplitAtrifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002794 RID: 10132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002794")]
			[Address(RVA = "0x78C5", Offset = "0x78C5", VA = "0x78C5")]
			public ConfirmSplitAtrifactWindowArgs()
			{
			}

			// Token: 0x040015B3 RID: 5555
			[Token(Token = "0x40015B3")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData ArtifactData;
		}
	}
}
