using System;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000679 RID: 1657
	[Token(Token = "0x2000679")]
	public class LoaderValueRowView : TitleIconLoaderValueRow
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x794C", Offset = "0x794C", VA = "0x794C", Slot = "6")]
		public override void SetTitle(string value)
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x794D", Offset = "0x794D", VA = "0x794D", Slot = "7")]
		public override void SetTitleColor(in Color32 color)
		{
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x794E", Offset = "0x794E", VA = "0x794E", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x794F", Offset = "0x794F", VA = "0x794F")]
		public LoaderValueRowView()
		{
		}

		// Token: 0x04001620 RID: 5664
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _image;

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _valid_OK;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _valid_NOT_OK;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Price _resourcesPrice;
	}
}
