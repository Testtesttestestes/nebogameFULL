using System;
using Il2CppDummyDll;

namespace Core.Application.Managers.Connection
{
	// Token: 0x0200126E RID: 4718
	[Token(Token = "0x200126E")]
	public class ServerConnectionDelay
	{
		// Token: 0x06006FED RID: 28653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FED")]
		[Address(RVA = "0xBA3D", Offset = "0xBA3D", VA = "0xBA3D")]
		public ServerConnectionDelay()
		{
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0xBA3E", Offset = "0xBA3E", VA = "0xBA3E")]
		public void IncreaseCommon()
		{
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FEF")]
		[Address(RVA = "0xBA3F", Offset = "0xBA3F", VA = "0xBA3F")]
		public void IncreaseMove()
		{
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0xBA40", Offset = "0xBA40", VA = "0xBA40")]
		public void IncreaseServer()
		{
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x00014580 File Offset: 0x00012780
		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0xBA41", Offset = "0xBA41", VA = "0xBA41")]
		public int GetDelay()
		{
			return 0;
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0x227A", Offset = "0x227A", VA = "0x227A")]
		public void ResetAll()
		{
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF3")]
		[Address(RVA = "0xBA42", Offset = "0xBA42", VA = "0xBA42")]
		public void ResetCommon()
		{
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF4")]
		[Address(RVA = "0xBA43", Offset = "0xBA43", VA = "0xBA43")]
		public void ResetMove()
		{
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FF5")]
		[Address(RVA = "0x227F", Offset = "0x227F", VA = "0x227F")]
		public void ResetServer()
		{
		}

		// Token: 0x04003A6D RID: 14957
		[Token(Token = "0x4003A6D")]
		[FieldOffset(Offset = "0x8")]
		private int _common;

		// Token: 0x04003A6E RID: 14958
		[Token(Token = "0x4003A6E")]
		[FieldOffset(Offset = "0xC")]
		private int _move;

		// Token: 0x04003A6F RID: 14959
		[Token(Token = "0x4003A6F")]
		[FieldOffset(Offset = "0x10")]
		private int _server;
	}
}
