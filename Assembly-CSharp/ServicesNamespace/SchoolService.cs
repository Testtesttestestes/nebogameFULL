using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.School;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public class SchoolService : AbstractService
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x170000AA")]
		public override short ServiceId
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x5A1E", Offset = "0x5A1E", VA = "0x5A1E", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000096")]
		public event Action<ProtoLearnSpellAcceleratedEvt> LearnSpellAccelerated
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x5A1F", Offset = "0x5A1F", VA = "0x5A1F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x5A20", Offset = "0x5A20", VA = "0x5A20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000097")]
		public event Action<ProtoLearnSpellFinishedEvt> LearnSpellFinished
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x5A21", Offset = "0x5A21", VA = "0x5A21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x5A22", Offset = "0x5A22", VA = "0x5A22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000098")]
		public event Action<ProtoLearnSpellCanceledEvt> LearnSpellCanceled
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x5A23", Offset = "0x5A23", VA = "0x5A23")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x5A24", Offset = "0x5A24", VA = "0x5A24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000099")]
		public event Action<ProtoLearnSpellStartedEvt> LearnSpellStarted
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x5A25", Offset = "0x5A25", VA = "0x5A25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x5A26", Offset = "0x5A26", VA = "0x5A26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x5A27", Offset = "0x5A27", VA = "0x5A27", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x5A28", Offset = "0x5A28", VA = "0x5A28")]
		public OpToken<IMessage, object> GetUserSpells()
		{
			return null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x5A29", Offset = "0x5A29", VA = "0x5A29")]
		public OpToken<IMessage, object> StartLearnSpell(uint spellId)
		{
			return null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5A2A", Offset = "0x5A2A", VA = "0x5A2A")]
		public OpToken<IMessage, object> CancelLearnSpell(uint spellId)
		{
			return null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x5A2B", Offset = "0x5A2B", VA = "0x5A2B")]
		public OpToken<IMessage, object> AccelerateLearnSpell(uint spellId, ulong ownerId)
		{
			return null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x5A2C", Offset = "0x5A2C", VA = "0x5A2C")]
		public OpToken<IMessage, object> GetSchoolInfo(ulong ownerId)
		{
			return null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600062B")]
		private OpToken<IMessage, object> MageSchoolRequest<TAns>(string cmdName, SchoolCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x5A2D", Offset = "0x5A2D", VA = "0x5A2D")]
		public SchoolService()
		{
		}
	}
}
