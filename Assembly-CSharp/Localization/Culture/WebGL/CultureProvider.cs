using System;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using UnityEngine;

namespace Localization.Culture.WebGL
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	public class CultureProvider : BaseCultureProvider
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x23A0", Offset = "0x23A0", VA = "0x23A0")]
		public CultureProvider(IPlatformConfigurationProvider configurationProvider)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5B71", Offset = "0x5B71", VA = "0x5B71")]
		private static SystemLanguage LocaleToSystemLang(string locale)
		{
			return SystemLanguage.Afrikaans;
		}
	}
}
