using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers.Configuration.Curator;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Configuration
{
	// Token: 0x0200122F RID: 4655
	[Token(Token = "0x200122F")]
	public class ConfigurationManager : IAppManager, IBaseManager
	{
		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700165B")]
		public string Name
		{
			[Token(Token = "0x6006E3A")]
			[Address(RVA = "0xB8E5", Offset = "0xB8E5", VA = "0xB8E5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002DD RID: 733
		// (add) Token: 0x06006E3B RID: 28219 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006E3C RID: 28220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DD")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006E3B")]
			[Address(RVA = "0xB8E6", Offset = "0xB8E6", VA = "0xB8E6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E3C")]
			[Address(RVA = "0xB8E7", Offset = "0xB8E7", VA = "0xB8E7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002DE RID: 734
		// (add) Token: 0x06006E3D RID: 28221 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006E3E RID: 28222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DE")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006E3D")]
			[Address(RVA = "0xB8E8", Offset = "0xB8E8", VA = "0xB8E8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E3E")]
			[Address(RVA = "0xB8E9", Offset = "0xB8E9", VA = "0xB8E9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700165C")]
		public IPlatformConfigurationProvider Provider
		{
			[Token(Token = "0x6006E3F")]
			[Address(RVA = "0xB8EA", Offset = "0xB8EA", VA = "0xB8EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E40")]
			[Address(RVA = "0xB8EB", Offset = "0xB8EB", VA = "0xB8EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E42 RID: 28226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700165D")]
		public IApp Application
		{
			[Token(Token = "0x6006E41")]
			[Address(RVA = "0xB8EC", Offset = "0xB8EC", VA = "0xB8EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E42")]
			[Address(RVA = "0xB8ED", Offset = "0xB8ED", VA = "0xB8ED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E43")]
		[Address(RVA = "0xB8EE", Offset = "0xB8EE", VA = "0xB8EE")]
		public ConfigurationManager(App application)
		{
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E44")]
		[Address(RVA = "0xB8EF", Offset = "0xB8EF", VA = "0xB8EF", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E45")]
		[Address(RVA = "0xB8F0", Offset = "0xB8F0", VA = "0xB8F0", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E46")]
		[Address(RVA = "0xB8F1", Offset = "0xB8F1", VA = "0xB8F1")]
		private void HandleConfigurationProvider(IPlatformConfigurationProvider provider)
		{
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E47")]
		[Address(RVA = "0xB8F2", Offset = "0xB8F2", VA = "0xB8F2")]
		private void HandleCuratorCompleteEvent(ICuratorDataProvider provider)
		{
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E48")]
		[Address(RVA = "0xB8F3", Offset = "0xB8F3", VA = "0xB8F3")]
		private void HandleForAnalyticCuratorCompleteEvent(ICuratorDataProvider obj)
		{
		}
	}
}
