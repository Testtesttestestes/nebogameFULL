using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Accounts.Model.Data;
using Gameplay.Isles.Base.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.World;

namespace Gameplay.Isles.User.Model
{
	// Token: 0x02000D2C RID: 3372
	[Token(Token = "0x2000D2C")]
	public class UserIsleModel : BaseIsleModel, IMonsterSource
	{
		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x0000EF58 File Offset: 0x0000D158
		// (set) Token: 0x0600526D RID: 21101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C7")]
		public int RequestFlags
		{
			[Token(Token = "0x600526C")]
			[Address(RVA = "0xA043", Offset = "0xA043", VA = "0xA043")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600526D")]
			[Address(RVA = "0xA044", Offset = "0xA044", VA = "0xA044")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600526E RID: 21102 RVA: 0x0000EF70 File Offset: 0x0000D170
		[Token(Token = "0x170010C8")]
		public ulong OwnerId
		{
			[Token(Token = "0x600526E")]
			[Address(RVA = "0xA045", Offset = "0xA045", VA = "0xA045", Slot = "6")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x0000EF88 File Offset: 0x0000D188
		// (set) Token: 0x06005270 RID: 21104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C9")]
		public bool IsLicenceSpent
		{
			[Token(Token = "0x600526F")]
			[Address(RVA = "0xA046", Offset = "0xA046", VA = "0xA046")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005270")]
			[Address(RVA = "0xA047", Offset = "0xA047", VA = "0xA047")]
			set
			{
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		// (set) Token: 0x06005272 RID: 21106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CA")]
		public bool IsDiamondIsle
		{
			[Token(Token = "0x6005271")]
			[Address(RVA = "0xA048", Offset = "0xA048", VA = "0xA048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005272")]
			[Address(RVA = "0xA049", Offset = "0xA049", VA = "0xA049")]
			set
			{
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x170010CB")]
		public Resources IsleBonusResourceType
		{
			[Token(Token = "0x6005273")]
			[Address(RVA = "0xA04A", Offset = "0xA04A", VA = "0xA04A")]
			get
			{
				return Resources.UnknownResource;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005275 RID: 21109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CC")]
		public ProtoGetUserIsleInfoAns.Types.IsleInformation IsleInformation
		{
			[Token(Token = "0x6005274")]
			[Address(RVA = "0xA04B", Offset = "0xA04B", VA = "0xA04B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005275")]
			[Address(RVA = "0xA04C", Offset = "0xA04C", VA = "0xA04C")]
			set
			{
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005277 RID: 21111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CD")]
		public IsleInfoDic IsleInfoDic
		{
			[Token(Token = "0x6005276")]
			[Address(RVA = "0xA04D", Offset = "0xA04D", VA = "0xA04D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005277")]
			[Address(RVA = "0xA04E", Offset = "0xA04E", VA = "0xA04E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005279 RID: 21113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CE")]
		public ClanData BackClanData
		{
			[Token(Token = "0x6005278")]
			[Address(RVA = "0xA04F", Offset = "0xA04F", VA = "0xA04F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005279")]
			[Address(RVA = "0xA050", Offset = "0xA050", VA = "0xA050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600527B RID: 21115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CF")]
		public MonsterData Monster
		{
			[Token(Token = "0x600527A")]
			[Address(RVA = "0xA051", Offset = "0xA051", VA = "0xA051", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600527B")]
			[Address(RVA = "0xA052", Offset = "0xA052", VA = "0xA052")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		// (set) Token: 0x0600527D RID: 21117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D0")]
		public bool IsHorde
		{
			[Token(Token = "0x600527C")]
			[Address(RVA = "0xA053", Offset = "0xA053", VA = "0xA053")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600527D")]
			[Address(RVA = "0xA054", Offset = "0xA054", VA = "0xA054")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600527F RID: 21119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D1")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600527E")]
			[Address(RVA = "0xA055", Offset = "0xA055", VA = "0xA055")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600527F")]
			[Address(RVA = "0xA056", Offset = "0xA056", VA = "0xA056")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005281 RID: 21121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D2")]
		public List<UserIsleAccountMarkerData> CurrentAccountMarkers
		{
			[Token(Token = "0x6005280")]
			[Address(RVA = "0xA057", Offset = "0xA057", VA = "0xA057")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005281")]
			[Address(RVA = "0xA058", Offset = "0xA058", VA = "0xA058")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005282")]
		[Address(RVA = "0xA059", Offset = "0xA059", VA = "0xA059", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005283")]
		[Address(RVA = "0xA05A", Offset = "0xA05A", VA = "0xA05A")]
		public UserIsleModel(UserData user, UserData loggedUser, IAccountDataDecorator[] availAccountMarkers, IDictProvider dictionaries, IGame game)
		{
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005284")]
		[Address(RVA = "0x1C9C", Offset = "0x1C9C", VA = "0x1C9C")]
		public void SetMonster(MonsterInfo monsterInfo)
		{
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x170010D3")]
		public double BuildingCancelRecoilCoeff
		{
			[Token(Token = "0x6005285")]
			[Address(RVA = "0xA05B", Offset = "0xA05B", VA = "0xA05B")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x34")]
		private ProtoGetUserIsleInfoAns.Types.IsleInformation _isleInformation;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x4C")]
		public readonly IAccountDataDecorator[] AvailAccountMarkers;
	}
}
