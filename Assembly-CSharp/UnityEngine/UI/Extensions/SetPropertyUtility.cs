using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	internal static class SetPropertyUtility
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5640", Offset = "0x5640", VA = "0x5640")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600017C")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600017D")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}
}
