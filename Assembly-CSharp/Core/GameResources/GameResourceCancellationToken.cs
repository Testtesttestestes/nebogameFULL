using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace Core.GameResources
{
	// Token: 0x02000ECB RID: 3787
	[Token(Token = "0x2000ECB")]
	public class GameResourceCancellationToken : IDisposable
	{
		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005C3B RID: 23611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012B7")]
		public CancellationTokenSource CancellationToken
		{
			[Token(Token = "0x6005C3A")]
			[Address(RVA = "0xA8DE", Offset = "0xA8DE", VA = "0xA8DE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C3B")]
			[Address(RVA = "0xA8DF", Offset = "0xA8DF", VA = "0xA8DF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400022D RID: 557
		// (add) Token: 0x06005C3C RID: 23612 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005C3D RID: 23613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400022D")]
		private event Action LoadCompleteEvent
		{
			[Token(Token = "0x6005C3C")]
			[Address(RVA = "0xA8E0", Offset = "0xA8E0", VA = "0xA8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005C3D")]
			[Address(RVA = "0xA8E1", Offset = "0xA8E1", VA = "0xA8E1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x06005C3F RID: 23615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012B8")]
		public bool LoadComplete
		{
			[Token(Token = "0x6005C3E")]
			[Address(RVA = "0xA8E2", Offset = "0xA8E2", VA = "0xA8E2")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C3F")]
			[Address(RVA = "0xA8E3", Offset = "0xA8E3", VA = "0xA8E3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x00010920 File Offset: 0x0000EB20
		[Token(Token = "0x170012B9")]
		public bool CancellationRequested
		{
			[Token(Token = "0x6005C40")]
			[Address(RVA = "0x22A5", Offset = "0x22A5", VA = "0x22A5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0xA8E4", Offset = "0xA8E4", VA = "0xA8E4")]
		public void Init()
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0xA8E5", Offset = "0xA8E5", VA = "0xA8E5")]
		public void CallWhenComplete(Action callback)
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x22A6", Offset = "0x22A6", VA = "0x22A6")]
		public void SetLoadComplete()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0xA8E6", Offset = "0xA8E6", VA = "0xA8E6")]
		public void Cancel()
		{
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0xA8E7", Offset = "0xA8E7", VA = "0xA8E7", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0xA8E8", Offset = "0xA8E8", VA = "0xA8E8")]
		public GameResourceCancellationToken()
		{
		}
	}
}
