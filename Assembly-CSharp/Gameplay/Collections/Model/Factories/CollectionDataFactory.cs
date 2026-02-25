using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model.Factories
{
	// Token: 0x020009E2 RID: 2530
	[Token(Token = "0x20009E2")]
	public class CollectionDataFactory : ICollectionDataFactory, IDisposable
	{
		// Token: 0x06003C73 RID: 15475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x8B3C", Offset = "0x8B3C", VA = "0x8B3C", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x8B3D", Offset = "0x8B3D", VA = "0x8B3D")]
		public CollectionDataFactory(IDictProvider dictProvider)
		{
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x8B3E", Offset = "0x8B3E", VA = "0x8B3E")]
		private void PopulateCollectionRanks()
		{
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x8B3F", Offset = "0x8B3F", VA = "0x8B3F")]
		private void PopulateMedals()
		{
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x1AA2", Offset = "0x1AA2", VA = "0x1AA2", Slot = "4")]
		public CollectionData Create(CollectionsDic collectionsDict)
		{
			return null;
		}

		// Token: 0x0400216F RID: 8559
		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<uint, Dictionary<uint, MedalDic>> _medals;

		// Token: 0x04002170 RID: 8560
		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<uint, Dictionary<uint, CollectionRanksDic>> _ranks;

		// Token: 0x04002171 RID: 8561
		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _nonCollectionAvatarAssetId;

		// Token: 0x04002172 RID: 8562
		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x14")]
		private readonly string _nonCollectionMedalAssetId;

		// Token: 0x04002173 RID: 8563
		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x18")]
		private IDictProvider _dictProvider;
	}
}
