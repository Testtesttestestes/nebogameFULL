using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace Core.Application.Managers
{
	// Token: 0x0200124C RID: 4684
	[Token(Token = "0x200124C")]
	public class AppBuildInfoManager : IAppManager, IBaseManager, IClientVersionProvider
	{
		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016AB")]
		public string Name
		{
			[Token(Token = "0x6006EF6")]
			[Address(RVA = "0xB973", Offset = "0xB973", VA = "0xB973", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002E4 RID: 740
		// (add) Token: 0x06006EF7 RID: 28407 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EF8 RID: 28408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006EF7")]
			[Address(RVA = "0xB974", Offset = "0xB974", VA = "0xB974", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EF8")]
			[Address(RVA = "0xB975", Offset = "0xB975", VA = "0xB975", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E5 RID: 741
		// (add) Token: 0x06006EF9 RID: 28409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EFA RID: 28410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006EF9")]
			[Address(RVA = "0xB976", Offset = "0xB976", VA = "0xB976", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EFA")]
			[Address(RVA = "0xB977", Offset = "0xB977", VA = "0xB977", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006EFB")]
		[Address(RVA = "0x228A", Offset = "0x228A", VA = "0x228A", Slot = "11")]
		public string GetVersion()
		{
			return null;
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFC")]
		[Address(RVA = "0xB978", Offset = "0xB978", VA = "0xB978", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0xB979", Offset = "0xB979", VA = "0xB979", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0xB97A", Offset = "0xB97A", VA = "0xB97A")]
		public AppBuildInfoManager()
		{
		}

		// Token: 0x04003A02 RID: 14850
		[Token(Token = "0x4003A02")]
		[FieldOffset(Offset = "0x10")]
		private AppBuildInfo _appBuildInfo;
	}
}
