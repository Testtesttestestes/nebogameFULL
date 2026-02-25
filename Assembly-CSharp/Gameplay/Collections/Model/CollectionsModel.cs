using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay;
using Gameplay.Collections.Model.Factories;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Collections;
using Protocol.Common;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D7 RID: 2519
	[Token(Token = "0x20009D7")]
	public class CollectionsModel : AbstractModel
	{
		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDF")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6003C3F")]
			[Address(RVA = "0x8B0D", Offset = "0x8B0D", VA = "0x8B0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C40")]
			[Address(RVA = "0x8B0E", Offset = "0x8B0E", VA = "0x8B0E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE0")]
		public IGame Game
		{
			[Token(Token = "0x6003C41")]
			[Address(RVA = "0x8B0F", Offset = "0x8B0F", VA = "0x8B0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C42")]
			[Address(RVA = "0x8B10", Offset = "0x8B10", VA = "0x8B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BE1")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003C43")]
			[Address(RVA = "0x8B11", Offset = "0x8B11", VA = "0x8B11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C45 RID: 15429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE2")]
		[NotNull]
		public ICollectionDataFactory CollectionDataFactory
		{
			[Token(Token = "0x6003C44")]
			[Address(RVA = "0x8B12", Offset = "0x8B12", VA = "0x8B12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C45")]
			[Address(RVA = "0x8B13", Offset = "0x8B13", VA = "0x8B13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C46")]
		[Address(RVA = "0x8B14", Offset = "0x8B14", VA = "0x8B14", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x8B15", Offset = "0x8B15", VA = "0x8B15")]
		public CollectionsModel(ICollectionDataFactory collectionDataFactory, UserData user, UserData loggedUser, IGame game)
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x8B16", Offset = "0x8B16", VA = "0x8B16")]
		public TabBarItemData[] GetTabBarData()
		{
			return null;
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x8B17", Offset = "0x8B17", VA = "0x8B17")]
		public List<CollectionListElement.CollectionListElementArgs> GetAllCollections()
		{
			return null;
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x8B18", Offset = "0x8B18", VA = "0x8B18")]
		public void PopulateModel(IList<ProtoGetUserCollectionsAns.Types.UserCollection> collections)
		{
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x8B19", Offset = "0x8B19", VA = "0x8B19")]
		public void ClearCallbacks()
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x8B1A", Offset = "0x8B1A", VA = "0x8B1A")]
		private void PopulateCollections()
		{
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x1C5A", Offset = "0x1C5A", VA = "0x1C5A")]
		private void AddAcquiredCollection(uint categoryId, uint collectionId)
		{
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x8B1B", Offset = "0x8B1B", VA = "0x8B1B")]
		public void SetNextUserCollection(CollectionData data)
		{
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0x8B1C", Offset = "0x8B1C", VA = "0x8B1C")]
		public uint DetermineCollectionRank(CollectionsDic dic)
		{
			return 0U;
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x8B1D", Offset = "0x8B1D", VA = "0x8B1D")]
		public int GetAcquiredCollectionsWhitMaxLevelCount(IList<CollectionListElement.CollectionListElementArgs> collectionsList, uint categoryId)
		{
			return 0;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C51")]
		[Address(RVA = "0x8B1E", Offset = "0x8B1E", VA = "0x8B1E")]
		private void SortCollections()
		{
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C52")]
		[Address(RVA = "0x8B1F", Offset = "0x8B1F", VA = "0x8B1F")]
		public List<CollectionsModel.CollectionMaterial> GetMaterials(uint requirementId)
		{
			return null;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x8B20", Offset = "0x8B20", VA = "0x8B20")]
		public float GetProgress(uint requirementId)
		{
			return 0f;
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x8B21", Offset = "0x8B21", VA = "0x8B21")]
		public void RecalculateCollectionProgress(CollectionData data)
		{
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x1C5B", Offset = "0x1C5B", VA = "0x1C5B")]
		public CollectionListElement.CollectionListElementArgs ConstructArgs(CollectionsDic dic)
		{
			return null;
		}

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0x14")]
		public readonly UserData LoggedUser;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool SameUser;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0x1C")]
		public readonly Dictionary<uint, List<CollectionListElement.CollectionListElementArgs>> CollectionsByCategoryId;

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x20")]
		public readonly Dictionary<uint, CollectionData> CollectionsById;

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, uint> _acquiredCollectionsRanksById;

		// Token: 0x04002153 RID: 8531
		[Token(Token = "0x4002153")]
		[FieldOffset(Offset = "0x28")]
		private List<CollectionListElement.CollectionListElementArgs> _allElements;

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[FieldOffset(Offset = "0x2C")]
		private readonly Dictionary<uint, HashSet<uint>> _acquiredCollectionIdsByCategoryId;

		// Token: 0x04002155 RID: 8533
		[Token(Token = "0x4002155")]
		[FieldOffset(Offset = "0x30")]
		public readonly HashSet<uint> MarketArtikuls;

		// Token: 0x020009D8 RID: 2520
		[Token(Token = "0x20009D8")]
		public enum CollectionMaterialType
		{
			// Token: 0x04002158 RID: 8536
			[Token(Token = "0x4002158")]
			UNKNOWN_MATERIAL,
			// Token: 0x04002159 RID: 8537
			[Token(Token = "0x4002159")]
			ARTIKUL,
			// Token: 0x0400215A RID: 8538
			[Token(Token = "0x400215A")]
			MEDAL,
			// Token: 0x0400215B RID: 8539
			[Token(Token = "0x400215B")]
			APR
		}

		// Token: 0x020009D9 RID: 2521
		[Token(Token = "0x20009D9")]
		public abstract class CollectionMaterial
		{
			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x06003C57 RID: 15447
			[Token(Token = "0x17000BE3")]
			public abstract CollectionsModel.CollectionMaterialType RewardType { [Token(Token = "0x6003C57")] get; }

			// Token: 0x06003C58 RID: 15448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C58")]
			[Address(RVA = "0x8B23", Offset = "0x8B23", VA = "0x8B23")]
			protected CollectionMaterial()
			{
			}
		}

		// Token: 0x020009DA RID: 2522
		[Token(Token = "0x20009DA")]
		public class ArtikulMaterial : CollectionsModel.CollectionMaterial
		{
			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
			[Token(Token = "0x17000BE4")]
			public override CollectionsModel.CollectionMaterialType RewardType
			{
				[Token(Token = "0x6003C59")]
				[Address(RVA = "0x8B24", Offset = "0x8B24", VA = "0x8B24", Slot = "4")]
				get
				{
					return CollectionsModel.CollectionMaterialType.UNKNOWN_MATERIAL;
				}
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x06003C5A RID: 15450 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000BE5")]
			public string Text
			{
				[Token(Token = "0x6003C5A")]
				[Address(RVA = "0x8B25", Offset = "0x8B25", VA = "0x8B25")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x06003C5B RID: 15451 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000BE6")]
			public string TextAvailable
			{
				[Token(Token = "0x6003C5B")]
				[Address(RVA = "0x8B26", Offset = "0x8B26", VA = "0x8B26")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x06003C5C RID: 15452 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000BE7")]
			public string TextRequired
			{
				[Token(Token = "0x6003C5C")]
				[Address(RVA = "0x8B27", Offset = "0x8B27", VA = "0x8B27")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
			[Token(Token = "0x17000BE8")]
			public bool? IsValid
			{
				[Token(Token = "0x6003C5D")]
				[Address(RVA = "0x8B28", Offset = "0x8B28", VA = "0x8B28")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003C5E RID: 15454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x8B29", Offset = "0x8B29", VA = "0x8B29")]
			public ArtikulMaterial()
			{
			}

			// Token: 0x0400215C RID: 8540
			[Token(Token = "0x400215C")]
			[FieldOffset(Offset = "0x8")]
			public uint Have;

			// Token: 0x0400215D RID: 8541
			[Token(Token = "0x400215D")]
			[FieldOffset(Offset = "0xC")]
			public uint Required;

			// Token: 0x0400215E RID: 8542
			[Token(Token = "0x400215E")]
			[FieldOffset(Offset = "0x10")]
			public ArtikulData Artikul;

			// Token: 0x0400215F RID: 8543
			[Token(Token = "0x400215F")]
			[FieldOffset(Offset = "0x14")]
			public bool IsOnMarket;
		}

		// Token: 0x020009DB RID: 2523
		[Token(Token = "0x20009DB")]
		public class MedalMaterial : CollectionsModel.CollectionMaterial
		{
			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
			[Token(Token = "0x17000BE9")]
			public override CollectionsModel.CollectionMaterialType RewardType
			{
				[Token(Token = "0x6003C5F")]
				[Address(RVA = "0x8B2A", Offset = "0x8B2A", VA = "0x8B2A", Slot = "4")]
				get
				{
					return CollectionsModel.CollectionMaterialType.UNKNOWN_MATERIAL;
				}
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x06003C60 RID: 15456 RVA: 0x0000C210 File Offset: 0x0000A410
			[Token(Token = "0x17000BEA")]
			public bool BuyableMedal
			{
				[Token(Token = "0x6003C60")]
				[Address(RVA = "0x8B2B", Offset = "0x8B2B", VA = "0x8B2B")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003C61 RID: 15457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x8B2C", Offset = "0x8B2C", VA = "0x8B2C")]
			public MedalMaterial()
			{
			}

			// Token: 0x04002160 RID: 8544
			[Token(Token = "0x4002160")]
			[FieldOffset(Offset = "0x8")]
			public MedalData MedalData;

			// Token: 0x04002161 RID: 8545
			[Token(Token = "0x4002161")]
			[FieldOffset(Offset = "0xC")]
			public MedalDicWrapper Medal;
		}

		// Token: 0x020009DC RID: 2524
		[Token(Token = "0x20009DC")]
		public class AprMaterial : CollectionsModel.CollectionMaterial
		{
			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x06003C62 RID: 15458 RVA: 0x0000C228 File Offset: 0x0000A428
			[Token(Token = "0x17000BEB")]
			public override CollectionsModel.CollectionMaterialType RewardType
			{
				[Token(Token = "0x6003C62")]
				[Address(RVA = "0x8B2D", Offset = "0x8B2D", VA = "0x8B2D", Slot = "4")]
				get
				{
					return CollectionsModel.CollectionMaterialType.UNKNOWN_MATERIAL;
				}
			}

			// Token: 0x06003C63 RID: 15459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x8B2E", Offset = "0x8B2E", VA = "0x8B2E")]
			public AprMaterial()
			{
			}

			// Token: 0x04002162 RID: 8546
			[Token(Token = "0x4002162")]
			[FieldOffset(Offset = "0x8")]
			public AprDicWrapper Apr;

			// Token: 0x04002163 RID: 8547
			[Token(Token = "0x4002163")]
			[FieldOffset(Offset = "0xC")]
			public CollectionRanksInfoDic CollectionRankInfoDic;

			// Token: 0x04002164 RID: 8548
			[Token(Token = "0x4002164")]
			[FieldOffset(Offset = "0x10")]
			public ResourceSet Price;

			// Token: 0x04002165 RID: 8549
			[Token(Token = "0x4002165")]
			[FieldOffset(Offset = "0x14")]
			public bool Achieved;
		}
	}
}
