using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D3 RID: 2515
	[Token(Token = "0x20009D3")]
	public class CollectionsMaterialsStorage : ICollectionsMaterialsStorage, IDisposable
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x8B01", Offset = "0x8B01", VA = "0x8B01")]
		public void Init(IGame game, IDictionary<uint, CollectionData> collectionsById)
		{
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x8B02", Offset = "0x8B02", VA = "0x8B02", Slot = "4")]
		public bool TryGetArtikulCollections(uint artikulId, out List<CollectionWithRank> collectionsWithRank)
		{
			return default(bool);
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x8B03", Offset = "0x8B03", VA = "0x8B03", Slot = "5")]
		public bool TryGetMedalCollections(uint medalId, out List<CollectionWithRank> collectionsWithRank)
		{
			return default(bool);
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x8B04", Offset = "0x8B04", VA = "0x8B04")]
		private bool TryGetMaterialCollectionsInternal(uint materialId, Dictionary<uint, Dictionary<CollectionData, List<uint>>> dict, out List<CollectionWithRank> collectionsWithRank)
		{
			return default(bool);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x1C4D", Offset = "0x1C4D", VA = "0x1C4D")]
		private void FillMaterials(CollectionRanksDic rankDic, IGame game, CollectionData collection)
		{
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x8B05", Offset = "0x8B05", VA = "0x8B05", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x8B06", Offset = "0x8B06", VA = "0x8B06")]
		public CollectionsMaterialsStorage()
		{
		}

		// Token: 0x04002145 RID: 8517
		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<uint, Dictionary<CollectionData, List<uint>>> _artikulMaterials;

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, Dictionary<CollectionData, List<uint>>> _medalMaterials;
	}
}
