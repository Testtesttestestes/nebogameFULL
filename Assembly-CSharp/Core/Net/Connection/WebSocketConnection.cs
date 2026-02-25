using System;
using System.Collections;
using System.Collections.Generic;
using BestHTTP.WebSocket;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Net.Connection
{
	// Token: 0x02000EB2 RID: 3762
	[Token(Token = "0x2000EB2")]
	public class WebSocketConnection : AbstractConnection
	{
		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A0")]
		protected override IEnumerable<ISrvCommand> CommandsAwaitAnswer
		{
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0xA835", Offset = "0xA835", VA = "0xA835", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0xA836", Offset = "0xA836", VA = "0xA836")]
		public WebSocketConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0xA837", Offset = "0xA837", VA = "0xA837", Slot = "21")]
		public override void Rollback()
		{
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x6005B77")]
		[Address(RVA = "0xA838", Offset = "0xA838", VA = "0xA838", Slot = "23")]
		protected override bool TryRemoveAwaitCommand(PacketParser.Packet packet, out SrvCommand cmd)
		{
			return default(bool);
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x6005B78")]
		[Address(RVA = "0xA839", Offset = "0xA839", VA = "0xA839", Slot = "25")]
		protected override bool Test()
		{
			return default(bool);
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B79")]
		[Address(RVA = "0xA83A", Offset = "0xA83A", VA = "0xA83A", Slot = "18")]
		public override void Push(SrvCommand command)
		{
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0xA83B", Offset = "0xA83B", VA = "0xA83B", Slot = "19")]
		public override void Run()
		{
		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0xA83C", Offset = "0xA83C", VA = "0xA83C", Slot = "20")]
		public override void Stop()
		{
		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0xA83D", Offset = "0xA83D", VA = "0xA83D")]
		private void InternalRun()
		{
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0xA83E", Offset = "0xA83E", VA = "0xA83E")]
		private void InternalStop(ConnectionState.ConnectionStateReason reason)
		{
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0xA83F", Offset = "0xA83F", VA = "0xA83F")]
		private IEnumerator CmdCoroutine()
		{
			return null;
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0xA840", Offset = "0xA840", VA = "0xA840")]
		private WebSocket Connect()
		{
			return null;
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B80")]
		[Address(RVA = "0xA841", Offset = "0xA841", VA = "0xA841")]
		private void ListenSocket(WebSocket socket)
		{
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B81")]
		[Address(RVA = "0xA842", Offset = "0xA842", VA = "0xA842")]
		private void RemoveListenSocket(WebSocket socket)
		{
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B82")]
		[Address(RVA = "0xA843", Offset = "0xA843", VA = "0xA843")]
		private void OnBinary(WebSocket websocket, byte[] data)
		{
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0xA844", Offset = "0xA844", VA = "0xA844")]
		private void OnError(WebSocket websocket, string reason)
		{
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0xA845", Offset = "0xA845", VA = "0xA845")]
		private void OnClosed(WebSocket websocket, ushort code, string message)
		{
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0xA846", Offset = "0xA846", VA = "0xA846")]
		private void OnOpen(WebSocket websocket)
		{
		}

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0x3C")]
		private WebSocket _currentSocket;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0x40")]
		private readonly LinkedList<SrvCommand> _commandsAwaitAnswer;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0x44")]
		private Coroutine _cmdCoroutine;
	}
}
