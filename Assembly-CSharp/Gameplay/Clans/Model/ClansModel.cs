using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanIsle;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Clans.Model
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	public class ClansModel : AbstractModel
	{
		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CBB")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600408F")]
			[Address(RVA = "0x8F46", Offset = "0x8F46", VA = "0x8F46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBC")]
		public ulong OwnClanId
		{
			[Token(Token = "0x6004090")]
			[Address(RVA = "0x8F47", Offset = "0x8F47", VA = "0x8F47")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004091")]
			[Address(RVA = "0x8F48", Offset = "0x8F48", VA = "0x8F48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004093 RID: 16531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBD")]
		public TreasuryData Treasury
		{
			[Token(Token = "0x6004092")]
			[Address(RVA = "0x8F49", Offset = "0x8F49", VA = "0x8F49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004093")]
			[Address(RVA = "0x8F4A", Offset = "0x8F4A", VA = "0x8F4A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004095 RID: 16533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBE")]
		public ProtoGetIsleInfoAns.Types.ClanIsleInformation ClanIsleInfo
		{
			[Token(Token = "0x6004094")]
			[Address(RVA = "0x8F4B", Offset = "0x8F4B", VA = "0x8F4B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004095")]
			[Address(RVA = "0x8F4C", Offset = "0x8F4C", VA = "0x8F4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004097 RID: 16535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBF")]
		public UserData GolemUserData
		{
			[Token(Token = "0x6004096")]
			[Address(RVA = "0x8F4D", Offset = "0x8F4D", VA = "0x8F4D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004097")]
			[Address(RVA = "0x8F4E", Offset = "0x8F4E", VA = "0x8F4E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x17000CC0")]
		public bool IsHead
		{
			[Token(Token = "0x6004098")]
			[Address(RVA = "0x8F4F", Offset = "0x8F4F", VA = "0x8F4F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004099")]
		[Address(RVA = "0x8F50", Offset = "0x8F50", VA = "0x8F50")]
		public ClansModel(UserData user)
		{
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409A")]
		[Address(RVA = "0x8F51", Offset = "0x8F51", VA = "0x8F51")]
		public void SetClanId(ulong clanId)
		{
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x8F52", Offset = "0x8F52", VA = "0x8F52")]
		public void DissociateClanFromUser()
		{
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x8F53", Offset = "0x8F53", VA = "0x8F53")]
		public void SetOwnClanIsleInfo(ProtoGetIsleInfoAns.Types.ClanIsleInformation info)
		{
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x8F54", Offset = "0x8F54", VA = "0x8F54")]
		public void UpdateOwnClanIsleInfo(ProtoGetIsleInfoAns.Types.ClanIsleInformation info)
		{
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x8F55", Offset = "0x8F55", VA = "0x8F55")]
		public void CreateTreasury(ProtoGetClanTreasuryAns msg)
		{
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x8F56", Offset = "0x8F56", VA = "0x8F56")]
		public bool TryGetOwnClanIsleInfo(out ProtoGetIsleInfoAns.Types.ClanIsleInformation info)
		{
			return default(bool);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x8F57", Offset = "0x8F57", VA = "0x8F57")]
		public bool TryGetBuilding(ClanBuildingTypes buildingType, out BuildingInfo buildingInfo)
		{
			return default(bool);
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x8F58", Offset = "0x8F58", VA = "0x8F58")]
		public List<RestrictionInfo> GetClanCreationRestrictions()
		{
			return null;
		}

		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0xC")]
		private readonly DictManager _dictManager;
	}
}
