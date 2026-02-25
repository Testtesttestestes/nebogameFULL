using System;
using System.Globalization;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Protocol.Consts;
using Utils;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x02001273 RID: 4723
	[Token(Token = "0x2001273")]
	public class CuratorService : AbstractHTTPService
	{
		// Token: 0x06007015 RID: 28693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007015")]
		[Address(RVA = "0xBA62", Offset = "0xBA62", VA = "0xBA62")]
		public CuratorService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007016")]
		[Address(RVA = "0xBA63", Offset = "0xBA63", VA = "0xBA63")]
		private void BootInternal(OpToken<CuratorJsonMessages.BootAns, HTTPResponse> token, ClientPlatform platform, CultureInfo cultureInfo)
		{
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007017")]
		[Address(RVA = "0xBA64", Offset = "0xBA64", VA = "0xBA64")]
		public OpToken<CuratorJsonMessages.BootAns, HTTPResponse> Boot(ClientPlatform platform, CultureInfo cultureInfo)
		{
			return null;
		}
	}
}
