using System;
using System.Threading;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EAF RID: 3759
	[Token(Token = "0x2000EAF")]
	public class ServerConnection : IConnection
	{
		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001299")]
		public static ServerConnection Instance
		{
			[Token(Token = "0x6005B55")]
			[Address(RVA = "0xA817", Offset = "0xA817", VA = "0xA817")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B56")]
		[Address(RVA = "0xA818", Offset = "0xA818", VA = "0xA818")]
		private ServerConnection()
		{
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B57")]
		[Address(RVA = "0xA819", Offset = "0xA819", VA = "0xA819")]
		private void ServerEventReceived(SrvAnswer evt)
		{
		}

		// Token: 0x1400022B RID: 555
		// (add) Token: 0x06005B58 RID: 23384 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005B59 RID: 23385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400022B")]
		public event Action<ConnectionState> OnStateChangedEvent
		{
			[Token(Token = "0x6005B58")]
			[Address(RVA = "0xA81A", Offset = "0xA81A", VA = "0xA81A", Slot = "11")]
			add
			{
			}
			[Token(Token = "0x6005B59")]
			[Address(RVA = "0xA81B", Offset = "0xA81B", VA = "0xA81B", Slot = "12")]
			remove
			{
			}
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0xA81C", Offset = "0xA81C", VA = "0xA81C", Slot = "13")]
		public void Push(SrvCommand command)
		{
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0xA81D", Offset = "0xA81D", VA = "0xA81D", Slot = "14")]
		public void AddServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0xA81E", Offset = "0xA81E", VA = "0xA81E", Slot = "15")]
		public void RemoveServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0xA81F", Offset = "0xA81F", VA = "0xA81F", Slot = "16")]
		public void Run()
		{
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0xA820", Offset = "0xA820", VA = "0xA820", Slot = "17")]
		public void Stop()
		{
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06005B5F RID: 23391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B60 RID: 23392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129A")]
		public Uri Uri
		{
			[Token(Token = "0x6005B5F")]
			[Address(RVA = "0xA821", Offset = "0xA821", VA = "0xA821", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B60")]
			[Address(RVA = "0xA822", Offset = "0xA822", VA = "0xA822", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06005B61 RID: 23393 RVA: 0x000103F8 File Offset: 0x0000E5F8
		// (set) Token: 0x06005B62 RID: 23394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129B")]
		public int WriteTimeout
		{
			[Token(Token = "0x6005B61")]
			[Address(RVA = "0xA823", Offset = "0xA823", VA = "0xA823", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B62")]
			[Address(RVA = "0xA824", Offset = "0xA824", VA = "0xA824", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06005B63 RID: 23395 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x06005B64 RID: 23396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129C")]
		public int ReadTimeout
		{
			[Token(Token = "0x6005B63")]
			[Address(RVA = "0xA825", Offset = "0xA825", VA = "0xA825", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B64")]
			[Address(RVA = "0xA826", Offset = "0xA826", VA = "0xA826", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700129D")]
		public ConnectionState CurrentState
		{
			[Token(Token = "0x6005B65")]
			[Address(RVA = "0xA827", Offset = "0xA827", VA = "0xA827", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0xA828", Offset = "0xA828", VA = "0xA828")]
		public void Setup(SynchronizationContext context, IProtocolMessageFactoriesRepository eventsMap, ILowResponseAbilityMonitor lowResponseAbilityMonitor)
		{
		}

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0x0")]
		private static ServerConnection _instance;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x8")]
		private readonly AbstractConnection _currentConnection;
	}
}
