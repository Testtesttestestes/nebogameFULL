using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers.Configuration.Curator;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Gameplay.Managers.Configuration
{
	// Token: 0x0200122D RID: 4653
	[Token(Token = "0x200122D")]
	public abstract class AbstractPlatformConfigurationProvider : IPlatformConfigurationProvider, IDisposable
	{
		// Token: 0x06006E2D RID: 28205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E2D")]
		[Address(RVA = "0xB8DD", Offset = "0xB8DD", VA = "0xB8DD", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001659")]
		public ConfigRecord Config
		{
			[Token(Token = "0x6006E2E")]
			[Address(RVA = "0xB8DE", Offset = "0xB8DE", VA = "0xB8DE", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06006E2F RID: 28207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E30 RID: 28208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700165A")]
		public LaunchAppVars LaunchAppVars
		{
			[Token(Token = "0x6006E2F")]
			[Address(RVA = "0xB8DF", Offset = "0xB8DF", VA = "0xB8DF", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E30")]
			[Address(RVA = "0xB8E0", Offset = "0xB8E0", VA = "0xB8E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E31")]
		[Address(RVA = "0xB8E1", Offset = "0xB8E1", VA = "0xB8E1", Slot = "7")]
		public void SetCurator(ICuratorDataProvider value)
		{
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E32")]
		[Address(RVA = "0xB8E2", Offset = "0xB8E2", VA = "0xB8E2", Slot = "8")]
		public void SetAuthData([NotNull] AuthData value)
		{
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x6006E33")]
		[Address(RVA = "0xB8E3", Offset = "0xB8E3", VA = "0xB8E3", Slot = "9")]
		public bool TryGetCurator(out ICuratorDataProvider curator)
		{
			return default(bool);
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E34")]
		[Address(RVA = "0x2395", Offset = "0x2395", VA = "0x2395")]
		protected void Complete(ConfigRecord configRecord, LaunchAppVars launchAppVars)
		{
		}

		// Token: 0x06006E35 RID: 28213
		[Token(Token = "0x6006E35")]
		public abstract UniTask<IPlatformConfigurationProvider> Run();

		// Token: 0x06006E36 RID: 28214
		[Token(Token = "0x6006E36")]
		public abstract UniTask<IPlatformConfigurationProvider> UpdateLaunchAppVars();

		// Token: 0x06006E37 RID: 28215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E37")]
		[Address(RVA = "0x239E", Offset = "0x239E", VA = "0x239E")]
		protected AbstractPlatformConfigurationProvider()
		{
		}

		// Token: 0x0400399C RID: 14748
		[Token(Token = "0x400399C")]
		[FieldOffset(Offset = "0x8")]
		private ConfigRecord _config;

		// Token: 0x0400399D RID: 14749
		[Token(Token = "0x400399D")]
		[FieldOffset(Offset = "0xC")]
		private ICuratorDataProvider _curator;

		// Token: 0x0400399E RID: 14750
		[Token(Token = "0x400399E")]
		[FieldOffset(Offset = "0x10")]
		private Action<IPlatformConfigurationProvider> _callback;
	}
}
