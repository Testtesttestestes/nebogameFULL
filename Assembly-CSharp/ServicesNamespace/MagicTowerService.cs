using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.MagicTower;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	public class MagicTowerService : AbstractService
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x170000A4")]
		public override short ServiceId
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x5995", Offset = "0x5995", VA = "0x5995", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007B")]
		public event Action<ProtoLearnSpellAcceleratedEvt> LearnSpellAcceleratedEvent
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x5996", Offset = "0x5996", VA = "0x5996")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x5997", Offset = "0x5997", VA = "0x5997")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007C")]
		public event Action<ProtoLearnSpellFinishedEvt> LearnSpellFinishedEvent
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x5998", Offset = "0x5998", VA = "0x5998")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x5999", Offset = "0x5999", VA = "0x5999")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007D")]
		public event Action<ProtoLearnSpellCanceledEvt> LearnSpellCanceledEvent
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x599A", Offset = "0x599A", VA = "0x599A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x599B", Offset = "0x599B", VA = "0x599B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007E")]
		public event Action<ProtoLearnSpellStartedEvt> LearnSpellStartedEvent
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x599C", Offset = "0x599C", VA = "0x599C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x599D", Offset = "0x599D", VA = "0x599D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400007F")]
		public event Action<ProtoSpellUsedEvt> SpellUsedEvent
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x599E", Offset = "0x599E", VA = "0x599E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x599F", Offset = "0x599F", VA = "0x599F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000080")]
		public event Action<ProtoSpellActionExpiredEvt> SpellActionExpiredEvent
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x59A0", Offset = "0x59A0", VA = "0x59A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x59A1", Offset = "0x59A1", VA = "0x59A1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x59A2", Offset = "0x59A2", VA = "0x59A2", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x59A3", Offset = "0x59A3", VA = "0x59A3")]
		public OpToken<IMessage, object> GetMagicTowerInfo(ulong clanId)
		{
			return null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x59A4", Offset = "0x59A4", VA = "0x59A4")]
		public OpToken<IMessage, object> StartLearnSpell(uint spellId)
		{
			return null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x59A5", Offset = "0x59A5", VA = "0x59A5")]
		public OpToken<IMessage, object> CancelLearnSpell(uint spellId)
		{
			return null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x59A6", Offset = "0x59A6", VA = "0x59A6")]
		public OpToken<IMessage, object> AccelerateLearnSpell(uint spellId, ulong clanId)
		{
			return null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x59A7", Offset = "0x59A7", VA = "0x59A7")]
		public OpToken<IMessage, object> UseSpell(uint spellId)
		{
			return null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x59A8", Offset = "0x59A8", VA = "0x59A8")]
		public MagicTowerService()
		{
		}
	}
}
