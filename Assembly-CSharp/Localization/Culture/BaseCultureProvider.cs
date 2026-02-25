using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Localization.Culture
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public abstract class BaseCultureProvider
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		public SystemLanguage Language
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x5B66", Offset = "0x5B66", VA = "0x5B66")]
			[CompilerGenerated]
			get
			{
				return SystemLanguage.Afrikaans;
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x5B67", Offset = "0x5B67", VA = "0x5B67")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5B68", Offset = "0x5B68", VA = "0x5B68")]
		protected BaseCultureProvider(SystemLanguage language)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5B69", Offset = "0x5B69", VA = "0x5B69", Slot = "4")]
		public virtual void SetLanguage(SystemLanguage value)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1AEA", Offset = "0x1AEA", VA = "0x1AEA")]
		public CultureInfo GetCulture()
		{
			return null;
		}
	}
}
