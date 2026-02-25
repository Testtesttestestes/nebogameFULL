using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001055 RID: 4181
	[Token(Token = "0x2001055")]
	public static class ExpectedErrorsHandler
	{
		// Token: 0x06006231 RID: 25137 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6006231")]
		[Address(RVA = "0xAE5C", Offset = "0xAE5C", VA = "0xAE5C")]
		private static bool InternalHandler(int errorCode, Type[] errorTypes, params KeyValuePair<Type, object>[] errorsArgs)
		{
			return default(bool);
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x6006232")]
		public static bool HandleErrorChain<E1>(int errorCode, [Optional] object errorArg) where E1 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6006233")]
		public static bool HandleErrorChain<E1, E2>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x6006234")]
		public static bool HandleErrorChain<E1, E2, E3>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2, [Optional] object errorArg3) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new() where E3 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x6006235")]
		public static bool HandleErrorChain<E1, E2, E3, E4>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2, [Optional] object errorArg3, [Optional] object errorArg4) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new() where E3 : ExpectedDefaultError, new() where E4 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6006236")]
		public static bool HandleErrorChain<E1, E2, E3, E4, E5>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2, [Optional] object errorArg3, [Optional] object errorArg4, [Optional] object errorArg5) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new() where E3 : ExpectedDefaultError, new() where E4 : ExpectedDefaultError, new() where E5 : ExpectedDefaultError, new()
		{
			return default(bool);
		}
	}
}
