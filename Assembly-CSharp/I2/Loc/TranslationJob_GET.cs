using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001363 RID: 4963
	[Token(Token = "0x2001363")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		// Token: 0x060075CF RID: 30159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CF")]
		[Address(RVA = "0xBF58", Offset = "0xBF58", VA = "0xBF58")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D0")]
		[Address(RVA = "0xBF59", Offset = "0xBF59", VA = "0xBF59")]
		private void ExecuteNextQuery()
		{
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x60075D1")]
		[Address(RVA = "0xBF5A", Offset = "0xBF5A", VA = "0xBF5A", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D2")]
		[Address(RVA = "0xBF5B", Offset = "0xBF5B", VA = "0xBF5B")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		// Token: 0x04003D82 RID: 15746
		[Token(Token = "0x4003D82")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D83 RID: 15747
		[Token(Token = "0x4003D83")]
		[FieldOffset(Offset = "0x14")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04003D84 RID: 15748
		[Token(Token = "0x4003D84")]
		[FieldOffset(Offset = "0x18")]
		private List<string> mQueries;

		// Token: 0x04003D85 RID: 15749
		[Token(Token = "0x4003D85")]
		[FieldOffset(Offset = "0x1C")]
		public string mErrorMessage;
	}
}
