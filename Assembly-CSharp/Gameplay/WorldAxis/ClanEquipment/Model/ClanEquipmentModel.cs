using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Cache;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Common;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.WorldAxis.ClanEquipment.Model
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	public class ClanEquipmentModel : AbstractModel
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000307")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600134B")]
			[Address(RVA = "0x653C", Offset = "0x653C", VA = "0x653C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000308")]
		public ClanEquipmentModel.DollsOwner[] DollOwners
		{
			[Token(Token = "0x600134C")]
			[Address(RVA = "0x653D", Offset = "0x653D", VA = "0x653D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600134D")]
			[Address(RVA = "0x653E", Offset = "0x653E", VA = "0x653E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x653F", Offset = "0x653F", VA = "0x653F")]
		public ClanEquipmentModel(UserData user, UserData golemUserData, [Optional] ulong? selectedUser)
		{
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000309")]
		public FilterWithIconListElement.FilterWithIconData[] FiltersData
		{
			[Token(Token = "0x600134F")]
			[Address(RVA = "0x6540", Offset = "0x6540", VA = "0x6540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x6541", Offset = "0x6541", VA = "0x6541")]
		public void PopulateUsers(IList<ProtoGetDollArtsAns.Types.DollsOwner> dollsOwners, UserData[] data)
		{
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x6542", Offset = "0x6542", VA = "0x6542")]
		private FilterWithIconListElement.FilterWithIconData[] CreateFilters()
		{
			return null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x6543", Offset = "0x6543", VA = "0x6543")]
		[CompilerGenerated]
		internal static FilterWithIconListElement.FilterWithIconData <CreateFilters>g__ConstructData|17_0(DollsInfoDic dic)
		{
			return null;
		}

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly Dictionary<ulong, DollsInfoDic> DollsInfoDicsById;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ArtifactCache ArtifactCache;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly UserData GolemUserData;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ulong? SelectedUser;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FilterWithIconListElement.FilterWithIconData[] _filtersData;

		// Token: 0x0200034B RID: 843
		[Token(Token = "0x200034B")]
		public class DollsOwner
		{
			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06001353 RID: 4947 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700030A")]
			public ArtifactData[] AllArtifacts
			{
				[Token(Token = "0x6001353")]
				[Address(RVA = "0x6544", Offset = "0x6544", VA = "0x6544")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001354")]
			[Address(RVA = "0x6545", Offset = "0x6545", VA = "0x6545")]
			public DollsOwner(UserData userData)
			{
			}

			// Token: 0x04000A5F RID: 2655
			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly UserData UserData;

			// Token: 0x04000A60 RID: 2656
			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Dictionary<ulong, ClanEquipmentModel.DollArtifacts> DollArtifactsByDollId;
		}

		// Token: 0x0200034D RID: 845
		[Token(Token = "0x200034D")]
		public class DollArtifacts
		{
			// Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001358")]
			[Address(RVA = "0x1DE8", Offset = "0x1DE8", VA = "0x1DE8")]
			public DollArtifacts(ulong dollId, IList<ArtifactInfo> artifacts, Dictionary<ulong, DollsInfoDic> dollsInfoDicsById, ArtifactCache artifactCache, UserData owner)
			{
			}

			// Token: 0x04000A63 RID: 2659
			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly DollsInfoDic Dic;

			// Token: 0x04000A64 RID: 2660
			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ArtifactData[] Artifacts;
		}
	}
}
