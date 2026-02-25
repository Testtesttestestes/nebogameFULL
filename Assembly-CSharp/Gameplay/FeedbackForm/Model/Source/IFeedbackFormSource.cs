using System;
using Core.Application.Managers;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.FeedbackForm.Model.Source
{
	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	public interface IFeedbackFormSource : IDisposable
	{
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003113 RID: 12563
		[Token(Token = "0x170009A0")]
		Themes[] Themes { [Token(Token = "0x6003113")] get; }

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003114 RID: 12564
		[Token(Token = "0x170009A1")]
		Themes DefaultTheme { [Token(Token = "0x6003114")] get; }

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003115 RID: 12565
		[Token(Token = "0x170009A2")]
		uint RequiredFormFields { [Token(Token = "0x6003115")] get; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003116 RID: 12566
		[Token(Token = "0x170009A3")]
		[NotNull]
		Uri Endpoint { [Token(Token = "0x6003116")] get; }

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003117 RID: 12567
		[Token(Token = "0x170009A4")]
		[NotNull]
		IPlatformConfigurationProvider ConfigurationProvider { [Token(Token = "0x6003117")] get; }

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003118 RID: 12568
		[Token(Token = "0x170009A5")]
		[NotNull]
		IClientVersionProvider ClientVersionProvider { [Token(Token = "0x6003118")] get; }

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003119 RID: 12569
		[Token(Token = "0x170009A6")]
		[CanBeNull]
		IPlatformSigninProvider SigninProvider { [Token(Token = "0x6003119")] get; }

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600311A RID: 12570
		[Token(Token = "0x170009A7")]
		[CanBeNull]
		IAuthDataProvider AuthDataProvider { [Token(Token = "0x600311A")] get; }
	}
}
