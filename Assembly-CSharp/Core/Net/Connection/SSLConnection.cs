using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EAB RID: 3755
	[Token(Token = "0x2000EAB")]
	public class SSLConnection : ThreadSafeConnection
	{
		// Token: 0x06005B43 RID: 23363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B43")]
		[Address(RVA = "0xA805", Offset = "0xA805", VA = "0xA805")]
		public SSLConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B44")]
		[Address(RVA = "0xA806", Offset = "0xA806", VA = "0xA806", Slot = "19")]
		public override void Run()
		{
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B45")]
		[Address(RVA = "0xA807", Offset = "0xA807", VA = "0xA807", Slot = "20")]
		public override void Stop()
		{
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B46")]
		[Address(RVA = "0xA808", Offset = "0xA808", VA = "0xA808")]
		private void InternalStop(ConnectionState.ConnectionStateReason reason)
		{
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B47")]
		[Address(RVA = "0xA809", Offset = "0xA809", VA = "0xA809")]
		private void Internal_RunJob(object args)
		{
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0xA80A", Offset = "0xA80A", VA = "0xA80A")]
		private void ReadJob(object args)
		{
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0xA80B", Offset = "0xA80B", VA = "0xA80B")]
		private SslStream GetSsl(Stream stream)
		{
			return null;
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0xA80C", Offset = "0xA80C", VA = "0xA80C")]
		private Socket Connect()
		{
			return null;
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0xA80D", Offset = "0xA80D", VA = "0xA80D")]
		private static void FillReasonFromAggregateException(ConnectionState.ConnectionStateReason reason, AggregateException ex)
		{
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0xA80E", Offset = "0xA80E", VA = "0xA80E", Slot = "25")]
		protected override bool Test()
		{
			return default(bool);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0xA80F", Offset = "0xA80F", VA = "0xA80F", Slot = "26")]
		protected override void Send(SrvCommand command)
		{
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0xA810", Offset = "0xA810", VA = "0xA810")]
		private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x44")]
		private byte[] _buffer;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x48")]
		private Socket _client;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x4C")]
		private SslStream _sslStream;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x50")]
		private object _sendSyncMonitor;

		// Token: 0x02000EAC RID: 3756
		[Token(Token = "0x2000EAC")]
		private class JobArgs
		{
			// Token: 0x06005B4F RID: 23375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0xA811", Offset = "0xA811", VA = "0xA811")]
			public JobArgs(SslStream stream, CancellationToken cancellationToken)
			{
			}

			// Token: 0x040031E8 RID: 12776
			[Token(Token = "0x40031E8")]
			[FieldOffset(Offset = "0x8")]
			public readonly SslStream Stream;

			// Token: 0x040031E9 RID: 12777
			[Token(Token = "0x40031E9")]
			[FieldOffset(Offset = "0xC")]
			public CancellationToken CancellationToken;
		}
	}
}
