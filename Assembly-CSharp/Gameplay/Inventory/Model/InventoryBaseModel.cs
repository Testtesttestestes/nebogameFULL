using System;
using System.Collections.Generic;
using Core.Cache;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Main;
using UI.Toast;

namespace Gameplay.Inventory.Model
{
	// Token: 0x0200069E RID: 1694
	[Token(Token = "0x200069E")]
	public abstract class InventoryBaseModel : AbstractModel
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C2")]
		public Dictionary<ulong, ArtifactData> ArtifactsByArtifactId
		{
			[Token(Token = "0x60028FE")]
			[Address(RVA = "0x7A16", Offset = "0x7A16", VA = "0x7A16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C3")]
		public Dictionary<ulong, ArtifactData> Favorites
		{
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x7A17", Offset = "0x7A17", VA = "0x7A17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C4")]
		public Dictionary<ulong, ArtifactData> Fresh
		{
			[Token(Token = "0x6002900")]
			[Address(RVA = "0x7A18", Offset = "0x7A18", VA = "0x7A18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C5")]
		public Dictionary<uint, List<ArtifactData>> ChestArtifactsByArtikulType
		{
			[Token(Token = "0x6002901")]
			[Address(RVA = "0x7A19", Offset = "0x7A19", VA = "0x7A19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C6")]
		public SortedList<int, ArtifactData> ChestArtifacts
		{
			[Token(Token = "0x6002902")]
			[Address(RVA = "0x7A1A", Offset = "0x7A1A", VA = "0x7A1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C7")]
		public SortedList<int, ArtifactData> BagArtifacts
		{
			[Token(Token = "0x6002903")]
			[Address(RVA = "0x7A1B", Offset = "0x7A1B", VA = "0x7A1B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C8")]
		public Dictionary<int, ArtifactData> Equipment
		{
			[Token(Token = "0x6002904")]
			[Address(RVA = "0x7A1C", Offset = "0x7A1C", VA = "0x7A1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x170007C9")]
		public int BagEmptySlotsNum
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x7A1D", Offset = "0x7A1D", VA = "0x7A1D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007CA")]
		public int[] EquipSlotsIds
		{
			[Token(Token = "0x6002906")]
			[Address(RVA = "0x7A1E", Offset = "0x7A1E", VA = "0x7A1E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x170007CB")]
		public long AvailableSlots
		{
			[Token(Token = "0x6002907")]
			[Address(RVA = "0x7A1F", Offset = "0x7A1F", VA = "0x7A1F")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x170007CC")]
		public long ChestEmptySlotsNum
		{
			[Token(Token = "0x6002908")]
			[Address(RVA = "0x7A20", Offset = "0x7A20", VA = "0x7A20")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x170007CD")]
		public long ChestTotalSlotsNum
		{
			[Token(Token = "0x6002909")]
			[Address(RVA = "0x7A21", Offset = "0x7A21", VA = "0x7A21")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x170007CE")]
		public long TotalEmptySlotsNum
		{
			[Token(Token = "0x600290A")]
			[Address(RVA = "0x7A22", Offset = "0x7A22", VA = "0x7A22")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x170007CF")]
		public long TotalSlotsAvailable
		{
			[Token(Token = "0x600290B")]
			[Address(RVA = "0x7A23", Offset = "0x7A23", VA = "0x7A23")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x7A24", Offset = "0x7A24", VA = "0x7A24")]
		protected InventoryBaseModel(ToastController toasts, ArtifactCache artifactCache, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x7A25", Offset = "0x7A25", VA = "0x7A25")]
		public List<InventoryMetaFilterData> GetAllArtikulTypeFilters()
		{
			return null;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x7A26", Offset = "0x7A26", VA = "0x7A26")]
		protected bool IsArtifactCanBeEquipped(ArtifactData artifact, UserData user)
		{
			return default(bool);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x7A27", Offset = "0x7A27", VA = "0x7A27")]
		public int GetFirstEmptySlot(InvetoryScope scope = InvetoryScope.ALL)
		{
			return 0;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x7A28", Offset = "0x7A28", VA = "0x7A28")]
		private void UpdateFreshCache()
		{
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x7A29", Offset = "0x7A29", VA = "0x7A29")]
		private void UpdateCache()
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x7A2A", Offset = "0x7A2A", VA = "0x7A2A", Slot = "6")]
		protected virtual void HandleBagSlot(int slotId, ArtifactData artifactData)
		{
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x7A2B", Offset = "0x7A2B", VA = "0x7A2B")]
		private void SetArtifact(int slotId, ArtifactInfo artifactInfo)
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x7A2C", Offset = "0x7A2C", VA = "0x7A2C")]
		public void ParseSlotChanges(IList<ProtoGetUserArtifactsAns.Types.UserArtifact> changes)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x7A2D", Offset = "0x7A2D", VA = "0x7A2D")]
		public void ParseSlotChanges(IList<UserArtifact> changes)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x1F8F", Offset = "0x1F8F", VA = "0x1F8F")]
		public ArtifactData GetArtifactById(ulong artifactId)
		{
			return null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x1DAC", Offset = "0x1DAC", VA = "0x1DAC")]
		public ArtifactData GetArtifactBySlotId(int slotId)
		{
			return null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x445A", Offset = "0x445A", VA = "0x445A")]
		public uint GetCount(uint artikulId)
		{
			return 0U;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x7A2E", Offset = "0x7A2E", VA = "0x7A2E")]
		public bool TryGetFitSlotId(ArtifactData artifact, out int slotId)
		{
			return default(bool);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x2173", Offset = "0x2173", VA = "0x2173")]
		public void SetArtifactFavorite(ArtifactData artifactData, bool favorite)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x1F93", Offset = "0x1F93", VA = "0x1F93")]
		public void SetArtifactFresh(ArtifactData artifactData, bool fresh)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x7A2F", Offset = "0x7A2F", VA = "0x7A2F")]
		public long GetMaxChestSlots()
		{
			return 0L;
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600291D RID: 10525
		[Token(Token = "0x170007D0")]
		public abstract UserData OwnerUser { [Token(Token = "0x600291D")] get; }

		// Token: 0x0600291E RID: 10526
		[Token(Token = "0x600291E")]
		public abstract bool CanFitTwoHandedWeapon(out int occupiedSlots);

		// Token: 0x0600291F RID: 10527
		[Token(Token = "0x600291F")]
		protected abstract long GetExtraSlotsCount();

		// Token: 0x06002920 RID: 10528
		[Token(Token = "0x6002920")]
		protected abstract bool IsEquipmentSlot(int slotId);

		// Token: 0x06002921 RID: 10529
		[Token(Token = "0x6002921")]
		public abstract ResourceSet GetSlotPrice(uint slotCount);

		// Token: 0x06002922 RID: 10530
		[Token(Token = "0x6002922")]
		public abstract IList<ArtifactData> GetComparableItems();

		// Token: 0x06002923 RID: 10531
		[Token(Token = "0x6002923")]
		public abstract bool IsArtifactCanBeEquipped(ArtifactData artifact);

		// Token: 0x040016B0 RID: 5808
		[Token(Token = "0x40016B0")]
		[FieldOffset(Offset = "0xC")]
		protected readonly SortedList<int, ArtifactData> _artifactsBySlotId;

		// Token: 0x040016B1 RID: 5809
		[Token(Token = "0x40016B1")]
		[FieldOffset(Offset = "0x10")]
		protected SortedList<int, ArtifactData> _bagArtifacts;

		// Token: 0x040016B2 RID: 5810
		[Token(Token = "0x40016B2")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<uint, uint> _artikulCount;

		// Token: 0x040016B3 RID: 5811
		[Token(Token = "0x40016B3")]
		[FieldOffset(Offset = "0x18")]
		private readonly SortedList<int, ArtifactData> _chestArtifacts;

		// Token: 0x040016B4 RID: 5812
		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<ulong, ArtifactData> _favorites;

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<ulong, ArtifactData> _fresh;

		// Token: 0x040016B6 RID: 5814
		[Token(Token = "0x40016B6")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, List<ArtifactData>> _chestArtifactsByArtikulType;

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<ulong, ArtifactData> _artifactsByArtifactId;

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x2C")]
		private readonly Dictionary<int, ArtifactData> _equipmentCache;

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<int> _bagEmptySlots;

		// Token: 0x040016BA RID: 5818
		[Token(Token = "0x40016BA")]
		[FieldOffset(Offset = "0x34")]
		private readonly List<int> _chestEmptySlots;

		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x40016BB")]
		[FieldOffset(Offset = "0x38")]
		private List<InventoryMetaFilterData> _artikulTypeFiltersCache;

		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x40016BC")]
		[FieldOffset(Offset = "0x3C")]
		private int _chestTotalSlotsNum;

		// Token: 0x040016BD RID: 5821
		[Token(Token = "0x40016BD")]
		[FieldOffset(Offset = "0x40")]
		private int _bagTotalSlotsNum;

		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x44")]
		private int _equipTotalSlotsNum;

		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x48")]
		public readonly ArtifactCache ArtifactCache;

		// Token: 0x040016C0 RID: 5824
		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x4C")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040016C1 RID: 5825
		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x50")]
		public readonly IRequirementValidator RequirementValidator;

		// Token: 0x040016C2 RID: 5826
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x54")]
		public readonly ToastController Toasts;
	}
}
