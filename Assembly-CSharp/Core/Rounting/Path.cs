using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Utils;

namespace Core.Rounting
{
	// Token: 0x02000E81 RID: 3713
	[Token(Token = "0x2000E81")]
	public class Path : IDisposable
	{
		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A5A RID: 23130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001269")]
		public Uri Uri
		{
			[Token(Token = "0x6005A59")]
			[Address(RVA = "0xA75A", Offset = "0xA75A", VA = "0xA75A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A5A")]
			[Address(RVA = "0xA75B", Offset = "0xA75B", VA = "0xA75B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0xA75C", Offset = "0xA75C", VA = "0xA75C", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0xA75D", Offset = "0xA75D", VA = "0xA75D")]
		public Path(IGame game, OpTokenRepository tokenRepository, IPathNodeFactoryRepository repository, Uri uri)
		{
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0xA75E", Offset = "0xA75E", VA = "0xA75E")]
		public bool Check()
		{
			return default(bool);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0xA75F", Offset = "0xA75F", VA = "0xA75F")]
		public void Run()
		{
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0xA760", Offset = "0xA760", VA = "0xA760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x8")]
		private readonly LinkedList<AbstractPathNode> _nodes;

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0xC")]
		private readonly char[] _pathDelimiter;
	}
}
