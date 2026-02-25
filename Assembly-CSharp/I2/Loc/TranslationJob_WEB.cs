using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001366 RID: 4966
	[Token(Token = "0x2001366")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		// Token: 0x060075D9 RID: 30169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D9")]
		[Address(RVA = "0xBF62", Offset = "0xBF62", VA = "0xBF62")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DA")]
		[Address(RVA = "0xBF63", Offset = "0xBF63", VA = "0xBF63")]
		private void FindAllQueries()
		{
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DB")]
		[Address(RVA = "0xBF64", Offset = "0xBF64", VA = "0xBF64")]
		private void ExecuteNextBatch()
		{
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x60075DC")]
		[Address(RVA = "0xBF65", Offset = "0xBF65", VA = "0xBF65", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DD")]
		[Address(RVA = "0xBF66", Offset = "0xBF66", VA = "0xBF66")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075DE")]
		[Address(RVA = "0xBF67", Offset = "0xBF67", VA = "0xBF67")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}

		// Token: 0x04003D8E RID: 15758
		[Token(Token = "0x4003D8E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D8F RID: 15759
		[Token(Token = "0x4003D8F")]
		[FieldOffset(Offset = "0x14")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04003D90 RID: 15760
		[Token(Token = "0x4003D90")]
		[FieldOffset(Offset = "0x18")]
		public string mErrorMessage;

		// Token: 0x04003D91 RID: 15761
		[Token(Token = "0x4003D91")]
		[FieldOffset(Offset = "0x1C")]
		private string mCurrentBatch_ToLanguageCode;

		// Token: 0x04003D92 RID: 15762
		[Token(Token = "0x4003D92")]
		[FieldOffset(Offset = "0x20")]
		private string mCurrentBatch_FromLanguageCode;

		// Token: 0x04003D93 RID: 15763
		[Token(Token = "0x4003D93")]
		[FieldOffset(Offset = "0x24")]
		private List<string> mCurrentBatch_Text;

		// Token: 0x04003D94 RID: 15764
		[Token(Token = "0x4003D94")]
		[FieldOffset(Offset = "0x28")]
		private List<KeyValuePair<string, string>> mQueries;
	}
}
