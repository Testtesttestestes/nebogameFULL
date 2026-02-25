using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001355 RID: 4949
	[Token(Token = "0x2001355")]
	public class SpecializationManager : BaseSpecializationManager
	{
		// Token: 0x06007584 RID: 30084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007584")]
		[Address(RVA = "0xBF14", Offset = "0xBF14", VA = "0xBF14")]
		private SpecializationManager()
		{
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007585")]
		[Address(RVA = "0xBF15", Offset = "0xBF15", VA = "0xBF15")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007586")]
		[Address(RVA = "0xBF16", Offset = "0xBF16", VA = "0xBF16")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007587")]
		[Address(RVA = "0xBF17", Offset = "0xBF17", VA = "0xBF17")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007588")]
		[Address(RVA = "0xBF18", Offset = "0xBF18", VA = "0xBF18")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007589")]
		[Address(RVA = "0xBF19", Offset = "0xBF19", VA = "0xBF19")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}

		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;
	}
}
