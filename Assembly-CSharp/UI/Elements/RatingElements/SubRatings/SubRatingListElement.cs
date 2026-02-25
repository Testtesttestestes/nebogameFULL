using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.RatingElements.SubRatings
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public class SubRatingListElement : SelectedGenericListElement<SubRatingListElementArgs>
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C1")]
		public override bool Selected
		{
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x6049", Offset = "0x6049", VA = "0x6049", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x604A", Offset = "0x604A", VA = "0x604A", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x604B", Offset = "0x604B", VA = "0x604B", Slot = "4")]
		protected override void OnInit(SubRatingListElementArgs args)
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x604C", Offset = "0x604C", VA = "0x604C")]
		public SubRatingListElement()
		{
		}

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _normalImage;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImageLoader _icon;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}
}
