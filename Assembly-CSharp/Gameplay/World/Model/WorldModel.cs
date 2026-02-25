using System;
using System.Runtime.CompilerServices;
using System.Text;
using Core.Data;
using Core.Data.User;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Isles.Axis;
using Gameplay.Isles.Base;
using Gameplay.Isles.Clan;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Consts;
using Utils.Timers;

namespace Gameplay.World.Model
{
	// Token: 0x0200036C RID: 876
	[Token(Token = "0x200036C")]
	public class WorldModel : AbstractModel
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		[CanBeNull]
		public IsleAnimationRequestVo LastSuccessIsleAnimationRequest
		{
			[Token(Token = "0x600144A")]
			[Address(RVA = "0x6618", Offset = "0x6618", VA = "0x6618")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600144B")]
			[Address(RVA = "0x6619", Offset = "0x6619", VA = "0x6619")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x661A", Offset = "0x661A", VA = "0x661A")]
		public WorldModel(IGame game, IDictProvider dictProvider, IUserSettings userSettings, UserData user)
		{
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x17000351")]
		public bool IsAtHome
		{
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x661B", Offset = "0x661B", VA = "0x661B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00004F98 File Offset: 0x00003198
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000352")]
		public LocationTypes CurrentLocationType
		{
			[Token(Token = "0x600144E")]
			[Address(RVA = "0x661C", Offset = "0x661C", VA = "0x661C")]
			[CompilerGenerated]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
			[Token(Token = "0x600144F")]
			[Address(RVA = "0x661D", Offset = "0x661D", VA = "0x661D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x661E", Offset = "0x661E", VA = "0x661E")]
		public ulong GetCurrentLocationId()
		{
			return 0UL;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		public UserIsle OwnUserIsle
		{
			[Token(Token = "0x6001451")]
			[Address(RVA = "0x661F", Offset = "0x661F", VA = "0x661F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x6620", Offset = "0x6620", VA = "0x6620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000354")]
		[CanBeNull]
		public UserIsle CurrentUserIsle
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x6621", Offset = "0x6621", VA = "0x6621")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x6622", Offset = "0x6622", VA = "0x6622")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000355")]
		[CanBeNull]
		public ClanIsle CurrentClanIsle
		{
			[Token(Token = "0x6001455")]
			[Address(RVA = "0x6623", Offset = "0x6623", VA = "0x6623")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001456")]
			[Address(RVA = "0x6624", Offset = "0x6624", VA = "0x6624")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		[CanBeNull]
		public AxisIsle CurrentAxisIsle
		{
			[Token(Token = "0x6001457")]
			[Address(RVA = "0x6625", Offset = "0x6625", VA = "0x6625")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001458")]
			[Address(RVA = "0x6626", Offset = "0x6626", VA = "0x6626")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public IsleHeap<UserIsle> UserIsleHeap
		{
			[Token(Token = "0x6001459")]
			[Address(RVA = "0x6627", Offset = "0x6627", VA = "0x6627")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600145A")]
			[Address(RVA = "0x6628", Offset = "0x6628", VA = "0x6628")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000358")]
		public IsleHeap<ClanIsle> ClanIsleHeap
		{
			[Token(Token = "0x600145B")]
			[Address(RVA = "0x6629", Offset = "0x6629", VA = "0x6629")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600145C")]
			[Address(RVA = "0x662A", Offset = "0x662A", VA = "0x662A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x17000359")]
		public int CacheTtl
		{
			[Token(Token = "0x600145D")]
			[Address(RVA = "0x1CA0", Offset = "0x1CA0", VA = "0x1CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x1700035A")]
		public double BuildingCancelRecoilCoeff
		{
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x662B", Offset = "0x662B", VA = "0x662B")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035B")]
		public TimerTracker AnimationsCooldown
		{
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x662C", Offset = "0x662C", VA = "0x662C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x662D", Offset = "0x662D", VA = "0x662D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035C")]
		public bool IsMovingOnWorldLevel
		{
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x662E", Offset = "0x662E", VA = "0x662E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001462")]
			[Address(RVA = "0x662F", Offset = "0x662F", VA = "0x662F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x6630", Offset = "0x6630", VA = "0x6630")]
		[CanBeNull]
		public UserIsle GetUserIsle(ulong userId)
		{
			return null;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x6631", Offset = "0x6631", VA = "0x6631")]
		[CanBeNull]
		public ClanIsle GetClanIsle(ulong clanId)
		{
			return null;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x6632", Offset = "0x6632", VA = "0x6632")]
		[CanBeNull]
		public IIsle GetIsleByTypeAndId(LocationTypes type, ulong id)
		{
			return null;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x6633", Offset = "0x6633", VA = "0x6633")]
		[CanBeNull]
		public IIsle GetCurrentIsle()
		{
			return null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x6634", Offset = "0x6634", VA = "0x6634")]
		public long GetLeftOverCountOfIsleAnimationWhitOutCoolDown()
		{
			return 0L;
		}

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x14")]
		public readonly IUserSettings UserSettings;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0x38")]
		private int _cacheTtl;

		// Token: 0x0200036D RID: 877
		[Token(Token = "0x200036D")]
		[NullableContext(1)]
		[Nullable(0)]
		public class WorldUserIsleRequestVo : IEquatable<WorldModel.WorldUserIsleRequestVo>
		{
			// Token: 0x06001468 RID: 5224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001468")]
			[Address(RVA = "0x6635", Offset = "0x6635", VA = "0x6635")]
			public WorldUserIsleRequestVo(ulong UserId, bool GoOnSuccess)
			{
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06001469 RID: 5225 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700035D")]
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[Token(Token = "0x6001469")]
				[Address(RVA = "0x6636", Offset = "0x6636", VA = "0x6636", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x0600146A RID: 5226 RVA: 0x00005028 File Offset: 0x00003228
			// (set) Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700035E")]
			public ulong UserId
			{
				[Token(Token = "0x600146A")]
				[Address(RVA = "0x6637", Offset = "0x6637", VA = "0x6637")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x600146B")]
				[Address(RVA = "0x6638", Offset = "0x6638", VA = "0x6638")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x0600146C RID: 5228 RVA: 0x00005040 File Offset: 0x00003240
			// (set) Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700035F")]
			public bool GoOnSuccess
			{
				[Token(Token = "0x600146C")]
				[Address(RVA = "0x6639", Offset = "0x6639", VA = "0x6639")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600146D")]
				[Address(RVA = "0x663A", Offset = "0x663A", VA = "0x663A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600146E RID: 5230 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x663B", Offset = "0x663B", VA = "0x663B", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600146F RID: 5231 RVA: 0x00005058 File Offset: 0x00003258
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x663C", Offset = "0x663C", VA = "0x663C", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return default(bool);
			}

			// Token: 0x06001470 RID: 5232 RVA: 0x00005070 File Offset: 0x00003270
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x663D", Offset = "0x663D", VA = "0x663D")]
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator !=(WorldModel.WorldUserIsleRequestVo left, WorldModel.WorldUserIsleRequestVo right)
			{
				return default(bool);
			}

			// Token: 0x06001471 RID: 5233 RVA: 0x00005088 File Offset: 0x00003288
			[Token(Token = "0x6001471")]
			[Address(RVA = "0x663E", Offset = "0x663E", VA = "0x663E")]
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator ==(WorldModel.WorldUserIsleRequestVo left, WorldModel.WorldUserIsleRequestVo right)
			{
				return default(bool);
			}

			// Token: 0x06001472 RID: 5234 RVA: 0x000050A0 File Offset: 0x000032A0
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x663F", Offset = "0x663F", VA = "0x663F", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06001473 RID: 5235 RVA: 0x000050B8 File Offset: 0x000032B8
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x6640", Offset = "0x6640", VA = "0x6640", Slot = "0")]
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06001474 RID: 5236 RVA: 0x000050D0 File Offset: 0x000032D0
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x6641", Offset = "0x6641", VA = "0x6641", Slot = "7")]
			[NullableContext(2)]
			[CompilerGenerated]
			public virtual bool Equals(WorldModel.WorldUserIsleRequestVo other)
			{
				return default(bool);
			}

			// Token: 0x06001476 RID: 5238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001476")]
			[Address(RVA = "0x6643", Offset = "0x6643", VA = "0x6643")]
			[CompilerGenerated]
			protected WorldUserIsleRequestVo(WorldModel.WorldUserIsleRequestVo original)
			{
			}

			// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x6644", Offset = "0x6644", VA = "0x6644")]
			[CompilerGenerated]
			public void Deconstruct(out ulong UserId, out bool GoOnSuccess)
			{
			}
		}
	}
}
