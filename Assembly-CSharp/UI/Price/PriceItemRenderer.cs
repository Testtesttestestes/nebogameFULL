using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Price
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public class PriceItemRenderer : MonoBehaviour
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x1700018B")]
		public Color32 IsOkColor
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x5F00", Offset = "0x5F00", VA = "0x5F00")]
			get
			{
				return default(Color32);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x1700018C")]
		public Color32 IsNotOkColor
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x5F01", Offset = "0x5F01", VA = "0x5F01")]
			get
			{
				return default(Color32);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		public virtual Func<Protocol.Consts.Resources, string> GetAssetIdHandler
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x5F02", Offset = "0x5F02", VA = "0x5F02", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x5F03", Offset = "0x5F03", VA = "0x5F03", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018E")]
		public virtual Func<Money.MoneyType, string> GetMoneyAssetIdHandler
		{
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x5F04", Offset = "0x5F04", VA = "0x5F04", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x5F05", Offset = "0x5F05", VA = "0x5F05", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x5F06", Offset = "0x5F06", VA = "0x5F06")]
		private static string GetAssetIdHandlerDefault(Protocol.Consts.Resources resId)
		{
			return null;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x5F07", Offset = "0x5F07", VA = "0x5F07")]
		private static string GetAssetIdHandlerDefault(Money.MoneyType moneyType)
		{
			return null;
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00003D68 File Offset: 0x00001F68
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018F")]
		public bool ValidIconEnabled
		{
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x5F08", Offset = "0x5F08", VA = "0x5F08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x1F8B", Offset = "0x1F8B", VA = "0x1F8B")]
			set
			{
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x5F09", Offset = "0x5F09", VA = "0x5F09")]
		private void HandleValidIconEnabledChanged()
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x5F0A", Offset = "0x5F0A", VA = "0x5F0A")]
		public void SetIcon(Sprite value)
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x5F0B", Offset = "0x5F0B", VA = "0x5F0B")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00003D80 File Offset: 0x00001F80
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000190")]
		public Protocol.Consts.Resources ResId
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x5F0C", Offset = "0x5F0C", VA = "0x5F0C")]
			get
			{
				return Protocol.Consts.Resources.UnknownResource;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x1F89", Offset = "0x1F89", VA = "0x1F89")]
			set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000191")]
		public Money.MoneyType MoneyType
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x5F0D", Offset = "0x5F0D", VA = "0x5F0D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x1F88", Offset = "0x1F88", VA = "0x1F88")]
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		public bool TruncatePrice
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x5F0E", Offset = "0x5F0E", VA = "0x5F0E")]
			set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		public double Value
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x1F8C", Offset = "0x1F8C", VA = "0x1F8C")]
			set
			{
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x5F0F", Offset = "0x5F0F", VA = "0x5F0F")]
		public void SetIsOk(bool value)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x1F8A", Offset = "0x1F8A", VA = "0x1F8A")]
		public void SetColor(in Color32 color)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x5F10", Offset = "0x5F10", VA = "0x5F10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x5F11", Offset = "0x5F11", VA = "0x5F11")]
		public PriceItemRenderer()
		{
		}

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _validIcon;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueFiled;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Sprite _isOk;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _isNotOk;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color32 _isOkColor;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color32 _isNotOkColor;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x2C")]
		private bool _validIconEnabled;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x30")]
		private Protocol.Consts.Resources? _resId;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x38")]
		private Money.MoneyType _moneyType;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x44")]
		private bool _truncatePrice;
	}
}
