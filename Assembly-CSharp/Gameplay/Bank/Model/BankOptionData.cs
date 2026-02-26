using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Money;
using Gameplay.Accounts.Model.Data;
using Gameplay.Billing.Model;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Services;
using Utils;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C57 RID: 3159
	[Token(Token = "0x2000C57")]
	public class BankOptionData
	{
		// Token: 0x140001DF RID: 479
		// (add) Token: 0x06004CF7 RID: 19703 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CF8 RID: 19704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DF")]
		public event Action RewardsChangedEvent
		{
			[Token(Token = "0x6004CF7")]
			[Address(RVA = "0x9B33", Offset = "0x9B33", VA = "0x9B33")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CF8")]
			[Address(RVA = "0x9B34", Offset = "0x9B34", VA = "0x9B34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001E0 RID: 480
		// (add) Token: 0x06004CF9 RID: 19705 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CFA RID: 19706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E0")]
		public event Action ResourceProfitChangedEvent
		{
			[Token(Token = "0x6004CF9")]
			[Address(RVA = "0x9B35", Offset = "0x9B35", VA = "0x9B35")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CFA")]
			[Address(RVA = "0x9B36", Offset = "0x9B36", VA = "0x9B36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001E1 RID: 481
		// (add) Token: 0x06004CFB RID: 19707 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CFC RID: 19708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E1")]
		public event Action IsProcessingChangedEvent
		{
			[Token(Token = "0x6004CFB")]
			[Address(RVA = "0x9B37", Offset = "0x9B37", VA = "0x9B37")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CFC")]
			[Address(RVA = "0x9B38", Offset = "0x9B38", VA = "0x9B38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001E2 RID: 482
		// (add) Token: 0x06004CFD RID: 19709 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CFE RID: 19710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E2")]
		public event Action StickerIdChangedEvent
		{
			[Token(Token = "0x6004CFD")]
			[Address(RVA = "0x9B39", Offset = "0x9B39", VA = "0x9B39")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CFE")]
			[Address(RVA = "0x9B3A", Offset = "0x9B3A", VA = "0x9B3A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D00 RID: 19712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F87")]
		public BankOptionData.ExtPriceData ExtPrice
		{
			[Token(Token = "0x6004CFF")]
			[Address(RVA = "0x9B3B", Offset = "0x9B3B", VA = "0x9B3B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D00")]
			[Address(RVA = "0x9B3C", Offset = "0x9B3C", VA = "0x9B3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x0000E238 File Offset: 0x0000C438
		// (set) Token: 0x06004D02 RID: 19714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F88")]
		public double VipPoints
		{
			[Token(Token = "0x6004D01")]
			[Address(RVA = "0x9B3D", Offset = "0x9B3D", VA = "0x9B3D")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6004D02")]
			[Address(RVA = "0x9B3E", Offset = "0x9B3E", VA = "0x9B3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x17000F89")]
		public int VipPointsInteger
		{
			[Token(Token = "0x6004D03")]
			[Address(RVA = "0x1D3A", Offset = "0x1D3A", VA = "0x1D3A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x0000E268 File Offset: 0x0000C468
		// (set) Token: 0x06004D05 RID: 19717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F8A")]
		public uint PlacementId
		{
			[Token(Token = "0x6004D04")]
			[Address(RVA = "0x9B3F", Offset = "0x9B3F", VA = "0x9B3F")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004D05")]
			[Address(RVA = "0x9B40", Offset = "0x9B40", VA = "0x9B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06004D06 RID: 19718 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x17000F8B")]
		public bool IsAdOption
		{
			[Token(Token = "0x6004D06")]
			[Address(RVA = "0x9B41", Offset = "0x9B41", VA = "0x9B41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x0000E298 File Offset: 0x0000C498
		// (set) Token: 0x06004D08 RID: 19720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F8C")]
		public OptionTypesDic.Types.OptionType OptionType
		{
			[Token(Token = "0x6004D07")]
			[Address(RVA = "0x9B42", Offset = "0x9B42", VA = "0x9B42")]
			[CompilerGenerated]
			get
			{
				return OptionTypesDic.Types.OptionType.Diamond;
			}
			[Token(Token = "0x6004D08")]
			[Address(RVA = "0x9B43", Offset = "0x9B43", VA = "0x9B43")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[Token(Token = "0x17000F8D")]
		public uint OptionId
		{
			[Token(Token = "0x6004D09")]
			[Address(RVA = "0x9B44", Offset = "0x9B44", VA = "0x9B44")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F8E")]
		public string OptionIdString
		{
			[Token(Token = "0x6004D0A")]
			[Address(RVA = "0x370F", Offset = "0x370F", VA = "0x370F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[Token(Token = "0x17000F8F")]
		public uint SortOrder
		{
			[Token(Token = "0x6004D0B")]
			[Address(RVA = "0x9B45", Offset = "0x9B45", VA = "0x9B45")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06004D0C RID: 19724 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D0D RID: 19725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F90")]
		public ResourceProfit ResourceProfit
		{
			[Token(Token = "0x6004D0C")]
			[Address(RVA = "0x9B46", Offset = "0x9B46", VA = "0x9B46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D0D")]
			[Address(RVA = "0x9B47", Offset = "0x9B47", VA = "0x9B47")]
			private set
			{
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06004D0E RID: 19726 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D0F RID: 19727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F91")]
		public BaseOption BaseOption
		{
			[Token(Token = "0x6004D0E")]
			[Address(RVA = "0x9B48", Offset = "0x9B48", VA = "0x9B48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D0F")]
			[Address(RVA = "0x9B49", Offset = "0x9B49", VA = "0x9B49")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D11 RID: 19729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F92")]
		public OptionRewards OptionRewards
		{
			[Token(Token = "0x6004D10")]
			[Address(RVA = "0x9B4A", Offset = "0x9B4A", VA = "0x9B4A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D11")]
			[Address(RVA = "0x9B4B", Offset = "0x9B4B", VA = "0x9B4B")]
			set
			{
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		// (set) Token: 0x06004D13 RID: 19731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F93")]
		public uint PurchaseCount
		{
			[Token(Token = "0x6004D12")]
			[Address(RVA = "0x9B4C", Offset = "0x9B4C", VA = "0x9B4C")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004D13")]
			[Address(RVA = "0x9B4D", Offset = "0x9B4D", VA = "0x9B4D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D15 RID: 19733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F94")]
		public string BankBgAssetId
		{
			[Token(Token = "0x6004D14")]
			[Address(RVA = "0x9B4E", Offset = "0x9B4E", VA = "0x9B4E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D15")]
			[Address(RVA = "0x9B4F", Offset = "0x9B4F", VA = "0x9B4F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D17 RID: 19735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F95")]
		public string PurchaseTitle
		{
			[Token(Token = "0x6004D16")]
			[Address(RVA = "0x9B50", Offset = "0x9B50", VA = "0x9B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D17")]
			[Address(RVA = "0x9B51", Offset = "0x9B51", VA = "0x9B51")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06004D18 RID: 19736 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D19 RID: 19737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F96")]
		public string EventPromoTitle
		{
			[Token(Token = "0x6004D18")]
			[Address(RVA = "0x9B52", Offset = "0x9B52", VA = "0x9B52")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D19")]
			[Address(RVA = "0x9B53", Offset = "0x9B53", VA = "0x9B53")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D1B RID: 19739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F97")]
		public string EventPromoDescription
		{
			[Token(Token = "0x6004D1A")]
			[Address(RVA = "0x9B54", Offset = "0x9B54", VA = "0x9B54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D1B")]
			[Address(RVA = "0x9B55", Offset = "0x9B55", VA = "0x9B55")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D1D RID: 19741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F98")]
		public string IsleImageAssetId
		{
			[Token(Token = "0x6004D1C")]
			[Address(RVA = "0x9B56", Offset = "0x9B56", VA = "0x9B56")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D1D")]
			[Address(RVA = "0x9B57", Offset = "0x9B57", VA = "0x9B57")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D1F RID: 19743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F99")]
		public BackTime Backtime
		{
			[Token(Token = "0x6004D1E")]
			[Address(RVA = "0x9B58", Offset = "0x9B58", VA = "0x9B58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D1F")]
			[Address(RVA = "0x9B59", Offset = "0x9B59", VA = "0x9B59")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06004D20 RID: 19744 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D21 RID: 19745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F9A")]
		public Money Price
		{
			[Token(Token = "0x6004D20")]
			[Address(RVA = "0x9B5A", Offset = "0x9B5A", VA = "0x9B5A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D21")]
			[Address(RVA = "0x9B5B", Offset = "0x9B5B", VA = "0x9B5B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06004D22 RID: 19746 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D23 RID: 19747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F9B")]
		public List<BankOptionArtikulContainerData> ArtikulContainers
		{
			[Token(Token = "0x6004D22")]
			[Address(RVA = "0x9B5C", Offset = "0x9B5C", VA = "0x9B5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D23")]
			[Address(RVA = "0x9B5D", Offset = "0x9B5D", VA = "0x9B5D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06004D24 RID: 19748 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x17000F9C")]
		public bool NeedShowFaqButton
		{
			[Token(Token = "0x6004D24")]
			[Address(RVA = "0x9B5E", Offset = "0x9B5E", VA = "0x9B5E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x17000F9D")]
		public bool NeedShowTitle
		{
			[Token(Token = "0x6004D25")]
			[Address(RVA = "0x9B5F", Offset = "0x9B5F", VA = "0x9B5F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06004D26 RID: 19750 RVA: 0x0000E328 File Offset: 0x0000C528
		// (set) Token: 0x06004D27 RID: 19751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F9E")]
		public int StarsNum
		{
			[Token(Token = "0x6004D26")]
			[Address(RVA = "0x9B60", Offset = "0x9B60", VA = "0x9B60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004D27")]
			[Address(RVA = "0x9B61", Offset = "0x9B61", VA = "0x9B61")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06004D28 RID: 19752 RVA: 0x0000E340 File Offset: 0x0000C540
		// (set) Token: 0x06004D29 RID: 19753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F9F")]
		public uint StickerId
		{
			[Token(Token = "0x6004D28")]
			[Address(RVA = "0x9B62", Offset = "0x9B62", VA = "0x9B62")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004D29")]
			[Address(RVA = "0x9B63", Offset = "0x9B63", VA = "0x9B63")]
			private set
			{
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06004D2A RID: 19754 RVA: 0x0000E358 File Offset: 0x0000C558
		// (set) Token: 0x06004D2B RID: 19755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA0")]
		public bool SingleTimeSell
		{
			[Token(Token = "0x6004D2A")]
			[Address(RVA = "0x9B64", Offset = "0x9B64", VA = "0x9B64")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D2B")]
			[Address(RVA = "0x9B65", Offset = "0x9B65", VA = "0x9B65")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x06004D2D RID: 19757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA1")]
		public bool WasPurchasedThisSession
		{
			[Token(Token = "0x6004D2C")]
			[Address(RVA = "0x9B66", Offset = "0x9B66", VA = "0x9B66")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D2D")]
			[Address(RVA = "0x9B67", Offset = "0x9B67", VA = "0x9B67")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06004D2E RID: 19758 RVA: 0x0000E388 File Offset: 0x0000C588
		// (set) Token: 0x06004D2F RID: 19759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA2")]
		public bool IsProcessing
		{
			[Token(Token = "0x6004D2E")]
			[Address(RVA = "0x9B68", Offset = "0x9B68", VA = "0x9B68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D2F")]
			[Address(RVA = "0x9B69", Offset = "0x9B69", VA = "0x9B69")]
			set
			{
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06004D30 RID: 19760 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[Token(Token = "0x17000FA3")]
		public bool IsValid
		{
			[Token(Token = "0x6004D30")]
			[Address(RVA = "0x9B6A", Offset = "0x9B6A", VA = "0x9B6A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x9B6B", Offset = "0x9B6B", VA = "0x9B6B")]
		protected BankOptionData(OptionTypesDic.Types.OptionType optionType)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Model_BankOptionData___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x38) = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  if ((*(int *)(param1 + 0x34) == 0) ||
		     (iVar1 = Protocol_Common_CubicBezier__Equals(*(int *)(param1 + 0x34),param2_00,0), iVar1 == 0))
		  {
		    *(undefined4 *)(param1 + 0x34) = param2_00;
		    iVar1 = *(int *)(param1 + 0xc);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  if (*(int *)(param2 + 0x14) != *(int *)(param1 + 0x68)) {
		    *(int *)(param1 + 0x68) = *(int *)(param2 + 0x14);
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  *(undefined1 *)(param1 + 0x6c) = *(undefined1 *)(param2 + 0x18);
		  *(undefined4 *)(param1 + 0x28) = *(undefined4 *)(param2 + 0x1c);
		  return;
		}
		*/

		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x9B6C", Offset = "0x9B6C", VA = "0x9B6C")]
		public static void FillPaymentOptionData(BankOptionData result, PaymentOption option)
		{
		/* --- GHIDRA: FillPaymentOptionData ---
		void Gameplay_Bank_Model_BankOptionData__FillPaymentOptionData
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(int *)(param1 + 0x34) == 0) ||
		     (iVar1 = Protocol_Common_CubicBezier__Equals(*(int *)(param1 + 0x34),0,0), iVar1 == 0)) {
		    *(undefined4 *)(param1 + 0x34) = 0;
		    iVar1 = *(int *)(param1 + 0xc);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  *(undefined4 *)(param1 + 0x38) = *(undefined4 *)(param2 + 0xc);
		  if (*(int *)(param2 + 0x10) != *(int *)(param1 + 0x68)) {
		    *(int *)(param1 + 0x68) = *(int *)(param2 + 0x10);
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x9B6D", Offset = "0x9B6D", VA = "0x9B6D")]
		public static void FillArtikulOption(BankOptionData result, ArtikulOptionsDic optionsDic)
		{
		/* --- GHIDRA: FillArtikulOption ---
		void Gameplay_Bank_Model_BankOptionData__FillArtikulOption(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(int *)(param1 + 0x34) == 0) ||
		     (iVar1 = Protocol_Common_CubicBezier__Equals(*(int *)(param1 + 0x34),0,0), iVar1 == 0)) {
		    *(undefined4 *)(param1 + 0x34) = 0;
		    iVar1 = *(int *)(param1 + 0xc);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  iVar1 = *(int *)(param2 + 0xc);
		  *(undefined4 *)(param1 + 0x38) = *(undefined4 *)(iVar1 + 0xc);
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != *(int *)(param1 + 0x68)) {
		    *(int *)(param1 + 0x68) = iVar1;
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x9B6E", Offset = "0x9B6E", VA = "0x9B6E")]
		public static void FillRegularOption(BankOptionData result, RegularOptionsDic optionsDic)
		{
		/* --- GHIDRA: FillRegularOption ---
		void Gameplay_Bank_Model_BankOptionData__FillRegularOption(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  double dVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a597c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_Money__int___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Model_BankOptionData___c__FillBillingData_b__118_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData___c_TypeInfo);
		    DAT_ram_00a597c9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                    (param2,param1,*(undefined4 *)(*param2 + 0x104));
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0x18);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  if (*(int *)(Gameplay_Bank_Model_BankOptionData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Bank_Model_BankOptionData___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Bank_Model_BankOptionData___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Bank_Model_BankOptionData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Bank_Model_BankOptionData___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Bank_Model_BankOptionData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_Money__int__TypeInfo);
		    func_ii_7937(param1_00,uVar4,
		                 Method_Gameplay_Bank_Model_BankOptionData___c__FillBillingData_b__118_0__,0);
		    *(int *)(*(int *)(Gameplay_Bank_Model_BankOptionData___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_OrderBy_Money__int___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		  *(undefined4 *)(param1 + 0x5c) = uVar1;
		  uVar4 = *(undefined4 *)(param1 + 0x38);
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  dVar2 = Core_Extensions_Dict_AssistantDictExt__GetDescriptionActive(uVar4,uVar1,0);
		  *(double *)(param1 + 0x20) = dVar2;
		  return;
		}
		*/

		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x9B6F", Offset = "0x9B6F", VA = "0x9B6F")]
		public static void FillBillingData(BankOptionData result, AbstractBillingModel billingModel)
		{
		/* --- GHIDRA: FillBillingData ---
		int Gameplay_Bank_Model_BankOptionData__FillBillingData
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a597ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData_TypeInfo);
		    DAT_ram_00a597ca = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionData_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x2c) = 0;
		  iVar3 = *(int *)(param1 + 0xc);
		  *(undefined4 *)(param1_00 + 0x38) = *(undefined4 *)(iVar3 + 0xc);
		  uVar1 = *(undefined4 *)(iVar3 + 0x10);
		  if ((*(int *)(param1_00 + 0x34) == 0) ||
		     (iVar2 = Protocol_Common_CubicBezier__Equals(*(int *)(param1_00 + 0x34),uVar1,0), iVar2 == 0))
		  {
		    *(undefined4 *)(param1_00 + 0x34) = uVar1;
		    iVar2 = *(int *)(param1_00 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  if (*(int *)(iVar3 + 0x14) != *(int *)(param1_00 + 0x68)) {
		    *(int *)(param1_00 + 0x68) = *(int *)(iVar3 + 0x14);
		    iVar2 = *(int *)(param1_00 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  *(undefined1 *)(param1_00 + 0x6c) = *(undefined1 *)(iVar3 + 0x18);
		  *(undefined4 *)(param1_00 + 0x28) = *(undefined4 *)(iVar3 + 0x1c);
		  uVar1 = Core_Extensions_Dict_DiamondOptionsDicExt__GetEventBannerEventAssetId(param1,0);
		  *(undefined4 *)(param1_00 + 0x44) = uVar1;
		  uVar1 = Core_Extensions_Dict_DiamondOptionsDicExt__GetSpecialOfferIslandIconAssetId(param1,0);
		  *(undefined4 *)(param1_00 + 0x48) = uVar1;
		  uVar1 = Core_Extensions_Dict_DiamondOptionsDicExt__GetPurchaseTitle(param1,0);
		  *(undefined4 *)(param1_00 + 0x4c) = uVar1;
		  uVar1 = Core_Extensions_Dict_DiamondOptionsDicExt__GetEventPromoTitle(param1,0);
		  *(undefined4 *)(param1_00 + 0x50) = uVar1;
		  uVar1 = Core_Extensions_Dict_DiamondOptionsDicExt__GetBankBgAssetId(param1,0);
		  *(undefined4 *)(param1_00 + 0x54) = uVar1;
		  Gameplay_Bank_Model_BankOptionData__FillRegularOption(param1_00,param2,param1_00);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x9B70", Offset = "0x9B70", VA = "0x9B70")]
		public static BankOptionData Create(DiamondOptionsDic option, AbstractBillingModel billingModel)
		{
		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: Create ---
		void Gameplay_Bank_Model_BankOptionData__Create
		               (int param1,double param2,double param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(double *)(param1 + 0x10) = param3;
		  *(double *)(param1 + 8) = param2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x9B71", Offset = "0x9B71", VA = "0x9B71")]
		public static BankOptionData Create(CrystalEnergyOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x9B72", Offset = "0x9B72", VA = "0x9B72")]
		public static BankOptionData Create(NewResourceOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x9B73", Offset = "0x9B73", VA = "0x9B73")]
		public static BankOptionData Create(ColossusFragmentsOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D3A")]
		[Address(RVA = "0x9B74", Offset = "0x9B74", VA = "0x9B74")]
		public static BankOptionData Create(ArtikulOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D3B")]
		[Address(RVA = "0x9B75", Offset = "0x9B75", VA = "0x9B75")]
		public static AccountOptionData Create(AccountOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D3C")]
		[Address(RVA = "0x9B76", Offset = "0x9B76", VA = "0x9B76")]
		public static EndlessPaymentOptionData Create(EndlessPaymentOptionListOptionDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D3D")]
		[Address(RVA = "0x9B77", Offset = "0x9B77", VA = "0x9B77")]
		public static BankOptionData Create(MarketOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D3E")]
		[Address(RVA = "0x9B78", Offset = "0x9B78", VA = "0x9B78")]
		public static RegularOptionData Create(RegularOptionsDic option, AbstractBillingModel billingModel)
		{
			return null;
		}

		// Token: 0x04002A13 RID: 10771
		[Token(Token = "0x4002A13")]
		[FieldOffset(Offset = "0x30")]
		private string _optionIdString;

		// Token: 0x04002A14 RID: 10772
		[Token(Token = "0x4002A14")]
		[FieldOffset(Offset = "0x34")]
		private ResourceProfit _resourceProfit;

		// Token: 0x04002A16 RID: 10774
		[Token(Token = "0x4002A16")]
		[FieldOffset(Offset = "0x3C")]
		private OptionRewards _optionRewards;

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x68")]
		private uint _stickerId;

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x6E")]
		private bool _isProcessing;

		// Token: 0x02000C58 RID: 3160
		[Token(Token = "0x2000C58")]
		public class ExtPriceData
		{
			// Token: 0x06004D3F RID: 19775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004D3F")]
			[Address(RVA = "0x9B79", Offset = "0x9B79", VA = "0x9B79")]
			public ExtPriceData(double extPriceValue, double extPriceValueDictionary, string extPriceString)
			{
			}

			// Token: 0x04002A25 RID: 10789
			[Token(Token = "0x4002A25")]
			[FieldOffset(Offset = "0x8")]
			public readonly double ExtPriceValue;

			// Token: 0x04002A26 RID: 10790
			[Token(Token = "0x4002A26")]
			[FieldOffset(Offset = "0x10")]
			public readonly double ExtPriceValueDictionary;

			// Token: 0x04002A27 RID: 10791
			[Token(Token = "0x4002A27")]
			[FieldOffset(Offset = "0x18")]
			public readonly string ExtPriceString;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_RewardsChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__add_RewardsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_RewardsChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__remove_RewardsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ResourceProfitChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__add_ResourceProfitChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ResourceProfitChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__remove_ResourceProfitChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_IsProcessingChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__add_IsProcessingChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_IsProcessingChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__remove_IsProcessingChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_StickerIdChangedEvent ---
		void Gameplay_Bank_Model_BankOptionData__add_StickerIdChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_VipPointsInteger ---
		int * Gameplay_Bank_Model_BankOptionData__get_VipPointsInteger(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_OptionIdString ---
		void Gameplay_Bank_Model_BankOptionData__get_OptionIdString
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param4_00;
		  
		  param4_00 = func_ii_5618(0);
		  BestHTTP_Forms_HTTPFormBase__AddBinaryData(param1,param2,param3,param4_00,param3);
		  return;
		}
		*/


		/* --- GHIDRA: get_ResourceProfit ---
		void Gameplay_Bank_Model_BankOptionData__get_ResourceProfit
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(int *)(param1 + 0x34) == 0) ||
		     (iVar1 = Protocol_Common_CubicBezier__Equals(*(int *)(param1 + 0x34),param2,0), iVar1 == 0)) {
		    *(undefined4 *)(param1 + 0x34) = param2;
		    iVar1 = *(int *)(param1 + 0xc);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_OptionRewards ---
		void Gameplay_Bank_Model_BankOptionData__get_OptionRewards(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x3c) != param2) {
		    *(int *)(param1 + 0x3c) = param2;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_NeedShowFaqButton ---
		uint Gameplay_Bank_Model_BankOptionData__get_NeedShowFaqButton(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 0x2c) == 3);
		}
		*/


		/* --- GHIDRA: get_StickerId ---
		void Gameplay_Bank_Model_BankOptionData__get_StickerId(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x68) != param2) {
		    *(int *)(param1 + 0x68) = param2;
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_IsProcessing ---
		void Gameplay_Bank_Model_BankOptionData__get_IsProcessing(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(byte *)(param1 + 0x6e) != param2) {
		    *(char *)(param1 + 0x6e) = (char)param2;
		    iVar1 = *(int *)(param1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsProcessing ---
		uint Gameplay_Bank_Model_BankOptionData__set_IsProcessing(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x6c) != '\0') {
		    return (uint)(*(char *)(param1 + 0x6d) == '\0');
		  }
		  return 1;
		}
		*/

}
