using System;
using Core.Application.Managers.Configuration.Curator;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Configuration
{
	// Token: 0x02001232 RID: 4658
	[Token(Token = "0x2001232")]
	public interface IPlatformConfigurationProvider : IDisposable
	{
		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06006E4D RID: 28237
		[Token(Token = "0x1700165E")]
		ConfigRecord Config { [Token(Token = "0x6006E4D")] get; }

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06006E4E RID: 28238
		[Token(Token = "0x1700165F")]
		LaunchAppVars LaunchAppVars { [Token(Token = "0x6006E4E")] get; }

		// Token: 0x06006E4F RID: 28239
		[Token(Token = "0x6006E4F")]
		UniTask<IPlatformConfigurationProvider> UpdateLaunchAppVars();

		// Token: 0x06006E50 RID: 28240
		[Token(Token = "0x6006E50")]
		void SetCurator(ICuratorDataProvider value);

		// Token: 0x06006E51 RID: 28241
		[Token(Token = "0x6006E51")]
		void SetAuthData(AuthData value);

		// Token: 0x06006E52 RID: 28242
		[Token(Token = "0x6006E52")]
		bool TryGetCurator(out ICuratorDataProvider curator);
	}
}
