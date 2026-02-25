using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Shop;

namespace Gameplay.Shop
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public class ShopModel : AbstractModel
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EA")]
		public UserIsle UserIsle
		{
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x71D1", Offset = "0x71D1", VA = "0x71D1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x71D2", Offset = "0x71D2", VA = "0x71D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EB")]
		public ShopLevelDic ShopLevelDic
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x71D3", Offset = "0x71D3", VA = "0x71D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x71D4", Offset = "0x71D4", VA = "0x71D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00006810 File Offset: 0x00004A10
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EC")]
		public int NeboMarketSlots
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x71D5", Offset = "0x71D5", VA = "0x71D5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x71D6", Offset = "0x71D6", VA = "0x71D6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00006828 File Offset: 0x00004A28
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005ED")]
		public bool HasTradeAccount
		{
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x71D7", Offset = "0x71D7", VA = "0x71D7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x71D8", Offset = "0x71D8", VA = "0x71D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00006840 File Offset: 0x00004A40
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EE")]
		public int MaxNormalSlots
		{
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x71D9", Offset = "0x71D9", VA = "0x71D9")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x71DA", Offset = "0x71DA", VA = "0x71DA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EF")]
		public int LastSelectedSlotId
		{
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x71DB", Offset = "0x71DB", VA = "0x71DB")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x71DC", Offset = "0x71DC", VA = "0x71DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F0")]
		public List<ShopArtifactDataDecorator> Artifacts
		{
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x71DD", Offset = "0x71DD", VA = "0x71DD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x71DE", Offset = "0x71DE", VA = "0x71DE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x170005F1")]
		public bool IsMyShop
		{
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x71DF", Offset = "0x71DF", VA = "0x71DF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x71E0", Offset = "0x71E0", VA = "0x71E0")]
		public ShopModel(IDictProvider dictProvider, UserData loggedUser, UserData user, UserIsle userIsle)
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x71E1", Offset = "0x71E1", VA = "0x71E1")]
		public void UpdateShopLevel()
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x71E2", Offset = "0x71E2", VA = "0x71E2")]
		public void RemoveArtifactById(ulong artifactId)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x71E3", Offset = "0x71E3", VA = "0x71E3")]
		public int GetFirstNormalEmptySlot()
		{
			return 0;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x71E4", Offset = "0x71E4", VA = "0x71E4")]
		public int GetFirstNeboMarketEmptySlot()
		{
			return 0;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x71E5", Offset = "0x71E5", VA = "0x71E5")]
		public void AddArtifact(UserArtifactWithPrice userArtifact)
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x71E6", Offset = "0x71E6", VA = "0x71E6")]
		private int FromServerId(int index)
		{
			return 0;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x71E7", Offset = "0x71E7", VA = "0x71E7")]
		public uint ToServerId(int index)
		{
			return 0U;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002083")]
		[Address(RVA = "0x71E8", Offset = "0x71E8", VA = "0x71E8")]
		public void UpdateItems(ProtoGetShopItemsInfoAns msg)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x71E9", Offset = "0x71E9", VA = "0x71E9")]
		private ShopArtifactDataDecorator ConstructShopArtifactDataDecorator(UserArtifactWithPrice artifactWithPrice)
		{
			return null;
		}

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0xC")]
		public readonly UserData LoggedUser;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x10")]
		private IDictProvider _dictProvider;
	}
}
