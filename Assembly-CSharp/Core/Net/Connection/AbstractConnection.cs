using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EA4 RID: 3748
	[Token(Token = "0x2000EA4")]
	public abstract class AbstractConnection : IConnection
	{
		// Token: 0x14000228 RID: 552
		// (add) Token: 0x06005B0D RID: 23309 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005B0E RID: 23310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000228")]
		public event Action<ConnectionState> OnStateChangedEvent
		{
			[Token(Token = "0x6005B0D")]
			[Address(RVA = "0xA7E2", Offset = "0xA7E2", VA = "0xA7E2", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005B0E")]
			[Address(RVA = "0xA7E3", Offset = "0xA7E3", VA = "0xA7E3", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000229 RID: 553
		// (add) Token: 0x06005B0F RID: 23311 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005B10 RID: 23312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000229")]
		public event Action<SrvAnswer> OnServerEventReceived
		{
			[Token(Token = "0x6005B0F")]
			[Address(RVA = "0xA7E4", Offset = "0xA7E4", VA = "0xA7E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005B10")]
			[Address(RVA = "0xA7E5", Offset = "0xA7E5", VA = "0xA7E5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06005B11 RID: 23313 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B12 RID: 23314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128C")]
		public Uri Uri
		{
			[Token(Token = "0x6005B11")]
			[Address(RVA = "0xA7E6", Offset = "0xA7E6", VA = "0xA7E6", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B12")]
			[Address(RVA = "0xA7E7", Offset = "0xA7E7", VA = "0xA7E7", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06005B13 RID: 23315 RVA: 0x00010350 File Offset: 0x0000E550
		// (set) Token: 0x06005B14 RID: 23316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128D")]
		public int WriteTimeout
		{
			[Token(Token = "0x6005B13")]
			[Address(RVA = "0xA7E8", Offset = "0xA7E8", VA = "0xA7E8", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B14")]
			[Address(RVA = "0xA7E9", Offset = "0xA7E9", VA = "0xA7E9", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x00010368 File Offset: 0x0000E568
		// (set) Token: 0x06005B16 RID: 23318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128E")]
		public int ReadTimeout
		{
			[Token(Token = "0x6005B15")]
			[Address(RVA = "0xA7EA", Offset = "0xA7EA", VA = "0xA7EA", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B16")]
			[Address(RVA = "0xA7EB", Offset = "0xA7EB", VA = "0xA7EB", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06005B17 RID: 23319 RVA: 0x00010380 File Offset: 0x0000E580
		// (set) Token: 0x06005B18 RID: 23320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128F")]
		public int ReadBufferSize
		{
			[Token(Token = "0x6005B17")]
			[Address(RVA = "0xA7EC", Offset = "0xA7EC", VA = "0xA7EC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B18")]
			[Address(RVA = "0xA7ED", Offset = "0xA7ED", VA = "0xA7ED")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B1A RID: 23322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001290")]
		public IProtocolMessageFactoriesRepository MessageFactoriesRepository
		{
			[Token(Token = "0x6005B19")]
			[Address(RVA = "0xA7EE", Offset = "0xA7EE", VA = "0xA7EE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B1A")]
			[Address(RVA = "0xA7EF", Offset = "0xA7EF", VA = "0xA7EF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06005B1B RID: 23323 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B1C RID: 23324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001291")]
		public ILowResponseAbilityMonitor LowResponseAbilityMonitor
		{
			[Token(Token = "0x6005B1B")]
			[Address(RVA = "0xA7F0", Offset = "0xA7F0", VA = "0xA7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B1C")]
			[Address(RVA = "0xA7F1", Offset = "0xA7F1", VA = "0xA7F1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B1E RID: 23326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001292")]
		public ConnectionState CurrentState
		{
			[Token(Token = "0x6005B1D")]
			[Address(RVA = "0xA7F2", Offset = "0xA7F2", VA = "0xA7F2", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B1E")]
			[Address(RVA = "0xA7F3", Offset = "0xA7F3", VA = "0xA7F3")]
			protected set
			{
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x00010398 File Offset: 0x0000E598
		// (set) Token: 0x06005B20 RID: 23328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001293")]
		public bool IsRun
		{
			[Token(Token = "0x6005B1F")]
			[Address(RVA = "0xA7F4", Offset = "0xA7F4", VA = "0xA7F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B20")]
			[Address(RVA = "0xA7F5", Offset = "0xA7F5", VA = "0xA7F5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B21")]
		[Address(RVA = "0xA7F6", Offset = "0xA7F6", VA = "0xA7F6")]
		public AbstractConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		}

		// Token: 0x06005B22 RID: 23330
		[Token(Token = "0x6005B22")]
		public abstract void Push(SrvCommand command);

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B23")]
		[Address(RVA = "0xA7F7", Offset = "0xA7F7", VA = "0xA7F7", Slot = "14")]
		public void AddServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B24")]
		[Address(RVA = "0xA7F8", Offset = "0xA7F8", VA = "0xA7F8", Slot = "15")]
		public void RemoveServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B25")]
		[Address(RVA = "0xA7F9", Offset = "0xA7F9", VA = "0xA7F9")]
		public Dictionary<Action<SrvAnswer>, Action<SrvAnswer>> GetEventHandlers(short serviceId)
		{
			return null;
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B26")]
		[Address(RVA = "0xA7FA", Offset = "0xA7FA", VA = "0xA7FA", Slot = "19")]
		public virtual void Run()
		{
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B27")]
		[Address(RVA = "0xA7FB", Offset = "0xA7FB", VA = "0xA7FB", Slot = "20")]
		public virtual void Stop()
		{
		}

		// Token: 0x06005B28 RID: 23336
		[Token(Token = "0x6005B28")]
		public abstract void Rollback();

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B29")]
		[Address(RVA = "0xA7FC", Offset = "0xA7FC", VA = "0xA7FC")]
		private void HandlePacketCompleteEvent(PacketParser.Packet packet)
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2A")]
		[Address(RVA = "0xA7FD", Offset = "0xA7FD", VA = "0xA7FD")]
		private void HandledEvent(SrvAnswer answer)
		{
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B2B")]
		[Address(RVA = "0xA7FE", Offset = "0xA7FE", VA = "0xA7FE")]
		protected IList<PacketParser.Packet> Receive(byte[] buffer)
		{
			return null;
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2C")]
		[Address(RVA = "0xA7FF", Offset = "0xA7FF", VA = "0xA7FF", Slot = "22")]
		protected virtual void HandleQueue()
		{
		}

		// Token: 0x06005B2D RID: 23341
		[Token(Token = "0x6005B2D")]
		protected abstract bool TryRemoveAwaitCommand(PacketParser.Packet packet, out SrvCommand cmd);

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06005B2E RID: 23342
		[Token(Token = "0x17001294")]
		protected abstract IEnumerable<ISrvCommand> CommandsAwaitAnswer { [Token(Token = "0x6005B2E")] get; }

		// Token: 0x06005B2F RID: 23343
		[Token(Token = "0x6005B2F")]
		protected abstract bool Test();

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<short, Dictionary<Action<SrvAnswer>, Action<SrvAnswer>>> _eventHandlers;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x2C")]
		private ConnectionState _currentState;

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x30")]
		protected readonly IPacketParser _parser;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x38")]
		public readonly int HandleCmdQueuePeriod;

		// Token: 0x02000EA5 RID: 3749
		[Token(Token = "0x2000EA5")]
		public enum ErrorCodes
		{
			// Token: 0x040031D2 RID: 12754
			[Token(Token = "0x40031D2")]
			COULD_NOT_RESOLVE_HOST = 11001,
			// Token: 0x040031D3 RID: 12755
			[Token(Token = "0x40031D3")]
			TIMEOUT_ERROR_CODE = 10060
		}
	}
}
