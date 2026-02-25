using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Events;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public class EventsService : AbstractService
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x170000A1")]
		public override short ServiceId
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x597A", Offset = "0x597A", VA = "0x597A", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x597B", Offset = "0x597B", VA = "0x597B", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x597C", Offset = "0x597C", VA = "0x597C")]
		public OpToken<IMessage, object> GetEventsList()
		{
			return null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x597D", Offset = "0x597D", VA = "0x597D")]
		public OpToken<IMessage, object> DeleteEvents(ulong[] eventsIds)
		{
			return null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x597E", Offset = "0x597E", VA = "0x597E")]
		public OpToken<IMessage, object> GetEventReward(ulong eventId)
		{
			return null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x597F", Offset = "0x597F", VA = "0x597F")]
		public OpToken<IMessage, object> ProcessEvent(ulong eventId, uint[] actions)
		{
			return null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5980", Offset = "0x5980", VA = "0x5980")]
		public OpToken<IMessage, object> ClearArchive()
		{
			return null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x5981", Offset = "0x5981", VA = "0x5981")]
		public OpToken<IMessage, object> ShareReward()
		{
			return null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x5982", Offset = "0x5982", VA = "0x5982")]
		public EventsService()
		{
		}

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x14")]
		public Action<ProtoGetEventsListAns> ThereIsNewEvent;
	}
}
