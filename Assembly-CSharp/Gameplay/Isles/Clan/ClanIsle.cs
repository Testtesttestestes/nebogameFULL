using System;
using Core.Data;
using Gameplay.Isles.Base;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;

namespace Gameplay.Isles.Clan
{
	// Token: 0x02000CEF RID: 3311
	[Token(Token = "0x2000CEF")]
	public class ClanIsle : AbstractIsle<Gameplay.Isles.Clan.Events.ClanIsleEvents, ClanIsleModel, ClanIsleController, ClanBuildingTypes>
	{
		// Token: 0x06005094 RID: 20628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005094")]
		[Address(RVA = "0x9EA3", Offset = "0x9EA3", VA = "0x9EA3")]
		public ClanIsle(ClanData clanData, UserData loggedUser, ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInformation)
		{
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x9EA4", Offset = "0x9EA4", VA = "0x9EA4")]
		public ClanIsle(ClanData clanData, UserData loggedUser)
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005096")]
		[Address(RVA = "0x9EA5", Offset = "0x9EA5", VA = "0x9EA5")]
		protected void CreateMvc()
		{
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x1700104A")]
		public override LocationTypes LocationType
		{
			[Token(Token = "0x6005097")]
			[Address(RVA = "0x9EA6", Offset = "0x9EA6", VA = "0x9EA6", Slot = "10")]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x9EA7", Offset = "0x9EA7", VA = "0x9EA7", Slot = "11")]
		public override bool TryOpenBuildingByType(uint type)
		{
			return default(bool);
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x9EA8", Offset = "0x9EA8", VA = "0x9EA8", Slot = "12")]
		public override void Dispose()
		{
		}

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		[FieldOffset(Offset = "0x24")]
		private readonly ClanData _clanData;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x28")]
		private readonly UserData _loggedUser;
	}
}
