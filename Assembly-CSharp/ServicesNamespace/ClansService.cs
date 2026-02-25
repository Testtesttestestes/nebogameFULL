using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Main;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public class ClansService : AbstractService
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x17000099")]
		public override short ServiceId
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x58C6", Offset = "0x58C6", VA = "0x58C6", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000043")]
		public event Action<ProtoStackableChangesAns> GolemSlotsChangedEvent
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x58C7", Offset = "0x58C7", VA = "0x58C7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x58C8", Offset = "0x58C8", VA = "0x58C8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000044")]
		public event Action<ProtoTreasuryChangedEvt> TreasuryChangedEvent
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x58C9", Offset = "0x58C9", VA = "0x58C9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x58CA", Offset = "0x58CA", VA = "0x58CA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000045")]
		public event Action<ProtoUserLeftClanEvt> UserLeftClanEvent
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x58CB", Offset = "0x58CB", VA = "0x58CB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x58CC", Offset = "0x58CC", VA = "0x58CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000046")]
		public event Action<ProtoClanLeaderChangedEvt> ClanLeaderChangedEvent
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x58CD", Offset = "0x58CD", VA = "0x58CD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x58CE", Offset = "0x58CE", VA = "0x58CE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000047")]
		public event Action<ProtoClanRestrictionChangedEvt> ClanRestrictionsChangedEvent
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x58CF", Offset = "0x58CF", VA = "0x58CF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x58D0", Offset = "0x58D0", VA = "0x58D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000048")]
		public event Action<ProtoCreateClanAns> ClanCreatedEvent
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x58D1", Offset = "0x58D1", VA = "0x58D1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x58D2", Offset = "0x58D2", VA = "0x58D2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000049")]
		public event Action<ProtoUnregisterClanAns> ClanUnregisteredEvent
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x58D3", Offset = "0x58D3", VA = "0x58D3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x58D4", Offset = "0x58D4", VA = "0x58D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x58D5", Offset = "0x58D5", VA = "0x58D5", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x58D6", Offset = "0x58D6", VA = "0x58D6")]
		public OpToken<IMessage, object> GetOwnClanInfo()
		{
			return null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x58D7", Offset = "0x58D7", VA = "0x58D7")]
		public OpToken<IMessage, object> GetShortClansInfo(params ulong[] ids)
		{
			return null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x58D8", Offset = "0x58D8", VA = "0x58D8")]
		public OpToken<IMessage, object> GetClanVacanciesList(ProtoGetClanVacanciesListCmd msg)
		{
			return null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x58D9", Offset = "0x58D9", VA = "0x58D9")]
		public OpToken<IMessage, object> PutRequestForJoin(ulong clanId)
		{
			return null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x58DA", Offset = "0x58DA", VA = "0x58DA")]
		public OpToken<IMessage, object> CancelRequestForJoin()
		{
			return null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x58DB", Offset = "0x58DB", VA = "0x58DB")]
		public OpToken<IMessage, object> GetMembersList(ulong clanId)
		{
			return null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x58DC", Offset = "0x58DC", VA = "0x58DC")]
		public OpToken<IMessage, object> ChangeClanInfo(ulong clanId, ProtoCreateClanCmd clanSetting)
		{
			return null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x58DD", Offset = "0x58DD", VA = "0x58DD")]
		public OpToken<IMessage, object> KickMember(ulong clanId, ulong userId)
		{
			return null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x58DE", Offset = "0x58DE", VA = "0x58DE")]
		public OpToken<IMessage, object> AppointHead(ulong clanId, ulong userId)
		{
			return null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x58DF", Offset = "0x58DF", VA = "0x58DF")]
		public OpToken<IMessage, object> BuyAddPlace(ulong clanId)
		{
			return null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x58E0", Offset = "0x58E0", VA = "0x58E0")]
		public OpToken<IMessage, object> SetClanStateFlags(ulong clanId, uint flags)
		{
			return null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x58E1", Offset = "0x58E1", VA = "0x58E1")]
		public OpToken<IMessage, object> GetClanTreasury()
		{
			return null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x58E2", Offset = "0x58E2", VA = "0x58E2")]
		public OpToken<IMessage, object> AddToTreasury(ulong clanId, ResourceSet resourceSet)
		{
			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x58E3", Offset = "0x58E3", VA = "0x58E3")]
		public OpToken<IMessage, object> GetJoinRequestList(ProtoGetJoinRequestListCmd msg)
		{
			return null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x58E4", Offset = "0x58E4", VA = "0x58E4")]
		public OpToken<IMessage, object> ApproveJoinRequest(ulong clanId, ulong userId)
		{
			return null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x58E5", Offset = "0x58E5", VA = "0x58E5")]
		public OpToken<IMessage, object> RefuseJoinRequests(ulong clanId, params ulong[] userIds)
		{
			return null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x58E6", Offset = "0x58E6", VA = "0x58E6")]
		public OpToken<IMessage, object> CreateClan(string name, string description, uint flags)
		{
			return null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x58E7", Offset = "0x58E7", VA = "0x58E7")]
		private void OnCreateClan(SrvCommand cmd, IMessage args)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x58E8", Offset = "0x58E8", VA = "0x58E8")]
		public OpToken<IMessage, object> RepayCreditDebt()
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x58E9", Offset = "0x58E9", VA = "0x58E9")]
		public OpToken<IMessage, object> GetGolemArtifacts(ulong golemId)
		{
			return null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x58EA", Offset = "0x58EA", VA = "0x58EA")]
		public OpToken<IMessage, object> SwapGolemSlots(int slotIdFrom, int slotIdTo)
		{
			return null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x58EB", Offset = "0x58EB", VA = "0x58EB")]
		public OpToken<IMessage, object> PutUserItemToGolem(ulong artId, uint slotIdTo)
		{
			return null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x58EC", Offset = "0x58EC", VA = "0x58EC")]
		public OpToken<IMessage, object> SellGolemItem(int slotId)
		{
			return null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x58ED", Offset = "0x58ED", VA = "0x58ED")]
		public OpToken<IMessage, object> UnregisterClan()
		{
			return null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x58EE", Offset = "0x58EE", VA = "0x58EE")]
		private void OnUnregisterClan(SrvCommand cmd, IMessage args)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x58EF", Offset = "0x58EF", VA = "0x58EF")]
		public OpToken<IMessage, object> LeaveClan(ulong clanId)
		{
			return null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x58F0", Offset = "0x58F0", VA = "0x58F0")]
		public ClansService()
		{
		}
	}
}
