using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C45 RID: 3141
	[Token(Token = "0x2000C45")]
	public class BankPromotionInfoWindow : BaseDialogWindow<BankPromotionInfoWindow.BankPromotionInfoWindowArgs>
	{
		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F73")]
		public override string WindowId
		{
			[Token(Token = "0x6004C9F")]
			[Address(RVA = "0x9AE0", Offset = "0x9AE0", VA = "0x9AE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x9AE1", Offset = "0x9AE1", VA = "0x9AE1")]
		public static BankPromotionInfoWindow Show(PromotionsDic promotionsDic)
		{
			return null;
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x9AE2", Offset = "0x9AE2", VA = "0x9AE2", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x9AE3", Offset = "0x9AE3", VA = "0x9AE3")]
		public BankPromotionInfoWindow()
		{
		}

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankPromotionInfoWindow";

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameRawImage _gameRawImage;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DecoratedTitle _prizeTitle;

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DecoratedTitle _superPrizeTitle;

		// Token: 0x02000C46 RID: 3142
		[Token(Token = "0x2000C46")]
		public class BankPromotionInfoWindowArgs : BaseDialogWindow<BankPromotionInfoWindow.BankPromotionInfoWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004CA3 RID: 19619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CA3")]
			[Address(RVA = "0x9AE4", Offset = "0x9AE4", VA = "0x9AE4")]
			public BankPromotionInfoWindowArgs()
			{
			}

			// Token: 0x040029D6 RID: 10710
			[Token(Token = "0x40029D6")]
			[FieldOffset(Offset = "0x2C")]
			public PromotionsDic PromotionsDic;
		}
	}
}
