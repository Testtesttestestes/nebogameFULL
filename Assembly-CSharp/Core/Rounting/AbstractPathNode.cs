using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Utils;

namespace Core.Rounting
{
	// Token: 0x02000E79 RID: 3705
	[Token(Token = "0x2000E79")]
	public abstract class AbstractPathNode
	{
		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A37 RID: 23095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001260")]
		public string Name
		{
			[Token(Token = "0x6005A36")]
			[Address(RVA = "0xA740", Offset = "0xA740", VA = "0xA740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A37")]
			[Address(RVA = "0xA741", Offset = "0xA741", VA = "0xA741")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06005A38 RID: 23096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A39 RID: 23097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001261")]
		public LinkedListNode<AbstractPathNode> Owner
		{
			[Token(Token = "0x6005A38")]
			[Address(RVA = "0xA742", Offset = "0xA742", VA = "0xA742")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A39")]
			[Address(RVA = "0xA743", Offset = "0xA743", VA = "0xA743")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A3B RID: 23099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001262")]
		public IGame Game
		{
			[Token(Token = "0x6005A3A")]
			[Address(RVA = "0xA744", Offset = "0xA744", VA = "0xA744")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A3B")]
			[Address(RVA = "0xA745", Offset = "0xA745", VA = "0xA745")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001263")]
		public OpTokenRepository TokenRepository
		{
			[Token(Token = "0x6005A3C")]
			[Address(RVA = "0xA746", Offset = "0xA746", VA = "0xA746")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A3D")]
			[Address(RVA = "0xA747", Offset = "0xA747", VA = "0xA747")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0xA748", Offset = "0xA748", VA = "0xA748")]
		public void Dispose()
		{
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0xA749", Offset = "0xA749", VA = "0xA749")]
		protected AbstractPathNode()
		{
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0xA74A", Offset = "0xA74A", VA = "0xA74A")]
		public void Execute(LocatorPayload payload)
		{
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A41")]
		[Address(RVA = "0xA74B", Offset = "0xA74B", VA = "0xA74B")]
		private void HandleCancel(OpToken<LocatorPayload, AbstractPathNode> token)
		{
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A42")]
		[Address(RVA = "0xA74C", Offset = "0xA74C", VA = "0xA74C")]
		private void HandleFault(OpToken<LocatorPayload, AbstractPathNode> token)
		{
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A43")]
		[Address(RVA = "0xA74D", Offset = "0xA74D", VA = "0xA74D")]
		private void HandleResult(OpToken<LocatorPayload, AbstractPathNode> token)
		{
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0xA74E", Offset = "0xA74E", VA = "0xA74E", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x6005A45")]
		[Address(RVA = "0xA74F", Offset = "0xA74F", VA = "0xA74F", Slot = "4")]
		public virtual bool Check()
		{
			return default(bool);
		}

		// Token: 0x06005A46 RID: 23110
		[Token(Token = "0x6005A46")]
		protected abstract void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload);

		// Token: 0x06005A47 RID: 23111
		[Token(Token = "0x6005A47")]
		protected abstract void TransitionCanceled();
	}
}
