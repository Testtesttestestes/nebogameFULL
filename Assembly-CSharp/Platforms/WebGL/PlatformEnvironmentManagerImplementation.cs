using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Application;
using Core.Application.Managers.Environment;
using Gameplay.Billing.BillingProvider.UnityIAP;
using Il2CppDummyDll;

namespace Platforms.WebGL
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public class PlatformEnvironmentManagerImplementation : IAppManager, IBaseManager, IEnvironment
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C9")]
		public string Name
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x5B26", Offset = "0x5B26", VA = "0x5B26", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C0")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x5B27", Offset = "0x5B27", VA = "0x5B27", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x5B28", Offset = "0x5B28", VA = "0x5B28", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C1")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x5B29", Offset = "0x5B29", VA = "0x5B29", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x5B2A", Offset = "0x5B2A", VA = "0x5B2A", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x5B2B", Offset = "0x5B2B", VA = "0x5B2B")]
		public PlatformEnvironmentManagerImplementation(IApp app)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x5B2C", Offset = "0x5B2C", VA = "0x5B2C", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x5B2D", Offset = "0x5B2D", VA = "0x5B2D", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000738")]
		public T GetUiapWrapper<T>() where T : class, IUiapWrapper, new()
		{
			return null;
		}
	}
}
