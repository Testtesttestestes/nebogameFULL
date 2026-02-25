using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net.Connection;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Core.Net
{
	// Token: 0x02000E86 RID: 3718
	[Token(Token = "0x2000E86")]
	public abstract class AbstractService
	{
		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A6C RID: 23148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700126B")]
		public ProtocolCommandInfoProvider ProtocolInfoProvider
		{
			[Token(Token = "0x6005A6B")]
			[Address(RVA = "0xA76A", Offset = "0xA76A", VA = "0xA76A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A6C")]
			[Address(RVA = "0xA76B", Offset = "0xA76B", VA = "0xA76B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06005A6D RID: 23149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A6E RID: 23150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700126C")]
		public IConnection Connection
		{
			[Token(Token = "0x6005A6D")]
			[Address(RVA = "0xA76C", Offset = "0xA76C", VA = "0xA76C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A6E")]
			[Address(RVA = "0xA76D", Offset = "0xA76D", VA = "0xA76D")]
			set
			{
			}
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0xA76E", Offset = "0xA76E", VA = "0xA76E")]
		private void HandleConnectionChanged()
		{
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0xA76F", Offset = "0xA76F", VA = "0xA76F")]
		private void HandleStateChangedEvent(ConnectionState state)
		{
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06005A71 RID: 23153
		[Token(Token = "0x1700126D")]
		public abstract short ServiceId { [Token(Token = "0x6005A71")] get; }

		// Token: 0x06005A72 RID: 23154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A72")]
		protected void LogEvent<T>(T eventId, IMessage message) where T : Enum
		{
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0xA770", Offset = "0xA770", VA = "0xA770")]
		protected void LogCommandAnswer(SrvCommand command, IMessage answerMsg)
		{
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0xA771", Offset = "0xA771", VA = "0xA771")]
		protected void PushCommand(SrvCommand command)
		{
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0xA772", Offset = "0xA772", VA = "0xA772")]
		protected OpToken<IMessage, object> GetOpToken(uint index)
		{
			return null;
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0xA773", Offset = "0xA773", VA = "0xA773")]
		private void KillOpToken(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0xA774", Offset = "0xA774", VA = "0xA774")]
		private void HandleOpFault(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0xA775", Offset = "0xA775", VA = "0xA775", Slot = "5")]
		protected virtual void CommonCommandCallback(SrvCommand cmd, IMessage msg)
		{
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0xA776", Offset = "0xA776", VA = "0xA776", Slot = "6")]
		protected virtual void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0xA777", Offset = "0xA777", VA = "0xA777")]
		protected AbstractService()
		{
		}

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<uint, OpToken<IMessage, object>> _operationByCmdIndex;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x10")]
		private IConnection _connection;
	}
}
