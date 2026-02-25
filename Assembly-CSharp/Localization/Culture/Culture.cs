using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Localization.Culture
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public static class Culture
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DB")]
		public static BaseCultureProvider Provider
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x5B6C", Offset = "0x5B6C", VA = "0x5B6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x5B6D", Offset = "0x5B6D", VA = "0x5B6D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x5B6E", Offset = "0x5B6E", VA = "0x5B6E")]
		public static UniTask Initialization()
		{
			return default(UniTask);
		}

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isInitialized;
	}
}
