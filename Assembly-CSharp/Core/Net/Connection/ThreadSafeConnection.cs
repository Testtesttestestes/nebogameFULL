using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net.Connection
{
	// Token: 0x02000EB1 RID: 3761
	[Token(Token = "0x2000EB1")]
	public abstract class ThreadSafeConnection : AbstractConnection
	{
		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06005B69 RID: 23401 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B6A RID: 23402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129E")]
		[CanBeNull]
		private protected CancellationTokenSource Cts
		{
			[Token(Token = "0x6005B69")]
			[Address(RVA = "0xA82B", Offset = "0xA82B", VA = "0xA82B")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0xA82C", Offset = "0xA82C", VA = "0xA82C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06005B6B RID: 23403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700129F")]
		protected override IEnumerable<ISrvCommand> CommandsAwaitAnswer
		{
			[Token(Token = "0x6005B6B")]
			[Address(RVA = "0xA82D", Offset = "0xA82D", VA = "0xA82D", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0xA82E", Offset = "0xA82E", VA = "0xA82E")]
		public ThreadSafeConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0xA82F", Offset = "0xA82F", VA = "0xA82F", Slot = "19")]
		public override void Run()
		{
		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0xA830", Offset = "0xA830", VA = "0xA830", Slot = "20")]
		public override void Stop()
		{
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0xA831", Offset = "0xA831", VA = "0xA831", Slot = "18")]
		public override void Push(SrvCommand command)
		{
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0xA832", Offset = "0xA832", VA = "0xA832", Slot = "21")]
		public override void Rollback()
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0xA833", Offset = "0xA833", VA = "0xA833", Slot = "23")]
		protected override bool TryRemoveAwaitCommand(PacketParser.Packet packet, out SrvCommand cmd)
		{
			return default(bool);
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0xA834", Offset = "0xA834", VA = "0xA834", Slot = "25")]
		protected override bool Test()
		{
			return default(bool);
		}

		// Token: 0x06005B73 RID: 23411
		[Token(Token = "0x6005B73")]
		protected abstract void Send(SrvCommand command);

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0x3C")]
		protected readonly ConcurrentDictionary<uint, SrvCommand> _commandsAwaitAnswer;
	}
}
