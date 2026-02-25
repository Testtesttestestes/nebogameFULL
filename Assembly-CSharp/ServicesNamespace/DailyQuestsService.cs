using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.DailyQuests;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class DailyQuestsService : AbstractService
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x1700009F")]
		public override short ServiceId
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x5961", Offset = "0x5961", VA = "0x5961", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000064")]
		public event Action<ProtoDailyQuestsChangedEvt> DailyQuestsChangedEvent
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x5962", Offset = "0x5962", VA = "0x5962")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x5963", Offset = "0x5963", VA = "0x5963")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x5964", Offset = "0x5964", VA = "0x5964", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x5965", Offset = "0x5965", VA = "0x5965")]
		public OpToken<IMessage, object> GetQuests(ProtoGetQuestsCmd.Types.Kind kind, IEnumerable<uint> ids)
		{
			return null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x5966", Offset = "0x5966", VA = "0x5966")]
		public OpToken<IMessage, object> GetQuests(ProtoGetQuestsCmd.Types.Kind kind)
		{
			return null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x5967", Offset = "0x5967", VA = "0x5967")]
		public OpToken<IMessage, object> TakeDailyQuestReward(uint questId)
		{
			return null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x5968", Offset = "0x5968", VA = "0x5968")]
		public OpToken<IMessage, object> TakeGoalReward(uint goalId)
		{
			return null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x5969", Offset = "0x5969", VA = "0x5969")]
		public DailyQuestsService()
		{
		}
	}
}
