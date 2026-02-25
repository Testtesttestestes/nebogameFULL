using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Colossus;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public class ColossusService : AbstractService
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x1700009B")]
		public override short ServiceId
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x58F6", Offset = "0x58F6", VA = "0x58F6", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060004CC RID: 1228 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004A")]
		public event Action<ProtoSlotsChanged> SlotsChangedEvent
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x58F7", Offset = "0x58F7", VA = "0x58F7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x58F8", Offset = "0x58F8", VA = "0x58F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004B")]
		public event Action<ProtoGetColossusInfoAns> ColossusChangedEvent
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x58F9", Offset = "0x58F9", VA = "0x58F9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x58FA", Offset = "0x58FA", VA = "0x58FA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004C")]
		public event Action<ProtoGetScheduleAns> ScheduleChangedEvent
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x58FB", Offset = "0x58FB", VA = "0x58FB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x58FC", Offset = "0x58FC", VA = "0x58FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004D")]
		public event Action<ProtoGetPartyInfoAns> SlotsResetEvent
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x58FD", Offset = "0x58FD", VA = "0x58FD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x58FE", Offset = "0x58FE", VA = "0x58FE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x58FF", Offset = "0x58FF", VA = "0x58FF", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x5900", Offset = "0x5900", VA = "0x5900")]
		public OpToken<IMessage, object> GetColossusInfo()
		{
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x5901", Offset = "0x5901", VA = "0x5901")]
		public OpToken<IMessage, object> GetPartyInfo()
		{
			return null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x5902", Offset = "0x5902", VA = "0x5902")]
		public OpToken<IMessage, object> GetAvailableDolls()
		{
			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x5903", Offset = "0x5903", VA = "0x5903")]
		public OpToken<IMessage, object> GetSchedule()
		{
			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x5904", Offset = "0x5904", VA = "0x5904")]
		public OpToken<IMessage, object> GetColossusRating(uint colossusId)
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x5905", Offset = "0x5905", VA = "0x5905")]
		public OpToken<IMessage, object> SwapPartySlot(uint partyId, uint slotId, ulong targetId)
		{
			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x5906", Offset = "0x5906", VA = "0x5906")]
		public OpToken<IMessage, object> UserDollSelect(ulong dollId)
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x5907", Offset = "0x5907", VA = "0x5907")]
		public OpToken<IMessage, object> BuyParty()
		{
			return null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x5908", Offset = "0x5908", VA = "0x5908")]
		public OpToken<IMessage, object> BuyPartySlot(uint partyId)
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x5909", Offset = "0x5909", VA = "0x5909")]
		public OpToken<IMessage, object> GetDollSlots(ulong dollId, ulong userId)
		{
			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x590A", Offset = "0x590A", VA = "0x590A")]
		public OpToken<IMessage, object> SwapDollSlots(ulong dollId, uint fromSlotId, uint toSlotId)
		{
			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x590B", Offset = "0x590B", VA = "0x590B")]
		public OpToken<IMessage, object> FromDollToGolem(ulong artifactId, uint toSlotId)
		{
			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x590C", Offset = "0x590C", VA = "0x590C")]
		public OpToken<IMessage, object> FromGolemToDoll(ulong artifactId, ulong dollId, uint toSlotId)
		{
			return null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x590D", Offset = "0x590D", VA = "0x590D")]
		public OpToken<IMessage, object> GetDollSkills(ulong userId, params ulong[] dollIds)
		{
			return null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x590E", Offset = "0x590E", VA = "0x590E")]
		public OpToken<IMessage, object> GetTreasuryOptions(uint colossusId)
		{
			return null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x590F", Offset = "0x590F", VA = "0x590F")]
		public OpToken<IMessage, object> BuyTreasuryItem(uint optionId)
		{
			return null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x5910", Offset = "0x5910", VA = "0x5910")]
		public OpToken<IMessage, object> GetDollSpellsInfo(ulong dollId)
		{
			return null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x5911", Offset = "0x5911", VA = "0x5911")]
		public OpToken<IMessage, object> GetSeasonRating()
		{
			return null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x5912", Offset = "0x5912", VA = "0x5912")]
		public OpToken<IMessage, object> GetHeroesRating()
		{
			return null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x5913", Offset = "0x5913", VA = "0x5913")]
		public OpToken<IMessage, object> TakeOffDollArtifacts(ulong ownerId, params ulong[] dollIds)
		{
			return null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x5914", Offset = "0x5914", VA = "0x5914")]
		public OpToken<IMessage, object> GetDollArtifacts()
		{
			return null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x5915", Offset = "0x5915", VA = "0x5915")]
		public OpToken<IMessage, object> GetColossusBattles(uint pageNumber, uint colossusId, bool clanBattles)
		{
			return null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x5916", Offset = "0x5916", VA = "0x5916")]
		public OpToken<IMessage, object> GetColossusBattleInfo(ulong battleId)
		{
			return null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x5917", Offset = "0x5917", VA = "0x5917")]
		public ColossusService()
		{
		}
	}
}
