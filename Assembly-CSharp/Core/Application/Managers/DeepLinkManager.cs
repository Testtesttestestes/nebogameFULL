using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200124D RID: 4685
	[Token(Token = "0x200124D")]
	public class DeepLinkManager : IAppManager, IBaseManager
	{
		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016AC")]
		public string Name
		{
			[Token(Token = "0x6006EFF")]
			[Address(RVA = "0xB97B", Offset = "0xB97B", VA = "0xB97B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002E6 RID: 742
		// (add) Token: 0x06006F00 RID: 28416 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F01 RID: 28417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E6")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F00")]
			[Address(RVA = "0xB97C", Offset = "0xB97C", VA = "0xB97C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F01")]
			[Address(RVA = "0xB97D", Offset = "0xB97D", VA = "0xB97D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E7 RID: 743
		// (add) Token: 0x06006F02 RID: 28418 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F03 RID: 28419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E7")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F02")]
			[Address(RVA = "0xB97E", Offset = "0xB97E", VA = "0xB97E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F03")]
			[Address(RVA = "0xB97F", Offset = "0xB97F", VA = "0xB97F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E8 RID: 744
		// (add) Token: 0x06006F04 RID: 28420 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F05 RID: 28421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E8")]
		public event Action<Uri> UriChangedEvent
		{
			[Token(Token = "0x6006F04")]
			[Address(RVA = "0xB980", Offset = "0xB980", VA = "0xB980")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F05")]
			[Address(RVA = "0xB981", Offset = "0xB981", VA = "0xB981")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AD")]
		public IApp Application
		{
			[Token(Token = "0x6006F06")]
			[Address(RVA = "0xB982", Offset = "0xB982", VA = "0xB982")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F07")]
			[Address(RVA = "0xB983", Offset = "0xB983", VA = "0xB983")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AE")]
		public Uri LinkUri
		{
			[Token(Token = "0x6006F08")]
			[Address(RVA = "0xB984", Offset = "0xB984", VA = "0xB984")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F09")]
			[Address(RVA = "0xB985", Offset = "0xB985", VA = "0xB985")]
			private set
			{
			}
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0xB986", Offset = "0xB986", VA = "0xB986")]
		public DeepLinkManager(IApp application)
		{
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F0B")]
		[Address(RVA = "0xB987", Offset = "0xB987", VA = "0xB987", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0xB988", Offset = "0xB988", VA = "0xB988", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0xB989", Offset = "0xB989", VA = "0xB989")]
		private void HandleDeepLinkActivatedEvent(string uri)
		{
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0xB98A", Offset = "0xB98A", VA = "0xB98A")]
		private void HandleDeepLink(Uri uri)
		{
		}

		// Token: 0x04003A07 RID: 14855
		[Token(Token = "0x4003A07")]
		[FieldOffset(Offset = "0x18")]
		private Uri _linkUri;
	}
}
