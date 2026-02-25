using System;
using Core.Gameplay;
using Gameplay.Billing.Events;
using Il2CppDummyDll;
using JetBrains.Annotations;
using OKG.Currencies;

namespace Gameplay.Billing.Controller
{
	// Token: 0x02000BFE RID: 3070
	[Token(Token = "0x2000BFE")]
	public interface IControllerFactory
	{
		// Token: 0x06004B2D RID: 19245
		[Token(Token = "0x6004B2D")]
		AbstractBillingController Create([NotNull] IAuthTokenSource authTokenSource, [NotNull] IGame game, [NotNull] BillingEvents events, [NotNull] CurrencyConverter currencyConverter);
	}
}
