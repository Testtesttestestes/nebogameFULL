using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D2 RID: 2514
	[Token(Token = "0x20009D2")]
	public class CollectionDicGroup
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x17000BDE")]
		public uint MaxRank
		{
			[Token(Token = "0x6003C2C")]
			[Address(RVA = "0x8AFB", Offset = "0x8AFB", VA = "0x8AFB")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x8AFC", Offset = "0x8AFC", VA = "0x8AFC")]
		public CollectionDicGroup(CollectionsDic dic, IEnumerable<CollectionRanksInfoDic> rankInfo, Dictionary<uint, CollectionRanksDic> ranks, Dictionary<uint, MedalDic> medals)
		{
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x8AFD", Offset = "0x8AFD", VA = "0x8AFD")]
		public MedalDic GetMedal(uint rank)
		{
			return null;
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x8AFE", Offset = "0x8AFE", VA = "0x8AFE")]
		public CollectionRanksDic GetCollectionRanksDic(uint rank)
		{
			return null;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x8AFF", Offset = "0x8AFF", VA = "0x8AFF")]
		public bool TryGetRankInfo(uint rank, out CollectionRanksInfoDic info)
		{
			return default(bool);
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x8B00", Offset = "0x8B00", VA = "0x8B00")]
		public void AddRank(uint rank, CollectionRanksDic collectionRanksDic, MedalDic medal)
		{
		}

		// Token: 0x04002141 RID: 8513
		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0x8")]
		public readonly CollectionsDic CollectionsDic;

		// Token: 0x04002142 RID: 8514
		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0xC")]
		private readonly IEnumerable<CollectionRanksInfoDic> _rankInfo;

		// Token: 0x04002143 RID: 8515
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<uint, CollectionRanksDic> _collectionRanksDicsByIndex;

		// Token: 0x04002144 RID: 8516
		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<uint, MedalDic> _medalsByRank;
	}
}
