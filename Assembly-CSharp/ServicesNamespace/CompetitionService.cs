using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Competition;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public class CompetitionService : AbstractService
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x1700009D")]
		public override short ServiceId
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x5941", Offset = "0x5941", VA = "0x5941", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005F")]
		public event Action<ProtoCompetitionStateChangedEvt> CompetitionStateChangedEvent
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x5942", Offset = "0x5942", VA = "0x5942")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x5943", Offset = "0x5943", VA = "0x5943")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x5944", Offset = "0x5944", VA = "0x5944", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x5945", Offset = "0x5945", VA = "0x5945")]
		public OpToken<IMessage, object> GetCompetitionState()
		{
			return null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x5946", Offset = "0x5946", VA = "0x5946")]
		public CompetitionService()
		{
		}
	}
}
