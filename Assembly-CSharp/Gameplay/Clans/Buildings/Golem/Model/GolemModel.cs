using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Data.Skills;
using Core.Dict;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Discounts.Model;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Model
{
	// Token: 0x02000AD4 RID: 2772
	[Token(Token = "0x2000AD4")]
	public class GolemModel : AbstractModel
	{
		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060042C1 RID: 17089 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060042C2 RID: 17090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2F")]
		public SkillCollection GolemSkills
		{
			[Token(Token = "0x60042C1")]
			[Address(RVA = "0x9175", Offset = "0x9175", VA = "0x9175")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042C2")]
			[Address(RVA = "0x9176", Offset = "0x9176", VA = "0x9176")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x17000D30")]
		public bool HeadUser
		{
			[Token(Token = "0x60042C3")]
			[Address(RVA = "0x9177", Offset = "0x9177", VA = "0x9177")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D31")]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x60042C4")]
			[Address(RVA = "0x9178", Offset = "0x9178", VA = "0x9178")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042C5")]
			[Address(RVA = "0x9179", Offset = "0x9179", VA = "0x9179")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x917A", Offset = "0x917A", VA = "0x917A", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x917B", Offset = "0x917B", VA = "0x917B")]
		public GolemModel(IDictProvider dictProviderProvider, IUserCache userCache, UserData user, ClanWarsModel clanWarsModel, ClanIsle clanIsle)
		{
		}

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x10")]
		public readonly ClanIsle ClanIsle;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x14")]
		public readonly GolemInventoryModel GolemInventoryModel;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x18")]
		public readonly ClanWarsModel ClanWarsModel;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x1C")]
		public readonly UserData GolemUserData;
	}
}
