using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Duel;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public class DuelService : AbstractService
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x170000A0")]
		public override short ServiceId
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x596A", Offset = "0x596A", VA = "0x596A", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000065")]
		public event Action<DuelStateInfo> NewDuelEvent
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x596B", Offset = "0x596B", VA = "0x596B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x596C", Offset = "0x596C", VA = "0x596C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000066")]
		public event Action<ProtoDuelPaidOffEvt> PaidOffEvent
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x596D", Offset = "0x596D", VA = "0x596D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x596E", Offset = "0x596E", VA = "0x596E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000067")]
		public event Action<ProtoDuelUserStateChangedEvt> UserStateFlagsChangedEvent
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x596F", Offset = "0x596F", VA = "0x596F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x5970", Offset = "0x5970", VA = "0x5970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x5971", Offset = "0x5971", VA = "0x5971", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x5972", Offset = "0x5972", VA = "0x5972")]
		public OpToken<IMessage, object> GetDuelsInfo(ulong opponentId)
		{
			return null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x5973", Offset = "0x5973", VA = "0x5973")]
		public OpToken<IMessage, object> GetUserInfo(params ulong[] userIds)
		{
			return null;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x5974", Offset = "0x5974", VA = "0x5974")]
		public OpToken<IMessage, object> Attack(ulong opponentId, uint attackType)
		{
			return null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x5975", Offset = "0x5975", VA = "0x5975")]
		public OpToken<IMessage, object> PayOff(ulong opponentId)
		{
			return null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x5976", Offset = "0x5976", VA = "0x5976")]
		public OpToken<IMessage, object> GetDuelStateInfo()
		{
			return null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x5977", Offset = "0x5977", VA = "0x5977")]
		public OpToken<IMessage, object> PerformIntelligence(ulong opponentId, uint intelligenceType)
		{
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x5978", Offset = "0x5978", VA = "0x5978")]
		public OpToken<IMessage, object> UnsubscribeOpponent(ulong opponentId)
		{
			return null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x5979", Offset = "0x5979", VA = "0x5979")]
		public DuelService()
		{
		}
	}
}
