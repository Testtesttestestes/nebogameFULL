using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Application;
using Core.Application.Managers.Environment;
using Gameplay.Billing.BillingProvider.UnityIAP;
using Il2CppDummyDll;

namespace Platforms.UnityEditor
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public class PlatformEnvironmentManagerImplementation : IAppManager, IBaseManager, IEnvironment
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CB")]
		public string Name
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x5B40", Offset = "0x5B40", VA = "0x5B40", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CC")]
		private IApp App
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x5B41", Offset = "0x5B41", VA = "0x5B41")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x5B42", Offset = "0x5B42", VA = "0x5B42")]
		public PlatformEnvironmentManagerImplementation(IApp app)
		{
		}

		// Token: 0x140000C4 RID: 196
		// (add) Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x5B43", Offset = "0x5B43", VA = "0x5B43", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x5B44", Offset = "0x5B44", VA = "0x5B44", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000C5 RID: 197
		// (add) Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x5B45", Offset = "0x5B45", VA = "0x5B45", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x5B46", Offset = "0x5B46", VA = "0x5B46", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x5B47", Offset = "0x5B47", VA = "0x5B47", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x5B48", Offset = "0x5B48", VA = "0x5B48", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000758")]
		public T GetUiapWrapper<T>() where T : class, IUiapWrapper, new()
		{
			return null;
		}

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x8")]
		private IUiapWrapper _uiapWrapper;
	}
}
