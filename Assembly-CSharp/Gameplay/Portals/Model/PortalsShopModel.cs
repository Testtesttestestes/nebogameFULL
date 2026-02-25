using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D3 RID: 1491
	[Token(Token = "0x20005D3")]
	public class PortalsShopModel : AbstractModel
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C1")]
		public IGame Game
		{
			[Token(Token = "0x60023E5")]
			[Address(RVA = "0x7537", Offset = "0x7537", VA = "0x7537")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C2")]
		public PortalsModel PortalsModel
		{
			[Token(Token = "0x60023E6")]
			[Address(RVA = "0x7538", Offset = "0x7538", VA = "0x7538")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x7539", Offset = "0x7539", VA = "0x7539")]
		public PortalsShopModel(UserData user, IGame game, PortalsModel portalsModel)
		{
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C3")]
		public List<ShopItemData> ShopItems
		{
			[Token(Token = "0x60023E8")]
			[Address(RVA = "0x753A", Offset = "0x753A", VA = "0x753A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x170006C4")]
		public ArtikulTypeFilters.Types.FilterType FilterType
		{
			[Token(Token = "0x60023E9")]
			[Address(RVA = "0x753B", Offset = "0x753B", VA = "0x753B")]
			get
			{
				return ArtikulTypeFilters.Types.FilterType.UnknownFilterType;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006C5")]
		public Dictionary<uint, ArtikulTypeFilters> AllFilters
		{
			[Token(Token = "0x60023EA")]
			[Address(RVA = "0x753C", Offset = "0x753C", VA = "0x753C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C6")]
		public IList<ArtikulTypeFilters> AvailableFilters
		{
			[Token(Token = "0x60023EB")]
			[Address(RVA = "0x753D", Offset = "0x753D", VA = "0x753D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x753E", Offset = "0x753E", VA = "0x753E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x1BDA", Offset = "0x1BDA", VA = "0x1BDA")]
		public void AddShopItem(ArtifactItem item)
		{
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x753F", Offset = "0x753F", VA = "0x753F")]
		private ArtifactData CreateArtifactData(ArtifactDetails artifactDetails)
		{
			return null;
		}

		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ArtikulTypeFilters> _allFilters;
	}
}
