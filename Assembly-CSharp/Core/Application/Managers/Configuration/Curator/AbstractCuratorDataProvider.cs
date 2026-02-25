using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Consts;
using Utils;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x0200126F RID: 4719
	[Token(Token = "0x200126F")]
	public abstract class AbstractCuratorDataProvider : ICuratorDataProvider, IDisposable
	{
		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06006FF6 RID: 28662 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FF7 RID: 28663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DA")]
		[CanBeNull]
		public CuratorService Service
		{
			[Token(Token = "0x6006FF6")]
			[Address(RVA = "0xBA44", Offset = "0xBA44", VA = "0xBA44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FF7")]
			[Address(RVA = "0xBA45", Offset = "0xBA45", VA = "0xBA45")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06006FF8 RID: 28664 RVA: 0x00014598 File Offset: 0x00012798
		// (set) Token: 0x06006FF9 RID: 28665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DB")]
		public ClientPlatform Platform
		{
			[Token(Token = "0x6006FF8")]
			[Address(RVA = "0xBA46", Offset = "0xBA46", VA = "0xBA46")]
			[CompilerGenerated]
			get
			{
				return ClientPlatform.UnknownClientPlatform;
			}
			[Token(Token = "0x6006FF9")]
			[Address(RVA = "0xBA47", Offset = "0xBA47", VA = "0xBA47")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06006FFA RID: 28666 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FFB RID: 28667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DC")]
		[CanBeNull]
		public CuratorData Data
		{
			[Token(Token = "0x6006FFA")]
			[Address(RVA = "0xBA48", Offset = "0xBA48", VA = "0xBA48", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FFB")]
			[Address(RVA = "0xBA49", Offset = "0xBA49", VA = "0xBA49", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x140002F7 RID: 759
		// (add) Token: 0x06006FFC RID: 28668 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006FFD RID: 28669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F7")]
		public event Action<ICuratorDataProvider> CompleteEvent
		{
			[Token(Token = "0x6006FFC")]
			[Address(RVA = "0xBA4A", Offset = "0xBA4A", VA = "0xBA4A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006FFD")]
			[Address(RVA = "0xBA4B", Offset = "0xBA4B", VA = "0xBA4B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0xBA4C", Offset = "0xBA4C", VA = "0xBA4C", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FFF")]
		[Address(RVA = "0xBA4D", Offset = "0xBA4D", VA = "0xBA4D")]
		public AbstractCuratorDataProvider(ClientPlatform platform, [NotNull] CuratorService service)
		{
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007000")]
		[Address(RVA = "0xBA4E", Offset = "0xBA4E", VA = "0xBA4E")]
		public AbstractCuratorDataProvider(CuratorData data)
		{
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007001")]
		[Address(RVA = "0xBA4F", Offset = "0xBA4F", VA = "0xBA4F")]
		protected void AddRequestToken(IOpToken token)
		{
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007002")]
		[Address(RVA = "0xBA50", Offset = "0xBA50", VA = "0xBA50")]
		protected void RemoveRequestToken(IOpToken token)
		{
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007003")]
		[Address(RVA = "0xBA51", Offset = "0xBA51", VA = "0xBA51")]
		protected void Complete()
		{
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007004")]
		[Address(RVA = "0xBA52", Offset = "0xBA52", VA = "0xBA52", Slot = "11")]
		public virtual void Run()
		{
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007005")]
		[Address(RVA = "0xBA53", Offset = "0xBA53", VA = "0xBA53")]
		public void Stop()
		{
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007006")]
		[Address(RVA = "0xBA54", Offset = "0xBA54", VA = "0xBA54", Slot = "12")]
		public virtual string GetUserId(ulong userId)
		{
			return null;
		}

		// Token: 0x06007007 RID: 28679
		[Token(Token = "0x6007007")]
		public abstract void Commit();

		// Token: 0x04003A70 RID: 14960
		[Token(Token = "0x4003A70")]
		[FieldOffset(Offset = "0x8")]
		private List<IOpToken> _tokens;
	}
}
