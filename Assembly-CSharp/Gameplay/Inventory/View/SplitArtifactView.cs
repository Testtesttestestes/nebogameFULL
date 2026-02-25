using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x2000664")]
	public class SplitArtifactView : AbstractDataRenderer<ArtifactData>
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x78E7", Offset = "0x78E7", VA = "0x78E7", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x78E8", Offset = "0x78E8", VA = "0x78E8")]
		private void Start()
		{
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x78E9", Offset = "0x78E9", VA = "0x78E9")]
		private void OnLeftArtifactClick(ArtifactView view)
		{
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x78EA", Offset = "0x78EA", VA = "0x78EA")]
		private void OnRightArtifactClick(ArtifactView view)
		{
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x78EB", Offset = "0x78EB", VA = "0x78EB", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000788")]
		public override ArtifactData Data
		{
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0x78EC", Offset = "0x78EC", VA = "0x78EC", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C7")]
			[Address(RVA = "0x78ED", Offset = "0x78ED", VA = "0x78ED", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000079B0 File Offset: 0x00005BB0
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000789")]
		public SplitArtifactView.ArtifactSelection CurrentSelection
		{
			[Token(Token = "0x60027C8")]
			[Address(RVA = "0x78EE", Offset = "0x78EE", VA = "0x78EE")]
			[CompilerGenerated]
			get
			{
				return SplitArtifactView.ArtifactSelection.Left;
			}
			[Token(Token = "0x60027C9")]
			[Address(RVA = "0x78EF", Offset = "0x78EF", VA = "0x78EF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x78F0", Offset = "0x78F0", VA = "0x78F0")]
		public SplitArtifactView()
		{
		}

		// Token: 0x040015C1 RID: 5569
		[Token(Token = "0x40015C1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtifactView _leftArtifactView;

		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtifactView _rightArtifactView;

		// Token: 0x040015C3 RID: 5571
		[Token(Token = "0x40015C3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _leftArtifactViewSelector;

		// Token: 0x040015C4 RID: 5572
		[Token(Token = "0x40015C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rightArtifactViewSelector;

		// Token: 0x040015C5 RID: 5573
		[Token(Token = "0x40015C5")]
		[FieldOffset(Offset = "0x34")]
		public Action<SplitArtifactView.ArtifactSelection> OnArtifactSelect;

		// Token: 0x02000665 RID: 1637
		[Token(Token = "0x2000665")]
		public enum ArtifactSelection
		{
			// Token: 0x040015C8 RID: 5576
			[Token(Token = "0x40015C8")]
			Left,
			// Token: 0x040015C9 RID: 5577
			[Token(Token = "0x40015C9")]
			Right
		}
	}
}
