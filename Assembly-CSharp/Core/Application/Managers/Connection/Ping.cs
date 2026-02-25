using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Configuration;
using Core.Net.Connection;
using Google.Protobuf;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Core.Application.Managers.Connection
{
	// Token: 0x0200126C RID: 4716
	[Token(Token = "0x200126C")]
	public class Ping : IPing, IDisposable
	{
		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06006FDF RID: 28639 RVA: 0x00014538 File Offset: 0x00012738
		// (set) Token: 0x06006FE0 RID: 28640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016D7")]
		public bool IsRun
		{
			[Token(Token = "0x6006FDF")]
			[Address(RVA = "0xBA2F", Offset = "0xBA2F", VA = "0xBA2F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006FE0")]
			[Address(RVA = "0xBA30", Offset = "0xBA30", VA = "0xBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0xBA31", Offset = "0xBA31", VA = "0xBA31", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0xBA32", Offset = "0xBA32", VA = "0xBA32")]
		public Ping(ConfigRecord config, IConnection connection)
		{
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FE3")]
		[Address(RVA = "0xBA33", Offset = "0xBA33", VA = "0xBA33")]
		private IEnumerator PingCoroutine(float timeout)
		{
			return null;
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0xBA34", Offset = "0xBA34", VA = "0xBA34")]
		public void Run()
		{
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE5")]
		[Address(RVA = "0xBA35", Offset = "0xBA35", VA = "0xBA35")]
		public void Stop()
		{
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0xBA36", Offset = "0xBA36", VA = "0xBA36", Slot = "4")]
		public bool TrySend(out uint index, out OpToken<IMessage, object> token)
		{
			return default(bool);
		}

		// Token: 0x04003A64 RID: 14948
		[Token(Token = "0x4003A64")]
		[FieldOffset(Offset = "0x8")]
		private ConfigRecord _config;

		// Token: 0x04003A65 RID: 14949
		[Token(Token = "0x4003A65")]
		[FieldOffset(Offset = "0xC")]
		private Coroutine _currentPingCoroutine;

		// Token: 0x04003A66 RID: 14950
		[Token(Token = "0x4003A66")]
		[FieldOffset(Offset = "0x10")]
		private IConnection _connection;

		// Token: 0x04003A67 RID: 14951
		[Token(Token = "0x4003A67")]
		[FieldOffset(Offset = "0x14")]
		private bool _disposed;
	}
}
